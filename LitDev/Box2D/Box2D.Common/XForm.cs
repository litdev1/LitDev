using System;
namespace Box2DX.Common
{
	public struct XForm
	{
		public Vec2 Position;
		public Mat22 R;
		public static XForm Identity
		{
			get
			{
				return new XForm(Vec2.Zero, Mat22.Identity);
			}
		}
		public XForm(Vec2 position, Mat22 rotation)
		{
			this.Position = position;
			this.R = rotation;
		}
		public void SetIdentity()
		{
			this.Position.SetZero();
			this.R.SetIdentity();
		}
	}
}
