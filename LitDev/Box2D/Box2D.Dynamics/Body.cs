using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class Body : IDisposable
	{
		[Flags]
		public enum BodyFlags
		{
			Frozen = 2,
			Island = 4,
			Sleep = 8,
			AllowSleep = 16,
			Bullet = 32,
			FixedRotation = 64
		}
		public enum BodyType
		{
			Static,
			Dynamic,
			MaxTypes
		}
		internal Body.BodyFlags _flags;
		private Body.BodyType _type;
		internal int _islandIndex;
		private XForm _xf;
		internal Sweep _sweep;
		internal Vec2 _linearVelocity;
		internal float _angularVelocity;
		internal Vec2 _force;
		internal float _torque;
		private World _world;
		internal Body _prev;
		internal Body _next;
		internal Shape _shapeList;
		internal int _shapeCount;
		internal JointEdge _jointList;
		internal ContactEdge _contactList;
		internal float _mass;
		internal float _invMass;
		private float _I;
		internal float _invI;
		internal float _linearDamping;
		internal float _angularDamping;
		internal float _sleepTime;
		private object _userData;
        internal Vec2 _gravity; // STEVE Added
        internal bool _useGravity; // STEVE Added
        internal Body(BodyDef bd, World world)
		{
			Box2DXDebug.Assert(!world._lock);
			this._flags = (Body.BodyFlags)0;
			if (bd.IsBullet)
			{
				this._flags |= Body.BodyFlags.Bullet;
			}
			if (bd.FixedRotation)
			{
				this._flags |= Body.BodyFlags.FixedRotation;
			}
			if (bd.AllowSleep)
			{
				this._flags |= Body.BodyFlags.AllowSleep;
			}
			if (bd.IsSleeping)
			{
				this._flags |= Body.BodyFlags.Sleep;
			}
			this._world = world;
			this._xf.Position = bd.Position;
			this._xf.R.Set(bd.Angle);
			this._sweep.LocalCenter = bd.MassData.Center;
			this._sweep.T0 = 1f;
			this._sweep.A0 = (this._sweep.A = bd.Angle);
			this._sweep.C0 = (this._sweep.C = Box2DX.Common.Math.Mul(this._xf, this._sweep.LocalCenter));
			this._jointList = null;
			this._contactList = null;
			this._prev = null;
			this._next = null;
			this._linearDamping = bd.LinearDamping;
			this._angularDamping = bd.AngularDamping;
			this._force.Set(0f, 0f);
			this._torque = 0f;
			this._linearVelocity.SetZero();
			this._angularVelocity = 0f;
			this._sleepTime = 0f;
			this._invMass = 0f;
			this._I = 0f;
			this._invI = 0f;
			this._mass = bd.MassData.Mass;
			if (this._mass > 0f)
			{
				this._invMass = 1f / this._mass;
			}
			if ((this._flags & Body.BodyFlags.FixedRotation) == (Body.BodyFlags)0)
			{
				this._I = bd.MassData.I;
			}
			if (this._I > 0f)
			{
				this._invI = 1f / this._I;
			}
			if (this._invMass == 0f && this._invI == 0f)
			{
				this._type = Body.BodyType.Static;
			}
			else
			{
				this._type = Body.BodyType.Dynamic;
			}
			this._userData = bd.UserData;
			this._shapeList = null;
			this._shapeCount = 0;
            this._gravity = _world.Gravity; // STEVE Added
            this._useGravity = false; // STEVE Added
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
                Box2DXDebug.Assert(!this._world._lock);
            }
            // free native resources if there are any.
        }
        public Shape CreateShape(ShapeDef shapeDef)
        {
            Box2DXDebug.Assert(!this._world._lock);
            Shape result;
            if (this._world._lock)
            {
                result = null;
            }
            else
            {
                Shape shape = Shape.Create(shapeDef);
                shape._next = this._shapeList;
                this._shapeList = shape;
                this._shapeCount++;
                shape._body = this;
                shape.CreateProxy(this._world._broadPhase, this._xf);
                shape.UpdateSweepRadius(this._sweep.LocalCenter);
                result = shape;
            }
            return result;
        }
        public void DestroyShape(Shape shape) // STEVE BUG if shape isn't first in list (last added) FIXED
		{
			Box2DXDebug.Assert(!this._world._lock);
			if (!this._world._lock)
			{
				Box2DXDebug.Assert(shape.GetBody() == this);
				shape.DestroyProxy(this._world._broadPhase);
				Box2DXDebug.Assert(this._shapeCount > 0);
				bool condition = false;
                if (shape == this._shapeList)
                {
                    this._shapeList = shape._next;
                    condition = true;
                }
                else
                {
                    Shape shape2 = this._shapeList;
                    Shape shapeLast = shape2;
                    while (shape2 != null)
                    {
                        if (shape2 == shape)
                        {
                            shapeLast._next = shape._next;
                            condition = true;
                            break;
                        }
                        shapeLast = shape2;
                        shape2 = shape2._next;
                    }
                }
				Box2DXDebug.Assert(condition);
				shape._body = null;
				shape._next = null;
				this._shapeCount--;
				Shape.Destroy(shape);
			}
		}
        public BodyType Type // STEVE Added
        {
            get { return this._type; }
            set
            {
                Box2DXDebug.Assert(!this._world._lock);
                if (!this._world._lock)
                {
                    this._type = value;
                    if (this._type == BodyType.Static)
                    {
                        this._mass = 0f;
                        this._invMass = 0f;
                        this._I = 0f;
                        this._invI = 0f;
                        this._linearVelocity.SetZero();
                        this._angularVelocity = 0f;
                        this._type = BodyType.Static;
                        this._flags |= Body.BodyFlags.FixedRotation;
                    }
                    else if (this._type == BodyType.Dynamic)
                    {
                        SetMassFromShapes();
                    }
                    for (Shape shape = this._shapeList; shape != null; shape = shape._next)
                    {
                        shape.RefilterProxy(this._world._broadPhase, this._xf);
                    }
                }
            }
        }
        public BodyFlags Flags // STEVE Added
        {
            get { return this._flags; }
            set 
            {
                Box2DXDebug.Assert(!this._world._lock);
                if (!this._world._lock)
                {
                    this._flags = value;
                    if (this._type == BodyType.Dynamic)
                    {
                        if ((_flags & BodyFlags.FixedRotation) == BodyFlags.FixedRotation)
                        {
                            this._I = 0f;
                            this._invI = 0f;
                            this._angularVelocity = 0f;
                        }
                        else
                        {
                            SetMassFromShapes();
                        }
                    }
                    else if (this._type == BodyType.Static)
                    {
                        if ((_flags & BodyFlags.FixedRotation) == BodyFlags.FixedRotation)
                        {
                            this._I = 0f;
                            this._invI = 0f;
                            this._angularVelocity = 0f;
                        }
                        else
                        {
                            SetMassFromShapes();
                            this._mass = 0f;
                            this._invMass = 0f;
                            this._linearVelocity.SetZero();
                        }
                    }
                    for (Shape shape = this._shapeList; shape != null; shape = shape._next)
                    {
                        shape.RefilterProxy(this._world._broadPhase, this._xf);
                    }
                }
            }
        }
        public Vec2 Gravity { get { return _gravity; } set { _useGravity = true; _gravity = value; } } // STEVE Added
        public void SetMass(MassData massData)
		{
			Box2DXDebug.Assert(!this._world._lock);
			if (!this._world._lock)
			{
				this._invMass = 0f;
				this._I = 0f;
				this._invI = 0f;
				this._mass = massData.Mass;
				if (this._mass > 0f)
				{
					this._invMass = 1f / this._mass;
				}
				if ((this._flags & Body.BodyFlags.FixedRotation) == (Body.BodyFlags)0)
				{
					this._I = massData.I;
				}
				if (this._I > 0f)
				{
					this._invI = 1f / this._I;
				}
				this._sweep.LocalCenter = massData.Center;
				this._sweep.C0 = (this._sweep.C = Box2DX.Common.Math.Mul(this._xf, this._sweep.LocalCenter));
				for (Shape shape = this._shapeList; shape != null; shape = shape._next)
				{
					shape.UpdateSweepRadius(this._sweep.LocalCenter);
				}
				Body.BodyType type = this._type;
				if (this._invMass == 0f && this._invI == 0f)
				{
					this._type = Body.BodyType.Static;
				}
				else
				{
					this._type = Body.BodyType.Dynamic;
				}
				if (type != this._type)
				{
					for (Shape shape = this._shapeList; shape != null; shape = shape._next)
					{
						shape.RefilterProxy(this._world._broadPhase, this._xf);
					}
				}
			}
		}
		public void SetMassFromShapes()
		{
			Box2DXDebug.Assert(!this._world._lock);
			if (!this._world._lock)
			{
				this._mass = 0f;
				this._invMass = 0f;
				this._I = 0f;
				this._invI = 0f;
				Vec2 vec = Vec2.Zero;
				for (Shape shape = this._shapeList; shape != null; shape = shape._next)
				{
					MassData massData;
					shape.ComputeMass(out massData);
					this._mass += massData.Mass;
					vec += massData.Mass * massData.Center;
					this._I += massData.I;
				}
				if (this._mass > 0f)
				{
					this._invMass = 1f / this._mass;
					vec *= this._invMass;
				}
				if (this._I > 0f && (this._flags & Body.BodyFlags.FixedRotation) == (Body.BodyFlags)0)
				{
					this._I -= this._mass * Vec2.Dot(vec, vec);
					Box2DXDebug.Assert(this._I > 0f);
					this._invI = 1f / this._I;
				}
				else
				{
					this._I = 0f;
					this._invI = 0f;
				}
				this._sweep.LocalCenter = vec;
				this._sweep.C0 = (this._sweep.C = Box2DX.Common.Math.Mul(this._xf, this._sweep.LocalCenter));
				for (Shape shape = this._shapeList; shape != null; shape = shape._next)
				{
					shape.UpdateSweepRadius(this._sweep.LocalCenter);
				}
				Body.BodyType type = this._type;
				if (this._invMass == 0f && this._invI == 0f)
				{
					this._type = Body.BodyType.Static;
				}
				else
				{
					this._type = Body.BodyType.Dynamic;
				}
				if (type != this._type)
				{
					for (Shape shape = this._shapeList; shape != null; shape = shape._next)
					{
						shape.RefilterProxy(this._world._broadPhase, this._xf);
					}
				}
			}
		}
		public bool SetXForm(Vec2 position, float angle)
		{
			Box2DXDebug.Assert(!this._world._lock);
			bool result;
			if (this._world._lock)
			{
				result = true;
			}
			else
			{
				if (this.IsFrozen())
				{
					result = false;
				}
				else
				{
					this._xf.R.Set(angle);
					this._xf.Position = position;
					this._sweep.C0 = (this._sweep.C = Box2DX.Common.Math.Mul(this._xf, this._sweep.LocalCenter));
					this._sweep.A = angle;
					this._sweep.A0 = angle;
					bool flag = false;
					for (Shape shape = this._shapeList; shape != null; shape = shape._next)
					{
						if (!shape.Synchronize(this._world._broadPhase, this._xf, this._xf))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						this._flags |= Body.BodyFlags.Frozen;
						this._linearVelocity.SetZero();
						this._angularVelocity = 0f;
						for (Shape shape = this._shapeList; shape != null; shape = shape._next)
						{
							shape.DestroyProxy(this._world._broadPhase);
						}
						result = false;
					}
					else
					{
						this._world._broadPhase.Commit();
						result = true;
					}
				}
			}
			return result;
		}
		public XForm GetXForm()
		{
			return this._xf;
		}
		public Vec2 GetPosition()
		{
			return this._xf.Position;
		}
		public float GetAngle()
		{
			return this._sweep.A;
		}
		public Vec2 GetWorldCenter()
		{
			return this._sweep.C;
		}
		public Vec2 GetLocalCenter()
		{
			return this._sweep.LocalCenter;
		}
		public void SetLinearVelocity(Vec2 v)
		{
			this._linearVelocity = v;
		}
		public Vec2 GetLinearVelocity()
		{
			return this._linearVelocity;
		}
		public void SetAngularVelocity(float omega)
		{
			this._angularVelocity = omega;
		}
		public float GetAngularVelocity()
		{
			return this._angularVelocity;
		}
		public void ApplyForce(Vec2 force, Vec2 point)
		{
			if (this.IsSleeping())
			{
				this.WakeUp();
			}
			this._force += force;
			this._torque += Vec2.Cross(point - this._sweep.C, force);
		}
		public void ApplyTorque(float torque)
		{
			if (this.IsSleeping())
			{
				this.WakeUp();
			}
			this._torque += torque;
		}
		public void ApplyImpulse(Vec2 impulse, Vec2 point)
		{
			if (this.IsSleeping())
			{
				this.WakeUp();
			}
			this._linearVelocity += this._invMass * impulse;
			this._angularVelocity += this._invI * Vec2.Cross(point - this._sweep.C, impulse);
		}
		public float GetMass()
		{
			return this._mass;
		}
		public float GetInertia()
		{
			return this._I;
		}
		public Vec2 GetWorldPoint(Vec2 localPoint)
		{
			return Box2DX.Common.Math.Mul(this._xf, localPoint);
		}
		public Vec2 GetWorldVector(Vec2 localVector)
		{
			return Box2DX.Common.Math.Mul(this._xf.R, localVector);
		}
		public Vec2 GetLocalPoint(Vec2 worldPoint)
		{
			return Box2DX.Common.Math.MulT(this._xf, worldPoint);
		}
		public Vec2 GetLocalVector(Vec2 worldVector)
		{
			return Box2DX.Common.Math.MulT(this._xf.R, worldVector);
		}
		public Vec2 GetLinearVelocityFromWorldPoint(Vec2 worldPoint)
		{
			return this._linearVelocity + Vec2.Cross(this._angularVelocity, worldPoint - this._sweep.C);
		}
		public Vec2 GetLinearVelocityFromLocalPoint(Vec2 localPoint)
		{
			return this.GetLinearVelocityFromWorldPoint(this.GetWorldPoint(localPoint));
		}
		public bool IsBullet()
		{
			return (this._flags & Body.BodyFlags.Bullet) == Body.BodyFlags.Bullet;
		}
		public void SetBullet(bool flag)
		{
			if (flag)
			{
				this._flags |= Body.BodyFlags.Bullet;
			}
			else
			{
				this._flags &= ~Body.BodyFlags.Bullet;
			}
		}
		public bool IsStatic()
		{
			return this._type == Body.BodyType.Static;
		}
		public bool IsDynamic()
		{
			return this._type == Body.BodyType.Dynamic;
		}
		public bool IsFrozen()
		{
			return (this._flags & Body.BodyFlags.Frozen) == Body.BodyFlags.Frozen;
		}
		public bool IsSleeping()
		{
			return (this._flags & Body.BodyFlags.Sleep) == Body.BodyFlags.Sleep;
		}
		public void AllowSleeping(bool flag)
		{
			if (flag)
			{
				this._flags |= Body.BodyFlags.AllowSleep;
			}
			else
			{
				this._flags &= ~Body.BodyFlags.AllowSleep;
				this.WakeUp();
			}
		}
		public void WakeUp()
		{
			this._flags &= ~Body.BodyFlags.Sleep;
			this._sleepTime = 0f;
		}
		public void PutToSleep()
		{
			this._flags |= Body.BodyFlags.Sleep;
			this._sleepTime = 0f;
			this._linearVelocity.SetZero();
			this._angularVelocity = 0f;
			this._force.SetZero();
			this._torque = 0f;
		}
		public Shape GetShapeList()
		{
			return this._shapeList;
		}
		public JointEdge GetJointList()
		{
			return this._jointList;
		}
		public Body GetNext()
		{
			return this._next;
		}
		public object GetUserData()
		{
			return this._userData;
		}
		public void SetUserData(object data)
		{
			this._userData = data;
		}
		public World GetWorld()
		{
			return this._world;
		}
		internal bool SynchronizeShapes()
		{
			XForm transform = default(XForm);
			transform.R.Set(this._sweep.A0);
			transform.Position = this._sweep.C0 - Box2DX.Common.Math.Mul(transform.R, this._sweep.LocalCenter);
			bool flag = true;
			for (Shape shape = this._shapeList; shape != null; shape = shape._next)
			{
				flag = shape.Synchronize(this._world._broadPhase, transform, this._xf);
				if (!flag)
				{
					break;
				}
			}
			bool result;
			if (!flag)
			{
				this._flags |= Body.BodyFlags.Frozen;
				this._linearVelocity.SetZero();
				this._angularVelocity = 0f;
				for (Shape shape = this._shapeList; shape != null; shape = shape._next)
				{
					shape.DestroyProxy(this._world._broadPhase);
				}
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}
		internal void SynchronizeTransform()
		{
			this._xf.R.Set(this._sweep.A);
			this._xf.Position = this._sweep.C - Box2DX.Common.Math.Mul(this._xf.R, this._sweep.LocalCenter);
		}
		internal bool IsConnected(Body other)
		{
			bool result;
			for (JointEdge jointEdge = this._jointList; jointEdge != null; jointEdge = jointEdge.Next)
			{
				if (jointEdge.Other == other)
				{
					result = !jointEdge.Joint._collideConnected;
					return result;
				}
			}
			result = false;
			return result;
		}
		internal void Advance(float t)
		{
			this._sweep.Advance(t);
			this._sweep.C = this._sweep.C0;
			this._sweep.A = this._sweep.A0;
			this.SynchronizeTransform();
		}
	}
}
