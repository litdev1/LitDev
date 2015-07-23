using System;
using System.Runtime.InteropServices;
namespace Box2DX.Common
{
	public class Math
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct Convert
		{
			[FieldOffset(0)]
			public float x;
			[FieldOffset(0)]
			public int i;
		}
		public static readonly float FLOAT32_EPSILON = 1.1920929E-07f;
		public static readonly float FLOAT32_MAX = 3.40282347E+38f;
		public static readonly ushort USHRT_MAX = 65535;
		public static readonly byte UCHAR_MAX = 255;
		public static readonly int RAND_LIMIT = 32767;
		private static Random s_rnd = new Random();
		public static bool IsValid(float x)
		{
			return !float.IsNaN(x) && !float.IsNegativeInfinity(x) && !float.IsPositiveInfinity(x);
		}
		public static float InvSqrt(float x)
		{
			Math.Convert convert = default(Math.Convert);
			convert.x = x;
			float num = 0.5f * x;
			convert.i = 1597463007 - (convert.i >> 1);
			x = convert.x;
			x *= 1.5f - num * x * x;
			return x;
		}
		public static float Sqrt(float x)
		{
			return (float)System.Math.Sqrt((double)x);
		}
		public static float Random()
		{
			float num = (float)(Math.s_rnd.Next() & Math.RAND_LIMIT);
			num /= (float)Math.RAND_LIMIT;
			return 2f * num - 1f;
		}
		public static float Random(float lo, float hi)
		{
			float num = (float)(Math.s_rnd.Next() & Math.RAND_LIMIT);
			num /= (float)Math.RAND_LIMIT;
			return (hi - lo) * num + lo;
		}
		public static uint NextPowerOfTwo(uint x)
		{
			x |= x >> 1;
			x |= x >> 2;
			x |= x >> 4;
			x |= x >> 8;
			x |= x >> 16;
			return x + 1u;
		}
		public static bool IsPowerOfTwo(uint x)
		{
			return x > 0u && (x & x - 1u) == 0u;
		}
		public static float Abs(float a)
		{
			return (a > 0f) ? a : (-a);
		}
		public static Vec2 Abs(Vec2 a)
		{
			Vec2 result = default(Vec2);
			result.Set(Math.Abs(a.X), Math.Abs(a.Y));
			return result;
		}
		public static Mat22 Abs(Mat22 A)
		{
			Mat22 result = default(Mat22);
			result.Set(Math.Abs(A.Col1), Math.Abs(A.Col2));
			return result;
		}
		public static float Min(float a, float b)
		{
			return (a < b) ? a : b;
		}
		public static int Min(int a, int b)
		{
			return (a < b) ? a : b;
		}
		public static Vec2 Min(Vec2 a, Vec2 b)
		{
			return new Vec2
			{
				X = Math.Min(a.X, b.X), 
				Y = Math.Min(a.Y, b.Y)
			};
		}
		public static float Max(float a, float b)
		{
			return (a > b) ? a : b;
		}
		public static int Max(int a, int b)
		{
			return (a > b) ? a : b;
		}
		public static Vec2 Max(Vec2 a, Vec2 b)
		{
			return new Vec2
			{
				X = Math.Max(a.X, b.X), 
				Y = Math.Max(a.Y, b.Y)
			};
		}
		public static float Clamp(float a, float low, float high)
		{
			return Math.Max(low, Math.Min(a, high));
		}
		public static int Clamp(int a, int low, int high)
		{
			return Math.Max(low, Math.Min(a, high));
		}
		public static Vec2 Clamp(Vec2 a, Vec2 low, Vec2 high)
		{
			return Math.Max(low, Math.Min(a, high));
		}
		public static void Swap<T>(ref T a, ref T b)
		{
			T t = a;
			a = b;
			b = t;
		}
		public static Vec2 Mul(Mat22 A, Vec2 v)
		{
			Vec2 result = default(Vec2);
			result.Set(A.Col1.X * v.X + A.Col2.X * v.Y, A.Col1.Y * v.X + A.Col2.Y * v.Y);
			return result;
		}
		public static Vec2 MulT(Mat22 A, Vec2 v)
		{
			Vec2 result = default(Vec2);
			result.Set(Vec2.Dot(v, A.Col1), Vec2.Dot(v, A.Col2));
			return result;
		}
		public static Mat22 Mul(Mat22 A, Mat22 B)
		{
			Mat22 result = default(Mat22);
			result.Set(Math.Mul(A, B.Col1), Math.Mul(A, B.Col2));
			return result;
		}
		public static Mat22 MulT(Mat22 A, Mat22 B)
		{
			Vec2 c = default(Vec2);
			c.Set(Vec2.Dot(A.Col1, B.Col1), Vec2.Dot(A.Col2, B.Col1));
			Vec2 c2 = default(Vec2);
			c2.Set(Vec2.Dot(A.Col1, B.Col2), Vec2.Dot(A.Col2, B.Col2));
			Mat22 result = default(Mat22);
			result.Set(c, c2);
			return result;
		}
		public static Vec2 Mul(XForm T, Vec2 v)
		{
			return T.Position + Math.Mul(T.R, v);
		}
		public static Vec2 MulT(XForm T, Vec2 v)
		{
			return Math.MulT(T.R, v - T.Position);
		}
		public static Vec3 Mul(Mat33 A, Vec3 v)
		{
			return v.X * A.Col1 + v.Y * A.Col2 + v.Z * A.Col3;
		}
	}
}
