using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class BroadPhase
	{
		public static readonly ushort BROADPHASE_MAX = Box2DX.Common.Math.USHRT_MAX;
		public static readonly ushort Invalid = BroadPhase.BROADPHASE_MAX;
		public static readonly ushort NullEdge = BroadPhase.BROADPHASE_MAX;
		public PairManager _pairManager;
		public Proxy[] _proxyPool = new Proxy[Settings.MaxProxies];
		public ushort _freeProxy;
		public Bound[][] _bounds = new Bound[2][];
		public ushort[] _queryResults = new ushort[Settings.MaxProxies];
		public float[] _querySortKeys = new float[Settings.MaxProxies];
		public int _queryResultCount;
		public AABB _worldAABB;
		public Vec2 _quantizationFactor;
		public int _proxyCount;
		public ushort _timeStamp;
		public static bool IsValidate = false;
		private int qi1 = 0;
		private int qi2 = 0;
		public BroadPhase(AABB worldAABB, PairCallback callback)
		{
			this._pairManager = new PairManager();
			this._pairManager.Initialize(this, callback);
			Box2DXDebug.Assert(worldAABB.IsValid);
			this._worldAABB = worldAABB;
			this._proxyCount = 0;
			Vec2 vec = worldAABB.UpperBound - worldAABB.LowerBound;
			this._quantizationFactor.X = (float)BroadPhase.BROADPHASE_MAX / vec.X;
			this._quantizationFactor.Y = (float)BroadPhase.BROADPHASE_MAX / vec.Y;
			ushort num = 0;
			while ((int)num < Settings.MaxProxies - 1)
			{
				this._proxyPool[(int)num] = new Proxy();
				this._proxyPool[(int)num].Next = (ushort)(num + 1);
				this._proxyPool[(int)num].TimeStamp = 0;
				this._proxyPool[(int)num].OverlapCount = BroadPhase.Invalid;
				this._proxyPool[(int)num].UserData = null;
				num += 1;
			}
			this._proxyPool[Settings.MaxProxies - 1] = new Proxy();
			this._proxyPool[Settings.MaxProxies - 1].Next = PairManager.NullProxy;
			this._proxyPool[Settings.MaxProxies - 1].TimeStamp = 0;
			this._proxyPool[Settings.MaxProxies - 1].OverlapCount = BroadPhase.Invalid;
			this._proxyPool[Settings.MaxProxies - 1].UserData = null;
			this._freeProxy = 0;
			this._timeStamp = 1;
			this._queryResultCount = 0;
			for (int i = 0; i < 2; i++)
			{
				this._bounds[i] = new Bound[2 * Settings.MaxProxies];
			}
			int num2 = 2 * Settings.MaxProxies;
			for (int j = 0; j < 2; j++)
			{
				for (int k = 0; k < num2; k++)
				{
					this._bounds[j][k] = new Bound();
				}
			}
		}
		public bool InRange(AABB aabb)
		{
			Vec2 vec = Box2DX.Common.Math.Max(aabb.LowerBound - this._worldAABB.UpperBound, this._worldAABB.LowerBound - aabb.UpperBound);
			return Box2DX.Common.Math.Max(vec.X, vec.Y) < 0f;
		}
		public ushort CreateProxy(AABB aabb, object userData)
		{
			Box2DXDebug.Assert(this._proxyCount < Settings.MaxProxies);
			Box2DXDebug.Assert(this._freeProxy != PairManager.NullProxy);
			ushort freeProxy = this._freeProxy;
			Proxy proxy = this._proxyPool[(int)freeProxy];
			this._freeProxy = proxy.Next;
			proxy.OverlapCount = 0;
			proxy.UserData = userData;
			int num = 2 * this._proxyCount;
			ushort[] array = new ushort[2];
			ushort[] array2 = new ushort[2];
			this.ComputeBounds(out array, out array2, aabb);
			for (int i = 0; i < 2; i++)
			{
				Bound[] array3 = this._bounds[i];
				int num2;
				int num3;
				this.Query(out num2, out num3, array[i], array2[i], array3, num, i);
				Bound[] array4 = new Bound[num - num3];
				for (int j = 0; j < num - num3; j++)
				{
					array4[j] = array3[num3 + j].Clone();
				}
				for (int j = 0; j < num - num3; j++)
				{
					array3[num3 + 2 + j] = array4[j];
				}
				array4 = new Bound[num3 - num2];
				for (int j = 0; j < num3 - num2; j++)
				{
					array4[j] = array3[num2 + j].Clone();
				}
				for (int j = 0; j < num3 - num2; j++)
				{
					array3[num2 + 1 + j] = array4[j];
				}
				num3++;
				array3[num2].Value = array[i];
				array3[num2].ProxyId = freeProxy;
				array3[num3].Value = array2[i];
				array3[num3].ProxyId = freeProxy;
                array3[num2].StabbingCount = ((num2 == 0) ? (ushort)0 : array3[num2 - 1].StabbingCount);
				array3[num3].StabbingCount = array3[num3 - 1].StabbingCount;
				for (int k = num2; k < num3; k++)
				{
					Bound expr_1E4 = array3[k];
					expr_1E4.StabbingCount += 1;
				}
				for (int k = num2; k < num + 2; k++)
				{
					Proxy proxy2 = this._proxyPool[(int)array3[k].ProxyId];
					if (array3[k].IsLower)
					{
						proxy2.LowerBounds[i] = (ushort)k;
					}
					else
					{
						proxy2.UpperBounds[i] = (ushort)k;
					}
				}
			}
			this._proxyCount++;
			Box2DXDebug.Assert(this._queryResultCount < Settings.MaxProxies);
			for (int j = 0; j < this._queryResultCount; j++)
			{
				Box2DXDebug.Assert((int)this._queryResults[j] < Settings.MaxProxies);
				Box2DXDebug.Assert(this._proxyPool[(int)this._queryResults[j]].IsValid);
				this._pairManager.AddBufferedPair((int)freeProxy, (int)this._queryResults[j]);
			}
			this._pairManager.Commit();
			if (BroadPhase.IsValidate)
			{
				this.Validate();
			}
			this._queryResultCount = 0;
			this.IncrementTimeStamp();
			return freeProxy;
		}
		public void DestroyProxy(int proxyId)
		{
			Box2DXDebug.Assert(0 < this._proxyCount && this._proxyCount <= Settings.MaxProxies);
			Proxy proxy = this._proxyPool[proxyId];
			Box2DXDebug.Assert(proxy.IsValid);
			int num = 2 * this._proxyCount;
			for (int i = 0; i < 2; i++)
			{
				Bound[] array = this._bounds[i];
				int num2 = (int)proxy.LowerBounds[i];
				int num3 = (int)proxy.UpperBounds[i];
				ushort value = array[num2].Value;
				ushort value2 = array[num3].Value;
				Bound[] array2 = new Bound[num3 - num2 - 1];
				for (int j = 0; j < num3 - num2 - 1; j++)
				{
					array2[j] = array[num2 + 1 + j].Clone();
				}
				for (int j = 0; j < num3 - num2 - 1; j++)
				{
					array[num2 + j] = array2[j];
				}
				array2 = new Bound[num - num3 - 1];
				for (int j = 0; j < num - num3 - 1; j++)
				{
					array2[j] = array[num3 + 1 + j].Clone();
				}
				for (int j = 0; j < num - num3 - 1; j++)
				{
					array[num3 - 1 + j] = array2[j];
				}
				for (int k = num2; k < num - 2; k++)
				{
					Proxy proxy2 = this._proxyPool[(int)array[k].ProxyId];
					if (array[k].IsLower)
					{
						proxy2.LowerBounds[i] = (ushort)k;
					}
					else
					{
						proxy2.UpperBounds[i] = (ushort)k;
					}
				}
				for (int k = num2; k < num3 - 1; k++)
				{
					Bound expr_1B5 = array[k];
					expr_1B5.StabbingCount -= 1;
				}
				this.Query(out num2, out num3, value, value2, array, num - 2, i);
			}
			Box2DXDebug.Assert(this._queryResultCount < Settings.MaxProxies);
			for (int j = 0; j < this._queryResultCount; j++)
			{
				Box2DXDebug.Assert(this._proxyPool[(int)this._queryResults[j]].IsValid);
				this._pairManager.RemoveBufferedPair(proxyId, (int)this._queryResults[j]);
			}
			this._pairManager.Commit();
			this._queryResultCount = 0;
			this.IncrementTimeStamp();
			proxy.UserData = null;
			proxy.OverlapCount = BroadPhase.Invalid;
			proxy.LowerBounds[0] = BroadPhase.Invalid;
			proxy.LowerBounds[1] = BroadPhase.Invalid;
			proxy.UpperBounds[0] = BroadPhase.Invalid;
			proxy.UpperBounds[1] = BroadPhase.Invalid;
			proxy.Next = this._freeProxy;
			this._freeProxy = (ushort)proxyId;
			this._proxyCount--;
			if (BroadPhase.IsValidate)
			{
				this.Validate();
			}
		}
		public void MoveProxy(int proxyId, AABB aabb)
		{
			if (proxyId == (int)PairManager.NullProxy || Settings.MaxProxies <= proxyId)
			{
				Box2DXDebug.Assert(false);
			}
			else
			{
				if (!aabb.IsValid)
				{
					Box2DXDebug.Assert(false);
				}
				else
				{
					int num = 2 * this._proxyCount;
					Proxy proxy = this._proxyPool[proxyId];
					BoundValues boundValues = new BoundValues();
					this.ComputeBounds(out boundValues.LowerValues, out boundValues.UpperValues, aabb);
					BoundValues boundValues2 = new BoundValues();
					for (int i = 0; i < 2; i++)
					{
						boundValues2.LowerValues[i] = this._bounds[i][(int)proxy.LowerBounds[i]].Value;
						boundValues2.UpperValues[i] = this._bounds[i][(int)proxy.UpperBounds[i]].Value;
					}
					for (int i = 0; i < 2; i++)
					{
						Bound[] array = this._bounds[i];
						int num2 = (int)proxy.LowerBounds[i];
						int num3 = (int)proxy.UpperBounds[i];
						ushort num4 = boundValues.LowerValues[i];
						ushort num5 = boundValues.UpperValues[i];
						int num6 = (int)(num4 - array[num2].Value);
						int num7 = (int)(num5 - array[num3].Value);
						array[num2].Value = num4;
						array[num3].Value = num5;
						if (num6 < 0)
						{
							int num8 = num2;
							while (num8 > 0 && num4 < array[num8 - 1].Value)
							{
								Bound bound = array[num8];
								Bound bound2 = array[num8 - 1];
								int proxyId2 = (int)bound2.ProxyId;
								Proxy proxy2 = this._proxyPool[(int)bound2.ProxyId];
								Bound expr_18A = bound2;
								expr_18A.StabbingCount += 1;
								if (bound2.IsUpper)
								{
									if (this.TestOverlap(boundValues, proxy2))
									{
										this._pairManager.AddBufferedPair(proxyId, proxyId2);
									}
									ushort[] expr_1DA_cp_0 = proxy2.UpperBounds;
									int expr_1DA_cp_1 = i;
									expr_1DA_cp_0[expr_1DA_cp_1] += 1;
									Bound expr_1EA = bound;
									expr_1EA.StabbingCount += 1;
								}
								else
								{
									ushort[] expr_20A_cp_0 = proxy2.LowerBounds;
									int expr_20A_cp_1 = i;
									expr_20A_cp_0[expr_20A_cp_1] += 1;
									Bound expr_21A = bound;
									expr_21A.StabbingCount -= 1;
								}
								ushort[] expr_236_cp_0 = proxy.LowerBounds;
								int expr_236_cp_1 = i;
								expr_236_cp_0[expr_236_cp_1] -= 1;
								Box2DX.Common.Math.Swap<Bound>(ref array[num8], ref array[num8 - 1]);
								num8--;
							}
						}
						if (num7 > 0)
						{
							int num8 = num3;
							while (num8 < num - 1 && array[num8 + 1].Value <= num5)
							{
								Bound bound = array[num8];
								Bound bound3 = array[num8 + 1];
								int proxyId3 = (int)bound3.ProxyId;
								Proxy proxy3 = this._proxyPool[proxyId3];
								Bound expr_2C9 = bound3;
								expr_2C9.StabbingCount += 1;
								if (bound3.IsLower)
								{
									if (this.TestOverlap(boundValues, proxy3))
									{
										this._pairManager.AddBufferedPair(proxyId, proxyId3);
									}
									ushort[] expr_319_cp_0 = proxy3.LowerBounds;
									int expr_319_cp_1 = i;
									expr_319_cp_0[expr_319_cp_1] -= 1;
									Bound expr_329 = bound;
									expr_329.StabbingCount += 1;
								}
								else
								{
									ushort[] expr_349_cp_0 = proxy3.UpperBounds;
									int expr_349_cp_1 = i;
									expr_349_cp_0[expr_349_cp_1] -= 1;
									Bound expr_359 = bound;
									expr_359.StabbingCount -= 1;
								}
								ushort[] expr_375_cp_0 = proxy.UpperBounds;
								int expr_375_cp_1 = i;
								expr_375_cp_0[expr_375_cp_1] += 1;
								Box2DX.Common.Math.Swap<Bound>(ref array[num8], ref array[num8 + 1]);
								num8++;
							}
						}
						if (num6 > 0)
						{
							int num8 = num2;
							while (num8 < num - 1 && array[num8 + 1].Value <= num4)
							{
								Bound bound = array[num8];
								Bound bound3 = array[num8 + 1];
								int proxyId3 = (int)bound3.ProxyId;
								Proxy proxy3 = this._proxyPool[proxyId3];
								Bound expr_40D = bound3;
								expr_40D.StabbingCount -= 1;
								if (bound3.IsUpper)
								{
									if (this.TestOverlap(boundValues2, proxy3))
									{
										this._pairManager.RemoveBufferedPair(proxyId, proxyId3);
									}
									ushort[] expr_45D_cp_0 = proxy3.UpperBounds;
									int expr_45D_cp_1 = i;
									expr_45D_cp_0[expr_45D_cp_1] -= 1;
									Bound expr_46D = bound;
									expr_46D.StabbingCount -= 1;
								}
								else
								{
									ushort[] expr_48D_cp_0 = proxy3.LowerBounds;
									int expr_48D_cp_1 = i;
									expr_48D_cp_0[expr_48D_cp_1] -= 1;
									Bound expr_49D = bound;
									expr_49D.StabbingCount += 1;
								}
								ushort[] expr_4B9_cp_0 = proxy.LowerBounds;
								int expr_4B9_cp_1 = i;
								expr_4B9_cp_0[expr_4B9_cp_1] += 1;
								Box2DX.Common.Math.Swap<Bound>(ref array[num8], ref array[num8 + 1]);
								num8++;
							}
						}
						if (num7 < 0)
						{
							int num8 = num3;
							while (num8 > 0 && num5 < array[num8 - 1].Value)
							{
								Bound bound = array[num8];
								Bound bound2 = array[num8 - 1];
								int proxyId2 = (int)bound2.ProxyId;
								Proxy proxy2 = this._proxyPool[proxyId2];
								Bound expr_551 = bound2;
								expr_551.StabbingCount -= 1;
								if (bound2.IsLower)
								{
									if (this.TestOverlap(boundValues2, proxy2))
									{
										this._pairManager.RemoveBufferedPair(proxyId, proxyId2);
									}
									ushort[] expr_5A1_cp_0 = proxy2.LowerBounds;
									int expr_5A1_cp_1 = i;
									expr_5A1_cp_0[expr_5A1_cp_1] += 1;
									Bound expr_5B1 = bound;
									expr_5B1.StabbingCount -= 1;
								}
								else
								{
									ushort[] expr_5D1_cp_0 = proxy2.UpperBounds;
									int expr_5D1_cp_1 = i;
									expr_5D1_cp_0[expr_5D1_cp_1] += 1;
									Bound expr_5E1 = bound;
									expr_5E1.StabbingCount += 1;
								}
								ushort[] expr_5FD_cp_0 = proxy.UpperBounds;
								int expr_5FD_cp_1 = i;
								expr_5FD_cp_0[expr_5FD_cp_1] -= 1;
								Box2DX.Common.Math.Swap<Bound>(ref array[num8], ref array[num8 - 1]);
								num8--;
							}
						}
					}
					if (BroadPhase.IsValidate)
					{
						this.Validate();
					}
				}
			}
		}
		public void Commit()
		{
			this._pairManager.Commit();
		}
		public Proxy GetProxy(int proxyId)
		{
			Proxy result;
			if (proxyId == (int)PairManager.NullProxy || !this._proxyPool[proxyId].IsValid)
			{
				result = null;
			}
			else
			{
				result = this._proxyPool[proxyId];
			}
			return result;
		}
		public int Query(AABB aabb, object[] userData, int maxCount)
		{
			ushort[] array;
			ushort[] array2;
			this.ComputeBounds(out array, out array2, aabb);
			int num;
			int num2;
			this.Query(out num, out num2, array[0], array2[0], this._bounds[0], 2 * this._proxyCount, 0);
			this.Query(out num, out num2, array[1], array2[1], this._bounds[1], 2 * this._proxyCount, 1);
			Box2DXDebug.Assert(this._queryResultCount < Settings.MaxProxies);
			int num3 = 0;
			int num4 = 0;
			while (num4 < this._queryResultCount && num3 < maxCount)
			{
				Box2DXDebug.Assert((int)this._queryResults[num4] < Settings.MaxProxies);
				Proxy proxy = this._proxyPool[(int)this._queryResults[num4]];
				Box2DXDebug.Assert(proxy.IsValid);
				userData[num4] = proxy.UserData;
				num4++;
				num3++;
			}
			this._queryResultCount = 0;
			this.IncrementTimeStamp();
			return num3;
		}
		public unsafe int QuerySegment(Segment segment, object[] userData, int maxCount, SortKeyFunc sortKey)
		{
			float num = 1f;
			float num2 = (segment.P2.X - segment.P1.X) * this._quantizationFactor.X;
			float num3 = (segment.P2.Y - segment.P1.Y) * this._quantizationFactor.Y;
			int num4 = (num2 < -Settings.FLT_EPSILON) ? -1 : ((num2 > Settings.FLT_EPSILON) ? 1 : 0);
			int num5 = (num3 < -Settings.FLT_EPSILON) ? -1 : ((num3 > Settings.FLT_EPSILON) ? 1 : 0);
			Box2DXDebug.Assert(num4 != 0 || num5 != 0);
			float num6 = (segment.P1.X - this._worldAABB.LowerBound.X) * this._quantizationFactor.X;
			float num7 = (segment.P1.Y - this._worldAABB.LowerBound.Y) * this._quantizationFactor.Y;
			ushort* ptr = stackalloc ushort[2];
			ushort* ptr2 = stackalloc ushort[2];
            *ptr = (ushort)((ushort)num6 & BroadPhase.BROADPHASE_MAX - 1);
            *ptr2 = (ushort)((ushort)num6 | 1);
            ptr[2 / 2] = (ushort)((ushort)num7 & BroadPhase.BROADPHASE_MAX - 1);
            ptr2[2 / 2] = (ushort)((ushort)num7 | 1);
			int num8;
			int num9;
			this.Query(out num8, out num9, *ptr, *ptr2, this._bounds[0], 2 * this._proxyCount, 0);
			int num10;
			if (num4 >= 0)
			{
				num10 = num9 - 1;
			}
			else
			{
				num10 = num8;
			}
			this.Query(out num8, out num9, ptr[2 / 2], *(ptr2 + 2 / 2), this._bounds[1], 2 * this._proxyCount, 1);
			int num11;
			if (num5 >= 0)
			{
				num11 = num9 - 1;
			}
			else
			{
				num11 = num8;
			}
			int j;
			if (sortKey != null)
			{
				for (int i = 0; i < this._queryResultCount; i++)
				{
					this._querySortKeys[i] = sortKey(this._proxyPool[(int)this._queryResults[i]].UserData);
				}
				j = 0;
				while (j < this._queryResultCount - 1)
				{
					float num12 = this._querySortKeys[j];
					float num13 = this._querySortKeys[j + 1];
					if (((num12 < 0f) ? ((num13 >= 0f) ? 1 : 0) : ((num12 <= num13) ? 0 : ((num13 >= 0f) ? 1 : 0))) != 0)
					{
						this._querySortKeys[j + 1] = num12;
						this._querySortKeys[j] = num13;
						ushort num14 = this._queryResults[j + 1];
						this._queryResults[j + 1] = this._queryResults[j];
						this._queryResults[j] = num14;
						j--;
						if (j == -1)
						{
							j = 1;
						}
					}
					else
					{
						j++;
					}
				}
				while (this._queryResultCount > 0 && this._querySortKeys[this._queryResultCount - 1] < 0f)
				{
					this._queryResultCount--;
				}
			}
			float num15 = 0f;
			float num16 = 0f;
			if (num10 >= 0 && num10 < this._proxyCount * 2)
			{
				if (num11 >= 0 && num11 < this._proxyCount * 2)
				{
					if (num4 != 0)
					{
						if (num4 > 0)
						{
							num10++;
							if (num10 == this._proxyCount * 2)
							{
								goto IL_829;
							}
						}
						else
						{
							num10--;
							if (num10 < 0)
							{
								goto IL_829;
							}
						}
						num15 = ((float)this._bounds[0][num10].Value - num6) / num2;
					}
					if (num5 != 0)
					{
						if (num5 > 0)
						{
							num11++;
							if (num11 == this._proxyCount * 2)
							{
								goto IL_829;
							}
						}
						else
						{
							num11--;
							if (num11 < 0)
							{
								goto IL_829;
							}
						}
						num16 = ((float)this._bounds[1][num11].Value - num7) / num3;
					}
					while (true)
					{
						if (num5 == 0 || (num4 != 0 && num15 < num16))
						{
							if (num15 > num)
							{
								break;
							}
							if ((num4 > 0) ? this._bounds[0][num10].IsLower : this._bounds[0][num10].IsUpper)
							{
								ushort proxyId = this._bounds[0][num10].ProxyId;
								Proxy proxy = this._proxyPool[(int)proxyId];
								if (num5 >= 0)
								{
									if ((int)proxy.LowerBounds[1] <= num11 - 1 && (int)proxy.UpperBounds[1] >= num11)
									{
										if (sortKey != null)
										{
											this.AddProxyResult(proxyId, proxy, maxCount, sortKey);
										}
										else
										{
											this._queryResults[this._queryResultCount] = proxyId;
											this._queryResultCount++;
										}
									}
								}
								else
								{
									if ((int)proxy.LowerBounds[1] <= num11 && (int)proxy.UpperBounds[1] >= num11 + 1)
									{
										if (sortKey != null)
										{
											this.AddProxyResult(proxyId, proxy, maxCount, sortKey);
										}
										else
										{
											this._queryResults[this._queryResultCount] = proxyId;
											this._queryResultCount++;
										}
									}
								}
							}
							if (sortKey != null && this._queryResultCount == maxCount && this._queryResultCount > 0 && num15 > this._querySortKeys[this._queryResultCount - 1])
							{
								break;
							}
							if (num4 > 0)
							{
								num10++;
								if (num10 == this._proxyCount * 2)
								{
									break;
								}
							}
							else
							{
								num10--;
								if (num10 < 0)
								{
									break;
								}
							}
							num15 = ((float)this._bounds[0][num10].Value - num6) / num2;
						}
						else
						{
							if (num16 > num)
							{
								break;
							}
							if ((num5 > 0) ? this._bounds[1][num11].IsLower : this._bounds[1][num11].IsUpper)
							{
								ushort proxyId = this._bounds[1][num11].ProxyId;
								Proxy proxy = this._proxyPool[(int)proxyId];
								if (num4 >= 0)
								{
									if ((int)proxy.LowerBounds[0] <= num10 - 1 && (int)proxy.UpperBounds[0] >= num10)
									{
										if (sortKey != null)
										{
											this.AddProxyResult(proxyId, proxy, maxCount, sortKey);
										}
										else
										{
											this._queryResults[this._queryResultCount] = proxyId;
											this._queryResultCount++;
										}
									}
								}
								else
								{
									if ((int)proxy.LowerBounds[0] <= num10 && (int)proxy.UpperBounds[0] >= num10 + 1)
									{
										if (sortKey != null)
										{
											this.AddProxyResult(proxyId, proxy, maxCount, sortKey);
										}
										else
										{
											this._queryResults[this._queryResultCount] = proxyId;
											this._queryResultCount++;
										}
									}
								}
							}
							if (sortKey != null && this._queryResultCount == maxCount && this._queryResultCount > 0 && num16 > this._querySortKeys[this._queryResultCount - 1])
							{
								break;
							}
							if (num5 > 0)
							{
								num11++;
								if (num11 == this._proxyCount * 2)
								{
									break;
								}
							}
							else
							{
								num11--;
								if (num11 < 0)
								{
									break;
								}
							}
							num16 = ((float)this._bounds[1][num11].Value - num7) / num3;
						}
					}
				}
			}
			IL_829:
			int num17 = 0;
			j = 0;
			while (j < this._queryResultCount && num17 < maxCount)
			{
				Box2DXDebug.Assert((int)this._queryResults[j] < Settings.MaxProxies);
				Proxy proxy2 = this._proxyPool[(int)this._queryResults[j]];
				Box2DXDebug.Assert(proxy2.IsValid);
				userData[j] = proxy2.UserData;
				j++;
				num17++;
			}
			this._queryResultCount = 0;
			this.IncrementTimeStamp();
			return num17;
		}
		public void Validate()
		{
			for (int i = 0; i < 2; i++)
			{
				Bound[] array = this._bounds[i];
				int num = 2 * this._proxyCount;
				ushort num2 = 0;
				for (int j = 0; j < num; j++)
				{
					Bound bound = array[j];
					Box2DXDebug.Assert(j == 0 || array[j - 1].Value <= bound.Value);
					Box2DXDebug.Assert(bound.ProxyId != PairManager.NullProxy);
					Box2DXDebug.Assert(this._proxyPool[(int)bound.ProxyId].IsValid);
					if (bound.IsLower)
					{
						Box2DXDebug.Assert((int)this._proxyPool[(int)bound.ProxyId].LowerBounds[i] == j);
						num2 += 1;
					}
					else
					{
						Box2DXDebug.Assert((int)this._proxyPool[(int)bound.ProxyId].UpperBounds[i] == j);
						num2 -= 1;
					}
					Box2DXDebug.Assert(bound.StabbingCount == num2);
				}
			}
		}
		private void ComputeBounds(out ushort[] lowerValues, out ushort[] upperValues, AABB aabb)
		{
			lowerValues = new ushort[2];
			upperValues = new ushort[2];
			Box2DXDebug.Assert(aabb.UpperBound.X >= aabb.LowerBound.X);
			Box2DXDebug.Assert(aabb.UpperBound.Y >= aabb.LowerBound.Y);
			Vec2 vec = Box2DX.Common.Math.Clamp(aabb.LowerBound, this._worldAABB.LowerBound, this._worldAABB.UpperBound);
			Vec2 vec2 = Box2DX.Common.Math.Clamp(aabb.UpperBound, this._worldAABB.LowerBound, this._worldAABB.UpperBound);
            lowerValues[0] = (ushort)((ushort)(this._quantizationFactor.X * (vec.X - this._worldAABB.LowerBound.X)) & BroadPhase.BROADPHASE_MAX - 1);
            upperValues[0] = (ushort)((ushort)(this._quantizationFactor.X * (vec2.X - this._worldAABB.LowerBound.X)) | 1);
            lowerValues[1] = (ushort)((ushort)(this._quantizationFactor.Y * (vec.Y - this._worldAABB.LowerBound.Y)) & BroadPhase.BROADPHASE_MAX - 1);
            upperValues[1] = (ushort)((ushort)(this._quantizationFactor.Y * (vec2.Y - this._worldAABB.LowerBound.Y)) | 1);
		}
		internal bool TestOverlap(Proxy p1, Proxy p2)
		{
			int i = 0;
			bool result;
			while (i < 2)
			{
				Bound[] array = this._bounds[i];
				Box2DXDebug.Assert((int)p1.LowerBounds[i] < 2 * this._proxyCount);
				Box2DXDebug.Assert((int)p1.UpperBounds[i] < 2 * this._proxyCount);
				Box2DXDebug.Assert((int)p2.LowerBounds[i] < 2 * this._proxyCount);
				Box2DXDebug.Assert((int)p2.UpperBounds[i] < 2 * this._proxyCount);
				if (array[(int)p1.LowerBounds[i]].Value > array[(int)p2.UpperBounds[i]].Value)
				{
					result = false;
				}
				else
				{
					if (array[(int)p1.UpperBounds[i]].Value >= array[(int)p2.LowerBounds[i]].Value)
					{
						i++;
						continue;
					}
					result = false;
				}
				return result;
			}
			result = true;
			return result;
		}
		internal bool TestOverlap(BoundValues b, Proxy p)
		{
			int i = 0;
			bool result;
			while (i < 2)
			{
				Bound[] array = this._bounds[i];
				Box2DXDebug.Assert((int)p.LowerBounds[i] < 2 * this._proxyCount);
				Box2DXDebug.Assert((int)p.UpperBounds[i] < 2 * this._proxyCount);
				if (b.LowerValues[i] > array[(int)p.UpperBounds[i]].Value)
				{
					result = false;
				}
				else
				{
					if (b.UpperValues[i] >= array[(int)p.LowerBounds[i]].Value)
					{
						i++;
						continue;
					}
					result = false;
				}
				return result;
			}
			result = true;
			return result;
		}
		private void Query(out int lowerQueryOut, out int upperQueryOut, ushort lowerValue, ushort upperValue, Bound[] bounds, int boundCount, int axis)
		{
			int num = BroadPhase.BinarySearch(bounds, boundCount, lowerValue);
			int num2 = BroadPhase.BinarySearch(bounds, boundCount, upperValue);
			for (int i = num; i < num2; i++)
			{
				if (bounds[i].IsLower)
				{
					this.IncrementOverlapCount((int)bounds[i].ProxyId);
				}
			}
			if (num > 0)
			{
				int i = num - 1;
				int num3 = (int)bounds[i].StabbingCount;
				while (num3 != 0)
				{
					Box2DXDebug.Assert(i >= 0);
					if (bounds[i].IsLower)
					{
						Proxy proxy = this._proxyPool[(int)bounds[i].ProxyId];
						if (num <= (int)proxy.UpperBounds[axis])
						{
							this.IncrementOverlapCount((int)bounds[i].ProxyId);
							num3--;
						}
					}
					i--;
				}
			}
			lowerQueryOut = num;
			upperQueryOut = num2;
		}
		private void IncrementOverlapCount(int proxyId)
		{
			Proxy proxy = this._proxyPool[proxyId];
			if (proxy.TimeStamp < this._timeStamp)
			{
				proxy.TimeStamp = this._timeStamp;
				proxy.OverlapCount = 1;
				this.qi1++;
			}
			else
			{
				proxy.OverlapCount = 2;
				Box2DXDebug.Assert(this._queryResultCount < Settings.MaxProxies);
				this._queryResults[this._queryResultCount] = (ushort)proxyId;
				this._queryResultCount++;
				this.qi2++;
			}
		}
		private void IncrementTimeStamp()
		{
			if (this._timeStamp == BroadPhase.BROADPHASE_MAX)
			{
				ushort num = 0;
				while ((int)num < Settings.MaxProxies)
				{
					this._proxyPool[(int)num].TimeStamp = 0;
					num += 1;
				}
				this._timeStamp = 1;
			}
			else
			{
				this._timeStamp += 1;
			}
		}
		public unsafe void AddProxyResult(ushort proxyId, Proxy proxy, int maxCount, SortKeyFunc sortKey)
		{
			float num = sortKey(proxy.UserData);
			if (num >= 0f)
			{
				fixed (float* ptr = this._querySortKeys)
				{
					float* ptr2 = ptr;
					while (*ptr2 < num && ptr2 < ptr + this._queryResultCount)
					{
						ptr2 += 4 / 4;
					}
                    int num2 = ((int)ptr2 - ((int)ptr) / 4) / 4;
					if (maxCount != this._queryResultCount || num2 != this._queryResultCount)
					{
						if (maxCount == this._queryResultCount)
						{
							this._queryResultCount--;
						}
						for (int i = this._queryResultCount + 1; i > num2; i--)
						{
							this._querySortKeys[i] = this._querySortKeys[i - 1];
							this._queryResults[i] = this._queryResults[i - 1];
						}
						this._querySortKeys[num2] = num;
						this._queryResults[num2] = proxyId;
						this._queryResultCount++;
                        //ptr = null;
					}
				}
			}
		}
		private static int BinarySearch(Bound[] bounds, int count, ushort value)
		{
			int num = 0;
			int num2 = count - 1;
			int result;
			while (num <= num2)
			{
				int num3 = num + num2 >> 1;
				if (bounds[num3].Value > value)
				{
					num2 = num3 - 1;
				}
				else
				{
					if (bounds[num3].Value >= value)
					{
						result = (int)((ushort)num3);
						return result;
					}
					num = num3 + 1;
				}
			}
			result = num;
			return result;
		}
	}
}
