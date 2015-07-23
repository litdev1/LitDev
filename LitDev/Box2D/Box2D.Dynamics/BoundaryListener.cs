using System;
namespace Box2DX.Dynamics
{
	public abstract class BoundaryListener
	{
		public abstract void Violation(Body body);
	}
}
