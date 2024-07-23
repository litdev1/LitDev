using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class ContactResult
	{
		public Shape Shape1;
		public Shape Shape2;
		public Vec2 Position;
		public Vec2 Normal;
		public float NormalImpulse;
		public float TangentImpulse;
		public ContactID ID;
	}
}
