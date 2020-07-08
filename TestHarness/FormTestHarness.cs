using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System.Reflection;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using LitDev;
using System.IO;
using System.Diagnostics;
using System.Drawing.Text;
using System.Net;
using LitDev.Engines;
using LitDev.Themes;

namespace TestHarness
{
    public partial class FormTestHarness : Form
    {
        public FormTestHarness()
        {
            InitializeComponent();
        }

        private void OnMouseDown()
        {
            TextWindow.WriteLine("HERE");
        }

        private void buttonShapes_Click(object sender, EventArgs e)
        {
            GraphicsWindow.Show();
            LDScrollBars.Rasterize = "True";
            GraphicsWindow.MouseDown += OnMouseDown;
            LDScrollBars.Add(GraphicsWindow.Width, 10000);
            int cogRadius = 100;
            int cogNumTeeth = 10;
            int cogToothSize = 10;
            Primitive cog = Shapes.AddEllipse(2*cogRadius,2*cogRadius);
            Primitive points = "";
            Primitive point = "";

            LDPhysics.AddMovingShape(cog,0.5,0.8,1);
            for (int i = 1; i <= 1; i++)
            {
                double angle = (i-1)/cogNumTeeth*2*SBMath.Pi;
                double innerSector = 0.7/cogNumTeeth*2*SBMath.Pi;
                double outerSector = 0.5/cogNumTeeth*2*SBMath.Pi;
                point["X"] = cogRadius+cogRadius*SBMath.Cos(angle);
                point["Y"] = cogRadius+cogRadius*SBMath.Sin(angle);
                points[1] = point;
                point["X"] = cogRadius+cogRadius*SBMath.Cos(angle+innerSector);
                point["Y"] = cogRadius+cogRadius*SBMath.Sin(angle+innerSector);
                points[2] = point;
                point["X"] = cogRadius+(cogRadius+cogToothSize)*SBMath.Cos(angle+outerSector);
                point["Y"] = cogRadius+(cogRadius+cogToothSize)*SBMath.Sin(angle+outerSector);
                points[3] = point;
                point["X"] = cogRadius+(cogRadius+cogToothSize)*SBMath.Cos(angle+innerSector-outerSector);
                point["Y"] = cogRadius+(cogRadius+cogToothSize)*SBMath.Sin(angle+innerSector-outerSector);
                points[4] = point;
                Primitive tooth = LDShapes.AddPolygon(points);
                LDPhysics.AddMovingShape(tooth,0.5,0.8,1);
                //LDPhysics.GroupShapes(cog, tooth);
            }

            LDPhysics.DoTimestep();

            Primitive ball = Shapes.AddEllipse(100, 50);
            //Shapes.Move(ball, 112, 112);
            //Shapes.Zoom(ball, 1, 1);
            //Shapes.Rotate(ball, -60);
            Shapes.Move(ball, 100, 112);
            //Shapes.Zoom(ball, 1.2, 1);
            //Shapes.Rotate(ball, -60);

            Primitive gradient = "";
            gradient[1] = "Red";
            gradient[2] = "Yellow";
            gradient[3] = "Blue";
            Primitive brush = LDShapes.BrushGradient(gradient, "H");
            LDShapes.BrushShape(ball, brush);

            LDUtilities.GWCapture("C:\\temp\\test.jpg", "False");

            Primitive rect = Shapes.AddRectangle(60, 60);
            Shapes.Move(rect, 25, 95);
            Shapes.Zoom(rect, 1.5, 1);
            Shapes.Rotate(rect, 45);
            //Shapes.Move(rect, 75, 75);
            //Shapes.Zoom(rect, 1.5, 1);
            //Shapes.Rotate(rect, 45);

            TextWindow.WriteLine(LDShapes.Overlap(ball, rect));
            //TextWindow.WriteLine(LDShapes.Overlap(rect, ball));

            Primitive image1 = Shapes.AddImage("C:\\temp\\test2.jpg");
            Shapes.Move(image1, 100, 100);
            TextWindow.WriteLine(LDShapes.Overlap(ball, image1));

            //LDShapes.AnimatedGifInterval = 0;
            Primitive gifShape = LDShapes.AddAnimatedGif("http://www.animatedgif.net//animals//birds//batana1_e0.gif", "True");
            Shapes.Move(gifShape, 100, 300);
            Primitive rectangle = Shapes.AddRectangle(100, 100);
            LDShapes.BrushColour(rectangle, "Red");
            Primitive img = SBImageList.LoadImage("C:\\temp\\test.jpg");
            Primitive img2 = "C:\\temp\\test2.jpg";
            Primitive button = SBControls.AddButton("TEST", 100, 100);
            SBControls.SetSize(button, 50, 50);
            Primitive image = Shapes.AddImage(img);
            LDShapes.ReSize(image, 50, 50);
            LDShapes.Centre(image, 400, 25);
            SBProgram.Delay(1000);
            LDShapes.SetImage(image, img2);
            LDShapes.SetImage(button, img);
            SBProgram.Delay(1000);
            LDShapes.AnimationInterval = 0;
            LDShapes.AnimationSet(gifShape, LDShapes.AnimationCount(gifShape) / 3);
            SBProgram.Delay(1000);
            LDShapes.AnimationInterval = 50;
            LDShapes.AnimationPause(gifShape);
            SBProgram.Delay(2000);
            Shapes.HideShape(gifShape);
            LDShapes.AnimationResume(gifShape);
            SBProgram.Delay(2000);
            Shapes.ShowShape(gifShape);
        }

        private void buttonWebCam_Click(object sender, EventArgs e)
        {
            LDWebCam.Effect = LDWebCam.EffectFishEye;
            LDWebCam.Start(200, 200);
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            LDDebug.Start();
        }

        private void buttonDialogs_Click(object sender, EventArgs e)
        {
            int i;
            GraphicsWindow.Show();
            Primitive items = "";
            Primitive images = "";
            for (i = 1; i <= 5; i++)
            {
                items[i] = "Item "+i;
                images[i] = "C:\temp\test.jpg";
            }
            LDDialogs.AddRightClickMenu(items, images);

            TextWindow.WriteLine(System.Windows.Media.RenderCapability.Tier >> 16);
            Primitive a1 = LDArray.Create(1000);
            Shapes.AddEllipse(50, 50);
            FormPropertyGrid grid = new FormPropertyGrid();
            grid.Display("_mainCanvas");
            Primitive properties = grid.GetProperties("_mainCanvas");
            for (i = 1; i <= SBArray.GetItemCount(properties); i++)
            {
                TextWindow.WriteLine(properties[i]);
            }

            grid.SetProperty("_mainCanvas.Children.Ellipse1.Opacity", 0.5);

            Primitive font = LDDialogs.Font("");
            Primitive font2 = LDDialogs.Font(font);
            Primitive fileName = LDDialogs.OpenFile("Small Basic File (*.sb) |*.sb", "");
            LDUtilities.Version();
            GraphicsWindow.Show();
            TextWindow.WriteLine(LDDialogs.Calendar(LDDateTime.Add(LDDateTime.Now(), 7))); //Now + 7 days
            //LDUtilities.PauseUpdates();
            LDDialogs.Wait("Please wait for a few seconds while I draw something...", LDColours.SetOpacity(LDColours.Violet, 200));
            double start = Clock.ElapsedMilliseconds;
            i = 1;
            while (Clock.ElapsedMilliseconds < start + 5000)
            {
                Primitive ball = Shapes.AddEllipse(20, 20);
                Shapes.Move(ball, SBMath.GetRandomNumber(GraphicsWindow.Width) - 10, SBMath.GetRandomNumber(GraphicsWindow.Height) - 10);
                LDDialogs.ToolTip(ball, "Ball " + i++);
                SBProgram.Delay(100);
            }
            //LDUtilities.ResumeUpdates();
            LDDialogs.EndWait();
        }

        private void buttonColours_Click(object sender, EventArgs e)
        {
            Primitive col = LDColours.SetOpacity("Orange", 100);
            TextWindow.WriteLine(col);
            TextWindow.WriteLine(LDColours.GetOpacity(col));
            TextWindow.WriteLine(LDColours.GetRed(col));
            TextWindow.WriteLine(LDColours.GetGreen(col));
            TextWindow.WriteLine(LDColours.GetBlue(col));

            TextWindow.WriteLine(LDColours.GetHue(col));
            TextWindow.WriteLine(LDColours.GetSaturation(col));
            TextWindow.WriteLine(LDColours.GetLightness(col));
            col = LDColours.HSLtoRGB(LDColours.GetHue(col), LDColours.GetSaturation(col), LDColours.GetLightness(col));
            TextWindow.WriteLine(col);

            for (int i = 0; i < 360; i++)
            {
                GraphicsWindow.BackgroundColor = LDColours.HSLtoRGB(i, 1, 0.5);
                SBProgram.Delay(20);
            }
            LDUtilities.PauseUpdates();
            GraphicsWindow.PenWidth = 0;
            Primitive colour = "Blue";
            Primitive ball = Shapes.AddEllipse(300, 300);
            Shapes.Move(ball, GraphicsWindow.Width / 2 - 150, GraphicsWindow.Height / 2 - 150);
            LDShapes.BrushColour(ball, LDColours.SetOpacity(colour, 0));
            LDUtilities.ResumeUpdates();
            for (int i = 0; i < 255; i++)
            {
                LDShapes.BrushColour(ball, LDColours.SetOpacity(colour, i));
                SBProgram.Delay(10);
            }
        }

        private void buttonSortStatistics_Click(object sender, EventArgs e)
        {
            Primitive array = "";
            for (int i = 1; i <= 100; i++)
            {
                array[i] = SBMath.GetRandomNumber(100);
            }
            LDSort.CaseSensitive = "False";
            array[1] = "FB";
            array[2] = "fb";
            array[4] = "c";
            array[3] = "C";
            Primitive result = LDSort.ByValue(array);
            for (int i = 1; i <= SBArray.GetItemCount(result); i++)
            {
                TextWindow.WriteLine(i + " : " + result[i]);
            }

            TextWindow.WriteLine("");
            result = LDStatistics.SetArray(array);
            for (int i = 1; i <= SBArray.GetItemCount(result); i++)
            {
                TextWindow.WriteLine(i + " : " + result[i]);
            }
            TextWindow.WriteLine("");
            TextWindow.WriteLine(LDStatistics.Count);
            TextWindow.WriteLine(LDStatistics.Mean);
            TextWindow.WriteLine(LDStatistics.Median);
            TextWindow.WriteLine(LDStatistics.Mode);
            TextWindow.WriteLine(LDStatistics.SDev);
            TextWindow.WriteLine(LDStatistics.PDev);
            TextWindow.WriteLine(LDStatistics.HarmonicMean);
            TextWindow.WriteLine(LDStatistics.GeometricMean);
            TextWindow.WriteLine(LDStatistics.Min);
            TextWindow.WriteLine(LDStatistics.Max);

            Primitive graph = LDGraph.AddGraph(0, 0, GraphicsWindow.Width, GraphicsWindow.Height, "Probability Distribution", "Value", "Probability");
            //Primitive data = LDStatistics.DistNormal(4, 0.5, 101);
            //Primitive data = LDStatistics.DistUniform(3, 6, 101);
            //Primitive data = LDStatistics.DistTriangular(3, 6, 101);
            Primitive data = LDStatistics.DistBinomial(20, 0.5);
            LDGraph.AddSeriesLine(graph, "PDF", data, "Red");
            LDGraph.AddSeriesLine(graph, "CDF", LDStatistics.Integrate(data), "Blue");
            LDGraph.AddSeriesLine(graph, "Derivative", LDStatistics.Differentiate(data), "Green");
            LDUtilities.Icon = "C:\\Users\\Public\\Pictures\\fractal-1.jpg";

            array = "";
            for (int i = 1; i <= 1000; i++)
            {
                array[i] = SBMath.GetRandomNumber(999) / 1000.0;
            }
            Primitive dist = LDStatistics.InterpolateX(LDStatistics.Integrate(data), array);
            Primitive freq = LDStatistics.Frequency(dist, 50, "True");
            LDGraph.AddSeriesHistogram(graph, "Generated", freq, "Black");
            LDStatistics.SetArray(dist);
            TextWindow.WriteLine(LDStatistics.Mean);
            TextWindow.WriteLine(LDStatistics.SDev);

            Primitive A = LDArray.Create(3);
            Primitive index = LDArray.Create(3);
            LDArray.SetValue(A, 1, 5);
            LDArray.SetValue(A, 2, 3);
            LDArray.SetValue(A, 3, 1);
            LDArray.SortIndex(A, index);
        }

        private void buttonCommPort_Click(object sender, EventArgs e)
        {
            Primitive ports = LDCommPort.AvailablePorts();
            for (int i = 1; i <= SBArray.GetItemCount(ports); i++)
            {
                TextWindow.WriteLine(ports[i]);
            }
            LDCommPort.OpenPort(ports[1], 100);
        }

        private void buttonSpeech_Click(object sender, EventArgs e)
        {
            TextWindow.WriteLine(LDSpeech.Volume);
            TextWindow.WriteLine(LDSpeech.Speed);
            Primitive voices = LDSpeech.Voices();
            LDSpeech.Speed = -2;
            LDSpeech.Volume = 50;
            for (int i = 1; i <= SBArray.GetItemCount(voices); i++)
            {
                LDSpeech.Voice = voices[i];
                LDSpeech.Speak("Available voice " + i + " " + LDSpeech.Voice);
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            TextWindow.WriteLine("Length   " + LDFile.Length("C:\\temp\\testfile.db"));
            TextWindow.WriteLine("Created  " + LDFile.CreationTime("C:\\temp\\testfile.db"));
            TextWindow.WriteLine("Accessed " + LDFile.AccessTime("C:\\temp\\testfile.db"));
            TextWindow.WriteLine("Modified " + LDFile.ModifiedTime("C:\\temp\\testfile.db"));
        }

        private void buttonTrig_Click(object sender, EventArgs e)
        {
            Primitive x1 = 100;
            Primitive y1 = 100;
            Primitive x2 = 150;
            Primitive y2 = 50;
            Primitive radial = LDMath.Convert2Radial(x1, y1, x2, y2);
            TextWindow.WriteLine(radial);
            Primitive pos = LDMath.Convert2Cartesian(x1, y1, radial[1], radial[2]);
            TextWindow.WriteLine(pos);
            Primitive rotate = LDMath.Rotate(x1, y1, x2, y2, 90);
            TextWindow.WriteLine(rotate);
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            LDFile.CSVplaceholder = " ";
            Primitive data = LDFile.ReadCSVTransposed("C:\\temp\\testfile2.csv");

            TextWindow.WriteLine("Read");

            LDFile.WriteCSV("C:\\temp\\testfile2-1.csv", data);
            TextWindow.WriteLine("Write");

            data = LDFile.ReadCSV("C:\\temp\\testfile2-1.csv");
            TextWindow.WriteLine("Read");

            Primitive dataA = SBArray.GetAllIndices(data);
            for (int i = 1; i <= SBArray.GetItemCount(dataA); i++)
            {
                Primitive dataB = SBArray.GetAllIndices(data[dataA[i]]);
                for (int j = 1; j <= SBArray.GetItemCount(dataB); j++)
                {
                    TextWindow.WriteLine(dataA[i] + "," + dataB[j] + " : " + data[dataA[i]][dataB[j]]);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            GraphicsWindow.Clear();
            TextWindow.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            SBProgram.End();
            Application.Exit();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            LDSound.Asterisk();
            LDMusic.Instrument = 20;
            int aa = LDMusic.PlayNote(8, "C", 0);
            Program.Delay(3000);
            LDMusic.EndNote(aa);

            LDMusic.Instrument = LDMusic.Applause;
            LDMusic.PlayNote(8, "C", 0);
            LDMusic.Instrument = LDMusic.Acoustic_Guitar_steel;
            LDMusic.PlayNote(5, "C", 0);
            LDMusic.PlayNote(5, "E", 0);
            LDMusic.Instrument = LDMusic.Choir_Aahs;
            int sustained = LDMusic.PlayNote(6, "A", 0);
            Program.Delay(3000);
            LDMusic.Reset();
            //LDMusic.EndNote(sustained);
            //for (int i = 1; i < 129; i++)
            //{
            //    TextWindow.WriteLine(i);
            //    LDMusic.Instrument = i;
            //    LDMusic.PlayMusic("O5 C8 C8 G8 G8 A8 A8");
            //}
        }

        private void buttonMatrix_Click(object sender, EventArgs e)
        {
            int dim = 16;
            Primitive mat = LDMatrix.Create(dim, dim);
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    //LDMatrix.SetValue(mat, i + 1, j + 1, -SBMath.GetRandomNumber(100) + SBMath.Pi);
                    LDMatrix.SetValue(mat, i + 1, j + 1, SBMath.GetRandomNumber(100));
                }
            }
            //LDMatrix.SetValue(mat, 1, 1, 2);
            //LDMatrix.SetValue(mat, 1, 2, -1);
            //LDMatrix.SetValue(mat, 1, 3, 0);
            //LDMatrix.SetValue(mat, 2, 1, -1);
            //LDMatrix.SetValue(mat, 2, 2, 2);
            //LDMatrix.SetValue(mat, 2, 3, -1);
            //LDMatrix.SetValue(mat, 3, 1, 0);
            //LDMatrix.SetValue(mat, 3, 2, -1);
            //LDMatrix.SetValue(mat, 3, 3, 2);
            Primitive inv = LDMatrix.Create(dim, dim);
            LDMatrix.Inverse(mat, inv);
            Primitive mult = LDMatrix.Create(dim, dim);
            LDMatrix.Multiply(mat, inv, mult);
            LDMatrix.View(mat, "False");
            LDMatrix.Delete(mat);
            LDMatrix.View(inv, "False");
            TextWindow.WriteLine(LDUtilities.KeyDown("Space"));
            TextWindow.WriteLine(LDUtilities.KeyDown("LeftShift"));
        }

        private void buttonWeather_Click(object sender, EventArgs e)
        {
            GraphicsWindow.Show();
            LDControls.AddBrowser(200, 200, "http://smallbasic.com");
            string result = LDNetwork.HighScore("MyGame","Steve",1000);
            TextWindow.WriteLine(result);

            Primitive forecast = LDWeather.Forecast("Rhodes");
            for (int i = 1; i <= SBArray.GetItemCount(forecast); i++)
            {
                TextWindow.WriteLine(forecast[i]);
            }
            TextWindow.WriteLine(LDWeather.Location);
            TextWindow.WriteLine(LDWeather.Conditions);
            TextWindow.WriteLine(LDWeather.TempC);
            TextWindow.WriteLine(LDWeather.TempF);
            TextWindow.WriteLine(LDWeather.WindDirection);
            TextWindow.WriteLine(LDWeather.WindSpeed);
            TextWindow.WriteLine(LDWeather.Humidity);
        }

        private void buttonInstances_Click(object sender, EventArgs e)
        {
            //GraphicsWindow.Show();
            Primitive win = new Primitive();
            for (int i = 0; i < 3; i++)
            {
                win[i] = LDWindows.Create();
                GraphicsWindow.Title = i.ToString();
                //Shapes.AddEllipse(100, 100);
            }
            LDWindows.CurrentID = win[0];
            Primitive ball = Shapes.AddEllipse(100, 100);
            LDWindows.CurrentID = win[1];
            Shapes.AddEllipse(100, 100);
            GraphicsWindow.BackgroundColor = "Red";
            GraphicsWindow.Hide();
            LDWindows.CurrentID = 0;
            GraphicsWindow.Show();
            LDWindows.CurrentID = win[0];
            Shapes.Move(ball, 200, 200);
            LDWindows.CurrentID = 0;
            Shapes.Move(ball, 300, 300);
            //LDWindow.Hide(win[0]);
            //LDWindow.Close(win[1]);
            //Program.Delay(5000);
            //LDWindow.Hide(win[2]);
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            Primitive GraphData = "";
            GraphData[1] = 68;
            GraphData[2] = 68;
            GraphData[3] = 68;

            Primitive MyGraph = LDGraph.AddGraph(100, 25, 400, 400, "Test", "Entry", "Test");
            LDGraph.AddSeriesPoints(MyGraph, "Test", GraphData, "Blue");
            Primitive Trend = LDGraph.CreateTrend(GraphData, 1);
            LDGraph.AddSeriesLine(MyGraph, "Trendline", Trend, "Green");

            //Primitive data = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    data[i] = SBMath.GetRandomNumber(100) * 1.075;
            //}
            //Primitive graph = LDGraph.AddGraph(0, 0, GraphicsWindow.Width, GraphicsWindow.Height, "Title", "X", "Y");
            //LDGraph.AddSeriesHistogram(graph, "Lable", data, "Blue");
        }

        private void buttonZip_Click(object sender, EventArgs e)
        {
            Primitive files = "C:\\temp\\temp";
            Primitive files1 = "C:\\temp\\temp1";
            Primitive archive = "C:\\temp\\test.zip";
            //LDUtilities.Zip(archive, files);
            LDUtilities.UnZip(archive, files1);
        }

        private void button3DView_Click(object sender, EventArgs e)
        {
            GraphicsWindow.Width = 500;
            GraphicsWindow.Height = 500;
            //GraphicsWindow.BackgroundColor = "Red";
            Primitive view3D = LD3DView.AddView(500,500,"False");
            Primitive points = "-0.5: -0.5: 0.5 0.5: -0.5: 0.5 0.5: 0.5: 0.5 0.5: 0.5: 0.5 -0.5: 0.5: 0.5 -0.5: -0.5: 0.5";
            Primitive indices = "0 2 1 3 5 4";
            Primitive geom = LD3DView.AddGeometry(view3D,points,indices,"","White","D");
            LD3DView.ReverseNormals(view3D, geom);
            LD3DView.ResetCamera(view3D, 0, 0, 2, 0, 0, -1, 0, 1, 0);
            //LD3DView.AddDirectionalLight(view3D,"White",0,0,-1);
            LD3DView.AddSpotLight(view3D, "Red", 0,0,10,0, 0, -1,20,100);
            //LD3DView.Freeze(view3D,geom);
            //LD3DView.RotateGeometry(view3D, geom, 0, 0, 1, 45);
            LD3DView.AnimateRotation(view3D, geom, 0, 0, 1, 0, 360, 1, 1);
            LD3DView.LoadModel(view3D, "C:\\temp\\room.3ds");
        }

        private void buttonUSB_Click(object sender, EventArgs e)
        {
            //Primitive devices = LDHID.AddDevice("046D", "C215", "Joystick");
            Primitive devices = LDHID.FindDevices();
            TextWindow.WriteLine(devices);
        }

        private void buttonBlueTooth_Click(object sender, EventArgs e)
        {
            Primitive encodings = LDBlueTooth.GetEncodings();
            for (int i = 1; i <= SBArray.GetItemCount(encodings); i++)
            {
                TextWindow.WriteLine(encodings[i]);
            }

            Primitive status = LDBlueTooth.Initialise();
            if (status)
            {
                Primitive devices = LDBlueTooth.GetDevices();
                for (int i = 1; i <= SBArray.GetItemCount(devices); i++)
                {
                    TextWindow.WriteLine(devices[i]);
                }
            }
            else
            {
                TextWindow.WriteLine(LDBlueTooth.LastError);
            }
            while (true)
            {
                Program.Delay(100);
            }
        }

        private void buttonChangeLog_Click(object sender, EventArgs e)
        {
            ChangeLog();
        }

        private void buttonDoAll_Click(object sender, EventArgs e)
        {
            ChangeLog();
            CopyDll();
            Process proc = Process.Start(Application.StartupPath + "..\\..\\..\\..\\..\\..\\LitDevUtilities\\LitDevUtilities\\bin\\Release\\LitDevUtilities.exe");
            while (!proc.HasExited) System.Threading.Thread.Sleep(100);

            proc = Process.Start(Application.StartupPath + "..\\..\\..\\..\\MergeLitDev.bat");
            while (!proc.HasExited) System.Threading.Thread.Sleep(100);

            proc = Process.Start("C:\\Users\\Steve\\Documents\\SmallBasic\\steve\\LitDev_Zips.exe");
            while (!proc.HasExited) System.Threading.Thread.Sleep(100);

            Application.Exit();
        }

        private void buttonCopyDll_Click(object sender, EventArgs e)
        {
            CopyDll();
        }

        private void buttonCombineDll_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "..\\..\\..\\..\\MergeLitDev.bat");
        }

        private void buttonUtilities_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "..\\..\\..\\..\\..\\LitDevUtilities\\LitDevUtilities\\bin\\Release\\LitDevUtilities.exe");
        }

        private void CopyDll()
        {
            try
            {
                System.IO.File.Copy(Application.StartupPath + "\\LitDev.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\LitDev.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\LitDev.xml", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\LitDev.xml", true);
                System.IO.File.Copy(Application.StartupPath + "\\HelixToolkit.Wpf.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\HelixToolkit.Wpf.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\InTheHand.Net.Personal.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\InTheHand.Net.Personal.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\Ionic.Zip.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\Ionic.Zip.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\MySql.Data.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\MySql.Data.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\System.Data.SQLite.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\System.Data.SQLite.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\DirectShowLib-2005.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\DirectShowLib-2005.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\Svg.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\Svg.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\IWshRuntimeLibrary.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\IWshRuntimeLibrary.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\Interop.Shell32.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\Interop.Shell32.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\SlimDX.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\SlimDX.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\MathNet.Numerics.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\MathNet.Numerics.dll", true);
                System.IO.File.Copy(Application.StartupPath + "\\Newtonsoft.Json.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\Newtonsoft.Json.dll", true);
                //System.IO.File.Copy(Application.StartupPath + "\\Microsoft.Expression.Effects.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\Microsoft.Expression.Effects.dll", true);
                //System.IO.File.Copy(Application.StartupPath + "\\Microsoft.Expression.Interactions.dll", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft\\Small Basic\\lib\\Microsoft.Expression.Interactions.dll", true);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private void ChangeLog()
        {
            string htmlFile = "C:\\Users\\Steve\\Documents\\LitDev\\ChangeLog.html";
            StreamWriter sw = new StreamWriter(htmlFile, false);

            //sw.WriteLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\">"); 
            sw.WriteLine("<!DOCTYPE html>");
            sw.WriteLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
            sw.WriteLine("<head>");
            sw.WriteLine(" <meta http-equiv=\"Content-type\" content=\"text/html;charset=UTF-8\">");
            sw.WriteLine(" <title>" + " LitDev ChangeLog</title>");
            sw.WriteLine(" <meta name=\"description\" content=\"SmallBasic " + " LitDev ChangeLog\" />");
            sw.WriteLine(" <meta name=\"keywords\" content=\"SmallBasic,litdev,ChangeLog\" />");
            sw.WriteLine(" <link rel=\"stylesheet\" type=\"text/css\" href=\"styleAPI.css\" />");
            sw.WriteLine(" <link rel=\"shortcut icon\" href=\"favicon.ico\" />");
            sw.WriteLine("</head>");
            sw.WriteLine("<body>");
            sw.WriteLine("<div id=\"wrapper\">");
            sw.WriteLine("<div id=\"content\">");
            sw.WriteLine();
            sw.Write("<p class=\"" + "assembly" + "\">");
            sw.Write("LitDev Extension Change Log");
            sw.Write("</p>");
            sw.WriteLine("<p class=\"links\">");
            sw.WriteLine("&nbsp;<a href=\"index.html\">Return to Main Page</a>");
            sw.WriteLine("</p>");

            FormChangeLog changeLog = new FormChangeLog();
            foreach (TreeNode node1 in changeLog.treeView1.Nodes)
            {
                sw.Write("<br />" + "<span class=\"" + "group" + "\">");
                sw.Write(node1.Text + "<br />");
                sw.WriteLine("</span>");
                foreach (TreeNode node2 in node1.Nodes)
                {
                    sw.Write("<span class=\"" + "method" + "\">");
                    sw.Write(node2.Text + "<br />");
                    sw.WriteLine("</span>");
                    foreach (TreeNode node3 in node2.Nodes)
                    {
                        sw.Write("<span class=\"" + "text" + "\">");
                        sw.Write(node3.Text + "<br />");
                        sw.WriteLine("</span>");
                    }
                }
            }

            sw.WriteLine("<br />");
            sw.WriteLine("<div id=\"footer\">");
            sw.WriteLine("<hr style=\"height: 2px; width: 100%;\" />");
            sw.WriteLine("<a style=\"position: relative; float: left;\" href=\"http://free-website-translation.com/\" id=\"ftwtranslation_button\" hreflang=\"en\" title=\"\" style=\"border:0;\"><img src=\"http://free-website-translation.com/img/fwt_button_en.gif\" id=\"ftwtranslation_image\" alt=\"Website Translation Widget\" style=\"border:0;\"/></a> <script type=\"text/javascript\" src=\"http://free-website-translation.com/scripts/fwt.js\" /></script>");
            //sw.WriteLine("<a style=\"position: relative; float: right;\" href=\"http://www.000webhost.com/\" target=\"_blank\"><img src=\"http://www.000webhost.com/images/80x15_powered.gif\" alt=\"Web Hosting\" width=\"80\" height=\"15\" border=\"0\" /></a>");
            sw.WriteLine("</div>");
            sw.WriteLine("</div>");
            sw.WriteLine("</div>");
            sw.WriteLine("</body>");
            sw.WriteLine("<script>");
            sw.WriteLine("(function (i, s, o, g, r, a, m) {");
            sw.WriteLine(" i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {");
            sw.WriteLine("  (i[r].q = i[r].q || []).push(arguments)");
            sw.WriteLine(" }, i[r].l = 1 * new Date(); a = s.createElement(o),");
            sw.WriteLine(" m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)");
            sw.WriteLine("})(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');");
            sw.WriteLine("ga('create', 'UA-28519634-1', 'auto');");
            sw.WriteLine("ga('send', 'pageview');");
            sw.WriteLine("</script>");
            //sw.WriteLine("<script type=\"text/javascript\">");
            //sw.WriteLine("var _gaq = _gaq || [];");
            //sw.WriteLine("_gaq.push(['_setAccount', 'UA-28519634-1']);");
            //sw.WriteLine("_gaq.push(['_trackPageview']);");
            //sw.WriteLine("(function () {");
            //sw.WriteLine("var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;");
            //sw.WriteLine("ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';");
            //sw.WriteLine("var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);");
            //sw.WriteLine("})();");
            //sw.WriteLine("</script>");
            sw.WriteLine("</html>");
            sw.Close();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //Primitive result = LDftp.ListFiles("gnu", "ftp.gnu.org", "", "");
            //result = LDftp.ListFiles("ftp://ftp.gnu.org/gnu/","ftp://ftp.gnu.org/gnu/","","");
            Primitive result = LDftp.ListFiles("Notebooks/15,4 Zoll Notebooks", "download.chiligreen.com", "", "");
            TextWindow.WriteLine(result);
               
            Primitive datFile = "C:/Users/steve/Documents/SmallBasic/steve/database.db";
            Primitive database = LDDataBase.ConnectSQLite(datFile);
            Primitive dataView = LDControls.AddDataView(240, 350, "");
            LDDataBase.EditTable(datFile, "Cars", dataView);
            LDDataBase.SaveTable(database, dataView);

            LDTranslate.Translate("Ein Besuch im Zoo.", "de", "en");

            Primitive img1 = LDClipboard.GetImage();
            LDImage.SaveAs(img1, "C:\\Temp\\DemoImg.jpg");

            Primitive shp = Microsoft.SmallBasic.Library.Controls.AddButton("Button", 10, 10);
            LDShapes.ReSize(shp, 100, 100);
            LDShapes.ReSize(shp, 200, 200);

            Primitive xx = LDFastArray.Add();
            LDFastArray.Set(xx,"1 2 3",24);
            FieldInfo _primitive = typeof(Primitive).GetField("_primitive", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance);
            Primitive aa = "1 23 45";
            string bb = (string)_primitive.GetValue(aa);
            Primitive sb = "1=1\\=\"hello\"\\;2\\=1\\;3\\=2\\;;2=1\\=3\\;2\\=test\\;3\\=3\\;;";
            Primitive arr = LDFastArray.CreateFromValues(sb);
            Primitive sb1 = LDFastArray.ToArray(arr);

            Primitive a = LDFastArray.Add();
            LDFastArray.Set2D(a, 2, 5, 10);
            LDFastArray.Set2D(a, 2, 2, 20);
            LDFastArray.Set2D(a, 1, 8, 30);
            LDFastArray.Collapse(a);
            Primitive b = LDFastArray.ToArray(a);

            Primitive img = Microsoft.SmallBasic.Library.ImageList.LoadImage("https://upload.wikimedia.org/wikipedia/commons/thumb/d/d6/STS120LaunchHiRes-edit1.jpg/153px-STS120LaunchHiRes-edit1.jpg");
            //Primitive x1 = LDImage.Copy(img);
            //LDImage.EffectCharcoal(x1);




            Primitive image = LDImage.NewImage(100, 100, "Red");
            LDImage.OpenWorkingImage(image);
            Primitive xml = LDxml.Open("C:\\Users\\Steve\\Documents\\SmallBasic\\steve\\sample.xml");
            Primitive data = LDxml.ToArray();
            LDxml.FromArray(data);
            LDxml.Save("C:\\Users\\Steve\\Documents\\SmallBasic\\steve\\sample1.xml");
            Primitive txt = Microsoft.SmallBasic.Library.File.ReadContents("C:\\Users\\Steve\\Documents\\SmallBasic\\steve\\txt.txt");
            LDSearch.GetProof(txt, "");
            LDSearch.GetWeb("bill gates");
            return;
            //TextWindow.Show();
            //LDTextWindow.SetColours("Pink", "Orange");
            //TextWindow.WriteLine("Hello World");

            LDPhysics.ReadJson("C:\\Users\\Steve\\Documents\\SmallBasic\\steve\\LDPysics.json", 1, "False", "False", 0, 0);

            LDWaveForm.PlayWave(256, 1000, "0=-1;1=1;5=0;");

            Primitive shape = Shapes.AddRectangle(100, 100);
            LDEffect.Bloom(shape,"");
            Program.Delay(1000);

            LDControls.AddDataView(GraphicsWindow.Width, GraphicsWindow.Height, "1=Hello;2=World;");

            //string _urlTemplate = "https://api.flickr.com/services/rest/?sort=interestingness-desc&safe_search=1&license=1,2,3,4,5,6,7&api_key=";
            //string _picUrlTemplate = "http://farm{0}.static.flickr.com/{1}/{2}_{3}.jpg";
            byte[] array = Convert.FromBase64String("MWY5ZmI5ODE4Mjk2NzAwNTgwYmYzMzQwMjc5MzQ2YjY=");
            //_urlTemplate += Encoding.UTF8.GetString(array, 0, array.Length);
            TextWindow.WriteLine(Encoding.UTF8.GetString(array, 0, array.Length));

            Primitive rtb = LDControls.AddRichTextBox(100, 100);
            LDControls.RichTextBoxSetText(rtb, "Hello","True");
            LDCall.Compile("C:\\Users\\Steve\\Documents\\SmallBasic\\steve\\testinclude.sb");
            Primitive include = LDCall.Include("C:\\Users\\Steve\\Documents\\SmallBasic\\steve\\testinclude.exe");
            TextWindow.WriteLine(include);

            LDUtilities.FixFlickr();//FCClipboard.GetText
            LDCall.CallAsync("SmallBasicLibrary.dll", "Microsoft.SmallBasic.Library", "Flickr", "GetRandomPicture", "Car");

            string tempFileName = Path.GetTempFileName();
            Stream stream = null;
            Stream stream2 = null;
            WebResponse webResponse = null;
            try
            {
                string url = "https://a75b9da71f50095fc4dc527d860da4427f274b07.googledrive.com/host/0B9s0FFxEQDb6T3VUdEw3QTJDS1E/efecast00.mp3";
                Uri uri = new Uri(url);
                WebRequest webRequest = WebRequest.Create(url);
                webResponse = webRequest.GetResponse();
                stream = System.IO.File.Open(tempFileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                byte[] buffer = new byte[16384];
                long num = webResponse.ContentLength;
                stream2 = webResponse.GetResponseStream();
                int readCount = stream2.Read(buffer, 0, 16384);
                while (readCount > 0L)
                {
                    stream.Write(buffer, 0, readCount);
                    readCount = stream2.Read(buffer, 0, 16384);
                }
            }
            catch (Exception ex)
            {
                TextWindow.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
                if (stream2 != null)
                {
                    stream2.Close();
                }
                if (webResponse != null)
                {
                    webResponse.Close();
                }
            }

            LDGraphicsWindow.SetFontFromFile("C:\\temp\\04b.ttf");
            TextWindow.Show();
            //Primitive source = "class Evaluator { public static function Eval(expr : String) : String { return eval(expr); } }";
            //LDInline.IncludeJScript(source,"","");
            //Primitive result = LDInline.Call("Eval","5+3");
            //TextWindow.WriteLine(result);

            //TextWindow.Hide();
            Primitive x = LDMath.Evaluate("1e6 + 6/4");
            Primitive y = LDMath.Evaluate2("1e6 + 6/4");
            //TextWindow.Hide();
            TextWindow.WriteLine("HERE " + x + " :" + y);

            LDImage.LoadSVG("C:\\temp\\snowtitle.svg");
            TextWindow.WriteLine(LDNetwork.LAN(1000));

            GraphicsWindow.Show();
            LDText.GetWidth("Hello World");

            Primitive server = LDServer.Start("True");
            LDClient.Connect(server, "True");
            LDClient.SendMessage("Hello1");
            LDClient.SendMessage("World1");
            LDServer.Disconnect("Client1");
            LDClient.Connect(server, "True");
            LDClient.SendMessage("Hello3");
            LDClient.SendMessage("World3");

            GraphicsWindow.Show();
            LDGraphicsWindow.FloodFill(200, 100, "#5588ee");
            //Program.Delay(1000000);
            //Primitive languages = LDTranslate.Languages();
            //Primitive indices = SBArray.GetAllIndices(languages);
            //for (int i = 1; i <= SBArray.GetItemCount(languages); i++)
            //{
            //    TextWindow.WriteLine(indices[i] + " : " + languages[indices[i]]);
            //}
            //Primitive result = LDTranslate.Translate("Hello World", "", "de");
            //TextWindow.WriteLine(result);

            //TextWindow.WriteLine(GraphicsWindow.FontName);
            //GraphicsWindow.DrawText(10, 10, "Hello World");
            //Primitive result = LDGraphicsWindow.SetFontFromFile("C:\\Users\\Public\\Documents\\SmallBasic\\steve\\WWFlakes.ttf");
            //TextWindow.WriteLine(GraphicsWindow.FontName);
            //GraphicsWindow.DrawText(10, 50, "Hello World");

            //PrivateFontCollection fntColl = new PrivateFontCollection();
            //fntColl.AddFontFile("C:\\Users\\Public\\Documents\\SmallBasic\\steve\\WWFlakes.ttf");
            //buttonTest.Font = new Font(fntColl.Families[0], 16, FontStyle.Regular);

            //LDDictionary.GetDefinition("Car");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Steve\\Documents\\SmallBasic\\steve\\LitDev_Zips.exe");
        }

        private void buttonUnits_Click(object sender, EventArgs e)
        {
            LDUnits.GetBaseUnits();

            Primitive aa = LDMath.Rotate(0, 0, 0, -100, 180);

            Primitive view = LD3DView.AddView(500, 500, "True");
            LD3DView.ResetCamera(view, 0, 0, -20, 0, 0, 1, 0, 1, 0);
            LD3DView.AddDirectionalLight(view, "Red", 1, 0, 1);
            LD3DView.AddDirectionalLight(view, "Green", 1, 0, -1);
            LD3DView.AddDirectionalLight(view, "Blue", -1, 0, 1);
            LD3DView.AddDirectionalLight(view, "Yellow", -1, 0, -1);
            Primitive cube = LD3DView.AddCube(view, 1, "Red", "D");
            LD3DView.SetBillBoard(view, cube);
            for (int i = 1; i < 100; i++)
            {
                LD3DView.MoveCamera(view, i, 1, 1, 1);
            }

            //Primitive button = Microsoft.SmallBasic.Library.Controls.AddButton("Test", 50, 50);
            //LDControls.SetButtonStyle(button, "Red", "Blue", "Green", "Black", "Black", "Black", 9, "True");

            //GraphicsWindow.Width = 200;
            //GraphicsWindow.Height = 200;
            //Primitive title = "";
            //for (int i = 1; i <= 20; i++)
            //{
            //    title[i] = "TEST" + i;
            //}
            //Primitive dv = LDControls.AddDataView(200, 200, title);
            //Primitive row = "";
            //for (int i = 1; i <= 20; i++)
            //{
            //    for (int j = 1; j <= 20; j++)
            //    {
            //        row[j] = Microsoft.SmallBasic.Library.Math.GetRandomNumber(1000000);
            //    }
            //    LDControls.DataViewSetRow(dv, i, row);
            //}

            //UnitSystem unitSystem = new UnitSystem();
            //double[] values = new double[22];
            //int i = 0;
            //values[i++] = unitSystem.Convert(1, "[D.ft/cP.psi]+[ft3/day]", "ft3/day");
            //values[i++] = unitSystem.Convert(1, "mu0.e0", "1/c2");
            //values[i++] = unitSystem.Convert(1, "RC", "J/K/mol");
            //values[i++] = unitSystem.Convert(1, "eQ", "Q");
            //values[i++] = unitSystem.Convert(6, "min/mile", "min/Km");
            //values[i++] = unitSystem.Convert(9.81, "m/s2", "ft/s2");
            //values[i++] = unitSystem.Convert(1, "Avagadro.M.l", "1");
            //values[i++] = unitSystem.Convert(1, "D.ft/cP.psi", "ft3/day");
            //values[i++] = unitSystem.Convert(1, "psi+(14.69)", "psig");
            //values[i++] = unitSystem.Convert(1, "Kilo.ft3/day", "ft3/day");
            //values[i++] = unitSystem.Convert(1, "m(-1)", "1/in");
            //values[i++] = unitSystem.Convert(1, "Kg/min2", "g/hr2");
            //values[i++] = unitSystem.Convert(1, "mm", "m");
            //values[i++] = unitSystem.Convert(1, "1/cN2", "1/N2");
            //values[i++] = unitSystem.Convert(1, "pi.KJ", "N.m");
            //values[i++] = unitSystem.Convert(100, "mC", "F");
            //values[i++] = unitSystem.Convert(1, "BTU2", "J2");
            //values[i++] = unitSystem.Convert(1, "ton", "tonne");
            //values[i++] = unitSystem.Convert(1, "W", "Volt.Amp");
            //values[i++] = unitSystem.Convert(1, "psi", "lbf/in2");
            //values[i++] = unitSystem.Convert(1, "Kpsig", "Kpsi");
            //values[i++] = unitSystem.Convert(1, "USD", "GBP");
        }
    }
}
