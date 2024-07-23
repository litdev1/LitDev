using System;
namespace Box2DX.Dynamics
{
	public abstract class ContactListener
	{
		public virtual void Add(ContactPoint point)
		{
		}
		public virtual void Persist(ContactPoint point)
		{
		}
		public virtual void Remove(ContactPoint point)
		{
		}
		public virtual void Result(ContactResult point)
		{
		}
	}
}
