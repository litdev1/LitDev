using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class RevoluteJointDef : JointDef
	{
		public Vec2 LocalAnchor1;
		public Vec2 LocalAnchor2;
		public float ReferenceAngle;
		public bool EnableLimit;
		public float LowerAngle;
		public float UpperAngle;
		public bool EnableMotor;
		public float MotorSpeed;
		public float MaxMotorTorque;
		public RevoluteJointDef()
		{
			this.Type = JointType.RevoluteJoint;
			this.LocalAnchor1.Set(0f, 0f);
			this.LocalAnchor2.Set(0f, 0f);
			this.ReferenceAngle = 0f;
			this.LowerAngle = 0f;
			this.UpperAngle = 0f;
			this.MaxMotorTorque = 0f;
			this.MotorSpeed = 0f;
			this.EnableLimit = false;
			this.EnableMotor = false;
		}
		public void Initialize(Body body1, Body body2, Vec2 anchor)
		{
			this.Body1 = body1;
			this.Body2 = body2;
			this.LocalAnchor1 = body1.GetLocalPoint(anchor);
			this.LocalAnchor2 = body2.GetLocalPoint(anchor);
			this.ReferenceAngle = body2.GetAngle() - body1.GetAngle();
		}
	}
}
