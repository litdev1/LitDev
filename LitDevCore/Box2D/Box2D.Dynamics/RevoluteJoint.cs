using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class RevoluteJoint : Joint
	{
		public Vec2 _localAnchor1;
		public Vec2 _localAnchor2;
		public Vec3 _impulse;
		public float _motorImpulse;
		public Mat33 _mass;
		public float _motorMass;
		public bool _enableMotor;
		public float _maxMotorTorque;
		public float _motorSpeed;
		public bool _enableLimit;
		public float _referenceAngle;
		public float _lowerAngle;
		public float _upperAngle;
		public LimitState _limitState;
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
		public float JointAngle
		{
			get
			{
				Body body = this._body1;
				Body body2 = this._body2;
				return body2._sweep.A - body._sweep.A - this._referenceAngle;
			}
		}
		public float JointSpeed
		{
			get
			{
				Body body = this._body1;
				Body body2 = this._body2;
				return body2._angularVelocity - body._angularVelocity;
			}
		}
		public bool IsLimitEnabled
		{
			get
			{
				return this._enableLimit;
			}
		}
		public float LowerLimit
		{
			get
			{
				return this._lowerAngle;
			}
		}
		public float UpperLimit
		{
			get
			{
				return this._upperAngle;
			}
		}
		public bool IsMotorEnabled
		{
			get
			{
				return this._enableMotor;
			}
		}
		public float MotorSpeed
		{
			get
			{
				return this._motorSpeed;
			}
			set
			{
				this._body1.WakeUp();
				this._body2.WakeUp();
				this._motorSpeed = value;
			}
		}
		public float MotorTorque
		{
			get
			{
				return this._motorImpulse;
			}
		}
		public override Vec2 GetReactionForce(float inv_dt)
		{
			Vec2 v = new Vec2(this._impulse.X, this._impulse.Y);
			return inv_dt * v;
		}
		public override float GetReactionTorque(float inv_dt)
		{
			return inv_dt * this._impulse.Z;
		}
		public void EnableLimit(bool flag)
		{
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._enableLimit = flag;
		}
		public void SetLimits(float lower, float upper)
		{
			Box2DXDebug.Assert(lower <= upper);
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._lowerAngle = lower;
			this._upperAngle = upper;
		}
		public void EnableMotor(bool flag)
		{
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._enableMotor = flag;
		}
		public void SetMaxMotorTorque(float torque)
		{
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._maxMotorTorque = torque;
		}
		public RevoluteJoint(RevoluteJointDef def) : base(def)
		{
			this._localAnchor1 = def.LocalAnchor1;
			this._localAnchor2 = def.LocalAnchor2;
			this._referenceAngle = def.ReferenceAngle;
			this._impulse = default(Vec3);
			this._motorImpulse = 0f;
			this._lowerAngle = def.LowerAngle;
			this._upperAngle = def.UpperAngle;
			this._maxMotorTorque = def.MaxMotorTorque;
			this._motorSpeed = def.MotorSpeed;
			this._enableLimit = def.EnableLimit;
			this._enableMotor = def.EnableMotor;
		}
		internal override void InitVelocityConstraints(TimeStep step)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 a = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
			Vec2 a2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
			float invMass = body._invMass;
			float invMass2 = body2._invMass;
			float invI = body._invI;
			float invI2 = body2._invI;
			this._mass.Col1.X = invMass + invMass2 + a.Y * a.Y * invI + a2.Y * a2.Y * invI2;
			this._mass.Col2.X = -a.Y * a.X * invI - a2.Y * a2.X * invI2;
			this._mass.Col3.X = -a.Y * invI - a2.Y * invI2;
			this._mass.Col1.Y = this._mass.Col2.X;
			this._mass.Col2.Y = invMass + invMass2 + a.X * a.X * invI + a2.X * a2.X * invI2;
			this._mass.Col3.Y = a.X * invI + a2.X * invI2;
			this._mass.Col1.Z = this._mass.Col3.X;
			this._mass.Col2.Z = this._mass.Col3.Y;
			this._mass.Col3.Z = invI + invI2;
			this._motorMass = 1f / (invI + invI2);
			if (!this._enableMotor)
			{
				this._motorImpulse = 0f;
			}
			if (this._enableLimit)
			{
				float num = body2._sweep.A - body._sweep.A - this._referenceAngle;
				if (Box2DX.Common.Math.Abs(this._upperAngle - this._lowerAngle) < 2f * Settings.AngularSlop)
				{
					this._limitState = LimitState.EqualLimits;
				}
				else
				{
					if (num <= this._lowerAngle)
					{
						if (this._limitState != LimitState.AtLowerLimit)
						{
							this._impulse.Z = 0f;
						}
						this._limitState = LimitState.AtLowerLimit;
					}
					else
					{
						if (num >= this._upperAngle)
						{
							if (this._limitState != LimitState.AtUpperLimit)
							{
								this._impulse.Z = 0f;
							}
							this._limitState = LimitState.AtUpperLimit;
						}
						else
						{
							this._limitState = LimitState.InactiveLimit;
							this._impulse.Z = 0f;
						}
					}
				}
			}
			if (step.WarmStarting)
			{
				this._impulse *= step.DtRatio;
				this._motorImpulse *= step.DtRatio;
				Vec2 vec = new Vec2(this._impulse.X, this._impulse.Y);
				Body expr_363 = body;
				expr_363._linearVelocity -= invMass * vec;
				body._angularVelocity -= invI * (Vec2.Cross(a, vec) + this._motorImpulse + this._impulse.Z);
				Body expr_3A8 = body2;
				expr_3A8._linearVelocity += invMass2 * vec;
				body2._angularVelocity += invI2 * (Vec2.Cross(a2, vec) + this._motorImpulse + this._impulse.Z);
			}
			else
			{
				this._impulse.SetZero();
				this._motorImpulse = 0f;
			}
		}
		internal override void SolveVelocityConstraints(TimeStep step)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 vec = body._linearVelocity;
			float num = body._angularVelocity;
			Vec2 vec2 = body2._linearVelocity;
			float num2 = body2._angularVelocity;
			float invMass = body._invMass;
			float invMass2 = body2._invMass;
			float invI = body._invI;
			float invI2 = body2._invI;
			if (this._enableMotor && this._limitState != LimitState.EqualLimits)
			{
				float num3 = num2 - num - this._motorSpeed;
				float num4 = this._motorMass * -num3;
				float motorImpulse = this._motorImpulse;
				float num5 = step.Dt * this._maxMotorTorque;
				this._motorImpulse = Box2DX.Common.Math.Clamp(this._motorImpulse + num4, -num5, num5);
				num4 = this._motorImpulse - motorImpulse;
				num -= invI * num4;
				num2 += invI2 * num4;
			}
			if (this._enableLimit && this._limitState != LimitState.InactiveLimit)
			{
				Vec2 a = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
				Vec2 a2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
				Vec2 v = vec2 + Vec2.Cross(num2, a2) - vec - Vec2.Cross(num, a);
				float z = num2 - num;
				Vec3 v2 = new Vec3(v.X, v.Y, z);
				Vec3 v3 = this._mass.Solve33(-v2);
				if (this._limitState == LimitState.EqualLimits)
				{
					this._impulse += v3;
				}
				else
				{
					if (this._limitState == LimitState.AtLowerLimit)
					{
						float num6 = this._impulse.Z + v3.Z;
						if (num6 < 0f)
						{
							Vec2 vec3 = this._mass.Solve22(-v);
							v3.X = vec3.X;
							v3.Y = vec3.Y;
							v3.Z = -this._impulse.Z;
							this._impulse.X = this._impulse.X + vec3.X;
							this._impulse.Y = this._impulse.Y + vec3.Y;
							this._impulse.Z = 0f;
						}
					}
					else
					{
						if (this._limitState == LimitState.AtUpperLimit)
						{
							float num6 = this._impulse.Z + v3.Z;
							if (num6 > 0f)
							{
								Vec2 vec3 = this._mass.Solve22(-v);
								v3.X = vec3.X;
								v3.Y = vec3.Y;
								v3.Z = -this._impulse.Z;
								this._impulse.X = this._impulse.X + vec3.X;
								this._impulse.Y = this._impulse.Y + vec3.Y;
								this._impulse.Z = 0f;
							}
						}
					}
				}
				Vec2 vec4 = new Vec2(v3.X, v3.Y);
				vec -= invMass * vec4;
				num -= invI * (Vec2.Cross(a, vec4) + v3.Z);
				vec2 += invMass2 * vec4;
				num2 += invI2 * (Vec2.Cross(a2, vec4) + v3.Z);
			}
			else
			{
				Vec2 a = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
				Vec2 a2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
				Vec2 v4 = vec2 + Vec2.Cross(num2, a2) - vec - Vec2.Cross(num, a);
				Vec2 vec5 = this._mass.Solve22(-v4);
				this._impulse.X = this._impulse.X + vec5.X;
				this._impulse.Y = this._impulse.Y + vec5.Y;
				vec -= invMass * vec5;
				num -= invI * Vec2.Cross(a, vec5);
				vec2 += invMass2 * vec5;
				num2 += invI2 * Vec2.Cross(a2, vec5);
			}
			body._linearVelocity = vec;
			body._angularVelocity = num;
			body2._linearVelocity = vec2;
			body2._angularVelocity = num2;
		}
		internal override bool SolvePositionConstraints(float baumgarte)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			float num = 0f;
			if (this._enableLimit && this._limitState != LimitState.InactiveLimit)
			{
				float num2 = body2._sweep.A - body._sweep.A - this._referenceAngle;
				float num3 = 0f;
				if (this._limitState == LimitState.EqualLimits)
				{
					float num4 = Box2DX.Common.Math.Clamp(num2, -Settings.MaxAngularCorrection, Settings.MaxAngularCorrection);
					num3 = -this._motorMass * num4;
					num = Box2DX.Common.Math.Abs(num4);
				}
				else
				{
					if (this._limitState == LimitState.AtLowerLimit)
					{
						float num4 = num2 - this._lowerAngle;
						num = -num4;
						num4 = Box2DX.Common.Math.Clamp(num4 + Settings.AngularSlop, -Settings.MaxAngularCorrection, 0f);
						num3 = -this._motorMass * num4;
					}
					else
					{
						if (this._limitState == LimitState.AtUpperLimit)
						{
							float num4 = num2 - this._upperAngle;
							num = num4;
							num4 = Box2DX.Common.Math.Clamp(num4 - Settings.AngularSlop, 0f, Settings.MaxAngularCorrection);
							num3 = -this._motorMass * num4;
						}
					}
				}
				Body expr_139_cp_0 = body;
				expr_139_cp_0._sweep.A = expr_139_cp_0._sweep.A - body._invI * num3;
				Body expr_154_cp_0 = body2;
				expr_154_cp_0._sweep.A = expr_154_cp_0._sweep.A + body2._invI * num3;
				body.SynchronizeTransform();
				body2.SynchronizeTransform();
			}
			Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
			Vec2 vec2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
			Vec2 vec3 = body2._sweep.C + vec2 - body._sweep.C - vec;
			float num5 = vec3.Length();
			float invMass = body._invMass;
			float invMass2 = body2._invMass;
			float invI = body._invI;
			float invI2 = body2._invI;
			float num6 = 10f * Settings.LinearSlop;
			if (vec3.LengthSquared() > num6 * num6)
			{
				Vec2 vec4 = vec3;
				vec4.Normalize();
				float num7 = invMass + invMass2;
				Box2DXDebug.Assert(num7 > Settings.FLT_EPSILON);
				float a = 1f / num7;
				Vec2 v = a * -vec3;
				float num8 = 0.5f;
				Body expr_283_cp_0 = body;
				expr_283_cp_0._sweep.C = expr_283_cp_0._sweep.C - num8 * invMass * v;
				Body expr_2A5_cp_0 = body2;
				expr_2A5_cp_0._sweep.C = expr_2A5_cp_0._sweep.C + num8 * invMass2 * v;
				vec3 = body2._sweep.C + vec2 - body._sweep.C - vec;
			}
			Mat22 a2 = default(Mat22);
			a2.Col1.X = invMass + invMass2;
			a2.Col2.X = 0f;
			a2.Col1.Y = 0f;
			a2.Col2.Y = invMass + invMass2;
			Mat22 b = default(Mat22);
			b.Col1.X = invI * vec.Y * vec.Y;
			b.Col2.X = -invI * vec.X * vec.Y;
			b.Col1.Y = -invI * vec.X * vec.Y;
			b.Col2.Y = invI * vec.X * vec.X;
			Mat22 b2 = default(Mat22);
			b2.Col1.X = invI2 * vec2.Y * vec2.Y;
			b2.Col2.X = -invI2 * vec2.X * vec2.Y;
			b2.Col1.Y = -invI2 * vec2.X * vec2.Y;
			b2.Col2.Y = invI2 * vec2.X * vec2.X;
			Vec2 vec5 = (a2 + b + b2).Solve(-vec3);
			Body expr_465_cp_0 = body;
			expr_465_cp_0._sweep.C = expr_465_cp_0._sweep.C - body._invMass * vec5;
			Body expr_488_cp_0 = body;
			expr_488_cp_0._sweep.A = expr_488_cp_0._sweep.A - body._invI * Vec2.Cross(vec, vec5);
			Body expr_4AA_cp_0 = body2;
			expr_4AA_cp_0._sweep.C = expr_4AA_cp_0._sweep.C + body2._invMass * vec5;
			Body expr_4CD_cp_0 = body2;
			expr_4CD_cp_0._sweep.A = expr_4CD_cp_0._sweep.A + body2._invI * Vec2.Cross(vec2, vec5);
			body.SynchronizeTransform();
			body2.SynchronizeTransform();
			return num5 <= Settings.LinearSlop && num <= Settings.AngularSlop;
		}
	}
}
