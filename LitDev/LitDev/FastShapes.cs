//#define SVB
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2020> litdev@hotmail.co.uk
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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using LitDev.Engines;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LitDev
{
    class ShapeProperty
    {
        public UIElement obj;
        public RotateTransform rotateTransform;
        public ScaleTransform scaleTransform;

        public Point point;
        public double opacity = 1;
        public double angle = 0;
        public System.Windows.Vector scale = new System.Windows.Vector(1,1);
        public Visibility visibility = Visibility.Visible;

        public bool modified = false;

        public ShapeProperty(UIElement obj, RotateTransform rotateTransform, ScaleTransform scaleTransform, Point point)
        {
            this.obj = obj;
            this.rotateTransform = rotateTransform;
            this.scaleTransform = scaleTransform;
            this.point = point;
        }
    }

    /// <summary>
    /// Shape methods which are faster than standard Small Basic Shape operations.
    /// This is primarily for shape movement when there are a large number of shapes updated in a game loop.
    /// Only the main Shapes commands are supported since these are the ones that are commonly repeated many times.
    /// The shape must first be created, then registered (ShapeIndex) and the returned integer index used with the other methods.
    /// The visual update of the changes made does not happen until (Update) is called when all changes are processed together.
    /// Performance improvements come from both integer indexing and batch update.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDFastShapes
    {
        private static Type GraphicsWindowType = typeof(GraphicsWindow);
        private static List<ShapeProperty> shapeProperties = new List<ShapeProperty>();
        private static Canvas _mainCanvas = null;
        private static Dictionary<string, UIElement> _objectsMap = null;
        private static Dictionary<string, RotateTransform> _rotateTransformMap = null;
        private static Dictionary<string, ScaleTransform> _scaleTransformMap = null;
        private static Dictionary<string, Point> _positionMap = null;

        /// <summary>
        /// Register a shape for use with this object.
        /// This command is potentially slow, so should be called before time critical visual updates occur.
        /// i.e. Create and register all shapes before motion is simulated.
        /// </summary>
        /// <param name="shapeName">The name of the created shape.</param>
        /// <returns>
        /// An index to use in the other methods in this object.
        /// The index is an integer starting at 1, incremented for each shape registered.
        /// -1 for an error.
        /// </returns>
        public static Primitive ShapeIndex(Primitive shapeName)
        {
            Type ShapesType = typeof(Shapes);
            UIElement obj;
            RotateTransform rotateTransform;
            ScaleTransform scaleTransform;
            Point point;

            try
            {
                if (null == _mainCanvas) _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (null == _objectsMap) _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (null == _rotateTransformMap) _rotateTransformMap = (Dictionary<string, RotateTransform>)ShapesType.GetField("_rotateTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (null == _scaleTransformMap) _scaleTransformMap = (Dictionary<string, ScaleTransform>)ShapesType.GetField("_scaleTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (null == _positionMap) _positionMap = (Dictionary<string, Point>)ShapesType.GetField("_positionMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return -1;
                }
                if (!_rotateTransformMap.TryGetValue((string)shapeName, out rotateTransform))
                {
                    Shapes.Rotate(shapeName, 0);
                    Utilities.doUpdates();
                    if (!_rotateTransformMap.TryGetValue((string)shapeName, out rotateTransform)) return -1;
                }
                if (!_scaleTransformMap.TryGetValue((string)shapeName, out scaleTransform))
                {
                    Shapes.Zoom(shapeName, 1, 1);
                    Utilities.doUpdates();
                    if (!_scaleTransformMap.TryGetValue((string)shapeName, out scaleTransform)) return -1;
                }
                if (!_positionMap.TryGetValue((string)shapeName, out point))
                {
                    Shapes.Move(shapeName, 0, 0);
                    Utilities.doUpdates();
                    if (!_positionMap.TryGetValue((string)shapeName, out point)) return -1;
                }

                ShapeProperty shapeProperty = new ShapeProperty(obj, rotateTransform, scaleTransform, point);
                shapeProperties.Add(shapeProperty);
                return shapeProperties.Count;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return -1;  
        }

        private static void Update_Delegate()
        {
            try
            {
                foreach (ShapeProperty shape in shapeProperties)
                {
                    if (shape.modified)
                    {
                        Canvas.SetLeft(shape.obj, shape.point.X);
                        Canvas.SetTop(shape.obj, shape.point.Y);
                        shape.obj.Opacity = shape.opacity;
                        shape.rotateTransform.Angle = shape.angle;
                        shape.scaleTransform.ScaleX = shape.scale.X;
                        shape.scaleTransform.ScaleY = shape.scale.Y;
                        shape.obj.Visibility = shape.visibility;
                        shape.modified = false;
                    }
                }
                if (null != _mainCanvas) _mainCanvas.InvalidateVisual();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
        /// <summary>
        /// Update all of the properties of shapes set by this object that have been modifed since the last update.
        /// The shapes are not visually updated until this method is called.
        /// </summary>
        public static void Update()
        {
            FastThread.BeginInvoke(Update_Delegate);
        }

        /// <summary>
        /// Moves the shape with the specified name to a new position.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape to move.
        /// </param>
        /// <param name="x">
        /// The x co-ordinate of the new position.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the new position.
        /// </param>
        public static void Move(Primitive index, Primitive x, Primitive y)
        {
            try
            {
                shapeProperties[index - 1].point.X = x;
                shapeProperties[index - 1].point.Y = y;
                shapeProperties[index - 1].modified = true;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Gets the left co-ordinate of the specified shape.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape.
        /// </param>
        /// <returns>
        /// The left co-ordinate of the shape.
        /// </returns>
        public static Primitive GetLeft(Primitive index)
        {
            try
            {
                return shapeProperties[index - 1].point.X;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Gets the top co-ordinate of the specified shape.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape.
        /// </param>
        /// <returns>
        /// The top co-ordinate of the shape.
        /// </returns>
        public static Primitive GetTop(Primitive index)
        {
            try
            {
                return shapeProperties[index - 1].point.Y;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Sets how opaque a shape should render.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape.
        /// </param>
        /// <param name="level">
        /// The opacity level ranging from 0 to 100.  0 is completely transparent and 100 is completely opaque.
        /// </param>
        public static void SetOpacity(Primitive index, Primitive level)
        {
            try
            {
                shapeProperties[index - 1].opacity = level / 100.0;
                shapeProperties[index - 1].modified = true;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Gets the opacity of a shape.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape.
        /// </param>
        /// <returns>
        /// The opacity of the object as a value between 0 and 100.  0 is completely transparent and 100 is completely opaque.
        /// </returns>
        public static Primitive GetOpacity(Primitive index)
        {
            try
            {
                return shapeProperties[index - 1].opacity * 100;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 100;
        }

        /// <summary>
        /// Rotates the shape with the specified name to the specified angle.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape.
        /// </param>
        /// <param name="angle">
        /// The angle to rotate the shape.
        /// </param>
        public static void Rotate(Primitive index, Primitive angle)
        {
            try
            {
                shapeProperties[index - 1].angle = angle;
                shapeProperties[index - 1].modified = true;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Scales the shape using the specified zoom levels.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape.
        /// </param>
        /// <param name="scaleX">
        /// The x-axis zoom level.
        /// </param>
        /// <param name="scaleY">
        /// The y-axis zoom level.
        /// </param>
        public static void Zoom(Primitive index, Primitive scaleX, Primitive scaleY)
        {
            try
            {
                shapeProperties[index - 1].scale.X = scaleX;
                shapeProperties[index - 1].scale.Y = scaleY;
                shapeProperties[index - 1].modified = true;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Hides an already added shape.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape.
        /// </param>
        public static void HideShape(Primitive index)
        {
            try
            {
                shapeProperties[index - 1].visibility = Visibility.Collapsed;
                shapeProperties[index - 1].modified = true;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Shows a previously hidden shape.
        /// </summary>
        /// <param name="index">
        /// The index (returned by ShapeIndex) of the shape.
        /// </param>
        public static void ShowShape(Primitive index)
        {
            try
            {
                shapeProperties[index - 1].visibility = Visibility.Visible;
                shapeProperties[index - 1].modified = true;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }
}
