using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class PolygonDef : ShapeDef
	{
		public int VertexCount;
		public Vec2[] Vertices = new Vec2[Settings.MaxPolygonVertices];
		public PolygonDef()
		{
			this.Type = ShapeType.PolygonShape;
			this.VertexCount = 0;
		}
		public void SetAsBox(float hx, float hy)
		{
			this.VertexCount = 4;
			this.Vertices[0].Set(-hx, -hy);
			this.Vertices[1].Set(hx, -hy);
			this.Vertices[2].Set(hx, hy);
			this.Vertices[3].Set(-hx, hy);
		}
		public void SetAsBox(float hx, float hy, Vec2 center, float angle)
		{
			this.SetAsBox(hx, hy);
			XForm t = default(XForm);
			t.Position = center;
			t.R.Set(angle);
			for (int i = 0; i < this.VertexCount; i++)
			{
				this.Vertices[i] = Box2DX.Common.Math.Mul(t, this.Vertices[i]);
			}
		}
	}
}
