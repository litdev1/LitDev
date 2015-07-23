using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class LineJoint : Joint
	{
		public Vec2 _localAnchor1;
		public Vec2 _localAnchor2;
		public Vec2 _localXAxis1;
		public Vec2 _localYAxis1;
		public Vec2 _axis;
		public Vec2 _perp;
		public float _s1;
		public float _s2;
		public float _a1;
		public float _a2;
		public Mat22 _K;
		public Vec2 _impulse;
		public float _motorMass;
		public float _motorImpulse;
		public float _lowerTranslation;
		public float _upperTranslation;
		public float _maxMotorForce;
		public float _motorSpeed;
		public bool _enableLimit;
		public bool _enableMotor;
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
		public LineJoint(LineJointDef def) : base(def)
		{
			this._localAnchor1 = def.localAnchor1;
			this._localAnchor2 = def.localAnchor2;
			this._localXAxis1 = def.localAxis1;
			this._localYAxis1 = Vec2.Cross(1f, this._localXAxis1);
			this._impulse.SetZero();
			this._motorMass = 0f;
			this._motorImpulse = 0f;
			this._lowerTranslation = def.lowerTranslation;
			this._upperTranslation = def.upperTranslation;
			this._maxMotorForce = Settings.FORCE_INV_SCALE(def.maxMotorForce);
			this._motorSpeed = def.motorSpeed;
			this._enableLimit = def.enableLimit;
			this._enableMotor = def.enableMotor;
			this._axis.SetZero();
			this._perp.SetZero();
		}
		public override Vec2 GetReactionForce(float inv_dt)
		{
			return inv_dt * (this._impulse.X * this._perp + (this._motorImpulse + this._impulse.Y) * this._axis);
		}
		public override float GetReactionTorque(float inv_dt)
		{
			return 0f;
		}
		public float GetJointTranslation()
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 worldPoint = body.GetWorldPoint(this._localAnchor1);
			Vec2 worldPoint2 = body2.GetWorldPoint(this._localAnchor2);
			Vec2 a = worldPoint2 - worldPoint;
			Vec2 worldVector = body.GetWorldVector(this._localXAxis1);
			return Vec2.Dot(a, worldVector);
		}
		public float GetJointSpeed()
		{
			Body body = this._body1;
			Body body2 = this._body2;
			Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor1 - body.GetLocalCenter());
			Vec2 vec2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, this._localAnchor2 - body2.GetLocalCenter());
			Vec2 v = body._sweep.C + vec;
			Vec2 v2 = body2._sweep.C + vec2;
			Vec2 a = v2 - v;
			Vec2 worldVector = body.GetWorldVector(this._localXAxis1);
			Vec2 linearVelocity = body._linearVelocity;
			Vec2 linearVelocity2 = body2._linearVelocity;
			float angularVelocity = body._angularVelocity;
			float angularVelocity2 = body2._angularVelocity;
			return Vec2.Dot(a, Vec2.Cross(angularVelocity, worldVector)) + Vec2.Dot(worldVector, linearVelocity2 + Vec2.Cross(angularVelocity2, vec2) - linearVelocity - Vec2.Cross(angularVelocity, vec));
		}
		public bool IsLimitEnabled()
		{
			return this._enableLimit;
		}
		public void EnableLimit(bool flag)
		{
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._enableLimit = flag;
		}
		public float GetLowerLimit()
		{
			return this._lowerTranslation;
		}
		public float GetUpperLimit()
		{
			return this._upperTranslation;
		}
		public void SetLimits(float lower, float upper)
		{
			Box2DXDebug.Assert(lower <= upper);
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._lowerTranslation = lower;
			this._upperTranslation = upper;
		}
		public bool IsMotorEnabled()
		{
			return this._enableMotor;
		}
		public void EnableMotor(bool flag)
		{
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._enableMotor = flag;
		}
		public void SetMotorSpeed(float speed)
		{
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._motorSpeed = speed;
		}
		public void SetMaxMotorForce(float force)
		{
			this._body1.WakeUp();
			this._body2.WakeUp();
			this._maxMotorForce = Settings.FORCE_SCALE(1f) * force;
		}
		public float GetMotorForce()
		{
			return this._motorImpulse;
		}
		public float GetMotorSpeed()
		{
			return this._motorSpeed;
		}
		internal override void InitVelocityConstraints(TimeStep step)
		{
			Body body = this._body1;
			Body body2 = this._body2;
			this._localCenter1 = body.GetLocalCenter();
			this._localCenter2 = body2.GetLocalCenter();
			XForm xForm = body.GetXForm();
			XForm xForm2 = body2.GetXForm();
			Vec2 v = Box2DX.Common.Math.Mul(xForm.R, this._localAnchor1 - this._localCenter1);
			Vec2 vec = Box2DX.Common.Math.Mul(xForm2.R, this._localAnchor2 - this._localCenter2);
			Vec2 vec2 = body2._sweep.C + vec - body._sweep.C - v;
			this._invMass1 = body._invMass;
			this._invI1 = body._invI;
			this._invMass2 = body2._invMass;
			this._invI2 = body2._invI;
			this._axis = Box2DX.Common.Math.Mul(xForm.R, this._localXAxis1);
			this._a1 = Vec2.Cross(vec2 + v, this._axis);
			this._a2 = Vec2.Cross(vec, this._axis);
			this._motorMass = this._invMass1 + this._invMass2 + this._invI1 * this._a1 * this._a1 + this._invI2 * this._a2 * this._a2;
			Box2DXDebug.Assert(this._motorMass > Settings.FLT_EPSILON);
			this._motorMass = 1f / this._motorMass;
			this._perp = Box2DX.Common.Math.Mul(xForm.R, this._localYAxis1);
			this._s1 = Vec2.Cross(vec2 + v, this._perp);
			this._s2 = Vec2.Cross(vec, this._perp);
			float invMass = this._invMass1;
			float invMass2 = this._invMass2;
			float invI = this._invI1;
			float invI2 = this._invI2;
			float x = invMass + invMass2 + invI * this._s1 * this._s1 + invI2 * this._s2 * this._s2;
			float num = invI * this._s1 * this._a1 + invI2 * this._s2 * this._a2;
			float y = invMass + invMass2 + invI * this._a1 * this._a1 + invI2 * this._a2 * this._a2;
			this._K.Col1.Set(x, num);
			this._K.Col2.Set(num, y);
			if (this._enableLimit)
			{
				float num2 = Vec2.Dot(this._axis, vec2);
				if (Box2DX.Common.Math.Abs(this._upperTranslation - this._lowerTranslation) < 2f * Settings.LinearSlop)
				{
					this._limitState = LimitState.EqualLimits;
				}
				else
				{
					if (num2 <= this._lowerTranslation)
					{
						if (this._limitState != LimitState.AtLowerLimit)
						{
							this._limitState = LimitState.AtLowerLimit;
							this._impulse.Y = 0f;
						}
					}
					else
					{
						if (num2 >= this._upperTranslation)
						{
							if (this._limitState != LimitState.AtUpperLimit)
							{
								this._limitState = LimitState.AtUpperLimit;
								this._impulse.Y = 0f;
							}
						}
						else
						{
							this._limitState = LimitState.InactiveLimit;
							this._impulse.Y = 0f;
						}
					}
				}
			}
			if (!this._enableMotor)
			{
				this._motorImpulse = 0f;
			}
			if (step.WarmStarting)
			{
				this._impulse *= step.DtRatio;
				this._motorImpulse *= step.DtRatio;
				Vec2 v2 = this._impulse.X * this._perp + (this._motorImpulse + this._impulse.Y) * this._axis;
				float num3 = this._impulse.X * this._s1 + (this._motorImpulse + this._impulse.Y) * this._a1;
				float num4 = this._impulse.X * this._s2 + (this._motorImpulse + this._impulse.Y) * this._a2;
				Body expr_457 = body;
				expr_457._linearVelocity -= this._invMass1 * v2;
				body._angularVelocity -= this._invI1 * num3;
				Body expr_48B = body2;
				expr_48B._linearVelocity += this._invMass2 * v2;
				body2._angularVelocity += this._invI2 * num4;
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
			if (this._enableMotor && this._limitState != LimitState.EqualLimits)
			{
				float num3 = Vec2.Dot(this._axis, vec2 - vec) + this._a2 * num2 - this._a1 * num;
				float num4 = this._motorMass * (this._motorSpeed - num3);
				float motorImpulse = this._motorImpulse;
				float num5 = step.Dt * this._maxMotorForce;
				this._motorImpulse = Box2DX.Common.Math.Clamp(this._motorImpulse + num4, -num5, num5);
				num4 = this._motorImpulse - motorImpulse;
				Vec2 v = num4 * this._axis;
				float num6 = num4 * this._a1;
				float num7 = num4 * this._a2;
				vec -= this._invMass1 * v;
				num -= this._invI1 * num6;
				vec2 += this._invMass2 * v;
				num2 += this._invI2 * num7;
			}
			float num8 = Vec2.Dot(this._perp, vec2 - vec) + this._s2 * num2 - this._s1 * num;
			if (this._enableLimit && this._limitState != LimitState.InactiveLimit)
			{
				float y = Vec2.Dot(this._axis, vec2 - vec) + this._a2 * num2 - this._a1 * num;
				Vec2 v2 = new Vec2(num8, y);
				Vec2 impulse = this._impulse;
				Vec2 v3 = this._K.Solve(-v2);
				this._impulse += v3;
				if (this._limitState == LimitState.AtLowerLimit)
				{
					this._impulse.Y = Box2DX.Common.Math.Max(this._impulse.Y, 0f);
				}
				else
				{
					if (this._limitState == LimitState.AtUpperLimit)
					{
						this._impulse.Y = Box2DX.Common.Math.Min(this._impulse.Y, 0f);
					}
				}
				float num9 = -num8 - (this._impulse.Y - impulse.Y) * this._K.Col2.X;
				float x = num9 / this._K.Col1.X + impulse.X;
				this._impulse.X = x;
				v3 = this._impulse - impulse;
				Vec2 v = v3.X * this._perp + v3.Y * this._axis;
				float num6 = v3.X * this._s1 + v3.Y * this._a1;
				float num7 = v3.X * this._s2 + v3.Y * this._a2;
				vec -= this._invMass1 * v;
				num -= this._invI1 * num6;
				vec2 += this._invMass2 * v;
				num2 += this._invI2 * num7;
			}
			else
			{
				float num10 = -num8 / this._K.Col1.X;
				this._impulse.X = this._impulse.X + num10;
				Vec2 v = num10 * this._perp;
				float num6 = num10 * this._s1;
				float num7 = num10 * this._s2;
				vec -= this._invMass1 * v;
				num -= this._invI1 * num6;
				vec2 += this._invMass2 * v;
				num2 += this._invI2 * num7;
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
			Vec2 vec = body._sweep.C;
			float num = body._sweep.A;
			Vec2 vec2 = body2._sweep.C;
			float num2 = body2._sweep.A;
			float num3 = 0f;
			bool flag = false;
			float y = 0f;
			Mat22 a = new Mat22(num);
			Mat22 a2 = new Mat22(num2);
			Vec2 v = Box2DX.Common.Math.Mul(a, this._localAnchor1 - this._localCenter1);
			Vec2 vec3 = Box2DX.Common.Math.Mul(a2, this._localAnchor2 - this._localCenter2);
			Vec2 vec4 = vec2 + vec3 - vec - v;
			if (this._enableLimit)
			{
				this._axis = Box2DX.Common.Math.Mul(a, this._localXAxis1);
				this._a1 = Vec2.Cross(vec4 + v, this._axis);
				this._a2 = Vec2.Cross(vec3, this._axis);
				float num4 = Vec2.Dot(this._axis, vec4);
				if (Box2DX.Common.Math.Abs(this._upperTranslation - this._lowerTranslation) < 2f * Settings.LinearSlop)
				{
					y = Box2DX.Common.Math.Clamp(num4, -Settings.MaxLinearCorrection, Settings.MaxLinearCorrection);
					num3 = Box2DX.Common.Math.Abs(num4);
					flag = true;
				}
				else
				{
					if (num4 <= this._lowerTranslation)
					{
						y = Box2DX.Common.Math.Clamp(num4 - this._lowerTranslation + Settings.LinearSlop, -Settings.MaxLinearCorrection, 0f);
						num3 = this._lowerTranslation - num4;
						flag = true;
					}
					else
					{
						if (num4 >= this._upperTranslation)
						{
							y = Box2DX.Common.Math.Clamp(num4 - this._upperTranslation - Settings.LinearSlop, 0f, Settings.MaxLinearCorrection);
							num3 = num4 - this._upperTranslation;
							flag = true;
						}
					}
				}
			}
			this._perp = Box2DX.Common.Math.Mul(a, this._localYAxis1);
			this._s1 = Vec2.Cross(vec4 + v, this._perp);
			this._s2 = Vec2.Cross(vec3, this._perp);
			float num5 = Vec2.Dot(this._perp, vec4);
			num3 = Box2DX.Common.Math.Max(num3, Box2DX.Common.Math.Abs(num5));
			float num6 = 0f;
			Vec2 vec5;
			if (flag)
			{
				float invMass = this._invMass1;
				float invMass2 = this._invMass2;
				float invI = this._invI1;
				float invI2 = this._invI2;
				float num7 = invMass + invMass2 + invI * this._s1 * this._s1 + invI2 * this._s2 * this._s2;
				float num8 = invI * this._s1 * this._a1 + invI2 * this._s2 * this._a2;
				float y2 = invMass + invMass2 + invI * this._a1 * this._a1 + invI2 * this._a2 * this._a2;
				this._K.Col1.Set(num7, num8);
				this._K.Col2.Set(num8, y2);
				vec5 = this._K.Solve(-new Vec2
				{
					X = num5, 
					Y = y
				});
			}
			else
			{
				float invMass = this._invMass1;
				float invMass2 = this._invMass2;
				float invI = this._invI1;
				float invI2 = this._invI2;
				float num7 = invMass + invMass2 + invI * this._s1 * this._s1 + invI2 * this._s2 * this._s2;
				float x = -num5 / num7;
				vec5.X = x;
				vec5.Y = 0f;
			}
			Vec2 v2 = vec5.X * this._perp + vec5.Y * this._axis;
			float num9 = vec5.X * this._s1 + vec5.Y * this._a1;
			float num10 = vec5.X * this._s2 + vec5.Y * this._a2;
			vec -= this._invMass1 * v2;
			num -= this._invI1 * num9;
			vec2 += this._invMass2 * v2;
			num2 += this._invI2 * num10;
			body._sweep.C = vec;
			body._sweep.A = num;
			body2._sweep.C = vec2;
			body2._sweep.A = num2;
			body.SynchronizeTransform();
			body2.SynchronizeTransform();
			return num3 <= Settings.LinearSlop && num6 <= Settings.AngularSlop;
		}
	}
}
