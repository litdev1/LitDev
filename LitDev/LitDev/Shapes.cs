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
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    class Animated
    {
        public Image shape;
        public string name;
        public Frame[] frames;
        public int iFrame = -1;
        public bool repeat = true;
        public bool paused = false;
    }

    class Frame
    {
        public int duration;
        public BitmapImage bi;

        public Frame(int _duration, BitmapImage _bi)
        {
            bi = _bi;
            duration = _duration;
        }
    }

    public class GradientBrush
    {
        public string name;
        public Primitive colours;
        public string orientation;
        public BitmapSource img = null;
        public Dictionary<string, Primitive> textData = null;

        public GradientBrush(string _name, Primitive _colours, string _orientation)
        {
            name = _name;
            colours = _colours;
            orientation = _orientation;
        }
        public GradientBrush(string _name, BitmapSource _img)
        {
            name = _name;
            img = _img;
        }
        public GradientBrush(string _name, Dictionary<string, Primitive> _textData)
        {
            name = _name;
            textData = _textData;
        }
        public Brush getBrush()
        {
            try
            {
                if (null != textData)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = textData["Text"];
                    textBlock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textData["BrushColor"]));
                    textBlock.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(textData["PenColor"]));
                    textBlock.FontFamily = new FontFamily(textData["FontName"]);
                    textBlock.FontSize = textData["FontSize"];
                    textBlock.FontWeight = textData["FontBold"] ? FontWeights.Bold : FontWeights.Normal;
                    textBlock.FontStyle = textData["FontItalic"] ? FontStyles.Italic : FontStyles.Normal;
                    //textBlock.Width = 100;
                    //textBlock.Height = 100;
                    VisualBrush visualBrush = new VisualBrush(textBlock);
                    return visualBrush;

                    //DrawingGroup group = new DrawingGroup();
                    //DrawingContext dc = group.Open();
                    //dc.DrawRectangle(
                    //    new SolidColorBrush((Color)ColorConverter.ConvertFromString(textData["BrushColor"])),
                    //    new Pen(new SolidColorBrush(Colors.Red), 2),
                    //    new Rect(0, 0, 100, 100));
                    //Typeface typeface = new Typeface(
                    //    new FontFamily(textData["FontName"]),
                    //    textData["FontItalic"] ? FontStyles.Italic : FontStyles.Normal,
                    //    textData["FontBold"] ? FontWeights.Bold : FontWeights.Normal,
                    //    new FontStretch());
                    //FormattedText formattedText = new FormattedText(
                    //    textData["Text"],
                    //    CultureInfo.InvariantCulture,
                    //    FlowDirection.LeftToRight,
                    //    typeface,
                    //    textData["FontSize"],
                    //    new SolidColorBrush((Color)ColorConverter.ConvertFromString(textData["PenColor"])));
                    //dc.DrawText(formattedText, new Point(0, 0));
                    //dc.Close();
                    //DrawingBrush drawingBrush = new DrawingBrush(group);
                    //return drawingBrush;
                }
                if (null != img)
                {
                    ImageBrush imageBrush = new ImageBrush(img);
                    return imageBrush;
                }
                if (orientation == "" || orientation.ToString().ToLower() == "r")
                {
                    RadialGradientBrush radialGradientBrush = new RadialGradientBrush();
                    radialGradientBrush.GradientOrigin = new Point(0.5, 0.5);
                    radialGradientBrush.Center = new Point(0.5, 0.5);
                    int numColours = SBArray.GetItemCount(colours);
                    if (numColours < 2) return null;
                    for (int i = 0; i < numColours; i++)
                    {
                        Color colour = (Color)ColorConverter.ConvertFromString(colours[i + 1]);
                        double stop = i / (double)(numColours - 1);
                        radialGradientBrush.GradientStops.Add(new GradientStop(colour, stop));
                    }
                    return radialGradientBrush;
                }
                else
                {
                    LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
                    switch (orientation.ToString().ToLower())
                    {
                        case "h":
                            linearGradientBrush.StartPoint = new Point(0, 0.5);
                            linearGradientBrush.EndPoint = new Point(1, 0.5);
                            break;
                        case "v":
                            linearGradientBrush.StartPoint = new Point(0.5, 0);
                            linearGradientBrush.EndPoint = new Point(0.5, 1);
                            break;
                        case "dd":
                            linearGradientBrush.StartPoint = new Point(0, 0);
                            linearGradientBrush.EndPoint = new Point(1, 1);
                            break;
                        case "du":
                            linearGradientBrush.StartPoint = new Point(0, 1);
                            linearGradientBrush.EndPoint = new Point(1, 0);
                            break;
                    }
                    int numColours = SBArray.GetItemCount(colours);
                    if (numColours < 2) return null;
                    for (int i = 0; i < numColours; i++)
                    {
                        Color colour = (Color)ColorConverter.ConvertFromString(colours[i + 1]);
                        double stop = i / (double)(numColours - 1);
                        linearGradientBrush.GradientStops.Add(new GradientStop(colour, stop));
                    }
                    return linearGradientBrush;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return null;
        }
    }

    /// <summary>
    /// Shapes extension utilities.
    /// </summary>
    [SmallBasicType]
    public static class LDShapes
    {
        private static List<Animated> animated = new List<Animated>();
        private static System.Windows.Forms.Timer animationTimer = null;
        private static int animationInterval = 100;

        public static List<GradientBrush> brushes = new List<GradientBrush>();
        private static int brushCount = 0;
        private static string getNewBrushName()
        {
            return "Brush" + (++brushCount).ToString();
        }
        private static Dictionary<string, DoubleAnimation> animations = new Dictionary<string, DoubleAnimation>();
        private static Dictionary<string, SkewTransform> _skewTransformMap = new Dictionary<string, SkewTransform>();

        private static void DoubleAnimateProperty(string name, IAnimatable animatable, DependencyProperty property, double end, double timespan)
        {
            double num = (double)((DependencyObject)animatable).GetValue(property);
            if (double.IsNaN(num))
            {
                num = 0.0;
            }
            DoubleAnimation animation = new DoubleAnimation(num, end, new Duration(TimeSpan.FromMilliseconds(timespan)))
            {
                FillBehavior = FillBehavior.HoldEnd,
                DecelerationRatio = 0.2
            };
            animatable.BeginAnimation(property, animation);
            animations[name] = animation;
        }

        private static void animation_Tick(object sender, EventArgs e)
        {
            if (animated.Count == 0) animationTimer.Enabled = false;
            for (int i = animated.Count - 1; i >= 0; i--) //Reverse order to allow removal
            {
                Animated anim = animated[i];
                if (!anim.paused) updateGif(anim);
                if (!anim.shape.IsEnabled) animated.Remove(anim);
            }
        }

        private static void updateGif(Animated anim)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);

            InvokeHelper ret = new InvokeHelper(delegate
            {
                try
                {
                    anim.iFrame++;
                    if (anim.iFrame >= anim.frames.Length && anim.repeat) anim.iFrame = 0;
                    if (anim.iFrame >= 0 && anim.iFrame < anim.frames.Length) anim.shape.Source = anim.frames[anim.iFrame].bi;
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            });
            MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
            method.Invoke(null, new object[] { ret });
        }

        private static void updateFlash(Animated anim)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);

            InvokeHelper ret = new InvokeHelper(delegate
            {
                try
                {
                    if (anim.shape.Visibility == Visibility.Visible)
                        anim.shape.Visibility = Visibility.Collapsed;
                    else
                        anim.shape.Visibility = Visibility.Visible;
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            });
            MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
            method.Invoke(null, new object[] { ret });
        }

        private static PointCollection getPoints(Primitive points)
        {
            PointCollection pointCollection = new PointCollection();
            Type PrimitiveType = typeof(Primitive);
            Dictionary<Primitive, Primitive> _arrayMap, _pointMap;

            try
            {
                points = Utilities.CreateArrayMap(points);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(points);

                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    Primitive value = Utilities.CreateArrayMap(kvp.Value);
                    _pointMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(value);
                    int i = 0;
                    Point _point = new Point();
                    if (_pointMap.Count == 2)
                    {
                        foreach (KeyValuePair<Primitive, Primitive> val in _pointMap)
                        {
                            if (i == 0)
                            {
                                _point.X = val.Value;
                            }
                            else if (i == 1)
                            {
                                _point.Y = val.Value;
                            }
                            i++;
                        }
                        pointCollection.Add(_point);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return pointCollection;
        }

        private static List<HitTestResult> HitTestResults = new List<HitTestResult>();

        private static HitTestResultBehavior _HitTestResult(HitTestResult result)
        {
            HitTestResults.Add(result);
            return HitTestResultBehavior.Continue;
        }

        private static HitTestResultBehavior _HitTestResultGeometry(HitTestResult result)
        {
            IntersectionDetail intersectionDetail = ((GeometryHitTestResult)result).IntersectionDetail;
            switch (intersectionDetail)
            {
                case IntersectionDetail.FullyContains:
                    HitTestResults.Add(result);
                    return HitTestResultBehavior.Continue;
                case IntersectionDetail.Intersects:
                    HitTestResults.Add(result);
                    return HitTestResultBehavior.Continue;
                case IntersectionDetail.FullyInside:
                    HitTestResults.Add(result);
                    return HitTestResultBehavior.Continue;
                default:
                    return HitTestResultBehavior.Stop;
            }
        }

        private static HitTestFilterBehavior _HitTestFilterGeometry(DependencyObject obj)
        {
            return HitTestFilterBehavior.Continue; //No obvious way to filter
        }

        private static string lastEventShape = "";
        private static string lastEventType = "";
        private static SmallBasicCallback _ShapeEventsDelegate = null;
        private static void _ShapeEventsMouseDown(Object sender, MouseButtonEventArgs e)
        {
            lastEventShape = ((FrameworkElement)sender).Name;
            lastEventType = "MouseDown";
            if (null != _ShapeEventsDelegate) _ShapeEventsDelegate();
        }
        private static void _ShapeEventsMouseUp(Object sender, MouseButtonEventArgs e)
        {
            lastEventShape = ((FrameworkElement)sender).Name;
            lastEventType = "MouseUp";
            if (null != _ShapeEventsDelegate) _ShapeEventsDelegate();
        }
        private static void _ShapeEventsMouseEnter(Object sender, MouseEventArgs e)
        {
            lastEventShape = ((FrameworkElement)sender).Name;
            lastEventType = "MouseEnter";
            if (null != _ShapeEventsDelegate) _ShapeEventsDelegate();
        }
        private static void _ShapeEventsMouseLeave(Object sender, MouseEventArgs e)
        {
            lastEventShape = ((FrameworkElement)sender).Name;
            lastEventType = "MouseLeave";
            if (null != _ShapeEventsDelegate) _ShapeEventsDelegate();
        }
        private static void _ShapeEventsGotFocus(Object sender, RoutedEventArgs e)
        {
            lastEventShape = ((FrameworkElement)sender).Name;
            lastEventType = "GotFocus";
            if (null != _ShapeEventsDelegate) _ShapeEventsDelegate();
        }
        private static void _ShapeEventsLostFocus(Object sender, RoutedEventArgs e)
        {
            lastEventShape = ((FrameworkElement)sender).Name;
            lastEventType = "LostFocus";
            if (null != _ShapeEventsDelegate) _ShapeEventsDelegate();
        }

        private static void treeViewPenColour(ItemCollection items, SolidColorBrush brush)
        {
            foreach (TreeViewItem i in items)
            {
                treeViewPenColour(i.Items, brush);
                i.Foreground = brush;
            }
        }

        private static void treeViewBrushColour(ItemCollection items, SolidColorBrush brush)
        {
            foreach (TreeViewItem i in items)
            {
                treeViewBrushColour(i.Items, brush);
                i.Background = brush;
            }
        }

        [HideFromIntellisense]
        public static void BackgroundImage(Primitive imageName)
        {
            LDGraphicsWindow.BackgroundImage(imageName);
        }

        [HideFromIntellisense]
        public static void BrushGradientBackground(Primitive brush)
        {
            LDGraphicsWindow.BackgroundBrush(brush);
        }

        [HideFromIntellisense]
        public static void BrushGradientRectangle(Primitive brush, Primitive x, Primitive y, Primitive width, Primitive height)
        {
            BrushRectangle(brush, x, y, width, height);
        }

        [HideFromIntellisense]
        public static void BrushGradientEllipse(Primitive brush, Primitive x, Primitive y, Primitive width, Primitive height)
        {
            BrushEllipse(brush, x, y, width, height);
        }

        [HideFromIntellisense]
        public static void BrushGradientRoundedRectangle(Primitive brush, Primitive x, Primitive y, Primitive width, Primitive height, Primitive radius)
        {
            BrushRoundedRectangle(brush, x, y, width, height, radius);
        }

        [HideFromIntellisense]
        public static void BrushGradientPolygon(Primitive brush, Primitive points)
        {
            BrushPolygon(brush, points);
        }

        [HideFromIntellisense]
        public static void BrushGradientShape(Primitive shapeName, Primitive brush)
        {
            BrushShape(shapeName, brush);
        }

        /// <summary>
        /// Get a shape property.  This is a .Net UIElement property.
        /// </summary>
        /// <param name="shapeName">The shape or control name.</param>
        /// <param name="property">The property name to get.</param>
        /// <returns>The value of the property.</returns>
        public static Primitive GetProperty(Primitive shapeName, Primitive property)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            return obj.GetType().GetProperty(property).GetValue(obj, null).ToString();
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get a list of shape properties.  These are .Net UIElement properties.
        /// </summary>
        /// <param name="shapeName">The shape or control name.</param>
        /// <returns>An array of properties and their values.</returns>
        public static Primitive GetProperties(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            PropertyInfo[] properties = obj.GetType().GetProperties();
                            string result = "";
                            foreach (PropertyInfo property in properties)
                            {
                                Object value = property.GetValue(obj, null);
                                if (null != value)
                                {
                                    if (TypeDescriptor.GetConverter(property.PropertyType).IsValid(value.ToString()))
                                    {
                                        result += Utilities.ArrayParse(property.Name) + "=" + Utilities.ArrayParse(value.ToString()) + ";";
                                    }
                                }
                            }
                            return Utilities.CreateArrayMap(result);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "";
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set a shape property.  This is a .Net UIElement property.
        /// </summary>
        /// <param name="shapeName">The shape or control name.</param>
        /// <param name="property">The property name to set.</param>
        /// <param name="value">The value to set the property to.</param>
        public static void SetProperty(Primitive shapeName, Primitive property, Primitive value)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(property);
                            propertyInfo.SetValue(obj, TypeDescriptor.GetConverter(propertyInfo.PropertyType).ConvertFromString((string)value), null);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Reset the Turtle after a GraphicsWindow.Clear().
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void ResetTurtle()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type TurtleType = typeof(Turtle);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            bool _initialized;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue("_turtle", out obj))
                {
                    _initialized = (bool)TurtleType.GetField("_initialized", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                    TurtleType.GetField("_initialized", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(_initialized, false);
                    Turtle.Show();
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set the turtle to an image.
        /// </summary>
        /// <param name="imageName">
        /// The image to load for the turtle.
        /// Value returned from ImageList.LoadImage or local or network image file.
        /// </param>
        /// <param name="size">
        /// The size to scale the turtle to (default turtle is 16).
        /// </param>
        public static void SetTurtleImage(Primitive imageName, Primitive size)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ImageListType = typeof(ImageList);
            Type TurtleType = typeof(Turtle);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;
            RotateTransform _rotateTransform;

            try
            {
                TurtleType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { });
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return;
                    }
                }
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _rotateTransform = (RotateTransform)TurtleType.GetField("_rotateTransform", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue("_turtle", out obj) && null != _rotateTransform)
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Image))
                            {
                                Image shape = ((Image)obj);
                                shape.Source = img;
                                shape.Stretch = Stretch.Fill;
                                shape.Width = size;
                                shape.Height = size;
                                shape.Margin = new Thickness(-size / 2, -size / 2, 0.0, 0.0);
                                _rotateTransform.CenterX = size / 2;
                                _rotateTransform.CenterY = size / 2;
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), "_turtle");
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Remove all turtle trail lines.
        /// </summary>
        public static void RemoveTurtleLines()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                List<string> shapes = new List<string>();
                foreach (KeyValuePair<string, UIElement> obj in _objectsMap)
                {
                    if (obj.Key.StartsWith("_turtleLine")) shapes.Add(obj.Key);
                }
                foreach (string shape in shapes)
                {
                    Shapes.Remove(shape);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Rasterise all turtle trail lines.
        /// When the number of turtle trails is large the program may slow due to the number of line shapes (trails) present.
        /// This converts the turtle trails from line shapes to background drawings. 
        /// </summary>
        public static void RasteriseTurtleLines()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            FieldInfo _penField;
            Pen _pen;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _penField = GraphicsWindowType.GetField("_pen", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                _pen = (Pen)_penField.GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        Pen pen = new Pen();
                        Line line;
                        List<string> shapes = new List<string>();
                        foreach (KeyValuePair<string, UIElement> obj in _objectsMap)
                        {
                            if (obj.Key.StartsWith("_turtleLine"))
                            {
                                line = (Line)obj.Value;
                                pen.Brush = line.Stroke;
                                pen.Thickness = line.StrokeThickness;
                                _penField.SetValue(null, pen);
                                GraphicsWindow.DrawLine(line.X1, line.Y1, line.X2, line.Y2);
                                shapes.Add(obj.Key);
                            }
                        }
                        foreach (string shape in shapes)
                        {
                            Shapes.Remove(shape);
                        }
                        _penField.SetValue(null, _pen);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { ret });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Moves a line shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name (a line created with Shapes.AddLine).
        /// </param>
        /// <param name="x1">
        /// The first X coordinate to move the line to.
        /// </param>
        /// <param name="y1">
        /// The first Y coordinate to move the line to.
        /// </param>
        /// <param name="x2">
        /// The second X coordinate to move the line to.
        /// </param>
        /// <param name="y2">
        /// The second Y coordinate to move the line to.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void MoveLine(Primitive shapeName, Primitive x1, Primitive y1, Primitive x2, Primitive y2)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            Line shape = (Line)obj;
                            shape.X1 = x1;
                            shape.X2 = x2;
                            shape.Y1 = y1;
                            shape.Y2 = y2;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Moves a triangle shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name (a triangle created with Shapes.AddTriangle).
        /// </param>
        /// <param name="x1">
        /// The first X coordinate to move the triangle to.
        /// </param>
        /// <param name="y1">
        /// The first Y coordinate to move the triangle to.
        /// </param>
        /// <param name="x2">
        /// The second X coordinate to move the triangle to.
        /// </param>
        /// <param name="y2">
        /// The second Y coordinate to move the triangle to.
        /// </param>
        /// <param name="x3">
        /// The third X coordinate to move the triangle to.
        /// </param>
        /// <param name="y3">
        /// The third Y coordinate to move the triangle to.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void MoveTriangle(Primitive shapeName, Primitive x1, Primitive y1, Primitive x2, Primitive y2, Primitive x3, Primitive y3)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            Polygon shape = (Polygon)obj;
                            System.Windows.Point Point1 = new System.Windows.Point(x1, y1);
                            System.Windows.Point Point2 = new System.Windows.Point(x2, y2);
                            System.Windows.Point Point3 = new System.Windows.Point(x3, y3);
                            PointCollection pointCollection = new PointCollection();
                            pointCollection.Add(Point1);
                            pointCollection.Add(Point2);
                            pointCollection.Add(Point3);
                            shape.Points = pointCollection;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Moves a triangle or polygon top-left position.
        /// This method also works for lines (Shapes.AddLine).
        /// </summary>
        /// <param name="shapeName">
        /// The shape name (a triangle, polygon or line shape).
        /// </param>
        /// <param name="x">
        /// The X (left) coordinate for the triangle, polygon or line.
        /// </param>
        /// <param name="y">
        /// The Y (top) coordinate for the triangle, polygon or line.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Move(Primitive shapeName, Primitive x, Primitive y)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Polygon))
                            {
                                Polygon shape = (Polygon)obj;
                                int numPoint = shape.Points.Count;
                                double left = double.MaxValue;
                                double top = double.MaxValue;
                                for (int i = 0; i < numPoint; i++)
                                {
                                    left = System.Math.Min(shape.Points[i].X, left);
                                    top = System.Math.Min(shape.Points[i].Y, top);
                                }
                                PointCollection pointCollection = new PointCollection();
                                for (int i = 0; i < numPoint; i++)
                                {
                                    pointCollection.Add(new Point(shape.Points[i].X + x - left, shape.Points[i].Y + y - top));
                                }
                                shape.Points = pointCollection;
                            }
                            else if (obj.GetType() == typeof(Line))
                            {
                                Line shape = (Line)obj;
                                double left = System.Math.Min(shape.X1, shape.X2);
                                double top = System.Math.Min(shape.Y1, shape.Y2);
                                shape.X1 += x - left;
                                shape.X2 += x - left;
                                shape.Y1 += y - top;
                                shape.Y2 += y - top;
                            }
                            else
                            {
                                Shapes.Move(shapeName, x, y);
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Rotate a shape about a point.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <param name="x">
        /// The X coordinate to rotate the shape about.
        /// </param>
        /// <param name="y">
        /// The Y coordinate to rotate the shape about.
        /// </param>
        /// <param name="angle">
        /// The angle in degrees to rotate the shape.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void RotateAbout(Primitive shapeName, Primitive x, Primitive y, Primitive angle)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Dictionary<string, UIElement> _objectsMap;
            Dictionary<string, RotateTransform> _rotateTransformMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _rotateTransformMap = (Dictionary<string, RotateTransform>)ShapesType.GetField("_rotateTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (!(obj.RenderTransform is TransformGroup))
                            {
                                obj.RenderTransform = new TransformGroup();
                            }
                            RotateTransform rotateTransform;
                            if (!_rotateTransformMap.TryGetValue(shapeName, out rotateTransform))
                            {
                                rotateTransform = new RotateTransform();
                                ((TransformGroup)obj.RenderTransform).Children.Add(rotateTransform);
                                _rotateTransformMap[shapeName] = rotateTransform;
                            }
                            rotateTransform.CenterX = x - Shapes.GetLeft(shapeName);
                            rotateTransform.CenterY = y - Shapes.GetTop(shapeName);
                            rotateTransform.Angle = angle;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Moves a polygon shape.
        /// </summary>
        /// <param name="shapeName">
        /// The shape name (a polygon created with LDShapes.AddPolygon).
        /// </param>
        /// <param name="points">
        /// An array of new coordinates for the polygon corners with the form points[i][1] = x, points[i][2] = y.
        /// 
        /// The number of points must be 3 or more and can change with each call.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void MovePolygon(Primitive shapeName, Primitive points)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            Polygon shape = (Polygon)obj;
                            PointCollection _points = getPoints(points);
                            if (_points.Count >= 3) shape.Points = _points;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Creates a polygon shape.
        /// </summary>
        /// <param name="points">
        /// An array of coordinates for the polygon corners with the form points[i][1] = x, points[i][2] = y.
        /// 
        /// The number of points must be 3 or more.
        /// </param>
        /// <returns>
        /// The polygon shape name.
        /// </returns>
        public static Primitive AddPolygon(Primitive points)
        {
            GraphicsWindow.Show();
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;
            Pen _pen;
            Brush _brush;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Polygon" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _pen = (Pen)GraphicsWindowType.GetField("_pen", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _brush = (Brush)GraphicsWindowType.GetField("_fillBrush", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        PointCollection _points = getPoints(points);
                        if (_points.Count < 3) return "";

                        Polygon shape = new Polygon
                        {
                            Name = shapeName,
                            Points = _points,
                            Fill = _brush,
                            Stroke = _pen.Brush,
                            StrokeThickness = _pen.Thickness
                        };

                        _objectsMap[shapeName] = shape;
                        _mainCanvas.Children.Add(shape);
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
        /// Creates a star shape.
        /// Fun effects can be created with negative distances.
        /// </summary>
        /// <param name="numPoint">The number of star points.</param>
        /// <param name="innerRadius">The centre to inner points' distance.</param>
        /// <param name="outerRadius">The centre to outer points' distance.</param>
        /// <returns>
        /// The star shape name.
        /// </returns>
        public static Primitive AddStar(Primitive numPoint, Primitive innerRadius, Primitive outerRadius)
        {
            GraphicsWindow.Show();
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;
            Pen _pen;
            Brush _brush;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Polygon" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _pen = (Pen)GraphicsWindowType.GetField("_pen", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _brush = (Brush)GraphicsWindowType.GetField("_fillBrush", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        PointCollection _points = new PointCollection();
                        double angle;
                        Point _point;
                        double x = 0;
                        double y = 0;
                        for (int i = 0; i < numPoint; i++)
                        {
                            angle = i * 2.0 * System.Math.PI / (double)numPoint;
                            _point = new Point(outerRadius * System.Math.Sin(angle), -outerRadius * System.Math.Cos(angle));
                            x = System.Math.Min(x, _point.X);
                            y = System.Math.Min(y, _point.Y);
                            _points.Add(_point);
                            angle = (i + 0.5) * 2.0 * System.Math.PI / (double)numPoint;
                            _point = new Point(innerRadius * System.Math.Sin(angle), -innerRadius * System.Math.Cos(angle));
                            x = System.Math.Min(x, _point.X);
                            y = System.Math.Min(y, _point.Y);
                            _points.Add(_point);
                        }

                        // Muck around to start at 0,0 in top left of the shape to be consistent with other GW shapes
                        for (int i = 0; i < _points.Count; i++)
                        {
                            _point = _points[i];
                            _point.X -= x;
                            _point.Y -= y;
                            _points[i] = _point;
                        }

                        Polygon shape = new Polygon
                        {
                            Name = shapeName,
                            Points = _points,
                            Fill = _brush,
                            Stroke = _pen.Brush,
                            StrokeThickness = _pen.Thickness
                        };

                        _objectsMap[shapeName] = shape;
                        _mainCanvas.Children.Add(shape);
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
        /// Creates a regular polygon shape.
        /// </summary>
        /// <param name="numPoint">The number of polygon sides.</param>
        /// <param name="radius">The centre to corner distance.</param>
        /// <returns>
        /// The regular polygon shape name.
        /// </returns>
        public static Primitive AddRegularPolygon(Primitive numPoint, Primitive radius)
        {
            GraphicsWindow.Show();
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;
            Pen _pen;
            Brush _brush;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Polygon" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _pen = (Pen)GraphicsWindowType.GetField("_pen", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _brush = (Brush)GraphicsWindowType.GetField("_fillBrush", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        PointCollection _points = new PointCollection();
                        double angle;
                        Point _point;
                        double x = 0;
                        double y = 0;
                        for (int i = 0; i < numPoint; i++)
                        {
                            angle = i * 2.0 * System.Math.PI / (double)numPoint;
                            _point = new Point(radius * System.Math.Sin(angle), -radius * System.Math.Cos(angle));
                            x = System.Math.Min(x, _point.X);
                            y = System.Math.Min(y, _point.Y);
                            _points.Add(_point);
                        }

                        // Muck around to start at 0,0 in top left of the shape to be consistent with other GW shapes
                        for (int i = 0; i < _points.Count; i++)
                        {
                            _point = _points[i];
                            _point.X -= x;
                            _point.Y -= y;
                            _points[i] = _point;
                        }

                        Polygon shape = new Polygon
                        {
                            Name = shapeName,
                            Points = _points,
                            Fill = _brush,
                            Stroke = _pen.Brush,
                            StrokeThickness = _pen.Thickness
                        };

                        _objectsMap[shapeName] = shape;
                        _mainCanvas.Children.Add(shape);
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
        /// Checks for shape overlap of bounding boxes (collision detection).
        /// </summary>
        /// <param name="shape1">
        /// The first shape name.
        /// </param>
        /// <param name="shape2">
        /// The second shape name.
        /// </param>
        /// <returns>
        /// "True" or "False".
        /// </returns>
        public static Primitive OverlapBox(Primitive shape1, Primitive shape2)
        {            
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj1, obj2;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shape1, out obj1))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shape1);
                    return "False";
                }
                if (!_objectsMap.TryGetValue((string)shape2, out obj2))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shape2);
                    return "False";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Rect rect1 = new Rect(obj1.RenderSize);
                        Rect rect2 = new Rect(obj2.RenderSize);
                        rect1.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj1));
                        rect2.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj2));
                        return rect1.IntersectsWith(rect2) ? "True" : "False";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "False";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "False";
            }
        }

        /// <summary>
        /// Checks for shape overlap of bounding circles (collision detection).
        /// </summary>
        /// <param name="shape1">
        /// The first shape name.
        /// </param>
        /// <param name="shape2">
        /// The second shape name.
        /// </param>
        /// <returns>
        /// "True" or "False".
        /// </returns>
        public static Primitive OverlapCircle(Primitive shape1, Primitive shape2)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj1, obj2;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shape1, out obj1))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shape1); 
                    return "False";
                }
                if (!_objectsMap.TryGetValue((string)shape2, out obj2))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shape2); 
                    return "False";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Rect rect1 = new Rect(obj1.RenderSize);
                        Rect rect2 = new Rect(obj2.RenderSize);
                        rect1.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj1));
                        rect2.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj2));

                        double rad1 = System.Math.Sqrt((rect1.Width * rect1.Width + rect1.Height * rect1.Height) / 2.0) / 2.0;
                        double rad2 = System.Math.Sqrt((rect2.Width * rect2.Width + rect2.Height * rect2.Height) / 2.0) / 2.0;
                        double dx = (rect1.X + rect1.Width / 2.0) - (rect2.X + rect2.Width / 2.0);
                        double dy = (rect1.Y + rect1.Height / 2.0) - (rect2.Y + rect2.Height / 2.0);
                        double dist = System.Math.Sqrt(dx * dx + dy * dy);

                        return dist <= rad1 + rad2 ? "True" : "False";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "False";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "False";
            }
        }

        /// <summary>
        /// Checks for shape overlap (collision detection for any ellipse or rectangle shape types).
        /// The first shape should be unZoomed and unRotated.
        /// </summary>
        /// <param name="shape1">
        /// The first shape name.
        /// </param>
        /// <param name="shape2">
        /// The second shape name.
        /// </param>
        /// <returns>
        /// "True" or "False".
        /// </returns>
        public static Primitive Overlap(Primitive shape1, Primitive shape2)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj1, obj2;
            Canvas _mainCanvas;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shape1, out obj1))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shape1); 
                    return "False";
                }
                if (!_objectsMap.TryGetValue((string)shape2, out obj2))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shape2); 
                    return "False";
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Utilities.doUpdates();
                        if (obj1.GetType() == typeof(Ellipse))
                        {
                            Rect rect1 = new Rect(obj1.RenderSize);
                            rect1.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj1));
                            EllipseGeometry geometry1 = new EllipseGeometry(rect1);
                            HitTestResults.Clear();
                            VisualTreeHelper.HitTest(_mainCanvas, new HitTestFilterCallback(_HitTestFilterGeometry), new HitTestResultCallback(_HitTestResultGeometry), new GeometryHitTestParameters(geometry1));
                        }
                        else
                        {
                            Rect rect1 = new Rect(obj1.RenderSize);
                            rect1.Offset(System.Windows.Media.VisualTreeHelper.GetOffset(obj1));
                            RectangleGeometry geometry1 = new RectangleGeometry(rect1);
                            HitTestResults.Clear();
                            VisualTreeHelper.HitTest(_mainCanvas, new HitTestFilterCallback(_HitTestFilterGeometry), new HitTestResultCallback(_HitTestResultGeometry), new GeometryHitTestParameters(geometry1));
                        }

                        foreach (HitTestResult i in HitTestResults)
                        {
                            if (i.VisualHit == obj2) return "True";
                        }
                        return "False";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "False";
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "False";
            }
        }

        /// <summary>
        /// Set shape Brush colour.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="colour">
        /// The new brush colour.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void BrushColour(Primitive shapeName, Primitive colour)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Ellipse))
                            {
                                Ellipse shape = (Ellipse)obj;
                                shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Rectangle))
                            {
                                Rectangle shape = (Rectangle)obj;
                                shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Polygon))
                            {
                                Polygon shape = (Polygon)obj;
                                shape.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Button))
                            {
                                Button shape = (Button)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(TextBlock))
                            {
                                TextBlock shape = (TextBlock)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(TextBox))
                            {
                                TextBox shape = (TextBox)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(PasswordBox))
                            {
                                PasswordBox shape = (PasswordBox)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(CheckBox))
                            {
                                CheckBox shape = (CheckBox)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(ComboBox))
                            {
                                ComboBox shape = (ComboBox)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(RadioButton))
                            {
                                RadioButton shape = (RadioButton)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(RichTextBox))
                            {
                                RichTextBox shape = (RichTextBox)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(TreeView))
                            {
                                TreeView shape = (TreeView)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(DocumentViewer))
                            {
                                DocumentViewer shape = (DocumentViewer)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(ListBox))
                            {
                                ListBox shape = (ListBox)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(ListView))
                            {
                                ListView shape = (ListView)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(WindowsFormsHost))
                            {
                                WindowsFormsHost shape = (WindowsFormsHost)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                                if (shape.Child.GetType() == typeof(System.Windows.Forms.DataGridView))
                                {
                                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                                    dataView.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(colour);
                                }
                            }
                            else if (obj.GetType() == typeof(ProgressBar))
                            {
                                ProgressBar shape = (ProgressBar)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Slider))
                            {
                                Slider shape = (Slider)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Menu))
                            {
                                Menu shape = (Menu)obj;
                                shape.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get shape Brush and Pen colours.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <returns>
        /// A 3 element array
        /// 1) shape brush (or background) colour in hex format
        /// 2) shape opacity (0 to 100)
        /// 3) shape pen (or foreground) colour in hex format
        /// </returns>
        public static Primitive GetColour(Primitive shapeName)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        string result = "";
                        Brush brush = null;
                        Brush pen = null;
                        try
                        {
                            if (obj.GetType() == typeof(Ellipse))
                            {
                                Ellipse shape = (Ellipse)obj;
                                brush = shape.Fill;
                                pen = shape.Stroke;
                            }
                            else if (obj.GetType() == typeof(Rectangle))
                            {
                                Rectangle shape = (Rectangle)obj;
                                brush = shape.Fill;
                                pen = shape.Stroke;
                            }
                            else if (obj.GetType() == typeof(Polygon))
                            {
                                Polygon shape = (Polygon)obj;
                                brush = shape.Fill;
                                pen = shape.Stroke;
                            }
                            else if (obj.GetType() == typeof(Button))
                            {
                                Button shape = (Button)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(TextBlock))
                            {
                                TextBlock shape = (TextBlock)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(TextBox))
                            {
                                TextBox shape = (TextBox)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(PasswordBox))
                            {
                                PasswordBox shape = (PasswordBox)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(CheckBox))
                            {
                                CheckBox shape = (CheckBox)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(ComboBox))
                            {
                                ComboBox shape = (ComboBox)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(RadioButton))
                            {
                                RadioButton shape = (RadioButton)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(RichTextBox))
                            {
                                RichTextBox shape = (RichTextBox)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(TreeView))
                            {
                                TreeView shape = (TreeView)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(DocumentViewer))
                            {
                                DocumentViewer shape = (DocumentViewer)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(ListBox))
                            {
                                ListBox shape = (ListBox)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(ListView))
                            {
                                ListView shape = (ListView)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(WindowsFormsHost))
                            {
                                WindowsFormsHost shape = (WindowsFormsHost)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                                if (shape.Child.GetType() == typeof(System.Windows.Forms.DataGridView))
                                {
                                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                                }
                            }
                            else if (obj.GetType() == typeof(ProgressBar))
                            {
                                ProgressBar shape = (ProgressBar)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(Slider))
                            {
                                Slider shape = (Slider)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                            else if (obj.GetType() == typeof(Menu))
                            {
                                Menu shape = (Menu)obj;
                                brush = shape.Background;
                                pen = shape.Foreground;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }

                        if (null != brush && null != pen)
                        {
                            result += "1=" + brush.ToString() + ";";
                            result += "2=" + (obj.Opacity * 100).ToString(CultureInfo.InvariantCulture) + ";";
                            result += "3=" + pen.ToString() + ";";
                        }
                        return Utilities.CreateArrayMap(result);
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Create a linear or radial gradient brush.
        /// </summary>
        /// <param name="colours">
        /// An array of colours to apply to the shape in a gradient.
        /// </param>
        /// <param name="orientation">
        /// The orientation for the gradient.
        /// "H" horizontal.
        /// "V" vertical.
        /// "DU" diagonally up.
        /// "DD" diagonally down.
        /// "R"  radial (default if "")
        /// </param>
        /// <returns>The gradient brush name.</returns>
        public static Primitive BrushGradient(Primitive colours, Primitive orientation)
        {
            GradientBrush brush = new GradientBrush(getNewBrushName(), colours, orientation);
            GradientBrush result = brushes.Find(item => item.colours == colours && item.orientation == orientation);
            if (null != result) return result.name; // Re-use if we can
            brushes.Add(brush);
            return brush.name;
        }

        /// <summary>
        /// Create an image brush.
        /// These brushes should work anywhere that BrushGradient can be used.
        /// </summary>
        /// <param name="imageName">
        /// The image to load to the brush.
        /// Value returned from ImageList.LoadImage or local or network image file.
        /// </param>
        /// <returns>The image brush name.</returns>
        public static Primitive BrushImage(Primitive imageName)
        {
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;

            try
            {
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return "";
                    }
                }
                GradientBrush brush = new GradientBrush(getNewBrushName(), img);
                GradientBrush result = brushes.Find(item => item.img == img);
                if (null != result) return result.name; // Re-use if we can
                brushes.Add(brush);
                return brush.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Create a text brush.
        /// These brushes should work anywhere that BrushGradient can be used.
        /// </summary>
        /// <param name="text">
        /// The text to add to the brush.
        /// The current GraphicsWindow font is used.
        /// </param>
        /// <param name="background">
        /// The background colour.
        /// </param>
        /// <param name="foreground">
        /// The foreground (pen) colour.
        /// </param>
        /// <returns>The text brush name.</returns>
        public static Primitive BrushText(Primitive text, Primitive background, Primitive foreground)
        {
            try
            {
                Dictionary<string, Primitive> textData = new Dictionary<string, Primitive>();
                textData["Text"] = text;
                textData["BrushColor"] = background;
                textData["PenColor"] = foreground;
                textData["FontName"] = GraphicsWindow.FontName;
                textData["FontSize"] = GraphicsWindow.FontSize;
                textData["FontBold"] = GraphicsWindow.FontBold;
                textData["FontItalic"] = GraphicsWindow.FontItalic;

                GradientBrush brush = new GradientBrush(getNewBrushName(), textData);
                GradientBrush result = brushes.Find(item => item.textData == textData);
                if (null != result) return result.name; // Re-use if we can
                brushes.Add(brush);
                return brush.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set a shape Brush style as a gradient of colours.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="brush">
        /// A previously created gradient or image brush (LDShapes.BrushGradient LDShapes.BrushImage).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void BrushShape(Primitive shapeName, Primitive brush)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            foreach (GradientBrush i in brushes)
                            {
                                if (i.name == brush)
                                {
                                    if (obj.GetType() == typeof(Ellipse))
                                    {
                                        Ellipse shape = (Ellipse)obj;
                                        shape.Fill = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(Rectangle))
                                    {
                                        Rectangle shape = (Rectangle)obj;
                                        shape.Fill = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(Polygon))
                                    {
                                        Polygon shape = (Polygon)obj;
                                        shape.Fill = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(Button))
                                    {
                                        Button shape = (Button)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(TextBlock))
                                    {
                                        TextBlock shape = (TextBlock)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(TextBox))
                                    {
                                        TextBox shape = (TextBox)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(PasswordBox))
                                    {
                                        PasswordBox shape = (PasswordBox)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(CheckBox))
                                    {
                                        CheckBox shape = (CheckBox)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(ComboBox))
                                    {
                                        ComboBox shape = (ComboBox)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(RadioButton))
                                    {
                                        RadioButton shape = (RadioButton)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(RichTextBox))
                                    {
                                        RichTextBox shape = (RichTextBox)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(TreeView))
                                    {
                                        TreeView shape = (TreeView)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(DocumentViewer))
                                    {
                                        DocumentViewer shape = (DocumentViewer)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(ListBox))
                                    {
                                        ListBox shape = (ListBox)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(ListView))
                                    {
                                        ListView shape = (ListView)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(WindowsFormsHost))
                                    {
                                        WindowsFormsHost shape = (WindowsFormsHost)obj;
                                        shape.Background = i.getBrush();
                                        if (shape.Child.GetType() == typeof(System.Windows.Forms.DataGridView))
                                        {
                                            System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                                        }
                                    }
                                    else if (obj.GetType() == typeof(ProgressBar))
                                    {
                                        ProgressBar shape = (ProgressBar)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(Slider))
                                    {
                                        Slider shape = (Slider)obj;
                                        shape.Background = i.getBrush();
                                    }
                                    else if (obj.GetType() == typeof(Menu))
                                    {
                                        Menu shape = (Menu)obj;
                                        shape.Background = i.getBrush();
                                    }
                                }
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Draw a rectangle filled with a gradient of colours.
        /// </summary>
        /// <param name="brush">
        /// A previously created gradient or image brush (LDShapes.BrushGradient LDShapes.BrushImage).
        /// </param>
        /// <param name="x">
        /// The x co-ordinate of the rectangle.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the rectangle.
        /// </param>
        /// <param name="width">
        /// The width of the rectangle.
        /// </param>
        /// <param name="height">
        /// The height of the rectangle.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void BrushRectangle(Primitive brush, Primitive x, Primitive y, Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            DrawingGroup _mainDrawing;

            try
            {
                _mainDrawing = (DrawingGroup)GraphicsWindowType.GetField("_mainDrawing", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        foreach (GradientBrush i in brushes)
                        {
                            if (i.name == brush)
                            {
                                DrawingContext drawingContext = _mainDrawing.Append();
                                drawingContext.DrawRectangle(i.getBrush(), null, new Rect((double)x, (double)y, width, height));
                                drawingContext.Close();
                                GraphicsWindowType.GetMethod("AddRasterizeOperationToQueue", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { });
                            }
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
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Draw an ellipse filled with a gradient of colours.
        /// </summary>
        /// <param name="brush">
        /// A previously created gradient or image brush (LDShapes.BrushGradient LDShapes.BrushImage).
        /// </param>
        /// <param name="x">
        /// The x co-ordinate of the ellipse.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the ellipse.
        /// </param>
        /// <param name="width">
        /// The width of the ellipse.
        /// </param>
        /// <param name="height">
        /// The height of the ellipse.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void BrushEllipse(Primitive brush, Primitive x, Primitive y, Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            DrawingGroup _mainDrawing;

            try
            {
                _mainDrawing = (DrawingGroup)GraphicsWindowType.GetField("_mainDrawing", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        foreach (GradientBrush i in brushes)
                        {
                            if (i.name == brush)
                            {
                                DrawingContext drawingContext = _mainDrawing.Append();
                                drawingContext.DrawEllipse(i.getBrush(), null, new Point(x + width / 2, y + height / 2), width / 2, height / 2);
                                drawingContext.Close();
                                GraphicsWindowType.GetMethod("AddRasterizeOperationToQueue", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { });
                            }
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
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Draw a rounded rectangle filled with a gradient of colours.
        /// </summary>
        /// <param name="brush">
        /// A previously created gradient or image brush (LDShapes.BrushGradient LDShapes.BrushImage).
        /// </param>
        /// <param name="x">
        /// The x co-ordinate of the rectangle.
        /// </param>
        /// <param name="y">
        /// The y co-ordinate of the rectangle.
        /// </param>
        /// <param name="width">
        /// The width of the rectangle.
        /// </param>
        /// <param name="height">
        /// The height of the rectangle.
        /// </param>
        /// <param name="radius">
        /// The radius of the rounded corners.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void BrushRoundedRectangle(Primitive brush, Primitive x, Primitive y, Primitive width, Primitive height, Primitive radius)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            DrawingGroup _mainDrawing;

            try
            {
                _mainDrawing = (DrawingGroup)GraphicsWindowType.GetField("_mainDrawing", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        foreach (GradientBrush i in brushes)
                        {
                            if (i.name == brush)
                            {
                                DrawingContext drawingContext = _mainDrawing.Append();
                                drawingContext.DrawRoundedRectangle(i.getBrush(), null, new Rect((double)x, (double)y, width, height), radius, radius);
                                drawingContext.Close();
                                GraphicsWindowType.GetMethod("AddRasterizeOperationToQueue", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { });
                            }
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
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Draw a polygon filled with a gradient of colours.
        /// </summary>
        /// <param name="brush">
        /// A previously created gradient or image brush (LDShapes.BrushGradient LDShapes.BrushImage).
        /// </param>
        /// <param name="points">
        /// An array of coordinates for the polygon corners with the form points[i][1] = x, points[i][2] = y.
        /// 
        /// The number of points must be 3 or more.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void BrushPolygon(Primitive brush, Primitive points)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            DrawingGroup _mainDrawing;

            try
            {
                _mainDrawing = (DrawingGroup)GraphicsWindowType.GetField("_mainDrawing", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        foreach (GradientBrush i in brushes)
                        {
                            if (i.name == brush)
                            {
                                PointCollection _points = getPoints(points);
                                if (_points.Count < 3) return;
                                DrawingContext drawingContext = _mainDrawing.Append();
                                PathFigure pathFigure = new PathFigure();
                                pathFigure.IsClosed = true;
                                pathFigure.StartPoint = _points[0];
                                for (int j = 1; j < _points.Count; j++)
                                {
                                    pathFigure.Segments.Add(new LineSegment(_points[j], true));
                                }
                                PathFigureCollection pathFigureCollection = new PathFigureCollection();
                                pathFigureCollection.Add(pathFigure);
                                PathGeometry pathGeometry = new PathGeometry();
                                pathGeometry.Figures = pathFigureCollection;
                                pathGeometry.Freeze();
                                drawingContext.DrawGeometry(i.getBrush(), null, pathGeometry);
                                drawingContext.Close();
                                GraphicsWindowType.GetMethod("AddRasterizeOperationToQueue", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).Invoke(null, new object[] { });
                            }
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
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set shape Pen colour.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="colour">
        /// The new pen colour.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void PenColour(Primitive shapeName, Primitive colour)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Ellipse))
                            {
                                Ellipse shape = (Ellipse)obj;
                                shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Rectangle))
                            {
                                Rectangle shape = (Rectangle)obj;
                                shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Polygon))
                            {
                                Polygon shape = (Polygon)obj;
                                shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Line))
                            {
                                Line shape = (Line)obj;
                                shape.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Button))
                            {
                                Button shape = (Button)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(TextBlock))
                            {
                                TextBlock shape = (TextBlock)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(TextBox))
                            {
                                TextBox shape = (TextBox)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(PasswordBox))
                            {
                                PasswordBox shape = (PasswordBox)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(CheckBox))
                            {
                                CheckBox shape = (CheckBox)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(ComboBox))
                            {
                                ComboBox shape = (ComboBox)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(RadioButton))
                            {
                                RadioButton shape = (RadioButton)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(RichTextBox))
                            {
                                RichTextBox shape = (RichTextBox)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(TreeView))
                            {
                                TreeView shape = (TreeView)obj;
                                treeViewPenColour(shape.Items, new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour)));
                            }
                            else if (obj.GetType() == typeof(DocumentViewer))
                            {
                                DocumentViewer shape = (DocumentViewer)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(ListBox))
                            {
                                ListBox shape = (ListBox)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(ListView))
                            {
                                ListView shape = (ListView)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(WindowsFormsHost))
                            {
                                WindowsFormsHost shape = (WindowsFormsHost)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                                if (shape.Child.GetType() == typeof(System.Windows.Forms.DataGridView))
                                {
                                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                                }
                            }
                            else if (obj.GetType() == typeof(ProgressBar))
                            {
                                ProgressBar shape = (ProgressBar)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Slider))
                            {
                                Slider shape = (Slider)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                            }
                            else if (obj.GetType() == typeof(Menu))
                            {
                                Menu shape = (Menu)obj;
                                shape.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set shape Font.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="family">The new font family name
        /// See LDUtilities.FontList() for available font families.</param>
        /// <param name="size">The new font size.</param>
        /// <param name="bold">The new font bold state ("True" or "False").</param>
        /// <param name="italic">The new font italic state ("True" or "False").</param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Font(Primitive shapeName, Primitive family, Primitive size, Primitive bold, Primitive italic)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Button))
                            {
                                Button shape = (Button)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(TextBlock))
                            {
                                TextBlock shape = (TextBlock)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(TextBox))
                            {
                                TextBox shape = (TextBox)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(PasswordBox))
                            {
                                PasswordBox shape = (PasswordBox)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(CheckBox))
                            {
                                CheckBox shape = (CheckBox)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(ComboBox))
                            {
                                ComboBox shape = (ComboBox)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(RadioButton))
                            {
                                RadioButton shape = (RadioButton)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(RichTextBox))
                            {
                                RichTextBox shape = (RichTextBox)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(TreeView))
                            {
                                TreeView shape = (TreeView)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(DocumentViewer))
                            {
                                DocumentViewer shape = (DocumentViewer)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(ListBox))
                            {
                                ListBox shape = (ListBox)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(ListView))
                            {
                                ListView shape = (ListView)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                            }
                            else if (obj.GetType() == typeof(WindowsFormsHost))
                            {
                                WindowsFormsHost shape = (WindowsFormsHost)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
                                if (shape.Child.GetType() == typeof(System.Windows.Forms.DataGridView))
                                {
                                    System.Windows.Forms.DataGridView dataView = (System.Windows.Forms.DataGridView)shape.Child;
                                }
                            }
                            else if (obj.GetType() == typeof(Menu))
                            {
                                Menu shape = (Menu)obj;
                                shape.FontFamily = new FontFamily(family);
                                shape.FontSize = size;
                                shape.FontWeight = bold ? FontWeights.Bold : FontWeights.Normal;
                                shape.FontStyle = italic ? FontStyles.Italic : FontStyles.Normal;
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set shape Pen width.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="width">
        /// The new pen width.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void PenWidth(Primitive shapeName, Primitive width)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Ellipse))
                            {
                                Ellipse shape = (Ellipse)obj;
                                shape.StrokeThickness = width;
                            }
                            else if (obj.GetType() == typeof(Rectangle))
                            {
                                Rectangle shape = (Rectangle)obj;
                                shape.StrokeThickness = width;
                            }
                            else if (obj.GetType() == typeof(Polygon))
                            {
                                Polygon shape = (Polygon)obj;
                                shape.StrokeThickness = width;
                            }
                            else if (obj.GetType() == typeof(Line))
                            {
                                Line shape = (Line)obj;
                                shape.StrokeThickness = width;
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set shape Pen style (dash, dot etc).
        /// </summary>
        /// <param name="shapeName">
        /// The shape name.
        /// </param>
        /// <param name="dash">
        /// The dash length.
        /// </param>
        /// <param name="space">
        /// The space length.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void PenStyle(Primitive shapeName, Primitive dash, Primitive space)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Ellipse))
                            {
                                Ellipse shape = (Ellipse)obj;
                                DoubleCollection style = new DoubleCollection();
                                style.Add(dash);
                                style.Add(space);
                                shape.StrokeDashArray = style;
                            }
                            else if (obj.GetType() == typeof(Rectangle))
                            {
                                Rectangle shape = (Rectangle)obj;
                                DoubleCollection style = new DoubleCollection();
                                style.Add(dash);
                                style.Add(space);
                                shape.StrokeDashArray = style;
                            }
                            else if (obj.GetType() == typeof(Polygon))
                            {
                                Polygon shape = (Polygon)obj;
                                DoubleCollection style = new DoubleCollection();
                                style.Add(dash);
                                style.Add(space);
                                shape.StrokeDashArray = style;
                            }
                            else if (obj.GetType() == typeof(Line))
                            {
                                Line shape = (Line)obj;
                                DoubleCollection style = new DoubleCollection();
                                style.Add(dash);
                                style.Add(space);
                                shape.StrokeDashArray = style;
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set shape z index (layer position negative are background and positive are foreground - default 0).
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="z_index">
        /// The z-index (zero, positive or negative interger).
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void ZIndex(Primitive shapeName, Primitive z_index)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            Canvas.SetZIndex(obj, z_index);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Resize shape width and height (an absolute version of zoom).
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="width">
        /// The shape width.
        /// </param>
        /// <param name="height">
        /// The shape height.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void ReSize(Primitive shapeName, Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Dictionary<string, ScaleTransform> _scaleTransformMap;
            ScaleTransform scaleTransform;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _scaleTransformMap = (Dictionary<string, ScaleTransform>)GraphicsWindowType.GetField("_scaleTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            FrameworkElement frameworkElement = obj as FrameworkElement;
                            if (!(obj.RenderTransform is TransformGroup))
                            {
                                obj.RenderTransform = new TransformGroup();
                            }
                            if (!_scaleTransformMap.TryGetValue((string)shapeName, out scaleTransform))
                            {
                                scaleTransform = new ScaleTransform();
                                _scaleTransformMap[shapeName] = scaleTransform;
                                if (frameworkElement != null)
                                {
                                    scaleTransform.CenterX = frameworkElement.ActualWidth / 2.0;
                                    scaleTransform.CenterY = frameworkElement.ActualHeight / 2.0;
                                }
                                ((TransformGroup)obj.RenderTransform).Children.Add(scaleTransform);
                            }
                            if (frameworkElement != null)
                            {
                                scaleTransform.ScaleX = width / frameworkElement.Width;
                                scaleTransform.ScaleY = height / frameworkElement.Height;
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Reset the size of a shape as if it was created with the new size.
        /// The position (top left point) is unchanged.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="width">
        /// The shape width.
        /// </param>
        /// <param name="height">
        /// The shape height.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetSize(Primitive shapeName, Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            FrameworkElement frameworkElement = obj as FrameworkElement;
                            frameworkElement.Width = width;
                            frameworkElement.Height = height;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Centre the shape on a point, also woks for zoomed shapes.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <param name="x">
        /// The x coordinate of the centre.
        /// </param>
        /// <param name="y">
        /// The y coordinate of the centre.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Centre(Primitive shapeName, Primitive x, Primitive y)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Polygon))
                            {
                                Polygon shape = (Polygon)obj;
                                int numPoint = shape.Points.Count;
                                double centreX = 0;
                                double centreY = 0;
                                for (int i = 0; i < numPoint; i++)
                                {
                                    centreX += shape.Points[i].X;
                                    centreY += shape.Points[i].Y;
                                }
                                centreX /= (double)numPoint;
                                centreY /= (double)numPoint;
                                PointCollection pointCollection = new PointCollection();
                                for (int i = 0; i < numPoint; i++)
                                {
                                    pointCollection.Add(new Point(shape.Points[i].X + x - centreX, shape.Points[i].Y + y - centreY));
                                }
                                shape.Points = pointCollection;
                            }
                            else if (obj.GetType() == typeof(Line))
                            {
                                Line shape = (Line)obj;
                                double vecX = shape.X2 - shape.X1;
                                double vecY = shape.Y2 - shape.Y1;
                                shape.X1 = (2 * x - vecX) / 2.0;
                                shape.X2 = (2 * x + vecX) / 2.0;
                                shape.Y1 = (2 * y - vecY) / 2.0;
                                shape.Y2 = (2 * y + vecY) / 2.0;
                            }
                            else
                            {
                                FrameworkElement frameworkElement = obj as FrameworkElement;
                                Canvas.SetLeft(obj, x - frameworkElement.ActualWidth / 2.0);
                                Canvas.SetTop(obj, y - frameworkElement.ActualHeight / 2.0);
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get the left position of a shape (works for triangles, polygons and lines).
        /// Also works for shapes while animating.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <returns>
        /// The x coordinate of the left edge of the shape.
        /// </returns>
        public static Primitive GetLeft(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        return Canvas.GetLeft(obj).ToString(CultureInfo.InvariantCulture);
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Get the top position of a shape (works for triangles, polygons and lines).
        /// Also works for shapes while animating.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <returns>
        /// The y coordinate of the top edge of the shape.
        /// </returns>
        public static Primitive GetTop(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        return Canvas.GetTop(obj).ToString(CultureInfo.InvariantCulture);
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Get the shape's visible (including zoom) width.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <returns>
        /// The shape visible width.
        /// </returns>
        public static Primitive Width(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return 0;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        FrameworkElement frameworkElement = obj as FrameworkElement;
                        return frameworkElement.ActualWidth.ToString(CultureInfo.InvariantCulture);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return 0;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Get the shape's visible (including zoom) height.
        /// </summary>
        /// <param name="shapeName">
        /// The shape or control name.
        /// </param>
        /// <returns>
        /// The shape visible height.
        /// </returns>
        public static Primitive Height(Primitive shapeName)
        {

            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return 0;
                }

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        FrameworkElement frameworkElement = obj as FrameworkElement;
                        return frameworkElement.ActualHeight.ToString(CultureInfo.InvariantCulture);
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return 0;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Set or change an image in a button or image shape.
        /// </summary>
        /// <param name="shapeName">
        /// The image or button name.
        /// </param>
        /// <param name="imageName">
        /// The image to load.
        /// Value returned from ImageList.LoadImage or local or network image file.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void SetImage(Primitive shapeName, Primitive imageName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ImageListType = typeof(ImageList);
            Dictionary<string, UIElement> _objectsMap;
            Dictionary<string, BitmapSource> _savedImages;
            UIElement obj;
            BitmapSource img;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return;
                    }
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (obj.GetType() == typeof(Image))
                        {
                            Image shape = ((Image)obj);
                            shape.Source = img;
                            shape.Stretch = Stretch.Fill;
                        }
                        else if (obj.GetType() == typeof(Button))
                        {
                            Image image = new Image();
                            image.Source = img;
                            image.Stretch = Stretch.Fill;
                            Button shape = ((Button)obj);
                            shape.Content = image;
                            shape.Padding = new Thickness(0.0);
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
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Creates an animated gif shape.  
        /// Do not add a very large number of these or performance may be degraded.
        /// </summary>
        /// <param name="imageName">
        /// The animated gif file (local or network) to load.
        /// </param>
        /// <param name="repeat">
        /// Continuously repeat the animation "True" or "False".
        /// </param>
        /// <returns>
        /// The animated gif shape name.
        /// </returns>
        public static Primitive AddAnimatedGif(Primitive imageName, Primitive repeat)
        {
            if (((string)imageName).StartsWith("http")) imageName = Network.DownloadFile(imageName);
            GraphicsWindow.Show();
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Dictionary<string, UIElement> _objectsMap;
            Canvas _mainCanvas;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Image" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(imageName);
                        System.Drawing.Imaging.FrameDimension fd = new System.Drawing.Imaging.FrameDimension(bitmap.FrameDimensionsList[0]);
                        int frameCount = bitmap.GetFrameCount(fd);

                        if (frameCount > 1)
                        {
                            Animated anim = new Animated();
                            animated.Add(anim);
                            anim.name = shapeName;
                            anim.frames = new Frame[frameCount];
                            anim.repeat = repeat;

                            //0x5100 is the property id of the GIF frame's durations
                            //this property does not exist when frameCount <= 1
                            byte[] times = bitmap.GetPropertyItem(0x5100).Value;

                            for (int i = 0; i < frameCount; i++)
                            {
                                //selects GIF frame based on FrameDimension and frameIndex
                                bitmap.SelectActiveFrame(fd, i);

                                //length in milliseconds of display duration
                                int length = BitConverter.ToInt32(times, 4 * i) * 10;

                                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                                new System.Drawing.Bitmap(bitmap).Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                                BitmapImage bi = new BitmapImage();
                                bi.BeginInit();
                                bi.StreamSource = stream;
                                bi.EndInit();

                                anim.frames[i] = new Frame(length, bi);
                            }

                            Image shape = new Image();
                            shape.Source = anim.frames[0].bi;
                            shape.Stretch = Stretch.Fill;
                            shape.Name = shapeName;
                            shape.Width = shape.Source.Width;
                            shape.Height = shape.Source.Height;
                            anim.shape = shape;

                            if (null == animationTimer)
                            {
                                animationTimer = new System.Windows.Forms.Timer();
                                animationTimer.Enabled = animationInterval > 0;
                                if (animationInterval > 0) animationTimer.Interval = animationInterval;
                                animationTimer.Tick += new System.EventHandler(animation_Tick);
                            }

                            _objectsMap[shapeName] = shape;
                            _mainCanvas.Children.Add(shape);
                            return shapeName;
                        }
                        return "";
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
        /// Creates an animation from a single image with multiple images on one layer.  
        /// Do not add a very large number of these or performance may be degraded.
        /// </summary>
        /// <param name="imageName">
        /// The image file (local or network) to load.
        /// Can also be an ImageList image.
        /// </param>
        /// <param name="repeat">
        /// Continuously repeat the animation "True" or "False".
        /// </param>
        /// <param name="countX">
        /// The number of sub-images in the X direction.
        /// </param>
        /// <param name="countY">
        /// The number of sub-images in the Y direction.
        /// </param>
        /// <returns>
        /// The animated shape name.
        /// </returns>
        public static Primitive AddAnimatedImage(Primitive imageName, Primitive repeat, Primitive countX, Primitive countY)
        {
            GraphicsWindow.Show();
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Type ImageListType = typeof(ImageList);
            Dictionary<string, UIElement> _objectsMap;
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;
            Canvas _mainCanvas;
            string shapeName;

            try
            {
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return "";
                    }
                }

                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "Image" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        //System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(imageName);
                        System.Drawing.Bitmap bitmap;
                        using (MemoryStream outStream = new MemoryStream())
                        {
                            BitmapEncoder enc = new PngBitmapEncoder();
                            enc.Frames.Add(BitmapFrame.Create(img));
                            enc.Save(outStream);
                            bitmap = new System.Drawing.Bitmap(outStream);
                        }

                        int frameCount = countX * countY;

                        if (frameCount > 1)
                        {
                            Animated anim = new Animated();
                            animated.Add(anim);
                            anim.name = shapeName;
                            anim.frames = new Frame[frameCount];
                            anim.repeat = repeat;

                            int w = bitmap.Width / countX;
                            int h = bitmap.Height / countY;

                            for (int j = 0; j < countY; j++)
                            {
                                for (int i = 0; i < countX; i++)
                                {
                                    System.Drawing.RectangleF cloneRect = new System.Drawing.RectangleF(w * i, h * j, w, h);
                                    System.Drawing.Bitmap crop = bitmap.Clone(cloneRect, bitmap.PixelFormat);

                                    System.IO.MemoryStream stream = new System.IO.MemoryStream();
                                    new System.Drawing.Bitmap(crop).Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                                    BitmapImage bi = new BitmapImage();
                                    bi.BeginInit();
                                    bi.StreamSource = stream;
                                    bi.EndInit();

                                    anim.frames[j * countX + i] = new Frame(0, bi);
                                }
                            }

                            Image shape = new Image();
                            shape.Source = anim.frames[0].bi;
                            shape.Stretch = Stretch.Fill;
                            shape.Name = shapeName;
                            shape.Width = shape.Source.Width;
                            shape.Height = shape.Source.Height;
                            anim.shape = shape;

                            if (null == animationTimer)
                            {
                                animationTimer = new System.Windows.Forms.Timer();
                                animationTimer.Enabled = animationInterval > 0;
                                if (animationInterval > 0) animationTimer.Interval = animationInterval;
                                animationTimer.Tick += new System.EventHandler(animation_Tick);
                            }

                            _objectsMap[shapeName] = shape;
                            _mainCanvas.Children.Add(shape);
                            return shapeName;
                        }
                        return "";
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
        /// The update interval for animated images in ms (default 100).
        /// A value of zero will pause all animated image updates, for example allowing AnimationSet to set images as required.
        /// This is an internal timer that applies to all animated images that are not paused or completed a non-repeating cycle.
        /// </summary>
        public static Primitive AnimationInterval
        {
            get { return animationInterval; }
            set
            {
                Type GraphicsWindowType = typeof(GraphicsWindow);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        animationInterval = value;
                        if (null != animationTimer)
                        {
                            if (animationInterval > 0) animationTimer.Interval = animationInterval;
                            animationTimer.Enabled = animationInterval > 0;
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
        }

        /// <summary>
        /// Reset animated image to a selected image.
        /// </summary>
        /// <param name="shapeName">
        /// The animated image shape name.
        /// </param>
        /// <param name="image">
        /// The selected animated image number (indexed from 1).
        /// </param>
        public static void AnimationSet(Primitive shapeName, Primitive image)
        {
            foreach (Animated anim in animated)
            {
                if (anim.name == shapeName)
                {
                    anim.iFrame = image - 2;
                    updateGif(anim);
                }
            }
        }

        /// <summary>
        /// Get the number of images in an animated image.
        /// </summary>
        /// <param name="shapeName">
        /// The animated image shape name.
        /// </param>
        /// <returns>The number of images in the animated image.</returns>
        public static Primitive AnimationCount(Primitive shapeName)
        {
            foreach (Animated anim in animated)
            {
                if (anim.name == shapeName) return anim.frames.Length;
            }
            return 0;
        }

        /// <summary>
        /// Pause an animated image.
        /// Paused images can still be updated using AnimationSet
        /// </summary>
        /// <param name="shapeName">
        /// The animated image shape name.
        /// </param>
        public static void AnimationPause(Primitive shapeName)
        {
            foreach (Animated anim in animated)
            {
                if (anim.name == shapeName)
                {
                    anim.paused = true;
                }
            }
        }

        /// <summary>
        /// Resume a previously paused animated image.
        /// </summary>
        /// <param name="shapeName">
        /// The animated image shape name.
        /// </param>
        public static void AnimationResume(Primitive shapeName)
        {
            foreach (Animated anim in animated)
            {
                if (anim.name == shapeName)
                {
                    anim.paused = false;
                }
            }
        }

        /// <summary>
        /// Get an array of all of the shapes (if any) at the specified coordinates.
        /// The coordinates could be the mouse coordinates for example.
        /// </summary>
        /// <param name="x">The X coordinate</param>
        /// <param name="y">The Y coordinate</param>
        /// <returns>
        /// An array of shape names or "False".
        /// For multiple shapes, the returned array is ordered from top visual layer to bottom.
        /// </returns>
        public static Primitive GetAllShapesAt(Primitive x, Primitive y)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Canvas _mainCanvas;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    Point pt = new Point(x, y);
                    HitTestResults.Clear();
                    VisualTreeHelper.HitTest(_mainCanvas, null, new HitTestResultCallback(_HitTestResult), new PointHitTestParameters(pt));

                    Primitive result = "False";
                    int i = 0;
                    foreach (HitTestResult j in HitTestResults)
                    {
                        obj = (UIElement)j.VisualHit;
                        foreach (KeyValuePair<string, UIElement> k in _objectsMap)
                        {
                            if (obj == k.Value)
                            {
                                result[++i] = k.Key;
                                break;
                            }
                        }
                    }
                    return result;
                });
                MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "False";
            }
        }

        /// <summary>
        /// Set a shape to animate opacity, flash (fade out and in).
        /// </summary>
        /// <param name="shapeName">The shape or control to flash.</param>
        /// <param name="interval">The interval in ms for a complete flash cycle.
        /// A value of 0 will stop the flashing.</param>
        /// <param name="count">The number of flashes.
        /// A value of 0 will flash continuously.</param>
        public static void AnimateOpacity(Primitive shapeName, Primitive interval, Primitive count)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    try
                    {
                        InvokeHelper ret = new InvokeHelper(delegate
                        {
                            if (interval > 0)
                            {
                                DoubleAnimation animation = new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(interval / 2));
                                animation.AccelerationRatio = 0.4;
                                animation.DecelerationRatio = 0.4;
                                animation.RepeatBehavior = (count > 0) ? new RepeatBehavior(count) : RepeatBehavior.Forever;
                                animation.AutoReverse = true;
                                obj.BeginAnimation(UIElement.OpacityProperty, animation);
                            }
                            else
                            {
                                obj.BeginAnimation(UIElement.OpacityProperty, null);
                            }
                        });
                        MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                        method.Invoke(null, new object[] { ret });
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set a shape to animate rotation (rotate continuously).
        /// </summary>
        /// <param name="shapeName">The shape or control to rotate.</param>
        /// <param name="interval">The interval in ms for a complete 360 degree rotation.
        /// A value of 0 will stop the rotation.
        /// A value less than 0 will rotate anti-clockwise.</param>
        /// <param name="count">The number of rotations.
        /// A value of 0 will rotate continuously.</param>
        public static void AnimateRotation(Primitive shapeName, Primitive interval, Primitive count)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Dictionary<string, UIElement> _objectsMap;
            Dictionary<string, RotateTransform> _rotateTransformMap;
            UIElement obj;
            RotateTransform rotateTransform;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _rotateTransformMap = (Dictionary<string, RotateTransform>)ShapesType.GetField("_rotateTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_rotateTransformMap.TryGetValue((string)shapeName, out rotateTransform))
                {
                    Shapes.Rotate(shapeName, 0);
                    Utilities.doUpdates();
                }
                if (_objectsMap.TryGetValue((string)shapeName, out obj) && _rotateTransformMap.TryGetValue((string)shapeName, out rotateTransform))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (interval != 0)
                            {
                                double start = interval > 0 ? 0 : 360;
                                double end = interval > 0 ? 360 : 0;
                                DoubleAnimation animation = new DoubleAnimation(start, end, TimeSpan.FromMilliseconds(System.Math.Abs(interval)));
                                animation.RepeatBehavior = (count > 0) ? new RepeatBehavior(count) : RepeatBehavior.Forever;
                                animation.AutoReverse = false;
                                rotateTransform.BeginAnimation(RotateTransform.AngleProperty, animation);
                            }
                            else
                            {
                                rotateTransform.BeginAnimation(RotateTransform.AngleProperty, null);
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set a shape to animate zooming (in and out).
        /// </summary>
        /// <param name="shapeName">The shape or control to zoom.</param>
        /// <param name="interval">The interval in ms for a complete zoom cycle.
        /// A value of 0 will stop the zooming.</param>
        /// <param name="count">The number of zoom cycles.
        /// A value of 0 will zoom continuously.</param>
        /// <param name="scaleX">The X zoom scale factor.</param>
        /// <param name="scaleY">The Y zoom scale factor.</param>
        public static void AnimateZoom(Primitive shapeName, Primitive interval, Primitive count, Primitive scaleX, Primitive scaleY)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Dictionary<string, UIElement> _objectsMap;
            Dictionary<string, ScaleTransform> _scaleTransformMap;
            UIElement obj;
            ScaleTransform scaleTransform;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _scaleTransformMap = (Dictionary<string, ScaleTransform>)ShapesType.GetField("_scaleTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_scaleTransformMap.TryGetValue((string)shapeName, out scaleTransform))
                {
                    Shapes.Zoom(shapeName, 1, 1);
                    Utilities.doUpdates();
                }
                if (_objectsMap.TryGetValue((string)shapeName, out obj) && _scaleTransformMap.TryGetValue((string)shapeName, out scaleTransform))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (interval != 0)
                            {
                                DoubleAnimation animationX = new DoubleAnimation(1, scaleX, TimeSpan.FromMilliseconds(interval / 2));
                                animationX.RepeatBehavior = (count > 0) ? new RepeatBehavior(count) : RepeatBehavior.Forever;
                                animationX.AutoReverse = true;
                                animationX.AccelerationRatio = 0.4;
                                animationX.DecelerationRatio = 0.4;
                                DoubleAnimation animationY = new DoubleAnimation(1, scaleY, TimeSpan.FromMilliseconds(interval / 2));
                                animationY.RepeatBehavior = (count > 0) ? new RepeatBehavior(count) : RepeatBehavior.Forever;
                                animationY.AutoReverse = true;
                                animationY.AccelerationRatio = 0.4;
                                animationY.DecelerationRatio = 0.4;
                                scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, animationX);
                                scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, animationY);
                            }
                            else
                            {
                                scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, null);
                                scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, null);
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
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Register a shape to record mouse events: MouseDown, MouseUp, MouseEnter, MouseLeave, GotFocus and LostFocus.
        /// </summary>
        /// <param name="shapeName">The shape or control to add.</param>
        public static void SetShapeEvent(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            ((FrameworkElement)obj).Name = shapeName;
                            obj.MouseDown += new MouseButtonEventHandler(_ShapeEventsMouseDown);
                            obj.MouseUp += new MouseButtonEventHandler(_ShapeEventsMouseUp);
                            obj.MouseEnter += new MouseEventHandler(_ShapeEventsMouseEnter);
                            obj.MouseLeave += new MouseEventHandler(_ShapeEventsMouseLeave);
                            obj.GotFocus += new RoutedEventHandler(_ShapeEventsGotFocus);
                            obj.LostFocus += new RoutedEventHandler(_ShapeEventsLostFocus);
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Event when a shape event occurs to a registered shape (SetShapeEvent)
        /// </summary>
        public static event SmallBasicCallback ShapeEvent
        {
            add
            {
                _ShapeEventsDelegate = value;
            }
            remove
            {
                _ShapeEventsDelegate = null;
            }
        }

        /// <summary>
        /// The last shape for which an event occured (ShapeEvent).
        /// </summary>
        public static Primitive LastEventShape
        {
            get { return lastEventShape; }
        }

        /// <summary>
        /// The last shape event type which an event occured (ShapeEvent).  May be one of the following.
        /// "MouseDown"
        /// "MouseUp"
        /// "MouseEnter"
        /// "MouseLeave"
        /// "GotFocus"
        /// "LostFocus"
        /// </summary>
        public static Primitive LastEventType
        {
            get { return lastEventType; }
        }

        /// <summary>
        /// Get an array of all currently created shapes.
        /// </summary>
        /// <returns>An array of shape names.</returns>
        public static Primitive GetAllShapes()
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            string result = "";

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                int i = 1;
                foreach (KeyValuePair<string, UIElement> obj in _objectsMap)
                {
                    result += (i++).ToString() + "=" + Utilities.ArrayParse(obj.Key) + ";";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Gets the opacity of a shape.
        /// </summary>
        /// <param name="shapeName">
        /// The name of the shape.
        /// </param>
        /// <returns>
        /// The opacity of the object as a value between 0 and 100.  0 is completely transparent and 100 is completely opaque.
        /// </returns>
        public static Primitive GetOpacity(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        return (obj.Opacity * 100).ToString(CultureInfo.InvariantCulture);
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return 0;
        }

        /// <summary>
        /// Zoom all shapes.
        /// </summary>
        /// <param name="scaleX">The x-axis zoom level.</param>
        /// <param name="scaleY">The y-axis zoom level.</param>
        public static void ZoomAll(Primitive scaleX, Primitive scaleY)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Dictionary<string, UIElement> _objectsMap;
            Dictionary<string, ScaleTransform> _scaleTransformMap;
            string shapeName;
            ScaleTransform scaleTransform;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _scaleTransformMap = (Dictionary<string, ScaleTransform>)GraphicsWindowType.GetField("_scaleTransformMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        foreach (var pair in _objectsMap)
                        {
                            shapeName = pair.Key;
                            if (_scaleTransformMap.TryGetValue(shapeName, out scaleTransform))
                            {
                                scaleTransform.ScaleX = scaleX;
                                scaleTransform.ScaleY = scaleY;
                            }
                            else
                            {
                                Shapes.Zoom(shapeName, scaleX, scaleY);
                            }
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
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Skews the shape with the specified name by the specified angles.
        /// </summary>
        /// <param name="shapeName">
        /// The name of the shape to skew.
        /// </param>
        /// <param name="angleX">
        /// The angle to skew the shape in the X direction.
        /// </param>
        /// <param name="angleY">
        /// The angle to skew the shape in the Y direction.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void Skew(Primitive shapeName, Primitive angleX, Primitive angleY)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return;
                }

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        if (!(obj.RenderTransform is TransformGroup))
                        {
                            obj.RenderTransform = new TransformGroup();
                        }
                        SkewTransform skewTransform;
                        if (!_skewTransformMap.TryGetValue(shapeName, out skewTransform))
                        {
                            skewTransform = new SkewTransform();
                            _skewTransformMap[shapeName] = skewTransform;
                            FrameworkElement frameworkElement = obj as FrameworkElement;
                            if (frameworkElement != null)
                            {
                                skewTransform.CenterX = frameworkElement.ActualWidth / 2.0;
                                skewTransform.CenterY = frameworkElement.ActualHeight / 2.0;
                            }
                            ((TransformGroup)obj.RenderTransform).Children.Add(skewTransform);
                        }
                        skewTransform.AngleX = angleX;
                        skewTransform.AngleY = angleY;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { ret });
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }
}