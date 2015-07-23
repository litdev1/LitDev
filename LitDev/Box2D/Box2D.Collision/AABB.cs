using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public struct AABB
	{
		public Vec2 LowerBound;
		public Vec2 UpperBound;
		public bool IsValid
		{
			get
			{
				Vec2 vec = this.UpperBound - this.LowerBound;
				bool flag = vec.X >= 0f && vec.Y >= 0f;
				return flag && this.LowerBound.IsValid && this.UpperBound.IsValid;
			}
		}
	}
}
