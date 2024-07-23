using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public struct OBB
	{
		public Mat22 R;
		public Vec2 Center;
		public Vec2 Extents;
	}
}
