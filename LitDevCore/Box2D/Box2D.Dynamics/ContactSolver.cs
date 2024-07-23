using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class ContactSolver : IDisposable
	{
		public TimeStep _step;
		public ContactConstraint[] _constraints;
		public int _constraintCount;
		public ContactSolver(TimeStep step, Contact[] contacts, int contactCount)
		{
			this._step = step;
			this._constraintCount = 0;
			for (int i = 0; i < contactCount; i++)
			{
				Box2DXDebug.Assert(contacts[i].IsSolid());
				this._constraintCount += contacts[i].GetManifoldCount();
			}
			this._constraints = new ContactConstraint[this._constraintCount];
			for (int i = 0; i < this._constraintCount; i++)
			{
				this._constraints[i] = new ContactConstraint();
			}
			int num = 0;
			for (int i = 0; i < contactCount; i++)
			{
				Contact contact = contacts[i];
				Shape shape = contact._shape1;
				Shape shape2 = contact._shape2;
				Body body = shape.GetBody();
				Body body2 = shape2.GetBody();
				int manifoldCount = contact.GetManifoldCount();
				Manifold[] manifolds = contact.GetManifolds();
				float friction = Settings.MixFriction(shape.Friction, shape2.Friction);
				float restitution = Settings.MixRestitution(shape.Restitution, shape2.Restitution);
				Vec2 linearVelocity = body._linearVelocity;
				Vec2 linearVelocity2 = body2._linearVelocity;
				float angularVelocity = body._angularVelocity;
				float angularVelocity2 = body2._angularVelocity;
				for (int j = 0; j < manifoldCount; j++)
				{
					Manifold manifold = manifolds[j];
					Box2DXDebug.Assert(manifold.PointCount > 0);
					Vec2 normal = manifold.Normal;
					Box2DXDebug.Assert(num < this._constraintCount);
					ContactConstraint contactConstraint = this._constraints[num];
					contactConstraint.Body1 = body;
					contactConstraint.Body2 = body2;
					contactConstraint.Manifold = manifold;
					contactConstraint.Normal = normal;
					contactConstraint.PointCount = manifold.PointCount;
					contactConstraint.Friction = friction;
					contactConstraint.Restitution = restitution;
					for (int k = 0; k < contactConstraint.PointCount; k++)
					{
						ManifoldPoint manifoldPoint = manifold.Points[k];
						ContactConstraintPoint contactConstraintPoint = contactConstraint.Points[k];
						contactConstraintPoint.NormalImpulse = manifoldPoint.NormalImpulse;
						contactConstraintPoint.TangentImpulse = manifoldPoint.TangentImpulse;
						contactConstraintPoint.Separation = manifoldPoint.Separation;
						contactConstraintPoint.LocalAnchor1 = manifoldPoint.LocalPoint1;
						contactConstraintPoint.LocalAnchor2 = manifoldPoint.LocalPoint2;
						contactConstraintPoint.R1 = Box2DX.Common.Math.Mul(body.GetXForm().R, manifoldPoint.LocalPoint1 - body.GetLocalCenter());
						contactConstraintPoint.R2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, manifoldPoint.LocalPoint2 - body2.GetLocalCenter());
						float num2 = Vec2.Cross(contactConstraintPoint.R1, normal);
						float num3 = Vec2.Cross(contactConstraintPoint.R2, normal);
						num2 *= num2;
						num3 *= num3;
						float num4 = body._invMass + body2._invMass + body._invI * num2 + body2._invI * num3;
						Box2DXDebug.Assert(num4 > Settings.FLT_EPSILON);
						contactConstraintPoint.NormalMass = 1f / num4;
						float num5 = body._mass * body._invMass + body2._mass * body2._invMass;
						num5 += body._mass * body._invI * num2 + body2._mass * body2._invI * num3;
						Box2DXDebug.Assert(num5 > Settings.FLT_EPSILON);
						contactConstraintPoint.EqualizedMass = 1f / num5;
						Vec2 b = Vec2.Cross(normal, 1f);
						float num6 = Vec2.Cross(contactConstraintPoint.R1, b);
						float num7 = Vec2.Cross(contactConstraintPoint.R2, b);
						num6 *= num6;
						num7 *= num7;
						float num8 = body._invMass + body2._invMass + body._invI * num6 + body2._invI * num7;
						Box2DXDebug.Assert(num8 > Settings.FLT_EPSILON);
						contactConstraintPoint.TangentMass = 1f / num8;
						contactConstraintPoint.VelocityBias = 0f;
						if (contactConstraintPoint.Separation > 0f)
						{
							contactConstraintPoint.VelocityBias = -step.Inv_Dt * contactConstraintPoint.Separation;
						}
						else
						{
							float num9 = Vec2.Dot(contactConstraint.Normal, linearVelocity2 + Vec2.Cross(angularVelocity2, contactConstraintPoint.R2) - linearVelocity - Vec2.Cross(angularVelocity, contactConstraintPoint.R1));
							if (num9 < -Settings.VelocityThreshold)
							{
								contactConstraintPoint.VelocityBias = -contactConstraint.Restitution * num9;
							}
						}
					}
					if (contactConstraint.PointCount == 2)
					{
						ContactConstraintPoint contactConstraintPoint2 = contactConstraint.Points[0];
						ContactConstraintPoint contactConstraintPoint3 = contactConstraint.Points[1];
						float invMass = body._invMass;
						float invI = body._invI;
						float invMass2 = body2._invMass;
						float invI2 = body2._invI;
						float num10 = Vec2.Cross(contactConstraintPoint2.R1, normal);
						float num11 = Vec2.Cross(contactConstraintPoint2.R2, normal);
						float num12 = Vec2.Cross(contactConstraintPoint3.R1, normal);
						float num13 = Vec2.Cross(contactConstraintPoint3.R2, normal);
						float num14 = invMass + invMass2 + invI * num10 * num10 + invI2 * num11 * num11;
						float num15 = invMass + invMass2 + invI * num12 * num12 + invI2 * num13 * num13;
						float num16 = invMass + invMass2 + invI * num10 * num12 + invI2 * num11 * num13;
						if (num14 * num14 < 100f * (num14 * num15 - num16 * num16))
						{
							contactConstraint.K.Col1.Set(num14, num16);
							contactConstraint.K.Col2.Set(num16, num15);
							contactConstraint.NormalMass = contactConstraint.K.Invert();
						}
						else
						{
							contactConstraint.PointCount = 1;
						}
					}
					num++;
				}
			}
			Box2DXDebug.Assert(num == this._constraintCount);
		}
		public void Dispose()
		{
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                this._constraints = null;
            }
            // free native resources if there are any.
        }
        public void InitVelocityConstraints(TimeStep step)
		{
			for (int i = 0; i < this._constraintCount; i++)
			{
				ContactConstraint contactConstraint = this._constraints[i];
				Body body = contactConstraint.Body1;
				Body body2 = contactConstraint.Body2;
				float invMass = body._invMass;
				float invI = body._invI;
				float invMass2 = body2._invMass;
				float invI2 = body2._invI;
				Vec2 normal = contactConstraint.Normal;
				Vec2 v = Vec2.Cross(normal, 1f);
				if (step.WarmStarting)
				{
					for (int j = 0; j < contactConstraint.PointCount; j++)
					{
						ContactConstraintPoint contactConstraintPoint = contactConstraint.Points[j];
						contactConstraintPoint.NormalImpulse *= step.DtRatio;
						contactConstraintPoint.TangentImpulse *= step.DtRatio;
						Vec2 vec = contactConstraintPoint.NormalImpulse * normal + contactConstraintPoint.TangentImpulse * v;
						body._angularVelocity -= invI * Vec2.Cross(contactConstraintPoint.R1, vec);
						Body expr_EA = body;
						expr_EA._linearVelocity -= invMass * vec;
						body2._angularVelocity += invI2 * Vec2.Cross(contactConstraintPoint.R2, vec);
						Body expr_122 = body2;
						expr_122._linearVelocity += invMass2 * vec;
					}
				}
				else
				{
					for (int j = 0; j < contactConstraint.PointCount; j++)
					{
						ContactConstraintPoint contactConstraintPoint = contactConstraint.Points[j];
						contactConstraintPoint.NormalImpulse = 0f;
						contactConstraintPoint.TangentImpulse = 0f;
					}
				}
			}
		}
		public void SolveVelocityConstraints()
		{
			for (int i = 0; i < this._constraintCount; i++)
			{
				ContactConstraint contactConstraint = this._constraints[i];
				Body body = contactConstraint.Body1;
				Body body2 = contactConstraint.Body2;
				float num = body._angularVelocity;
				float num2 = body2._angularVelocity;
				Vec2 vec = body._linearVelocity;
				Vec2 vec2 = body2._linearVelocity;
				float invMass = body._invMass;
				float invI = body._invI;
				float invMass2 = body2._invMass;
				float invI2 = body2._invI;
				Vec2 normal = contactConstraint.Normal;
				Vec2 vec3 = Vec2.Cross(normal, 1f);
				float friction = contactConstraint.Friction;
				Box2DXDebug.Assert(contactConstraint.PointCount == 1 || contactConstraint.PointCount == 2);
				if (contactConstraint.PointCount == 1)
				{
					ContactConstraintPoint contactConstraintPoint = contactConstraint.Points[0];
					Vec2 a = vec2 + Vec2.Cross(num2, contactConstraintPoint.R2) - vec - Vec2.Cross(num, contactConstraintPoint.R1);
					float num3 = Vec2.Dot(a, normal);
					float num4 = -contactConstraintPoint.NormalMass * (num3 - contactConstraintPoint.VelocityBias);
					float num5 = Box2DX.Common.Math.Max(contactConstraintPoint.NormalImpulse + num4, 0f);
					num4 = num5 - contactConstraintPoint.NormalImpulse;
					Vec2 vec4 = num4 * normal;
					vec -= invMass * vec4;
					num -= invI * Vec2.Cross(contactConstraintPoint.R1, vec4);
					vec2 += invMass2 * vec4;
					num2 += invI2 * Vec2.Cross(contactConstraintPoint.R2, vec4);
					contactConstraintPoint.NormalImpulse = num5;
				}
				else
				{
					ContactConstraintPoint contactConstraintPoint2 = contactConstraint.Points[0];
					ContactConstraintPoint contactConstraintPoint3 = contactConstraint.Points[1];
					Vec2 vec5 = new Vec2(contactConstraintPoint2.NormalImpulse, contactConstraintPoint3.NormalImpulse);
					Box2DXDebug.Assert(vec5.X >= 0f && vec5.Y >= 0f);
					Vec2 a2 = vec2 + Vec2.Cross(num2, contactConstraintPoint2.R2) - vec - Vec2.Cross(num, contactConstraintPoint2.R1);
					Vec2 a3 = vec2 + Vec2.Cross(num2, contactConstraintPoint3.R2) - vec - Vec2.Cross(num, contactConstraintPoint3.R1);
					float num6 = Vec2.Dot(a2, normal);
					float num7 = Vec2.Dot(a3, normal);
					Vec2 vec6;
					vec6.X = num6 - contactConstraintPoint2.VelocityBias;
					vec6.Y = num7 - contactConstraintPoint3.VelocityBias;
					vec6 -= Box2DX.Common.Math.Mul(contactConstraint.K, vec5);
					Vec2 v = -Box2DX.Common.Math.Mul(contactConstraint.NormalMass, vec6);
					if (v.X >= 0f && v.Y >= 0f)
					{
						Vec2 vec7 = v - vec5;
						Vec2 vec8 = vec7.X * normal;
						Vec2 vec9 = vec7.Y * normal;
						vec -= invMass * (vec8 + vec9);
						num -= invI * (Vec2.Cross(contactConstraintPoint2.R1, vec8) + Vec2.Cross(contactConstraintPoint3.R1, vec9));
						vec2 += invMass2 * (vec8 + vec9);
						num2 += invI2 * (Vec2.Cross(contactConstraintPoint2.R2, vec8) + Vec2.Cross(contactConstraintPoint3.R2, vec9));
						contactConstraintPoint2.NormalImpulse = v.X;
						contactConstraintPoint3.NormalImpulse = v.Y;
					}
					else
					{
						v.X = -contactConstraintPoint2.NormalMass * vec6.X;
						v.Y = 0f;
						num7 = contactConstraint.K.Col1.Y * v.X + vec6.Y;
						if (v.X >= 0f && num7 >= 0f)
						{
							Vec2 vec7 = v - vec5;
							Vec2 vec8 = vec7.X * normal;
							Vec2 vec9 = vec7.Y * normal;
							vec -= invMass * (vec8 + vec9);
							num -= invI * (Vec2.Cross(contactConstraintPoint2.R1, vec8) + Vec2.Cross(contactConstraintPoint3.R1, vec9));
							vec2 += invMass2 * (vec8 + vec9);
							num2 += invI2 * (Vec2.Cross(contactConstraintPoint2.R2, vec8) + Vec2.Cross(contactConstraintPoint3.R2, vec9));
							contactConstraintPoint2.NormalImpulse = v.X;
							contactConstraintPoint3.NormalImpulse = v.Y;
						}
						else
						{
							v.X = 0f;
							v.Y = -contactConstraintPoint3.NormalMass * vec6.Y;
							num6 = contactConstraint.K.Col2.X * v.Y + vec6.X;
							if (v.Y >= 0f && num6 >= 0f)
							{
								Vec2 vec7 = v - vec5;
								Vec2 vec8 = vec7.X * normal;
								Vec2 vec9 = vec7.Y * normal;
								vec -= invMass * (vec8 + vec9);
								num -= invI * (Vec2.Cross(contactConstraintPoint2.R1, vec8) + Vec2.Cross(contactConstraintPoint3.R1, vec9));
								vec2 += invMass2 * (vec8 + vec9);
								num2 += invI2 * (Vec2.Cross(contactConstraintPoint2.R2, vec8) + Vec2.Cross(contactConstraintPoint3.R2, vec9));
								contactConstraintPoint2.NormalImpulse = v.X;
								contactConstraintPoint3.NormalImpulse = v.Y;
							}
							else
							{
								v.X = 0f;
								v.Y = 0f;
								num6 = vec6.X;
								num7 = vec6.Y;
								if (num6 >= 0f && num7 >= 0f)
								{
									Vec2 vec7 = v - vec5;
									Vec2 vec8 = vec7.X * normal;
									Vec2 vec9 = vec7.Y * normal;
									vec -= invMass * (vec8 + vec9);
									num -= invI * (Vec2.Cross(contactConstraintPoint2.R1, vec8) + Vec2.Cross(contactConstraintPoint3.R1, vec9));
									vec2 += invMass2 * (vec8 + vec9);
									num2 += invI2 * (Vec2.Cross(contactConstraintPoint2.R2, vec8) + Vec2.Cross(contactConstraintPoint3.R2, vec9));
									contactConstraintPoint2.NormalImpulse = v.X;
									contactConstraintPoint3.NormalImpulse = v.Y;
								}
							}
						}
					}
				}
				for (int j = 0; j < contactConstraint.PointCount; j++)
				{
					ContactConstraintPoint contactConstraintPoint = contactConstraint.Points[j];
					Vec2 a = vec2 + Vec2.Cross(num2, contactConstraintPoint.R2) - vec - Vec2.Cross(num, contactConstraintPoint.R1);
					float num8 = Vec2.Dot(a, vec3);
					float num4 = contactConstraintPoint.TangentMass * -num8;
					float num9 = friction * contactConstraintPoint.NormalImpulse;
					float num5 = Box2DX.Common.Math.Clamp(contactConstraintPoint.TangentImpulse + num4, -num9, num9);
					num4 = num5 - contactConstraintPoint.TangentImpulse;
					Vec2 vec4 = num4 * vec3;
					vec -= invMass * vec4;
					num -= invI * Vec2.Cross(contactConstraintPoint.R1, vec4);
					vec2 += invMass2 * vec4;
					num2 += invI2 * Vec2.Cross(contactConstraintPoint.R2, vec4);
					contactConstraintPoint.TangentImpulse = num5;
				}
				body._linearVelocity = vec;
				body._angularVelocity = num;
				body2._linearVelocity = vec2;
				body2._angularVelocity = num2;
			}
		}
		public void FinalizeVelocityConstraints()
		{
			for (int i = 0; i < this._constraintCount; i++)
			{
				ContactConstraint contactConstraint = this._constraints[i];
				Manifold manifold = contactConstraint.Manifold;
				for (int j = 0; j < contactConstraint.PointCount; j++)
				{
					manifold.Points[j].NormalImpulse = contactConstraint.Points[j].NormalImpulse;
					manifold.Points[j].TangentImpulse = contactConstraint.Points[j].TangentImpulse;
				}
			}
		}
		public bool SolvePositionConstraints(float baumgarte)
		{
			float num = 0f;
			for (int i = 0; i < this._constraintCount; i++)
			{
				ContactConstraint contactConstraint = this._constraints[i];
				Body body = contactConstraint.Body1;
				Body body2 = contactConstraint.Body2;
				float a = body._mass * body._invMass;
				float num2 = body._mass * body._invI;
				float a2 = body2._mass * body2._invMass;
				float num3 = body2._mass * body2._invI;
				Vec2 normal = contactConstraint.Normal;
				for (int j = 0; j < contactConstraint.PointCount; j++)
				{
					ContactConstraintPoint contactConstraintPoint = contactConstraint.Points[j];
					Vec2 vec = Box2DX.Common.Math.Mul(body.GetXForm().R, contactConstraintPoint.LocalAnchor1 - body.GetLocalCenter());
					Vec2 vec2 = Box2DX.Common.Math.Mul(body2.GetXForm().R, contactConstraintPoint.LocalAnchor2 - body2.GetLocalCenter());
					Vec2 v = body._sweep.C + vec;
					Vec2 v2 = body2._sweep.C + vec2;
					Vec2 a3 = v2 - v;
					float num4 = Vec2.Dot(a3, normal) + contactConstraintPoint.Separation;
					num = Box2DX.Common.Math.Min(num, num4);
					float num5 = baumgarte * Box2DX.Common.Math.Clamp(num4 + Settings.LinearSlop, -Settings.MaxLinearCorrection, 0f);
					float a4 = -contactConstraintPoint.EqualizedMass * num5;
					Vec2 vec3 = a4 * normal;
					Body expr_157_cp_0 = body;
					expr_157_cp_0._sweep.C = expr_157_cp_0._sweep.C - a * vec3;
					Body expr_176_cp_0 = body;
					expr_176_cp_0._sweep.A = expr_176_cp_0._sweep.A - num2 * Vec2.Cross(vec, vec3);
					body.SynchronizeTransform();
					Body expr_19C_cp_0 = body2;
					expr_19C_cp_0._sweep.C = expr_19C_cp_0._sweep.C + a2 * vec3;
					Body expr_1BC_cp_0 = body2;
					expr_1BC_cp_0._sweep.A = expr_1BC_cp_0._sweep.A + num3 * Vec2.Cross(vec2, vec3);
					body2.SynchronizeTransform();
				}
			}
			return num >= -1.5f * Settings.LinearSlop;
		}
	}
}
