using Box2DX.Common;
using Box2DX.Dynamics;
using System;
namespace Box2DX.Collision
{
	public abstract class Shape : IDisposable
	{
		protected ShapeType _type;
		internal Shape _next;
		internal Body _body;
		protected float _sweepRadius;
		protected float _density;
		protected float _friction;
		protected float _restitution;
		protected ushort _proxyId;
		protected bool _isSensor;
		protected FilterData _filter;
		protected object _userData;
        public float Density // STEVE
        {
            get
            {
                return this._density;
            }
        }
        public float Friction
		{
			get
			{
				return this._friction;
			}
			set
			{
				this._friction = value;
			}
		}
		public float Restitution
		{
			get
			{
				return this._restitution;
			}
			set
			{
				this._restitution = value;
			}
		}
		public bool IsSensor
		{
			get
			{
				return this._isSensor;
			}
		}
		public FilterData FilterData
		{
			get
			{
				return this._filter;
			}
			set
			{
				this._filter = value;
			}
		}
		public object UserData
		{
			get
			{
				return this._userData;
			}
			set
			{
				this._userData = value;
			}
		}
		public new ShapeType GetType()
		{
			return this._type;
		}
		public Shape GetNext()
		{
			return this._next;
		}
		public Body GetBody()
		{
			return this._body;
		}
		public float GetSweepRadius()
		{
			return this._sweepRadius;
		}
		protected Shape(ShapeDef def)
		{
			this._userData = def.UserData;
			this._friction = def.Friction;
			this._restitution = def.Restitution;
			this._density = def.Density;
			this._body = null;
			this._sweepRadius = 0f;
			this._next = null;
			this._proxyId = PairManager.NullProxy;
			this._filter = def.Filter;
			this._isSensor = def.IsSensor;
		}
		public abstract bool TestPoint(XForm xf, Vec2 p);
		public abstract SegmentCollide TestSegment(XForm xf, out float lambda, out Vec2 normal, Segment segment, float maxLambda);
		public abstract void ComputeAABB(out AABB aabb, XForm xf);
		public abstract void ComputeSweptAABB(out AABB aabb, XForm xf1, XForm xf2);
		public abstract void ComputeMass(out MassData massData);
		internal abstract void UpdateSweepRadius(Vec2 center);
		internal static Shape Create(ShapeDef def)
		{
			Shape result;
			switch (def.Type)
			{
				case ShapeType.CircleShape:
				{
					result = new CircleShape(def);
					break;
				}
				case ShapeType.PolygonShape:
				{
					result = new PolygonShape(def);
					break;
				}
				default:
				{
					Box2DXDebug.Assert(false);
					result = null;
					break;
				}
			}
			return result;
		}
		internal static void Destroy(Shape s)
		{
			switch (s.GetType())
			{
				case ShapeType.CircleShape:
				{
					if (s != null)
					{
						((IDisposable)s).Dispose();
					}
					s = null;
					break;
				}
				case ShapeType.PolygonShape:
				{
					if (s != null)
					{
						((IDisposable)s).Dispose();
					}
					s = null;
					break;
				}
				default:
				{
					Box2DXDebug.Assert(false);
					break;
				}
			}
		}
		internal void CreateProxy(BroadPhase broadPhase, XForm transform)
		{
			Box2DXDebug.Assert(this._proxyId == PairManager.NullProxy);
			AABB aabb;
			this.ComputeAABB(out aabb, transform);
			bool flag = broadPhase.InRange(aabb);
			Box2DXDebug.Assert(flag);
			if (flag)
			{
				this._proxyId = broadPhase.CreateProxy(aabb, this);
			}
			else
			{
				this._proxyId = PairManager.NullProxy;
			}
		}
		internal void DestroyProxy(BroadPhase broadPhase)
		{
			if (this._proxyId != PairManager.NullProxy)
			{
				broadPhase.DestroyProxy((int)this._proxyId);
				this._proxyId = PairManager.NullProxy;
			}
		}
		internal bool Synchronize(BroadPhase broadPhase, XForm transform1, XForm transform2)
		{
			bool result;
			if (this._proxyId == PairManager.NullProxy)
			{
				result = false;
			}
			else
			{
				AABB aabb;
				this.ComputeSweptAABB(out aabb, transform1, transform2);
				if (broadPhase.InRange(aabb))
				{
					broadPhase.MoveProxy((int)this._proxyId, aabb);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}
		internal void RefilterProxy(BroadPhase broadPhase, XForm transform)
		{
			if (this._proxyId != PairManager.NullProxy)
			{
				broadPhase.DestroyProxy((int)this._proxyId);
				AABB aabb;
				this.ComputeAABB(out aabb, transform);
				bool flag = broadPhase.InRange(aabb);
				if (flag)
				{
					this._proxyId = broadPhase.CreateProxy(aabb, this);
				}
				else
				{
					this._proxyId = PairManager.NullProxy;
				}
			}
		}
        public void Dispose()
		{
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                Box2DXDebug.Assert(this._proxyId == PairManager.NullProxy);
            }
            // free native resources if there are any.
        }
    }
}
