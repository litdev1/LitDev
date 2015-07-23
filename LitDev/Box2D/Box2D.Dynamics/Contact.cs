using Box2DX.Collision;
using System;
namespace Box2DX.Dynamics
{
	public abstract class Contact
	{
		[Flags]
		public enum CollisionFlags
		{
			NonSolid = 1,
			Slow = 2,
			Island = 4,
			Toi = 8
		}
		public static ContactRegister[][] s_registers = new ContactRegister[2][];
		public static bool s_initialized = false;
		public Contact.CollisionFlags _flags;
		public int _manifoldCount;
		public Contact _prev;
		public Contact _next;
		public ContactEdge _node1;
		public ContactEdge _node2;
		public Shape _shape1;
		public Shape _shape2;
		public float _toi;
		public Contact()
		{
			this._shape1 = null;
			this._shape2 = null;
		}
		public Contact(Shape s1, Shape s2)
		{
			this._flags = (Contact.CollisionFlags)0;
			if (s1.IsSensor || s2.IsSensor)
			{
				this._flags |= Contact.CollisionFlags.NonSolid;
			}
			this._shape1 = s1;
			this._shape2 = s2;
			this._manifoldCount = 0;
			this._prev = null;
			this._next = null;
			this._node1 = new ContactEdge();
			this._node1.Contact = null;
			this._node1.Prev = null;
			this._node1.Next = null;
			this._node1.Other = null;
			this._node2 = new ContactEdge();
			this._node2.Contact = null;
			this._node2.Prev = null;
			this._node2.Next = null;
			this._node2.Other = null;
		}
		public static void AddType(ContactCreateFcn createFcn, ContactDestroyFcn destoryFcn, ShapeType type1, ShapeType type2)
		{
			Box2DXDebug.Assert(ShapeType.UnknownShape < type1 && type1 < ShapeType.ShapeTypeCount);
			Box2DXDebug.Assert(ShapeType.UnknownShape < type2 && type2 < ShapeType.ShapeTypeCount);
			if (Contact.s_registers[(int)type1] == null)
			{
				Contact.s_registers[(int)type1] = new ContactRegister[2];
			}
			Contact.s_registers[(int)type1][(int)type2].CreateFcn = createFcn;
			Contact.s_registers[(int)type1][(int)type2].DestroyFcn = destoryFcn;
			Contact.s_registers[(int)type1][(int)type2].Primary = true;
			if (type1 != type2)
			{
				Contact.s_registers[(int)type2][(int)type1].CreateFcn = createFcn;
				Contact.s_registers[(int)type2][(int)type1].DestroyFcn = destoryFcn;
				Contact.s_registers[(int)type2][(int)type1].Primary = false;
			}
		}
		public static void InitializeRegisters()
		{
			Contact.AddType(new ContactCreateFcn(CircleContact.Create), new ContactDestroyFcn(CircleContact.Destroy), ShapeType.CircleShape, ShapeType.CircleShape);
			Contact.AddType(new ContactCreateFcn(PolyAndCircleContact.Create), new ContactDestroyFcn(PolyAndCircleContact.Destroy), ShapeType.PolygonShape, ShapeType.CircleShape);
			Contact.AddType(new ContactCreateFcn(PolygonContact.Create), new ContactDestroyFcn(PolygonContact.Destroy), ShapeType.PolygonShape, ShapeType.PolygonShape);
		}
		public static Contact Create(Shape shape1, Shape shape2)
		{
			if (!Contact.s_initialized)
			{
				Contact.InitializeRegisters();
				Contact.s_initialized = true;
			}
			ShapeType type = shape1.GetType();
			ShapeType type2 = shape2.GetType();
			Box2DXDebug.Assert(ShapeType.UnknownShape < type && type < ShapeType.ShapeTypeCount);
			Box2DXDebug.Assert(ShapeType.UnknownShape < type2 && type2 < ShapeType.ShapeTypeCount);
			ContactCreateFcn createFcn = Contact.s_registers[(int)type][(int)type2].CreateFcn;
			Contact result;
			if (createFcn != null)
			{
				if (Contact.s_registers[(int)type][(int)type2].Primary)
				{
					result = createFcn(shape1, shape2);
				}
				else
				{
					Contact contact = createFcn(shape2, shape1);
					for (int i = 0; i < contact.GetManifoldCount(); i++)
					{
						Manifold manifold = contact.GetManifolds()[i];
						manifold.Normal = -manifold.Normal;
					}
					result = contact;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}
		public static void Destroy(Contact contact)
		{
			Box2DXDebug.Assert(Contact.s_initialized);
			if (contact.GetManifoldCount() > 0)
			{
				contact.GetShape1().GetBody().WakeUp();
				contact.GetShape2().GetBody().WakeUp();
			}
			ShapeType type = contact.GetShape1().GetType();
			ShapeType type2 = contact.GetShape2().GetType();
			Box2DXDebug.Assert(ShapeType.UnknownShape < type && type < ShapeType.ShapeTypeCount);
			Box2DXDebug.Assert(ShapeType.UnknownShape < type2 && type2 < ShapeType.ShapeTypeCount);
			ContactDestroyFcn destroyFcn = Contact.s_registers[(int)type][(int)type2].DestroyFcn;
			destroyFcn(contact);
		}
		public abstract Manifold[] GetManifolds();
		public int GetManifoldCount()
		{
			return this._manifoldCount;
		}
		public bool IsSolid()
		{
			return (this._flags & Contact.CollisionFlags.NonSolid) == (Contact.CollisionFlags)0;
		}
		public Contact GetNext()
		{
			return this._next;
		}
		public Shape GetShape1()
		{
			return this._shape1;
		}
		public Shape GetShape2()
		{
			return this._shape2;
		}
		public void Update(ContactListener listener)
		{
			int manifoldCount = this.GetManifoldCount();
			this.Evaluate(listener);
			int manifoldCount2 = this.GetManifoldCount();
			Body body = this._shape1.GetBody();
			Body body2 = this._shape2.GetBody();
			if (manifoldCount2 == 0 && manifoldCount > 0)
			{
				body.WakeUp();
				body2.WakeUp();
			}
			if (body.IsStatic() || body.IsBullet() || body2.IsStatic() || body2.IsBullet())
			{
				this._flags &= ~Contact.CollisionFlags.Slow;
			}
			else
			{
				this._flags |= Contact.CollisionFlags.Slow;
			}
		}
		public abstract void Evaluate(ContactListener listener);
	}
}
