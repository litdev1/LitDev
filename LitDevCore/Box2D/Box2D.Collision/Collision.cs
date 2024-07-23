using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class Collision
	{
		public interface IGenericShape
		{
			Vec2 Support(XForm xf, Vec2 v);
			Vec2 GetFirstVertex(XForm xf);
		}
		public class Point : Collision.IGenericShape
		{
			public Vec2 p;
			public Vec2 Support(XForm xf, Vec2 v)
			{
				return this.p;
			}
			public Vec2 GetFirstVertex(XForm xf)
			{
				return this.p;
			}
		}
		public struct ClipVertex
		{
			public Vec2 V;
			public ContactID ID;
		}
		public static int GJKIterations = 0;
		public static readonly byte NullFeature = Box2DX.Common.Math.UCHAR_MAX;
		public static void CollideCircles(ref Manifold manifold, CircleShape circle1, XForm xf1, CircleShape circle2, XForm xf2)
		{
			manifold.PointCount = 0;
			Vec2 vec = Box2DX.Common.Math.Mul(xf1, circle1.GetLocalPosition());
			Vec2 vec2 = Box2DX.Common.Math.Mul(xf2, circle2.GetLocalPosition());
			Vec2 vec3 = vec2 - vec;
			float num = Vec2.Dot(vec3, vec3);
			float radius = circle1.GetRadius();
			float radius2 = circle2.GetRadius();
			float num2 = radius + radius2;
			if (num <= num2 * num2)
			{
				float separation;
				if (num < Settings.FLT_EPSILON)
				{
					separation = -num2;
					manifold.Normal.Set(0f, 1f);
				}
				else
				{
					float num3 = Box2DX.Common.Math.Sqrt(num);
					separation = num3 - num2;
					float num4 = 1f / num3;
					manifold.Normal.X = num4 * vec3.X;
					manifold.Normal.Y = num4 * vec3.Y;
				}
				manifold.PointCount = 1;
				manifold.Points[0].ID.Key = 0u;
				manifold.Points[0].Separation = separation;
				vec += radius * manifold.Normal;
				vec2 -= radius2 * manifold.Normal;
				Vec2 v = 0.5f * (vec + vec2);
				manifold.Points[0].LocalPoint1 = Box2DX.Common.Math.MulT(xf1, v);
				manifold.Points[0].LocalPoint2 = Box2DX.Common.Math.MulT(xf2, v);
			}
		}
		public static void CollidePolygonAndCircle(ref Manifold manifold, PolygonShape polygon, XForm xf1, CircleShape circle, XForm xf2)
		{
			manifold.PointCount = 0;
			Vec2 vec = Box2DX.Common.Math.Mul(xf2, circle.GetLocalPosition());
			Vec2 v = Box2DX.Common.Math.MulT(xf1, vec);
			int num = 0;
			float num2 = -Settings.FLT_MAX;
			float radius = circle.GetRadius();
			int vertexCount = polygon.VertexCount;
			Vec2[] vertices = polygon.GetVertices();
			Vec2[] normals = polygon.Normals;
			for (int i = 0; i < vertexCount; i++)
			{
				float num3 = Vec2.Dot(normals[i], v - vertices[i]);
				if (num3 > radius)
				{
					return;
				}
				if (num3 > num2)
				{
					num2 = num3;
					num = i;
				}
			}
			if (num2 < Settings.FLT_EPSILON)
			{
				manifold.PointCount = 1;
				manifold.Normal = Box2DX.Common.Math.Mul(xf1.R, normals[num]);
				manifold.Points[0].ID.Features.IncidentEdge = (byte)num;
				manifold.Points[0].ID.Features.IncidentVertex = Collision.NullFeature;
				manifold.Points[0].ID.Features.ReferenceEdge = 0;
				manifold.Points[0].ID.Features.Flip = 0;
				Vec2 v2 = vec - radius * manifold.Normal;
				manifold.Points[0].LocalPoint1 = Box2DX.Common.Math.MulT(xf1, v2);
				manifold.Points[0].LocalPoint2 = Box2DX.Common.Math.MulT(xf2, v2);
				manifold.Points[0].Separation = num2 - radius;
				return;
			}
			int num4 = num;
			int num5 = (num4 + 1 < vertexCount) ? (num4 + 1) : 0;
			Vec2 vec2 = vertices[num5] - vertices[num4];
			float num6 = vec2.Normalize();
			Box2DXDebug.Assert(num6 > Settings.FLT_EPSILON);
			float num7 = Vec2.Dot(v - vertices[num4], vec2);
			Vec2 v3;
			if (num7 <= 0f)
			{
				v3 = vertices[num4];
				manifold.Points[0].ID.Features.IncidentEdge = Collision.NullFeature;
				manifold.Points[0].ID.Features.IncidentVertex = (byte)num4;
			}
			else
			{
				if (num7 >= num6)
				{
					v3 = vertices[num5];
					manifold.Points[0].ID.Features.IncidentEdge = Collision.NullFeature;
					manifold.Points[0].ID.Features.IncidentVertex = (byte)num5;
				}
				else
				{
					v3 = vertices[num4] + num7 * vec2;
					manifold.Points[0].ID.Features.IncidentEdge = (byte)num;
					manifold.Points[0].ID.Features.IncidentVertex = Collision.NullFeature;
				}
			}
			Vec2 v4 = v - v3;
			float num8 = v4.Normalize();
			if (num8 > radius)
			{
				return;
			}
			manifold.PointCount = 1;
			manifold.Normal = Box2DX.Common.Math.Mul(xf1.R, v4);
			Vec2 v5 = vec - radius * manifold.Normal;
			manifold.Points[0].LocalPoint1 = Box2DX.Common.Math.MulT(xf1, v5);
			manifold.Points[0].LocalPoint2 = Box2DX.Common.Math.MulT(xf2, v5);
			manifold.Points[0].Separation = num8 - radius;
			manifold.Points[0].ID.Features.ReferenceEdge = 0;
			manifold.Points[0].ID.Features.Flip = 0;
		}
		public static int ProcessTwo(out Vec2 x1, out Vec2 x2, ref Vec2[] p1s, ref Vec2[] p2s, ref Vec2[] points)
		{
			Vec2 a = -points[1];
			Vec2 b = points[0] - points[1];
			float num = b.Normalize();
			float num2 = Vec2.Dot(a, b);
			int result;
			if (num2 <= 0f || num < Settings.FLT_EPSILON)
			{
				x1 = p1s[1];
				x2 = p2s[1];
				p1s[0] = p1s[1];
				p2s[0] = p2s[1];
				points[0] = points[1];
				result = 1;
			}
			else
			{
				num2 /= num;
				x1 = p1s[1] + num2 * (p1s[0] - p1s[1]);
				x2 = p2s[1] + num2 * (p2s[0] - p2s[1]);
				result = 2;
			}
			return result;
		}
		public static int ProcessThree(out Vec2 x1, out Vec2 x2, ref Vec2[] p1s, ref Vec2[] p2s, ref Vec2[] points)
		{
			Vec2 vec = points[0];
			Vec2 vec2 = points[1];
			Vec2 vec3 = points[2];
			Vec2 vec4 = vec2 - vec;
			Vec2 b = vec3 - vec;
			Vec2 b2 = vec3 - vec2;
			float num = -Vec2.Dot(vec, vec4);
			float num2 = Vec2.Dot(vec2, vec4);
			float num3 = -Vec2.Dot(vec, b);
			float num4 = Vec2.Dot(vec3, b);
			float num5 = -Vec2.Dot(vec2, b2);
			float num6 = Vec2.Dot(vec3, b2);
			int result;
			if (num4 <= 0f && num6 <= 0f)
			{
				x1 = p1s[2];
				x2 = p2s[2];
				p1s[0] = p1s[2];
				p2s[0] = p2s[2];
				points[0] = points[2];
				result = 1;
			}
			else
			{
				Box2DXDebug.Assert(num > 0f || num3 > 0f);
				Box2DXDebug.Assert(num2 > 0f || num5 > 0f);
				float num7 = Vec2.Cross(vec4, b);
				float num8 = num7 * Vec2.Cross(vec, vec2);
				Box2DXDebug.Assert(num8 > 0f || num > 0f || num2 > 0f);
				float num9 = num7 * Vec2.Cross(vec2, vec3);
				if (num9 <= 0f && num5 >= 0f && num6 >= 0f && num5 + num6 > 0f)
				{
					Box2DXDebug.Assert(num5 + num6 > 0f);
					float a = num5 / (num5 + num6);
					x1 = p1s[1] + a * (p1s[2] - p1s[1]);
					x2 = p2s[1] + a * (p2s[2] - p2s[1]);
					p1s[0] = p1s[2];
					p2s[0] = p2s[2];
					points[0] = points[2];
					result = 2;
				}
				else
				{
					float num10 = num7 * Vec2.Cross(vec3, vec);
					if (num10 <= 0f && num3 >= 0f && num4 >= 0f && num3 + num4 > 0f)
					{
						Box2DXDebug.Assert(num3 + num4 > 0f);
						float a = num3 / (num3 + num4);
						x1 = p1s[0] + a * (p1s[2] - p1s[0]);
						x2 = p2s[0] + a * (p2s[2] - p2s[0]);
						p1s[1] = p1s[2];
						p2s[1] = p2s[2];
						points[1] = points[2];
						result = 2;
					}
					else
					{
						float num11 = num9 + num10 + num8;
						Box2DXDebug.Assert(num11 > 0f);
						num11 = 1f / num11;
						float num12 = num9 * num11;
						float num13 = num10 * num11;
						float a2 = 1f - num12 - num13;
						x1 = num12 * p1s[0] + num13 * p1s[1] + a2 * p1s[2];
						x2 = num12 * p2s[0] + num13 * p2s[1] + a2 * p2s[2];
						result = 3;
					}
				}
			}
			return result;
		}
		public static bool InPoints(Vec2 w, Vec2[] points, int pointCount)
		{
			float num = 100f * Settings.FLT_EPSILON;
			bool result;
			for (int i = 0; i < pointCount; i++)
			{
				Vec2 vec = Box2DX.Common.Math.Abs(w - points[i]);
				Vec2 vec2 = Box2DX.Common.Math.Max(Box2DX.Common.Math.Abs(w), Box2DX.Common.Math.Abs(points[i]));
				if (vec.X < num * (vec2.X + 1f) && vec.Y < num * (vec2.Y + 1f))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		public static float DistanceGeneric<T1, T2>(out Vec2 x1, out Vec2 x2, T1 shape1_, XForm xf1, T2 shape2_, XForm xf2)
		{
			Collision.IGenericShape genericShape = shape1_ as Collision.IGenericShape;
			Collision.IGenericShape genericShape2 = shape2_ as Collision.IGenericShape;
			if (genericShape == null || genericShape2 == null)
			{
				Box2DXDebug.Assert(false, "Can not cast some parameters to IGenericShape");
			}
			Vec2[] array = new Vec2[3];
			Vec2[] array2 = new Vec2[3];
			Vec2[] array3 = new Vec2[3];
			int num = 0;
			x1 = genericShape.GetFirstVertex(xf1);
			x2 = genericShape2.GetFirstVertex(xf2);
			float num2 = 0f;
			int num3 = 20;
			int i = 0;
			float result;
			while (i < num3)
			{
				Vec2 vec = x2 - x1;
				Vec2 vec2 = genericShape.Support(xf1, vec);
				Vec2 vec3 = genericShape2.Support(xf2, -vec);
				num2 = Vec2.Dot(vec, vec);
				Vec2 vec4 = vec3 - vec2;
				float num4 = Vec2.Dot(vec, vec4);
				if (num2 - num4 <= 0.01f * num2 || Collision.InPoints(vec4, array3, num))
				{
					if (num == 0)
					{
						x1 = vec2;
						x2 = vec3;
					}
					Collision.GJKIterations = i;
					result = Box2DX.Common.Math.Sqrt(num2);
				}
				else
				{
					switch (num)
					{
						case 0:
						{
							array[0] = vec2;
							array2[0] = vec3;
							array3[0] = vec4;
							x1 = array[0];
							x2 = array2[0];
							num++;
							break;
						}
						case 1:
						{
							array[1] = vec2;
							array2[1] = vec3;
							array3[1] = vec4;
							num = Collision.ProcessTwo(out x1, out x2, ref array, ref array2, ref array3);
							break;
						}
						case 2:
						{
							array[2] = vec2;
							array2[2] = vec3;
							array3[2] = vec4;
							num = Collision.ProcessThree(out x1, out x2, ref array, ref array2, ref array3);
							break;
						}
					}
					if (num == 3)
					{
						Collision.GJKIterations = i;
						result = 0f;
					}
					else
					{
						float num5 = -Settings.FLT_MAX;
						for (int j = 0; j < num; j++)
						{
							num5 = Box2DX.Common.Math.Max(num5, Vec2.Dot(array3[j], array3[j]));
						}
						if (num2 > 100f * Settings.FLT_EPSILON * num5)
						{
							i++;
							continue;
						}
						Collision.GJKIterations = i;
						vec = x2 - x1;
						num2 = Vec2.Dot(vec, vec);
						result = Box2DX.Common.Math.Sqrt(num2);
					}
				}
				return result;
			}
			Collision.GJKIterations = num3;
			result = Box2DX.Common.Math.Sqrt(num2);
			return result;
		}
		public static float DistanceCC(out Vec2 x1, out Vec2 x2, CircleShape circle1, XForm xf1, CircleShape circle2, XForm xf2)
		{
			Vec2 vec = Box2DX.Common.Math.Mul(xf1, circle1.GetLocalPosition());
			Vec2 v = Box2DX.Common.Math.Mul(xf2, circle2.GetLocalPosition());
			Vec2 vec2 = v - vec;
			float num = Vec2.Dot(vec2, vec2);
			float num2 = circle1.GetRadius() - Settings.ToiSlop;
			float num3 = circle2.GetRadius() - Settings.ToiSlop;
			float num4 = num2 + num3;
			float result;
			if (num > num4 * num4)
			{
				float num5 = vec2.Normalize();
				float num6 = num5 - num4;
				x1 = vec + num2 * vec2;
				x2 = v - num3 * vec2;
				result = num6;
			}
			else
			{
				if (num > Settings.FLT_EPSILON * Settings.FLT_EPSILON)
				{
					vec2.Normalize();
					x1 = vec + num2 * vec2;
					x2 = x1;
					result = 0f;
				}
				else
				{
					x1 = vec;
					x2 = x1;
					result = 0f;
				}
			}
			return result;
		}
		public static float DistancePC(out Vec2 x1, out Vec2 x2, PolygonShape polygon, XForm xf1, CircleShape circle, XForm xf2)
		{
			float num = Collision.DistanceGeneric<PolygonShape, Collision.Point>(out x1, out x2, polygon, xf1, new Collision.Point
			{
				p = Box2DX.Common.Math.Mul(xf2, circle.GetLocalPosition())
			}, XForm.Identity);
			float num2 = circle.GetRadius() - Settings.ToiSlop;
			if (num > num2)
			{
				num -= num2;
				Vec2 v = x2 - x1;
				v.Normalize();
				x2 -= num2 * v;
			}
			else
			{
				num = 0f;
				x2 = x1;
			}
			return num;
		}
		public static float Distance(out Vec2 x1, out Vec2 x2, Shape shape1, XForm xf1, Shape shape2, XForm xf2)
		{
			x1 = default(Vec2);
			x2 = default(Vec2);
			ShapeType type = shape1.GetType();
			ShapeType type2 = shape2.GetType();
			float result;
			if (type == ShapeType.CircleShape && type2 == ShapeType.CircleShape)
			{
				result = Collision.DistanceCC(out x1, out x2, (CircleShape)shape1, xf1, (CircleShape)shape2, xf2);
			}
			else
			{
				if (type == ShapeType.PolygonShape && type2 == ShapeType.CircleShape)
				{
					result = Collision.DistancePC(out x1, out x2, (PolygonShape)shape1, xf1, (CircleShape)shape2, xf2);
				}
				else
				{
					if (type == ShapeType.CircleShape && type2 == ShapeType.PolygonShape)
					{
						result = Collision.DistancePC(out x2, out x1, (PolygonShape)shape2, xf2, (CircleShape)shape1, xf1);
					}
					else
					{
						if (type == ShapeType.PolygonShape && type2 == ShapeType.PolygonShape)
						{
							result = Collision.DistanceGeneric<PolygonShape, PolygonShape>(out x1, out x2, (PolygonShape)shape1, xf1, (PolygonShape)shape2, xf2);
						}
						else
						{
							result = 0f;
						}
					}
				}
			}
			return result;
		}
		public static float TimeOfImpact(Shape shape1, Sweep sweep1, Shape shape2, Sweep sweep2)
		{
			float sweepRadius = shape1.GetSweepRadius();
			float sweepRadius2 = shape2.GetSweepRadius();
			Box2DXDebug.Assert(sweep1.T0 == sweep2.T0);
			Box2DXDebug.Assert(1f - sweep1.T0 > Settings.FLT_EPSILON);
			float t = sweep1.T0;
			Vec2 v = sweep1.C - sweep1.C0;
			Vec2 v2 = sweep2.C - sweep2.C0;
			float a = sweep1.A - sweep1.A0;
			float a2 = sweep2.A - sweep2.A0;
			float num = 0f;
			int num2 = 20;
			int num3 = 0;
			Vec2 a3 = Vec2.Zero;
			float num4 = 0f;
			while (true)
			{
				float t2 = (1f - num) * t + num;
				XForm xf;
				sweep1.GetXForm(out xf, t2);
				XForm xf2;
				sweep2.GetXForm(out xf2, t2);
				Vec2 v3;
				Vec2 v4;
				float num5 = Collision.Distance(out v3, out v4, shape1, xf, shape2, xf2);
				if (num3 == 0)
				{
					if (num5 > 2f * Settings.ToiSlop)
					{
						num4 = 1.5f * Settings.ToiSlop;
					}
					else
					{
						num4 = Box2DX.Common.Math.Max(0.05f * Settings.ToiSlop, num5 - 0.5f * Settings.ToiSlop);
					}
				}
				if (num5 - num4 < 0.05f * Settings.ToiSlop || num3 == num2)
				{
					break;
				}
				a3 = v4 - v3;
				a3.Normalize();
				float num6 = Vec2.Dot(a3, v - v2) + Box2DX.Common.Math.Abs(a) * sweepRadius + Box2DX.Common.Math.Abs(a2) * sweepRadius2;
				if (Box2DX.Common.Math.Abs(num6) < Settings.FLT_EPSILON)
				{
					goto Block_5;
				}
				float num7 = (num5 - num4) / num6;
				float num8 = num + num7;
				if (num8 < 0f || 1f < num8)
				{
					goto Block_7;
				}
				if (num8 < (1f + 100f * Settings.FLT_EPSILON) * num)
				{
					break;
				}
				num = num8;
				num3++;
			}
			return num;
			Block_5:
			num = 1f;
			return num;
			Block_7:
			num = 1f;
			return num;
		}
		public static bool TestOverlap(AABB a, AABB b)
		{
			Vec2 vec = b.LowerBound - a.UpperBound;
			Vec2 vec2 = a.LowerBound - b.UpperBound;
			return vec.X <= 0f && vec.Y <= 0f && vec2.X <= 0f && vec2.Y <= 0f;
		}
		public static int ClipSegmentToLine(out Collision.ClipVertex[] vOut, Collision.ClipVertex[] vIn, Vec2 normal, float offset)
		{
			if (vIn.Length != 2)
			{
				Box2DXDebug.ThrowBox2DXException("vIn should contain 2 element, but contains " + vIn.Length.ToString());
			}
			vOut = new Collision.ClipVertex[2];
			int num = 0;
			float num2 = Vec2.Dot(normal, vIn[0].V) - offset;
			float num3 = Vec2.Dot(normal, vIn[1].V) - offset;
			if (num2 <= 0f)
			{
				vOut[num++] = vIn[0];
			}
			if (num3 <= 0f)
			{
				vOut[num++] = vIn[1];
			}
			if (num2 * num3 < 0f)
			{
				float a = num2 / (num2 - num3);
				vOut[num].V = vIn[0].V + a * (vIn[1].V - vIn[0].V);
				if (num2 > 0f)
				{
					vOut[num].ID = vIn[0].ID;
				}
				else
				{
					vOut[num].ID = vIn[1].ID;
				}
				num++;
			}
			return num;
		}
		public static float EdgeSeparation(PolygonShape poly1, XForm xf1, int edge1, PolygonShape poly2, XForm xf2)
		{
			int vertexCount = poly1.VertexCount;
			Vec2[] vertices = poly1.GetVertices();
			Vec2[] normals = poly1.Normals;
			int vertexCount2 = poly2.VertexCount;
			Vec2[] vertices2 = poly2.GetVertices();
			Box2DXDebug.Assert(0 <= edge1 && edge1 < vertexCount);
			Vec2 vec = Box2DX.Common.Math.Mul(xf1.R, normals[edge1]);
			Vec2 b = Box2DX.Common.Math.MulT(xf2.R, vec);
			int num = 0;
			float num2 = Settings.FLT_MAX;
			for (int i = 0; i < vertexCount2; i++)
			{
				float num3 = Vec2.Dot(vertices2[i], b);
				if (num3 < num2)
				{
					num2 = num3;
					num = i;
				}
			}
			Vec2 v = Box2DX.Common.Math.Mul(xf1, vertices[edge1]);
			Vec2 v2 = Box2DX.Common.Math.Mul(xf2, vertices2[num]);
			return Vec2.Dot(v2 - v, vec);
		}
		public static float FindMaxSeparation(ref int edgeIndex, PolygonShape poly1, XForm xf1, PolygonShape poly2, XForm xf2)
		{
			int vertexCount = poly1.VertexCount;
			Vec2[] normals = poly1.Normals;
			Vec2 v = Box2DX.Common.Math.Mul(xf2, poly2.GetCentroid()) - Box2DX.Common.Math.Mul(xf1, poly1.GetCentroid());
			Vec2 b = Box2DX.Common.Math.MulT(xf1.R, v);
			int num = 0;
			float num2 = -Settings.FLT_MAX;
			for (int i = 0; i < vertexCount; i++)
			{
				float num3 = Vec2.Dot(normals[i], b);
				if (num3 > num2)
				{
					num2 = num3;
					num = i;
				}
			}
			float num4 = Collision.EdgeSeparation(poly1, xf1, num, poly2, xf2);
			float result;
			if (num4 > 0f)
			{
				result = num4;
			}
			else
			{
				int num5 = (num - 1 >= 0) ? (num - 1) : (vertexCount - 1);
				float num6 = Collision.EdgeSeparation(poly1, xf1, num5, poly2, xf2);
				if (num6 > 0f)
				{
					result = num6;
				}
				else
				{
					int num7 = (num + 1 < vertexCount) ? (num + 1) : 0;
					float num8 = Collision.EdgeSeparation(poly1, xf1, num7, poly2, xf2);
					if (num8 > 0f)
					{
						result = num8;
					}
					else
					{
						int num9;
						int num10;
						float num11;
						if (num6 > num4 && num6 > num8)
						{
							num9 = -1;
							num10 = num5;
							num11 = num6;
						}
						else
						{
							if (num8 <= num4)
							{
								edgeIndex = num;
								result = num4;
								return result;
							}
							num9 = 1;
							num10 = num7;
							num11 = num8;
						}
						while (true)
						{
							if (num9 == -1)
							{
								num = ((num10 - 1 >= 0) ? (num10 - 1) : (vertexCount - 1));
							}
							else
							{
								num = ((num10 + 1 < vertexCount) ? (num10 + 1) : 0);
							}
							num4 = Collision.EdgeSeparation(poly1, xf1, num, poly2, xf2);
							if (num4 > 0f)
							{
								break;
							}
							if (num4 <= num11)
							{
								goto IL_1F7;
							}
							num10 = num;
							num11 = num4;
						}
						result = num4;
						return result;
						IL_1F7:
						edgeIndex = num10;
						result = num11;
					}
				}
			}
			return result;
		}
		public static void FindIncidentEdge(out Collision.ClipVertex[] c, PolygonShape poly1, XForm xf1, int edge1, PolygonShape poly2, XForm xf2)
		{
			int vertexCount = poly1.VertexCount;
			Vec2[] normals = poly1.Normals;
			int vertexCount2 = poly2.VertexCount;
			Vec2[] vertices = poly2.GetVertices();
			Vec2[] normals2 = poly2.Normals;
			Box2DXDebug.Assert(0 <= edge1 && edge1 < vertexCount);
			Vec2 a = Box2DX.Common.Math.MulT(xf2.R, Box2DX.Common.Math.Mul(xf1.R, normals[edge1]));
			int num = 0;
			float num2 = Settings.FLT_MAX;
			for (int i = 0; i < vertexCount2; i++)
			{
				float num3 = Vec2.Dot(a, normals2[i]);
				if (num3 < num2)
				{
					num2 = num3;
					num = i;
				}
			}
			int num4 = num;
			int num5 = (num4 + 1 < vertexCount2) ? (num4 + 1) : 0;
			c = new Collision.ClipVertex[2];
			c[0].V = Box2DX.Common.Math.Mul(xf2, vertices[num4]);
			c[0].ID.Features.ReferenceEdge = (byte)edge1;
			c[0].ID.Features.IncidentEdge = (byte)num4;
			c[0].ID.Features.IncidentVertex = 0;
			c[1].V = Box2DX.Common.Math.Mul(xf2, vertices[num5]);
			c[1].ID.Features.ReferenceEdge = (byte)edge1;
			c[1].ID.Features.IncidentEdge = (byte)num5;
			c[1].ID.Features.IncidentVertex = 1;
		}
		public static void CollidePolygons(ref Manifold manifold, PolygonShape polyA, XForm xfA, PolygonShape polyB, XForm xfB)
		{
			manifold.PointCount = 0;
			int num = 0;
			float num2 = Collision.FindMaxSeparation(ref num, polyA, xfA, polyB, xfB);
			if (num2 <= 0f)
			{
				int num3 = 0;
				float num4 = Collision.FindMaxSeparation(ref num3, polyB, xfB, polyA, xfA);
				if (num4 <= 0f)
				{
					float num5 = 0.98f;
					float num6 = 0.001f;
					PolygonShape polygonShape;
					PolygonShape poly;
					XForm xForm;
					XForm xf;
					int num7;
					byte b;
					if (num4 > num5 * num2 + num6)
					{
						polygonShape = polyB;
						poly = polyA;
						xForm = xfB;
						xf = xfA;
						num7 = num3;
						b = 1;
					}
					else
					{
						polygonShape = polyA;
						poly = polyB;
						xForm = xfA;
						xf = xfB;
						num7 = num;
						b = 0;
					}
					Collision.ClipVertex[] vIn;
					Collision.FindIncidentEdge(out vIn, polygonShape, xForm, num7, poly, xf);
					int vertexCount = polygonShape.VertexCount;
					Vec2[] vertices = polygonShape.GetVertices();
					Vec2 vec = vertices[num7];
					Vec2 vec2 = (num7 + 1 < vertexCount) ? vertices[num7 + 1] : vertices[0];
					Vec2 vec3 = vec2 - vec;
					Vec2 vec4 = Box2DX.Common.Math.Mul(xForm.R, vec2 - vec);
					vec4.Normalize();
					Vec2 vec5 = Vec2.Cross(vec4, 1f);
					vec = Box2DX.Common.Math.Mul(xForm, vec);
					vec2 = Box2DX.Common.Math.Mul(xForm, vec2);
					float num8 = Vec2.Dot(vec5, vec);
					float offset = -Vec2.Dot(vec4, vec);
					float offset2 = Vec2.Dot(vec4, vec2);
					Collision.ClipVertex[] vIn2;
					int num9 = Collision.ClipSegmentToLine(out vIn2, vIn, -vec4, offset);
					if (num9 >= 2)
					{
						Collision.ClipVertex[] array;
						num9 = Collision.ClipSegmentToLine(out array, vIn2, vec4, offset2);
						if (num9 >= 2)
						{
							manifold.Normal = ((b != 0) ? (-vec5) : vec5);
							int num10 = 0;
							for (int i = 0; i < Settings.MaxManifoldPoints; i++)
							{
								float num11 = Vec2.Dot(vec5, array[i].V) - num8;
								if (num11 <= 0f)
								{
									ManifoldPoint manifoldPoint = manifold.Points[num10];
									manifoldPoint.Separation = num11;
									manifoldPoint.LocalPoint1 = Box2DX.Common.Math.MulT(xfA, array[i].V);
									manifoldPoint.LocalPoint2 = Box2DX.Common.Math.MulT(xfB, array[i].V);
									manifoldPoint.ID = array[i].ID;
									manifoldPoint.ID.Features.Flip = b;
									num10++;
								}
							}
							manifold.PointCount = num10;
						}
					}
				}
			}
		}
	}
}
