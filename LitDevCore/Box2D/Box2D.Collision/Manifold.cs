using Box2DX.Common;
using System;
namespace Box2DX.Collision
{
	public class Manifold
	{
		public ManifoldPoint[] Points = new ManifoldPoint[Settings.MaxManifoldPoints];
		public Vec2 Normal;
		public int PointCount;
		public Manifold()
		{
			for (int i = 0; i < Settings.MaxManifoldPoints; i++)
			{
				this.Points[i] = new ManifoldPoint();
			}
		}
		public Manifold Clone()
		{
			Manifold manifold = new Manifold();
			manifold.Normal = this.Normal;
			manifold.PointCount = this.PointCount;
			int num = this.Points.Length;
			ManifoldPoint[] array = new ManifoldPoint[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.Points[i].Clone();
			}
			manifold.Points = array;
			return manifold;
		}
	}
}
