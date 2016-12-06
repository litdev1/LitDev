using Box2DX.Collision;
using Box2DX.Common;
using LitDev.Engines;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Box2DX.Dynamics
{
	public class World : IDisposable
	{
		internal bool _lock;
		internal BroadPhase _broadPhase;
		private ContactManager _contactManager;
		private Body _bodyList;
		private Joint _jointList;
		private Vec2 _raycastNormal;
		private object _raycastUserData;
		private Segment _raycastSegment;
		private bool _raycastSolidShape;
		internal Contact _contactList;
		private int _bodyCount;
		internal int _contactCount;
		private int _jointCount;
		private Vec2 _gravity;
		private bool _allowSleep;
		private Body _groundBody;
		private DestructionListener _destructionListener;
		private BoundaryListener _boundaryListener;
		internal ContactFilter _contactFilter;
		internal ContactListener _contactListener;
		private DebugDraw _debugDraw;
		private float _inv_dt0;
		private bool _warmStarting;
		private bool _continuousPhysics;
		public Vec2 Gravity
		{
			get
			{
				return this._gravity;
			}
			set
			{
				this._gravity = value;
			}
		}
		public World(AABB worldAABB, Vec2 gravity, bool doSleep)
		{
			this._destructionListener = null;
			this._boundaryListener = null;
			this._contactFilter = WorldCallback.DefaultFilter;
			this._contactListener = null;
			this._debugDraw = null;
			this._bodyList = null;
			this._contactList = null;
			this._jointList = null;
			this._bodyCount = 0;
			this._contactCount = 0;
			this._jointCount = 0;
			this._warmStarting = true;
			this._continuousPhysics = true;
			this._allowSleep = doSleep;
			this._gravity = gravity;
			this._lock = false;
			this._inv_dt0 = 0f;
			this._contactManager = new ContactManager();
			this._contactManager._world = this;
			this._broadPhase = new BroadPhase(worldAABB, this._contactManager);
			BodyDef def = new BodyDef();
			this._groundBody = this.CreateBody(def);
		}
		public void Dispose()
		{
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                this.DestroyBody(this._groundBody);
                if (this._broadPhase is IDisposable)
                {
                    (this._broadPhase as IDisposable).Dispose();
                }
                this._broadPhase = null;
            }
            // free native resources if there are any.
        }
		public void SetDestructionListener(DestructionListener listener)
		{
			this._destructionListener = listener;
		}
		public void SetBoundaryListener(BoundaryListener listener)
		{
			this._boundaryListener = listener;
		}
		public void SetContactFilter(ContactFilter filter)
		{
			this._contactFilter = filter;
		}
		public void SetContactListener(ContactListener listener)
		{
			this._contactListener = listener;
		}
		public void SetDebugDraw(DebugDraw debugDraw)
		{
			this._debugDraw = debugDraw;
		}
		public Body CreateBody(BodyDef def)
		{
			Box2DXDebug.Assert(!this._lock);
			Body result;
			if (this._lock)
			{
				result = null;
			}
			else
			{
				Body body = new Body(def, this);
				body._prev = null;
				body._next = this._bodyList;
				if (this._bodyList != null)
				{
					this._bodyList._prev = body;
				}
				this._bodyList = body;
				this._bodyCount++;
				result = body;
			}
			return result;
		}
		public void DestroyBody(Body b)
		{
			Box2DXDebug.Assert(this._bodyCount > 0);
			Box2DXDebug.Assert(!this._lock);
			if (!this._lock)
			{
				JointEdge jointEdge = null;
				if (b._jointList != null)
				{
					jointEdge = b._jointList;
				}
				while (jointEdge != null)
				{
					JointEdge jointEdge2 = jointEdge;
					jointEdge = jointEdge.Next;
					if (this._destructionListener != null)
					{
						this._destructionListener.SayGoodbye(jointEdge2.Joint);
					}
					this.DestroyJoint(jointEdge2.Joint);
				}
				Shape shape = null;
				if (b._shapeList != null)
				{
					shape = b._shapeList;
				}
				while (shape != null)
				{
					Shape shape2 = shape;
					shape = shape._next;
					if (this._destructionListener != null)
					{
						this._destructionListener.SayGoodbye(shape2);
					}
					shape2.DestroyProxy(this._broadPhase);
					Shape.Destroy(shape2);
				}
				if (b._prev != null)
				{
					b._prev._next = b._next;
				}
				if (b._next != null)
				{
					b._next._prev = b._prev;
				}
				if (b == this._bodyList)
				{
					this._bodyList = b._next;
				}
				this._bodyCount--;
				if (b != null)
				{
					((IDisposable)b).Dispose();
				}
				b = null;
			}
		}
		public Joint CreateJoint(JointDef def)
		{
			Box2DXDebug.Assert(!this._lock);
			Joint joint = Joint.Create(def);
			joint._prev = null;
			joint._next = this._jointList;
			if (this._jointList != null)
			{
				this._jointList._prev = joint;
			}
			this._jointList = joint;
			this._jointCount++;
			joint._node1.Joint = joint;
			joint._node1.Other = joint._body2;
			joint._node1.Prev = null;
			joint._node1.Next = joint._body1._jointList;
			if (joint._body1._jointList != null)
			{
				joint._body1._jointList.Prev = joint._node1;
			}
			joint._body1._jointList = joint._node1;
			joint._node2.Joint = joint;
			joint._node2.Other = joint._body1;
			joint._node2.Prev = null;
			joint._node2.Next = joint._body2._jointList;
			if (joint._body2._jointList != null)
			{
				joint._body2._jointList.Prev = joint._node2;
			}
			joint._body2._jointList = joint._node2;
			if (!def.CollideConnected)
			{
				Body body = (def.Body1._shapeCount < def.Body2._shapeCount) ? def.Body1 : def.Body2;
				for (Shape shape = body._shapeList; shape != null; shape = shape._next)
				{
					shape.RefilterProxy(this._broadPhase, body.GetXForm());
				}
			}
			return joint;
		}
		public void DestroyJoint(Joint j)
		{
			Box2DXDebug.Assert(!this._lock);
			bool collideConnected = j._collideConnected;
			if (j._prev != null)
			{
				j._prev._next = j._next;
			}
			if (j._next != null)
			{
				j._next._prev = j._prev;
			}
			if (j == this._jointList)
			{
				this._jointList = j._next;
			}
			Body body = j._body1;
			Body body2 = j._body2;
			body.WakeUp();
			body2.WakeUp();
			if (j._node1.Prev != null)
			{
				j._node1.Prev.Next = j._node1.Next;
			}
			if (j._node1.Next != null)
			{
				j._node1.Next.Prev = j._node1.Prev;
			}
			if (j._node1 == body._jointList)
			{
				body._jointList = j._node1.Next;
			}
			j._node1.Prev = null;
			j._node1.Next = null;
			if (j._node2.Prev != null)
			{
				j._node2.Prev.Next = j._node2.Next;
			}
			if (j._node2.Next != null)
			{
				j._node2.Next.Prev = j._node2.Prev;
			}
			if (j._node2 == body2._jointList)
			{
				body2._jointList = j._node2.Next;
			}
			j._node2.Prev = null;
			j._node2.Next = null;
			Joint.Destroy(j);
			Box2DXDebug.Assert(this._jointCount > 0);
			this._jointCount--;
			if (!collideConnected)
			{
				Body body3 = (body._shapeCount < body2._shapeCount) ? body : body2;
				for (Shape shape = body3._shapeList; shape != null; shape = shape._next)
				{
					shape.RefilterProxy(this._broadPhase, body3.GetXForm());
				}
			}
		}
		public Body GetGroundBody()
		{
			return this._groundBody;
		}
		public Body GetBodyList()
		{
			return this._bodyList;
		}
		public Joint GetJointList()
		{
			return this._jointList;
		}
		public void Refilter(Shape shape)
		{
			Box2DXDebug.Assert(!this._lock);
			shape.RefilterProxy(this._broadPhase, shape.GetBody().GetXForm());
		}
		public void SetWarmStarting(bool flag)
		{
			this._warmStarting = flag;
		}
		public void SetContinuousPhysics(bool flag)
		{
			this._continuousPhysics = flag;
		}
		public void Validate()
		{
			this._broadPhase.Validate();
		}
		public int GetProxyCount()
		{
			return this._broadPhase._proxyCount;
		}
		public int GetPairCount()
		{
			return this._broadPhase._pairManager._pairCount;
		}
		public int GetBodyCount()
		{
			return this._bodyCount;
		}
		public int GetJointCount()
		{
			return this._jointCount;
		}
		public int GetContactCount()
		{
			return this._contactCount;
		}
		public void Step(float dt, int velocityIterations, int positionIteration)
		{
			this._lock = true;
			TimeStep step = default(TimeStep);
			step.Dt = dt;
			step.VelocityIterations = velocityIterations;
			step.PositionIterations = positionIteration;
			if (dt > 0f)
			{
				step.Inv_Dt = 1f / dt;
			}
			else
			{
				step.Inv_Dt = 0f;
			}
			step.DtRatio = this._inv_dt0 * dt;
			step.WarmStarting = this._warmStarting;
			this._contactManager.Collide();
			if (step.Dt > 0f)
			{
				this.Solve(step);
			}
			if (this._continuousPhysics && step.Dt > 0f)
			{
				this.SolveTOI(step);
			}
			this.DrawDebugData();
			this._inv_dt0 = step.Inv_Dt;
			this._lock = false;
		}
		public int Query(AABB aabb, Shape[] shapes, int maxCount)
		{
			object[] array = new object[maxCount];
			int num = this._broadPhase.Query(aabb, array, maxCount);
			for (int i = 0; i < num; i++)
			{
				shapes[i] = (Shape)array[i];
			}
			return num;
		}
		public int Raycast(Segment segment, Shape[] shapes, int maxCount, bool solidShapes, object userData)
		{
			this._raycastSegment = segment;
			this._raycastUserData = userData;
			this._raycastSolidShape = solidShapes;
			object[] array = new object[maxCount];
			int num = this._broadPhase.QuerySegment(segment, array, maxCount, new SortKeyFunc(World.RaycastSortKey));
			for (int i = 0; i < num; i++)
			{
				shapes[i] = (Shape)array[i];
			}
			return num;
		}
		public Shape RaycastOne(Segment segment, out float lambda, out Vec2 normal, bool solidShapes, object userData)
		{
			lambda = 0f;
			normal = new Vec2(0f, 0f);
			int num = 1;
			Shape[] array = new Shape[num];
			int num2 = this.Raycast(segment, array, num, solidShapes, userData);
			Shape result;
			if (num2 == 0)
			{
				result = null;
			}
			else
			{
				Box2DXDebug.Assert(num2 == 1);
				XForm xForm = array[0].GetBody().GetXForm();
				array[0].TestSegment(xForm, out lambda, out normal, segment, 1f);
				result = array[0];
			}
			return result;
		}
		private void Solve(TimeStep step)
		{
			Island island = new Island(this._bodyCount, this._contactCount, this._jointCount, this._contactListener);
			for (Body body = this._bodyList; body != null; body = body._next)
			{
				body._flags &= ~Body.BodyFlags.Island;
			}
			for (Contact contact = this._contactList; contact != null; contact = contact._next)
			{
				contact._flags &= ~Contact.CollisionFlags.Island;
			}
			for (Joint joint = this._jointList; joint != null; joint = joint._next)
			{
				joint._islandFlag = false;
			}
			int bodyCount = this._bodyCount;
			Body[] array = new Body[bodyCount];
			for (Body body2 = this._bodyList; body2 != null; body2 = body2._next)
			{
				if ((body2._flags & (Body.BodyFlags.Frozen | Body.BodyFlags.Island | Body.BodyFlags.Sleep)) == (Body.BodyFlags)0)
				{
					if (!body2.IsStatic())
					{
						island.Clear();
						int i = 0;
						array[i++] = body2;
						body2._flags |= Body.BodyFlags.Island;
						while (i > 0)
						{
							Body body = array[--i];
							island.Add(body);
							body._flags &= ~Body.BodyFlags.Sleep;
							if (!body.IsStatic())
							{
								for (ContactEdge contactEdge = body._contactList; contactEdge != null; contactEdge = contactEdge.Next)
								{
									if ((contactEdge.Contact._flags & (Contact.CollisionFlags.NonSolid | Contact.CollisionFlags.Island)) == (Contact.CollisionFlags)0)
									{
										if (contactEdge.Contact.GetManifoldCount() != 0)
										{
											island.Add(contactEdge.Contact);
											contactEdge.Contact._flags |= Contact.CollisionFlags.Island;
											Body other = contactEdge.Other;
											if ((other._flags & Body.BodyFlags.Island) == (Body.BodyFlags)0)
											{
												Box2DXDebug.Assert(i < bodyCount);
												array[i++] = other;
												other._flags |= Body.BodyFlags.Island;
											}
										}
									}
								}
								for (JointEdge jointEdge = body._jointList; jointEdge != null; jointEdge = jointEdge.Next)
								{
									if (!jointEdge.Joint._islandFlag)
									{
										island.Add(jointEdge.Joint);
										jointEdge.Joint._islandFlag = true;
										Body other = jointEdge.Other;
										if ((other._flags & Body.BodyFlags.Island) == (Body.BodyFlags)0)
										{
											Box2DXDebug.Assert(i < bodyCount);
											array[i++] = other;
											other._flags |= Body.BodyFlags.Island;
										}
									}
								}
							}
						}
						island.Solve(step, this._gravity, this._allowSleep);
						for (int j = 0; j < island._bodyCount; j++)
						{
							Body body = island._bodies[j];
							if (body.IsStatic())
							{
								body._flags &= ~Body.BodyFlags.Island;
							}
						}
					}
				}
			}
			for (Body body = this._bodyList; body != null; body = body.GetNext())
			{
				if ((body._flags & (Body.BodyFlags.Frozen | Body.BodyFlags.Sleep)) == (Body.BodyFlags)0)
				{
					if (!body.IsStatic())
					{
						if (!body.SynchronizeShapes() && this._boundaryListener != null)
						{
							this._boundaryListener.Violation(body);
						}
					}
				}
			}
			this._broadPhase.Commit();
		}
		private void SolveTOI(TimeStep step)
		{
			Island island = new Island(this._bodyCount, Settings.MaxTOIContactsPerIsland, Settings.MaxTOIJointsPerIsland, this._contactListener);
			int bodyCount = this._bodyCount;
			Body[] array = new Body[bodyCount];
			for (Body body = this._bodyList; body != null; body = body._next)
			{
				body._flags &= ~Body.BodyFlags.Island;
				body._sweep.T0 = 0f;
			}
			for (Contact contact = this._contactList; contact != null; contact = contact._next)
			{
				contact._flags &= ~(Contact.CollisionFlags.Island | Contact.CollisionFlags.Toi);
			}
			while (true)
			{
				Contact contact2 = null;
				float num = 1f;
				for (Contact contact = this._contactList; contact != null; contact = contact._next)
				{
					if ((contact._flags & (Contact.CollisionFlags.NonSolid | Contact.CollisionFlags.Slow)) == (Contact.CollisionFlags)0)
					{
						float num2 = 1f;
						if ((contact._flags & Contact.CollisionFlags.Toi) != (Contact.CollisionFlags)0)
						{
							num2 = contact._toi;
						}
						else
						{
							Shape shape = contact.GetShape1();
							Shape shape2 = contact.GetShape2();
							Body body2 = shape.GetBody();
							Body body3 = shape2.GetBody();
							if ((body2.IsStatic() || body2.IsSleeping()) && (body3.IsStatic() || body3.IsSleeping()))
							{
								goto IL_2B4;
							}
							float t = body2._sweep.T0;
							if (body2._sweep.T0 < body3._sweep.T0)
							{
								t = body3._sweep.T0;
								body2._sweep.Advance(t);
							}
							else
							{
								if (body3._sweep.T0 < body2._sweep.T0)
								{
									t = body2._sweep.T0;
									body3._sweep.Advance(t);
								}
							}
							Box2DXDebug.Assert(t < 1f);
                            num2 = Collision.Collision.TimeOfImpact(contact._shape1, body2._sweep, contact._shape2, body3._sweep);
							Box2DXDebug.Assert(0f <= num2 && num2 <= 1f);
							if (num2 > 0f && num2 < 1f)
							{
								num2 = Box2DX.Common.Math.Min((1f - num2) * t + num2, 1f);
							}
							contact._toi = num2;
							contact._flags |= Contact.CollisionFlags.Toi;
						}
						if (Settings.FLT_EPSILON < num2 && num2 < num)
						{
							contact2 = contact;
							num = num2;
						}
					}
					IL_2B4:;
				}
				if (contact2 == null || 1f - 100f * Settings.FLT_EPSILON < num)
				{
					break;
				}
				Shape shape3 = contact2.GetShape1();
				Shape shape4 = contact2.GetShape2();
				Body body4 = shape3.GetBody();
				Body body5 = shape4.GetBody();
				body4.Advance(num);
				body5.Advance(num);
				contact2.Update(this._contactListener);
				contact2._flags &= ~Contact.CollisionFlags.Toi;
				if (contact2.GetManifoldCount() != 0)
				{
					Body body6 = body4;
					if (body6.IsStatic())
					{
						body6 = body5;
					}
					island.Clear();
					int num3 = 0;
					int i = 0;
					array[num3 + i++] = body6;
					body6._flags |= Body.BodyFlags.Island;
					while (i > 0)
					{
						Body body = array[num3++];
						i--;
						island.Add(body);
						body._flags &= ~Body.BodyFlags.Sleep;
						if (!body.IsStatic())
						{
							for (ContactEdge contactEdge = body._contactList; contactEdge != null; contactEdge = contactEdge.Next)
							{
								if (island._contactCount != island._contactCapacity)
								{
									if ((contactEdge.Contact._flags & (Contact.CollisionFlags.NonSolid | Contact.CollisionFlags.Slow | Contact.CollisionFlags.Island)) == (Contact.CollisionFlags)0)
									{
										if (contactEdge.Contact.GetManifoldCount() != 0)
										{
											island.Add(contactEdge.Contact);
											contactEdge.Contact._flags |= Contact.CollisionFlags.Island;
											Body other = contactEdge.Other;
											if ((other._flags & Body.BodyFlags.Island) == (Body.BodyFlags)0)
											{
												if (!other.IsStatic())
												{
													other.Advance(num);
													other.WakeUp();
												}
												Box2DXDebug.Assert(num3 + i < bodyCount);
												array[num3 + i++] = other;
												other._flags |= Body.BodyFlags.Island;
											}
										}
									}
								}
							}
						}
					}
					TimeStep timeStep = default(TimeStep);
					timeStep.WarmStarting = false;
					timeStep.Dt = (1f - num) * step.Dt;
					Box2DXDebug.Assert(timeStep.Dt > Settings.FLT_EPSILON);
					timeStep.Inv_Dt = 1f / timeStep.Dt;
					timeStep.VelocityIterations = step.VelocityIterations;
					timeStep.PositionIterations = step.PositionIterations;
					island.SolveTOI(ref timeStep);
					for (int j = 0; j < island._bodyCount; j++)
					{
						Body body = island._bodies[j];
						body._flags &= ~Body.BodyFlags.Island;
						if ((body._flags & (Body.BodyFlags.Frozen | Body.BodyFlags.Sleep)) == (Body.BodyFlags)0)
						{
							if (!body.IsStatic())
							{
								if (!body.SynchronizeShapes() && this._boundaryListener != null)
								{
									this._boundaryListener.Violation(body);
								}
								for (ContactEdge contactEdge = body._contactList; contactEdge != null; contactEdge = contactEdge.Next)
								{
									contactEdge.Contact._flags &= ~Contact.CollisionFlags.Toi;
								}
							}
						}
					}
					for (int j = 0; j < island._contactCount; j++)
					{
						Contact contact = island._contacts[j];
						contact._flags &= ~(Contact.CollisionFlags.Island | Contact.CollisionFlags.Toi);
					}
					for (int j = 0; j < island._jointCount; j++)
					{
						Joint joint = island._joints[j];
						joint._islandFlag = false;
					}
					this._broadPhase.Commit();
				}
			}
		}
		private void DrawJoint(Joint joint)
		{
			Body body = joint.GetBody1();
			Body body2 = joint.GetBody2();
			XForm xForm = body.GetXForm();
			XForm xForm2 = body2.GetXForm();
			Vec2 position = xForm.Position;
			Vec2 position2 = xForm2.Position;
			Vec2 anchor = joint.Anchor1;
			Vec2 anchor2 = joint.Anchor2;
			Color color = new Color(0.5f, 0.8f, 0.8f);
			switch (joint.GetType())
			{
				case JointType.DistanceJoint:
				{
					this._debugDraw.DrawSegment(anchor, anchor2, color);
					break;
				}
				case JointType.PulleyJoint:
				{
					PulleyJoint pulleyJoint = (PulleyJoint)joint;
					Vec2 groundAnchor = pulleyJoint.GroundAnchor1;
					Vec2 groundAnchor2 = pulleyJoint.GroundAnchor2;
					this._debugDraw.DrawSegment(groundAnchor, anchor, color);
					this._debugDraw.DrawSegment(groundAnchor2, anchor2, color);
					this._debugDraw.DrawSegment(groundAnchor, groundAnchor2, color);
					break;
				}
				case JointType.MouseJoint:
				{
					break;
				}
				default:
				{
					this._debugDraw.DrawSegment(position, anchor, color);
					this._debugDraw.DrawSegment(anchor, anchor2, color);
					this._debugDraw.DrawSegment(position2, anchor2, color);
					break;
				}
			}
		}
		private void DrawShape(Shape shape, XForm xf, Color color, bool core)
		{
			Color color2 = new Color(0.9f, 0.6f, 0.6f);
			switch (shape.GetType())
			{
				case ShapeType.CircleShape:
				{
					CircleShape circleShape = (CircleShape)shape;
					Vec2 center = Box2DX.Common.Math.Mul(xf, circleShape.GetLocalPosition());
					float radius = circleShape.GetRadius();
					Vec2 col = xf.R.Col1;
					this._debugDraw.DrawSolidCircle(center, radius, col, color);
					if (core)
					{
						this._debugDraw.DrawCircle(center, radius - Settings.ToiSlop, color2);
					}
					break;
				}
				case ShapeType.PolygonShape:
				{
					PolygonShape polygonShape = (PolygonShape)shape;
					int vertexCount = polygonShape.VertexCount;
					Vec2[] vertices = polygonShape.GetVertices();
					Box2DXDebug.Assert(vertexCount <= Settings.MaxPolygonVertices);
					Vec2[] array = new Vec2[Settings.MaxPolygonVertices];
					for (int i = 0; i < vertexCount; i++)
					{
						array[i] = Box2DX.Common.Math.Mul(xf, vertices[i]);
					}
					this._debugDraw.DrawSolidPolygon(array, vertexCount, color);
					if (core)
					{
						Vec2[] coreVertices = polygonShape.GetCoreVertices();
						for (int i = 0; i < vertexCount; i++)
						{
							array[i] = Box2DX.Common.Math.Mul(xf, coreVertices[i]);
						}
						this._debugDraw.DrawPolygon(array, vertexCount, color2);
					}
					break;
				}
			}
		}
		private void DrawDebugData()
		{
			if (this._debugDraw != null)
			{
				DebugDraw.DrawFlags flags = this._debugDraw.Flags;
				if ((flags & DebugDraw.DrawFlags.Shape) != (DebugDraw.DrawFlags)0)
				{
					bool core = (flags & DebugDraw.DrawFlags.CoreShape) == DebugDraw.DrawFlags.CoreShape;
					for (Body body = this._bodyList; body != null; body = body.GetNext())
					{
						XForm xForm = body.GetXForm();
						for (Shape shape = body.GetShapeList(); shape != null; shape = shape.GetNext())
						{
							if (body.IsStatic())
							{
								this.DrawShape(shape, xForm, new Color(0.5f, 0.9f, 0.5f), core);
							}
							else
							{
								if (body.IsSleeping())
								{
									this.DrawShape(shape, xForm, new Color(0.5f, 0.5f, 0.9f), core);
								}
								else
								{
									this.DrawShape(shape, xForm, new Color(0.9f, 0.9f, 0.9f), core);
								}
							}
						}
					}
				}
				if ((flags & DebugDraw.DrawFlags.Joint) != (DebugDraw.DrawFlags)0)
				{
					for (Joint joint = this._jointList; joint != null; joint = joint.GetNext())
					{
						if (joint.GetType() != JointType.MouseJoint)
						{
							this.DrawJoint(joint);
						}
					}
				}
				if ((flags & DebugDraw.DrawFlags.Pair) != (DebugDraw.DrawFlags)0)
				{
					BroadPhase broadPhase = this._broadPhase;
					Vec2 vec = default(Vec2);
					vec.Set(1f / broadPhase._quantizationFactor.X, 1f / broadPhase._quantizationFactor.Y);
					Color color = new Color(0.9f, 0.9f, 0.3f);
					for (int i = 0; i < PairManager.TableCapacity; i++)
					{
						Pair pair;
						for (ushort num = broadPhase._pairManager._hashTable[i]; num != PairManager.NullPair; num = pair.Next)
						{
							pair = broadPhase._pairManager._pairs[(int)num];
							Proxy proxy = broadPhase._proxyPool[(int)pair.ProxyId1];
							Proxy proxy2 = broadPhase._proxyPool[(int)pair.ProxyId2];
							AABB aABB = default(AABB);
							AABB aABB2 = default(AABB);
							aABB.LowerBound.X = broadPhase._worldAABB.LowerBound.X + vec.X * (float)broadPhase._bounds[0][(int)proxy.LowerBounds[0]].Value;
							aABB.LowerBound.Y = broadPhase._worldAABB.LowerBound.Y + vec.Y * (float)broadPhase._bounds[1][(int)proxy.LowerBounds[1]].Value;
							aABB.UpperBound.X = broadPhase._worldAABB.LowerBound.X + vec.X * (float)broadPhase._bounds[0][(int)proxy.UpperBounds[0]].Value;
							aABB.UpperBound.Y = broadPhase._worldAABB.LowerBound.Y + vec.Y * (float)broadPhase._bounds[1][(int)proxy.UpperBounds[1]].Value;
							aABB2.LowerBound.X = broadPhase._worldAABB.LowerBound.X + vec.X * (float)broadPhase._bounds[0][(int)proxy2.LowerBounds[0]].Value;
							aABB2.LowerBound.Y = broadPhase._worldAABB.LowerBound.Y + vec.Y * (float)broadPhase._bounds[1][(int)proxy2.LowerBounds[1]].Value;
							aABB2.UpperBound.X = broadPhase._worldAABB.LowerBound.X + vec.X * (float)broadPhase._bounds[0][(int)proxy2.UpperBounds[0]].Value;
							aABB2.UpperBound.Y = broadPhase._worldAABB.LowerBound.Y + vec.Y * (float)broadPhase._bounds[1][(int)proxy2.UpperBounds[1]].Value;
							Vec2 p = 0.5f * (aABB.LowerBound + aABB.UpperBound);
							Vec2 p2 = 0.5f * (aABB2.LowerBound + aABB2.UpperBound);
							this._debugDraw.DrawSegment(p, p2, color);
						}
					}
				}
				if ((flags & DebugDraw.DrawFlags.Aabb) != (DebugDraw.DrawFlags)0)
				{
					BroadPhase broadPhase = this._broadPhase;
					Vec2 lowerBound = broadPhase._worldAABB.LowerBound;
					Vec2 upperBound = broadPhase._worldAABB.UpperBound;
					Vec2 vec = default(Vec2);
					vec.Set(1f / broadPhase._quantizationFactor.X, 1f / broadPhase._quantizationFactor.Y);
					Color color = new Color(0.9f, 0.3f, 0.9f);
					for (int i = 0; i < Settings.MaxProxies; i++)
					{
						Proxy proxy3 = broadPhase._proxyPool[i];
						if (proxy3.IsValid)
						{
							AABB aABB3 = default(AABB);
							aABB3.LowerBound.X = lowerBound.X + vec.X * (float)broadPhase._bounds[0][(int)proxy3.LowerBounds[0]].Value;
							aABB3.LowerBound.Y = lowerBound.Y + vec.Y * (float)broadPhase._bounds[1][(int)proxy3.LowerBounds[1]].Value;
							aABB3.UpperBound.X = lowerBound.X + vec.X * (float)broadPhase._bounds[0][(int)proxy3.UpperBounds[0]].Value;
							aABB3.UpperBound.Y = lowerBound.Y + vec.Y * (float)broadPhase._bounds[1][(int)proxy3.UpperBounds[1]].Value;
							Vec2[] array = new Vec2[4];
							array[0].Set(aABB3.LowerBound.X, aABB3.LowerBound.Y);
							array[1].Set(aABB3.UpperBound.X, aABB3.LowerBound.Y);
							array[2].Set(aABB3.UpperBound.X, aABB3.UpperBound.Y);
							array[3].Set(aABB3.LowerBound.X, aABB3.UpperBound.Y);
							this._debugDraw.DrawPolygon(array, 4, color);
						}
					}
					Vec2[] array2 = new Vec2[4];
					array2[0].Set(lowerBound.X, lowerBound.Y);
					array2[1].Set(upperBound.X, lowerBound.Y);
					array2[2].Set(upperBound.X, upperBound.Y);
					array2[3].Set(lowerBound.X, upperBound.Y);
					this._debugDraw.DrawPolygon(array2, 4, new Color(0.3f, 0.9f, 0.9f));
				}
				if ((flags & DebugDraw.DrawFlags.Obb) != (DebugDraw.DrawFlags)0)
				{
					Color color = new Color(0.5f, 0.3f, 0.5f);
					for (Body body = this._bodyList; body != null; body = body.GetNext())
					{
						XForm xForm = body.GetXForm();
						for (Shape shape = body.GetShapeList(); shape != null; shape = shape.GetNext())
						{
							if (shape.GetType() == ShapeType.PolygonShape)
							{
								PolygonShape polygonShape = (PolygonShape)shape;
								OBB oBB = polygonShape.GetOBB();
								Vec2 extents = oBB.Extents;
								Vec2[] array2 = new Vec2[4];
								array2[0].Set(-extents.X, -extents.Y);
								array2[1].Set(extents.X, -extents.Y);
								array2[2].Set(extents.X, extents.Y);
								array2[3].Set(-extents.X, extents.Y);
								for (int i = 0; i < 4; i++)
								{
									array2[i] = oBB.Center + Box2DX.Common.Math.Mul(oBB.R, array2[i]);
									array2[i] = Box2DX.Common.Math.Mul(xForm, array2[i]);
								}
								this._debugDraw.DrawPolygon(array2, 4, color);
							}
						}
					}
				}
				if ((flags & DebugDraw.DrawFlags.CenterOfMass) != (DebugDraw.DrawFlags)0)
				{
					for (Body body = this._bodyList; body != null; body = body.GetNext())
					{
						XForm xForm = body.GetXForm();
						xForm.Position = body.GetWorldCenter();
						this._debugDraw.DrawXForm(xForm);
					}
				}
			}
		}
		private static float RaycastSortKey(object data)
		{
			Shape shape = data as Shape;
			Box2DXDebug.Assert(shape != null);
			Body body = shape.GetBody();
			World world = body.GetWorld();
			XForm xForm = body.GetXForm();
			float result;
			if (world._contactFilter != null && !world._contactFilter.RayCollide(world._raycastUserData, shape))
			{
				result = -1f;
			}
			else
			{
				float num;
				SegmentCollide segmentCollide = shape.TestSegment(xForm, out num, out world._raycastNormal, world._raycastSegment, 1f);
				if (world._raycastSolidShape && segmentCollide == SegmentCollide.MissCollide)
				{
					result = -1f;
				}
				else
				{
					if (!world._raycastSolidShape && segmentCollide != SegmentCollide.HitCollide)
					{
						result = -1f;
					}
					else
					{
						result = num;
					}
				}
			}
			return result;
		}
		public bool InRange(AABB aabb)
		{
			return this._broadPhase.InRange(aabb);
		}

        // STEVE
        public void SetJson(JsonWorld jsWorld)
        {
            jsWorld.gravity = new JsonVector(_gravity);
            jsWorld.allowSleep = _allowSleep;

            Sprite sprite;
            Dictionary<Body, int> bodies = new Dictionary<Body, int>();
            jsWorld.body = new List<JsonBody>();
            jsWorld.image = new List<JsonImage>();
            jsWorld.joint = new List<JsonJoint>();
            int iBody = 0;
            int iFixture = 0;
            int iJoint = 0;
            Body body = _bodyList;
            while (null != body._next) body = body._next;
            for (; body != null; body = body._prev)
            //for (Body body = _bodyList; body != null; body = body._next)
            {
                if (body._shapeCount == 0) continue;

                JsonBody jsBody = new JsonBody();
                jsWorld.body.Add(jsBody);

                bodies[body] = iBody;
                jsBody.name = "Body" + (iBody + 1);
                if (null != body.GetUserData() && body.GetUserData().GetType() == typeof(Sprite))
                {
                    sprite = (Sprite)body.GetUserData();
                    jsBody.name = sprite.name;
                }
                jsBody.type = body.Type == Body.BodyType.Static ? 0 : 2;
                jsBody.angle = body.GetAngle();
                jsBody.angularDamping = body._angularDamping;
                jsBody.angularVelocity = body.GetAngularVelocity();
                jsBody.awake = (body.Flags & Body.BodyFlags.Sleep) != Body.BodyFlags.Sleep;
                jsBody.bullet = (body.Flags & Body.BodyFlags.Bullet) == Body.BodyFlags.Bullet;
                jsBody.fixedRotation = (body.Flags & Body.BodyFlags.FixedRotation) == Body.BodyFlags.FixedRotation;
                jsBody.linearDamping = body._linearDamping;
                jsBody.linearVelocity = new JsonVector(body.GetLinearVelocity());
                jsBody.massData_mass = body.GetMass();
                jsBody.massData_center = new JsonVector(body.GetLocalCenter());
                jsBody.massData_I = body.GetInertia();
                jsBody.position = new JsonVector(body.GetPosition());

                jsBody.fixture = new List<JsonFixture>();
                int iFixtureCount = 0;
                for (Shape shape = body.GetShapeList(); shape != null; shape = shape.GetNext(), iFixtureCount++)
                {
                    JsonFixture jsFixture = new JsonFixture();
                    jsBody.fixture.Add(jsFixture);

                    jsFixture.name = iFixtureCount == 0 ? jsBody.name : "Fixture" + ++iFixture;
                    jsFixture.density = shape.Density;
                    jsFixture.filter_categoryBits = shape.FilterData.CategoryBits;
                    jsFixture.filter_maskBits = shape.FilterData.MaskBits;
                    jsFixture.filter_groupIndex = shape.FilterData.GroupIndex;
                    jsFixture.friction = shape.Friction;
                    jsFixture.restitution = shape.Restitution;
                    jsFixture.sensor = shape.IsSensor;
                    float angle = body.GetAngle();
                    if (shape.GetType() == ShapeType.CircleShape)
                    {
                        CircleShape circle = (CircleShape)shape;
                        Vec2 position = new Vec2(0, 0);
                        position.X += circle.GetLocalPosition().X * (float)System.Math.Cos(angle) - circle.GetLocalPosition().Y * (float)System.Math.Sin(angle);
                        position.Y += circle.GetLocalPosition().X * (float)System.Math.Sin(angle) + circle.GetLocalPosition().Y * (float)System.Math.Cos(angle);
                        jsFixture.circle = new JsonCircle(new JsonVector(position), circle.GetRadius());
                    }
                    else if (shape.GetType() == ShapeType.PolygonShape)
                    {
                        PolygonShape polygon = (PolygonShape)shape;
                        List<float> x = new List<float>();
                        List<float> y = new List<float>();
                        for (int i = 0; i < ((PolygonShape)shape).VertexCount; i++)
                        {
                            Vec2 position = new Vec2(0, 0);
                            position.X += polygon.GetVertices()[i].X * (float)System.Math.Cos(angle) - polygon.GetVertices()[i].Y * (float)System.Math.Sin(angle);
                            position.Y += polygon.GetVertices()[i].X * (float)System.Math.Sin(angle) + polygon.GetVertices()[i].Y * (float)System.Math.Cos(angle);
                            x.Add(position.X);
                            y.Add(position.Y);
                        }
                        jsFixture.polygon = new JsonPolygon(new JsonVectorArray(x, y));
                    }

                    if (null == shape.UserData || shape.UserData.GetType() != typeof(Sprite)) continue;
                    sprite = (Sprite)shape.UserData;
                    jsFixture.name = sprite.name;
                    if (!sprite.name.StartsWith("Image")) continue;

                    JsonImage image = new JsonImage();
                    jsWorld.image.Add(image);

                    image.name = sprite.name;
                    image.body = iBody;

                    Type GraphicsWindowType = typeof(GraphicsWindow);
                    Dictionary<string, UIElement> _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    UIElement obj;
                    if (!_objectsMap.TryGetValue(sprite.name, out obj)) continue;
                    if (obj.GetType() != typeof(Image)) continue;

                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        Image imageObj = (Image)obj;
                        BitmapSource img = (BitmapSource)imageObj.Source;
                        System.Drawing.Bitmap dImg = FastPixel.GetBitmap(img);
                        string fileName = Program.Directory + "\\" + sprite.name + ".png";
                        dImg.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        image.file = fileName;
                    });
                    FastThread.Invoke(ret);
                }
                iBody++;
                //jsBody.fixture.Reverse();
            }
            //Joint joint = _jointList;
            //while (null != joint._next) joint = joint._next;
            //for (; joint != null; joint = joint._prev)
            for (Joint joint = _jointList; joint != null; joint = joint._next)
            {
                JsonJoint jsJoint = new JsonJoint();

                switch (joint.GetType())
                {
                    case JointType.RevoluteJoint:
                        {
                            RevoluteJoint _joint = (RevoluteJoint)joint;
                            jsJoint.type = "revolute";
                            jsJoint.anchorA = new JsonVector(_joint.Anchor2);
                            jsJoint.anchorB = new JsonVector(_joint.Anchor1);
                            jsJoint.bodyA = bodies[_joint.GetBody2()];
                            jsJoint.bodyB = bodies[_joint.GetBody1()];
                            jsJoint.collideConnected = _joint._collideConnected;
                            jsJoint.enableLimit = _joint._enableLimit;
                            jsJoint.enableMotor = _joint._enableMotor;
                            jsJoint.jointSpeed = _joint.JointSpeed;
                            jsJoint.lowerLimit = _joint.LowerLimit;
                            jsJoint.maxMotorTorque = _joint.MotorTorque;
                            jsJoint.motorSpeed = _joint.MotorSpeed;
                            jsJoint.refAngle = _joint.JointAngle;
                            jsJoint.upperLimit = _joint.UpperLimit;
                            jsJoint.name = "Joint" + ++iJoint;
                            jsWorld.joint.Add(jsJoint);
                        }
                        break;
                    case JointType.DistanceJoint:
                        {
                            DistanceJoint _joint = (DistanceJoint)joint;
                            jsJoint.type = "distance";
                            jsJoint.anchorA = new JsonVector(_joint.Anchor2);
                            jsJoint.anchorB = new JsonVector(_joint.Anchor1);
                            jsJoint.bodyA = bodies[_joint.GetBody2()];
                            jsJoint.bodyB = bodies[_joint.GetBody1()];
                            jsJoint.collideConnected = _joint._collideConnected;
                            jsJoint.dampingRatio = _joint._dampingRatio;
                            jsJoint.frequency = _joint._frequencyHz;
                            jsJoint.length = _joint._length;
                            jsJoint.name = "Joint" + ++iJoint;
                            jsWorld.joint.Add(jsJoint);
                        }
                        break;
                    case JointType.PrismaticJoint:
                        {
                            PrismaticJoint _joint = (PrismaticJoint)joint;
                            jsJoint.type = "prismatic";
                            jsJoint.anchorA = new JsonVector(_joint.Anchor2);
                            jsJoint.anchorB = new JsonVector(_joint.Anchor1);
                            jsJoint.bodyA = bodies[_joint.GetBody2()];
                            jsJoint.bodyB = bodies[_joint.GetBody1()];
                            jsJoint.collideConnected = _joint._collideConnected;
                            jsJoint.enableLimit = _joint._enableLimit;
                            jsJoint.enableMotor = _joint._enableMotor;
                            jsJoint.localAxisA = new JsonVector(_joint._axis);
                            jsJoint.jointSpeed = _joint.JointSpeed;
                            jsJoint.lowerLimit = _joint.LowerLimit;
                            jsJoint.maxMotorForce = _joint.MotorForce;
                            jsJoint.motorSpeed = _joint.MotorSpeed;
                            jsJoint.refAngle = _joint._refAngle;
                            jsJoint.upperLimit = _joint.UpperLimit;
                            jsJoint.name = "Joint" + ++iJoint;
                            jsWorld.joint.Add(jsJoint);
                        }
                        break;
                    case JointType.GearJoint:
                        {
                            TextWindow.WriteLine("Gear joint is not implemented or the conversion is ambiguous");
                        }
                        break;
                    case JointType.LineJoint:
                        {
                            TextWindow.WriteLine("Line joint is not implemented or the conversion is ambiguous");
                        }
                        break;
                    case JointType.MouseJoint:
                        {
                            TextWindow.WriteLine("Mouse joint is not implemented or the conversion is ambiguous");
                        }
                        break;
                    case JointType.PulleyJoint:
                        {
                            TextWindow.WriteLine("Pulley joint is not implemented or the conversion is ambiguous");
                        }
                        break;
                }
            }
        }
    }
}
