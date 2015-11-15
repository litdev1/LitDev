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

using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Shapes;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    /// <summary>
    /// Physics extension using Box2D engine.
    /// </summary>
    [SmallBasicType]
    public static class LDPhysics
    {
        private static PhysicsEngine _Engine = new PhysicsEngine();

        /// <summary>
        /// The colour to be used for chains.
        /// </summary>
        public static Primitive ChainColour
        {
            get { return _Engine.chainColour; }
            set { _Engine.chainColour = value; }
        }

        /// <summary>
        /// Toggle whether image shapes will be loaded as circles - "True" or "False" (default is "False").
        /// </summary>
        public static Primitive LoadImagesAsCircles
        {
            get { return _Engine.bImageCircle ? "True" : "False"; }
            set { _Engine.bImageCircle = value.ToString().ToLower() == "true"; }
        }

        /// <summary>
        /// The physics engine position iterations (default 2).
        /// </summary>
        public static Primitive PositionIterations
        {
            get { return _Engine.positionIterations; }
            set { _Engine.positionIterations = value; }
        }

        /// <summary>
        /// The colour to be used for ropes.
        /// </summary>
        public static Primitive RopeColour
        {
            get { return _Engine.ropeColour; }
            set { _Engine.ropeColour = value; }
        }

        /// <summary>
        /// The physics engine scaling (pixel/m, default 10).  It is not recommended to change this.
        /// </summary>
        public static Primitive Scaling
        {
            get { return _Engine.scale; }
            set
            {
                _Engine.scale = value;
                _Engine.setBoundaries(0, GraphicsWindow.Width, 0, GraphicsWindow.Height);
            }
        }

        /// <summary>
        /// The physics engine timestep size (default 0.025).
        /// </summary>
        public static Primitive TimeStep
        {
            get { return _Engine.timeStep; }
            set { _Engine.timeStep = value; }
        }

        /// <summary>
        /// The physics engine velocity iterations (default 6).
        /// </summary>
        public static Primitive VelocityIterations
        {
            get { return _Engine.velocityIterations; }
            set { _Engine.velocityIterations = value; }
        }

        /// <summary>
        /// The physics engine velocity threshold for inelastic collisions 'sticky walls' (default 1).
        /// </summary>
        public static Primitive VelocityThreshold
        {
            get { return _Engine.velocityThreshold; }
            set { _Engine.velocityThreshold = value; }
        }

        /// <summary>
        /// The physics engine maximum number of vertices on convex polygons (default 8).
        /// </summary>
        public static Primitive MaxPolygonVertices
        {
            get { return _Engine.maxPolygonVertices; }
            set { _Engine.maxPolygonVertices = value; }
        }

        /// <summary>
        /// The physics engine maximum number of objects 'proxies' (default 1024).
        /// </summary>
        public static Primitive MaxProxies
        {
            get { return _Engine.maxProxies; }
            set { _Engine.maxProxies = value; }
        }

        /// <summary>
        /// Add a chain between two existing shapes.
        /// </summary>
        /// <param name="shape1">
        /// First shape.
        /// </param>
        /// <param name="shape2">
        /// Second shape.
        /// </param>
        /// <returns>
        /// The chain name.
        /// </returns>
        public static Primitive AddChain(Primitive shape1, Primitive shape2)
        {
            return _Engine.addChain(shape1, shape2, true);
        }

        /// <summary>
        /// Add a new small, transparent shape to be used as a fixed anchor point.
        /// </summary>
        /// <param name="posX">
        /// The X coordinate of the anchor.
        /// </param>
        /// <param name="posY">
        /// The Y coordinate of the anchor.
        /// </param>
        /// <returns>
        /// The anchor shape name.
        /// </returns>
        public static Primitive AddFixedAnchor(Primitive posX, Primitive posY)
        {
            return _Engine.addAnchor(posX, posY, spriteType.FIXED);
        }

        /// <summary>
        /// Add an existing SmallBasic shape to the physics engine as a fixed (non-dynamic) shape with friction and restitution that affects shapes that hit it.
        /// </summary>
        /// <param name="shapeName">
        /// The name of the shape.
        /// </param>
        /// <param name="friction">
        /// The shape friction (usually 0 to 1).
        /// </param>
        /// <param name="restitution">
        /// The shape restitution or bounciness (usually 0 to 1).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void AddFixedShape(Primitive shapeName, Primitive friction, Primitive restitution)
        {
            float posXS, posYS, sizeXS, sizeYS;
            string success;

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Utilities.doUpdates();
            Shapes.Rotate(shapeName, _Engine.getShapeAngle(shapeName)); // Create the SB transform
            Utilities.doUpdates();

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Rect rect = new Rect(obj.RenderSize);
                        rect.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj));

                        sizeXS = (float)rect.Width / 2.0f;
                        sizeYS = (float)rect.Height / 2.0f;
                        posXS = (float)rect.Left + sizeXS;
                        posYS = (float)rect.Top + sizeYS;

                        _Engine.addSprite(shapeName, posXS, posYS, sizeXS, sizeYS, friction, restitution, 1.0f, spriteType.FIXED);
                        return "True";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "False";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                success = method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return;
            }

            return;
        }

        /// <summary>
        /// Add an existing SmallBasic shape to the physics engine as an inactive (non-dynamic and non-interacting) shape which only moves with the PanView method.
        /// </summary>
        /// <param name="shapeName">
        /// The name of the shape.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void AddInactiveShape(Primitive shapeName)
        {
            float posXS, posYS, sizeXS, sizeYS;
            string success;

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Utilities.doUpdates();

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Rect rect = new Rect(obj.RenderSize);
                        rect.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj));

                        sizeXS = (float)rect.Width / 2.0f;
                        sizeYS = (float)rect.Height / 2.0f;
                        posXS = (float)rect.Left + sizeXS;
                        posYS = (float)rect.Top + sizeYS;

                        _Engine.addSprite(shapeName, posXS, posYS, sizeXS, sizeYS, 0.0f, 0.0f, 0.0f, spriteType.INACTIVE);
                        return "True";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "False";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                success = method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return;
            }

            return;
        }

        /// <summary>
        /// Add a new small, transparent and high density shape to be used as a moving anchor point.
        /// </summary>
        /// <param name="posX">
        /// The X coordinate of the anchor.
        /// </param>
        /// <param name="posY">
        /// The Y coordinate of the anchor.
        /// </param>
        /// <returns>
        /// The anchor shape name.
        /// </returns>
        public static Primitive AddMovingAnchor(Primitive posX, Primitive posY)
        {
            return _Engine.addAnchor(posX, posY, spriteType.MOVING);
        }

        /// <summary>
        /// Add an existing SmallBasic shape to the physics engine as a moving (dynamic) shape.
        /// </summary>
        /// <param name="shapeName">
        /// The name of the shape.
        /// </param>
        /// <param name="friction">
        /// The shape friction (usually 0 to 1).
        /// </param>
        /// <param name="restitution">
        /// The shape restitution or bounciness (usually 0 to 1).
        /// If a negative value is set for restitution, then the shape will be added with a very small size which may be used to add an inactive image that can be grouped within an irregular compound shape that matches the image boundary.
        /// </param>
        /// <param name="density">
        /// The shape density (default 1).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void AddMovingShape(Primitive shapeName, Primitive friction, Primitive restitution, Primitive density)
        {
            float posXS, posYS, sizeXS, sizeYS;
            string success;

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Utilities.doUpdates();
            Shapes.Rotate(shapeName, _Engine.getShapeAngle(shapeName)); // Create the SB transform
            Utilities.doUpdates();

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Rect rect = new Rect(obj.RenderSize);
                        rect.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj));

                        if (obj.GetType() == typeof(Polygon))
                        {
                            sizeXS = 0;
                            sizeYS = 0;
                            posXS = 0;
                            posYS = 0;
                            Polygon polygon = (Polygon)obj;
                            foreach (Point point in polygon.Points)
                            {
                                posXS += (float)point.X;
                                posYS += (float)point.Y;
                            }
                            posXS /= (float)polygon.Points.Count;
                            posYS /= (float)polygon.Points.Count;
                        }
                        else
                        {
                            sizeXS = (float)rect.Width / 2.0f;
                            sizeYS = (float)rect.Height / 2.0f;
                            posXS = (float)rect.Left + sizeXS;
                            posYS = (float)rect.Top + sizeYS;
                        }

                        _Engine.addSprite(shapeName, posXS, posYS, sizeXS, sizeYS, friction, restitution, density, spriteType.MOVING);
                        return "True";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "False";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                success = method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return;
            }

            return;
        }

        /// <summary>
        /// Add a rope between two existing shapes.
        /// </summary>
        /// <param name="shape1">
        /// First shape.
        /// </param>
        /// <param name="shape2">
        /// Second shape.
        /// </param>
        /// <returns>
        /// The rope name.
        /// </returns>
        public static Primitive AddRope(Primitive shape1, Primitive shape2)
        {
            return _Engine.addChain(shape1, shape2, false);
        }

        /// <summary>
        /// Connect two shapes to move together as one.
        /// </summary>
        /// <param name="shape1">
        /// The first shape name.
        /// </param>
        /// <param name="shape2">
        /// The second shape name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void AttachShapes(Primitive shape1, Primitive shape2)
        {
            _Engine.attachSprites(shape1, shape2, true, false);
        }
        
        /// <summary>
        /// Connect two shapes to move together as one, but allow the shapes to rotate about each other.
        /// </summary>
        /// <param name="shape1">
        /// The first shape name.
        /// </param>
        /// <param name="shape2">
        /// The second shape name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void AttachShapesWithRotation(Primitive shape1, Primitive shape2)
        {
            _Engine.attachSprites(shape1, shape2, true, true);
        }

        /// <summary>
        /// Disconnect two shapes that were previously attached.
        /// </summary>
        /// <param name="shape1">
        /// The first shape name.
        /// </param>
        /// <param name="shape2">
        /// The second shape name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void DetachShapes(Primitive shape1, Primitive shape2)
        {
            _Engine.attachSprites(shape1, shape2, false, false);
        }

        /// <summary>
        /// Disconnect shape from the physics engine without deleting the shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void DisconnectShape(Primitive shapeName)
        {
            _Engine.disconnectSprite(shapeName);
        }

        /// <summary>
        /// Perform a time-step update.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void DoTimestep()
        {
            _Engine.doTimestep();
        }

        /// <summary>
        /// Get the angle of rotation for the shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// The angle of rotation in degrees.
        /// </returns>
        public static Primitive GetAngle(Primitive shapeName)
        {
            return _Engine.getAngle(shapeName);
        }

        /// <summary>
        /// Reset the angle of rotation for a shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <param name="angle">
        /// The angle of rotation in degrees.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetAngle(Primitive shapeName, Primitive angle)
        {
            _Engine.setAngle(shapeName, angle);
        }

        /// <summary>
        /// Get an array of all the shapes that the specified shape collided with during the last DoTimestep().
        /// </summary>
        /// <param name="shapeName">
        /// The shape to check for collisions.
        /// </param>
        /// <returns>
        /// An array of all the shapes collided with (may be empty "" or "Wall" for a static obstacle).
        /// </returns>
        public static Primitive GetCollisions(Primitive shapeName)
        {
            return _Engine.getCollisions(shapeName);
        }

        /// <summary>
        /// Get the moment of inertia of a shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// The inertia of the shape.
        /// </returns>
        public static Primitive GetInertia(Primitive shapeName)
        {
            return _Engine.getInertia(shapeName);
        }

        /// <summary>
        /// Get the mass of a shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// The mass of the shape.
        /// </returns>
        public static Primitive GetMass(Primitive shapeName)
        {
            return _Engine.getMass(shapeName);
        }

        /// <summary>
        /// Get the centre of the shape coordinates.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// A 2 element array with the shape centre position.
        /// </returns>
        public static Primitive GetPosition(Primitive shapeName)
        {
            float[] pos = new float[2];
            pos = _Engine.getPosition(shapeName);
            return Utilities.CreateArrayMap("1=" + pos[0].ToString(CultureInfo.InvariantCulture) + ";2=" + pos[1].ToString(CultureInfo.InvariantCulture) + ";");
        }

        /// <summary>
        /// Get a list of shapes that collided within a distance of a specified contact point.
        /// </summary>
        /// <param name="x">
        /// The X coordinate of a contact position to check.
        /// </param>
        /// <param name="y">
        /// The Y coordinate of a contact position to check.
        /// </param>
        /// <param name="distance">
        /// A maximum distance from the contact point for the contact.
        /// </param>
        /// <returns>
        /// An array of contacts, with each contact being an array of 2 shape names.
        /// </returns>
        public static Primitive GetContacts(Primitive x, Primitive y, Primitive distance)
        {
            return _Engine.getContacts(x, y, distance);
        }

        /// <summary>
        /// Get the shape rotation speed.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// The angular rotation speed degrees/s.
        /// </returns>
        public static Primitive GetRotation(Primitive shapeName)
        {
            return _Engine.getRotation(shapeName);
        }

        /// <summary>
        /// Get the shape (if any) at the input coordinates.
        /// The coordinates for this method are the screen coordinates if panning is present.
        /// </summary>
        /// <param name="posX">
        /// The X coordinate.
        /// </param>
        /// <param name="posY">
        /// The Y coordinate.
        /// </param>
        /// <returns>
        /// The shape name at the input position or "".
        /// </returns>
        public static Primitive GetShapeAt(Primitive posX, Primitive posY)
        {
            return _Engine.getShapeAt(posX, posY);
        }

        /// <summary>
        /// Get the velocity of the shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// A 2 element array with the shape velocity.
        /// </returns>
        public static Primitive GetVelocity(Primitive shapeName)
        {
            float[] vel = new float[2];
            vel = _Engine.getVelocity(shapeName);
            return Utilities.CreateArrayMap("1=" + vel[0].ToString(CultureInfo.InvariantCulture) + ";2=" + vel[1].ToString(CultureInfo.InvariantCulture) + ";");
        }

        /// <summary>
        /// Solidly group two shapes to move together as one.
        /// </summary>
        /// <param name="shape1">
        /// The first shape name.
        /// </param>
        /// <param name="shape2">
        /// The second shape name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void GroupShapes(Primitive shape1, Primitive shape2)
        {
            _Engine.groupSprites(shape1, shape2, true);
        }

        /// <summary>
        /// This function is just to display this help.
        /// 
        /// The extension uses Box2D (http://box2d.org) as an engine and provides an interface between it and the graphics capabilities of SmallBasic.
        /// 
        /// Only shapes that are connected to the physics engine take part in the motion physics, for example you may add normal shapes (e.g. a gun and not connect it to the physics engine).  Once a shape is connected to the engine, it is best to only interact with it through the methods provided by the extension.  All positions are in the SmallBasic GraphicsWindow pixels and refer to shape centres.
        /// 
        /// Image and text shapes are treated as rectangles, and ellipses as circles; there is also triangle and convex polygon support, but not lines.  Images may be treated as circles by setting the property LoadImagesAsCircles to "True".
        /// 
        /// One issue that Box2D has difficulty with is small fast moving objects that can 'tunnel' through other shapes without being deflected (see the SetBullet option).
        /// 
        /// Another problem is shapes of very different size and hence mass, especially large shapes when they are connected together.  It may be necessary to modify the density for these (the Anchor options are an attempt to automate this a bit), otherwise the default density of 1 is good.  Resist the temptation to connect too many shapes together.
        /// 
        /// It may be possible to improve the stability of some 'difficult' models using the TimestepControl settings, but the defaults look good for most cases.
        /// 
        /// Do not call the physics methods inside SmallBasic event subroutines directly, rather set flags that can be processed in a main game loop.
        /// 
        /// There are sample SmallBasic programs and a Getting Started Guide that comes with the extension dll - this is the best place to start.
        /// 
        /// Report bugs and problems to the SmallBasic forum (http://social.msdn.microsoft.com/Forums/en-US/smallbasic/threads), but first simplify your SmallBasic code to isolate the issue before providing a short 'runnable' code sample.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void Help()
        {
        }

        /// <summary>
        /// Pan the camera view, including window boundaries.
        /// </summary>
        /// <param name="panHorizontal">
        /// Pan in the horizontal direction (negative is left).
        /// </param>
        /// <param name="panVertical">
        /// Pan in the vertical direction (negative is up).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void PanView(Primitive panHorizontal, Primitive panVertical)
        {
            _Engine.panView(panHorizontal, panVertical);
        }

        /// <summary>
        /// Get the current pan offset, see PanView, FollowShapeX(Y) and BoxShape.
        /// World coordinates = screen coordinates + pan offset.
        /// </summary>
        /// <returns>
        /// A 2 element array with the current pan offset.
        /// </returns>
        public static Primitive GetPan()
        {
            float[] pan = new float[2];
            pan = _Engine.getPan();
            return Utilities.CreateArrayMap("1=" + pan[0].ToString(CultureInfo.InvariantCulture) + ";2=" + pan[1].ToString(CultureInfo.InvariantCulture) + ";");
        }

        /// <summary>
        /// Set a shape to remain stationary at X position in the view.
        /// This is similar to PanView, except that the view pans automatically to keep the specified shape at a constant visual X location.
        /// Only one shape can be followed in X direction.  To unset shape following, set the shapeName to "".
        /// </summary>
        /// <param name="shapeName">
        /// The shape to follow or "".
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void FollowShapeX(Primitive shapeName)
        {
            _Engine.setFollowX(shapeName);
        }

        /// <summary>
        /// Set a shape to remain stationary at Y position in the view.
        /// This is similar to PanView, except that the view pans automatically to keep the specified shape at a constant visual Y location.
        /// Only one shape can be followed in Y direction.  To unset shape following, set the shapeName to "".
        /// </summary>
        /// <param name="shapeName">
        /// The shape to follow or "".
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void FollowShapeY(Primitive shapeName)
        {
            _Engine.setFollowY(shapeName);
        }

        /// <summary>
        /// Set a shape to remain within a box within the view.
        /// This is similar to PanView, except that the view pans automatically to keep the specified shape within a box region of the GraphicsWindow.
        /// Only one shape can be boxed.  To unset shape box, set the shapeName to "".
        /// </summary>
        /// <param name="shapeName">The shape to box or "".</param>
        /// <param name="x1">The left x coordinate of the box.</param>
        /// <param name="y1">The top y coordinate of the box.</param>
        /// <param name="x2">The right x coordinate of the box.</param>
        /// <param name="y2">The bottom y coordinate of the box.</param>
        public static void BoxShape(Primitive shapeName, Primitive x1, Primitive y1, Primitive x2, Primitive y2)
        {
            _Engine.setBox(shapeName, x1, y1, x2, y2);
        }

        /// <summary>
        /// Remove a chain.
        /// </summary>
        /// <param name="shapeName">
        /// The chain name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void RemoveChain(Primitive shapeName)
        {
            _Engine.removeChain(shapeName);
        }

        /// <summary>
        /// Removes all frozen shapes - outside the AABB for the engine.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void RemoveFrozen()
        {
            _Engine.deleteFrozen();
        }

        /// <summary>
        /// Remove a rope.
        /// </summary>
        /// <param name="shapeName">
        /// The rope name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void RemoveRope(Primitive shapeName)
        {
            _Engine.removeChain(shapeName);
        }

        /// <summary>
        /// Remove a shape.
        /// </summary>
        /// <param name="shapeName">
        /// The name of the shape.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void RemoveShape(Primitive shapeName)
        {
            _Engine.removeSprite(shapeName);
        }

        /// <summary>
        /// Reset (delete all physics engine attached shapes).
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void Reset()
        {
            _Engine.reset(_Engine.scale, _Engine.minAABBB.X, _Engine.maxAABBB.X, _Engine.minAABBB.Y, _Engine.maxAABBB.Y);
        }

        /// <summary>
        /// The physics engine AABB (axis-aligned bounding box). The units are the engine units of m.  A Reset is required after setting.  It is not recommended to change this.
        /// </summary>
        /// <param name="minX">
        /// The left coordinate of the universe (default -100).
        /// </param>
        /// <param name="maxX">
        /// The right coordinate of the universe (default 200).
        /// </param>
        /// <param name="minY">
        /// The top coordinate of the universe (default -100).
        /// </param>
        /// <param name="maxY">
        /// The bottom coordinate of the universe (default 200).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetAABB(Primitive minX, Primitive maxX, Primitive minY, Primitive maxY)
        {
            _Engine.minAABBB.X = minX;
            _Engine.maxAABBB.X = maxX;
            _Engine.minAABBB.Y = minY;
            _Engine.maxAABBB.Y = maxY;
        }

        /// <summary>
        /// Set solid boundaries (positioning a boundary outside the GraphicsWindow removes it).
        /// </summary>
        /// <param name="left">
        /// The left boundary X value.
        /// </param>
        /// <param name="right">
        /// The right boundary X value.
        /// </param>
        /// <param name="top">
        /// The top boundary Y value.
        /// </param>
        /// <param name="bottom">
        /// The bottom (ground) boundary Y value.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetBoundaries(Primitive left, Primitive right, Primitive top, Primitive bottom)
        {
            _Engine.setBoundaries(left, right, top, bottom);
        }

        /// <summary>
        /// Set a shape as a bullet.  This prevents 'tunnelling' of fast moving small objects at the expense of performance.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetBullet(Primitive shapeName)
        {
            _Engine.setBullet(shapeName, true);
        }

        /// <summary>
        /// Set a damping factor for a shape (default 0).
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="linear">
        /// Linear damping factor.
        /// </param>
        /// <param name="angular">
        /// Angular damping factor.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetDamping(Primitive shapeName, Primitive linear, Primitive angular)
        {
            _Engine.setDamping(shapeName, linear, angular);
        }

        /// <summary>
        /// Set a force to apply to a shape (Remember F = ma).
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="forceX">
        /// X component of the force.
        /// </param>
        /// <param name="forceY">
        /// Y component of the force.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetForce(Primitive shapeName, Primitive forceX, Primitive forceY)
        {
            _Engine.setForce(shapeName, forceX, forceY);
        }

        /// <summary>
        /// Control which sprites interact (collide) with other shapes.
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="group">
        /// The group that the current shape belongs to (default 0).  This should be an integer between 0 and 7.
        /// </param>
        /// <param name="mask">
        /// An array of groups that this shape will collide with (default all groups).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetGroup(Primitive shapeName, Primitive group, Primitive mask)
        {
            ushort groupBits = (ushort)System.Math.Pow(2, group);
            ushort maskBits = 0;
            if (SBArray.IsArray(mask))
            {
                Primitive indices = SBArray.GetAllIndices(mask);
                for (int i = 1; i <= SBArray.GetItemCount(mask); i++)
                {
                    maskBits += (ushort)System.Math.Pow(2, mask[indices[i]]);
                }
            }
            else
            {
                maskBits += (ushort)System.Math.Pow(2, mask);
            }
            _Engine.setGroup(shapeName, groupBits, maskBits);
        }

        /// <summary>
        /// Set the gravity direction and magnitude (default 0,100).
        /// </summary>
        /// <param name="gravX">
        /// The X component of gravity.
        /// </param>
        /// <param name="gravY">
        /// The Y component of gravity.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetGravity(Primitive gravX, Primitive gravY)
        {
            _Engine.setGravity(gravX, gravY);
        }

        /// <summary>
        /// Set the gravity direction and magnitude for an individual shape (default 0,100).
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="gravX">
        /// The X component of gravity.
        /// </param>
        /// <param name="gravY">
        /// The Y component of gravity.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetShapeGravity(Primitive shapeName, Primitive gravX, Primitive gravY)
        {
            _Engine.setGravity(shapeName, gravX, gravY);
        }

        /// <summary>
        /// Set an impulse to a shape (a kick).
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="impulseX">
        /// X component of the impulse.
        /// </param>
        /// <param name="impulseY">
        /// Y component of the impulse.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetImpulse(Primitive shapeName, Primitive impulseX, Primitive impulseY)
        {
            _Engine.setImpulse(shapeName, impulseX, impulseY);
        }

        /// <summary>
        /// Reset shape position.
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="posX">
        /// X component shape centre.
        /// </param>
        /// <param name="posY">
        /// Y component shape centre.
        /// </param>
        /// <param name="angle">
        /// The angle of rotation in degrees.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetPosition(Primitive shapeName, Primitive posX, Primitive posY, Primitive angle)
        {
            _Engine.setPosition(shapeName, posX, posY, angle);
        }

        /// <summary>
        /// Set shape rotation speed.
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="rotation">
        /// The angular rotation speed degrees/s.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetRotation(Primitive shapeName, Primitive rotation)
        {
            _Engine.setRotation(shapeName, rotation);
        }

        /// <summary>
        /// Set a torque to a shape (a rotational kick).
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="torque">
        /// The torque to apply.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetTorque(Primitive shapeName, Primitive torque)
        {
            _Engine.setTorque(shapeName, torque);
        }

        /// <summary>
        /// Set the velocity of a shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape to modify.
        /// </param>
        /// <param name="velX">
        /// X component of the velocity.
        /// </param>
        /// <param name="velY">
        /// Y component of the velocity.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetVelocity(Primitive shapeName, Primitive velX, Primitive velY)
        {
            _Engine.setVelocity(shapeName, velX, velY);
        }

        /// <summary>
        /// Modify default timestep control parameters - also can be set using individual parameters.
        /// </summary>
        /// <param name="timestep">
        /// Time-step (default 0.025).
        /// </param>
        /// <param name="velocityIterations">
        /// Velocity iterations (default 6).
        /// </param>
        /// <param name="positionIterations">
        /// Position iterations (default 2).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void TimestepControl(Primitive timestep, Primitive velocityIterations, Primitive positionIterations)
        {
            _Engine.timeStep = timestep;
            _Engine.velocityIterations = velocityIterations;
            _Engine.positionIterations = positionIterations;
        }

        /// <summary>
        /// Remove shape group pairing.
        /// </summary>
        /// <param name="shape1">
        /// The first shape name.
        /// </param>
        /// <param name="shape2">
        /// The second shape name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void UngroupShapes(Primitive shape1, Primitive shape2)
        {
            _Engine.groupSprites(shape1, shape2, false);
        }

        /// <summary>
        /// Unset a shape as a bullet.  This reverts the shape to normal collision detection.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void UnsetBullet(Primitive shapeName)
        {
            _Engine.setBullet(shapeName, false);
        }

        /// <summary>
        /// Set an object to act as a drivable tire for a top down game.
        /// Usually gravity will be 0 and the shape should already be added to the engine.
        /// The object should be initially positioned facing forward up on the display.
        /// </summary>
        /// <param name="shapeName">The shape to make a tire.</param>
        public static void SetTire(Primitive shapeName)
        {
            _Engine.setTire(shapeName);
        }

        /// <summary>
        /// Move a tire shape, apply a forward or backward force.
        /// </summary>
        /// <param name="shapeName">The tire shape to move.</param>
        /// <param name="force">The force to apply, positive is forward, negative is backward.</param>
        public static void MoveTire(Primitive shapeName, Primitive force)
        {
            _Engine.moveTire(shapeName, force);
        }

        /// <summary>
        /// Apply a brake to a tire shape.
        /// </summary>
        /// <param name="shapeName">The tire shape to brake.</param>
        public static void BrakeTire(Primitive shapeName)
        {
            _Engine.brakeTire(shapeName);
        }

        /// <summary>
        /// Turn a tire shape, steer left or right.
        /// </summary>
        /// <param name="shapeName">The tire shape to turn.</param>
        /// <param name="torque">The torque, rotation force to apply, positive is turn right, negative is turn left.</param>
        public static void TurnTire(Primitive shapeName, Primitive torque)
        {
            _Engine.turnTire(shapeName, torque);
        }

        /// <summary>
        /// Get tire properties, they include:
        /// 
        /// AntiSkid (higher value reduces skid)
        /// Drag (higher value increases forward/backward drag)
        /// Brake (higher value increases braking power)
        /// Straighten (higher value restores steering more quickly)
        /// BrakeStraighten (higher value restores steering more quickly while braking)
        /// </summary>
        /// <param name="shapeName">The tire shape.</param>
        /// <returns>An array of properties, indexed by the property name, e.g. "AntiSkid".</returns>
        public static Primitive GetTireProperties(Primitive shapeName)
        {
            try
            {
                Dictionary<string, float> propeties = _Engine.getTireProperties(shapeName);
                string result = "";
                if (null != propeties)
                {
                    foreach(KeyValuePair<string, float> property in propeties)
                    {
                        result += Utilities.ArrayParse(property.Key) + "=" + property.Value + ";";
                    }
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set tire properties, they include:
        /// 
        /// AntiSkid (higher value reduces skid)
        /// Drag (higher value increases forward/backward drag)
        /// Brake (higher value increases braking power)
        /// Straighten (higher value restores stearing more quickly)
        /// BrakeStraighten (higher value restores stearing more quickly while braking)
        /// </summary>
        /// <param name="shapeName">The tire shape.</param>
        /// <param name="properties">An array of one or more properties to set.
        /// The index is one of the properties (case sensitive) and the value is the property value.</param>
        public static void SetTireProperties(Primitive shapeName, Primitive properties)
        {
            try
            {
                Dictionary<string, float> _propeties = new Dictionary<string, float>();
                Primitive indices = SBArray.GetAllIndices(properties);
                for (int i = 1; i <= SBArray.GetItemCount(indices); i++ )
                {
                    _propeties[indices[i]] = properties[indices[i]];
                }
                _Engine.setTireProperties(shapeName, _propeties);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get tire information, it includes:
        /// 
        /// Skid (if this value exceeds the property AntiSkid, then the tire is skidding)
        /// Crash (the value is the speed of the impact)
        /// </summary>
        /// <param name="shapeName">The tire shape.</param>
        /// <returns>An array of information, indexed by the information name, e.g. "Skid".</returns>
        public static Primitive GetTireInformation(Primitive shapeName)
        {
            try
            {
                Dictionary<string, float> information = _Engine.getTireInformation(shapeName);
                string result = "";
                if (null != information)
                {
                    foreach (KeyValuePair<string, float> property in information)
                    {
                        result += Utilities.ArrayParse(property.Key) + "=" + property.Value + ";";
                    }
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Make an explosion, which consists of 50x20kg particles blast apart over 500ms.
        /// </summary>
        /// <param name="posX">The X coordinate of the explosion.</param>
        /// <param name="posY">The Y coordinate of the explosion.</param>
        /// <param name="power">The explosion force, this is the initial velocity of the blast particles.</param>
        /// <param name="damping">A damping for the blast, the smaller this value the larger the blast range (default 10).</param>
        /// <param name="colour">An optional colour of the explosion particles ("" for none).</param>
        public static void AddExplosion(Primitive posX, Primitive posY, Primitive power, Primitive damping, Primitive colour)
        {
            _Engine.addExplosion(posX, posY, power, damping, colour);
        }

        /// <summary>
        /// Toggle a moving shape to be fixed and vice-versa.
        /// This method also sets the rotation to be on or off to match if it is moving or fixed.
        /// </summary>
        /// <param name="shapeName">The shape name.</param>
        public static void ToggleMoving(Primitive shapeName)
        {
            _Engine.toggleMoving(shapeName);
        }

        /// <summary>
        /// Toggle a shape to not rotate and vice-versa.
        /// This method toggles the rotation property for fixed and moving shapes.
        /// </summary>
        /// <param name="shapeName">The shape name.</param>
        public static void ToggleRotation(Primitive shapeName)
        {
            _Engine.toggleRotation(shapeName);
        }

        /// <summary>
        /// Connect two shapes to move together as one with one of several joint types.
        /// These can be advanced and require reference to Box2D manual.
        /// In many cases it is best to prevent shape rotation for the joints to behave as desired.
        /// Multiple joints may also be applied to shapes.
        /// The methods use the initial shape positions, so set these first.
        /// </summary>
        /// <param name="shape1">The first shape name.</param>
        /// <param name="shape2">The second shape name.</param>
        /// <param name="type">One of the following joint types.
        /// 
        /// "Distance" - maintain a fixed distance between the shapes.
        /// "Gear" - link Prismatic or Revolute joints (previously created) of 2 shapes.
        /// "Line" - move the shapes along a line initially connecting the shapes.
        /// "Mouse" - move the shape to follow the mouse (both shape names should be the same).
        /// "Prismatic_H" - move shapes vertically along a line between the two shapes.
        /// "Prismatic_V" - move shapes horizontally along a line between the two shapes.
        /// "Pulley" - a pulley system, one shape moves up as the other moves down - position the shapes initially at the extreme points of the pulley motion.
        /// "Revolute" - the shapes can rotate about each other.
        /// </param>
        /// <param name="collide">The connected shapes can interact with each other "True" or "False" (default).
        /// </param>
        /// <param name="parameters">Optional parameters (default ""), multiple parameters are in an array.
        ///
        /// "Distance" - damping ratio (default 0)
        /// "Gear" - gear ratio, first joint, second joint (default 1, auto detect joints)
        /// "Line" - X direction, Y direction, lower translation, upper translation (default line connecting shapes, no limits)
        /// "Mouse" - max acceleration, damping ratio (default 10000, 0.7)
        /// "Prismatic_H" - X direction, Y direction, lower translation, upper translation (default 1,0, no limits)
        /// "Prismatic_V" - X direction, Y direction, lower translation, upper translation  (default 0,1, no limits)
        /// "Pulley" - pulley ratio (block and tackle) (default 1)
        /// "Revolute" - lower angle, upper angle (default no limits)
        /// </param>
        /// <returns>
        /// The joint name.
        /// </returns>
        public static Primitive AttachShapesWithJoint(Primitive shape1, Primitive shape2, Primitive type, Primitive collide, Primitive parameters)
        {
            try
            {
                List<Primitive> param = new List<Primitive>();
                if (SBArray.IsArray(parameters))
                {
                    Primitive indices = SBArray.GetAllIndices(parameters);
                    for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                    {
                        param.Add(parameters[indices[i]]);
                    }
                }
                else if (parameters != "")
                {
                    param.Add(parameters);
                }

                string jointName = "";
                switch (((string)type).ToLower())
                {
                    case "distance":
                        jointName = _Engine.joinSprites(shape1, shape2, joinType.DISTANCE, collide, param);
                        break;
                    case "gear":
                        jointName = _Engine.joinSprites(shape1, shape2, joinType.GEAR, collide, param);
                        break;
                    case "line":
                        jointName = _Engine.joinSprites(shape1, shape2, joinType.LINE, collide, param);
                        break;
                    case "mouse":
                        jointName = _Engine.joinSprites(shape1, shape2, joinType.MOUSE, collide, param);
                        break;
                    case "prismatic_h":
                        jointName = _Engine.joinSprites(shape1, shape2, joinType.PRISMATIC_H, collide, param);
                        break;
                    case "prismatic_v":
                        jointName = _Engine.joinSprites(shape1, shape2, joinType.PRISMATIC_V, collide, param);
                        break;
                    case "pulley":
                        jointName = _Engine.joinSprites(shape1, shape2, joinType.PULLEY, collide, param);
                        break;
                    case "revolute":
                        jointName = _Engine.joinSprites(shape1, shape2, joinType.REVOLUTE, collide, param);
                        break;
                }
                return jointName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Disconnect two shapes that were previously joined with a joint.
        /// </summary>
        /// <param name="jointName">
        /// The joint name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void DetachJoint(Primitive jointName)
        {
            _Engine.detachJoint(jointName);
        }

        /// <summary>
        /// Set a motor for selected joints (Line, Prismatic_H, Prismatic_V and Revolute).
        /// </summary>
        /// <param name="jointName">
        /// The joint name.
        /// </param>
        /// <param name="speed">The desired motor speed.</param>
        /// <param name="maxForce">The maximum motor force (torque for Revolute).
        /// A zero value turns motor off.</param>
        public static void SetJointMotor(Primitive jointName, Primitive speed, Primitive maxForce)
        {
            _Engine.setJointMotor(jointName, speed, maxForce);
        }

        /// <summary>
        /// Wake all sleeping shapes - shapes sleep due to no applied forces or contacts.  They wake automatically on any contact or applied force, so this action is rarely required.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void WakeAll()
        {
            _Engine.wakeAll();
        }
    }
}
