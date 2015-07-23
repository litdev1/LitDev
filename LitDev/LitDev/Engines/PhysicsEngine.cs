//The following Copyright applies to Box2D and files in its namespace.

//Copyright (c) 2006-2007 Erin Catto http://www.gphysics.com

//This software is provided 'as-is', without any express or implied
//warranty. In no event will the authors be held liable for any damages
//arising from the use of this software.

//Permission is granted to anyone to use this software for any purpose,
//including commercial applications, and to alter it and redistribute it
//freely, subject to the following restrictions:

//1. The origin of this software must not be misrepresented; you must not
//claim that you wrote the original software. If you use this software
//in a product, an acknowledgment in the product documentation would be
//appreciated but is not required.
//2. Altered source versions must be plainly marked as such, and must not be
//misrepresented as being the original software.
//3. This notice may not be removed or altered from any source distribution.

//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

using Box2DX.Collision;
using Box2DX.Common;
using Box2DX.Dynamics;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace LitDev
{
    enum spriteType { FIXED, MOVING, INACTIVE }
    enum joinType { DISTANCE, GEAR, LINE, MOUSE, PRISMATIC_H, PRISMATIC_V, PULLEY, REVOLUTE }

    class Weld
    {
        // Private
        private World world;

        //Public
        public bool bRotate;
        public Joint jd1;
        public Joint jd2;
        public Body body1;
        public Body body2;

        public Weld(World _world)
        {
            bRotate = false;
            world = _world;
            jd1 = null;
            jd2 = null;
            body1 = null;
            body2 = null;
        }
    }

    class Tire
    {
        //Based heavily on http://www.iforce2d.net/b2dtut/top-down-car
        public Sprite sprite;
        private Body tire;

        public Dictionary<string, float> Information = new Dictionary<string, float>();
        public Dictionary<string, float> Properties = new Dictionary<string, float>();

        public Tire(Sprite _sprite)
        {
            sprite = _sprite;
            tire = sprite.body;
            Information.Clear();
            Properties.Clear();
            Properties.Add("AntiSkid", 3);
            Properties.Add("Drag", 0.05f);
            Properties.Add("Brake", 2);
            Properties.Add("Straighten", 0.5f);
            Properties.Add("BrakeStraighten", 2);
        }

        private Vec2 getLateralVelocity()
        {
            Vec2 currentRightNormal = tire.GetWorldVector(new Vec2(1, 0));
            return Vec2.Dot(currentRightNormal, tire.GetLinearVelocity()) * currentRightNormal;
        }

        private Vec2 getForwardVelocity()
        {
            Vec2 currentForwardNormal = tire.GetWorldVector(new Vec2(0, -1)); //Up is forward
            return Vec2.Dot(currentForwardNormal, tire.GetLinearVelocity()) * currentForwardNormal;
        }

        public void updateFriction()
        {
            // Remove skid, leave some
            Vec2 impulse = -tire.GetMass() * getLateralVelocity();
            Information["Skid"] = impulse.Length();
            if (impulse.Length() > Properties["AntiSkid"]) impulse *= Properties["AntiSkid"] / impulse.Length();
            tire.ApplyImpulse(impulse, tire.GetWorldCenter());

            // Straighten stearing
            tire.ApplyTorque(-Properties["Straighten"] * tire.GetInertia() * tire.GetAngularVelocity());

            // Apply drag
            Vec2 currentForwardNormal = getForwardVelocity();
            float currentForwardSpeed = currentForwardNormal.Normalize();
            float dragForceMagnitude = -Properties["Drag"] * currentForwardSpeed * tire.GetMass();
            tire.ApplyForce(dragForceMagnitude * currentForwardNormal, tire.GetWorldCenter());
        }

        public void updateDrive(float force)
        {
            Vec2 currentForwardNormal = tire.GetWorldVector(new Vec2(0, -1)); //Up is forward
            tire.ApplyForce(force * currentForwardNormal, tire.GetWorldCenter());
        }

        public void brake()
        {
            Vec2 currentForwardNormal = getForwardVelocity();
            float currentForwardSpeed = currentForwardNormal.Normalize();
            float dragForceMagnitude = -Properties["Brake"] * currentForwardSpeed * tire.GetMass();
            tire.ApplyForce(dragForceMagnitude * currentForwardNormal, tire.GetWorldCenter());

            tire.ApplyTorque(-Properties["BrakeStraighten"] * tire.GetInertia() * tire.GetAngularVelocity());
        }

        public void updateTurn(float torque)
        {
            Vec2 currentForwardDirection = tire.GetWorldVector(new Vec2(0, -1)); //Up is forward
            float direction = Vec2.Dot(currentForwardDirection, tire.GetLinearVelocity());
            if (direction == 0) direction = 1;
            tire.ApplyTorque(torque * System.Math.Sign(direction));
        }
    }

    class Fragment
    {
        public Body body;
        public string shapeName;
        public Fragment(Body _body, string _shapeName)
        {
            body = _body;
            shapeName = _shapeName;
        }
    }

    class Explosion
    {
        //Based heavily on http://www.iforce2d.net/b2dtut/explosions
        private PhysicsEngine physicsEngine;
        private World world;
        public List<Fragment> fragments = new List<Fragment>();
        DateTime start = DateTime.Now;
        double delay = 1000;

        public Explosion(PhysicsEngine _physicsEngine, World _world, double _delay, int numRays, float mass, float damping, float posXS, float posYS, float powerS, float scale, string colour)
        {
            physicsEngine = _physicsEngine;
            world = _world;
            fragments.Clear();
            Random rand = new Random();
            start = DateTime.Now;
            delay = _delay;
            string oldBrushColor = GraphicsWindow.BrushColor;
            double oldPenWidth = GraphicsWindow.PenWidth;
            GraphicsWindow.BrushColor = colour;
            GraphicsWindow.PenWidth = 0;

            for (int i = 0; i < numRays; i++)
            {
                //float angle = (i / (float)numRays) * 2 * (float)System.Math.PI;
                float angle = (float)(rand.NextDouble() * 2 * System.Math.PI);
                Vec2 rayDir = new Vec2((float)System.Math.Sin(angle), (float)System.Math.Cos(angle));

                BodyDef bodyDef = new BodyDef();
                bodyDef.FixedRotation = true; // rotation not necessary
                bodyDef.LinearDamping = damping; // drag due to moving through air
                bodyDef.Position.Set((float)(posXS + 10 * rand.NextDouble() - 5) / scale, (float)(posYS + 10 * rand.NextDouble() - 5) / scale); // start at blast center - not all on top of each other

                Body body = world.CreateBody(bodyDef);

                CircleDef circleDef = new CircleDef();
                circleDef.Radius = 0.05f; // very small
                circleDef.Density = mass / ((float)System.Math.PI * circleDef.Radius * circleDef.Radius) / (float)numRays; // very high - shared across all particles
                circleDef.Friction = 0; // friction not necessary
                circleDef.Restitution = 0.99f; // high restitution to reflect off obstacles
                circleDef.Filter.GroupIndex = -1; // particles should not collide with each other

                Shape shape = body.CreateShape(circleDef);
                body.SetMassFromShapes();
                body.SetBullet(true);
                body.SetLinearVelocity(powerS / scale * rayDir);
                string shapeName = string.Empty;
                if (colour != "")
                {
                    shapeName = Shapes.AddEllipse(2, 2);
                    body.SetUserData(Sprite.GetUIElement(shapeName));
                }

                Fragment fragment = new Fragment(body, shapeName);
                fragments.Add(fragment);
                shape.UserData = fragment;
            }

            GraphicsWindow.BrushColor = oldBrushColor;
            GraphicsWindow.PenWidth = oldPenWidth;
        }

        public bool Update()
        {
            if (DateTime.Now - start > TimeSpan.FromMilliseconds(delay))
            {
                Delete();
                return false;
            }
            return true;
        }

        public void Delete()
        {
            foreach (Fragment fragment in fragments)
            {
                if (fragment.shapeName != string.Empty) Shapes.Remove(fragment.shapeName);
                world.DestroyBody(fragment.body);
            }
            fragments.Clear();
        }
    }

    class Sprite : IEquatable<Sprite>
    {
        // Private
        private PhysicsEngine physicsEngine;
        private World world;

        //Public
        public UIElement uiElement;
        public RotateTransform rotateTransform;
        public string name;
        public Body body;
        public PolygonDef polygonDef;
        public CircleDef circleDef;
        public float widthS, heightS;
        public List<string> Collisions = new List<string>();

        public Sprite(PhysicsEngine _physicsEngine, World _world)
        {
            physicsEngine = _physicsEngine;
            world = _world;
            reset();
        }

        public void reset()
        {
            uiElement = null;
            rotateTransform = null;
            name = "";
            body = null;
            polygonDef = null;
            circleDef = null;
            widthS = 0.0f;
            heightS = 0.0f;
            Collisions.Clear();
        }

        public bool Add(string shapeName, float posXP, float posYP, float sizeXP, float sizeYP, float angleP, float friction, float restitution, float density, spriteType eType, bool bImageCircle, float scale)
        {
            uiElement = GetUIElement(shapeName);
            rotateTransform = GetRotateTransform(shapeName);
            name = shapeName;

            BodyDef bodyDef = new BodyDef();
            bodyDef.Position.Set(posXP, posYP);
            bodyDef.Angle = angleP;
            body = world.CreateBody(bodyDef);
            widthS = scale * sizeXP;
            heightS = scale * sizeYP;

            Shape spriteShape;

            if (eType == spriteType.MOVING && restitution < 0)
            {
                sizeXP = 0.001f;
                sizeYP = 0.001f;
            }

            if (uiElement.GetType() == typeof(System.Windows.Shapes.Ellipse) || ((uiElement.GetType() == typeof(System.Windows.Controls.Image)) && bImageCircle))
            {
                circleDef = new CircleDef();
                circleDef.Radius = (float)System.Math.Sqrt((sizeXP * sizeXP + sizeYP * sizeYP) / 2.0);
                circleDef.Density = (density > 0) ? density : 1.0f;
                circleDef.Friction = (friction >= 0) ? friction : 0.3f;
                circleDef.Restitution = (restitution >= 0) ? restitution : 0.5f;
                spriteShape = body.CreateShape(circleDef);
                spriteShape.UserData = this;
                if (eType == spriteType.MOVING) body.SetMassFromShapes();
                return true;
            }
            else if (uiElement.GetType() == typeof(System.Windows.Shapes.Polygon))
            {
                PointCollection coords = polygonCoords(shapeName);

                polygonDef = new PolygonDef();
                polygonDef.VertexCount = coords.Count;
                for (int i = 0; i < coords.Count; i++)
                {
                    polygonDef.Vertices[i].Set((float)(coords[i].X - widthS) / scale, (float)(coords[i].Y - heightS) / scale);
                }
                polygonDef.Density = (density > 0) ? density : 1.0f;
                polygonDef.Friction = (friction >= 0) ? friction : 0.3f;
                polygonDef.Restitution = (restitution >= 0) ? restitution : 0.5f;
                spriteShape = body.CreateShape(polygonDef);
                spriteShape.UserData = this;
                if (eType == spriteType.MOVING) body.SetMassFromShapes();
                if (eType == spriteType.MOVING && body.GetMass() < 0) //quirk of mass generation - reverse the order
                {
                    body.DestroyShape(spriteShape);

                    for (int i = 0; i < coords.Count; i++)
                    {
                        polygonDef.Vertices[coords.Count - 1 - i].Set((float)(coords[i].X - widthS) / scale, (float)(coords[i].Y - heightS) / scale);
                    }

                    spriteShape = body.CreateShape(polygonDef);
                    spriteShape.UserData = this;
                    body.SetMassFromShapes();
                }
                return true;
            }
            //else if (shapeName.Contains("Rectangle") || (shapeName.Contains("Image") && !bImageCircle) || shapeName.Contains("Text") || shapeName.Contains("TextBox") || shapeName.Contains("Button"))
            else if (uiElement.GetType() != typeof(System.Windows.Shapes.Line))
            {
                polygonDef = new PolygonDef();
                polygonDef.SetAsBox(sizeXP, sizeYP);
                polygonDef.Density = (density > 0) ? density : 1.0f;
                polygonDef.Friction = (friction >= 0) ? friction : 0.3f;
                polygonDef.Restitution = (restitution >= 0) ? restitution : 0.5f;
                spriteShape = body.CreateShape(polygonDef);
                spriteShape.UserData = this;
                if (eType == spriteType.MOVING) body.SetMassFromShapes();
                return true;
            }

            world.DestroyBody(body);
            return false;
        }

        public static UIElement GetUIElement(string shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap.TryGetValue((string)shapeName, out obj);
                return obj;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return null;
        }

        public static RotateTransform GetRotateTransform(string shapeName)
        {
            Shapes.Rotate(shapeName, 0);
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue(shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return null;
                }
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        foreach (Transform transform in ((TransformGroup)obj.RenderTransform).Children)
                        {
                            if (transform.GetType() == typeof(RotateTransform))
                            {
                                return (RotateTransform)transform;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return null;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return (RotateTransform)method.Invoke(null, new object[] { ret });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return null;
        }

        public bool Equals(Sprite other)
        {
            if (this.name == other.name)
                return true;
            else
                return false;
        }

        public PointCollection polygonCoords(string shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Type ShapesType = typeof(Shapes);
            Dictionary<string, RotateTransform> _rotateTransformMap;
		    RotateTransform rotateTransform;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return null;
                }
                _rotateTransformMap = (Dictionary<string, RotateTransform>)ShapesType.GetField("_rotateTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_rotateTransformMap.TryGetValue((string)shapeName, out rotateTransform))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return null;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        System.Windows.Shapes.Polygon shape = (System.Windows.Shapes.Polygon)obj;

                        // Centre of mass for polygon
                        double Area = 0.0, part;
                        Point centre = new Point(0.0, 0.0);
                        int i, j;
                        for (i = 0; i < shape.Points.Count(); i++)
                        {
                            j = i == shape.Points.Count() - 1 ? 0 : i + 1;
                            part = shape.Points[i].X * shape.Points[j].Y - shape.Points[j].X * shape.Points[i].Y;
                            Area += part / 2.0;
                            centre.X += part * (shape.Points[i].X + shape.Points[j].X);
                            centre.Y += part * (shape.Points[i].Y + shape.Points[j].Y);
                        }
                        centre.X /= (6.0 * Area);
                        centre.Y /= (6.0 * Area);
                        rotateTransform.CenterX = centre.X;
                        rotateTransform.CenterY = centre.Y;
                        widthS = (float)centre.X;
                        heightS = (float)centre.Y;

                        return shape.Points;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return null;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return (PointCollection) method.Invoke(null, new object[] { ret });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return null;
            }
        }
    }

    class InactiveShape : IEquatable<InactiveShape>
    {
        //Public
        public UIElement uiElement;
        public RotateTransform rotateTransform;
        public string name;
        public float widthS;
        public float heightS;
        public float posXS;
        public float posYS;
        public float angleS;

        public InactiveShape()
        {
            reset();
        }

        public void reset()
        {
            uiElement = null;
            rotateTransform = null;
            name = "";
            widthS = 0.0f;
            heightS = 0.0f;
            posXS = 0.0f;
            posYS = 0.0f;
            angleS = 0.0f;
        }

        public bool Add(string shapeName)
        {
            uiElement = Sprite.GetUIElement(shapeName);
            rotateTransform = Sprite.GetRotateTransform(shapeName);

            name = shapeName;
            return true;
        }

        public bool Equals(InactiveShape other)
        {
            if (this.name == other.name)
                return true;
            else
                return false;
        }
    }

    class Chain : IEquatable<Chain>
    {
        // Private
        private PhysicsEngine physicsEngine;
        private World world;

        //Public
        public string name;
        public Sprite sprite1;
        public Sprite sprite2;
        public List<Sprite> Sprites = new List<Sprite>();

        public Chain(PhysicsEngine _physicsEngine, World _world)
        {
            physicsEngine = _physicsEngine;
            world = _world;
            name = "";
            sprite1 = null;
            sprite2 = null;
            Sprites.Clear();
        }

        public bool Add(string shape1, string shape2, List<Sprite> GlobalSprites, bool bChain, string sColour, bool bImageCircle, float scale)
        {
            foreach (Sprite i in GlobalSprites)
            {
                if (i.name == shape1) sprite1 = i;
                if (i.name == shape2) sprite2 = i;
            }
            if (null == sprite1 || null == sprite2) return false;

            Vec2 s1 = sprite1.body.GetPosition();
            Vec2 s2 = sprite2.body.GetPosition();
            string shapeName;
            float posXP, posYP, radiusP = 0.5f;
            float fraction;

            float dx = (s2.X - s1.X);
            float dy = (s2.Y - s1.Y);
            float dist = (float)System.Math.Sqrt(dx * dx + dy * dy);
            int count = (int) (dist/(3*radiusP)+0.5f);
            float angleP = dx == 0.0f ? (float)(System.Math.PI/2.0) : (float)System.Math.Atan(dy / dx);
            float lenP = dist / (float)(count) / 2.0f;
            float widthP = radiusP / 3.0f;
            dx /= (float)count;
            dy /= (float)count;

            RevoluteJointDef jd1 = new RevoluteJointDef();
            jd1.CollideConnected = false;
            DistanceJointDef jd2 = new DistanceJointDef();
            jd2.CollideConnected = false;

            Body prevBody = sprite1.body;

            Primitive oldBrushColor = GraphicsWindow.BrushColor;
            Primitive oldPenColor = GraphicsWindow.PenColor;
            Primitive oldPenWidth = GraphicsWindow.PenWidth;
            if (bChain)
            {
                GraphicsWindow.BrushColor = "#00000000";
                GraphicsWindow.PenColor = sColour;
                GraphicsWindow.PenWidth = 2;
            }
            else
            {
                GraphicsWindow.BrushColor = sColour;
                GraphicsWindow.PenColor = "#ff000000";
                GraphicsWindow.PenWidth = 0;
            }
            for (int i = 0; i < count; i++)
            {
                Sprite _sprite = new Sprite(physicsEngine, world);
                fraction = (float)(i) / (float)(count);
                posXP = s1.X + fraction * dx;
                posYP = s1.Y + fraction * dy;
                Vec2 posP = new Vec2(s1.X + (i + 0.5f) * dx, s1.Y + (i + 0.5f) * dy);
                Vec2 anchorP = new Vec2(s1.X + i * dx, s1.Y + i * dy);

                // Test if chain point is inside the shape
                //if (prevBody.GetShapeList().TestPoint(prevBody.GetXForm(), posP)) continue;

                if (bChain)
                {
                    shapeName = Shapes.AddEllipse(20 * radiusP, 20 * radiusP);
                    _sprite.Add(shapeName, posP.X, posP.Y, radiusP, radiusP, 0.0f, 0.3f, 0.1f, 40.0f, spriteType.MOVING, bImageCircle, scale);
                }
                else
                {
                    shapeName = Shapes.AddRectangle(20 * lenP, 20 * widthP);
                    Shapes.Zoom(shapeName, 1.1, 1.0);
                    _sprite.Add(shapeName, posXP, posYP, lenP, widthP, 0.0f, 0.3f, 0.5f, 20.0f, spriteType.MOVING, bImageCircle, scale);
                    _sprite.body.SetXForm(posP, angleP);
                }
                Sprites.Add(_sprite);

                jd1.Initialize(prevBody, _sprite.body, anchorP);
                world.CreateJoint(jd1);
                jd2.Initialize(prevBody, _sprite.body, prevBody.GetPosition(), _sprite.body.GetPosition());
                world.CreateJoint(jd2);
                prevBody = _sprite.body;
            }
            GraphicsWindow.BrushColor = oldBrushColor;
            GraphicsWindow.PenColor = oldPenColor;
            GraphicsWindow.PenWidth = oldPenWidth;

            jd1.Initialize(prevBody, sprite2.body, s2);
            world.CreateJoint(jd1);
            jd2.Initialize(prevBody, sprite2.body, prevBody.GetPosition(), sprite2.body.GetPosition());
            world.CreateJoint(jd2);

            return true;
        }

        public bool Equals(Chain other)
        {
            if (this.name == other.name)
                return true;
            else
                return false;
        }
    }

    class SpriteContactListener : ContactListener
    {
        private PhysicsEngine engine;
        public SpriteContactListener(PhysicsEngine _engine)
        {
            engine = _engine;
        }

        // (1)
        public override void Add(ContactPoint point)
        {
            if (null != point.Shape1.UserData && point.Shape1.UserData.GetType() != typeof(Sprite)) return;
            if (null != point.Shape2.UserData && point.Shape2.UserData.GetType() != typeof(Sprite)) return;

            Sprite _Sprite1, _Sprite2;

            _Sprite1 = (Sprite)point.Shape1.UserData;
            _Sprite2 = (Sprite)point.Shape2.UserData;

            if (null != _Sprite1) _Sprite1.Collisions.Add(null == _Sprite2 ? "Wall" : _Sprite2.name);
            if (null != _Sprite2) _Sprite2.Collisions.Add(null == _Sprite1 ? "Wall" : _Sprite1.name);

            foreach (Tire tire in engine.Tires)
            {
                if (tire.sprite == _Sprite1) tire.Information["Crash"] = engine.scale * point.Velocity.Length();
                if (tire.sprite == _Sprite2) tire.Information["Crash"] = engine.scale * point.Velocity.Length();
            }
       }

        // (2)
        //public override void Result(ContactResult point)
        //{
        //}

        // (3)
        //public override void Persist(ContactPoint point)
        //{
        //}

        // (4)
        //public override void Remove(ContactPoint point)
        //{
        //}
    }

    class Join
    {
        // Private
        private World world;

        //Public
        public string name;
        public joinType type;
        public Joint jd;
        public Body body1;
        public Body body2;

        public Join(string _name, World _world, joinType _type)
        {
            name = _name;
            world = _world;
            type = _type;
            jd = null;
            body1 = null;
            body2 = null;
        }
    }

    class PhysicsEngine : IDisposable
    {
        // Private
        World world;
        SpriteContactListener contactListener;
        float pi;
        int nextJoint;
        List<Sprite> Sprites = new List<Sprite>();
        List<InactiveShape> InactiveShapes = new List<InactiveShape>();
        List<Chain> Chains = new List<Chain>();
        List<Weld> Welds = new List<Weld>();
        List<Join> Joins = new List<Join>();
        List<Explosion> Explosions = new List<Explosion>();
        Body groundBody;
        Body leftBody;
        Body rightBody;
        Body topBody;
        Sprite followSpriteX, followSpriteY, boxSprite;
        Vec2 boxSprite1, boxSprite2;

        //Public
        public float timeStep;
        public int velocityIterations, positionIterations;
        public int maxPolygonVertices
        {
            get { return Settings.MaxPolygonVertices; }
            set { Settings.MaxPolygonVertices = value; }
        }
        public int maxProxies
        {
            get { return Settings.MaxProxies; }
            set
            {
                Settings.MaxProxies = System.Math.Min(value, 65535);
                Settings.MaxPairs = 8 * Settings.MaxProxies;
            }
        }
        public float velocityThreshold
        {
            get { return Settings.VelocityThreshold; }
            set { Settings.VelocityThreshold = value; }
        }
        public string chainColour;
        public string ropeColour;
        public bool bImageCircle;
        public bool bCrossConnect;
        public float scale;
        public Vec2 rangeAABB, centreAABB, minAABBB, maxAABBB;
        public List<Tire> Tires = new List<Tire>();
        public Vec2 panViewP; // the offset view in Engine coordinates posP = posS / scale + panViewP

        public PhysicsEngine()
        {
            world = null;
            contactListener = null;
            reset(10.0f, -100.0f, 200.0f, -100.0f, 200.0f);
        }

        public void Dispose()
        {
            world.Dispose();
            GC.SuppressFinalize(this);
        }

        public float getShapeAngle(string shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Dictionary<string, RotateTransform> _rotateTransformMap;
            RotateTransform rotateTransform;
            float angle = 0.0f;

            try
            {
                _rotateTransformMap = (Dictionary<string, RotateTransform>)ShapesType.GetField("_rotateTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_rotateTransformMap.TryGetValue((string)shapeName, out rotateTransform))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            angle = (float)rotateTransform.Angle;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return angle;
        }

        public void reset(float scaleX, float minAABBBX, float maxAABBBX, float minAABBBY, float maxAABBBY)
        {
            removeAllChains();
            removeAllSprites();
            InactiveShapes.Clear();
            Welds.Clear();
            Joins.Clear();
            Tires.Clear();
            Explosions.Clear();

            if (null != world) world.Dispose();

            pi = (float)System.Math.PI;
            nextJoint = 1;
            scale = scaleX;
            minAABBB.X = minAABBBX;
            maxAABBB.X = maxAABBBX;
            minAABBB.Y = minAABBBY;
            maxAABBB.Y = maxAABBBY;
            rangeAABB = maxAABBB - minAABBB;
            centreAABB = 0.5f * (minAABBB + maxAABBB);

            AABB worldAABB = default(AABB);
            worldAABB.LowerBound.Set(minAABBB.X, minAABBB.Y);
            worldAABB.UpperBound.Set(maxAABBB.X, maxAABBB.Y);
            Vec2 gravity = new Vec2(0f, 10f);
            bool doSleep = true;
            world = new World(worldAABB, gravity, doSleep);

            contactListener = new SpriteContactListener(this);
            world.SetContactListener(contactListener);

            GraphicsWindow.Show();

            leftBody = null;
            rightBody = null;
            topBody = null;
            groundBody = null;

            followSpriteX = null;
            followSpriteY = null;
            boxSprite = null;
            panViewP = Vec2.Zero;

            timeStep = 0.025f;
            velocityIterations = 6;
            positionIterations = 2;
            velocityThreshold = 1.0f;

            chainColour = "#ff000000";
            ropeColour = "#ffaa9955";

            bImageCircle = false;
            bCrossConnect = true;

            setBoundaries(0f, GraphicsWindow.Width, 0f, GraphicsWindow.Height);
        }

        public void addSprite(string shapeName, float posXS, float posYS, float sizeXS, float sizeYS, float friction, float restitution, float density, spriteType eType)
        {
            float angleS = getShapeAngle(shapeName);

            if (eType == spriteType.INACTIVE)
            {
                InactiveShape _shape = new InactiveShape();
                _shape.name = shapeName;
                _shape.Add(shapeName);
                _shape.widthS = sizeXS;
                _shape.heightS = sizeYS;
                _shape.posXS = posXS;
                _shape.posYS = posYS;
                _shape.angleS = angleS;
                InactiveShapes.Add(_shape);
            }
            else
            {
                Sprite _sprite = new Sprite(this, world);
                bool success = _sprite.Add(shapeName, posXS / scale, posYS / scale, sizeXS / scale, sizeYS / scale, angleS * pi / 180f, friction, restitution, density, eType, bImageCircle, scale);
                if (success) Sprites.Add(_sprite);
            }
        }

        public string addAnchor(float posXS, float posYS, spriteType eType)
        {
            float radS = 2.0f;
            string shapeName = Shapes.AddEllipse(2 * radS, 2 * radS);
            Shapes.SetOpacity(shapeName, 0);
            Sprite _sprite = new Sprite(this, world);
            bool success = _sprite.Add(shapeName, posXS / scale, posYS / scale, radS / scale, radS / scale, 0.0f, 0.0f, 0.0f, 10.0f, eType, bImageCircle, scale);
            if (success) Sprites.Add(_sprite);
            return shapeName;
        }

        public void removeSprite(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    for (Shape shape = i.body.GetShapeList(); shape != null; shape = shape._next)
                    {
                        if (shape.UserData == i)
                        {
                            i.body.DestroyShape(shape);  // This a Box2D BUG FIXED
                            break;
                        }
                    }
                    if (i.body._shapeCount == 0)
                    {
                        world.DestroyBody(i.body);
                    }
                    else
                    {
                        i.body.SetMassFromShapes();
                    }
                    Shapes.Remove(shapeName);
                    Sprites.Remove(i);
                    Tire tire = getTire(shapeName);
                    if (null != tire) Tires.Remove(tire);
                    return;
                }
            }

            foreach (InactiveShape i in InactiveShapes)
            {
                if (i.name == shapeName)
                {
                    Shapes.Remove(shapeName);
                    InactiveShapes.Remove(i);
                    return;
                }
            }
        }

        public void removeAllSprites()
        {
            foreach (Sprite i in Sprites)
            {
                Shapes.Remove(i.name);
                world.DestroyBody(i.body);
            }
            Sprites.Clear();

            foreach (InactiveShape i in InactiveShapes)
            {
                Shapes.Remove(i.name);
            }
            InactiveShapes.Clear();
        }

        public void disconnectSprite(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    for (Shape shape = i.body.GetShapeList(); shape != null; shape = shape._next)
                    {
                        if (shape.UserData == i)
                        {
                            i.body.DestroyShape(shape); // This a Box2D BUG FIXED
                            break;
                        }
                    }
                    if (i.body._shapeCount == 0)
                    {
                        world.DestroyBody(i.body);
                    }
                    else
                    {
                        i.body.SetMassFromShapes();
                    }
                    Sprites.Remove(i);
                    return;
                }
            }

            foreach (InactiveShape i in InactiveShapes)
            {
                if (i.name == shapeName)
                {
                    InactiveShapes.Remove(i);
                    return;
                }
            }
        }

        public string addChain(string shape1, string shape2, bool bChain)
        {
            string sLabel = bChain ? "Chain" : "Rope";
            Chain _chain = new Chain(this, world);
            int i = 1;
            _chain.name = sLabel + i.ToString();
            foreach (Chain j in Chains)
            {
                if (j.name == _chain.name)
                {
                    i++;
                    _chain.name = sLabel + i.ToString();
                }
            }
            bool success = _chain.Add(shape1, shape2, Sprites, bChain, bChain ? chainColour : ropeColour, bImageCircle, scale);
            if (success)
            {
                Chains.Add(_chain);
                return _chain.name;
            }
            else
            {
                return "";
            }
        }

        public void removeChain(string shapeName)
        {
            foreach (Chain i in Chains)
            {
                if (i.name == shapeName)
                {
                    foreach (Sprite j in i.Sprites)
                    {
                        Shapes.Remove(j.name);
                        world.DestroyBody(j.body);
                    }
                    i.Sprites.Clear();
                    Chains.Remove(i);
                    return;
                }
            }
        }

        public void removeAllChains()
        {
            foreach (Chain i in Chains)
            {
                foreach (Sprite j in i.Sprites)
                {
                    Shapes.Remove(j.name);
                    world.DestroyBody(j.body);
                }
                i.Sprites.Clear();
            }
            Chains.Clear();
        }

        public void setGravity(float gravXS, float gravYS)
        {
            world.Gravity = new Vec2(gravXS / scale, gravYS / scale);
        }

        public void setGravity(string shapeName, float gravXS, float gravYS)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    i.body.Gravity = new Vec2(gravXS / scale, gravYS / scale);
                }
            }
        }

        public void setBoundaries(float leftS, float rightS, float topS, float bottomS)
        {
            if (leftS < 0)
            {
                if (null != leftBody)
                {
                    world.DestroyBody(leftBody);
                    leftBody = null;
                }
            }
            else
            {
                if (null == leftBody)
                {
                    BodyDef leftBodyDef = new BodyDef();
                    leftBodyDef.Position.Set(0f, 0f);
                    leftBody = world.CreateBody(leftBodyDef);
                    PolygonDef leftShapeDef = new PolygonDef();
                    leftShapeDef.SetAsBox(1f, rangeAABB.Y);
                    leftShapeDef.Friction = 0.5f;
                    leftBody.CreateShape(leftShapeDef);
                }
                Vec2 posLeft = new Vec2((leftS / scale) - 1.0f, centreAABB.Y);
                leftBody.SetXForm(posLeft, 0.0f);
            }

            if (rightS > GraphicsWindow.Width)
            {
                if (null != rightBody)
                {
                    world.DestroyBody(rightBody);
                    rightBody = null;
                }
            }
            else
            {
                if (null == rightBody)
                {
                    BodyDef rightBodyDef = new BodyDef();
                    rightBodyDef.Position.Set(0f, 0f);
                    rightBody = world.CreateBody(rightBodyDef);
                    PolygonDef rightShapeDef = new PolygonDef();
                    rightShapeDef.SetAsBox(1f, rangeAABB.Y);
                    rightShapeDef.Friction = 0.5f;
                    rightBody.CreateShape(rightShapeDef);
                }
                Vec2 posRight = new Vec2((rightS / scale) + 1.0f, centreAABB.Y);
                rightBody.SetXForm(posRight, 0.0f);
            }

            if (topS < 0)
            {
                if (null != topBody)
                {
                    world.DestroyBody(topBody);
                    topBody = null;
                }
            }
            else
            {
                if (null == topBody)
                {
                    BodyDef topBodyDef = new BodyDef();
                    topBodyDef.Position.Set(0f, 0f);
                    topBody = world.CreateBody(topBodyDef);
                    PolygonDef topShapeDef = new PolygonDef();
                    topShapeDef.SetAsBox(rangeAABB.X, 1f);
                    topShapeDef.Friction = 0.5f;
                    topBody.CreateShape(topShapeDef);
                }
                Vec2 posTop = new Vec2(centreAABB.X, (topS / scale) - 1.0f);
                topBody.SetXForm(posTop, 0.0f);
            }

            if (bottomS > GraphicsWindow.Height)
            {
                if (null != groundBody)
                {
                    world.DestroyBody(groundBody);
                    groundBody = null;
                }
            }
            else
            {
                if (null == groundBody)
                {
                    BodyDef groundBodyDef = new BodyDef();
                    groundBodyDef.Position.Set(0f, 0f);
                    groundBody = world.CreateBody(groundBodyDef);
                    PolygonDef groundShapeDef = new PolygonDef();
                    groundShapeDef.SetAsBox(rangeAABB.X, 1f);
                    groundShapeDef.Friction = 0.5f;
                    groundBody.CreateShape(groundShapeDef);
                }
                Vec2 posGround = new Vec2(centreAABB.X, (bottomS / scale) + 1.0f);
                groundBody.SetXForm(posGround, 0.0f);
            }
        }

        // a solid but seems unstable one body solution - fixed complex shapes
        public void groupSprites(string shapeName1, string shapeName2, bool connect)
        {
            Sprite sprite1 = null;
            Sprite sprite2 = null;
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName1) sprite1 = i;
                if (i.name == shapeName2) sprite2 = i;
            }

            if (null == sprite1 || null == sprite2) return; // Make sure the sprites exist
            if (!bCrossConnect && (null != sprite1.body._jointList || null != sprite2.body._jointList)) return; // Non-welded attached bodies only

            Body body1 = sprite1.body;
            Body body2 = sprite2.body;

            if (connect)
            {
                if (body1 != body2)
                {
                    // Consider all shapes in body1 (containing shape1) - we move them all!
                    for (Shape shape = body1.GetShapeList(); shape != null; shape = shape._next)
                    {
                        // Get the current sprite
                        if (null != shape.UserData && shape.UserData.GetType() != typeof(Sprite)) continue;
                        Sprite sprite = (Sprite)shape.UserData;
                        if (null == sprite) continue;
                        // Reposition the sprite local coordinates (Def) to be relative to body2
                        // Add sprite1 Def to body2 (create a shape) and point the new shape sprite1
                        if (null != sprite.circleDef)
                        {
                            //CircleShape shapeCircle = (CircleShape)shape1;
                            sprite.circleDef.LocalPosition += body1.GetPosition() - body2.GetPosition();
                            Shape spriteShape = body2.CreateShape(sprite.circleDef);
                            spriteShape.UserData = sprite;
                        }
                        if (null != sprite.polygonDef)
                        {
                            //PolygonShape shapePolygon = (PolygonShape)shape1;
                            for (int i = 0; i < sprite.polygonDef.VertexCount; i++)
                            {
                                sprite.polygonDef.Vertices[i] += body1.GetPosition() - body2.GetPosition();
                            }
                            Shape spriteShape = body2.CreateShape(sprite.polygonDef);
                            spriteShape.UserData = sprite;
                        }
                        // Reset the body for the sprite to body2
                        sprite.body = body2;
                    }
                    // Remove all the shapes from body1 and remove the body
                    world.DestroyBody(body1);
                    // Update the mass of body2 (now containg all the moved shapes)
                    body2.SetMassFromShapes();
                }
            }
            else
            {
                if (body1 == body2)
                {
                    // Create a new body1 with the same position and angle as the original body2
                    BodyDef bodyDef = new BodyDef();
                    bodyDef.Position.Set(body2.GetPosition().X, body2.GetPosition().Y);
                    body1 = world.CreateBody(bodyDef);
                    // Get the shape for sprite1
                    Shape shape;
                    for (shape = body2.GetShapeList(); shape != null; shape = shape._next)
                    {
                        if (sprite1 == shape.UserData) break;
                    }
                    // Create and position the new body1 at the centre of the shape1
                    Vec2 position = body2.GetPosition();
                    float angle = body2.GetAngle();
                    if (shape.GetType() == ShapeType.CircleShape)
                    {
                        CircleShape shapeCircle = (CircleShape)shape;
                        position.X += shapeCircle.GetLocalPosition().X * (float)System.Math.Cos(angle) - shapeCircle.GetLocalPosition().Y * (float)System.Math.Sin(angle);
                        position.Y += shapeCircle.GetLocalPosition().X * (float)System.Math.Sin(angle) + shapeCircle.GetLocalPosition().Y * (float)System.Math.Cos(angle);
                    }
                    else if (shape.GetType() == ShapeType.PolygonShape)
                    {
                        PolygonShape shapePolygon = (PolygonShape)shape;
                        position.X += shapePolygon.GetCentroid().X * (float)System.Math.Cos(angle) - shapePolygon.GetCentroid().Y * (float)System.Math.Sin(angle);
                        position.Y += shapePolygon.GetCentroid().X * (float)System.Math.Sin(angle) + shapePolygon.GetCentroid().Y * (float)System.Math.Cos(angle);
                    }
                    body1.SetXForm(position, angle);
                    // Add shape1 sprite to new body1 and remove shape1 from body2
                    if (null != sprite1.circleDef)
                    {
                        sprite1.circleDef.LocalPosition = new Vec2(0.0f,0.0f);
                        Shape spriteShape = body1.CreateShape(sprite1.circleDef);
                        spriteShape.UserData = sprite1;
                    }
                    if (null != sprite1.polygonDef)
                    {
                        Vec2 centre = new Vec2(0.0f, 0.0f);
                        for (int i = 0; i < sprite1.polygonDef.VertexCount; i++)
                        {
                            centre += sprite1.polygonDef.Vertices[i] * (1.0f / (float)sprite1.polygonDef.VertexCount);
                        }
                        for (int i = 0; i < sprite1.polygonDef.VertexCount; i++)
                        {
                            sprite1.polygonDef.Vertices[i] -= centre;
                        }
                        Shape spriteShape = body1.CreateShape(sprite1.polygonDef);
                        spriteShape.UserData = sprite1;
                    }
                    for (shape = body2.GetShapeList(); shape != null; shape = shape._next)
                    {
                        if (shape.UserData == sprite1) body2.DestroyShape(shape);
                    }
                    // Update the mass of body1 and body2 (now containg all the moved shapes)
                    body1.SetMassFromShapes();
                    body2.SetMassFromShapes();
                }
            }
        }

        // A wobbly but stable joint method - seems good for high impact collisions
        public void attachSprites(string shapeName1, string shapeName2, bool connect, bool rotation)
        {
            Sprite sprite1 = null;
            Sprite sprite2 = null;
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName1) sprite1 = i;
                if (i.name == shapeName2) sprite2 = i;
            }

            if (null == sprite1 || null == sprite2) return; // Make sure the sprites exist
            if (!bCrossConnect && (sprite1.body._shapeCount != 1 || sprite2.body._shapeCount != 1)) return; // Single shape bodies only

            Body body1 = sprite1.body;
            Body body2 = sprite2.body;

            if (body1 == body2) return; // Non grouped shapes only

            if (connect)
            {
                RevoluteJointDef jd1 = new RevoluteJointDef();
                jd1.CollideConnected = false;
                if (!rotation)
                {
                    jd1.EnableLimit = true;
                    jd1.LowerAngle = 0.0f;
                    jd1.UpperAngle = 0.0f;
                }
                jd1.Initialize(sprite1.body, sprite2.body, sprite1.body.GetPosition());
                DistanceJointDef jd2 = new DistanceJointDef();
                jd2.CollideConnected = false;
                jd2.Initialize(sprite1.body, sprite2.body, sprite1.body.GetPosition(), sprite2.body.GetPosition());
                Weld _weld = new Weld(world);
                _weld.bRotate = rotation;
                _weld.jd1 = world.CreateJoint(jd1);
                _weld.jd2 = world.CreateJoint(jd2);
                _weld.body1 = sprite1.body;
                _weld.body2 = sprite2.body;
                Welds.Add(_weld);
            }
            else
            {
                foreach (Weld i in Welds)
                {
                    if ((i.body1 == sprite1.body && i.body2 == sprite2.body) || (i.body1 == sprite2.body && i.body2 == sprite1.body))
                    {
                        if (null != i.jd1) world.DestroyJoint(i.jd1);
                        if (null != i.jd2) world.DestroyJoint(i.jd2);
                        return;
                    }
                }
            }
        }

        // a generalised joint connection method
        public string joinSprites(string shapeName1, string shapeName2, joinType type, bool collideConnected, List<Primitive> param)
        {
            Sprite sprite1 = null;
            Sprite sprite2 = null;
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName1) sprite1 = i;
                if (i.name == shapeName2) sprite2 = i;
            }

            if (null == sprite1 || null == sprite2) return ""; // Make sure the sprites exist
            if (!bCrossConnect && (sprite1.body._shapeCount != 1 || sprite2.body._shapeCount != 1)) return ""; // Single shape bodies only

            Body body1 = sprite1.body;
            Body body2 = sprite2.body;

            if (type != joinType.MOUSE && body1 == body2) return ""; // Distinct shapes only
            if (type == joinType.MOUSE && body1 != body2) return ""; // The same shape only

            Vec2 dir = Vec2.Zero;
            string jointName = "Joint"+nextJoint++;
            Join _join = new Join(jointName, world, type);
            _join.body1 = sprite1.body;
            _join.body2 = sprite2.body;
            Joins.Add(_join);

            switch (type)
            {
                case joinType.DISTANCE:
                    DistanceJointDef jd1 = new DistanceJointDef();
                    jd1.CollideConnected = collideConnected;
                    if (param.Count >= 1) jd1.DampingRatio = param[0];
                    jd1.Initialize(sprite1.body, sprite2.body, sprite1.body.GetPosition(), sprite2.body.GetPosition());
                    _join.jd = world.CreateJoint(jd1);
                    break;
                case joinType.GEAR:
                    GearJointDef jd2 = new GearJointDef();
                    jd2.CollideConnected = collideConnected;
                    if (param.Count >= 1) jd2.Ratio = param[0];
                    if (param.Count >= 3) 
                    {
                        foreach (Join join in Joins)
                        {
                            if (join.name == param[1])
                            {
                                //TextWindow.WriteLine("BODY 1 " + sprite1.name);
                                jd2.Body1 = sprite1.body;
                                jd2.Joint1 = join.jd;
                            }
                            if (join.name == param[2])
                            {
                                //TextWindow.WriteLine("BODY 2 " + sprite2.name);
                                jd2.Body2 = sprite2.body;
                                jd2.Joint2 = join.jd;
                            }
                        }
                    }
                    else
                    {
                        for (Joint joint = world.GetJointList(); joint != null; joint = joint._next)
                        {
                            if (joint.GetType() == JointType.RevoluteJoint || joint.GetType() == JointType.PrismaticJoint)
                            {
                                if (null == jd2.Body1 && (joint._body1 == sprite1.body || joint._body2 == sprite1.body))
                                {
                                    //TextWindow.WriteLine("BODY 1 " + sprite1.name);
                                    jd2.Body1 = sprite1.body;
                                    jd2.Joint1 = joint;
                                }
                                if (null == jd2.Body2 && (joint._body1 == sprite2.body || joint._body2 == sprite2.body))
                                {
                                    //TextWindow.WriteLine("BODY 2 " + sprite2.name);
                                    jd2.Body2 = sprite2.body;
                                    jd2.Joint2 = joint;
                                }
                            }
                        }
                    }
                    if (null != jd2.Joint1 && null != jd2.Joint2) _join.jd = world.CreateJoint(jd2);
                    break;
                case joinType.LINE:
                    LineJointDef jd3 = new LineJointDef();
                    jd3.CollideConnected = collideConnected;
                    if (param.Count >= 2)
                    {
                        dir.X = param[0];
                        dir.Y = param[1];
                        if (param.Count >= 4)
                        {
                            jd3.enableLimit = true;
                            jd3.lowerTranslation = param[2] / scale;
                            jd3.upperTranslation = param[3] / scale;
                        }
                    }
                    else
                    {
                        dir = sprite2.body.GetPosition() - sprite1.body.GetPosition();
                    }
                    dir.Normalize();
                    jd3.Initialize(sprite1.body, sprite2.body, (sprite1.body.GetPosition() + sprite2.body.GetPosition()) * 0.5f, dir);
                    _join.jd = world.CreateJoint(jd3);
                    break;
                case joinType.MOUSE:
                    MouseJointDef jd4 = new MouseJointDef();
                    jd4.CollideConnected = collideConnected;
                    jd4.Body1 = sprite1.body;
                    jd4.Body2 = sprite2.body;
                    jd4.Target = sprite1.body.GetPosition();
                    jd4.MaxForce = sprite1.body.GetMass() * (param.Count >= 1 ? (float)param[0] / scale : 1000.0f);
                    if (param.Count >= 2) jd4.DampingRatio = param[1];
                    _join.jd = world.CreateJoint(jd4);
                    break;
                case joinType.PRISMATIC_H:
                    PrismaticJointDef jd5 = new PrismaticJointDef();
                    jd5.CollideConnected = collideConnected;
                    if (param.Count >= 2)
                    {
                        dir.X = param[0];
                        dir.Y = param[1];
                        if (param.Count >= 4)
                        {
                            jd5.EnableLimit = true;
                            jd5.LowerTranslation = param[2] / scale;
                            jd5.UpperTranslation = param[3] / scale;
                        }
                    }
                    else
                    {
                        dir = new Vec2(1, 0);
                    }
                    dir.Normalize();
                    jd5.Initialize(sprite1.body, sprite2.body, (sprite1.body.GetPosition() + sprite2.body.GetPosition()) * 0.5f, dir); //Slide horizontally
                    _join.jd = world.CreateJoint(jd5);
                    break;
                case joinType.PRISMATIC_V:
                    PrismaticJointDef jd6 = new PrismaticJointDef();
                    jd6.CollideConnected = collideConnected;
                    if (param.Count >= 2)
                    {
                        dir.X = param[0];
                        dir.Y = param[1];
                        if (param.Count >= 4)
                        {
                            jd6.EnableLimit = true;
                            jd6.LowerTranslation = param[2] / scale;
                            jd6.UpperTranslation = param[3] / scale;
                        }
                    }
                    else
                    {
                        dir = new Vec2(0, 1);
                    }
                    dir.Normalize();
                    jd6.Initialize(sprite1.body, sprite2.body, (sprite1.body.GetPosition() + sprite2.body.GetPosition()) * 0.5f, dir); //Slide vertically
                    _join.jd = world.CreateJoint(jd6);
                    break;
                case joinType.PULLEY:
                    PulleyJointDef jd7 = new PulleyJointDef();
                    jd7.CollideConnected = collideConnected;
                    Vec2 pos1 = sprite1.body.GetPosition();
                    Vec2 pos2 = sprite2.body.GetPosition();
                    float top = System.Math.Min(pos1.Y, pos2.Y) - sprite1.heightS / scale /2.0f - PulleyJoint.MinPulleyLength; //Y is down
                    jd7.Initialize(sprite1.body, sprite2.body, new Vec2(pos1.X, top), new Vec2(pos2.X, top), pos1, pos2, (param.Count >= 1 ? (float)param[0] : 1.0f)); //Anchored at top-most body
                    _join.jd = world.CreateJoint(jd7);
                    break;
                case joinType.REVOLUTE:
                    RevoluteJointDef jd8 = new RevoluteJointDef();
                    jd8.CollideConnected = collideConnected;
                    if (param.Count >= 2)
                    {
                        jd8.EnableLimit = true;
                        jd8.LowerAngle = param[0];
                        jd8.UpperAngle = param[1];
                    }
                    jd8.Initialize(sprite1.body, sprite2.body, sprite1.body.GetPosition());
                    _join.jd = world.CreateJoint(jd8);
                    break;
            }
            return jointName;
        }

        public void detachJoint(string jointName)
        {
            foreach (Join i in Joins)
            {
                if (i.name == jointName && null != i.jd)
                {
                    world.DestroyJoint(i.jd);
                    return;
                }
            }
        }

        public void setJointMotor(string jointName, float speed, float maxForce)
        {
            foreach (Join i in Joins)
            {
                if (i.name == jointName && null != i.jd)
                {
                    switch (i.type)
                    {
                        case joinType.DISTANCE:
                            break;
                        case joinType.GEAR:
                            break;
                        case joinType.LINE:
                            ((LineJoint)i.jd).EnableMotor(maxForce != 0);
                            ((LineJoint)i.jd).SetMaxMotorForce(maxForce / scale);
                            ((LineJoint)i.jd).SetMotorSpeed(speed / scale);
                            break;
                        case joinType.MOUSE:
                            break;
                        case joinType.PRISMATIC_H:
                        case joinType.PRISMATIC_V:
                            ((PrismaticJoint)i.jd).EnableMotor(maxForce != 0);
                            ((PrismaticJoint)i.jd).SetMaxMotorForce(maxForce / scale);
                            ((PrismaticJoint)i.jd).MotorSpeed = speed / scale;
                            break;
                        case joinType.PULLEY:
                            break;
                        case joinType.REVOLUTE:
                            ((RevoluteJoint)i.jd).EnableMotor(maxForce != 0);
                            ((RevoluteJoint)i.jd).SetMaxMotorTorque(maxForce / scale);
                            ((RevoluteJoint)i.jd).MotorSpeed = speed / scale;
                            break;
                    }
                    return;
                }
            }
        }

        //Tires
        private Tire getTire(string shapeName)
        {
            foreach (Tire tire in Tires)
            {
                if (tire.sprite.name == shapeName) return tire;
            }
            return null;
        }

        public void setTire(string shapeName)
        {
            Tire tire = getTire(shapeName);
            if (null == tire)
            {
                foreach (Sprite i in Sprites)
                {
                    if (i.name == shapeName)
                    {
                        tire = new Tire(i);
                        Tires.Add(tire);
                        break;
                    }
                }
            }
        }

        public void moveTire(string shapeName, float forceS)
        {
            Tire tire = getTire(shapeName);
            if (null != tire) tire.updateDrive(forceS / scale);
        }

        public void brakeTire(string shapeName)
        {
            Tire tire = getTire(shapeName);
            if (null != tire) tire.brake();
        }

        public void turnTire(string shapeName, float torqueS)
        {
            Tire tire = getTire(shapeName);
            if (null != tire) tire.updateTurn(torqueS / scale / scale);
        }

        public void setTireProperties(Primitive shapeName, Dictionary<string, float> propeties)
        {
            Tire tire = getTire(shapeName);
            if (null == tire) return;
            if (propeties.ContainsKey("AntiSkid")) tire.Properties["AntiSkid"] = propeties["AntiSkid"];
            if (propeties.ContainsKey("Drag")) tire.Properties["Drag"] = propeties["Drag"];
            if (propeties.ContainsKey("Brake")) tire.Properties["Brake"] = propeties["Brake"];
            if (propeties.ContainsKey("Straighten")) tire.Properties["Straighten"] = propeties["Straighten"];
            if (propeties.ContainsKey("BrakeStraighten")) tire.Properties["BrakeStraighten"] = propeties["BrakeStraighten"];
        }

        public Dictionary<string, float> getTireProperties(Primitive shapeName)
        {
            Tire tire = getTire(shapeName);
            if (null == tire) return null;
            return tire.Properties;
        }

        public Dictionary<string, float> getTireInformation(Primitive shapeName)
        {
            Tire tire = getTire(shapeName);
            if (null == tire) return null;
            return tire.Information;
        }

        //Explosions
        public void addExplosion(float posXS, float posYS, float powerS, float damping, string colour)
        {
            Explosion explosion = new Explosion(this, world, 500, 50, 1000, damping, posXS, posYS, powerS, scale, colour);
            Explosions.Add(explosion);
        }

        //Update
        public void doTimestep()
        {
            //Reset collisions
            foreach (Sprite i in Sprites)
            {
                i.Collisions.Clear();
            }

            //Update tires
            foreach (Tire tire in Tires)
            {
                tire.Information.Clear();
                tire.updateFriction();
            }

            //Update joints
            foreach (Join join in Joins)
            {
                if (join.type == joinType.MOUSE)
                {
                    ((MouseJoint)join.jd).SetTarget(new Vec2(GraphicsWindow.MouseX / scale, GraphicsWindow.MouseY / scale));
                }
            }

            //PreSolve shape following position
            Vec2 offset = Vec2.Zero;
            Vec2 offsetBox = Vec2.Zero;
            if (null != followSpriteX) offset.X += followSpriteX.body.GetPosition().X;
            if (null != followSpriteY) offset.Y += followSpriteY.body.GetPosition().Y;

            //The physics engine update solve
            world.Step(timeStep, velocityIterations, positionIterations);

            //PostSolve shape following
            if (null != followSpriteX) offset.X -= followSpriteX.body.GetPosition().X;
            if (null != followSpriteY) offset.Y -= followSpriteY.body.GetPosition().Y;
            panViewP -= offset;

            if (offset.Length() == 0 && null != boxSprite)
            {
                Vec2 pos = boxSprite.body.GetPosition() - panViewP; //In screen view
                if (pos.X < boxSprite1.X) offsetBox.X = boxSprite1.X - pos.X;
                else if (pos.X > boxSprite2.X) offsetBox.X = boxSprite2.X - pos.X;
                if (pos.Y < boxSprite1.Y) offsetBox.Y = boxSprite1.Y - pos.Y;
                else if (pos.Y > boxSprite2.Y) offsetBox.Y = boxSprite2.Y - pos.Y;
            }
            panViewP -= offsetBox;

            Vec2 position;
            float angle;
            float X, Y;

            // Consistency for multi-shape bodies
            Type GraphicsWindowType = typeof(GraphicsWindow);
            InvokeHelper ret = new InvokeHelper(delegate
            {
                try
                {
                    //Update explosions
                    foreach (Explosion explosion in Explosions)
                    {
                        foreach (Fragment fragment in explosion.fragments)
                        {
                            if (null != fragment.body && null != fragment.body.GetUserData())
                            {
                                Vec2 pos = fragment.body.GetPosition() - panViewP;
                                //Shapes.Move((Primitive)fragment.body.GetUserData(), pos.X * scale - 1, pos.Y * scale - 1);
                                UIElement elt = (UIElement)fragment.body.GetUserData();
                                System.Windows.Controls.Canvas.SetLeft(elt, pos.X * scale - 1);
                                System.Windows.Controls.Canvas.SetTop(elt, pos.Y * scale - 1);
                            }
                        }
                        if (!explosion.Update())
                        {
                            Explosions.Remove(explosion);
                            break; //can only remove one from list while iterating it
                        }
                    }

                    for (Body body = world.GetBodyList(); body != null; body = body._next)
                    {
                        for (Shape shape = body.GetShapeList(); shape != null; shape = shape._next)
                        {
                            if (null != shape.UserData && shape.UserData.GetType() != typeof(Sprite)) continue;
                            Sprite sprite = (Sprite)shape.UserData;
                            if (null != sprite)
                            {
                                position = body.GetPosition() - panViewP;
                                angle = body.GetAngle();
                                if (shape.GetType() == ShapeType.CircleShape)
                                {
                                    CircleShape shapeCircle = (CircleShape)shape;
                                    position.X += shapeCircle.GetLocalPosition().X * (float)System.Math.Cos(angle) - shapeCircle.GetLocalPosition().Y * (float)System.Math.Sin(angle);
                                    position.Y += shapeCircle.GetLocalPosition().X * (float)System.Math.Sin(angle) + shapeCircle.GetLocalPosition().Y * (float)System.Math.Cos(angle);
                                }
                                else if (shape.GetType() == ShapeType.PolygonShape)
                                {
                                    PolygonShape shapePolygon = (PolygonShape)shape;
                                    position.X += shapePolygon.GetCentroid().X * (float)System.Math.Cos(angle) - shapePolygon.GetCentroid().Y * (float)System.Math.Sin(angle);
                                    position.Y += shapePolygon.GetCentroid().X * (float)System.Math.Sin(angle) + shapePolygon.GetCentroid().Y * (float)System.Math.Cos(angle);
                                }
                                X = scale * position.X - sprite.widthS;
                                Y = scale * position.Y - sprite.heightS;
                                //Shapes.Move(sprite.name, X, Y);
                                //Shapes.Rotate(sprite.name, angle * 180 / pi);
                                System.Windows.Controls.Canvas.SetLeft(sprite.uiElement, X);
                                System.Windows.Controls.Canvas.SetTop(sprite.uiElement, Y);
                                sprite.rotateTransform.Angle = angle * 180 / pi;
                            }
                        }
                    }

                    // Inactive sprites
                    foreach (InactiveShape _shape in InactiveShapes)
                    {
                        //Shapes.Move(_shape.name, _shape.posXS - _shape.widthS, _shape.posYS - _shape.heightS);
                        //Shapes.Rotate(_shape.name, _shape.angleS);
                        System.Windows.Controls.Canvas.SetLeft(_shape.uiElement, _shape.posXS - scale * panViewP.X - _shape.widthS);
                        System.Windows.Controls.Canvas.SetTop(_shape.uiElement, _shape.posYS - scale * panViewP.Y - _shape.heightS);
                        _shape.rotateTransform.Angle = _shape.angleS;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            });
            MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
            method.Invoke(null, new object[] { ret });
        }

        public string getCollisions(string shapeName)
        {
            Primitive collisions = "";
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    for (int j = 0; j < i.Collisions.Count(); j++)
                    {
                        collisions[j+1] =  i.Collisions[j];
                    }
                }
            }
            return collisions;
        }

        public void setPosition(string shapeName, float posXS, float posYS, float angleS)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    Vec2 pos = new Vec2(posXS / scale, posYS / scale);
                    i.body.SetXForm(pos, angleS * pi / 180.0f);
                    return;
                }
            }

            foreach (InactiveShape _shape in InactiveShapes)
            {
                if (_shape.name == shapeName)
                {
                    _shape.posXS = posXS;
                    _shape.posYS = posYS;
                    _shape.angleS = angleS;
                    return;
                }
            }

        }

        public float[] getPosition(string shapeName)
        {
            float[] posS = new float[2] { 0.0f, 0.0f };
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    posS[0] = scale * (i.body.GetPosition().X);
                    posS[1] = scale * (i.body.GetPosition().Y);
                    return posS;
                }
            }

            foreach (InactiveShape _shape in InactiveShapes)
            {
                if (_shape.name == shapeName)
                {
                    posS[0] = _shape.posXS;
                    posS[1] = _shape.posYS;
                    return posS;
                }
            }

            return posS;
        }

        public void setAngle(string shapeName, float angleS)
        {
            float[] posS = getPosition(shapeName);
            setPosition(shapeName, posS[0], posS[1], angleS);
        }

        public float getAngle(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    return i.body.GetAngle() * 180.0f / pi;
                }
            }

            foreach (InactiveShape _shape in InactiveShapes)
            {
                if (_shape.name == shapeName)
                {
                    return _shape.angleS;
                }
            }

            return 0.0f;
        }

        public float getMass(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    return i.body.GetMass(); // We need mass*gravity to be correct
                }
            }
            foreach (Chain i in Chains)
            {
                if (i.name == shapeName)
                {
                    float mass = 0.0f;
                    foreach (Sprite j in i.Sprites)
                    {
                        mass += j.body.GetMass(); // We need mass*gravity to be correct
                    }
                    return mass;
                }
            }
            return 0.0f;
        }

        public float getInertia(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    return scale * scale * i.body.GetInertia();
                }
            }
            return 0.0f;
        }

        public void setVelocity(string shapeName, float velXS, float velYS)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    Vec2 vec = new Vec2(velXS / scale, velYS / scale);
                    i.body.SetLinearVelocity(vec);
                    return;
                }
            }
        }

        public float[] getVelocity(string shapeName)
        {
            float[] velS = new float[2] { 0.0f, 0.0f };
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    velS[0] = scale * i.body.GetLinearVelocity().X;
                    velS[1] = scale * i.body.GetLinearVelocity().Y;
                    return velS;
                }
            }
            return velS;
        }

        public void setImpulse(string shapeName, float impulseXS, float impulseYS)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    Vec2 impulse = new Vec2(impulseXS / scale, impulseYS / scale);
                    i.body.ApplyImpulse(impulse, i.body.GetPosition());
                    return;
                }
            }
        }

        public void setDamping(string shapeName, float linear, float angular)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    i.body._linearDamping = linear;
                    i.body._angularDamping = angular;
                    return;
                }
            }
        }

        public void setForce(string shapeName, float forceXS, float forceYS)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    Vec2 force = new Vec2(forceXS / scale, forceYS / scale);
                    i.body.ApplyForce(force, i.body.GetPosition());
                    return;
                }
            }
        }

        public void setTorque(string shapeName, float torqueS)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    i.body.ApplyTorque(torqueS / scale / scale);
                    return;
                }
            }
        }

        public void setRotation(string shapeName, float angleS)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    i.body.SetAngularVelocity(angleS * pi / 180.0f);
                    return;
                }
            }
        }

        public float getRotation(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    return i.body.GetAngularVelocity() * 180.0f / pi;
                }
            }
            return 0.0f;
        }

        public string getShapeAt(float posXS, float posYS)
        {
            Vec2 posP = new Vec2(posXS / scale, posYS/ scale) + panViewP;
            for (Body body = world.GetBodyList(); body != null; body = body._next)
            {
                XForm xf = body.GetXForm();
                for (Shape shape = body.GetShapeList(); shape != null; shape = shape._next)
                {
                    if (null != shape.UserData && shape.UserData.GetType() != typeof(Sprite)) continue;
                    Sprite sprite = (Sprite)shape.UserData;
                    if (null != sprite && shape.TestPoint(xf, posP))
                    {
                        return sprite.name;
                    }
                }
            }
            return "";
        }

        public void setBullet(string shapeName, bool status)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    i.body.SetBullet(status);
                    return;
                }
            }
        }

        public void panView(float panHorizontalS, float panVerticalS)
        {
            panViewP += new Vec2(panHorizontalS / scale, panVerticalS / scale);
        }

        public float[] getPan()
        {
            return new float[2] { scale * panViewP.X, scale * panViewP.Y };
        }

        public void setFollowX(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    followSpriteX = i;
                    return;
                }
            }
            followSpriteX = null;
        }

        public void setFollowY(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    followSpriteY = i;
                    return;
                }
            }
            followSpriteY = null;
        }

        public void setBox(string shapeName, float x1S, float y1S, float x2S, float y2S)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    boxSprite = i;
                    boxSprite1 = new Vec2(System.Math.Min(x1S, x2S), System.Math.Min(y1S, y2S)) * (1.0f / scale);
                    boxSprite2 = new Vec2(System.Math.Max(x1S, x2S), System.Math.Max(y1S, y2S)) * (1.0f / scale);
                    return;
                }
            }
            boxSprite = null;
        }

        public void deleteFrozen()
        {
            for (Body body = world.GetBodyList(); body != null; body = body._next)
            {
                if (body.IsFrozen())
                {
                    for (Shape shape = body.GetShapeList(); shape != null; shape = shape._next)
                    {
                        if (null != shape.UserData && shape.UserData.GetType() != typeof(Sprite)) continue;
                        Sprite sprite = (Sprite)shape.UserData;
                        if (null != sprite)
                        {
                            Shapes.Remove(sprite.name);
                            Sprites.Remove(sprite);
                        }
                    }
                    world.DestroyBody(body);
                }
            }
        }

        public void wakeAll()
        {
            for (Body body = world.GetBodyList(); body != null; body = body._next)
            {
                if (body.IsSleeping()) body.WakeUp();
            }
        }

        public void toggleMoving(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    i.body.Type = i.body.IsDynamic() ? Body.BodyType.Static : Body.BodyType.Dynamic;
                    return;
                }
            }
        }

        public void toggleRotation(string shapeName)
        {
            foreach (Sprite i in Sprites)
            {
                if (i.name == shapeName)
                {
                    i.body.Flags ^= Body.BodyFlags.FixedRotation;
                    return;
                }
            }
        }
    }
}
