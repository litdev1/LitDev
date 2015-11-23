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
using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows;
using System.Reflection;
using Microsoft.SmallBasic.Library.Internal;
using Microsoft.Expression.Shapes;
using Microsoft.Expression.Controls;
using SBArray = Microsoft.SmallBasic.Library.Array;
using System.Windows.Media;

namespace LitDev
{
    /// <summary>
    /// Some additional shapes like callouts, arcs and arrows.
    /// </summary>
    [SmallBasicType]
    public static class LDFigures
    {
        private enum eFigure { NONE, ARC, BLOCKARROW, REGULARPOLYGON, CALLOUT, LINEARROW };

        private static void ExtractDll()
        {
            try
            {
                string filename = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Microsoft.Expression.Drawing.dll";
                if (!System.IO.File.Exists(filename))
                {
                    Byte[] dll = global::LitDev.Properties.Resources.Microsoft_Expression_Drawing;
                    using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                    {
                        fs.Write(dll, 0, dll.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static string AddFigure(eFigure figure, double width, double height, Primitive[] properties)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                ExtractDll();

                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Figure" }).ToString();

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        switch (figure)
                        {
                            case eFigure.ARC:
                                {
                                    Arc shape = new Arc();
                                    shape.Name = shapeName;
                                    shape.Width = width;
                                    shape.Height = height;
                                    _objectsMap[shapeName] = shape;
                                    _mainCanvas.Children.Add(shape);

                                    shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.BrushColor));
                                    shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.PenColor));
                                    shape.StrokeThickness = GraphicsWindow.PenWidth;

                                    shape.StartAngle = properties[0];
                                    shape.EndAngle = properties[1];
                                    shape.ArcThickness = properties[2];
                                    shape.ArcThicknessUnit = Microsoft.Expression.Media.UnitType.Pixel;
                                }
                                break;
                            case eFigure.BLOCKARROW:
                                {
                                    BlockArrow shape = new BlockArrow();
                                    shape.Name = shapeName;
                                    shape.Width = width;
                                    shape.Height = height;
                                    _objectsMap[shapeName] = shape;
                                    _mainCanvas.Children.Add(shape);

                                    shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.BrushColor));
                                    shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.PenColor));
                                    shape.StrokeThickness = GraphicsWindow.PenWidth;

                                    shape.ArrowBodySize = properties[0];
                                    shape.ArrowheadAngle = properties[1];
                                    switch (((string)properties[2]).ToLower())
                                    {
                                        case "up":
                                            shape.Orientation = Microsoft.Expression.Media.ArrowOrientation.Up;
                                            break;
                                        case "down":
                                            shape.Orientation = Microsoft.Expression.Media.ArrowOrientation.Down;
                                            break;
                                        case "left":
                                            shape.Orientation = Microsoft.Expression.Media.ArrowOrientation.Left;
                                            break;
                                        case "right":
                                            shape.Orientation = Microsoft.Expression.Media.ArrowOrientation.Right;
                                            break;
                                    }
                                }
                                break;
                            case eFigure.REGULARPOLYGON:
                                {
                                    RegularPolygon shape = new RegularPolygon();
                                    shape.Name = shapeName;
                                    shape.Width = width;
                                    shape.Height = height;
                                    _objectsMap[shapeName] = shape;
                                    _mainCanvas.Children.Add(shape);

                                    shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.BrushColor));
                                    shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.PenColor));
                                    shape.StrokeThickness = GraphicsWindow.PenWidth;

                                    shape.PointCount = properties[0];
                                    shape.InnerRadius = properties[1];
                                }
                                break;
                            case eFigure.CALLOUT:
                                {
                                    Callout shape = new Callout();
                                    shape.Name = shapeName;
                                    shape.Width = width;
                                    shape.Height = height;
                                    _objectsMap[shapeName] = shape;
                                    _mainCanvas.Children.Add(shape);

                                    shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.BrushColor));
                                    shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.PenColor));
                                    shape.StrokeThickness = GraphicsWindow.PenWidth;
                                    shape.FontFamily = new FontFamily(GraphicsWindow.FontName);
                                    shape.FontSize = GraphicsWindow.FontSize;
                                    shape.FontStyle = GraphicsWindow.FontItalic ? FontStyles.Italic : FontStyles.Normal;
                                    shape.FontWeight = GraphicsWindow.FontBold ? FontWeights.Bold : FontWeights.Normal;
                                    shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.PenColor));
                                    shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.BrushColor));

                                    shape.Content = properties[0];
                                    switch (((string)properties[1]).ToLower())
                                    {
                                        case "cloud":
                                            shape.CalloutStyle = Microsoft.Expression.Media.CalloutStyle.Cloud;
                                            break;
                                        case "oval":
                                            shape.CalloutStyle = Microsoft.Expression.Media.CalloutStyle.Oval;
                                            break;
                                        case "rectangle":
                                            shape.CalloutStyle = Microsoft.Expression.Media.CalloutStyle.Rectangle;
                                            break;
                                        case "roundedrectangle":
                                            shape.CalloutStyle = Microsoft.Expression.Media.CalloutStyle.RoundedRectangle;
                                            break;
                                    }
                                    Primitive anchor = properties[2];
                                    Point point = new Point(0,1.25);
                                    if (SBArray.GetItemCount(anchor) == 2)
                                    {
                                        Primitive indices = SBArray.GetAllIndices(anchor);
                                        point.X = anchor[indices[1]];
                                        point.Y = anchor[indices[2]];
                                    }
                                    shape.AnchorPoint = point;
                                }
                                break;
                            case eFigure.LINEARROW:
                                {
                                    LineArrow shape = new LineArrow();
                                    shape.Name = shapeName;
                                    shape.Width = width;
                                    shape.Height = height;
                                    _objectsMap[shapeName] = shape;
                                    _mainCanvas.Children.Add(shape);

                                    shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.BrushColor));
                                    shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.PenColor));
                                    shape.StrokeThickness = GraphicsWindow.PenWidth;

                                    shape.ArrowSize = properties[0];
                                    shape.BendAmount = properties[1];
                                    switch (((string)properties[2]).ToLower())
                                    {
                                        case "none":
                                            shape.StartArrow = Microsoft.Expression.Media.ArrowType.NoArrow;
                                            break;
                                        case "arrow":
                                            shape.StartArrow = Microsoft.Expression.Media.ArrowType.Arrow;
                                            break;
                                        case "open":
                                            shape.StartArrow = Microsoft.Expression.Media.ArrowType.OpenArrow;
                                            break;
                                        case "oval":
                                            shape.StartArrow = Microsoft.Expression.Media.ArrowType.OvalArrow;
                                            break;
                                        case "stealth":
                                            shape.StartArrow = Microsoft.Expression.Media.ArrowType.StealthArrow;
                                            break;
                                    }
                                    switch (((string)properties[3]).ToLower())
                                    {
                                        case "none":
                                            shape.EndArrow = Microsoft.Expression.Media.ArrowType.NoArrow;
                                            break;
                                        case "arrow":
                                            shape.EndArrow = Microsoft.Expression.Media.ArrowType.Arrow;
                                            break;
                                        case "open":
                                            shape.EndArrow = Microsoft.Expression.Media.ArrowType.OpenArrow;
                                            break;
                                        case "oval":
                                            shape.EndArrow = Microsoft.Expression.Media.ArrowType.OvalArrow;
                                            break;
                                        case "stealth":
                                            shape.EndArrow = Microsoft.Expression.Media.ArrowType.StealthArrow;
                                            break;
                                    }
                                    switch (((string)properties[4]).ToLower())
                                    {
                                        case "bottomleft":
                                            shape.StartCorner = Microsoft.Expression.Media.CornerType.BottomLeft;
                                            break;
                                        case "bottomright":
                                            shape.StartCorner = Microsoft.Expression.Media.CornerType.BottomRight;
                                            break;
                                        case "topleft":
                                            shape.StartCorner = Microsoft.Expression.Media.CornerType.TopLeft;
                                            break;
                                        case "topright":
                                            shape.StartCorner = Microsoft.Expression.Media.CornerType.TopRight;
                                            break;
                                    }
                                }
                                break;
                        }
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Add an arc shape.
        /// </summary>
        /// <param name="width">The width of the shape.</param>
        /// <param name="height">The height of the shape.</param>
        /// <param name="startAngle">The starting angle in degrees.</param>
        /// <param name="endAngle">The ending angle in degrees.</param>
        /// <param name="thickness">The thickness of the arc in pixels.</param>
        /// <returns>The shape name.</returns>
        public static Primitive AddArc(Primitive width, Primitive height, Primitive startAngle, Primitive endAngle, Primitive thickness)
        {
            return AddFigure(eFigure.ARC, width, height, new Primitive[] { startAngle, endAngle, thickness });
        }

        /// <summary>
        /// Add an block arrow shape.
        /// </summary>
        /// <param name="width">The width of the shape.</param>
        /// <param name="height">The height of the shape.</param>
        /// <param name="thickness">The relative thickness of the arrow shaft, e.g. 0.25.</param>
        /// <param name="arrowAngle">The arrow head angle in degrees.</param>
        /// <param name="direction">The direction of the arrow: "Up", "Down", "Left" or "Right".</param>
        /// <returns>The shape name.</returns>
        public static Primitive AddBlockArrow(Primitive width, Primitive height, Primitive thickness, Primitive arrowAngle, Primitive direction)
        {
            return AddFigure(eFigure.BLOCKARROW, width, height, new Primitive[] { thickness, arrowAngle, direction });
        }

        /// <summary>
        /// Add a callout shape.
        /// </summary>
        /// <param name="width">The width of the shape.</param>
        /// <param name="height">The height of the shape.</param>
        /// <param name="text">The callout text.</param>
        /// <param name="style">The callout style: "Cloud", "Oval", "Rectangle" or "RoundedRectangle".</param>
        /// <param name="anchor">Position of callout anchor relative to the callout size (e.g. "X=0;Y=1.25;")</param>
        /// <returns>The shape name.</returns>
        public static Primitive AddCallout(Primitive width, Primitive height, Primitive text, Primitive style, Primitive anchor)
        {
            return AddFigure(eFigure.CALLOUT, width, height, new Primitive[] { text, style, anchor });
        }

        /// <summary>
        /// Add a line arrow shape.
        /// </summary>
        /// <param name="width">The width of the shape.</param>
        /// <param name="height">The height of the shape.</param>
        /// <param name="size">The size of the arrow head in pixels.</param>
        /// <param name="bend">The arrow bend amount (e.g. 0 is straight, 0.5 is smoothly bending).</param>
        /// <param name="startArrow">The start arrow type: "None", "Arrow", "Open", "Oval" or "Stealth".</param>
        /// <param name="endArrow">The end arrow type: "None", "Arrow", "Open", "Oval" or "Stealth".</param>
        /// <param name="startCorner">The start corner position: "BottomLeft", "BottomRight", "TopLeft" or "TopRight".  The arrow will terminate in the opposite corner.</param>
        /// <returns>The shape name.</returns>
        public static Primitive AddLineArrow(Primitive width, Primitive height, Primitive size, Primitive bend, Primitive startArrow, Primitive endArrow, Primitive startCorner)
        {
            return AddFigure(eFigure.LINEARROW, width, height, new Primitive[] { size, bend, startArrow, endArrow, startCorner });
        }

        /// <summary>
        /// Add a regular polygon shape.
        /// </summary>
        /// <param name="width">The width of the shape.</param>
        /// <param name="height">The height of the shape.</param>
        /// <param name="corners">The number of corners.</param>
        /// <param name="radius">A relative radius for star shapes (e.g. 1 for pentagon, 0.5 for 5 pointed star).</param>
        /// <returns>The shape name.</returns>
        public static Primitive AddRegularPolygon(Primitive width, Primitive height, Primitive corners, Primitive radius)
        {
            return AddFigure(eFigure.REGULARPOLYGON, width, height, new Primitive[] { corners, radius });
        }
    }
}
