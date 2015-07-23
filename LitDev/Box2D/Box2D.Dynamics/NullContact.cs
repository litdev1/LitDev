using Box2DX.Collision;
using System;
namespace Box2DX.Dynamics
{
	public class NullContact : Contact
	{
		public override void Evaluate(ContactListener listener)
		{
		}
		public override Manifold[] GetManifolds()
		{
			return null;
		}
	}
}
