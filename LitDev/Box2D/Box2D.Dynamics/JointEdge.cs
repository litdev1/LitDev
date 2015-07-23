using System;
namespace Box2DX.Dynamics
{
	public class JointEdge
	{
		public Body Other;
		public Joint Joint;
		public JointEdge Prev;
		public JointEdge Next;
	}
}
