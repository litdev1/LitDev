using Box2DX.Collision;
using Box2DX.Common;
using System;
namespace Box2DX.Dynamics
{
	public class Island : IDisposable
	{
		public ContactListener _listener;
		public Body[] _bodies;
		public Contact[] _contacts;
		public Joint[] _joints;
		public Position[] _positions;
		public Velocity[] _velocities;
		public int _bodyCount;
		public int _jointCount;
		public int _contactCount;
		public int _bodyCapacity;
		public int _contactCapacity;
		public int _jointCapacity;
		public int _positionIterationCount;
		public Island(int bodyCapacity, int contactCapacity, int jointCapacity, ContactListener listener)
		{
			this._bodyCapacity = bodyCapacity;
			this._contactCapacity = contactCapacity;
			this._jointCapacity = jointCapacity;
			this._bodyCount = 0;
			this._contactCount = 0;
			this._jointCount = 0;
			this._listener = listener;
			this._bodies = new Body[bodyCapacity];
			this._contacts = new Contact[contactCapacity];
			this._joints = new Joint[jointCapacity];
			this._velocities = new Velocity[this._bodyCapacity];
			this._positions = new Position[this._bodyCapacity];
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
                this._positions = null;
                this._velocities = null;
                this._joints = null;
                this._contacts = null;
                this._bodies = null;
            }
            // free native resources if there are any.
        }
        public void Clear()
		{
			this._bodyCount = 0;
			this._contactCount = 0;
			this._jointCount = 0;
		}
		public void Solve(TimeStep step, Vec2 gravity, bool allowSleep)
		{
			for (int i = 0; i < this._bodyCount; i++)
			{
				Body body = this._bodies[i];
				if (!body.IsStatic())
				{
					Body expr_27 = body;
                    //expr_27._linearVelocity += step.Dt * (gravity + body._invMass * body._force);
                    expr_27._linearVelocity += step.Dt * (body._useGravity ? body._gravity : gravity + body._invMass * body._force); //Steve body gravity
                    body._angularVelocity += step.Dt * body._invI * body._torque;
					body._force.Set(0f, 0f);
					body._torque = 0f;
					Body expr_9E = body;
					expr_9E._linearVelocity *= Box2DX.Common.Math.Clamp(1f - step.Dt * body._linearDamping, 0f, 1f);
					body._angularVelocity *= Box2DX.Common.Math.Clamp(1f - step.Dt * body._angularDamping, 0f, 1f);
					if (Vec2.Dot(body._linearVelocity, body._linearVelocity) > Settings.MaxLinearVelocitySquared)
					{
						body._linearVelocity.Normalize();
						Body expr_130 = body;
						expr_130._linearVelocity *= Settings.MaxLinearVelocity;
					}
					if (body._angularVelocity * body._angularVelocity > Settings.MaxAngularVelocitySquared)
					{
						if (body._angularVelocity < 0f)
						{
							body._angularVelocity = -Settings.MaxAngularVelocity;
						}
						else
						{
							body._angularVelocity = Settings.MaxAngularVelocity;
						}
					}
				}
			}
			ContactSolver contactSolver = new ContactSolver(step, this._contacts, this._contactCount);
			contactSolver.InitVelocityConstraints(step);
			for (int i = 0; i < this._jointCount; i++)
			{
				this._joints[i].InitVelocityConstraints(step);
			}
			for (int i = 0; i < step.VelocityIterations; i++)
			{
				for (int j = 0; j < this._jointCount; j++)
				{
					this._joints[j].SolveVelocityConstraints(step);
				}
				contactSolver.SolveVelocityConstraints();
			}
			contactSolver.FinalizeVelocityConstraints();
			for (int i = 0; i < this._bodyCount; i++)
			{
				Body body = this._bodies[i];
				if (!body.IsStatic())
				{
					body._sweep.C0 = body._sweep.C;
					body._sweep.A0 = body._sweep.A;
					Body expr_296_cp_0 = body;
					expr_296_cp_0._sweep.C = expr_296_cp_0._sweep.C + step.Dt * body._linearVelocity;
					Body expr_2BE_cp_0 = body;
					expr_2BE_cp_0._sweep.A = expr_2BE_cp_0._sweep.A + step.Dt * body._angularVelocity;
					body.SynchronizeTransform();
				}
			}
			for (int k = 0; k < step.PositionIterations; k++)
			{
				bool flag = contactSolver.SolvePositionConstraints(Settings.ContactBaumgarte);
				bool flag2 = true;
				for (int i = 0; i < this._jointCount; i++)
				{
					bool flag3 = this._joints[i].SolvePositionConstraints(Settings.ContactBaumgarte);
					flag2 = (flag2 && flag3);
				}
				if (flag && flag2)
				{
					break;
				}
			}
			this.Report(contactSolver._constraints);
			if (allowSleep)
			{
				float num = Settings.FLT_MAX;
				float num2 = Settings.LinearSleepTolerance * Settings.LinearSleepTolerance;
				float num3 = Settings.AngularSleepTolerance * Settings.AngularSleepTolerance;
				for (int i = 0; i < this._bodyCount; i++)
				{
					Body body = this._bodies[i];
					if (body._invMass != 0f)
					{
						if ((body._flags & Body.BodyFlags.AllowSleep) == (Body.BodyFlags)0)
						{
							body._sleepTime = 0f;
							num = 0f;
						}
						if ((body._flags & Body.BodyFlags.AllowSleep) == (Body.BodyFlags)0 || body._angularVelocity * body._angularVelocity > num3 || Vec2.Dot(body._linearVelocity, body._linearVelocity) > num2)
						{
							body._sleepTime = 0f;
							num = 0f;
						}
						else
						{
							body._sleepTime += step.Dt;
							num = Box2DX.Common.Math.Min(num, body._sleepTime);
						}
					}
				}
				if (num >= Settings.TimeToSleep)
				{
					for (int i = 0; i < this._bodyCount; i++)
					{
						Body body = this._bodies[i];
						body._flags |= Body.BodyFlags.Sleep;
						body._linearVelocity = Vec2.Zero;
						body._angularVelocity = 0f;
					}
				}
			}
		}
		public void SolveTOI(ref TimeStep subStep)
		{
			ContactSolver contactSolver = new ContactSolver(subStep, this._contacts, this._contactCount);
			for (int i = 0; i < subStep.VelocityIterations; i++)
			{
				contactSolver.SolveVelocityConstraints();
			}
			for (int i = 0; i < this._bodyCount; i++)
			{
				Body body = this._bodies[i];
				if (!body.IsStatic())
				{
					body._sweep.C0 = body._sweep.C;
					body._sweep.A0 = body._sweep.A;
					Body expr_8D_cp_0 = body;
					expr_8D_cp_0._sweep.C = expr_8D_cp_0._sweep.C + subStep.Dt * body._linearVelocity;
					Body expr_B4_cp_0 = body;
					expr_B4_cp_0._sweep.A = expr_B4_cp_0._sweep.A + subStep.Dt * body._angularVelocity;
					body.SynchronizeTransform();
				}
			}
			float baumgarte = 0.75f;
			for (int i = 0; i < subStep.PositionIterations; i++)
			{
				bool flag = contactSolver.SolvePositionConstraints(baumgarte);
				if (flag)
				{
					break;
				}
			}
			this.Report(contactSolver._constraints);
		}
		public void Add(Body body)
		{
			Box2DXDebug.Assert(this._bodyCount < this._bodyCapacity);
			body._islandIndex = this._bodyCount;
			this._bodies[this._bodyCount++] = body;
		}
		public void Add(Contact contact)
		{
			Box2DXDebug.Assert(this._contactCount < this._contactCapacity);
			this._contacts[this._contactCount++] = contact;
		}
		public void Add(Joint joint)
		{
			Box2DXDebug.Assert(this._jointCount < this._jointCapacity);
			this._joints[this._jointCount++] = joint;
		}
		public void Report(ContactConstraint[] constraints)
		{
			if (this._listener != null)
			{
				for (int i = 0; i < this._contactCount; i++)
				{
					Contact contact = this._contacts[i];
					ContactConstraint contactConstraint = constraints[i];
					ContactResult contactResult = new ContactResult();
					contactResult.Shape1 = contact.GetShape1();
					contactResult.Shape2 = contact.GetShape2();
					Body body = contactResult.Shape1.GetBody();
					int manifoldCount = contact.GetManifoldCount();
					Manifold[] manifolds = contact.GetManifolds();
					for (int j = 0; j < manifoldCount; j++)
					{
						Manifold manifold = manifolds[j];
						contactResult.Normal = manifold.Normal;
						for (int k = 0; k < manifold.PointCount; k++)
						{
							ManifoldPoint manifoldPoint = manifold.Points[k];
							ContactConstraintPoint contactConstraintPoint = contactConstraint.Points[k];
							contactResult.Position = body.GetWorldPoint(manifoldPoint.LocalPoint1);
							contactResult.NormalImpulse = contactConstraintPoint.NormalImpulse;
							contactResult.TangentImpulse = contactConstraintPoint.TangentImpulse;
							contactResult.ID = manifoldPoint.ID;
							this._listener.Result(contactResult);
						}
					}
				}
			}
		}
	}
}
