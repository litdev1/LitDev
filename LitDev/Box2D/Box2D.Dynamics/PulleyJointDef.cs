using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class PulleyJointDef : JointDef
	{
		public Vec2 GroundAnchor1;
		public Vec2 GroundAnchor2;
		public Vec2 LocalAnchor1;
		public Vec2 LocalAnchor2;
		public float Length1;
		public float MaxLength1;
		public float Length2;
		public float MaxLength2;
		public float Ratio;
		public PulleyJointDef()
		{
			this.Type = JointType.PulleyJoint;
			this.GroundAnchor1.Set(-1f, 1f);
			this.GroundAnchor2.Set(1f, 1f);
			this.LocalAnchor1.Set(-1f, 0f);
			this.LocalAnchor2.Set(1f, 0f);
			this.Length1 = 0f;
			this.MaxLength1 = 0f;
			this.Length2 = 0f;
			this.MaxLength2 = 0f;
			this.Ratio = 1f;
			this.CollideConnected = true;
		}
		public void Initialize(Body body1, Body body2, Vec2 groundAnchor1, Vec2 groundAnchor2, Vec2 anchor1, Vec2 anchor2, float ratio)
		{
			this.Body1 = body1;
			this.Body2 = body2;
			this.GroundAnchor1 = groundAnchor1;
			this.GroundAnchor2 = groundAnchor2;
			this.LocalAnchor1 = body1.GetLocalPoint(anchor1);
			this.LocalAnchor2 = body2.GetLocalPoint(anchor2);
			this.Length1 = (anchor1 - groundAnchor1).Length();
			this.Length2 = (anchor2 - groundAnchor2).Length();
			this.Ratio = ratio;
			Box2DXDebug.Assert(ratio > Settings.FLT_EPSILON);
			float num = this.Length1 + ratio * this.Length2;
			this.MaxLength1 = num - ratio * PulleyJoint.MinPulleyLength;
			this.MaxLength2 = (num - PulleyJoint.MinPulleyLength) / ratio;
		}
	}
}
