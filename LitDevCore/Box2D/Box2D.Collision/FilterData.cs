using System;
namespace Box2DX.Collision
{
	public struct FilterData
	{
		public ushort CategoryBits;
		public ushort MaskBits;
		public short GroupIndex;
	}
}
