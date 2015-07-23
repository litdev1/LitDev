using System;
namespace Box2DX.Collision
{
	public class Proxy
	{
		public ushort[] LowerBounds = new ushort[2];
		public ushort[] UpperBounds = new ushort[2];
		public ushort OverlapCount;
		public ushort TimeStamp;
		public object UserData;
		public ushort Next
		{
			get
			{
				return this.LowerBounds[0];
			}
			set
			{
				this.LowerBounds[0] = value;
			}
		}
		public bool IsValid
		{
			get
			{
				return this.OverlapCount != BroadPhase.Invalid;
			}
		}
	}
}
