using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class CircleDef : ShapeDef
	{
		public Vec2 LocalPosition;
		public float Radius;
		public CircleDef()
		{
			this.Type = ShapeType.CircleShape;
			this.LocalPosition = Vec2.Zero;
			this.Radius = 1f;
		}
	}
}
