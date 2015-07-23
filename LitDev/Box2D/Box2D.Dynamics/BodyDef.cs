using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class BodyDef
	{
		public MassData MassData;
		public object UserData;
		public Vec2 Position;
		public float Angle;
		public float LinearDamping;
		public float AngularDamping;
		public bool AllowSleep;
		public bool IsSleeping;
		public bool FixedRotation;
		public bool IsBullet;
		public BodyDef()
		{
			this.MassData = default(MassData);
			this.MassData.Center.SetZero();
			this.MassData.Mass = 0f;
			this.MassData.I = 0f;
			this.UserData = null;
			this.Position = default(Vec2);
			this.Position.Set(0f, 0f);
			this.Angle = 0f;
			this.LinearDamping = 0f;
			this.AngularDamping = 0f;
			this.AllowSleep = true;
			this.IsSleeping = false;
			this.FixedRotation = false;
			this.IsBullet = false;
		}
	}
}
