using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class ContactConstraint
	{
		public ContactConstraintPoint[] Points = new ContactConstraintPoint[Settings.MaxManifoldPoints];
		public Vec2 Normal;
		public Mat22 NormalMass;
		public Mat22 K;
		public Manifold Manifold;
		public Body Body1;
		public Body Body2;
		public float Friction;
		public float Restitution;
		public int PointCount;
		public ContactConstraint()
		{
			for (int i = 0; i < Settings.MaxManifoldPoints; i++)
			{
				this.Points[i] = new ContactConstraintPoint();
			}
		}
	}
}
