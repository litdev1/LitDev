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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;

namespace LitDev.Engines
{
    public enum eLineType { LINE, HISTOGRAM, POINTS }

    class plotData
    {
        public string name;
        public double nTickX = 0, nTickY = 0;
        public double userMinX = 0, userMaxX = -1, userIntervalX = 0;
        public double userMinY = 0, userMaxY = -1, userIntervalY = 0;
        public double minX, maxX, minY, maxY, shiftX, shiftY;
        public string title;
        public string labelX;
        public string labelY;
        public bool displayLegend, displayHoverVal;
        public Point legendPosition;
        public Canvas plotarea, legend, scrollX, scrollY;
        public TextBlock hoverVal, hoverValBG;
        public Rectangle scaleArea;
        public List<seriesData> series = new List<seriesData>();

        public plotData()
        {
            name = "";
            minX = 1.0e20;
            maxX = -1.0e20;
            minY = 1.0e20;
            maxY = -1.0e20;
            shiftX = 0.0;
            shiftY = 0.0;
            title = "";
            labelX = "";
            labelY = "";
            displayLegend = true;
            displayHoverVal = false;
            legendPosition.X = 10;
            legendPosition.Y = 10;
            plotarea = null;
            legend = null;
            scrollX = null;
            scrollY = null;
            hoverVal = null;
            hoverValBG = null;
            scaleArea = null;
            series.Clear();
        }

        ~plotData()
        {
            series.Clear();
        }
    }

    class seriesData
    {
        public string name;
        public double minX, maxX, minY, maxY;
        public List<double> dataX = new List<double>();
        public List<double> dataY = new List<double>();
        public string colour;
        public eLineType type;

        public seriesData()
        {
            name = "";
            minX = 1.0e20;
            maxX = -1.0e20;
            minY = 1.0e20;
            maxY = -1.0e20;
            dataX.Clear();
            dataY.Clear();
            colour = "";
            type = eLineType.LINE;
        }

        public void CopyFrom(seriesData from)
        {
            name = from.name;
            minX = from.minX;
            maxX = from.maxX;
            minY = from.minY;
            maxY = from.maxY;
            dataX.Clear();
            dataY.Clear();
            foreach (double value in from.dataX) dataX.Add(value);
            foreach (double value in from.dataY) dataY.Add(value);
            //dataX = from.dataX;
            //dataY = from.dataY;
            colour = from.colour;
            type = from.type;
        }

        ~seriesData()
        {
            dataX.Clear();
            dataY.Clear();
        }
    }

    class GraphEngine
    {
        public string borderColour = Brushes.AntiqueWhite.ToString();
        public string interiorColour = Brushes.AliceBlue.ToString();
        public string textColour = Brushes.Black.ToString();
        public string linesColour = Brushes.Black.ToString();
        public string faintlinesColour = Brushes.LightGray.ToString();
        public bool doEvents = true;
        public double resolution = 2;
        public double borderScale = 100.0;
        public double nTickX = 10;
        public double nTickY = 10;
        public bool autoScale = true;

        private double offsetL = 40;
        private double offsetR = 10;
        private double offsetT = 30;
        private double offsetB = 40;

        private Point posDown, posUp, posLegend, posScrollX, posScrollY;
        private bool mouseDown = false;
        private bool mouseDownLegend = false;
        private bool mouseScrollX = false;
        private bool mouseScrollY = false;
        private bool isPlotting = false;

        private object[] delegate_Data;

        private enum eZoom { FALSE, TRUE };
        private enum eRescale { FALSE, TRUE };

        private List<plotData> plotInfo = new List<plotData>();

        private Brush getBrush(string colour)
        {
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
        }

        private plotData getPlotData(string graphName)
        {
            plotData _plotData = null;
            foreach (plotData i in plotInfo)
            {
                if (i.name == graphName) _plotData = i;
            }
            if (null == _plotData)
            {
                _plotData = new plotData();
                plotInfo.Add(_plotData);
                _plotData.name = graphName;
            }
            return _plotData;
        }

        private void mnuExcel_Click(Object sender, EventArgs e)
        {
            try
            {
                MenuItem _item = (MenuItem)sender;
                Canvas _graph = (Canvas)_item.Tag;
                plotData _plotData = getPlotData((string)_graph.Tag);

                object misValue = System.Reflection.Missing.Value;

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlApp.Visible = true;

                if (_plotData.title.Length > 0) xlWorkSheet.Name = _plotData.title;

                for (int i = 0; i < _plotData.series.Count; i++)
                {
                    xlWorkSheet.Cells[1, 1 + 3 * i] = _plotData.series[i].name;
                    xlWorkSheet.Cells[2, 1 + 3 * i] = _plotData.labelX;
                    xlWorkSheet.Cells[2, 2 + 3 * i] = _plotData.labelY;
                    for (int j = 0; j < _plotData.series[i].dataX.Count; j++)
                    {
                        xlWorkSheet.Cells[4 + j, 1 + 3 * i] = _plotData.series[i].dataX[j];
                        xlWorkSheet.Cells[4 + j, 2 + 3 * i] = _plotData.series[i].dataY[j];
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void mnuCSV_Click(Object sender, EventArgs e)
        {
            try
            {
                MenuItem _item = (MenuItem)sender;
                Canvas _graph = (Canvas)_item.Tag;
                plotData _plotData = getPlotData((string)_graph.Tag);

                System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
                dlg.Title = "Save data as a CSV File";
                dlg.Filter = "Comma Separated Values (*.csv)|*.csv|All Files|*.*";
                if (dlg.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK)
                {
                    exportCSV(_plotData, dlg.FileName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void mnuSave_Click(Object sender, EventArgs e)
        {
            try
            {
                MenuItem _item = (MenuItem)sender;
                Canvas _graph = (Canvas)_item.Tag;

                System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
                dlg.Title = "Save graph an image file";
                dlg.Filter = "Png|*.png|Jpg Jpeg|*.jpg|Bmp|*.bmp|Gif|*.gif|Tiff|*.tiff|All Files|*.*";
                if (dlg.ShowDialog(Utilities.ForegroundHandle()) == System.Windows.Forms.DialogResult.OK)
                {
                    Utilities.saveImage(Utilities.getBitmapFrame(_graph), dlg.FileName);

                    Canvas _manCanvas = (Canvas)_graph.Parent;
                    _manCanvas.InvalidateVisual();
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void mnuHoverVal_Click(Object sender, EventArgs e)
        {
            MenuItem _item = (MenuItem)sender;
            Canvas _graph = (Canvas)_item.Tag;
            plotData _plotData = getPlotData((string)_graph.Tag);
            Canvas _plotarea = _plotData.plotarea;
            _plotData.displayHoverVal = !_plotData.displayHoverVal;
            _item.IsChecked = _plotData.displayHoverVal;
            if (!_plotData.displayHoverVal)
            {
                _plotData.hoverVal.Text = "";
                _plotData.hoverValBG.Text = "";
            }
        }

        private void mnuLegend_Click(Object sender, EventArgs e)
        {
            MenuItem _item = (MenuItem)sender;
            Canvas _graph = (Canvas)_item.Tag;
            plotData _plotData = getPlotData((string)_graph.Tag);
            _plotData.displayLegend = !_plotData.displayLegend;
            _item.IsChecked = _plotData.displayLegend;
            plotSeries(_graph, _plotData, eZoom.FALSE, eRescale.FALSE);
        }

        private void mnuResetLegend_Click(Object sender, EventArgs e)
        {
            MenuItem _item = (MenuItem)sender;
            Canvas _graph = (Canvas)_item.Tag;
            plotData _plotData = getPlotData((string)_graph.Tag);
            _plotData.legendPosition.X = 10;
            _plotData.legendPosition.Y = 10;
            Canvas _legend = _plotData.legend;
            Canvas.SetLeft(_legend, offsetL + _plotData.legendPosition.X);
            Canvas.SetTop(_legend, offsetT + _plotData.legendPosition.Y);
            mouseDownLegend = false;
        }

        private void mnuResetZoom_Click(Object sender, EventArgs e)
        {
            MenuItem _item = (MenuItem)sender;
            Canvas _graph = (Canvas)_item.Tag;
            plotData _plotData = getPlotData((string)_graph.Tag);
            plotSeries(_graph, _plotData, eZoom.FALSE, eRescale.TRUE);
        }

        private void _MouseDownEventLegend(Object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ClickCount == 1)
                {
                    if (e.LeftButton == MouseButtonState.Pressed)
                    {
                        mouseDownLegend = true;
                        Canvas _legend = (Canvas)sender;
                        Canvas _graph = (Canvas)_legend.Parent;
                        posLegend = e.GetPosition(_graph);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseUpEventLegend(Object sender, MouseButtonEventArgs e)
        {
            mouseDownLegend = false;
        }

        private void _MouseMoveEventLegend(Object sender, MouseEventArgs e)
        {
            try
            {
                if (mouseDownLegend)
                {
                    Canvas _legend = (Canvas)sender;
                    Canvas _graph = (Canvas)_legend.Parent;
                    plotData _plotData = getPlotData((string)_graph.Tag);
                    _plotData.legendPosition += (e.GetPosition(_graph) - posLegend);
                    posLegend = e.GetPosition(_graph);
                    Canvas.SetLeft(_legend, offsetL + _plotData.legendPosition.X);
                    Canvas.SetTop(_legend, offsetT + _plotData.legendPosition.Y);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseDownEventScrollX(Object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (!mouseScrollX)
                {
                    mouseScrollX = true;
                    Canvas _scrollX = (Canvas)sender;
                    posScrollX = e.GetPosition(_scrollX);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseUpEventScrollX(Object sender, MouseButtonEventArgs e)
        {
            mouseScrollX = false;
        }

        private void _MouseMoveEventScrollX(Object sender, MouseEventArgs e)
        {
            try
            {
                if (mouseScrollX)
                {
                    Canvas _scrollX = (Canvas)sender;
                    Canvas _graph = (Canvas)_scrollX.Parent;
                    plotData _plotData = getPlotData((string)_graph.Tag);
                    _plotData.shiftX += (e.GetPosition(_scrollX).X - posScrollX.X) / _scrollX.ActualWidth * (_plotData.maxX - _plotData.minX);
                    posScrollX = e.GetPosition(_scrollX);
                    plotSeries(_graph, _plotData, eZoom.FALSE, eRescale.FALSE);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseDownEventScrollY(Object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (!mouseScrollY)
                {
                    mouseScrollY = true;
                    Canvas _scrollY = (Canvas)sender;
                    posScrollY = e.GetPosition(_scrollY);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseUpEventScrollY(Object sender, MouseButtonEventArgs e)
        {
            mouseScrollY = false;
        }

        private void _MouseMoveEventScrollY(Object sender, MouseEventArgs e)
        {
            try
            {
                if (mouseScrollY)
                {
                    Canvas _scrollY = (Canvas)sender;
                    Canvas _graph = (Canvas)_scrollY.Parent;
                    plotData _plotData = getPlotData((string)_graph.Tag);
                    _plotData.shiftY += (e.GetPosition(_scrollY).Y - posScrollY.Y) / _scrollY.ActualHeight * (_plotData.minY - _plotData.maxY);
                    posScrollY = e.GetPosition(_scrollY);
                    plotSeries(_graph, _plotData, eZoom.FALSE, eRescale.FALSE);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseDownEvent(Object sender, MouseButtonEventArgs e)
        {
            try
            {
                Canvas _plotarea = (Canvas)sender;
                Canvas _graph = (Canvas)_plotarea.Parent;
                plotData _plotData = getPlotData((string)_graph.Tag);

                posDown = e.GetPosition(_plotarea);
                if (e.ClickCount == 1)
                {
                    if (e.LeftButton == MouseButtonState.Pressed)
                    {
                        mouseDown = true;
                        _plotData.scaleArea = new Rectangle();
                        _plotData.scaleArea.Stroke = getBrush(linesColour);
                        DoubleCollection style = new DoubleCollection();
                        style.Add(2);
                        style.Add(2);
                        _plotData.scaleArea.StrokeDashArray = style;
                        _plotData.scaleArea.StrokeThickness = 1.0;
                        _plotarea.Children.Add(_plotData.scaleArea);
                    }
                    else if (e.RightButton == MouseButtonState.Pressed)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseUpEvent(Object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (mouseDown)
                {
                    Canvas _plotarea = (Canvas)sender;
                    Canvas _graph = (Canvas)_plotarea.Parent;
                    plotData _plotData = getPlotData((string)_graph.Tag);

                    posUp = e.GetPosition(_plotarea);

                    _plotarea.Children.Remove(_plotData.scaleArea);
                    _plotData.scaleArea = null;

                    if (posUp.X == posDown.X || posUp.Y == posDown.Y)
                    {
                        plotSeries(_graph, _plotData, eZoom.FALSE, eRescale.TRUE);
                    }
                    else
                    {
                        plotSeries(_graph, _plotData, eZoom.TRUE, eRescale.FALSE);
                    }
                    mouseDown = false;
                }
                mouseScrollX = false;
                mouseScrollY = false;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseMoveEvent(Object sender, MouseEventArgs e)
        {
            try
            {
                Canvas _plotarea = (Canvas)sender;
                Canvas _graph = (Canvas)_plotarea.Parent;
                plotData _plotData = getPlotData((string)_graph.Tag);

                _plotarea.Cursor = Cursors.Cross;

                if (null != _plotData.scaleArea)
                {
                    posUp = e.GetPosition(_plotarea);

                    _plotData.scaleArea.Width = System.Math.Abs(posUp.X - posDown.X);
                    _plotData.scaleArea.Height = System.Math.Abs(posUp.Y - posDown.Y);
                    Canvas.SetLeft(_plotData.scaleArea, System.Math.Min(posUp.X, posDown.X));
                    Canvas.SetTop(_plotData.scaleArea, System.Math.Min(posUp.Y, posDown.Y));
                }
                if (_plotData.displayHoverVal)
                {
                    Point pos = e.GetPosition(_plotarea);
                    double X = sigfig(_plotData.minX - _plotData.shiftX + (_plotData.maxX- _plotData.minX) * pos.X / _plotarea.ActualWidth, 5);
                    double Y = sigfig(_plotData.maxY - _plotData.shiftY + (_plotData.minY - _plotData.maxY) * pos.Y / _plotarea.ActualHeight, 5);
                    _plotData.hoverVal.Text = "(" + X.ToString() + "," + Y.ToString() + ")";
                    Canvas.SetLeft(_plotData.hoverVal, pos.X + 6);
                    Canvas.SetTop(_plotData.hoverVal, pos.Y - 20);
                    _plotData.hoverValBG.Text = _plotData.hoverVal.Text;
                    Canvas.SetLeft(_plotData.hoverValBG, pos.X + 6);
                    Canvas.SetTop(_plotData.hoverValBG, pos.Y - 20);
                }
                if (mouseScrollX)
                {
                    _plotData.shiftX += (e.GetPosition(_plotarea).X - posScrollX.X) / _plotarea.ActualWidth * (_plotData.maxX - _plotData.minX);
                    posScrollX = e.GetPosition(_plotarea);
                    if (doEvents) _plotarea.Cursor = Cursors.Hand;
                    plotSeries(_graph, _plotData, eZoom.FALSE, eRescale.FALSE);
                }
                if (mouseScrollY)
                {
                    _plotData.shiftY += (e.GetPosition(_plotarea).Y - posScrollY.Y) / _plotarea.ActualHeight * (_plotData.minY - _plotData.maxY);
                    posScrollY = e.GetPosition(_plotarea);
                    if (doEvents) _plotarea.Cursor = Cursors.Hand;
                    plotSeries(_graph, _plotData, eZoom.FALSE, eRescale.FALSE);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void _MouseWheelEvent(Object sender, MouseWheelEventArgs e)
        {
            try
            {
                Canvas _plotarea = (Canvas)sender;
                Canvas _graph = (Canvas)_plotarea.Parent;
                plotData _plotData = getPlotData((string)_graph.Tag);

                if (null == _plotData.scaleArea && !mouseScrollX && !mouseScrollY)
                {
                    posDown.X = _plotarea.ActualWidth;
                    posDown.Y = _plotarea.ActualHeight;
                    posUp.X = _plotarea.ActualWidth;
                    posUp.Y = _plotarea.ActualHeight;
                    if (e.Delta > 0)
                    {
                        posDown.X *= -0.05;
                        posDown.Y *= -0.05;
                        posUp.X *= 1.05;
                        posUp.Y *= 1.05;
                    }
                    else if (e.Delta < 0)
                    {
                        posDown.X *= 0.05;
                        posDown.Y *= 0.05;
                        posUp.X /= 1.05;
                        posUp.Y /= 1.05;
                    }
                    plotSeries(_graph, _plotData, eZoom.TRUE, eRescale.FALSE);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void round(ref double min, ref double max)
        {
            min = sigfig(min, 6);
            max = sigfig(max, 6);
            if (min == max)
            {
                min--;
                max++;
            }
            else
            {
                double range = System.Math.Abs(max - min) / borderScale;
                double mean = System.Math.Abs(max + min) / 2.0;
                if (range < 1.0e-6 * mean) range = 1.0e-6 * mean;
                min -= range;
                max += range;
            }
            double power = System.Math.Max(System.Math.Abs(min), System.Math.Abs(max));
            power = System.Math.Pow(10.0, System.Math.Ceiling(System.Math.Log10(power)) - resolution);
            min = power * System.Math.Floor(min / power);
            max = power * System.Math.Ceiling(max / power);
        }

        private double sigfig(double val, int sig)
        {
            if (System.Math.Abs(val) < 1.0e-10)
            {
                return 0.0;
            }
            else if (val < 0.0)
            {
                val = System.Math.Abs(val);
                double power = System.Math.Floor(System.Math.Log10(val));
                power = System.Math.Pow(10.0, power - sig);
                return - power * System.Math.Floor(0.5 + val / power);
            }
            else
            {
                double power = System.Math.Floor(System.Math.Log10(val));
                power = System.Math.Pow(10.0, power - sig);
                return power * System.Math.Floor(0.5 + val / power);
            }
        }

        private double getInterval(double range)
        {
            if (System.Math.Abs(range) < 1.0e-10) range = 0.0;
            string unit = range.ToString("E0", CultureInfo.InvariantCulture);
            unit = unit.Replace("0E", "1E");
            unit = unit.Replace("3E", "2E");
            unit = unit.Replace("4E", "5E");
            unit = unit.Replace("6E", "5E");
            unit = unit.Replace("7E", "5E");
            unit = unit.Replace("8E", "10E");
            unit = unit.Replace("9E", "10E");
            return double.Parse(unit, CultureInfo.InvariantCulture);
        }

        private void plotSeries_Delegate()
        {
            try
            {
                int i = 0;
                Canvas _graph = (Canvas)delegate_Data[i++];
                plotData _plotData = (plotData)delegate_Data[i++];
                eZoom _eZoom = (eZoom)delegate_Data[i++];
                eRescale _eRescale = (eRescale)delegate_Data[i++];

                plotSeries(_graph, _plotData, _eZoom, _eRescale);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
        private void plotSeries(Canvas _graph, plotData _plotData, eZoom eZoom, eRescale eRescale)
        {
            if (isPlotting) return;
            isPlotting = true;
            if (!mouseScrollX && !mouseScrollY) setEvents(false);

            double gw = _graph.ActualWidth - offsetL - offsetR;
            double gh = _graph.ActualHeight - offsetT - offsetB;
            double _nTickX = _plotData.nTickX > 0 ? _plotData.nTickX : nTickX;
            double _nTickY = _plotData.nTickY > 0 ? _plotData.nTickY : nTickY;

            _graph.Background = getBrush(borderColour); // Possible user change

            /*******************************************************************************
             * Axes scaling
             ******************************************************************************/
            if (eZoom == eZoom.TRUE)
            {
                double minXtemp = _plotData.minX - _plotData.shiftX + posDown.X / gw * (_plotData.maxX - _plotData.minX);
                double minYtemp = _plotData.maxY - _plotData.shiftY + posUp.Y / gh * (_plotData.minY - _plotData.maxY);
                double maxXtemp = _plotData.minX - _plotData.shiftX + posUp.X / gw * (_plotData.maxX - _plotData.minX);
                double maxYtemp = _plotData.maxY - _plotData.shiftY + posDown.Y / gh * (_plotData.minY - _plotData.maxY);
                _plotData.minX = System.Math.Min(minXtemp, maxXtemp);
                _plotData.minY = System.Math.Min(minYtemp, maxYtemp);
                _plotData.maxX = System.Math.Max(minXtemp, maxXtemp);
                _plotData.maxY = System.Math.Max(minYtemp, maxYtemp);
                _plotData.shiftX = 0.0;
                _plotData.shiftY = 0.0;
            }
            else if (eRescale == eRescale.TRUE)
            {
                _plotData.minX = 1.0e20;
                _plotData.minY = 1.0e20;
                _plotData.maxX = -1.0e20;
                _plotData.maxY = -1.0e20;
                foreach (seriesData _series in _plotData.series)
                {
                    _plotData.minX = System.Math.Min(_plotData.minX, _series.minX);
                    _plotData.minY = System.Math.Min(_plotData.minY, _series.minY);
                    _plotData.maxX = System.Math.Max(_plotData.maxX, _series.maxX);
                    _plotData.maxY = System.Math.Max(_plotData.maxY, _series.maxY);
                }
                _plotData.shiftX = 0.0;
                _plotData.shiftY = 0.0;

                if (_plotData.userIntervalX == 0 && _plotData.userMaxX < _plotData.userMinX)
                {
                    if (autoScale)
                    {
                        double interval = getInterval((_plotData.maxX - _plotData.minX) / nTickX);
                        _plotData.minX = interval * (int)(_plotData.minX / interval - 1);
                        _nTickX = 1 + (int)((_plotData.maxX - _plotData.minX) / interval);
                        _plotData.maxX = _plotData.minX + _nTickX * interval;
                        _plotData.nTickX = _nTickX;
                    }
                    else
                    {
                        round(ref _plotData.minX, ref _plotData.maxX);
                        _plotData.nTickX = 0;
                        _nTickX = nTickX;
                    }
                }
                else
                {
                    if (_plotData.userMaxX >= _plotData.userMinX) _plotData.minX = _plotData.userMinX;
                    if (_plotData.userMaxX > _plotData.userMinX) _plotData.maxX = _plotData.userMaxX;
                    double interval = _plotData.userIntervalX > 0 ? _plotData.userIntervalX : getInterval((_plotData.maxX - _plotData.minX) / nTickX);
                    if (_plotData.userMaxX < _plotData.userMinX) _plotData.minX = interval * (int)(_plotData.minX / interval - 1);
                    _nTickX = (int)((_plotData.maxX - _plotData.minX) / interval);
                    if (_plotData.userMaxX <= _plotData.userMinX || _plotData.userMaxX > _plotData.userMinX + _nTickX * interval) _nTickX++;
                    _plotData.maxX = _plotData.minX + _nTickX * interval;
                    _plotData.nTickX = _nTickX;
                }
                if (_plotData.userIntervalY == 0 && _plotData.userMaxY < _plotData.userMinY)
                {
                    if (autoScale)
                    {
                        double interval = getInterval((_plotData.maxY - _plotData.minY) / nTickY);
                        _plotData.minY = interval * (int)(_plotData.minY / interval - 1);
                        _nTickY = 1 + (int)((_plotData.maxY - _plotData.minY) / interval);
                        _plotData.maxY = _plotData.minY + _nTickY * interval;
                        _plotData.nTickY = _nTickY;
                    }
                    else
                    {
                        round(ref _plotData.minY, ref _plotData.maxY);
                        _plotData.nTickY = 0;
                        _nTickY = nTickY;
                    }
                }
                else
                {
                    if (_plotData.userMaxY >= _plotData.userMinY) _plotData.minY = _plotData.userMinY;
                    if (_plotData.userMaxY > _plotData.userMinY) _plotData.maxY = _plotData.userMaxY;
                    double interval = _plotData.userIntervalY > 0 ? _plotData.userIntervalY : getInterval((_plotData.maxY - _plotData.minY) / nTickY);
                    if (_plotData.userMaxY < _plotData.userMinY) _plotData.minY = interval * (int)(_plotData.minY / interval - 1);
                    _nTickY = (int)((_plotData.maxY - _plotData.minY) / interval);
                    if (_plotData.userMaxY <= _plotData.userMinY || _plotData.userMaxY > _plotData.userMinY + _nTickY * interval) _nTickY++;
                    _plotData.maxY = _plotData.minY + _nTickY * interval;
                    _plotData.nTickY = _nTickY;
                }
            }

            /*******************************************************************************
             * Create all children objects
             ******************************************************************************/
            _graph.Children.Clear();

            RotateTransform rotate90 = new RotateTransform();
            rotate90.Angle = -90;
            ScaleTransform bgLayer = new ScaleTransform();
            bgLayer.ScaleY = 1.2;
            bgLayer.CenterY = 11.0;

            /*******************************************************************************
             * Axes labeling
             ******************************************************************************/
            TextBlock _title = new TextBlock();
            _title.Text = _plotData.title;
            _title.Width = gw;
            _title.TextAlignment = TextAlignment.Center;
            _title.FontSize = 18;
            _title.Foreground = getBrush(textColour);
            _title.FontWeight = FontWeights.Bold;
            _graph.Children.Add(_title);
            Canvas.SetLeft(_title, offsetL);
            Canvas.SetTop(_title, 2);

            TextBlock _titleX = new TextBlock();
            _titleX.Text = _plotData.labelX;
            _titleX.Width = gw;
            _titleX.TextAlignment = TextAlignment.Center;
            _titleX.FontSize = 14;
            _titleX.Foreground = getBrush(textColour);
            _titleX.FontWeight = FontWeights.Bold;
            _graph.Children.Add(_titleX);
            Canvas.SetLeft(_titleX, offsetL);
            Canvas.SetTop(_titleX, _graph.ActualHeight - 20);

            TextBlock _titleY = new TextBlock();
            _titleY.Text = _plotData.labelY;
            _titleY.Width = gh;
            _titleY.TextAlignment = TextAlignment.Center;
            _titleY.FontSize = 14;
            _titleY.Foreground = getBrush(textColour);
            _titleY.FontWeight = FontWeights.Bold;
            _graph.Children.Add(_titleY);
            Canvas.SetLeft(_titleY, 2);
            Canvas.SetTop(_titleY, _graph.ActualHeight - offsetB);
            _titleY.RenderTransform = rotate90;

            /*******************************************************************************
             * Plot area
             ******************************************************************************/
            Canvas _plotarea = new Canvas();
            _plotData.plotarea = _plotarea;
            _plotarea.Width = gw;
            _plotarea.Height = gh;
            _plotarea.Background = getBrush(interiorColour);
            _plotarea.ClipToBounds = true;
            _plotarea.Cursor = Cursors.Cross;
            _graph.Children.Add(_plotarea);
            Canvas.SetLeft(_plotarea, offsetL);
            Canvas.SetTop(_plotarea, offsetT);

            /*******************************************************************************
             * Hover values
             ******************************************************************************/
            _plotData.hoverValBG = new TextBlock();
            _plotData.hoverValBG.Text = "";
            _plotData.hoverValBG.Foreground = getBrush(interiorColour);
            _plotData.hoverValBG.FontWeight = FontWeights.Bold;
            _plotData.hoverValBG.RenderTransform = bgLayer;
            Canvas.SetZIndex(_plotData.hoverValBG, 1);

            _plotarea.Children.Add(_plotData.hoverValBG);
            _plotData.hoverVal = new TextBlock();
            _plotData.hoverVal.Text = "";
            _plotData.hoverVal.Foreground = getBrush(textColour);
            _plotData.hoverVal.FontWeight = FontWeights.Bold;
            Canvas.SetZIndex(_plotData.hoverVal, 1);
            _plotarea.Children.Add(_plotData.hoverVal);

            /*******************************************************************************
             * Plot area Border
             ******************************************************************************/
            Rectangle _border = new Rectangle();
            _border.Width = gw;
            _border.Height = gh;
            _border.Stroke = getBrush(linesColour);
            _border.StrokeThickness = 1.0;
            _graph.Children.Add(_border);
            Canvas.SetLeft(_border, offsetL);
            Canvas.SetTop(_border, offsetT);

            /*******************************************************************************
             * X axis tick marks and labels
             ******************************************************************************/
            Line _line;
            int i, j;
            double iTick;
            for (i = 0; i < _nTickX + 1; i++)
            {
                j = i - (int)System.Math.Floor(_plotData.shiftX * _nTickX / (_plotData.maxX - _plotData.minX));
                iTick = j + _plotData.shiftX * _nTickX / (_plotData.maxX - _plotData.minX);
                if (iTick >= 0 && iTick <= _nTickX)
                {
                    _line = new Line();
                    _line.X1 = iTick * gw / _nTickX;
                    _line.Y1 = gh;
                    _line.X2 = iTick * gw / _nTickX;
                    _line.Y2 = 0;
                    _line.Stroke = getBrush(faintlinesColour);
                    _line.StrokeThickness = 0.5;
                    _plotarea.Children.Add(_line);

                    _line = new Line();
                    _line.X1 = iTick * gw / _nTickX;
                    _line.Y1 = gh;
                    _line.X2 = iTick * gw / _nTickX;
                    _line.Y2 = gh - 10;
                    _line.Stroke = getBrush(linesColour);
                    _line.StrokeThickness = 1.0;
                    _plotarea.Children.Add(_line);

                    TextBlock _val = new TextBlock();
                    _val.Text = sigfig((_plotData.minX - _plotData.shiftX + iTick / _nTickX * (_plotData.maxX - _plotData.minX)), 3).ToString();
                    _val.Foreground = getBrush(textColour);
                    _graph.Children.Add(_val);
                    Canvas.SetLeft(_val, offsetL + iTick / _nTickX * gw - 3 * _val.Text.Length);
                    Canvas.SetTop(_val, offsetT + gh + 2);
                }
            }

            /*******************************************************************************
             * Y axis tick marks and labels
             ******************************************************************************/
            for (i = 0; i < _nTickY + 1; i++)
            {
                j = i - (int)System.Math.Floor(_plotData.shiftY * _nTickY / (_plotData.minY - _plotData.maxY));
                iTick = j + _plotData.shiftY * _nTickY / (_plotData.minY - _plotData.maxY);
                if (iTick >= 0 && iTick <= _nTickY)
                {
                    _line = new Line();
                    _line.X1 = 0;
                    _line.Y1 = iTick * gh / _nTickY;
                    _line.X2 = gw;
                    _line.Y2 = iTick * gh / _nTickY;
                    _line.Stroke = getBrush(faintlinesColour);
                    _line.StrokeThickness = 0.5;
                    _plotarea.Children.Add(_line);

                    _line = new Line();
                    _line.X1 = 0;
                    _line.Y1 = iTick * gh / _nTickY;
                    _line.X2 = 10;
                    _line.Y2 = iTick * gh / _nTickY;
                    _line.Stroke = getBrush(linesColour);
                    _plotarea.Children.Add(_line);

                    TextBlock _val = new TextBlock();
                    _val.Text = sigfig((_plotData.maxY - _plotData.shiftY + iTick / _nTickY * (_plotData.minY - _plotData.maxY)), 3).ToString();
                    _val.Foreground = getBrush(textColour);
                    _graph.Children.Add(_val);
                    Canvas.SetLeft(_val, offsetL - 20);
                    Canvas.SetTop(_val, offsetT + iTick / _nTickY * gh + 3 * _val.Text.Length);
                    _val.RenderTransform = rotate90;
                }
            }

            /*******************************************************************************
             * Axes scroll areas
             ******************************************************************************/
            Canvas _scrollX = new Canvas();
            _scrollX.Width = gw;
            _scrollX.Height = offsetB;
            _scrollX.Background = getBrush("#00ffffff");
            _graph.Children.Add(_scrollX);
            _plotData.scrollX = _scrollX;
            Canvas.SetLeft(_scrollX, offsetL);
            Canvas.SetTop(_scrollX, gh + offsetT);
            if (doEvents) _scrollX.Cursor = Cursors.Hand;

            Canvas _scrollY = new Canvas();
            _scrollY.Width = offsetL;
            _scrollY.Height = gh;
            _scrollY.Background = getBrush("#00ffffff");
            _graph.Children.Add(_scrollY);
            _plotData.scrollY = _scrollY;
            Canvas.SetLeft(_scrollY, 0);
            Canvas.SetTop(_scrollY, offsetT);
            if (doEvents) _scrollY.Cursor = Cursors.Hand;

            /*******************************************************************************
             * Legend
             ******************************************************************************/
            if (_plotData.displayLegend)
            {
                Canvas _legend = new Canvas();
                _plotData.legend = _legend;
                _legend.Width = 60;
                _legend.Height = 20*_plotData.series.Count;
                _legend.Background = getBrush("#00ffffff");
                if (doEvents) _legend.Cursor = Cursors.Hand;
                i = 0;
                foreach (seriesData _series in _plotData.series)
                {
                    Brush seriesBrush = getBrush(_series.colour);
                    _line = new Line();
                    _line.X1 = 10;
                    _line.Y1 = 10+20*i;
                    _line.X2 = 50;
                    _line.Y2 = 10 + 20 * i;
                    _line.Stroke = seriesBrush;
                    _line.StrokeThickness = 2;
                    _legend.Children.Add(_line);

                    TextBlock _val = new TextBlock();
                    _val.Text = _series.name;
                    _val.Foreground = getBrush(textColour);
                    _legend.Children.Add(_val);
                    Canvas.SetLeft(_val, 55);
                    Canvas.SetTop(_val, 20 * i);
                    i++;
                }
                _graph.Children.Add(_legend);
                Canvas.SetLeft(_legend, offsetL + _plotData.legendPosition.X);
                Canvas.SetTop(_legend, offsetT + _plotData.legendPosition.Y);
            }

            /*******************************************************************************
             * Plot the series data
             ******************************************************************************/
            double dSeries = 0;
            int iCount = 0;
            foreach (seriesData _series in _plotData.series)
            {
                for (i = 0; i < _series.dataX.Count; i++)
                {
                    if (_series.dataX[i] > (_plotData.minX - _plotData.shiftX) && _series.dataX[i] < (_plotData.maxX - _plotData.shiftX)) iCount++;
                }
                if (_series.type == eLineType.HISTOGRAM) dSeries++; // Number of histograms;
            }
            double dOffest = -(dSeries - 1.0) / 2.0;
            dSeries = 0;;
            double dWL = 2.0; // Width for line
            double dWH = 0.8 * System.Math.Min(50.0, System.Math.Max(2.0, gw / (double) iCount)); // Width for histogram
            double dWP = System.Math.Min(12.0, System.Math.Max(6.0, gw / (double)iCount)); // Width for points

            foreach (seriesData _series in _plotData.series)
            {
                Brush seriesBrush = getBrush(_series.colour);

                switch (_series.type)
                {
                    case eLineType.LINE: // Line
                        {
                            for (i = 1; i < _series.dataX.Count; i++)
                            {
                                double X1 = gw * (_series.dataX[i - 1] - (_plotData.minX - _plotData.shiftX)) / (_plotData.maxX - _plotData.minX);
                                double Y1 = gh * ((_plotData.maxY - _plotData.shiftY) - _series.dataY[i - 1]) / (_plotData.maxY - _plotData.minY);
                                double X2 = gw * (_series.dataX[i] - (_plotData.minX - _plotData.shiftX)) / (_plotData.maxX - _plotData.minX);
                                double Y2 = gh * ((_plotData.maxY - _plotData.shiftY) - _series.dataY[i]) / (_plotData.maxY - _plotData.minY);
                                if (((X2 >= 0 && X1 <= gw) || (X1 >= 0 && X2 <= gw)) && ((Y2 >= 0 && Y1 <= gh) || (Y1 >= 0 && Y2 <= gh)))
                                {
                                    _line = new Line();
                                    _line.X1 = X1;
                                    _line.Y1 = Y1;
                                    _line.X2 = X2;
                                    _line.Y2 = Y2;
                                    _line.Stroke = seriesBrush;
                                    _line.StrokeThickness = dWL;
                                    _plotarea.Children.Add(_line);
                                }
                            }
                        }
                        break;
                    case eLineType.HISTOGRAM: // Histogram
                        {
                            Rectangle _rect;
                            for (i = 0; i < _series.dataX.Count; i++)
                            {
                                double X = gw * (_series.dataX[i] - (_plotData.minX - _plotData.shiftX)) / (_plotData.maxX - _plotData.minX);
                                double Y1 = gh * ((_plotData.maxY - _plotData.shiftY) - System.Math.Max(0.0, _series.dataY[i])) / (_plotData.maxY - _plotData.minY);
                                double Y2 = gh * ((_plotData.maxY - _plotData.shiftY) - System.Math.Min(0.0, _series.dataY[i])) / (_plotData.maxY - _plotData.minY);
                                if ((X >= 0 && X <= gw) && (Y1 <= gh && Y2 >= 0))
                                {
                                    _rect = new Rectangle();
                                    _rect.Width = 0.8 * dWH;
                                    _rect.Height = Y2 - Y1;
                                    _rect.Fill = seriesBrush;
                                    _rect.StrokeThickness = 0;
                                    _plotarea.Children.Add(_rect);
                                    Canvas.SetLeft(_rect, X + dWH * (dOffest + dSeries) - 0.8 * dWH / 2.0);
                                    Canvas.SetTop(_rect, Y1);
                                }
                            }
                            dSeries++;
                        }
                        break;
                    case eLineType.POINTS: // Points
                        {
                            Ellipse _ellip;
                            for (i = 0; i < _series.dataX.Count; i++)
                            {
                                double X = gw * (_series.dataX[i] - (_plotData.minX - _plotData.shiftX)) / (_plotData.maxX - _plotData.minX);
                                double Y = gh * ((_plotData.maxY - _plotData.shiftY) - _series.dataY[i]) / (_plotData.maxY - _plotData.minY);
                                if ((X >= 0 && X <= gw) && (Y >= 0 && Y <= gh))
                                {
                                    _ellip = new Ellipse();
                                    _ellip.Width = dWP;
                                    _ellip.Height = dWP;
                                    _ellip.Fill = seriesBrush;
                                    _ellip.StrokeThickness = 0;
                                    _plotarea.Children.Add(_ellip);
                                    Canvas.SetLeft(_ellip, X - dWP / 2.0);
                                    Canvas.SetTop(_ellip, Y - dWP / 2.0);
                                }
                            }
                        }
                        break;
                }
            }

            setEvents(doEvents);
            isPlotting = false;
        }

        public string createGraph(int width, int height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Canvas _mainCanvas;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
#if SVB
                string name = method.Invoke(null, new object[] { "Graph", false }).ToString();
#else
                string name = method.Invoke(null, new object[] { "Graph" }).ToString();
#endif

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        // Remove any hanging plotData (Shapes.Remove) data stores
                        for (int i = plotInfo.Count - 1; i >= 0; i--)  //Reverse order to allow potential multiple deletions 
                        {
                            if (!_objectsMap.TryGetValue(plotInfo[i].name, out obj))
                            {
                                for (int j = 0; j < plotInfo[i].series.Count; j++)
                                {
                                    plotInfo[i].series[j].dataX.Clear();
                                    plotInfo[i].series[j].dataY.Clear();
                                }
                                plotInfo[i].series.Clear();
                                plotInfo.RemoveAt(i);
                            }
                        }

                        Canvas _graph = new Canvas();
                        _graph.Name = name;
                        _graph.Width = width;
                        _graph.Height = height;
                        _graph.Background = getBrush(borderColour);
                        _graph.Tag = name;

                        _objectsMap[name] = _graph;
                        _mainCanvas.Children.Add(_graph);

                        // Creates the Excel Image.
                        System.Drawing.Bitmap dImg = global::LitDev.Properties.Resources.excel;
                        MemoryStream ms = new MemoryStream();
                        dImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        BitmapImage bImg = new BitmapImage();
                        bImg.BeginInit();
                        bImg.StreamSource = ms;
                        bImg.EndInit();
                        Image imgExcel = new Image();
                        imgExcel.Source = bImg;

                        // Creates the CSV Image.
                        dImg = global::LitDev.Properties.Resources.csv;
                        ms = new MemoryStream();
                        dImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        bImg = new BitmapImage();
                        bImg.BeginInit();
                        bImg.StreamSource = ms;
                        bImg.EndInit();
                        Image imgCSV = new Image();
                        imgCSV.Source = bImg;

                        // Creates the Save Image.
                        dImg = global::LitDev.Properties.Resources.save;
                        ms = new MemoryStream();
                        dImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        bImg = new BitmapImage();
                        bImg.BeginInit();
                        bImg.StreamSource = ms;
                        bImg.EndInit();
                        Image imgSave = new Image();
                        imgSave.Source = bImg;

                        // Creates the zoom Image.
                        dImg = global::LitDev.Properties.Resources.zoom;
                        ms = new MemoryStream();
                        dImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        bImg = new BitmapImage();
                        bImg.BeginInit();
                        bImg.StreamSource = ms;
                        bImg.EndInit();
                        Image imgZoom = new Image();
                        imgZoom.Source = bImg;

                        // Creates the Legend Image.
                        dImg = global::LitDev.Properties.Resources.legend;
                        ms = new MemoryStream();
                        dImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        bImg = new BitmapImage();
                        bImg.BeginInit();
                        bImg.StreamSource = ms;
                        bImg.EndInit();
                        Image imgLegend = new Image();
                        imgLegend.Source = bImg;

                        //Right click popup menu
                        ContextMenu mnu = new ContextMenu();
                        MenuItem mnuExcel = new MenuItem();
                        mnuExcel.Icon = imgExcel;
                        mnuExcel.Header = "Export data to Excel";
                        mnuExcel.Click += new RoutedEventHandler(mnuExcel_Click);
                        mnuExcel.Tag = _graph;
                        mnu.Items.Add(mnuExcel);
                        MenuItem mnuCSV = new MenuItem();
                        mnuCSV.Icon = imgCSV;
                        mnuCSV.Header = "Export data to CSV file";
                        mnuCSV.Click += new RoutedEventHandler(mnuCSV_Click);
                        mnuCSV.Tag = _graph;
                        mnu.Items.Add(mnuCSV);
                        MenuItem mnuSave = new MenuItem();
                        mnuSave.Icon = imgSave;
                        mnuSave.Header = "Export graph to image file";
                        mnuSave.Click += new RoutedEventHandler(mnuSave_Click);
                        mnuSave.Tag = _graph;
                        mnu.Items.Add(mnuSave);
                        MenuItem mnuHoverVal = new MenuItem();
                        mnuHoverVal.IsChecked = false;
                        mnuHoverVal.Header = "Toggle show values at mouse";
                        mnuHoverVal.Click += new RoutedEventHandler(mnuHoverVal_Click);
                        mnuHoverVal.Tag = _graph;
                        mnu.Items.Add(mnuHoverVal);
                        MenuItem mnuLegend = new MenuItem();
                        mnuLegend.IsChecked = true;
                        mnuLegend.Header = "Toggle show legend";
                        mnuLegend.Click += new RoutedEventHandler(mnuLegend_Click);
                        mnuLegend.Tag = _graph;
                        mnu.Items.Add(mnuLegend);
                        MenuItem mnuResetLegend = new MenuItem();
                        mnuResetLegend.Icon = imgLegend;
                        mnuResetLegend.Header = "Reset legend position";
                        mnuResetLegend.Click += new RoutedEventHandler(mnuResetLegend_Click);
                        mnuResetLegend.Tag = _graph;
                        mnu.Items.Add(mnuResetLegend);
                        MenuItem mnuResetZoom = new MenuItem();
                        mnuResetZoom.Icon = imgZoom;
                        mnuResetZoom.Header = "Reset zoom";
                        mnuResetZoom.Click += new RoutedEventHandler(mnuResetZoom_Click);
                        mnuResetZoom.Tag = _graph;
                        mnu.Items.Add(mnuResetZoom);
                        _graph.ContextMenu = mnu;

                        return name;
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

        public void setAxes(string graphName, string title, string labelX, string labelY)
        {
            plotData _plotData = getPlotData(graphName);
            _plotData.title = title;
            _plotData.labelX = labelX;
            _plotData.labelY = labelY;
        }

        public seriesData createSeries(string seriesLabel, Primitive data, string colour, eLineType type)
        {
            Type PrimitiveType = typeof(Primitive);
            Dictionary<Primitive, Primitive> _arrayMap;
            seriesData _series = new seriesData();
            double x, y;

            try
            {
                data = Utilities.CreateArrayMap(data);
                _arrayMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(data);

                foreach (KeyValuePair<Primitive, Primitive> kvp in _arrayMap)
                {
                    x = (double)kvp.Key;
                    y = (double)kvp.Value;
                    _series.dataX.Add(x);
                    _series.dataY.Add(y);
                    _series.minX = System.Math.Min(_series.minX, x);
                    _series.minY = System.Math.Min(_series.minY, y);
                    _series.maxX = System.Math.Max(_series.maxX, x);
                    _series.maxY = System.Math.Max(_series.maxY, y);
                    _series.type = type;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }

            _series.colour = colour;
            _series.name = seriesLabel;

            return _series;
        }

        public void addSeries(string graphName, string seriesLabel, Primitive data, string colour, eLineType type)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue(graphName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), graphName);
                    return;
                }

                try
                {
                    Canvas _graph = (Canvas)obj;

                    plotData _plotData = getPlotData(graphName);
                    // Create new series if needed (otherwise its just the graph background)
                    if (null != data)
                    {
                        bool bFound = false;
                        seriesData newSeries = createSeries(seriesLabel, data, colour, type);
                        foreach (seriesData series in _plotData.series)
                        {
                            if (series.name == seriesLabel)
                            {
                                series.CopyFrom(newSeries);
                                bFound = true;
                                break;
                            }
                        }
                        if (!bFound) _plotData.series.Add(newSeries);
                    }
                    delegate_Data = new object[] { _graph, _plotData, eZoom.FALSE, eRescale.TRUE };
                    FastThread.Invoke(plotSeries_Delegate);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public void deleteSeries(string graphName, string name)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue(graphName, out obj))
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), graphName);
                    return;
                }

                try
                {
                    Canvas _graph = (Canvas)obj;

                    foreach (plotData _plotData in plotInfo)
                    {
                        if (_plotData.name == graphName)
                        {
                            foreach (seriesData _series in _plotData.series)
                            {
                                if (_series.name == name)
                                {
                                    _plotData.series.Remove(_series);
                                    delegate_Data = new object[] { _graph, _plotData, eZoom.FALSE, eRescale.TRUE };
                                    FastThread.Invoke(plotSeries_Delegate);
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public void setEvents(bool bAdd)
        {
            try
            {
                foreach (plotData _plotData in plotInfo)
                {
                    if (bAdd)
                    {
                        if (null != _plotData.plotarea)
                        {
                            _plotData.plotarea.MouseDown += new MouseButtonEventHandler(_MouseDownEvent);
                            _plotData.plotarea.MouseUp += new MouseButtonEventHandler(_MouseUpEvent);
                            _plotData.plotarea.MouseMove += new MouseEventHandler(_MouseMoveEvent);
                            _plotData.plotarea.MouseWheel += new MouseWheelEventHandler(_MouseWheelEvent);
                        }

                        if (null != _plotData.legend)
                        {
                            _plotData.legend.MouseDown += new MouseButtonEventHandler(_MouseDownEventLegend);
                            _plotData.legend.MouseUp += new MouseButtonEventHandler(_MouseUpEventLegend);
                            _plotData.legend.MouseMove += new MouseEventHandler(_MouseMoveEventLegend);
                        }

                        if (null != _plotData.scrollX)
                        {
                            _plotData.scrollX.MouseDown += new MouseButtonEventHandler(_MouseDownEventScrollX);
                            _plotData.scrollX.MouseUp += new MouseButtonEventHandler(_MouseUpEventScrollX);
                            _plotData.scrollX.MouseMove += new MouseEventHandler(_MouseMoveEventScrollX);
                        }

                        if (null != _plotData.scrollY)
                        {
                            _plotData.scrollY.MouseDown += new MouseButtonEventHandler(_MouseDownEventScrollY);
                            _plotData.scrollY.MouseUp += new MouseButtonEventHandler(_MouseUpEventScrollY);
                            _plotData.scrollY.MouseMove += new MouseEventHandler(_MouseMoveEventScrollY);
                        }
                    }
                    else
                    {
                        if (null != _plotData.plotarea)
                        {
                            _plotData.plotarea.MouseDown -= new MouseButtonEventHandler(_MouseDownEvent);
                            _plotData.plotarea.MouseUp -= new MouseButtonEventHandler(_MouseUpEvent);
                            _plotData.plotarea.MouseMove -= new MouseEventHandler(_MouseMoveEvent);
                            _plotData.plotarea.MouseWheel -= new MouseWheelEventHandler(_MouseWheelEvent);
                        }

                        if (null != _plotData.legend)
                        {
                            _plotData.legend.MouseDown -= new MouseButtonEventHandler(_MouseDownEventLegend);
                            _plotData.legend.MouseUp -= new MouseButtonEventHandler(_MouseUpEventLegend);
                            _plotData.legend.MouseMove -= new MouseEventHandler(_MouseMoveEventLegend);
                        }

                        if (null != _plotData.scrollX)
                        {
                            _plotData.scrollX.MouseDown -= new MouseButtonEventHandler(_MouseDownEventScrollX);
                            _plotData.scrollX.MouseUp -= new MouseButtonEventHandler(_MouseUpEventScrollX);
                            _plotData.scrollX.MouseMove -= new MouseEventHandler(_MouseMoveEventScrollX);
                        }

                        if (null != _plotData.scrollY)
                        {
                            _plotData.scrollY.MouseDown -= new MouseButtonEventHandler(_MouseDownEventScrollY);
                            _plotData.scrollY.MouseUp -= new MouseButtonEventHandler(_MouseUpEventScrollY);
                            _plotData.scrollY.MouseMove -= new MouseEventHandler(_MouseMoveEventScrollY);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        public void exportCSV(plotData _plotData, string fileName)
        {
            string line;
            StreamWriter file = new StreamWriter(fileName);

            line = "";
            for (int i = 0; i < _plotData.series.Count; i++)
            {
                line += _plotData.series[i].name + Utilities.CSV + Utilities.CSV + Utilities.CSV;
            }
            file.WriteLine(line);
            line = "";
            for (int i = 0; i < _plotData.series.Count; i++)
            {
                line += _plotData.labelX + Utilities.CSV + _plotData.labelY + Utilities.CSV + Utilities.CSV;
            }
            file.WriteLine(line);
            line = "";
            for (int i = 0; i < _plotData.series.Count; i++)
            {
                line += Utilities.CSV + Utilities.CSV + Utilities.CSV;
            }
            file.WriteLine(line);
            int max = 0;
            for (int i = 0; i < _plotData.series.Count; i++)
            {
                max = System.Math.Max(max, _plotData.series[i].dataX.Count);
            }
            for (int iRow = 0; iRow < max; iRow++)
            {
                line = "";
                for (int i = 0; i < _plotData.series.Count; i++)
                {
                    if (_plotData.series[i].dataX.Count <= iRow)
                    {
                        line += Utilities.CSV + Utilities.CSV + Utilities.CSV;
                    }
                    else
                    {
                        line += _plotData.series[i].dataX[iRow] + Utilities.CSV + _plotData.series[i].dataY[iRow] + Utilities.CSV + Utilities.CSV;
                    }
                }
                file.WriteLine(line);
            }
            file.Close();
        }

        public void scaleAxis(string graphName, double min, double interval, double max, int axis)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
            if (!_objectsMap.TryGetValue(graphName, out obj))
            {
                Utilities.OnShapeError(Utilities.GetCurrentMethod(), graphName);
                return;
            }

            try
            {
                Canvas _graph = (Canvas)obj;

                foreach (plotData _plotData in plotInfo)
                {
                    if (_plotData.name == graphName)
                    {
                        if (axis == 0)
                        {
                            _plotData.userMinX = min;
                            _plotData.userMaxX = max;
                            _plotData.userIntervalX = interval;
                        }
                        else if (axis == 1)
                        {
                            _plotData.userMinY = min;
                            _plotData.userMaxY = max;
                            _plotData.userIntervalY = interval;
                        }
                        delegate_Data = new object[] { _graph, _plotData, eZoom.FALSE, eRescale.TRUE };
                        FastThread.Invoke(plotSeries_Delegate);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }
}
