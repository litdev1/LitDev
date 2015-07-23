using System;
namespace Box2DX.Collision
{
	public class ShapeDef
	{
		public ShapeType Type;
		public object UserData;
		public float Friction;
		public float Restitution;
		public float Density;
		public bool IsSensor;
		public FilterData Filter;
		public ShapeDef()
		{
			this.Type = ShapeType.UnknownShape;
			this.UserData = null;
			this.Friction = 0.2f;
			this.Restitution = 0f;
			this.Density = 0f;
			this.Filter.CategoryBits = 1;
			this.Filter.MaskBits = 65535;
			this.Filter.GroupIndex = 0;
			this.IsSensor = false;
		}
	}
}
