using System;
namespace Box2DX.Common
{
	public struct Sweep
	{
		public Vec2 LocalCenter;
		public Vec2 C0;
		public Vec2 C;
		public float A0;
		public float A;
		public float T0;
		public void GetXForm(out XForm xf, float t)
		{
			xf = default(XForm);
			if (1f - this.T0 > Math.FLOAT32_EPSILON)
			{
				float num = (t - this.T0) / (1f - this.T0);
				xf.Position = (1f - num) * this.C0 + num * this.C;
				float angle = (1f - num) * this.A0 + num * this.A;
				xf.R.Set(angle);
			}
			else
			{
				xf.Position = this.C;
				xf.R.Set(this.A);
			}
			xf.Position -= Math.Mul(xf.R, this.LocalCenter);
		}
		public void Advance(float t)
		{
			if (this.T0 < t && 1f - this.T0 > Math.FLOAT32_EPSILON)
			{
				float num = (t - this.T0) / (1f - this.T0);
				this.C0 = (1f - num) * this.C0 + num * this.C;
				this.A0 = (1f - num) * this.A0 + num * this.A;
				this.T0 = t;
			}
		}
	}
}
