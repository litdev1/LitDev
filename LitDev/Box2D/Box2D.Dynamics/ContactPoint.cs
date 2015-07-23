using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class ContactPoint
	{
		public Shape Shape1;
		public Shape Shape2;
		public Vec2 Position;
		public Vec2 Velocity;
		public Vec2 Normal;
		public float Separation;
		public float Friction;
		public float Restitution;
		public ContactID ID;
	}
}
