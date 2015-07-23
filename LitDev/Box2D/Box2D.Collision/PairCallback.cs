using System;
namespace Box2DX.Collision
{
	public abstract class PairCallback
	{
		public abstract object PairAdded(object proxyUserData1, object proxyUserData2);
		public abstract void PairRemoved(object proxyUserData1, object proxyUserData2, object pairUserData);
	}
}
