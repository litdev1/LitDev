using System;
namespace Box2DX.Collision
{
	public class Pair
	{
		[Flags]
		public enum PairStatus
		{
			PairBuffered = 1,
			PairRemoved = 2,
			PairFinal = 4
		}
		public object UserData;
		public ushort ProxyId1;
		public ushort ProxyId2;
		public ushort Next;
		public Pair.PairStatus Status;
		public void SetBuffered()
		{
			this.Status |= Pair.PairStatus.PairBuffered;
		}
		public void ClearBuffered()
		{
			this.Status &= ~Pair.PairStatus.PairBuffered;
		}
		public bool IsBuffered()
		{
			return (this.Status & Pair.PairStatus.PairBuffered) == Pair.PairStatus.PairBuffered;
		}
		public void SetRemoved()
		{
			this.Status |= Pair.PairStatus.PairRemoved;
		}
		public void ClearRemoved()
		{
			this.Status &= ~Pair.PairStatus.PairRemoved;
		}
		public bool IsRemoved()
		{
			return (this.Status & Pair.PairStatus.PairRemoved) == Pair.PairStatus.PairRemoved;
		}
		public void SetFinal()
		{
			this.Status |= Pair.PairStatus.PairFinal;
		}
		public bool IsFinal()
		{
			return (this.Status & Pair.PairStatus.PairFinal) == Pair.PairStatus.PairFinal;
		}
	}
}
