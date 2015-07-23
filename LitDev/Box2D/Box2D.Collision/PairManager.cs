using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class PairManager
	{
		public static readonly ushort NullPair = Box2DX.Common.Math.USHRT_MAX;
		public static readonly ushort NullProxy = Box2DX.Common.Math.USHRT_MAX;
		public static readonly int TableCapacity = Settings.MaxPairs;
		public static readonly int TableMask = PairManager.TableCapacity - 1;
		public BroadPhase _broadPhase;
		public PairCallback _callback;
		public Pair[] _pairs = new Pair[Settings.MaxPairs];
		public ushort _freePair;
		public int _pairCount;
		public BufferedPair[] _pairBuffer = new BufferedPair[Settings.MaxPairs];
		public int _pairBufferCount;
		public ushort[] _hashTable = new ushort[PairManager.TableCapacity];
		public PairManager()
		{
			Box2DXDebug.Assert(Box2DX.Common.Math.IsPowerOfTwo((uint)PairManager.TableCapacity));
			Box2DXDebug.Assert(PairManager.TableCapacity >= Settings.MaxPairs);
			for (int i = 0; i < PairManager.TableCapacity; i++)
			{
				this._hashTable[i] = PairManager.NullPair;
			}
			this._freePair = 0;
			for (int i = 0; i < Settings.MaxPairs; i++)
			{
				this._pairs[i] = new Pair();
				this._pairs[i].ProxyId1 = PairManager.NullProxy;
				this._pairs[i].ProxyId2 = PairManager.NullProxy;
				this._pairs[i].UserData = null;
				this._pairs[i].Status = (Pair.PairStatus)0;
				this._pairs[i].Next = (ushort)(i + 1);
			}
			this._pairs[Settings.MaxPairs - 1].Next = PairManager.NullPair;
			this._pairCount = 0;
			this._pairBufferCount = 0;
		}
		public void Initialize(BroadPhase broadPhase, PairCallback callback)
		{
			this._broadPhase = broadPhase;
			this._callback = callback;
		}
		public void AddBufferedPair(int id1, int id2)
		{
			Box2DXDebug.Assert(id1 != (int)PairManager.NullProxy && id2 != (int)PairManager.NullProxy);
			Box2DXDebug.Assert(this._pairBufferCount < Settings.MaxPairs);
			Pair pair = this.AddPair(id1, id2);
			if (!pair.IsBuffered())
			{
				Box2DXDebug.Assert(!pair.IsFinal());
				pair.SetBuffered();
				this._pairBuffer[this._pairBufferCount].ProxyId1 = pair.ProxyId1;
				this._pairBuffer[this._pairBufferCount].ProxyId2 = pair.ProxyId2;
				this._pairBufferCount++;
				Box2DXDebug.Assert(this._pairBufferCount <= this._pairCount);
			}
			pair.ClearRemoved();
			if (BroadPhase.IsValidate)
			{
				this.ValidateBuffer();
			}
		}
		public void RemoveBufferedPair(int id1, int id2)
		{
			Box2DXDebug.Assert(id1 != (int)PairManager.NullProxy && id2 != (int)PairManager.NullProxy);
			Box2DXDebug.Assert(this._pairBufferCount < Settings.MaxPairs);
			Pair pair = this.Find(id1, id2);
			if (pair != null)
			{
				if (!pair.IsBuffered())
				{
					Box2DXDebug.Assert(pair.IsFinal());
					pair.SetBuffered();
					this._pairBuffer[this._pairBufferCount].ProxyId1 = pair.ProxyId1;
					this._pairBuffer[this._pairBufferCount].ProxyId2 = pair.ProxyId2;
					this._pairBufferCount++;
					Box2DXDebug.Assert(this._pairBufferCount <= this._pairCount);
				}
				pair.SetRemoved();
				if (BroadPhase.IsValidate)
				{
					this.ValidateBuffer();
				}
			}
		}
		public void Commit()
		{
			int num = 0;
			Proxy[] proxyPool = this._broadPhase._proxyPool;
			for (int i = 0; i < this._pairBufferCount; i++)
			{
				Pair pair = this.Find((int)this._pairBuffer[i].ProxyId1, (int)this._pairBuffer[i].ProxyId2);
				Box2DXDebug.Assert(pair.IsBuffered());
				pair.ClearBuffered();
				Box2DXDebug.Assert((int)pair.ProxyId1 < Settings.MaxProxies && (int)pair.ProxyId2 < Settings.MaxProxies);
				Proxy proxy = proxyPool[(int)pair.ProxyId1];
				Proxy proxy2 = proxyPool[(int)pair.ProxyId2];
				Box2DXDebug.Assert(proxy.IsValid);
				Box2DXDebug.Assert(proxy2.IsValid);
				if (pair.IsRemoved())
				{
					if (pair.IsFinal())
					{
						this._callback.PairRemoved(proxy.UserData, proxy2.UserData, pair.UserData);
					}
					this._pairBuffer[num].ProxyId1 = pair.ProxyId1;
					this._pairBuffer[num].ProxyId2 = pair.ProxyId2;
					num++;
				}
				else
				{
					Box2DXDebug.Assert(this._broadPhase.TestOverlap(proxy, proxy2));
					if (!pair.IsFinal())
					{
						pair.UserData = this._callback.PairAdded(proxy.UserData, proxy2.UserData);
						pair.SetFinal();
					}
				}
			}
			for (int i = 0; i < num; i++)
			{
				this.RemovePair((int)this._pairBuffer[i].ProxyId1, (int)this._pairBuffer[i].ProxyId2);
			}
			this._pairBufferCount = 0;
			if (BroadPhase.IsValidate)
			{
				this.ValidateTable();
			}
		}
		private Pair Find(int proxyId1, int proxyId2)
		{
			if (proxyId1 > proxyId2)
			{
				Box2DX.Common.Math.Swap<int>(ref proxyId1, ref proxyId2);
			}
			uint hash = (uint)((ulong)this.Hash((uint)proxyId1, (uint)proxyId2) & (ulong)((long)PairManager.TableMask));
			return this.Find(proxyId1, proxyId2, hash);
		}
		private Pair Find(int proxyId1, int proxyId2, uint hash)
		{
			int num = (int)this._hashTable[(int)((UIntPtr)hash)];
			while (num != (int)PairManager.NullPair && !this.Equals(this._pairs[num], proxyId1, proxyId2))
			{
				num = (int)this._pairs[num].Next;
			}
			Pair result;
			if (num == (int)PairManager.NullPair)
			{
				result = null;
			}
			else
			{
				Box2DXDebug.Assert(num < Settings.MaxPairs);
				result = this._pairs[num];
			}
			return result;
		}
		private Pair AddPair(int proxyId1, int proxyId2)
		{
			if (proxyId1 > proxyId2)
			{
				Box2DX.Common.Math.Swap<int>(ref proxyId1, ref proxyId2);
			}
			int num = (int)((ulong)this.Hash((uint)proxyId1, (uint)proxyId2) & (ulong)((long)PairManager.TableMask));
			Pair pair = this.Find(proxyId1, proxyId2, (uint)num);
			Pair result;
			if (pair != null)
			{
				result = pair;
			}
			else
			{
				Box2DXDebug.Assert(this._pairCount < Settings.MaxPairs && this._freePair != PairManager.NullPair);
				ushort freePair = this._freePair;
				pair = this._pairs[(int)freePair];
				this._freePair = pair.Next;
				pair.ProxyId1 = (ushort)proxyId1;
				pair.ProxyId2 = (ushort)proxyId2;
				pair.Status = (Pair.PairStatus)0;
				pair.UserData = null;
				pair.Next = this._hashTable[num];
				this._hashTable[num] = freePair;
				this._pairCount++;
				result = pair;
			}
			return result;
		}
		private object RemovePair(int proxyId1, int proxyId2)
		{
			Box2DXDebug.Assert(this._pairCount > 0);
			if (proxyId1 > proxyId2)
			{
				Box2DX.Common.Math.Swap<int>(ref proxyId1, ref proxyId2);
			}
			int num = (int)((ulong)this.Hash((uint)proxyId1, (uint)proxyId2) & (ulong)((long)PairManager.TableMask));
			ushort num2 = this._hashTable[num];
			bool flag = false;
			int num3 = 0;
			object result;
			while (num2 != PairManager.NullPair)
			{
				if (this.Equals(this._pairs[(int)num2], proxyId1, proxyId2))
				{
					ushort num4 = num2;
					num2 = this._pairs[(int)num2].Next;
					if (flag)
					{
						this._pairs[num3].Next = num2;
					}
					else
					{
						this._hashTable[num] = num2;
					}
					Pair pair = this._pairs[(int)num4];
					object userData = pair.UserData;
					pair.Next = this._freePair;
					pair.ProxyId1 = PairManager.NullProxy;
					pair.ProxyId2 = PairManager.NullProxy;
					pair.UserData = null;
					pair.Status = (Pair.PairStatus)0;
					this._freePair = num4;
					this._pairCount--;
					result = userData;
					return result;
				}
				num3 = (int)num2;
				num2 = this._pairs[num3].Next;
				flag = true;
			}
			Box2DXDebug.Assert(false);
			result = null;
			return result;
		}
		private void ValidateBuffer()
		{
			Box2DXDebug.Assert(this._pairBufferCount <= this._pairCount);
			BufferedPair[] array = new BufferedPair[this._pairBufferCount];
			Array.Copy(this._pairBuffer, 0, array, 0, this._pairBufferCount);
			Array.Sort<BufferedPair>(array, new Comparison<BufferedPair>(PairManager.BufferedPairSortPredicate));
			Array.Copy(array, 0, this._pairBuffer, 0, this._pairBufferCount);
			for (int i = 0; i < this._pairBufferCount; i++)
			{
				if (i > 0)
				{
					Box2DXDebug.Assert(!object.Equals(this._pairBuffer[i], this._pairBuffer[i - 1]));
				}
				Pair pair = this.Find((int)this._pairBuffer[i].ProxyId1, (int)this._pairBuffer[i].ProxyId2);
				Box2DXDebug.Assert(pair.IsBuffered());
				Box2DXDebug.Assert(pair.ProxyId1 != pair.ProxyId2);
				Box2DXDebug.Assert((int)pair.ProxyId1 < Settings.MaxProxies);
				Box2DXDebug.Assert((int)pair.ProxyId2 < Settings.MaxProxies);
				Proxy proxy = this._broadPhase._proxyPool[(int)pair.ProxyId1];
				Proxy proxy2 = this._broadPhase._proxyPool[(int)pair.ProxyId2];
				Box2DXDebug.Assert(proxy.IsValid);
				Box2DXDebug.Assert(proxy2.IsValid);
			}
		}
		private void ValidateTable()
		{
			for (int i = 0; i < PairManager.TableCapacity; i++)
			{
				Pair pair;
				for (ushort num = this._hashTable[i]; num != PairManager.NullPair; num = pair.Next)
				{
					pair = this._pairs[(int)num];
					Box2DXDebug.Assert(!pair.IsBuffered());
					Box2DXDebug.Assert(pair.IsFinal());
					Box2DXDebug.Assert(!pair.IsRemoved());
					Box2DXDebug.Assert(pair.ProxyId1 != pair.ProxyId2);
					Box2DXDebug.Assert((int)pair.ProxyId1 < Settings.MaxProxies);
					Box2DXDebug.Assert((int)pair.ProxyId2 < Settings.MaxProxies);
					Proxy proxy = this._broadPhase._proxyPool[(int)pair.ProxyId1];
					Proxy proxy2 = this._broadPhase._proxyPool[(int)pair.ProxyId2];
					Box2DXDebug.Assert(proxy.IsValid);
					Box2DXDebug.Assert(proxy2.IsValid);
					Box2DXDebug.Assert(this._broadPhase.TestOverlap(proxy, proxy2));
				}
			}
		}
		private uint Hash(uint proxyId1, uint proxyId2)
		{
			uint num = proxyId2 << 16 | proxyId1;
			num = ~num + (num << 15);
			num ^= num >> 12;
			num += num << 2;
			num ^= num >> 4;
			num *= 2057u;
			return num ^ num >> 16;
		}
		private bool Equals(Pair pair, int proxyId1, int proxyId2)
		{
			return (int)pair.ProxyId1 == proxyId1 && (int)pair.ProxyId2 == proxyId2;
		}
		private bool Equals(ref BufferedPair pair1, ref BufferedPair pair2)
		{
			return pair1.ProxyId1 == pair2.ProxyId1 && pair1.ProxyId2 == pair2.ProxyId2;
		}
		public static int BufferedPairSortPredicate(BufferedPair pair1, BufferedPair pair2)
		{
			int result;
			if (pair1.ProxyId1 > pair2.ProxyId1)
			{
				result = 1;
			}
			else
			{
				if (pair1.ProxyId1 < pair2.ProxyId1)
				{
					result = -1;
				}
				else
				{
					if (pair1.ProxyId2 > pair2.ProxyId2)
					{
						result = 1;
					}
					else
					{
						if (pair1.ProxyId2 < pair2.ProxyId2)
						{
							result = -1;
						}
						else
						{
							result = 0;
						}
					}
				}
			}
			return result;
		}
	}
}
