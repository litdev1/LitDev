using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public struct Segment
	{
		public Vec2 P1;
		public Vec2 P2;
		public bool TestSegment(out float lambda, out Vec2 normal, Segment segment, float maxLambda)
		{
			lambda = 0f;
			normal = default(Vec2);
			Vec2 p = segment.P1;
			Vec2 a = segment.P2 - p;
			Vec2 a2 = this.P2 - this.P1;
			Vec2 vec = Vec2.Cross(a2, 1f);
			float num = 100f * Settings.FLT_EPSILON;
			float num2 = -Vec2.Dot(a, vec);
			bool result;
			if (num2 > num)
			{
				Vec2 a3 = p - this.P1;
				float num3 = Vec2.Dot(a3, vec);
				if (0f <= num3 && num3 <= maxLambda * num2)
				{
					float num4 = -a.X * a3.Y + a.Y * a3.X;
					if (-num * num2 <= num4 && num4 <= num2 * (1f + num))
					{
						num3 /= num2;
						vec.Normalize();
						lambda = num3;
						normal = vec;
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}
	}
}
