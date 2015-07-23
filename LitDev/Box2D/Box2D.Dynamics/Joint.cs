using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public abstract class Joint
	{
		protected JointType _type;
		internal Joint _prev;
		internal Joint _next;
		internal JointEdge _node1 = new JointEdge();
		internal JointEdge _node2 = new JointEdge();
		internal Body _body1;
		internal Body _body2;
		internal bool _islandFlag;
		internal bool _collideConnected;
		protected object _userData;
		protected Vec2 _localCenter1;
		protected Vec2 _localCenter2;
		protected float _invMass1;
		protected float _invI1;
		protected float _invMass2;
		protected float _invI2;
		public abstract Vec2 Anchor1
		{
			get;
		}
		public abstract Vec2 Anchor2
		{
			get;
		}
		public object UserData
		{
			get
			{
				return this._userData;
			}
			set
			{
				this._userData = value;
			}
		}
		public new JointType GetType()
		{
			return this._type;
		}
		public Body GetBody1()
		{
			return this._body1;
		}
		public Body GetBody2()
		{
			return this._body2;
		}
		public abstract Vec2 GetReactionForce(float inv_dt);
		public abstract float GetReactionTorque(float inv_dt);
		public Joint GetNext()
		{
			return this._next;
		}
		protected Joint(JointDef def)
		{
			this._type = def.Type;
			this._prev = null;
			this._next = null;
			this._body1 = def.Body1;
			this._body2 = def.Body2;
			this._collideConnected = def.CollideConnected;
			this._islandFlag = false;
			this._userData = def.UserData;
		}
		internal static Joint Create(JointDef def)
		{
			Joint result = null;
			switch (def.Type)
			{
				case JointType.RevoluteJoint:
				{
					result = new RevoluteJoint((RevoluteJointDef)def);
					break;
				}
				case JointType.PrismaticJoint:
				{
					result = new PrismaticJoint((PrismaticJointDef)def);
					break;
				}
				case JointType.DistanceJoint:
				{
					result = new DistanceJoint((DistanceJointDef)def);
					break;
				}
				case JointType.PulleyJoint:
				{
					result = new PulleyJoint((PulleyJointDef)def);
					break;
				}
				case JointType.MouseJoint:
				{
					result = new MouseJoint((MouseJointDef)def);
					break;
				}
				case JointType.GearJoint:
				{
					result = new GearJoint((GearJointDef)def);
					break;
				}
				case JointType.LineJoint:
				{
					result = new LineJoint((LineJointDef)def);
					break;
				}
				default:
				{
					Box2DXDebug.Assert(false);
					break;
				}
			}
			return result;
		}
		internal static void Destroy(Joint joint)
		{
		}
		internal abstract void InitVelocityConstraints(TimeStep step);
		internal abstract void SolveVelocityConstraints(TimeStep step);
		internal abstract bool SolvePositionConstraints(float baumgarte);
		internal void ComputeXForm(ref XForm xf, Vec2 center, Vec2 localCenter, float angle)
		{
			xf.R.Set(angle);
			xf.Position = center - Box2DX.Common.Math.Mul(xf.R, localCenter);
		}
	}
}
