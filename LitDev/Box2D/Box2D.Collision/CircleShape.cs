using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class CircleShape : Shape
	{
		private Vec2 _localPosition;
		private float _radius;
		internal CircleShape(ShapeDef def) : base(def)
		{
			Box2DXDebug.Assert(def.Type == ShapeType.CircleShape);
			CircleDef circleDef = (CircleDef)def;
			this._type = ShapeType.CircleShape;
			this._localPosition = circleDef.LocalPosition;
			this._radius = circleDef.Radius;
		}
		internal override void UpdateSweepRadius(Vec2 center)
		{
			this._sweepRadius = (this._localPosition - center).Length() + this._radius - Settings.ToiSlop;
		}
		public override bool TestPoint(XForm transform, Vec2 p)
		{
			Vec2 v = transform.Position + Box2DX.Common.Math.Mul(transform.R, this._localPosition);
			Vec2 vec = p - v;
			return Vec2.Dot(vec, vec) <= this._radius * this._radius;
		}
		public override SegmentCollide TestSegment(XForm transform, out float lambda, out Vec2 normal, Segment segment, float maxLambda)
		{
			lambda = 0f;
			normal = Vec2.Zero;
			Vec2 v = transform.Position + Box2DX.Common.Math.Mul(transform.R, this._localPosition);
			Vec2 vec = segment.P1 - v;
			float num = Vec2.Dot(vec, vec) - this._radius * this._radius;
			SegmentCollide result;
			if (num < 0f)
			{
				lambda = 0f;
				result = SegmentCollide.StartInsideCollide;
			}
			else
			{
				Vec2 vec2 = segment.P2 - segment.P1;
				float num2 = Vec2.Dot(vec, vec2);
				float num3 = Vec2.Dot(vec2, vec2);
				float num4 = num2 * num2 - num3 * num;
				if (num4 < 0f || num3 < Settings.FLT_EPSILON)
				{
					result = SegmentCollide.MissCollide;
				}
				else
				{
					float num5 = -(num2 + Box2DX.Common.Math.Sqrt(num4));
					if (0f <= num5 && num5 <= maxLambda * num3)
					{
						num5 /= num3;
						lambda = num5;
						normal = vec + num5 * vec2;
						normal.Normalize();
						result = SegmentCollide.HitCollide;
					}
					else
					{
						result = SegmentCollide.MissCollide;
					}
				}
			}
			return result;
		}
		public override void ComputeAABB(out AABB aabb, XForm transform)
		{
			aabb = default(AABB);
			Vec2 vec = transform.Position + Box2DX.Common.Math.Mul(transform.R, this._localPosition);
			aabb.LowerBound.Set(vec.X - this._radius, vec.Y - this._radius);
			aabb.UpperBound.Set(vec.X + this._radius, vec.Y + this._radius);
		}
		public override void ComputeSweptAABB(out AABB aabb, XForm transform1, XForm transform2)
		{
			aabb = default(AABB);
			Vec2 a = transform1.Position + Box2DX.Common.Math.Mul(transform1.R, this._localPosition);
			Vec2 b = transform2.Position + Box2DX.Common.Math.Mul(transform2.R, this._localPosition);
			Vec2 vec = Box2DX.Common.Math.Min(a, b);
			Vec2 vec2 = Box2DX.Common.Math.Max(a, b);
			aabb.LowerBound.Set(vec.X - this._radius, vec.Y - this._radius);
			aabb.UpperBound.Set(vec2.X + this._radius, vec2.Y + this._radius);
		}
		public override void ComputeMass(out MassData massData)
		{
			massData = default(MassData);
			massData.Mass = this._density * Settings.Pi * this._radius * this._radius;
			massData.Center = this._localPosition;
			massData.I = massData.Mass * (0.5f * this._radius * this._radius + Vec2.Dot(this._localPosition, this._localPosition));
		}
		public Vec2 GetLocalPosition()
		{
			return this._localPosition;
		}
		public float GetRadius()
		{
			return this._radius;
		}
	}
}
