using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class CircleContact : Contact
	{
		public Manifold _manifold = new Manifold();
		public override Manifold[] GetManifolds()
		{
			return new Manifold[]
			{
				this._manifold
			};
		}
		public CircleContact(Shape s1, Shape s2) : base(s1, s2)
		{
			Box2DXDebug.Assert(this._shape1.GetType() == ShapeType.CircleShape);
			Box2DXDebug.Assert(this._shape2.GetType() == ShapeType.CircleShape);
			this._manifold.PointCount = 0;
			this._manifold.Points[0].NormalImpulse = 0f;
			this._manifold.Points[0].TangentImpulse = 0f;
		}
		public override void Evaluate(ContactListener listener)
		{
			Body body = this._shape1.GetBody();
			Body body2 = this._shape2.GetBody();
			Manifold manifold = this._manifold.Clone();
            Collision.Collision.CollideCircles(ref this._manifold, (CircleShape)this._shape1, body.GetXForm(), (CircleShape)this._shape2, body2.GetXForm());
			ContactPoint contactPoint = new ContactPoint();
			contactPoint.Shape1 = this._shape1;
			contactPoint.Shape2 = this._shape2;
			contactPoint.Friction = Settings.MixFriction(this._shape1.Friction, this._shape2.Friction);
			contactPoint.Restitution = Settings.MixRestitution(this._shape1.Restitution, this._shape2.Restitution);
			if (this._manifold.PointCount > 0)
			{
				this._manifoldCount = 1;
				ManifoldPoint manifoldPoint = this._manifold.Points[0];
				if (manifold.PointCount == 0)
				{
					manifoldPoint.NormalImpulse = 0f;
					manifoldPoint.TangentImpulse = 0f;
					if (listener != null)
					{
						contactPoint.Position = body.GetWorldPoint(manifoldPoint.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint = body.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint2 = body2.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint2);
						contactPoint.Velocity = linearVelocityFromLocalPoint2 - linearVelocityFromLocalPoint;
						contactPoint.Normal = this._manifold.Normal;
						contactPoint.Separation = manifoldPoint.Separation;
						contactPoint.ID = manifoldPoint.ID;
						listener.Add(contactPoint);
					}
				}
				else
				{
					ManifoldPoint manifoldPoint2 = manifold.Points[0];
					manifoldPoint.NormalImpulse = manifoldPoint2.NormalImpulse;
					manifoldPoint.TangentImpulse = manifoldPoint2.TangentImpulse;
					if (listener != null)
					{
						contactPoint.Position = body.GetWorldPoint(manifoldPoint.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint = body.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint2 = body2.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint2);
						contactPoint.Velocity = linearVelocityFromLocalPoint2 - linearVelocityFromLocalPoint;
						contactPoint.Normal = this._manifold.Normal;
						contactPoint.Separation = manifoldPoint.Separation;
						contactPoint.ID = manifoldPoint.ID;
						listener.Persist(contactPoint);
					}
				}
			}
			else
			{
				this._manifoldCount = 0;
				if (manifold.PointCount > 0 && listener != null)
				{
					ManifoldPoint manifoldPoint2 = manifold.Points[0];
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
		public new static Contact Create(Shape shape1, Shape shape2)
		{
			return new CircleContact(shape1, shape2);
		}
		public new static void Destroy(Contact contact)
		{
		}
	}
}
