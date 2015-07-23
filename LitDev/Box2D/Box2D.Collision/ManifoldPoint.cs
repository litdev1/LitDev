using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class ManifoldPoint
	{
		public Vec2 LocalPoint1;
		public Vec2 LocalPoint2;
		public float Separation;
		public float NormalImpulse;
		public float TangentImpulse;
		public ContactID ID;
		public ManifoldPoint Clone()
		{
			return new ManifoldPoint
			{
				LocalPoint1 = this.LocalPoint1, 
				LocalPoint2 = this.LocalPoint2, 
				Separation = this.Separation, 
				NormalImpulse = this.NormalImpulse, 
				TangentImpulse = this.TangentImpulse, 
				ID = this.ID
			};
		}
	}
}
