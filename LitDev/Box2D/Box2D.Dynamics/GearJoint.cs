using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class GearJoint : Joint
	{
		public Body _ground1;
		public Body _ground2;
		public RevoluteJoint _revolute1;
		public PrismaticJoint _prismatic1;
		public RevoluteJoint _revolute2;
		public PrismaticJoint _prismatic2;
		public Vec2 _groundAnchor1;
		public Vec2 _groundAnchor2;
		public Vec2 _localAnchor1;
		public Vec2 _localAnchor2;
		public Jacobian _J;
		public float _constant;
		public float _ratio;
		public float _mass;
		public float _impulse;
		public override Vec2 Anchor1
		{
			get
			{
				return this._body1.GetWorldPoint(this._localAnchor1);
			}
		}
		public override Vec2 Anchor2
		{
			get
			{
				return this._body2.GetWorldPoint(this._localAnchor2);
			}
		}
		public float Ratio
		{
			get
			{
				return this._ratio;
			}
		}
		public override Vec2 GetReactionForce(float inv_dt)
		{
			Vec2 v = this._impulse * this._J.Linear2;
			return inv_dt * v;
		}
		public override float GetReactionTorque(float inv_dt)
		{
			Vec2 a = Box2DX.Common.Math.Mul(this._body2.GetXForm().R, this._localAnchor2 - this._body2.GetLocalCenter());
			Vec2 b = this._impulse * this._J.Linear2;
			float num = this._impulse * this._J.Angular2 - Vec2.Cross(a, b);
			return inv_dt * num;
		}
		public GearJoint(GearJointDef def) : base(def)
		{
			JointType type = def.Joint1.GetType();
			JointType type2 = def.Joint2.GetType();
			Box2DXDebug.Assert(type == JointType.RevoluteJoint || type == JointType.PrismaticJoint);
			Box2DXDebug.Assert(type2 == JointType.RevoluteJoint || type2 == JointType.PrismaticJoint);
			Box2DXDebug.Assert(def.Joint1.GetBody1().IsStatic());
			Box2DXDebug.Assert(def.Joint2.GetBody1().IsStatic());
			this._revolute1 = null;
			this._prismatic1 = null;
			this._revolute2 = null;
			this._prismatic2 = null;
			this._ground1 = def.Joint1.GetBody1();
			this._body1 = def.Joint1.GetBody2();
			float num;
			if (type == JointType.RevoluteJoint)
			{
				this._revolute1 = (RevoluteJoint)def.Joint1;
				this._groundAnchor1 = this._revolute1._localAnchor1;
				this._localAnchor1 = this._revolute1._localAnchor2;
				num = this._revolute1.JointAngle;
			}
			else
			{
				this._prismatic1 = (PrismaticJoint)def.Joint1;
				this._groundAnchor1 = this._prismatic1._localAnchor1;
				this._localAnchor1 = this._prismatic1._localAnchor2;
				num = this._prismatic1.JointTranslation;
			}
			this._ground2 = def.Joint2.GetBody1();
			this._body2 = def.Joint2.GetBody2();
			float num2;
			if (type2 == JointType.RevoluteJoint)
			{
				this._revolute2 = (RevoluteJoint)def.Joint2;
				this._groundAnchor2 = this._revolute2._localAnchor1;
				this._localAnchor2 = this._revolute2._localAnchor2;
				num2 = this._revolute2.JointAngle;
			}
			else
			{
				this._prismatic2 = (PrismaticJoint)def.Joint2;
				this._groundAnchor2 = this._prismatic2._localAnchor1;
				this._localAnchor2 = this._prismatic2._localAnchor2;
				num2 = this._prismatic2.JointTranslation;
			}
			this._ratio = def.Ratio;
			this._constant = num + this._ratio * num2;
			this._impulse = 0f;
		}
		internal override void InitVelocityConstraints(TimeStep step)
		{
			Body ground = this._ground1;
			Body ground2 = this._ground2;
			Body body = this._body1;
			Body body2 = this._body2;
			float num = 0f;
			this._J.SetZero();
			if (this._revolute1 != null)
			{
				this._J.Angular1 = -1f;
				num += body._invI;
			}
			else
			{
				Vec2 vec = Box2DX.Common.Math.Mul(ground.GetXForm().R, this._prismatic1._localXAxis1);
				Vec2 a = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
				float num2 = Vec2.Cross(a, vec);
				this._J.Linear1 = -vec;
				this._J.Angular1 = -num2;
				num += body._invMass + body._invI * num2 * num2;
			}
			if (this._revolute2 != null)
			{
				this._J.Angular2 = -this._ratio;
				num += this._ratio * this._ratio * body2._invI;
			}
			else
			{
				Vec2 vec = Box2DX.Common.Math.Mul(ground2.GetXForm().R, this._prismatic2._localXAxis1);
				Vec2 a = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
				float num2 = Vec2.Cross(a, vec);
				this._J.Linear2 = -this._ratio * vec;
				this._J.Angular2 = -this._ratio * num2;
				num += this._ratio * this._ratio * (body2._invMass + body2._invI * num2 * num2);
			}
			Box2DXDebug.Assert(num > 0f);
			this._mass = 1f / num;
			if (step.WarmStarting)
			{
				Body expr_1FA = body;
				expr_1FA._linearVelocity += body._invMass * this._impulse * this._J.Linear1;
				body._angularVelocity += body._invI * this._impulse * this._J.Angular1;
				Body expr_24E = body2;
				expr_24E._linearVelocity += body2._invMass * this._impulse * this._J.Linear2;
				body2._angularVelocity += body2._invI * this._impulse * this._J.Angular2;
			}
			else
			{
				this._impulse = 0f;
			}
		}
		internal override void SolveVelocityConstraints(TimeStep step)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			float num = this._J.Compute(body._linearVelocity, body._angularVelocity, body2._linearVelocity, body2._angularVelocity);
			float num2 = this._mass * -num;
			this._impulse += num2;
			Body expr_4C = body;
			expr_4C._linearVelocity += body._invMass * num2 * this._J.Linear1;
			body._angularVelocity += body._invI * num2 * this._J.Angular1;
			Body expr_96 = body2;
			expr_96._linearVelocity += body2._invMass * num2 * this._J.Linear2;
			body2._angularVelocity += body2._invI * num2 * this._J.Angular2;
		}
		internal override bool SolvePositionConstraints(float baumgarte)
		{
			float num = 0f;
			Body body = this._body1;
			Body body2 = this._body2;
			float num2;
			if (this._revolute1 != null)
			{
				num2 = this._revolute1.JointAngle;
			}
			else
			{
				num2 = this._prismatic1.JointTranslation;
			}
			float num3;
			if (this._revolute2 != null)
			{
				num3 = this._revolute2.JointAngle;
			}
			else
			{
				num3 = this._prismatic2.JointTranslation;
			}
			float num4 = this._constant - (num2 + this._ratio * num3);
			float num5 = this._mass * -num4;
			Body expr_97_cp_0 = body;
			expr_97_cp_0._sweep.C = expr_97_cp_0._sweep.C + body._invMass * num5 * this._J.Linear1;
			Body expr_C6_cp_0 = body;
			expr_C6_cp_0._sweep.A = expr_C6_cp_0._sweep.A + body._invI * num5 * this._J.Angular1;
			Body expr_ED_cp_0 = body2;
			expr_ED_cp_0._sweep.C = expr_ED_cp_0._sweep.C + body2._invMass * num5 * this._J.Linear2;
			Body expr_11C_cp_0 = body2;
			expr_11C_cp_0._sweep.A = expr_11C_cp_0._sweep.A + body2._invI * num5 * this._J.Angular2;
			body.SynchronizeTransform();
			body2.SynchronizeTransform();
			return num < Settings.LinearSlop;
		}
	}
}
