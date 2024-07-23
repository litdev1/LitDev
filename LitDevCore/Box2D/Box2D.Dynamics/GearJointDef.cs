using System;
namespace Box2DX.Dynamics
{
	public class GearJointDef : JointDef
	{
		public Joint Joint1;
		public Joint Joint2;
		public float Ratio;
		public GearJointDef()
		{
			this.Type = JointType.GearJoint;
			this.Joint1 = null;
			this.Joint2 = null;
			this.Ratio = 1f;
		}
	}
}
