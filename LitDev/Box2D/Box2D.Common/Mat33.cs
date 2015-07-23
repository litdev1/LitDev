using System;
namespace Box2DX.Common
{
	public struct Mat33
	{
		public Vec3 Col1;
		public Vec3 Col2;
		public Vec3 Col3;
		public Mat33(Vec3 c1, Vec3 c2, Vec3 c3)
		{
			this.Col1 = c1;
			this.Col2 = c2;
			this.Col3 = c3;
		}
		public void SetZero()
		{
			this.Col1.SetZero();
			this.Col2.SetZero();
			this.Col3.SetZero();
		}
		public Vec3 Solve33(Vec3 b)
		{
			float num = Vec3.Dot(this.Col1, Vec3.Cross(this.Col2, this.Col3));
			Box2DXDebug.Assert(num != 0f);
			num = 1f / num;
			return new Vec3
			{
				X = num * Vec3.Dot(b, Vec3.Cross(this.Col2, this.Col3)), 
				Y = num * Vec3.Dot(this.Col1, Vec3.Cross(b, this.Col3)), 
				Z = num * Vec3.Dot(this.Col1, Vec3.Cross(this.Col2, b))
			};
		}
		public Vec2 Solve22(Vec2 b)
		{
			float x = this.Col1.X;
			float x2 = this.Col2.X;
			float y = this.Col1.Y;
			float y2 = this.Col2.Y;
			float num = x * y2 - x2 * y;
			Box2DXDebug.Assert(num != 0f);
			num = 1f / num;
			return new Vec2
			{
				X = num * (y2 * b.X - x2 * b.Y), 
				Y = num * (x * b.Y - y * b.X)
			};
		}
	}
}
