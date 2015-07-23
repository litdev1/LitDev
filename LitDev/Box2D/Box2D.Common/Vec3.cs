using System;
namespace Box2DX.Common
{
	public struct Vec3
	{
		public float X;
		public float Y;
		public float Z;
		public Vec3(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}
		public void SetZero()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
		}
		public void Set(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}
		public static float Dot(Vec3 a, Vec3 b)
		{
			return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
		}
		public static Vec3 Cross(Vec3 a, Vec3 b)
		{
			return new Vec3(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
		}
		public static Vec3 operator -(Vec3 v)
		{
			return new Vec3(-v.X, -v.Y, -v.Z);
		}
		public static Vec3 operator +(Vec3 v1, Vec3 v2)
		{
			return new Vec3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
		}
		public static Vec3 operator -(Vec3 v1, Vec3 v2)
		{
			return new Vec3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
		}
		public static Vec3 operator *(Vec3 v, float s)
		{
			return new Vec3(v.X * s, v.Y * s, v.Z * s);
		}
		public static Vec3 operator *(float s, Vec3 v)
		{
			return new Vec3(v.X * s, v.Y * s, v.Z * s);
		}
	}
}
