using System;
using System.Runtime.InteropServices;
namespace Box2DX.Collision
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ContactID
	{
		[FieldOffset(0)]
		public Features Features;
		[FieldOffset(0)]
		public uint Key;
	}
}
