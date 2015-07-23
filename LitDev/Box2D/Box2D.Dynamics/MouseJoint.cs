using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class MouseJoint : Joint
	{
		public Vec2 _localAnchor;
		public Vec2 _target;
		public Vec2 _impulse;
		public Mat22 _mass;
		public Vec2 _C;
		public float _maxForce;
		public float _frequencyHz;
		public float _dampingRatio;
		public float _beta;
		public float _gamma;
		public override Vec2 Anchor1
		{
			get
			{
				return this._target;
			}
		}
		public override Vec2 Anchor2
		{
			get
			{
				return this._body2.GetWorldPoint(this._localAnchor);
			}
		}
		public override Vec2 GetReactionForce(float inv_dt)
		{
			return inv_dt * this._impulse;
		}
		public override float GetReactionTorque(float inv_dt)
		{
			return inv_dt * 0f;
		}
		public void SetTarget(Vec2 target)
		{
			if (this._body2.IsSleeping())
			{
				this._body2.WakeUp();
			}
			this._target = target;
		}
		public MouseJoint(MouseJointDef def) : base(def)
		{
			this._target = def.Target;
			this._localAnchor = Box2DX.Common.Math.MulT(this._body2.GetXForm(), this._target);
			this._maxForce = def.MaxForce;
			this._impulse.SetZero();
			this._frequencyHz = def.FrequencyHz;
			this._dampingRatio = def.DampingRatio;
			this._beta = 0f;
			this._gamma = 0f;
		}
		internal override void InitVelocityConstraints(TimeStep step)
		{
			Body body = this._body2;
			float mass = body.GetMass();
			float num = 2f * Settings.Pi * this._frequencyHz;
			float num2 = 2f * mass * this._dampingRatio * num;
			float num3 = mass * (num * num);
			Box2DXDebug.Assert(num2 + step.Dt * num3 > Settings.FLT_EPSILON);
			this._gamma = 1f / (step.Dt * (num2 + step.Dt * num3));
			this._beta = step.Dt * num3 * this._gamma;
			Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor - body.GetLocalCenter());
			float invMass = body._invMass;
			float invI = body._invI;
			Mat22 a = default(Mat22);
			a.Col1.X = invMass;
			a.Col2.X = 0f;
			a.Col1.Y = 0f;
			a.Col2.Y = invMass;
			Mat22 b = default(Mat22);
			b.Col1.X = invI * vec.Y * vec.Y;
			b.Col2.X = -invI * vec.X * vec.Y;
			b.Col1.Y = -invI * vec.X * vec.Y;
			b.Col2.Y = invI * vec.X * vec.X;
			Mat22 mat = a + b;
			mat.Col1.X = mat.Col1.X + this._gamma;
			mat.Col2.Y = mat.Col2.Y + this._gamma;
			this._mass = mat.Invert();
			this._C = body._sweep.C + vec - this._target;
			body._angularVelocity *= 0.98f;
			this._impulse *= step.DtRatio;
			Body expr_21D = body;
			expr_21D._linearVelocity += invMass * this._impulse;
			body._angularVelocity += invI * Vec2.Cross(vec, this._impulse);
		}
		internal override void SolveVelocityConstraints(TimeStep step)
		{
			Body body = this._body2;
			Vec2 a = Box2DX.Common.Math.Mul(body.GetXForm().R, this._localAnchor - body.GetLocalCenter());
			Vec2 v = body._linearVelocity + Vec2.Cross(body._angularVelocity, a);
			Vec2 vec = Box2DX.Common.Math.Mul(this._mass, -(v + this._beta * this._C + this._gamma * this._impulse));
			Vec2 impulse = this._impulse;
			this._impulse += vec;
			float num = step.Dt * this._maxForce;
			if (this._impulse.LengthSquared() > num * num)
			{
				this._impulse *= num / this._impulse.Length();
			}
			vec = this._impulse - impulse;
			Body expr_F5 = body;
			expr_F5._linearVelocity += body._invMass * vec;
			body._angularVelocity += body._invI * Vec2.Cross(a, vec);
		}
		internal override bool SolvePositionConstraints(float baumgarte)
		{
			return true;
		}
	}
}
