using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class ContactManager : PairCallback
	{
		public World _world;
		public NullContact _nullContact;
		public bool _destroyImmediate;
		public ContactManager()
		{
			this._world = null;
			this._destroyImmediate = false;
		}
		public override object PairAdded(object proxyUserData1, object proxyUserData2)
		{
			Shape shape = proxyUserData1 as Shape;
			Shape shape2 = proxyUserData2 as Shape;
			Body body = shape.GetBody();
			Body body2 = shape2.GetBody();
			object result;
			if (body.IsStatic() && body2.IsStatic())
			{
				result = this._nullContact;
			}
			else
			{
				if (shape.GetBody() == shape2.GetBody())
				{
					result = this._nullContact;
				}
				else
				{
					if (body2.IsConnected(body))
					{
						result = this._nullContact;
					}
					else
					{
						if (this._world._contactFilter != null && !this._world._contactFilter.ShouldCollide(shape, shape2))
						{
							result = this._nullContact;
						}
						else
						{
							Contact contact = Contact.Create(shape, shape2);
							if (contact == null)
							{
								result = this._nullContact;
							}
							else
							{
								shape = contact.GetShape1();
								shape2 = contact.GetShape2();
								body = shape.GetBody();
								body2 = shape2.GetBody();
								contact._prev = null;
								contact._next = this._world._contactList;
								if (this._world._contactList != null)
								{
									this._world._contactList._prev = contact;
								}
								this._world._contactList = contact;
								contact._node1.Contact = contact;
								contact._node1.Other = body2;
								contact._node1.Prev = null;
								contact._node1.Next = body._contactList;
								if (body._contactList != null)
								{
									body._contactList.Prev = contact._node1;
								}
								body._contactList = contact._node1;
								contact._node2.Contact = contact;
								contact._node2.Other = body;
								contact._node2.Prev = null;
								contact._node2.Next = body2._contactList;
								if (body2._contactList != null)
								{
									body2._contactList.Prev = contact._node2;
								}
								body2._contactList = contact._node2;
								this._world._contactCount++;
								result = contact;
							}
						}
					}
				}
			}
			return result;
		}
		public override void PairRemoved(object proxyUserData1, object proxyUserData2, object pairUserData)
		{
			if (pairUserData != null)
			{
				Contact contact = pairUserData as Contact;
				if (contact != this._nullContact)
				{
					this.Destroy(contact);
				}
			}
		}
		public void Destroy(Contact c)
		{
			Shape shape = c.GetShape1();
			Shape shape2 = c.GetShape2();
			Body body = shape.GetBody();
			Body body2 = shape2.GetBody();
			ContactPoint contactPoint = new ContactPoint();
			contactPoint.Shape1 = shape;
			contactPoint.Shape2 = shape2;
			contactPoint.Friction = Settings.MixFriction(shape.Friction, shape2.Friction);
			contactPoint.Restitution = Settings.MixRestitution(shape.Restitution, shape2.Restitution);
			int manifoldCount = c.GetManifoldCount();
			if (manifoldCount > 0 && this._world._contactListener != null)
			{
				Manifold[] manifolds = c.GetManifolds();
				for (int i = 0; i < manifoldCount; i++)
				{
					Manifold manifold = manifolds[i];
					contactPoint.Normal = manifold.Normal;
					for (int j = 0; j < manifold.PointCount; j++)
					{
						ManifoldPoint manifoldPoint = manifold.Points[j];
						contactPoint.Position = body.GetWorldPoint(manifoldPoint.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint = body.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint1);
						Vec2 linearVelocityFromLocalPoint2 = body2.GetLinearVelocityFromLocalPoint(manifoldPoint.LocalPoint2);
						contactPoint.Velocity = linearVelocityFromLocalPoint2 - linearVelocityFromLocalPoint;
						contactPoint.Separation = manifoldPoint.Separation;
						contactPoint.ID = manifoldPoint.ID;
						this._world._contactListener.Remove(contactPoint);
					}
				}
			}
			if (c._prev != null)
			{
				c._prev._next = c._next;
			}
			if (c._next != null)
			{
				c._next._prev = c._prev;
			}
			if (c == this._world._contactList)
			{
				this._world._contactList = c._next;
			}
			if (c._node1.Prev != null)
			{
				c._node1.Prev.Next = c._node1.Next;
			}
			if (c._node1.Next != null)
			{
				c._node1.Next.Prev = c._node1.Prev;
			}
			if (c._node1 == body._contactList)
			{
				body._contactList = c._node1.Next;
			}
			if (c._node2.Prev != null)
			{
				c._node2.Prev.Next = c._node2.Next;
			}
			if (c._node2.Next != null)
			{
				c._node2.Next.Prev = c._node2.Prev;
			}
			if (c._node2 == body2._contactList)
			{
				body2._contactList = c._node2.Next;
			}
			Contact.Destroy(c);
			this._world._contactCount--;
		}
		public void Collide()
		{
			for (Contact contact = this._world._contactList; contact != null; contact = contact.GetNext())
			{
				Body body = contact.GetShape1().GetBody();
				Body body2 = contact.GetShape2().GetBody();
				if (!body.IsSleeping() || !body2.IsSleeping())
				{
					contact.Update(this._world._contactListener);
				}
			}
		}
	}
}
