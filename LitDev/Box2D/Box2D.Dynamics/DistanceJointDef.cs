using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class DistanceJointDef : JointDef
	{
		public Vec2 LocalAnchor1;
		public Vec2 LocalAnchor2;
		public float Length;
		public float FrequencyHz;
		public float DampingRatio;
		public DistanceJointDef()
		{
			this.Type = JointType.DistanceJoint;
			this.LocalAnchor1.Set(0f, 0f);
			this.LocalAnchor2.Set(0f, 0f);
			this.Length = 1f;
			this.FrequencyHz = 0f;
			this.DampingRatio = 0f;
		}
		public void Initialize(Body body1, Body body2, Vec2 anchor1, Vec2 anchor2)
		{
			this.Body1 = body1;
			this.Body2 = body2;
			this.LocalAnchor1 = body1.GetLocalPoint(anchor1);
			this.LocalAnchor2 = body2.GetLocalPoint(anchor2);
			this.Length = (anchor2 - anchor1).Length();
		}
	}
}
