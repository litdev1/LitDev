using System;
namespace Box2DX.Common
{
	public struct Mat22
	{
		public Vec2 Col1;
		public Vec2 Col2;
		public static Mat22 Identity
		{
			get
			{
				return new Mat22(1f, 0f, 0f, 1f);
			}
		}
		public Mat22(Vec2 c1, Vec2 c2)
		{
			this.Col1 = c1;
			this.Col2 = c2;
		}
		public Mat22(float a11, float a12, float a21, float a22)
		{
			this.Col1.X = a11;
			this.Col1.Y = a21;
			this.Col2.X = a12;
			this.Col2.Y = a22;
		}
		public Mat22(float angle)
		{
			float num = (float)System.Math.Cos((double)angle);
			float num2 = (float)System.Math.Sin((double)angle);
			this.Col1.X = num;
			this.Col2.X = -num2;
			this.Col1.Y = num2;
			this.Col2.Y = num;
		}
		public void Set(Vec2 c1, Vec2 c2)
		{
			this.Col1 = c1;
			this.Col2 = c2;
		}
		public void Set(float angle)
		{
			float num = (float)System.Math.Cos((double)angle);
			float num2 = (float)System.Math.Sin((double)angle);
			this.Col1.X = num;
			this.Col2.X = -num2;
			this.Col1.Y = num2;
			this.Col2.Y = num;
		}
		public void SetIdentity()
		{
			this.Col1.X = 1f;
			this.Col2.X = 0f;
			this.Col1.Y = 0f;
			this.Col2.Y = 1f;
		}
		public void SetZero()
		{
			this.Col1.X = 0f;
			this.Col2.X = 0f;
			this.Col1.Y = 0f;
			this.Col2.Y = 0f;
		}
		public float GetAngle()
		{
			return (float)System.Math.Atan2((double)this.Col1.Y, (double)this.Col1.X);
		}
		public Mat22 Invert()
		{
			float x = this.Col1.X;
			float x2 = this.Col2.X;
			float y = this.Col1.Y;
			float y2 = this.Col2.Y;
			Mat22 result = default(Mat22);
			float num = x * y2 - x2 * y;
			Box2DXDebug.Assert(num != 0f);
			num = 1f / num;
			result.Col1.X = num * y2;
			result.Col2.X = -num * x2;
			result.Col1.Y = -num * y;
			result.Col2.Y = num * x;
			return result;
		}
		public Vec2 Solve(Vec2 b)
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
		public static Mat22 operator +(Mat22 A, Mat22 B)
		{
			Mat22 result = default(Mat22);
			result.Set(A.Col1 + B.Col1, A.Col2 + B.Col2);
			return result;
		}
	}
}
