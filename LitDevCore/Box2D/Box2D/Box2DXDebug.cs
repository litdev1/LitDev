using System;
using System.Diagnostics;
namespace Box2DX
{
	public static class Box2DXDebug
	{
		[Conditional("DEBUG")]
		public static void Assert(bool condition)
		{
			Debug.Assert(condition);
		}
		[Conditional("DEBUG")]
		public static void Assert(bool condition, string message)
		{
			Debug.Assert(condition, message);
		}
		[Conditional("DEBUG")]
		public static void Assert(bool condition, string message, string detailMessage)
		{
			Debug.Assert(condition, message, detailMessage);
		}
		public static void ThrowBox2DXException(string message)
		{
			string message2 = string.Format("Error: {0}", message);
			throw new Exception(message2);
		}
	}
}
