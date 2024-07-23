using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class DistanceJoint : Joint
	{
		public Vec2 _localAnchor1;
		public Vec2 _localAnchor2;
		public Vec2 _u;
		public float _frequencyHz;
		public float _dampingRatio;
		public float _gamma;
		public float _bias;
		public float _impulse;
		public float _mass;
		public float _length;
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
		public override Vec2 GetReactionForce(float inv_dt)
		{
			return inv_dt * this._impulse * this._u;
		}
		public override float GetReactionTorque(float inv_dt)
		{
			return 0f;
		}
		public DistanceJoint(DistanceJointDef def) : base(def)
		{
			this._localAnchor1 = def.LocalAnchor1;
			this._localAnchor2 = def.LocalAnchor2;
			this._length = def.Length;
			this._frequencyHz = def.FrequencyHz;
			this._dampingRatio = def.DampingRatio;
			this._impulse = 0f;
			this._gamma = 0f;
			this._bias = 0f;
		}
		internal override void InitVelocityConstraints(TimeStep step)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
			Vec2 vec2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
			this._u = body2._sweep.C + vec2 - body._sweep.C - vec;
			float num = this._u.Length();
			if (num > Settings.LinearSlop)
			{
				this._u *= 1f / num;
			}
			else
			{
				this._u.Set(0f, 0f);
			}
			float num2 = Vec2.Cross(vec, this._u);
			float num3 = Vec2.Cross(vec2, this._u);
			float num4 = body._invMass + body._invI * num2 * num2 + body2._invMass + body2._invI * num3 * num3;
			Box2DXDebug.Assert(num4 > Settings.FLT_EPSILON);
			this._mass = 1f / num4;
			if (this._frequencyHz > 0f)
			{
				float num5 = num - this._length;
				float num6 = 2f * Settings.Pi * this._frequencyHz;
				float num7 = 2f * this._mass * this._dampingRatio * num6;
				float num8 = this._mass * num6 * num6;
				this._gamma = 1f / (step.Dt * (num7 + step.Dt * num8));
				this._bias = num5 * step.Dt * num8 * this._gamma;
				this._mass = 1f / (num4 + this._gamma);
			}
			if (step.WarmStarting)
			{
				this._impulse *= step.DtRatio;
				Vec2 vec3 = this._impulse * this._u;
				Body expr_222 = body;
				expr_222._linearVelocity -= body._invMass * vec3;
				body._angularVelocity -= body._invI * Vec2.Cross(vec, vec3);
				Body expr_25C = body2;
				expr_25C._linearVelocity += body2._invMass * vec3;
				body2._angularVelocity += body2._invI * Vec2.Cross(vec2, vec3);
			}
			else
			{
				this._impulse = 0f;
			}
		}
		internal override bool SolvePositionConstraints(float baumgarte)
		{
			bool result;
			if (this._frequencyHz > 0f)
			{
				result = true;
			}
			else
			{
				Body body = this._body1;
				Body body2 = this._body2;
				Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
				Vec2 vec2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
				Vec2 u = body2._sweep.C + vec2 - body._sweep.C - vec;
				float num = u.Normalize();
				float num2 = num - this._length;
				num2 = Box2DX.Common.Math.Clamp(num2, -Settings.MaxLinearCorrection, Settings.MaxLinearCorrection);
				float a = -this._mass * num2;
				this._u = u;
				Vec2 vec3 = a * this._u;
				Body expr_EC_cp_0 = body;
				expr_EC_cp_0._sweep.C = expr_EC_cp_0._sweep.C - body._invMass * vec3;
				Body expr_10F_cp_0 = body;
				expr_10F_cp_0._sweep.A = expr_10F_cp_0._sweep.A - body._invI * Vec2.Cross(vec, vec3);
				Body expr_130_cp_0 = body2;
				expr_130_cp_0._sweep.C = expr_130_cp_0._sweep.C + body2._invMass * vec3;
				Body expr_153_cp_0 = body2;
				expr_153_cp_0._sweep.A = expr_153_cp_0._sweep.A + body2._invI * Vec2.Cross(vec2, vec3);
				body.SynchronizeTransform();
				body2.SynchronizeTransform();
				result = (System.Math.Abs(num2) < Settings.LinearSlop);
			}
			return result;
		}
		internal override void SolveVelocityConstraints(TimeStep step)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 a = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
			Vec2 a2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
			Vec2 v = body._linearVelocity + Vec2.Cross(body._angularVelocity, a);
			Vec2 v2 = body2._linearVelocity + Vec2.Cross(body2._angularVelocity, a2);
			float num = Vec2.Dot(this._u, v2 - v);
			float num2 = -this._mass * (num + this._bias + this._gamma * this._impulse);
			this._impulse += num2;
			Vec2 vec = num2 * this._u;
			Body expr_DB = body;
			expr_DB._linearVelocity -= body._invMass * vec;
			body._angularVelocity -= body._invI * Vec2.Cross(a, vec);
			Body expr_115 = body2;
			expr_115._linearVelocity += body2._invMass * vec;
			body2._angularVelocity += body2._invI * Vec2.Cross(a2, vec);
		}
	}
}
