using System;
namespace Box2DX.Common
{
	public class Settings
	{
		public static readonly float FLT_EPSILON = 1.1920929E-07f;
		public static readonly float FLT_MAX = 3.40282347E+38f;
		public static readonly float Pi = 3.14159274f;
		public static readonly int MaxManifoldPoints = 2;
        //public static readonly int MaxPolygonVertices = 8; // STEVE
        public static int MaxPolygonVertices = 8; // STEVE
        //public static readonly int MaxProxies = 512; // STEVE
        public static int MaxProxies = 1024; // STEVE
        //public static readonly int MaxPairs = 8 * Settings.MaxProxies;
        public static int MaxPairs = 8 * Settings.MaxProxies; // STEVE// STEVE
        public static readonly float LinearSlop = 0.005f;
		public static readonly float AngularSlop = 0.0111111114f * Settings.Pi;
		public static readonly float ToiSlop = 8f * Settings.LinearSlop;
		public static readonly int MaxTOIContactsPerIsland = 32;
		public static readonly int MaxTOIJointsPerIsland = 32;
        //public static readonly float VelocityThreshold = 1f; //STEVE
        public static float VelocityThreshold = 1f; //STEVE
        public static readonly float MaxLinearCorrection = 0.2f;
		public static readonly float MaxAngularCorrection = 0.0444444455f * Settings.Pi;
		public static readonly float MaxLinearVelocity = 200f;
		public static readonly float MaxLinearVelocitySquared = Settings.MaxLinearVelocity * Settings.MaxLinearVelocity;
		public static readonly float MaxAngularVelocity = 250f;
		public static readonly float MaxAngularVelocitySquared = Settings.MaxAngularVelocity * Settings.MaxAngularVelocity;
		public static readonly float ContactBaumgarte = 0.2f;
		public static readonly float TimeToSleep = 0.5f;
		public static readonly float LinearSleepTolerance = 0.01f;
		public static readonly float AngularSleepTolerance = 0.0111111114f;
		public static float FORCE_SCALE(float x)
		{
			return x;
		}
		public static float FORCE_INV_SCALE(float x)
		{
			return x;
		}
		public static float MixFriction(float friction1, float friction2)
		{
			return (float)System.Math.Sqrt((double)(friction1 * friction2));
		}
		public static float MixRestitution(float restitution1, float restitution2)
		{
			return (restitution1 > restitution2) ? restitution1 : restitution2;
		}
	}
}
