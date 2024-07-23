using Box2DX.Collision;
using System;
namespace Box2DX.Dynamics
{
	public abstract class DestructionListener
	{
		public abstract void SayGoodbye(Joint joint);
		public abstract void SayGoodbye(Shape shape);
	}
}
