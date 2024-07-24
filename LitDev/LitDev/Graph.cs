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
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

using LitDev.Engines;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace LitDev
{
    /// <summary>
    /// Graphing utility.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDGraph
    {
        static LDGraph()
        {
            Instance.Verify();
        }

        private static int trendPoint = 50;
        private static Primitive trendCoef = "";

        private static GraphEngine _Engine = new GraphEngine();

        [HideFromIntellisense]
        public static void AddSeriesHitogram(Primitive graphName, Primitive seriesLabel, Primitive data, Primitive colour)
        {
            AddSeriesHistogram(graphName, seriesLabel, data, colour);
        }

        /// <summary>
        /// Create a graph.
        /// </summary>
        /// <param name="xpos">
        /// The graph left position.
        /// </param>
        /// <param name="ypos">
        /// The graph right position.
        /// </param>
        /// <param name="width">
        /// The graph width.
        /// </param>
        /// <param name="height">
        /// The graph height.
        /// </param>
        /// <param name="title">
        /// The graph title.
        /// </param>
        /// <param name="labelX">
        /// The X axis label.
        /// </param>
        /// <param name="labelY">
        /// The Y axis label.
        /// </param>
        /// <returns>
        /// The graph name.
        /// </returns>
        public static Primitive AddGraph(Primitive xpos, Primitive ypos, Primitive width, Primitive height, Primitive title, Primitive labelX, Primitive labelY)
        {
            GraphicsWindow.Show();
            string _graphName = _Engine.createGraph(width, height);
            Shapes.Move(_graphName, xpos, ypos);
            _Engine.setAxes(_graphName, title, labelX, labelY);
            _Engine.addSeries(_graphName, "", null, null, 0);
            return _graphName;
        }

        /// <summary>
        /// Add a new data series to an existing graph as a line graph.
        /// </summary>
        /// <param name="graphName">
        /// The graph name.
        /// </param>
        /// <param name="seriesLabel">
        /// The series label.
        /// If a series with this label already exists then it is replaced with this series.
        /// </param>
        /// <param name="data">
        /// An array holding the X and Y coordinate data.
        /// 
        /// For example, a line with points (0,1) and (2,3) would have
        /// data[0] = 1
        /// data[2] = 3
        /// 
        /// More generally data[x] = y.
        /// </param>
        /// <param name="colour">
        /// The colour of the series data.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void AddSeriesLine(Primitive graphName, Primitive seriesLabel, Primitive data, Primitive colour)
        {
            _Engine.addSeries(graphName, seriesLabel, data, colour, eLineType.LINE);
        }

        /// <summary>
        /// Add a new data series to an existing graph as a histogram.
        /// </summary>
        /// <param name="graphName">
        /// The graph name.
        /// </param>
        /// <param name="seriesLabel">
        /// The series label.
        /// If a series with this label already exists then it is replaced with this series.
        /// </param>
        /// <param name="data">
        /// An array holding the X and Y coordinate data.
        /// 
        /// For example, a line with points (0,1) and (2,3) would have
        /// data[0] = 1
        /// data[2] = 3
        /// 
        /// More generally data[x] = y.
        /// </param>
        /// <param name="colour">
        /// The colour of the series data.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void AddSeriesHistogram(Primitive graphName, Primitive seriesLabel, Primitive data, Primitive colour)
        {
            _Engine.addSeries(graphName, seriesLabel, data, colour, eLineType.HISTOGRAM);
        }

        /// <summary>
        /// Add a new data series to an existing graph as points.
        /// </summary>
        /// <param name="graphName">
        /// The graph name.
        /// </param>
        /// <param name="seriesLabel">
        /// The series label.
        /// If a series with this label already exists then it is replaced with this series.
        /// </param>
        /// <param name="data">
        /// An array holding the X and Y coordinate data.
        /// 
        /// For example, a line with points (0,1) and (2,3) would have
        /// data[0] = 1
        /// data[2] = 3
        /// 
        /// More generally data[x] = y.
        /// </param>
        /// <param name="colour">
        /// The colour of the series data.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void AddSeriesPoints(Primitive graphName, Primitive seriesLabel, Primitive data, Primitive colour)
        {
            _Engine.addSeries(graphName, seriesLabel, data, colour, eLineType.POINTS);
        }

        /// <summary>
        /// Delete an existing series on existing graph.
        /// </summary>
        /// <param name="graphName">
        /// The graph name.
        /// </param>
        /// <param name="seriesLabel">
        /// The series label name to delete.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void DeleteSeries(Primitive graphName, Primitive seriesLabel)
        {
            _Engine.deleteSeries(graphName, seriesLabel);
        }

        /// <summary>
        /// Stop all the graph left click mouse events.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void StopEvents()
        {
            _Engine.doEvents = false;
            _Engine.setEvents(_Engine.doEvents);
        }

        /// <summary>
        /// Restart all the graph left click mouse events.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void RestartEvents()
        {
            _Engine.doEvents = true;
            _Engine.setEvents(_Engine.doEvents);
        }

        /// <summary>
        /// Export data series directly to CSV file (no graphing).
        /// </summary>
        /// <param name="data">
        /// An array holding the X and Y coordinate data.
        /// </param>
        /// <param name="fileName">
        /// The CSV output file name.
        /// </param>
        /// <returns>
        /// None.
        /// </returns>
        public static void ExportCSV(Primitive data, Primitive fileName)
        {
            plotData _plotData = new plotData();
            _plotData.labelX = "X Value";
            _plotData.labelY = "Y Value";
            _plotData.series.Add(_Engine.createSeries("Data Series", data, "", 0));
            _Engine.exportCSV(_plotData, fileName);
        }

        /// <summary>
        /// The border colour.
        /// </summary>
        public static Primitive BorderColour
        {
            get { return _Engine.borderColour; }
            set { _Engine.borderColour = value; }
        }

        /// <summary>
        /// The interior colour.
        /// </summary>
        public static Primitive InteriorColour
        {
            get { return _Engine.interiorColour; }
            set { _Engine.interiorColour = value; }
        }

        /// <summary>
        /// The text colour.
        /// </summary>
        public static Primitive TextColour
        {
            get { return _Engine.textColour; }
            set { _Engine.textColour = value; }
        }

        /// <summary>
        /// The boundary axes and tick mark colour.
        /// </summary>
        public static Primitive AxesColour
        {
            get { return _Engine.linesColour; }
            set { _Engine.linesColour = value; }
        }

        /// <summary>
        /// The internal scale grid lines colour.
        /// </summary>
        public static Primitive GridColour
        {
            get { return _Engine.faintlinesColour; }
            set { _Engine.faintlinesColour = value; }
        }
        
        /// <summary>
        /// The number of X axes tick marks and grid lines (default 10)
        /// </summary>
        public static Primitive GridLinesX
        {
            get { return _Engine.nTickX; }
            set { _Engine.nTickX = value; }
        }

        /// <summary>
        /// The number of Y axes tick marks and grid lines (default 10)
        /// </summary>
        public static Primitive GridLinesY
        {
            get { return _Engine.nTickY; }
            set { _Engine.nTickY = value; }
        }

        /// <summary>
        /// AutoScale axes "True" (default) or "False".
        /// When set to "False" early version scaling is used.
        /// </summary>
        public static Primitive AutoScale
        {
            get { return _Engine.autoScale ? "True" : "False"; }
            set { _Engine.autoScale = value; }
        }

        /// <summary>
        /// Set the X axis scaling.
        /// This over-rides any automatic methods.
        /// </summary>
        /// <param name="graphName">The graph name.</param>
        /// <param name="min">The X axis minimum value.</param>
        /// <param name="interval">The grid spacing interval.
        /// If this value is 0 then the interval is calculated from the data.</param>
        /// <param name="max">The X axis maximum value.
        /// If this value is equal to min, then the maximum is calculated from the data.
        /// If this value is less than min, then both the minimum and maximum are calculated from the data.</param>
        public static void ScaleAxisX(Primitive graphName, Primitive min, Primitive interval, Primitive max)
        {
            _Engine.scaleAxis(graphName, min, interval, max, 0);
        }

        /// <summary>
        /// Set the Y axis scaling.
        /// This over-rides any automatic methods.
        /// </summary>
        /// <param name="graphName">The graph name.</param>
        /// <param name="min">The Y axis minimum value.</param>
        /// <param name="interval">The grid spacing interval.
        /// If this value is 0 then the interval is calculated from the data.</param>
        /// <param name="max">The Y axis maximum value.
        /// If this value is equal to min, then the maximum is calculated from the data.
        /// If this value is less than min, then both the minimum and maximum are calculated from the data.</param>
        public static void ScaleAxisY(Primitive graphName, Primitive min, Primitive interval, Primitive max)
        {
            _Engine.scaleAxis(graphName, min, interval, max, 1);
        }

        /// <summary>
        /// The axes (min and max value) significant figures (default 2).
        /// </summary>
        public static Primitive AxesResolution
        {
            get { return _Engine.resolution; }
            set { _Engine.resolution = value; }
        }

        /// <summary>
        /// This function is just to display this help.
        /// 
        /// Graphs of data can be plotted as lines, points or histograms.
        /// 
        /// Each series of data is a SmallBasic array with the array index reprenting the (unique) X value and the array value representing the Y value.
        /// 
        /// For example:
        /// data[1] = 5
        /// data[2] = 8
        /// data[3] = 3
        /// 
        /// First create a graph object with AddGraph, then add series with AddSeriesLine, AddSeriesHistogram or AddSeriesPoints.
        /// 
        /// Once a graph is created and plotted, the axes can be grabbed and scrolled where the hand cursor appears.  The legend can also be moved.
        /// 
        /// The graph can be rescaled by using the left mouse button to select a region to zoom, or the mouse wheel can be used to zoom the display.  A double click will reset the scaling to the original default.
        /// 
        /// A right click will bring up a menu with other features like export of image or data, displaying the cursor coordinates, hiding the legend etc.
        /// 
        /// Finally the various parmeters for this method give further control of the plotting colours and behaviour.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public static void Help()
        {
        }

        /// <summary>
        /// Create a trend from data.
        /// </summary>
        /// <param name="data">
        /// An array holding the X and Y coordinate data.
        /// 
        /// For example, a line with points (0,1) and (2,3) would have
        /// data[0] = 1
        /// data[2] = 3
        /// 
        /// More generally data[x] = y.
        /// </param>
        /// <param name="order">The polynomial order for the trend line.
        /// 1 is linear.
        /// 2 is quadratic.
        /// </param>
        /// <returns>A data array holding a trend that may be plotted.</returns>
        public static Primitive CreateTrend(Primitive data, Primitive order)
        {
            order++;
            string result = "";

            Type PrimitiveType = typeof(Primitive);
            Dictionary<Primitive, Primitive> _arrayMap;
            double x, y;

            try
            {
                data = Utilities.CreateArrayMap(data);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(data);

                Matrix matrix = new Matrix(order, order, -1);
                Matrix inverse = new Matrix(order, order, -1);
                Matrix lhs = new Matrix(order, 1, -1);
                Matrix rhs = new Matrix(order, 1, -1);
                double xMin = double.MaxValue;
                double xMax = -double.MaxValue;
                double mult;
                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    x = (double)kvp.Key;
                    y = (double)kvp.Value;
                    xMin = System.Math.Min(xMin, x);
                    xMax = System.Math.Max(xMax, x);
                    for (int i = 0; i < order; i++)
                    {
                        mult = System.Math.Pow(x, i);
                        for (int j = 0; j < order; j++)
                        {
                            matrix.matrix[i, j] += mult * System.Math.Pow(x, j);
                        }
                        rhs.matrix[i, 0] += mult * y;
                    }
                }
                matrix.Inverse(inverse);
                inverse.Multiply(rhs, lhs);
                for (int i = 0; i < trendPoint; i++)
                {
                    x = xMin + (xMax - xMin) * i / (double)(trendPoint - 1);
                    y = 0;
                    for (int j = 0; j < order; j++)
                    {
                        y += lhs.matrix[j, 0] * System.Math.Pow(x, j);
                    }
                    result += x.ToString(CultureInfo.InvariantCulture) + "=" + y.ToString(CultureInfo.InvariantCulture) + ";";
                }
                trendCoef = "";
                for (int i = 0; i < order; i++)
                {
                    trendCoef[i] = lhs.matrix[i, 0];
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Set or get the number of points created for a trend line using CreateTrend.
        /// Default 50.
        /// </summary>
        public static Primitive TrendPointCount
        {
            get { return trendPoint; }
            set { trendPoint = value; }
        }

        /// <summary>
        /// Get the polynomial trend line coefficients for the last calculated trend using CreateTrend.
        /// </summary>
        /// <returns>An array 'coef' of the polynomial coefficients for the trend line.
        /// The number of coefficients in the array is one larger than the order used to create the trend (order+1) and is indexed from 0.
        /// y = coef[0] + coef[1]x + coef[2]x^2 ...
        /// </returns>
        public static Primitive TrendCoef()
        {
            return trendCoef;
        }
    }
}
