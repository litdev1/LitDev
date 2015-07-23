using System;
namespace Box2DX.Dynamics
{
	public class ContactEdge
	{
		public Body Other;
		public Contact Contact;
		public ContactEdge Prev;
		public ContactEdge Next;
	}
}
