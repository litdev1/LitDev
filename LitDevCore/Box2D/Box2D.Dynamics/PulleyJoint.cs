using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class PulleyJoint : Joint
	{
		public static readonly float MinPulleyLength = 2f;
		public Body _ground;
		public Vec2 _groundAnchor1;
		public Vec2 _groundAnchor2;
		public Vec2 _localAnchor1;
		public Vec2 _localAnchor2;
		public Vec2 _u1;
		public Vec2 _u2;
		public float _constant;
		public float _ratio;
		public float _maxLength1;
		public float _maxLength2;
		public float _pulleyMass;
		public float _limitMass1;
		public float _limitMass2;
		public float _impulse;
		public float _limitImpulse1;
		public float _limitImpulse2;
		public LimitState _state;
		public LimitState _limitState1;
		public LimitState _limitState2;
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
		public Vec2 GroundAnchor1
		{
			get
			{
				return this._ground.GetXForm().Position + this._groundAnchor1;
			}
		}
		public Vec2 GroundAnchor2
		{
			get
			{
				return this._ground.GetXForm().Position + this._groundAnchor2;
			}
		}
		public float Length1
		{
			get
			{
				Vec2 worldPoint = this._body1.GetWorldPoint(this._localAnchor1);
				Vec2 v = this._ground.GetXForm().Position + this._groundAnchor1;
				return (worldPoint - v).Length();
			}
		}
		public float Length2
		{
			get
			{
				Vec2 worldPoint = this._body2.GetWorldPoint(this._localAnchor2);
				Vec2 v = this._ground.GetXForm().Position + this._groundAnchor2;
				return (worldPoint - v).Length();
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
			Vec2 v = this._impulse * this._u2;
			return inv_dt * v;
		}
		public override float GetReactionTorque(float inv_dt)
		{
			return 0f;
		}
		public PulleyJoint(PulleyJointDef def) : base(def)
		{
			this._ground = this._body1.GetWorld().GetGroundBody();
			this._groundAnchor1 = def.GroundAnchor1 - this._ground.GetXForm().Position;
			this._groundAnchor2 = def.GroundAnchor2 - this._ground.GetXForm().Position;
			this._localAnchor1 = def.LocalAnchor1;
			this._localAnchor2 = def.LocalAnchor2;
			Box2DXDebug.Assert(def.Ratio != 0f);
			this._ratio = def.Ratio;
			this._constant = def.Length1 + this._ratio * def.Length2;
			this._maxLength1 = Box2DX.Common.Math.Min(def.MaxLength1, this._constant - this._ratio * PulleyJoint.MinPulleyLength);
			this._maxLength2 = Box2DX.Common.Math.Min(def.MaxLength2, (this._constant - PulleyJoint.MinPulleyLength) / this._ratio);
			this._impulse = 0f;
			this._limitImpulse1 = 0f;
			this._limitImpulse2 = 0f;
		}
		internal override void InitVelocityConstraints(TimeStep step)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
			Vec2 vec2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
			Vec2 v = body._sweep.C + vec;
			Vec2 v2 = body2._sweep.C + vec2;
			Vec2 v3 = this._ground.GetXForm().Position + this._groundAnchor1;
			Vec2 v4 = this._ground.GetXForm().Position + this._groundAnchor2;
			this._u1 = v - v3;
			this._u2 = v2 - v4;
			float num = this._u1.Length();
			float num2 = this._u2.Length();
			if (num > Settings.LinearSlop)
			{
				this._u1 *= 1f / num;
			}
			else
			{
				this._u1.SetZero();
			}
			if (num2 > Settings.LinearSlop)
			{
				this._u2 *= 1f / num2;
			}
			else
			{
				this._u2.SetZero();
			}
			float num3 = this._constant - num - this._ratio * num2;
			if (num3 > 0f)
			{
				this._state = LimitState.InactiveLimit;
				this._impulse = 0f;
			}
			else
			{
				this._state = LimitState.AtUpperLimit;
			}
			if (num < this._maxLength1)
			{
				this._limitState1 = LimitState.InactiveLimit;
				this._limitImpulse1 = 0f;
			}
			else
			{
				this._limitState1 = LimitState.AtUpperLimit;
			}
			if (num2 < this._maxLength2)
			{
				this._limitState2 = LimitState.InactiveLimit;
				this._limitImpulse2 = 0f;
			}
			else
			{
				this._limitState2 = LimitState.AtUpperLimit;
			}
			float num4 = Vec2.Cross(vec, this._u1);
			float num5 = Vec2.Cross(vec2, this._u2);
			this._limitMass1 = body._invMass + body._invI * num4 * num4;
			this._limitMass2 = body2._invMass + body2._invI * num5 * num5;
			this._pulleyMass = this._limitMass1 + this._ratio * this._ratio * this._limitMass2;
			Box2DXDebug.Assert(this._limitMass1 > Settings.FLT_EPSILON);
			Box2DXDebug.Assert(this._limitMass2 > Settings.FLT_EPSILON);
			Box2DXDebug.Assert(this._pulleyMass > Settings.FLT_EPSILON);
			this._limitMass1 = 1f / this._limitMass1;
			this._limitMass2 = 1f / this._limitMass2;
			this._pulleyMass = 1f / this._pulleyMass;
			if (step.WarmStarting)
			{
				this._impulse *= step.DtRatio;
				this._limitImpulse1 *= step.DtRatio;
				this._limitImpulse2 *= step.DtRatio;
				Vec2 vec3 = -(this._impulse + this._limitImpulse1) * this._u1;
				Vec2 vec4 = (-this._ratio * this._impulse - this._limitImpulse2) * this._u2;
				Body expr_37B = body;
				expr_37B._linearVelocity += body._invMass * vec3;
				body._angularVelocity += body._invI * Vec2.Cross(vec, vec3);
				Body expr_3B5 = body2;
				expr_3B5._linearVelocity += body2._invMass * vec4;
				body2._angularVelocity += body2._invI * Vec2.Cross(vec2, vec4);
			}
			else
			{
				this._impulse = 0f;
				this._limitImpulse1 = 0f;
				this._limitImpulse2 = 0f;
			}
		}
		internal override void SolveVelocityConstraints(TimeStep step)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 a = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
			Vec2 a2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
			if (this._state == LimitState.AtUpperLimit)
			{
				Vec2 b = body._linearVelocity + Vec2.Cross(body._angularVelocity, a);
				Vec2 b2 = body2._linearVelocity + Vec2.Cross(body2._angularVelocity, a2);
				float num = -Vec2.Dot(this._u1, b) - this._ratio * Vec2.Dot(this._u2, b2);
				float num2 = this._pulleyMass * -num;
				float num3 = this._impulse;
				this._impulse = Box2DX.Common.Math.Max(0f, this._impulse + num2);
				num2 = this._impulse - num3;
				Vec2 vec = -num2 * this._u1;
				Vec2 vec2 = -this._ratio * num2 * this._u2;
				Body expr_120 = body;
				expr_120._linearVelocity += body._invMass * vec;
				body._angularVelocity += body._invI * Vec2.Cross(a, vec);
				Body expr_15A = body2;
				expr_15A._linearVelocity += body2._invMass * vec2;
				body2._angularVelocity += body2._invI * Vec2.Cross(a2, vec2);
			}
			if (this._limitState1 == LimitState.AtUpperLimit)
			{
				Vec2 b = body._linearVelocity + Vec2.Cross(body._angularVelocity, a);
				float num = -Vec2.Dot(this._u1, b);
				float num2 = -this._limitMass1 * num;
				float num3 = this._limitImpulse1;
				this._limitImpulse1 = Box2DX.Common.Math.Max(0f, this._limitImpulse1 + num2);
				num2 = this._limitImpulse1 - num3;
				Vec2 vec = -num2 * this._u1;
				Body expr_21C = body;
				expr_21C._linearVelocity += body._invMass * vec;
				body._angularVelocity += body._invI * Vec2.Cross(a, vec);
			}
			if (this._limitState2 == LimitState.AtUpperLimit)
			{
				Vec2 b2 = body2._linearVelocity + Vec2.Cross(body2._angularVelocity, a2);
				float num = -Vec2.Dot(this._u2, b2);
				float num2 = -this._limitMass2 * num;
				float num3 = this._limitImpulse2;
				this._limitImpulse2 = Box2DX.Common.Math.Max(0f, this._limitImpulse2 + num2);
				num2 = this._limitImpulse2 - num3;
				Vec2 vec2 = -num2 * this._u2;
				Body expr_2DE = body2;
				expr_2DE._linearVelocity += body2._invMass * vec2;
				body2._angularVelocity += body2._invI * Vec2.Cross(a2, vec2);
			}
		}
		internal override bool SolvePositionConstraints(float baumgarte)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 v = this._ground.GetXForm().Position + this._groundAnchor1;
			Vec2 v2 = this._ground.GetXForm().Position + this._groundAnchor2;
			float num = 0f;
			if (this._state == LimitState.AtUpperLimit)
			{
				Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
				Vec2 vec2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
				Vec2 v3 = body._sweep.C + vec;
				Vec2 v4 = body2._sweep.C + vec2;
				this._u1 = v3 - v;
				this._u2 = v4 - v2;
				float num2 = this._u1.Length();
				float num3 = this._u2.Length();
				if (num2 > Settings.LinearSlop)
				{
					this._u1 *= 1f / num2;
				}
				else
				{
					this._u1.SetZero();
				}
				if (num3 > Settings.LinearSlop)
				{
					this._u2 *= 1f / num3;
				}
				else
				{
					this._u2.SetZero();
				}
				float num4 = this._constant - num2 - this._ratio * num3;
				num = Box2DX.Common.Math.Max(num, -num4);
				num4 = Box2DX.Common.Math.Clamp(num4 + Settings.LinearSlop, -Settings.MaxLinearCorrection, 0f);
				float num5 = -this._pulleyMass * num4;
				Vec2 vec3 = -num5 * this._u1;
				Vec2 vec4 = -this._ratio * num5 * this._u2;
				Body expr_1F6_cp_0 = body;
				expr_1F6_cp_0._sweep.C = expr_1F6_cp_0._sweep.C + body._invMass * vec3;
				Body expr_219_cp_0 = body;
				expr_219_cp_0._sweep.A = expr_219_cp_0._sweep.A + body._invI * Vec2.Cross(vec, vec3);
				Body expr_23B_cp_0 = body2;
				expr_23B_cp_0._sweep.C = expr_23B_cp_0._sweep.C + body2._invMass * vec4;
				Body expr_25E_cp_0 = body2;
				expr_25E_cp_0._sweep.A = expr_25E_cp_0._sweep.A + body2._invI * Vec2.Cross(vec2, vec4);
				body.SynchronizeTransform();
				body2.SynchronizeTransform();
			}
			if (this._limitState1 == LimitState.AtUpperLimit)
			{
				Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
				Vec2 v3 = body._sweep.C + vec;
				this._u1 = v3 - v;
				float num2 = this._u1.Length();
				if (num2 > Settings.LinearSlop)
				{
					this._u1 *= 1f / num2;
				}
				else
				{
					this._u1.SetZero();
				}
				float num4 = this._maxLength1 - num2;
				num = Box2DX.Common.Math.Max(num, -num4);
				num4 = Box2DX.Common.Math.Clamp(num4 + Settings.LinearSlop, -Settings.MaxLinearCorrection, 0f);
				float num5 = -this._limitMass1 * num4;
				Vec2 vec3 = -num5 * this._u1;
				Body expr_381_cp_0 = body;
				expr_381_cp_0._sweep.C = expr_381_cp_0._sweep.C + body._invMass * vec3;
				Body expr_3A4_cp_0 = body;
				expr_3A4_cp_0._sweep.A = expr_3A4_cp_0._sweep.A + body._invI * Vec2.Cross(vec, vec3);
				body.SynchronizeTransform();
			}
			if (this._limitState2 == LimitState.AtUpperLimit)
			{
				Vec2 vec2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
				Vec2 v4 = body2._sweep.C + vec2;
				this._u2 = v4 - v2;
				float num3 = this._u2.Length();
				if (num3 > Settings.LinearSlop)
				{
					this._u2 *= 1f / num3;
				}
				else
				{
					this._u2.SetZero();
				}
				float num4 = this._maxLength2 - num3;
				num = Box2DX.Common.Math.Max(num, -num4);
				num4 = Box2DX.Common.Math.Clamp(num4 + Settings.LinearSlop, -Settings.MaxLinearCorrection, 0f);
				float num5 = -this._limitMass2 * num4;
				Vec2 vec4 = -num5 * this._u2;
				Body expr_4C0_cp_0 = body2;
				expr_4C0_cp_0._sweep.C = expr_4C0_cp_0._sweep.C + body2._invMass * vec4;
				Body expr_4E3_cp_0 = body2;
				expr_4E3_cp_0._sweep.A = expr_4E3_cp_0._sweep.A + body2._invI * Vec2.Cross(vec2, vec4);
				body2.SynchronizeTransform();
			}
			return num < Settings.LinearSlop;
		}
	}
}
