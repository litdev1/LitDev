using System;
namespace Box2DX.Dynamics
{
	public struct TimeStep
	{
		public float Dt;
		public float Inv_Dt;
		public float DtRatio;
		public int VelocityIterations;
		public int PositionIterations;
		public bool WarmStarting;
	}
}
