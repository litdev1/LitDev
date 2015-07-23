using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class PolygonShape : Shape, Collision.IGenericShape
	{
		private Vec2 _centroid;
		private OBB _obb;
		private int _vertexCount;
		private Vec2[] _vertices = new Vec2[Settings.MaxPolygonVertices];
		private Vec2[] _coreVertices = new Vec2[Settings.MaxPolygonVertices];
		private Vec2[] _normals = new Vec2[Settings.MaxPolygonVertices];
		public int VertexCount
		{
			get
			{
				return this._vertexCount;
			}
		}
		public Vec2[] Normals
		{
			get
			{
				return this._normals;
			}
		}
		public Vec2 GetCentroid()
		{
			return this._centroid;
		}
		public OBB GetOBB()
		{
			return this._obb;
		}
		public Vec2[] GetVertices()
		{
			return this._vertices;
		}
		public Vec2[] GetCoreVertices()
		{
			return this._coreVertices;
		}
		public Vec2 GetFirstVertex(XForm xf)
		{
			return Box2DX.Common.Math.Mul(xf, this._coreVertices[0]);
		}
		public Vec2 Centroid(XForm xf)
		{
			return Box2DX.Common.Math.Mul(xf, this._centroid);
		}
		public Vec2 Support(XForm xf, Vec2 d)
		{
			Vec2 b = Box2DX.Common.Math.MulT(xf.R, d);
			int num = 0;
			float num2 = Vec2.Dot(this._coreVertices[0], b);
			for (int i = 1; i < this._vertexCount; i++)
			{
				float num3 = Vec2.Dot(this._coreVertices[i], b);
				if (num3 > num2)
				{
					num = i;
					num2 = num3;
				}
			}
			return Box2DX.Common.Math.Mul(xf, this._coreVertices[num]);
		}
		internal PolygonShape(ShapeDef def) : base(def)
		{
			Box2DXDebug.Assert(def.Type == ShapeType.PolygonShape);
			this._type = ShapeType.PolygonShape;
			PolygonDef polygonDef = (PolygonDef)def;
			this._vertexCount = polygonDef.VertexCount;
			Box2DXDebug.Assert(3 <= this._vertexCount && this._vertexCount <= Settings.MaxPolygonVertices);
			for (int i = 0; i < this._vertexCount; i++)
			{
				this._vertices[i] = polygonDef.Vertices[i];
			}
			for (int i = 0; i < this._vertexCount; i++)
			{
				int num = i;
				int num2 = (i + 1 < this._vertexCount) ? (i + 1) : 0;
				Vec2 a = this._vertices[num2] - this._vertices[num];
				Box2DXDebug.Assert(a.LengthSquared() > Settings.FLT_EPSILON * Settings.FLT_EPSILON);
				this._normals[i] = Vec2.Cross(a, 1f);
				this._normals[i].Normalize();
			}
			for (int i = 0; i < this._vertexCount; i++)
			{
				for (int j = 0; j < this._vertexCount; j++)
				{
					if (j != i && j != (i + 1) % this._vertexCount)
					{
						float num3 = Vec2.Dot(this._normals[i], this._vertices[j] - this._vertices[i]);
						Box2DXDebug.Assert(num3 < -Settings.LinearSlop);
					}
				}
			}
			for (int i = 1; i < this._vertexCount; i++)
			{
				float num4 = Vec2.Cross(this._normals[i - 1], this._normals[i]);
				num4 = Box2DX.Common.Math.Clamp(num4, -1f, 1f);
				float num5 = (float)System.Math.Asin((double)num4);
				Box2DXDebug.Assert(num5 > Settings.AngularSlop);
			}
			this._centroid = PolygonShape.ComputeCentroid(polygonDef.Vertices, polygonDef.VertexCount);
			PolygonShape.ComputeOBB(out this._obb, this._vertices, this._vertexCount);
			for (int i = 0; i < this._vertexCount; i++)
			{
				int num = (i - 1 >= 0) ? (i - 1) : (this._vertexCount - 1);
				int num2 = i;
				Vec2 a2 = this._normals[num];
				Vec2 a3 = this._normals[num2];
				Vec2 b = this._vertices[i] - this._centroid;
				Vec2 b2 = default(Vec2);
				b2.X = Vec2.Dot(a2, b) - Settings.ToiSlop;
				b2.Y = Vec2.Dot(a3, b) - Settings.ToiSlop;
				Box2DXDebug.Assert(b2.X >= 0f);
				Box2DXDebug.Assert(b2.Y >= 0f);
				Mat22 mat = default(Mat22);
				mat.Col1.X = a2.X;
				mat.Col2.X = a2.Y;
				mat.Col1.Y = a3.X;
				mat.Col2.Y = a3.Y;
				this._coreVertices[i] = mat.Solve(b2) + this._centroid;
			}
		}
		internal override void UpdateSweepRadius(Vec2 center)
		{
			this._sweepRadius = 0f;
			for (int i = 0; i < this._vertexCount; i++)
			{
				Vec2 vec = this._coreVertices[i] - center;
				this._sweepRadius = Box2DX.Common.Math.Max(this._sweepRadius, vec.Length());
			}
		}
		public override bool TestPoint(XForm xf, Vec2 p)
		{
			Vec2 v = Box2DX.Common.Math.MulT(xf.R, p - xf.Position);
			bool result;
			for (int i = 0; i < this._vertexCount; i++)
			{
				float num = Vec2.Dot(this._normals[i], v - this._vertices[i]);
				if (num > 0f)
				{
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}
		public override SegmentCollide TestSegment(XForm xf, out float lambda, out Vec2 normal, Segment segment, float maxLambda)
		{
			lambda = 0f;
			normal = Vec2.Zero;
			float num = 0f;
			float num2 = maxLambda;
			Vec2 v = Box2DX.Common.Math.MulT(xf.R, segment.P1 - xf.Position);
			Vec2 v2 = Box2DX.Common.Math.MulT(xf.R, segment.P2 - xf.Position);
			Vec2 b = v2 - v;
			int num3 = -1;
			int i = 0;
			SegmentCollide result;
			while (i < this._vertexCount)
			{
				float num4 = Vec2.Dot(this._normals[i], this._vertices[i] - v);
				float num5 = Vec2.Dot(this._normals[i], b);
				if (num5 == 0f)
				{
					if (num4 < 0f)
					{
						result = SegmentCollide.MissCollide;
						return result;
					}
				}
				else
				{
					if (num5 < 0f && num4 < num * num5)
					{
						num = num4 / num5;
						num3 = i;
					}
					else
					{
						if (num5 > 0f && num4 < num2 * num5)
						{
							num2 = num4 / num5;
						}
					}
				}
				if (num2 >= num)
				{
					i++;
					continue;
				}
				result = SegmentCollide.MissCollide;
				return result;
			}
			Box2DXDebug.Assert(0f <= num && num <= maxLambda);
			if (num3 >= 0)
			{
				lambda = num;
				normal = Box2DX.Common.Math.Mul(xf.R, this._normals[num3]);
				result = SegmentCollide.HitCollide;
				return result;
			}
			lambda = 0f;
			result = SegmentCollide.StartInsideCollide;
			return result;
		}
		public override void ComputeAABB(out AABB aabb, XForm xf)
		{
			Mat22 a = Box2DX.Common.Math.Mul(xf.R, this._obb.R);
			Mat22 a2 = Box2DX.Common.Math.Abs(a);
			Vec2 v = Box2DX.Common.Math.Mul(a2, this._obb.Extents);
			Vec2 v2 = xf.Position + Box2DX.Common.Math.Mul(xf.R, this._obb.Center);
			aabb.LowerBound = v2 - v;
			aabb.UpperBound = v2 + v;
		}
		public override void ComputeSweptAABB(out AABB aabb, XForm transform1, XForm transform2)
		{
			AABB aABB;
			this.ComputeAABB(out aABB, transform1);
			AABB aABB2;
			this.ComputeAABB(out aABB2, transform2);
			aabb.LowerBound = Box2DX.Common.Math.Min(aABB.LowerBound, aABB2.LowerBound);
			aabb.UpperBound = Box2DX.Common.Math.Max(aABB.UpperBound, aABB2.UpperBound);
		}
		public override void ComputeMass(out MassData massData)
		{
			Box2DXDebug.Assert(this._vertexCount >= 3);
			Vec2 vec = default(Vec2);
			vec.Set(0f, 0f);
			float num = 0f;
			float num2 = 0f;
			Vec2 vec2 = new Vec2(0f, 0f);
			float num3 = 0.333333343f;
			for (int i = 0; i < this._vertexCount; i++)
			{
				Vec2 vec3 = vec2;
				Vec2 vec4 = this._vertices[i];
				Vec2 vec5 = (i + 1 < this._vertexCount) ? this._vertices[i + 1] : this._vertices[0];
				Vec2 a = vec4 - vec3;
				Vec2 b = vec5 - vec3;
				float num4 = Vec2.Cross(a, b);
				float num5 = 0.5f * num4;
				num += num5;
				vec += num5 * num3 * (vec3 + vec4 + vec5);
				float x = vec3.X;
				float y = vec3.Y;
				float x2 = a.X;
				float y2 = a.Y;
				float x3 = b.X;
				float y3 = b.Y;
				float num6 = num3 * (0.25f * (x2 * x2 + x3 * x2 + x3 * x3) + (x * x2 + x * x3)) + 0.5f * x * x;
				float num7 = num3 * (0.25f * (y2 * y2 + y3 * y2 + y3 * y3) + (y * y2 + y * y3)) + 0.5f * y * y;
				num2 += num4 * (num6 + num7);
			}
            massData.Mass = this._density * num;
			Box2DXDebug.Assert(num > Settings.FLT_EPSILON);
			vec *= 1f / num;
			massData.Center = vec;
			massData.I = this._density * num2;
		}
		public static Vec2 ComputeCentroid(Vec2[] vs, int count)
		{
			Box2DXDebug.Assert(count >= 3);
			Vec2 vec = default(Vec2);
			vec.Set(0f, 0f);
			float num = 0f;
			Vec2 vec2 = new Vec2(0f, 0f);
			float num2 = 0.333333343f;
			for (int i = 0; i < count; i++)
			{
				Vec2 vec3 = vec2;
				Vec2 vec4 = vs[i];
				Vec2 vec5 = (i + 1 < count) ? vs[i + 1] : vs[0];
				Vec2 a = vec4 - vec3;
				Vec2 b = vec5 - vec3;
				float num3 = Vec2.Cross(a, b);
				float num4 = 0.5f * num3;
				num += num4;
				vec += num4 * num2 * (vec3 + vec4 + vec5);
			}
			Box2DXDebug.Assert(num > Settings.FLT_EPSILON);
			vec *= 1f / num;
			return vec;
		}
		public static void ComputeOBB(out OBB obb, Vec2[] vs, int count)
		{
			obb = default(OBB);
			Box2DXDebug.Assert(count <= Settings.MaxPolygonVertices);
			Vec2[] array = new Vec2[Settings.MaxPolygonVertices + 1];
			for (int i = 0; i < count; i++)
			{
				array[i] = vs[i];
			}
			array[count] = array[0];
			float num = Settings.FLT_MAX;
			for (int i = 1; i <= count; i++)
			{
				Vec2 vec = array[i - 1];
				Vec2 vec2 = array[i] - vec;
				float num2 = vec2.Normalize();
				Box2DXDebug.Assert(num2 > Settings.FLT_EPSILON);
				Vec2 vec3 = new Vec2(-vec2.Y, vec2.X);
				Vec2 vec4 = new Vec2(Settings.FLT_MAX, Settings.FLT_MAX);
				Vec2 vec5 = new Vec2(-Settings.FLT_MAX, -Settings.FLT_MAX);
				for (int j = 0; j < count; j++)
				{
					Vec2 b = array[j] - vec;
					Vec2 b2 = default(Vec2);
					b2.X = Vec2.Dot(vec2, b);
					b2.Y = Vec2.Dot(vec3, b);
					vec4 = Box2DX.Common.Math.Min(vec4, b2);
					vec5 = Box2DX.Common.Math.Max(vec5, b2);
				}
				float num3 = (vec5.X - vec4.X) * (vec5.Y - vec4.Y);
				if (num3 < 0.95f * num)
				{
					num = num3;
					obb.R.Col1 = vec2;
					obb.R.Col2 = vec3;
					Vec2 v = 0.5f * (vec4 + vec5);
					obb.Center = vec + Box2DX.Common.Math.Mul(obb.R, v);
					obb.Extents = 0.5f * (vec5 - vec4);
				}
			}
			Box2DXDebug.Assert(num < Settings.FLT_MAX);
		}
	}
}
