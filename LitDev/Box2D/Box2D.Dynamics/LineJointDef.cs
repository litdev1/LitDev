using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class LineJointDef : JointDef
	{
		public Vec2 localAnchor1;
		public Vec2 localAnchor2;
		public Vec2 localAxis1;
		public bool enableLimit;
		public float lowerTranslation;
		public float upperTranslation;
		public bool enableMotor;
		public float maxMotorForce;
		public float motorSpeed;
		public LineJointDef()
		{
			this.Type = JointType.LineJoint;
			this.localAnchor1.SetZero();
			this.localAnchor2.SetZero();
			this.localAxis1.Set(1f, 0f);
			this.enableLimit = false;
			this.lowerTranslation = 0f;
			this.upperTranslation = 0f;
			this.enableMotor = false;
			this.maxMotorForce = 0f;
			this.motorSpeed = 0f;
		}
		public void Initialize(Body body1, Body body2, Vec2 anchor, Vec2 axis)
		{
			this.Body1 = body1;
			this.Body2 = body2;
			this.localAnchor1 = body1.GetLocalPoint(anchor);
			this.localAnchor2 = body2.GetLocalPoint(anchor);
			this.localAxis1 = body1.GetLocalVector(axis);
		}
	}
}
