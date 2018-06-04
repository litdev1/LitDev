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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using Microsoft.SmallBasic.Library;
using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using System.Windows.Media;
using Microsoft.SmallBasic.Library.Internal;
using System.Windows.Shapes;
using SBArray = Microsoft.SmallBasic.Library.Array;
using System.Windows.Media.Animation;
using LitDev.Engines;

namespace LitDev
{
    public class Segment
    {
        public string chart;
        public string label;
        public double x, y, w, h;

        public Segment(double x, double y, double w, double h, string chart, string label)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.chart = chart;
            this.label = label;
        }
    }

    public class Chart : Canvas
    {
        public enum Styles { PIE, DOUGHNUT, BUBBLE, BAR, COLUMN };
        public enum Legends { NONE, LEGEND, OVERLAY, PERCENT, LEGEND_PERCENT };
        public enum HSL { HUE, SATURATION, LIGHTNESS };
        public Styles eStyle;
        public List<double> Values;
        public List<string> Labels;
        public int Count;
        public double Total;
        public double Min, Max;
        Brush foreground;
        FontFamily fontFamily;
        double fontSize;
        FontWeight fontWeight;
        FontStyle fontStyle;

        public Legends eLegend;
        public bool bLegendBackground;
        public double legendScale;
        public double scale;

        public double hue;
        public double saturation;
        public double lightness;
        public HSL eHSL;
        public double startColor;
        public double endColor;
        public string centralColour;

        public double xc, yc, rad;

        public Chart(double width, double height)
        {
            Width = width;
            Height = height;
            Reset();
        }

        public void Reset()
        {
            Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.BackgroundColor));
            foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(GraphicsWindow.PenColor));
            fontFamily = new FontFamily(GraphicsWindow.FontName);
            fontSize = GraphicsWindow.FontSize;
            fontWeight = GraphicsWindow.FontBold ? FontWeights.Bold : FontWeights.Normal;
            fontStyle = GraphicsWindow.FontItalic ? FontStyles.Italic : FontStyles.Normal;

            eStyle = Styles.PIE;
            Values = new List<double>();
            Labels = new List<string>();
            Count = 0;

            eLegend = Legends.LEGEND_PERCENT;
            bLegendBackground = false;
            legendScale = 1.0;
            scale = 1.0;

            hue = 0;
            saturation = 0.5;
            lightness = 0.5;
            startColor = 0;
            endColor = 1;
            centralColour = "";
            eHSL = HSL.HUE;

            Update();
        }

        public void SetData(Primitive data)
        {
            Primitive indices = SBArray.GetAllIndices(data);
            Count = SBArray.GetItemCount(indices);
            string index;
            double value;
            Values.Clear();
            Labels.Clear();
            Total = 0;
            Min = 0;
            Max = -double.MaxValue;
            for (int i = 1; i <= Count; i++)
            {
                index = indices[i];
                value = data[index];
                Labels.Add(index);
                Total += value;
                Min = System.Math.Min(Min, value);
                Max = System.Math.Max(Max, value);
                Values.Add(value);
            }
            Update();
        }

        public void Update()
        {
            Children.Clear();
            xc = Width / 2.0;
            yc = Height / 2.0;
            rad = scale * System.Math.Min(Width / 2.5, Height / 2.5);

            if (eLegend == Legends.LEGEND || eLegend == Legends.LEGEND_PERCENT)
            {
                rad *= 0.7;
                xc -= 0.8 * (xc - rad);
            }

            double angle = 0;
            double x1 = rad, y1 = 0, x2, y2;
            Size size = new Size(0, 0);
            Color col = Colors.White;
            Brush brush;
            Ellipse ellipse;
            Rectangle rectangle;
            TextBlock textblock;

            for (int i = 0; i < Count; i++)
            {
                double frac = startColor + (endColor - startColor) * i / (double)(Count);
                switch (eHSL)
                {
                    case HSL.HUE:
                        col = (Color)ColorConverter.ConvertFromString(LDColours.HSLtoRGB(360 * frac, saturation, lightness));
                        break;
                    case HSL.SATURATION:
                        col = (Color)ColorConverter.ConvertFromString(LDColours.HSLtoRGB(hue, frac, lightness));
                        break;
                    case HSL.LIGHTNESS:
                        col = (Color)ColorConverter.ConvertFromString(LDColours.HSLtoRGB(hue, saturation, frac));
                        break;
                }
                brush = new SolidColorBrush(col);
                if (centralColour != "")
                {
                    GradientBrush gradientBrush = new GradientBrush("", new Primitive("1=" + centralColour + ";2=" + col.ToString() + ";"), "");
                    brush = gradientBrush.getBrush();
                }

                angle += 2 * System.Math.PI * Values[i] / Total;
                x2 = rad + rad * System.Math.Sin(angle);
                y2 = rad - rad * System.Math.Cos(angle);
                bool bLargeArc = (Values[i] / Total) > 0.5;

                switch (eStyle)
                {
                    case Styles.PIE:
                    case Styles.DOUGHNUT:
                        {
                            PathSegmentCollection pathSegments = new PathSegmentCollection();
                            pathSegments.Add(new LineSegment(new Point(x1, y1), false));
                            pathSegments.Add(new ArcSegment(new Point(x2, y2), new Size(rad, rad), angle, bLargeArc, SweepDirection.Clockwise, false));
                            PathFigureCollection pathFigures = new PathFigureCollection();
                            pathFigures.Add(new PathFigure(new Point(rad, rad), pathSegments, true));
                            PathFigureCollection figCollection = new PathFigureCollection(pathFigures);

                            ellipse = new Ellipse { Width = 2 * rad, Height = 2 * rad, Fill = brush };
                            ellipse.Clip = new PathGeometry(figCollection);
                            ellipse.Tag = new Segment(xc, yc, rad, rad, Name, Labels[i]);
                            ellipse.MouseDown += new MouseButtonEventHandler(_ValueClickedEvent);
                            Children.Add(ellipse);
                            Chart.SetLeft(ellipse, xc - rad);
                            Chart.SetTop(ellipse, yc - rad);
                        }
                        break;
                    case Styles.BUBBLE:
                        {
                            double sin = System.Math.Sin(System.Math.PI * Values[i] / Total);
                            double r = rad * sin / (1.0 + sin);
                            angle -= System.Math.PI * Values[i] / Total;
                            double x = xc + (rad - r) * System.Math.Sin(angle);
                            double y = yc - (rad - r) * System.Math.Cos(angle);
                            angle += System.Math.PI * Values[i] / Total;
                            ellipse = new Ellipse { Width = 2 * r, Height = 2 * r, Fill = brush };
                            ellipse.Tag = new Segment(x, y, r, r, Name, Labels[i]);
                            ellipse.MouseDown += new MouseButtonEventHandler(_ValueClickedEvent);
                            Children.Add(ellipse);
                            Chart.SetLeft(ellipse, x - r);
                            Chart.SetTop(ellipse, y - r);
                        }
                        break;
                    case Styles.BAR:
                        {
                            double w = rad * (Values[i] - Min) / (Max - Min);
                            double h = rad / (double)Count;
                            double x = xc - rad + w;
                            double y = yc - rad + (2 * i + 1) * h;
                            rectangle = new Rectangle { Width = 2 * w, Height = 2 * h, Fill = brush };
                            rectangle.Tag = new Segment(x, y, w, h, Name, Labels[i]);
                            rectangle.MouseDown += new MouseButtonEventHandler(_ValueClickedEvent);
                            Children.Add(rectangle);
                            Chart.SetLeft(rectangle, x - w);
                            Chart.SetTop(rectangle, y - h);
                        }
                        break;
                    case Styles.COLUMN:
                        {
                            double w = rad / (double)Count;
                            double h = rad * (Values[i] - Min) / (Max - Min);
                            double x = xc - rad + (2 * i + 1) * w;
                            double y = yc + rad - h;
                            rectangle = new Rectangle { Width = 2 * w, Height = 2 * h, Fill = brush };
                            rectangle.Tag = new Segment(x, y, w, h, Name, Labels[i]);
                            rectangle.MouseDown += new MouseButtonEventHandler(_ValueClickedEvent);
                            Children.Add(rectangle);
                            Chart.SetLeft(rectangle, x - w);
                            Chart.SetTop(rectangle, y - h);
                        }
                        break;
                }

                brush = new SolidColorBrush(col);
                x1 = x2;
                y1 = y2;

                if (eLegend == Legends.OVERLAY || eLegend == Legends.PERCENT || eLegend == Legends.LEGEND_PERCENT)
                {
                    textblock = new TextBlock
                    {
                        Text = eLegend == Legends.OVERLAY ? Labels[i] : string.Format("{0:F1}%", 100 * Values[i] / Total),
                        Foreground = foreground,
                        FontFamily = fontFamily,
                        FontSize = fontSize,
                        FontWeight = fontWeight,
                        FontStyle = fontStyle
                    };
                    if (bLegendBackground) textblock.Background = brush;
                    textblock.FontSize *= legendScale;
                    textblock.MouseDown += new MouseButtonEventHandler(_ValueClickedEvent);
                    Children.Add(textblock);
                    textblock.Measure(size);
                    textblock.Arrange(new Rect(size));
                    angle -= System.Math.PI * Values[i] / Total;
                    double w = textblock.ActualWidth / 2.0;
                    double h = textblock.ActualHeight / 2.0;
                    if (eStyle == Styles.PIE)
                    {
                        x2 = xc + 0.67 * rad * System.Math.Sin(angle);
                        y2 = yc - 0.67 * rad * System.Math.Cos(angle);
                    }
                    else if (eStyle == Styles.DOUGHNUT)
                    {
                        x2 = xc + (1 + LDChart.DoughnutFraction) / 2.0 * rad * System.Math.Sin(angle);
                        y2 = yc - (1 + LDChart.DoughnutFraction) / 2.0 * rad * System.Math.Cos(angle);
                    }
                    else if (eStyle == Styles.BUBBLE)
                    {
                        double sin = System.Math.Sin(System.Math.PI * Values[i] / Total);
                        double r = rad * sin / (1.0 + sin);
                        x2 = xc + (rad - r) * System.Math.Sin(angle);
                        y2 = yc - (rad - r) * System.Math.Cos(angle);
                    }
                    else if (eStyle == Styles.BAR)
                    {
                        //x2 = xc - rad + rad * (Values[i] - Min) / (Max - Min);
                        x2 = xc - rad + w + 5;
                        y2 = yc - rad + (2 * i + 1) * rad / (double)Count;
                    }
                    else if (eStyle == Styles.COLUMN)
                    {
                        x2 = xc - rad + (2 * i + 1) * rad / (double)Count; 
                        //y2 = yc + rad - rad * (Values[i] - Min) / (Max - Min);
                        y2 = yc + rad - w - 5;
                        RotateTransform rotateTransform = new RotateTransform();
				        rotateTransform.CenterX = w;
				        rotateTransform.CenterY = h;
                        rotateTransform.Angle = -90;
                        textblock.RenderTransform = rotateTransform;
                    }
                    angle += System.Math.PI * Values[i] / Total;
                    textblock.Tag = new Segment(x2, y2, w, h, Name, Labels[i]);
                    Chart.SetLeft(textblock, x2 - w);
                    Chart.SetTop(textblock, y2 - h);
                    Canvas.SetZIndex(textblock, 1);
                }

                if (eLegend == Legends.LEGEND || eLegend == Legends.LEGEND_PERCENT)
                {
                    rectangle = new Rectangle { Width = 10 * legendScale, Height = 10 * legendScale, Fill = brush };
                    Children.Add(rectangle);
                    x2 = 2 * xc;
                    y2 = (Width - 15 * Count * legendScale) / 2 + 15 * i * legendScale;
                    Chart.SetLeft(rectangle, x2);
                    Chart.SetTop(rectangle, y2);
                    Canvas.SetZIndex(rectangle, 1);

                    textblock = new TextBlock
                    {
                        Text = Labels[i],
                        Foreground = foreground,
                        FontFamily = fontFamily,
                        FontSize = fontSize,
                        FontWeight = fontWeight,
                        FontStyle = fontStyle
                    };
                    if (bLegendBackground) textblock.Background = brush;
                    textblock.FontSize *= legendScale;
                    Children.Add(textblock);
                    textblock.Measure(size);
                    textblock.Arrange(new Rect(size));
                    Chart.SetLeft(textblock, x2 + 15 * legendScale);
                    Chart.SetTop(textblock, y2 + 5 * legendScale - textblock.ActualHeight / 2.0);
                    Canvas.SetZIndex(textblock, 1);
                }
            }

            if (eStyle == Styles.DOUGHNUT)
            {
                ellipse = new Ellipse { Width = 2 * LDChart.DoughnutFraction * rad, Height = 2 * LDChart.DoughnutFraction * rad, Fill = Background };
                Children.Add(ellipse);
                Chart.SetLeft(ellipse, xc - LDChart.DoughnutFraction * rad);
                Chart.SetTop(ellipse, yc - LDChart.DoughnutFraction * rad);
            }
        }

        public static string lastChart = "";
        public static string lastLabel = "";
        public static SmallBasicCallback _ValueClickedDelegate = null;
        public static void _ValueClickedEvent(Object sender, MouseButtonEventArgs e)
        {
            FrameworkElement obj = (FrameworkElement)sender;
            Segment seg = (Segment)obj.Tag;
            lastChart = seg.chart;
            lastLabel = seg.label;
            if (null != _ValueClickedDelegate) _ValueClickedDelegate();
        }
    }

    /// <summary>
    /// Chart control.
    /// </summary>
    [SmallBasicType]
    public static class LDChart
    {
        private static double doughnutFraction = 0.7;
        private static double highlightDuration = 100;

        private static void DoubleAnimateProperty(IAnimatable animatable, DependencyProperty property, double end, double timespan)
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
        }

        /// <summary>
        ///Radius fraction removed for doughnut chart, default 0.7.
        /// </summary>
        public static Primitive DoughnutFraction
        {
            get { return doughnutFraction; }
            set { doughnutFraction = value; }
        }

        /// <summary>
        ///Time in ms for Highlight animations, default 100.
        /// </summary>
        public static Primitive HighlightDuration
        {
            get { return highlightDuration; }
            set { highlightDuration = value; }
        }

        /// <summary>
        /// Event when a chart segment is clicked.
        /// </summary>
        public static event SmallBasicCallback ValueClicked
        {
            add
            {
                Chart._ValueClickedDelegate = value;
            }
            remove
            {
                Chart._ValueClickedDelegate = null;
            }
        }

        /// <summary>
        /// The last clicked chart.
        /// </summary>
        public static Primitive LastChart { get { return Chart.lastChart; } }

        /// <summary>
        /// The last clicked chart segment label.
        /// </summary>
        public static Primitive LastLabel { get { return Chart.lastLabel; } }

        /// <summary>
        /// Create a chart control.
        /// The current GraphicsWindow.BackgroundColor will be used for the background.
        /// The current GraphicsWindow.PenColor and Font properties will be used for the label text.
        /// For Example:
        /// GraphicsWindow.FontName = "Segoe UI"
        /// GraphicsWindow.FontBold = "False"
        /// </summary>
        /// <param name="width">The width of the chart.</param>
        /// <param name="height">The height of the chart.</param>
        /// <returns>The chart shape name.</returns>
        public static Primitive AddChart(Primitive width, Primitive height)
        {
            GraphicsWindow.Show();
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;
            string chartName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                chartName = method.Invoke(null, new object[] { "Control" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Chart chart = new Chart(width, height);
                        chart.Name = chartName;
                        _objectsMap[chartName] = chart;
                        _mainCanvas.Children.Add(chart);
                        return chartName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                return FastThread.InvokeWithReturn(ret).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set data for a chart.
        /// </summary>
        /// <param name="chartName">The chart name.</param>
        /// <param name="data">The data to set, which is a 1D array, indices are item names.
        /// Example:
        /// data["Fred"] = 25
        /// data["Mary"] = 15
        /// data["John"] = 40
        /// </param>
        public static void SetData(Primitive chartName, Primitive data)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)chartName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Chart))
                            {
                                Chart chart = (Chart)obj;
                                chart.SetData(data);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    FastThread.Invoke(ret);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), chartName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set chart properties.
        /// </summary>
        /// <param name="chartName">The chart name.</param>
        /// <param name="style">A style for the chart, options are:
        /// "Pie" (default)
        /// "Doughnut"
        /// "Bubble"
        /// "Bar"
        /// "Column"</param>
        /// <param name="scale">A scale factor for the chart, default 1.</param>
        public static void Properties(Primitive chartName, Primitive style, Primitive scale)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)chartName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Chart))
                            {
                                Chart chart = (Chart)obj;
                                switch (((string)style).ToLower())
                                {
                                    case "pie":
                                        chart.eStyle = Chart.Styles.PIE;
                                        break;
                                    case "doughnut":
                                        chart.eStyle = Chart.Styles.DOUGHNUT;
                                        break;
                                    case "bubble":
                                        chart.eStyle = Chart.Styles.BUBBLE;
                                        break;
                                    case "bar":
                                        chart.eStyle = Chart.Styles.BAR;
                                        break;
                                    case "column":
                                        chart.eStyle = Chart.Styles.COLUMN;
                                        break;
                                }
                                chart.scale = scale;
                                chart.Update();
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    FastThread.Invoke(ret);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), chartName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set colour mapping for the chart.
        /// </summary>
        /// <param name="chartName">The chart name.</param>
        /// <param name="hue">A hue (colour 0 to 360), default 0 (red).</param>
        /// <param name="saturation">A saturation (intensity 0 to 1), default 0.5.</param>
        /// <param name="lightness">A lightness (brightness 0 to 1), default 0.5.</param>
        /// <param name="hsl">The parameter to change for different segments, options are:
        /// "Hue" (default) rainbow colours
        /// "Saturation" increasing intensity of colour
        /// "Lightness" increasing brightness</param>
        /// <param name="start">Starting value for colour variation in the range [0 to 1], default 0.</param>
        /// <param name="end">Ending value for colour variation in the range [0 to 1], default 1.</param>
        /// <param name="centralColour">An optional circular gradient color centered on chart, default "".</param>
        public static void ColourMap(Primitive chartName, Primitive hue, Primitive saturation, Primitive lightness, Primitive hsl, Primitive start, Primitive end, Primitive centralColour)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)chartName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Chart))
                            {
                                Chart chart = (Chart)obj;
                                chart.hue = hue;
                                chart.saturation = saturation;
                                chart.lightness = lightness;
                                chart.startColor = start;
                                chart.endColor = end;
                                chart.centralColour = centralColour;
                                switch (((string)hsl).ToLower())
                                {
                                    case "hue":
                                        chart.eHSL = Chart.HSL.HUE;
                                        break;
                                    case "saturation":
                                        chart.eHSL = Chart.HSL.SATURATION;
                                        break;
                                    case "lightness":
                                        chart.eHSL = Chart.HSL.LIGHTNESS;
                                        break;
                                }
                                chart.Update();
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    FastThread.Invoke(ret);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), chartName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set legend properties.
        /// </summary>
        /// <param name="chartName">The chart name.</param>
        /// <param name="scale">A scale factor for the legend and text labels, default 1</param>
        /// <param name="legend">A legend style, options are:
        /// "None" no legend
        /// "Legend" separate legend
        /// "Overlay" names overlaying chart
        /// "Percent" percentages overlaying chart
        /// "Legend_Percent" (default) separate legend and percentages overlaying chart
        /// "</param>
        /// <param name="background">The legend label text background is coloured, "True" or "False" (default).</param>
        public static void Legend(Primitive chartName, Primitive scale, Primitive legend, Primitive background)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)chartName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Chart))
                            {
                                Chart chart = (Chart)obj;
                                switch (((string)legend).ToLower())
                                {
                                    case "none":
                                        chart.eLegend = Chart.Legends.NONE;
                                        break;
                                    case "legend":
                                        chart.eLegend = Chart.Legends.LEGEND;
                                        break;
                                    case "overlay":
                                        chart.eLegend = Chart.Legends.OVERLAY;
                                        break;
                                    case "percent":
                                        chart.eLegend = Chart.Legends.PERCENT;
                                        break;
                                    case "legend_percent":
                                        chart.eLegend = Chart.Legends.LEGEND_PERCENT;
                                        break;
                                }
                                chart.bLegendBackground = background;
                                chart.legendScale = scale;
                                chart.Update();
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    FastThread.Invoke(ret);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), chartName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Highlight a chart value (move segment out).
        /// </summary>
        /// <param name="chartName">The chart name.</param>
        /// <param name="label">The segment label.</param>
        /// <param name="fraction">A fraction of the radius to move segment out (0 to return it).</param>
        public static void Highlight(Primitive chartName, Primitive label, Primitive fraction)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)chartName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Chart))
                            {
                                Chart chart = (Chart)obj;
                                foreach (FrameworkElement elt in chart.Children)
                                {
                                    if (null != elt.Tag)
                                    {
                                        Segment seg = (Segment)elt.Tag;
                                        if (seg.label.ToLower() == ((string)(label)).ToLower())
                                        {
                                            double angle = 0;
                                            int i;
                                            for (i = 0; i < chart.Count; i++)
                                            {
                                                if (chart.Labels[i] == seg.label)
                                                {
                                                    angle += System.Math.PI * chart.Values[i] / chart.Total;
                                                    break;
                                                }
                                                angle += 2 * System.Math.PI * chart.Values[i] / chart.Total;
                                            }
                                            double dx, dy;
                                            if (chart.eStyle == Chart.Styles.BAR)
                                            {
                                                dx = fraction * chart.rad;
                                                dy = 0;
                                            }
                                            else if (chart.eStyle == Chart.Styles.COLUMN)
                                            {
                                                dx = 0;
                                                dy = -fraction * chart.rad;
                                            }
                                            else
                                            {
                                                dx = fraction * chart.rad * System.Math.Sin(angle);
                                                dy = -fraction * chart.rad * System.Math.Cos(angle);
                                            }
                                            DoubleAnimateProperty(elt, Canvas.LeftProperty, seg.x - seg.w + dx, highlightDuration);
                                            DoubleAnimateProperty(elt, Canvas.TopProperty, seg.y - seg.h + dy, highlightDuration);
                                            //Chart.SetLeft(elt, seg.x - seg.w + dx);
                                            //Chart.SetTop(elt, seg.y - seg.h + dy);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    FastThread.Invoke(ret);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), chartName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Redraw (update) a chart.
        /// This restores any highlighted segments or applies any modified chart properties.
        /// </summary>
        /// <param name="chartName">The chart name.</param>
        public static void Update(Primitive chartName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)chartName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Chart))
                            {
                                Chart chart = (Chart)obj;
                                chart.Update();
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    FastThread.Invoke(ret);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), chartName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }
}
