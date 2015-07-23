using Box2DX.Collision;
using System;
namespace Box2DX.Dynamics
{
	public class ContactFilter
	{
		public virtual bool ShouldCollide(Shape shape1, Shape shape2)
		{
			FilterData filterData = shape1.FilterData;
			FilterData filterData2 = shape2.FilterData;
			bool result;
			if (filterData.GroupIndex == filterData2.GroupIndex && filterData.GroupIndex != 0)
			{
				result = (filterData.GroupIndex > 0);
			}
			else
			{
				bool flag = (filterData.MaskBits & filterData2.CategoryBits) != 0 && (filterData.CategoryBits & filterData2.MaskBits) != 0;
				result = flag;
			}
			return result;
		}
		public bool RayCollide(object userData, Shape shape)
		{
			return userData == null || this.ShouldCollide((Shape)userData, shape);
		}
	}
}
