using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class PolyAndCircleContact : Contact
	{
		public Manifold _manifold = new Manifold();
		public override Manifold[] GetManifolds()
		{
			return new Manifold[]
			{
				this._manifold
			};
		}
		public PolyAndCircleContact(Shape s1, Shape s2) : base(s1, s2)
		{
			Box2DXDebug.Assert(this._shape1.GetType() == ShapeType.PolygonShape);
			Box2DXDebug.Assert(this._shape2.GetType() == ShapeType.CircleShape);
			this._manifold.PointCount = 0;
		}
		public override void Evaluate(ContactListener listener)
		{
			Body body = this._shape1.GetBody();
			Body body2 = this._shape2.GetBody();
			Manifold manifold = this._manifold.Clone();
            Collision.Collision.CollidePolygonAndCircle(ref this._manifold, (PolygonShape)this._shape1, body.GetXForm(), (CircleShape)this._shape2, body2.GetXForm());
			bool[] array = new bool[2];
			bool[] array2 = array;
			ContactPoint contactPoint = new ContactPoint();
			contactPoint.Shape1 = this._shape1;
			contactPoint.Shape2 = this._shape2;
			contactPoint.Friction = Settings.MixFriction(this._shape1.Friction, this._shape2.Friction);
			contactPoint.Restitution = Settings.MixRestitution(this._shape1.Restitution, this._shape2.Restitution);
			if (this._manifold.PointCount > 0)
			{
				for (int i = 0; i < this._manifold.PointCount; i++)
				{
					ManifoldPoint manifoldPoint = this._manifold.Points[i];
					manifoldPoint.NormalImpulse = 0f;
					manifoldPoint.TangentImpulse = 0f;
					bool flag = false;
					ContactID iD = manifoldPoint.ID;
					for (int j = 0; j < manifold.PointCount; j++)
					{
						if (!array2[j])
						{
							ManifoldPoint manifoldPoint2 = manifold.Points[j];
							if (manifoldPoint2.ID.Key == iD.Key)
							{
								array2[j] = true;
								manifoldPoint.NormalImpulse = manifoldPoint2.NormalImpulse;
								manifoldPoint.TangentImpulse = manifoldPoint2.TangentImpulse;
								flag = true;
								if (listener != null)
								{
									contactPoint.Position = body.GetWorldPoint(manifoldPoint.LocalPoint1);
									Vec2 linearVelocityFromLocalPoint = body.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint1);
									Vec2 linearVelocityFromLocalPoint2 = body2.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint2);
									contactPoint.Velocity = linearVelocityFromLocalPoint2 - linearVelocityFromLocalPoint;
									contactPoint.Normal = this._manifold.Normal;
									contactPoint.Separation = manifoldPoint.Separation;
									contactPoint.ID = iD;
									listener.Persist(contactPoint);
								}
								break;
							}
						}
					}
					if (!flag && listener != null)
					{
						contactPoint.Position = body.GetWorldPoint(manifoldPoint.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint = body.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint2 = body2.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint2);
						contactPoint.Velocity = linearVelocityFromLocalPoint2 - linearVelocityFromLocalPoint;
						contactPoint.Normal = this._manifold.Normal;
						contactPoint.Separation = manifoldPoint.Separation;
						contactPoint.ID = iD;
						listener.Add(contactPoint);
					}
				}
				this._manifoldCount = 1;
			}
			else
			{
				this._manifoldCount = 0;
			}
			if (listener != null)
			{
				for (int i = 0; i < manifold.PointCount; i++)
				{
					if (!array2[i])
					{
						ManifoldPoint manifoldPoint2 = manifold.Points[i];
						contactPoint.Position = body.GetWorldPoint(manifoldPoint2.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint = body.GetLinearVelocityFromLocalPoint(manifoldPoint2.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint2 = body2.GetLinearVelocityFromLocalPoint(manifoldPoint2.LocalPoint2);
						contactPoint.Velocity = linearVelocityFromLocalPoint2 - linearVelocityFromLocalPoint;
						contactPoint.Normal = manifold.Normal;
						contactPoint.Separation = manifoldPoint2.Separation;
						contactPoint.ID = manifoldPoint2.ID;
						listener.Remove(contactPoint);
					}
				}
			}
		}
		public new static Contact Create(Shape shape1, Shape shape2)
		{
			return new PolyAndCircleContact(shape1, shape2);
		}
		public new static void Destroy(Contact contact)
		{
		}
	}
}
