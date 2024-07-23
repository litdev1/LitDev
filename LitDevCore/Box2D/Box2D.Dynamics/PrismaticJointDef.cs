using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class PrismaticJointDef : JointDef
	{
		public Vec2 LocalAnchor1;
		public Vec2 LocalAnchor2;
		public Vec2 LocalAxis1;
		public float ReferenceAngle;
		public bool EnableLimit;
		public float LowerTranslation;
		public float UpperTranslation;
		public bool EnableMotor;
		public float MaxMotorForce;
		public float MotorSpeed;
		public PrismaticJointDef()
		{
			this.Type = JointType.PrismaticJoint;
			this.LocalAnchor1.SetZero();
			this.LocalAnchor2.SetZero();
			this.LocalAxis1.Set(1f, 0f);
			this.ReferenceAngle = 0f;
			this.EnableLimit = false;
			this.LowerTranslation = 0f;
			this.UpperTranslation = 0f;
			this.EnableMotor = false;
			this.MaxMotorForce = 0f;
			this.MotorSpeed = 0f;
		}
		public void Initialize(Body body1, Body body2, Vec2 anchor, Vec2 axis)
		{
			this.Body1 = body1;
			this.Body2 = body2;
			this.LocalAnchor1 = body1.GetLocalPoint(anchor);
			this.LocalAnchor2 = body2.GetLocalPoint(anchor);
			this.LocalAxis1 = body1.GetLocalVector(axis);
			this.ReferenceAngle = body2.GetAngle() - body1.GetAngle();
		}
	}
}
