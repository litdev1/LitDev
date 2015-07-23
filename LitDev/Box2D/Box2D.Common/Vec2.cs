using System;
namespace Box2DX.Common
{
	public struct Vec2
	{
		public float X;
		public float Y;
		public bool IsValid
		{
			get
			{
				return Math.IsValid(this.X) && Math.IsValid(this.Y);
			}
		}
		public static Vec2 Zero
		{
			get
			{
				return new Vec2(0f, 0f);
			}
		}
		public Vec2(float x, float y)
		{
			this.X = x;
			this.Y = y;
		}
		public void SetZero()
		{
			this.X = 0f;
			this.Y = 0f;
		}
		public void Set(float x, float y)
		{
			this.X = x;
			this.Y = y;
		}
		public float Length()
		{
			return (float)System.Math.Sqrt((double)(this.X * this.X + this.Y * this.Y));
		}
		public float LengthSquared()
		{
			return this.X * this.X + this.Y * this.Y;
		}
		public float Normalize()
		{
			float num = this.Length();
			float result;
			if (num < Math.FLOAT32_EPSILON)
			{
				result = 0f;
			}
			else
			{
				float num2 = 1f / num;
				this.X *= num2;
				this.Y *= num2;
				result = num;
			}
			return result;
		}
		public static Vec2 operator -(Vec2 v1)
		{
			Vec2 result = default(Vec2);
			result.Set(-v1.X, -v1.Y);
			return result;
		}
		public static Vec2 operator +(Vec2 v1, Vec2 v2)
		{
			Vec2 result = default(Vec2);
			result.Set(v1.X + v2.X, v1.Y + v2.Y);
			return result;
		}
		public static Vec2 operator -(Vec2 v1, Vec2 v2)
		{
			Vec2 result = default(Vec2);
			result.Set(v1.X - v2.X, v1.Y - v2.Y);
			return result;
		}
		public static Vec2 operator *(Vec2 v1, float a)
		{
			Vec2 result = default(Vec2);
			result.Set(v1.X * a, v1.Y * a);
			return result;
		}
		public static Vec2 operator *(float a, Vec2 v1)
		{
			Vec2 result = default(Vec2);
			result.Set(v1.X * a, v1.Y * a);
			return result;
		}
		public static bool operator ==(Vec2 a, Vec2 b)
		{
			return a.X == b.X && a.Y == b.Y;
		}
		public static bool operator !=(Vec2 a, Vec2 b)
		{
			return a.X != b.X && a.Y != b.Y;
		}
        // STEVE Added Equals and GetHashCode
        public override bool Equals(object o)
        {
            return this.X == ((Vec2)o).X && this.Y == ((Vec2)o).Y;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        // STEVE
        public static float Dot(Vec2 a, Vec2 b)
		{
			return a.X * b.X + a.Y * b.Y;
		}
		public static float Cross(Vec2 a, Vec2 b)
		{
			return a.X * b.Y - a.Y * b.X;
		}
		public static Vec2 Cross(Vec2 a, float s)
		{
			Vec2 result = default(Vec2);
			result.Set(s * a.Y, -s * a.X);
			return result;
		}
		public static Vec2 Cross(float s, Vec2 a)
		{
			Vec2 result = default(Vec2);
			result.Set(-s * a.Y, s * a.X);
			return result;
		}
		public static float Distance(Vec2 a, Vec2 b)
		{
			return (a - b).Length();
		}
		public static float DistanceSquared(Vec2 a, Vec2 b)
		{
			Vec2 vec = a - b;
			return Vec2.Dot(vec, vec);
		}
	}
}
