using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class ContactConstraintPoint
	{
		public Vec2 LocalAnchor1;
		public Vec2 LocalAnchor2;
		public Vec2 R1;
		public Vec2 R2;
		public float NormalImpulse;
		public float TangentImpulse;
		public float NormalMass;
		public float TangentMass;
		public float EqualizedMass;
		public float Separation;
		public float VelocityBias;
	}
}
