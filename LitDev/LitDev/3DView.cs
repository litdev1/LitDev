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

using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Input;
using LitDev.Engines;

namespace LitDev
{
    /// <summary>
    /// 3D Visualisation in the GraphicsWindow.
    /// 
    /// Coordinates have the following directions and have no correspondence to the GraphicsWindow coordinates.
    /// X - Left(-) to Right(+)
    /// Y - Down(-) to Up(+)
    /// Z - Far(-) to Near(+)
    /// 
    /// For more details on the underlying methods see http://msdn.microsoft.com/en-us/library/ms747437%28v=vs.90%29.aspx
    /// Several of the AddShape methods use HelixToolkit (recompiled and slightly modified for SmallBasic) http://helixToolkit.codeplex.com
    /// 
    /// Also see LDVector for vector algebra methods.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LD3DView
    {
        public static Vector3D swapDirection = new Vector3D(1, 0, 0);
        public static double swapAngle = -90;

        private static Dictionary<string, UIElement> _objectsMap = (Dictionary<string, UIElement>)typeof(GraphicsWindow).GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

        private static int iLight = 0;
        private class Lighting
        {
            public string name;
            public Light light;
            public Lighting(string _name, Light _light)
            {
                name = _name;
                light = _light;
            }
        }
        private static List<Lighting> Lightings = new List<Lighting>();
        private static Lighting getLighting(string name)
        {
            return Lightings.Find(item => item.name == name);
        }
        private static string getLightingName()
        {
            return "Light" + (++iLight).ToString();
        }

        private static int iGeometry = 0;
        private class Geometry
        {
            public string name;
            public GeometryModel3D geometryModel3D;
            public Geometry(string _name, GeometryModel3D _geometryModel3D)
            {
                name = _name;
                geometryModel3D = _geometryModel3D;
            }
        }
        private static List<Geometry> Geometries = new List<Geometry>();
        private static Geometry getGeometry(string name)
        {
            return Geometries.Find(item => item.name == name);
        }
        private static string getGeometryName()
        {
            return "Geometry" + (++iGeometry).ToString();
        }

        private static Dictionary<string, List<string>> BillBoards = new Dictionary<string, List<string>>();
        private static List<Viewport3D> views = new List<Viewport3D>();

        public static Object lockObj = new Object(); //public static to keep the queue thread safe
        private static double specular = 5;

        private static string lastRotation = "";
        private static Queue<string> queueRotation = new Queue<string>();
        private static SBCallback _RotationCompletedDelegate = null;
        private static void _RotationCompletedEvent(Geometry geom)
        {
            queueRotation.Enqueue(geom.name);
            if (null != _RotationCompletedDelegate) _RotationCompletedDelegate();
        }

        private static string lastTranslation = "";
        private static Queue<string> queueTranslation = new Queue<string>();
        private static SBCallback _TranslationCompletedDelegate = null;
        private static void _TranslationCompletedEvent(Geometry geom)
        {
            queueTranslation.Enqueue(geom.name);
            if (null != _TranslationCompletedDelegate) _TranslationCompletedDelegate();
        }

        private enum transform
        {
            Rotate1,
            Rotate2,
            Rotate3,
            Scale,
            Translate
        }

        private static string[] stringSeparators = new string[] { " ", ":" };

        private static RayHitTestResult rayResult = null;
        private static HitTestResultBehavior ResultCallback(HitTestResult result)
        {
            rayResult = result as RayHitTestResult;
            return HitTestResultBehavior.Stop; // Nearest
        }

        private static void AddTransforms(GeometryModel3D geometry)
        {
            double X = geometry.Bounds.X + geometry.Bounds.SizeX / 2.0;
            double Y = geometry.Bounds.Y + geometry.Bounds.SizeY / 2.0;
            double Z = geometry.Bounds.Z + geometry.Bounds.SizeZ / 2.0;

            RotateTransform3D rotateTransform3D = new RotateTransform3D();
            AxisAngleRotation3D axisAngleRotation3D = new AxisAngleRotation3D();
            axisAngleRotation3D.Axis = new Vector3D(0, 1, 0);
            axisAngleRotation3D.Angle = 0;
            rotateTransform3D.Rotation = axisAngleRotation3D;
            rotateTransform3D.CenterX = X;
            rotateTransform3D.CenterY = Y;
            rotateTransform3D.CenterZ = Z;

            RotateTransform3D rotateTransform3D2 = new RotateTransform3D();
            AxisAngleRotation3D axisAngleRotation3D2 = new AxisAngleRotation3D();
            axisAngleRotation3D2.Axis = new Vector3D(0, 1, 0);
            axisAngleRotation3D2.Angle = 0;
            rotateTransform3D2.Rotation = axisAngleRotation3D2;
            rotateTransform3D2.CenterX = X;
            rotateTransform3D2.CenterY = Y;
            rotateTransform3D2.CenterZ = Z;

            RotateTransform3D rotateTransform3D3 = new RotateTransform3D();
            AxisAngleRotation3D axisAngleRotation3D3 = new AxisAngleRotation3D();
            axisAngleRotation3D3.Axis = new Vector3D(0, 1, 0);
            axisAngleRotation3D3.Angle = 0;
            rotateTransform3D3.Rotation = axisAngleRotation3D3;
            rotateTransform3D3.CenterX = X;
            rotateTransform3D3.CenterY = Y;
            rotateTransform3D3.CenterZ = Z;

            ScaleTransform3D scaleTransform3D = new ScaleTransform3D();
            scaleTransform3D.CenterX = X;
            scaleTransform3D.CenterY = Y;
            scaleTransform3D.CenterZ = Z;
            scaleTransform3D.ScaleX = 1;
            scaleTransform3D.ScaleY = 1;
            scaleTransform3D.ScaleZ = 1;

            TranslateTransform3D translateTransform3D = new TranslateTransform3D();
            translateTransform3D.OffsetX = 0;
            translateTransform3D.OffsetY = 0;
            translateTransform3D.OffsetZ = 0;

            Transform3DGroup transform3DGroup = new Transform3DGroup();
            transform3DGroup.Children.Add(rotateTransform3D);
            transform3DGroup.Children.Add(rotateTransform3D2);
            transform3DGroup.Children.Add(rotateTransform3D3);
            transform3DGroup.Children.Add(scaleTransform3D);
            transform3DGroup.Children.Add(translateTransform3D);
            geometry.Transform = transform3DGroup;
        }

        private static string AddGeometry(Viewport3D viewport3D, Point3DCollection pointCollection, Int32Collection indexCollection, Vector3DCollection normalCollection, PointCollection textureCollection, string colour, string materialType)
        {
            try
            {
                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                GeometryModel3D geometry = new GeometryModel3D();
                MeshGeometry3D mesh = new MeshGeometry3D();

                mesh.Positions = pointCollection;
                mesh.TriangleIndices = indexCollection;
                if (normalCollection.Count == pointCollection.Count) mesh.Normals = normalCollection;
                if (textureCollection.Count == pointCollection.Count) mesh.TextureCoordinates = textureCollection;

                // Apply the mesh to the geometry model.
                geometry.Geometry = mesh;

                AddTransforms(geometry);

                MaterialGroup material = new MaterialGroup();
                Brush brush = null;
                foreach (GradientBrush iBrush in LDShapes.brushes)
                {
                    if (iBrush.name == colour)
                    {
                        brush = iBrush.getBrush();
                    }
                }
                if (null == brush) brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                switch (materialType.ToString().ToLower())
                {
                    case "e":
                        material.Children.Add(new DiffuseMaterial(brush));
                        material.Children.Add(new EmissiveMaterial(brush));
                        geometry.Material = material;
                        break;
                    case "d":
                        material.Children.Add(new DiffuseMaterial(brush));
                        geometry.Material = material;
                        break;
                    case "s":
                        material.Children.Add(new SpecularMaterial(brush, specular));
                        geometry.Material = material;
                        break;
                }

                string name = getGeometryName();
                Geometries.Add(new Geometry(name, geometry));
                model3DGroup.Children.Add(geometry);
                return name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        private static void UpdateBillBoards(Viewport3D viewport3D, string shapeName)
        {
            lock (lockObj)
            {
                if (BillBoards.ContainsKey(shapeName))
                {
                    foreach (string billBoard in BillBoards[shapeName])
                    {
                        double tol = 1e-6;
                        Geometry geom = getGeometry(billBoard);
                        if (null == geom) continue;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;
                        Vector3D lookDirection = camera.LookDirection;
                        Vector3D upDirection = camera.UpDirection;
                        lookDirection.Normalize();
                        upDirection.Normalize();
                        Vector3D screenDirection = Vector3D.CrossProduct(lookDirection, upDirection);

                        Vector3D Z = new Vector3D(0, 0, -1);
                        RotateTransform3D rotateTransform3D1 = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate2];
                        AxisAngleRotation3D axisAngleRotation3D1 = new AxisAngleRotation3D();
                        axisAngleRotation3D1.Axis = Vector3D.CrossProduct(lookDirection, Z);
                        axisAngleRotation3D1.Angle = Vector3D.AngleBetween(lookDirection, Z);
                        rotateTransform3D1.Rotation = axisAngleRotation3D1;

                        Z = rotateTransform3D1.Transform(new Vector3D(0, 0, -1)) - rotateTransform3D1.Transform(new Vector3D(0, 0, 0));
                        Z.Normalize();
                        if (Vector3D.DotProduct(lookDirection, Z) < 1 - tol) axisAngleRotation3D1.Angle *= -1;

                        Vector3D Y = rotateTransform3D1.Transform(new Vector3D(0, 1, 0)) - rotateTransform3D1.Transform(new Vector3D(0, 0, 0));
                        Y.Normalize();

                        RotateTransform3D rotateTransform3D2 = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate3];
                        AxisAngleRotation3D axisAngleRotation3D2 = new AxisAngleRotation3D();
                        axisAngleRotation3D2.Axis = lookDirection;
                        axisAngleRotation3D2.Angle = Vector3D.AngleBetween(upDirection, Y);
                        rotateTransform3D2.Rotation = axisAngleRotation3D2;

                        Y = rotateTransform3D2.Transform(Y);
                        Y.Normalize();
                        if (Vector3D.DotProduct(upDirection, Y) < 1 - tol) axisAngleRotation3D2.Angle *= -1;

                        geometry.Transform = transform3DGroup;
                    }
                }
            }
        }

        private static Point lastPos = new Point(-1, -1);
        private static string centerGeom = "";
        private static int autoMode = 0;
        private static bool bPitchRoll = false;
        private static bool bShift = false;
        private static double keyDist = 0;
        private static double speedMult = 1;
        private static double panRight = 0;
        private static double panUp = 0;

        private static Point3D GetCentre(GeometryModel3D geometry)
        {
            Transform3D transform3D = (Transform3D)geometry.Transform;
            Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;
            RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate1];
            return new Point3D(rotateTransform3D.CenterX, rotateTransform3D.CenterY, rotateTransform3D.CenterZ);
        }

        private static void _MouseMove(object sender, MouseEventArgs e)
        {
            lock (lockObj)
            {
                Window window = (Window)sender;
                Point pos = e.GetPosition(window);

                if (autoMode == 1 || e.LeftButton == MouseButtonState.Pressed || e.RightButton == MouseButtonState.Pressed)
                {
                    foreach (Viewport3D viewport3D in views)
                    {
                        if (!_objectsMap.ContainsKey(viewport3D.Name))
                        {
                            views.Remove(viewport3D);
                            continue;
                        }
                        if (e.LeftButton == MouseButtonState.Pressed)
                        {
                            double yaw = -(pos.X - lastPos.X) * 180 / viewport3D.ActualWidth;
                            double pitch = bPitchRoll ? (pos.Y - lastPos.Y) * 180 / viewport3D.ActualHeight : 0;

                            if (autoMode == 1 || (bShift && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))))
                            {
                                ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;
                                Vector3D lookDirection = camera.LookDirection;
                                Vector3D upDirection = camera.UpDirection;
                                Vector3D screenDirection = Vector3D.CrossProduct(lookDirection, upDirection);
                                Point3D position = camera.Position;
                                lookDirection.Normalize();
                                screenDirection = Vector3D.CrossProduct(lookDirection, upDirection);
                                screenDirection.Normalize();
                                upDirection = Vector3D.CrossProduct(screenDirection, lookDirection);

                                bool reset = false;
                                if (centerGeom == "")
                                {
                                    if (Geometries.Count == 0) return;
                                    Primitive hit = HitTest(viewport3D.Name, -1, -1);
                                    if (hit == "") centerGeom = Geometries[0].name;
                                    else centerGeom = hit[1];
                                    reset = true;
                                }
                                Geometry geom = getGeometry(centerGeom);
                                GeometryModel3D geometry = geom.geometryModel3D;
                                Transform3D transform3D = (Transform3D)geometry.Transform;

                                if (reset)
                                {
                                    Point3D centerMove = transform3D.Transform(GetCentre(geometry));
                                    panRight = Vector3D.DotProduct(screenDirection, position - centerMove);
                                    panUp = Vector3D.DotProduct(upDirection, position - centerMove);
                                }
                                //TextWindow.WriteLine(panRight + " : " + panUp);
                                //TextWindow.WriteLine("SCREEN " + screenDirection.X + "," + screenDirection.Y + "," + screenDirection.Z);
                                //TextWindow.WriteLine("UP " + upDirection.X + "," + upDirection.Y + "," + upDirection.Z);
                                //TextWindow.WriteLine("LOOK " + lookDirection.X + "," + lookDirection.Y + "," + lookDirection.Z);
                                Vector3D move = panRight * screenDirection + panUp * upDirection;
                                Point3D center = transform3D.Transform(GetCentre(geometry)) + move;
                                position += move;

                                RotateTransform3D yawTransform = new RotateTransform3D(new AxisAngleRotation3D(upDirection, yaw), center);
                                position = yawTransform.Transform(position);
                                RotateTransform3D pitchTransform = new RotateTransform3D(new AxisAngleRotation3D(screenDirection, -pitch), center);
                                position = pitchTransform.Transform(position);
                                position -= move;

                                lookDirection = center - position;
                                lookDirection.Normalize();
                                screenDirection = Vector3D.CrossProduct(lookDirection, upDirection);
                                screenDirection.Normalize();
                                upDirection = Vector3D.CrossProduct(screenDirection, lookDirection);

                                ResetCamera(viewport3D.Name, position.X, position.Y, position.Z, lookDirection.X, lookDirection.Y, lookDirection.Z, upDirection.X, upDirection.Y, upDirection.Z);
                            }
                            else
                            {
                                MoveCamera(viewport3D.Name, yaw, pitch, 0, 0);
                            }
                        }
                        if (bPitchRoll && e.RightButton == MouseButtonState.Pressed)
                        {
                            double roll = -(pos.X - lastPos.X) * 180 / viewport3D.ActualWidth;
                            MoveCamera(viewport3D.Name, 0, 0, roll, 0);
                        }
                    }
                }
                lastPos = pos;
            }
        }

        private static void _MouseWheel(object sender, MouseWheelEventArgs e)
        {
            lock (lockObj)
            {
                foreach (Viewport3D viewport3D in views)
                {
                    if (!_objectsMap.ContainsKey(viewport3D.Name))
                    {
                        views.Remove(viewport3D);
                        continue;
                    }
                    double move = -e.Delta / 100.0 * speedMult;
                    if (bShift && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))) move *= 5;
                    if (bShift && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))) move /= 5;
                    MoveCamera(viewport3D.Name, 0, 0, 0, move);
                }
            }
        }

        private static void _KeyDown(object sender, KeyEventArgs e)
        {
            lock (lockObj)
            {
                if (keyDist <= 0) return;

                foreach (Viewport3D viewport3D in views)
                {
                    if (!_objectsMap.ContainsKey(viewport3D.Name))
                    {
                        views.Remove(viewport3D);
                        continue;
                    }
                    ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;
                    Vector3D lookDirection = camera.LookDirection;
                    Vector3D upDirection = camera.UpDirection;
                    Point3D position = camera.Position;
                    double mult = (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) ? 1 : -1;

                    Point3D center = new Point3D(0, 0, 0);
                    if (centerGeom != "")
                    {
                        Geometry geom = getGeometry(centerGeom);
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        center = transform3D.Transform(GetCentre(geometry));
                    }

                    switch (e.Key)
                    {
                        case Key.X:
                            lookDirection = new Vector3D(mult, 0, 0);
                            position = new Point3D(center.X - keyDist * mult, center.Y, center.Z);
                            upDirection = new Vector3D(0, 1, 0);
                            ResetCamera(viewport3D.Name, position.X, position.Y, position.Z, lookDirection.X, lookDirection.Y, lookDirection.Z, upDirection.X, upDirection.Y, upDirection.Z);
                            panRight = 0;
                            panUp = 0;
                            break;
                        case Key.Y:
                            lookDirection = new Vector3D(0, mult, 0);
                            position = new Point3D(center.X, center.Y - keyDist * mult, center.Z);
                            upDirection = new Vector3D(0, 0, 1);
                            ResetCamera(viewport3D.Name, position.X, position.Y, position.Z, lookDirection.X, lookDirection.Y, lookDirection.Z, upDirection.X, upDirection.Y, upDirection.Z);
                            panRight = 0;
                            panUp = 0;
                            break;
                        case Key.Z:
                            lookDirection = new Vector3D(0, 0, mult);
                            position = new Point3D(center.X, center.Y, center.Z - keyDist * mult);
                            upDirection = new Vector3D(0, 1, 0);
                            ResetCamera(viewport3D.Name, position.X, position.Y, position.Z, lookDirection.X, lookDirection.Y, lookDirection.Z, upDirection.X, upDirection.Y, upDirection.Z);
                            panRight = 0;
                            panUp = 0;
                            break;
                    }
                }
            }
        }

        private static void _MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lock (lockObj)
            {
                foreach (Viewport3D viewport3D in views)
                {
                    if (!_objectsMap.ContainsKey(viewport3D.Name))
                    {
                        views.Remove(viewport3D);
                        continue;
                    }

                    ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;
                    Vector3D lookDirection = camera.LookDirection;
                    Vector3D upDirection = camera.UpDirection;
                    Point3D position = camera.Position;

                    if (e.LeftButton == MouseButtonState.Pressed)
                    {
                        Primitive hit = HitTest(viewport3D.Name, GraphicsWindow.MouseX, GraphicsWindow.MouseY);
                        if (hit == "") return;
                        centerGeom = hit[1];

                        Geometry geom = getGeometry(centerGeom);
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Point3D center = transform3D.Transform(GetCentre(geometry));
                        panRight = 0;
                        panUp = 0;

                        lookDirection = center - position;
                        lookDirection.Normalize();
                    }
                    if (e.RightButton == MouseButtonState.Pressed)
                    {
                        upDirection = new Vector3D(0, 1, 0);
                    }

                    Vector3D screenDirection = Vector3D.CrossProduct(lookDirection, upDirection);
                    screenDirection.Normalize();
                    upDirection = Vector3D.CrossProduct(screenDirection, lookDirection);

                    ResetCamera(viewport3D.Name, position.X, position.Y, position.Z, lookDirection.X, lookDirection.Y, lookDirection.Z, upDirection.X, upDirection.Y, upDirection.Z);
                }
            }
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            lock (lockObj)
            {
                if (keyDist < 0) return;

                if (autoMode == 0)
                {
                    double move = 0;
                    if (Keyboard.IsKeyDown(Key.S) || Keyboard.IsKeyDown(Key.Down)) move -= 0.1 * speedMult;
                    if (Keyboard.IsKeyDown(Key.W) || Keyboard.IsKeyDown(Key.Up)) move += 0.1 * speedMult;
                    double yaw = 0;
                    if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left)) yaw -= 3;
                    if (Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right)) yaw += 3;

                    if (move == 0 && yaw == 0) return;

                    foreach (Viewport3D viewport3D in views)
                    {
                        if (!_objectsMap.ContainsKey(viewport3D.Name))
                        {
                            views.Remove(viewport3D);
                            continue;
                        }
                        if (bShift && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))) move *= 5;
                        if (bShift && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))) move /= 5;
                        MoveCamera(viewport3D.Name, yaw, 0, 0, move);
                    }
                }
                else if (autoMode == 1)
                {
                    double scale = 1;
                    if (bShift && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))) scale = 5.0;
                    else if (bShift && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))) scale = 1.0/5.0;

                    double right = 0;
                    if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left)) right += 0.1 * speedMult * scale;
                    if (Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right)) right -= 0.1 * speedMult * scale;
                    double up = 0;
                    if (Keyboard.IsKeyDown(Key.S) || Keyboard.IsKeyDown(Key.Down)) up += 0.1 * speedMult * scale;
                    if (Keyboard.IsKeyDown(Key.W) || Keyboard.IsKeyDown(Key.Up)) up -= 0.1 * speedMult * scale;

                    if (right == 0 && up == 0) return;
                    panRight += right;
                    panUp += up;

                    foreach (Viewport3D viewport3D in views)
                    {
                        if (!_objectsMap.ContainsKey(viewport3D.Name))
                        {
                            views.Remove(viewport3D);
                            continue;
                        }
                        ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;
                        Vector3D screenDirection = Vector3D.CrossProduct(camera.LookDirection, camera.UpDirection);
                        Vector3D move = right * screenDirection + up * camera.UpDirection;
                        camera.Position += move;
                    }
                }
            }
        }

        private class Delegates
        {
            object[] data;

            public Delegates(object[] data)
            {
                this.data = data;
            }

            public void MoveCamera_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    double yaw = (double)data[i++];
                    double pitch = (double)data[i++];
                    double roll = (double)data[i++];
                    double move = (double)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Viewport3D viewport3D = (Viewport3D)obj;
                        ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;
                        Vector3D lookDirection = camera.LookDirection;
                        Vector3D upDirection = camera.UpDirection;
                        Point3D position = camera.Position;

                        Vector3D rotateAbout1 = upDirection;
                        Vector3D rotateAbout2 = Vector3D.CrossProduct(rotateAbout1, lookDirection);

                        Matrix3D rotateMatrix = Matrix3D.Identity;
                        Quaternion quaterion = new Quaternion(upDirection, -yaw);
                        rotateMatrix.Rotate(quaterion);
                        quaterion = new Quaternion(rotateAbout2, -pitch);
                        rotateMatrix.Rotate(quaterion);
                        lookDirection = rotateMatrix.Transform(lookDirection);
                        lookDirection.Normalize();
                        position += move * lookDirection;

                        //Also rotate up direction
                        rotateMatrix = Matrix3D.Identity;
                        quaterion = new Quaternion(rotateAbout2, -pitch);
                        rotateMatrix.Rotate(quaterion);
                        quaterion = new Quaternion(lookDirection, roll);
                        rotateMatrix.Rotate(quaterion);
                        upDirection = rotateMatrix.Transform(upDirection);
                        upDirection.Normalize();

                        lookDirection.Normalize();
                        Vector3D screenDirection = Vector3D.CrossProduct(lookDirection, upDirection);
                        screenDirection.Normalize();
                        upDirection = Vector3D.CrossProduct(screenDirection, lookDirection);

                        camera.LookDirection = lookDirection;
                        camera.UpDirection = upDirection;
                        camera.Position = position;

                        UpdateBillBoards(viewport3D, shapeName);

                        if (centerGeom != "")
                        {
                            Geometry geom = getGeometry(centerGeom);
                            GeometryModel3D geometry = geom.geometryModel3D;
                            Transform3D transform3D = (Transform3D)geometry.Transform;
                            Point3D centerMove = transform3D.Transform(GetCentre(geometry));

                            panRight = Vector3D.DotProduct(screenDirection, position - centerMove);
                            panUp = Vector3D.DotProduct(upDirection, position - centerMove);
                        }
                        else
                        {
                            panRight = 0;
                            panUp = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void ResetCamera_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    double xDir = (double)data[i++];
                    double yDir = (double)data[i++];
                    double zDir = (double)data[i++];
                    double xPos = (double)data[i++];
                    double yPos = (double)data[i++];
                    double zPos = (double)data[i++];
                    Primitive xUp = (Primitive)data[i++];
                    Primitive yUp = (Primitive)data[i++];
                    Primitive zUp = (Primitive)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Viewport3D viewport3D = (Viewport3D)obj;
                        ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;

                        camera.LookDirection = new Vector3D(xDir, yDir, zDir);
                        camera.Position = new Point3D(xPos, yPos, zPos);
                        if (xUp == "" || yUp == "" || zUp == "")
                        {
                            camera.UpDirection = (xDir == 0 && zDir == 0) ? new Vector3D(0, 0, -1) : new Vector3D(0, 1, 0);
                            Vector3D rotateAbout = Vector3D.CrossProduct(camera.LookDirection, camera.UpDirection);
                            camera.UpDirection = Vector3D.CrossProduct(rotateAbout, camera.LookDirection);
                        }
                        else
                        {
                            camera.UpDirection = new Vector3D(xUp, yUp, zUp);
                        }

                        camera.LookDirection.Normalize();
                        camera.UpDirection.Normalize();
                        Vector3D screenDirection = Vector3D.CrossProduct(camera.LookDirection, camera.UpDirection);
                        camera.UpDirection = Vector3D.CrossProduct(screenDirection, camera.LookDirection);

                        UpdateBillBoards(viewport3D, shapeName);
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void RotateGeometry_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    string geometryName = (string)data[i++];
                    double x = (double)data[i++];
                    double y = (double)data[i++];
                    double z = (double)data[i++];
                    double angle = (double)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate1];
                        AxisAngleRotation3D axisAngleRotation3D = new AxisAngleRotation3D();
                        axisAngleRotation3D.Axis = new Vector3D(x, y, z);
                        axisAngleRotation3D.Angle = angle;
                        rotateTransform3D.Rotation = axisAngleRotation3D;

                        geometry.Transform = transform3DGroup;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void RotateGeometry2_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    string geometryName = (string)data[i++];
                    double x = (double)data[i++];
                    double y = (double)data[i++];
                    double z = (double)data[i++];
                    double angle = (double)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate2];
                        AxisAngleRotation3D axisAngleRotation3D = new AxisAngleRotation3D();
                        axisAngleRotation3D.Axis = new Vector3D(x, y, z);
                        axisAngleRotation3D.Angle = angle;
                        rotateTransform3D.Rotation = axisAngleRotation3D;

                        geometry.Transform = transform3DGroup;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void RotateGeometry3_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    string geometryName = (string)data[i++];
                    double x = (double)data[i++];
                    double y = (double)data[i++];
                    double z = (double)data[i++];
                    double angle = (double)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate3];
                        AxisAngleRotation3D axisAngleRotation3D = new AxisAngleRotation3D();
                        axisAngleRotation3D.Axis = new Vector3D(x, y, z);
                        axisAngleRotation3D.Angle = angle;
                        rotateTransform3D.Rotation = axisAngleRotation3D;

                        geometry.Transform = transform3DGroup;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void ScaleGeometry_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    string geometryName = (string)data[i++];
                    double scaleX = (double)data[i++];
                    double scaleY = (double)data[i++];
                    double scaleZ = (double)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        ScaleTransform3D scaleTransform3D = (ScaleTransform3D)transform3DGroup.Children[(int)transform.Scale];
                        scaleTransform3D.ScaleX = scaleX;
                        scaleTransform3D.ScaleY = scaleY;
                        scaleTransform3D.ScaleZ = scaleZ;

                        geometry.Transform = transform3DGroup;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void TranslateGeometry_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    string geometryName = (string)data[i++];
                    double dx = (double)data[i++];
                    double dy = (double)data[i++];
                    double dz = (double)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        TranslateTransform3D translateTransform3D = (TranslateTransform3D)transform3DGroup.Children[(int)transform.Translate];
                        translateTransform3D.OffsetX = dx;
                        translateTransform3D.OffsetY = dy;
                        translateTransform3D.OffsetZ = dz;

                        geometry.Transform = transform3DGroup;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void ModifyObject_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    string geometryName = (string)data[i++];
                    string action = (string)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Viewport3D viewport3D = (Viewport3D)obj;
                        ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                        Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                        Geometry geom = getGeometry(geometryName);
                        Lighting lighting = getLighting(geometryName);
                        if (null != geom)
                        {
                            switch (action.ToLower())
                            {
                                case "x":
                                    model3DGroup.Children.Remove(geom.geometryModel3D);
                                    Geometries.Remove(geom);
                                    break;
                                case "h":
                                    model3DGroup.Children.Remove(geom.geometryModel3D);
                                    break;
                                case "s":
                                    if (!model3DGroup.Children.Contains(geom.geometryModel3D)) model3DGroup.Children.Add(geom.geometryModel3D);
                                    break;
                            }
                        }
                        else if (null != lighting)
                        {
                            switch (action.ToLower())
                            {
                                case "x":
                                    model3DGroup.Children.Remove(lighting.light);
                                    Lightings.Remove(lighting);
                                    break;
                                case "h":
                                    model3DGroup.Children.Remove(lighting.light);
                                    break;
                                case "s":
                                    if (!model3DGroup.Children.Contains(lighting.light)) model3DGroup.Children.Add(lighting.light);
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void Freeze_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    string geometryName = (string)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Viewport3D viewport3D = (Viewport3D)obj;
                        ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                        Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                        Geometry geom = getGeometry(geometryName);
                        geom.geometryModel3D.Freeze();
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void SetCentre_Delegate()
            {
                try
                {
                    int i = 0;
                    string shapeName = (string)data[i++];
                    string geometryName = (string)data[i++];
                    Primitive x = (Primitive)data[i++];
                    Primitive y = (Primitive)data[i++];
                    Primitive z = (Primitive)data[i++];
                    string options = (string)data[i++];
                    UIElement obj = (UIElement)data[i++];

                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate1];
                        RotateTransform3D rotateTransform3D2 = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate2];
                        RotateTransform3D rotateTransform3D3 = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate3];
                        ScaleTransform3D scaleTransform3D = (ScaleTransform3D)transform3DGroup.Children[(int)transform.Scale];

                        Point3D centroid = geometry.Bounds.Location;
                        centroid.X += geometry.Bounds.SizeX / 2.0;
                        centroid.Y += geometry.Bounds.SizeY / 2.0;
                        centroid.Z += geometry.Bounds.SizeZ / 2.0;
                        centroid = transform3D.Inverse.Transform(centroid);

                        string opt = options.ToLower();
                        double X = x == "" ? centroid.X : (double)x;
                        double Y = y == "" ? centroid.Y : (double)y;
                        double Z = z == "" ? centroid.Z : (double)z;

                        if (opt.Contains("r1"))
                        {
                            rotateTransform3D.CenterX = X;
                            rotateTransform3D.CenterY = Y;
                            rotateTransform3D.CenterZ = Z;
                        }
                        if (opt.Contains("r2"))
                        {
                            rotateTransform3D2.CenterX = X;
                            rotateTransform3D2.CenterY = Y;
                            rotateTransform3D2.CenterZ = Z;
                        }
                        if (opt.Contains("r3"))
                        {
                            rotateTransform3D3.CenterX = X;
                            rotateTransform3D3.CenterY = Y;
                            rotateTransform3D3.CenterZ = Z;
                        }
                        if (opt.Contains("s"))
                        {
                            scaleTransform3D.CenterX = X;
                            scaleTransform3D.CenterY = Y;
                            scaleTransform3D.CenterZ = Z;
                        }

                        geometry.Transform = transform3DGroup;
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void ResetMaterial_Delegate()
            {
                int i = 0;
                string shapeName = (string)data[i++];
                string geometryName = (string)data[i++];
                Primitive colour = (Primitive)data[i++];
                Primitive materialType = (Primitive)data[i++];
                UIElement obj = (UIElement)data[i++];

                try
                {
                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;

                        MaterialGroup material = new MaterialGroup();
                        Brush brush = null;
                        foreach (GradientBrush iBrush in LDShapes.brushes)
                        {
                            if (iBrush.name == colour)
                            {
                                brush = iBrush.getBrush();
                            }
                        }
                        if (null == brush) brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                        switch (materialType.ToString().ToLower())
                        {
                            case "e":
                                material.Children.Add(new DiffuseMaterial(brush));
                                material.Children.Add(new EmissiveMaterial(brush));
                                geometry.Material = material;
                                break;
                            case "d":
                                material.Children.Add(new DiffuseMaterial(brush));
                                geometry.Material = material;
                                break;
                            case "s":
                                material.Children.Add(new SpecularMaterial(brush, specular));
                                geometry.Material = material;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void SetBackMaterial_Delegate()
            {
                int i = 0;
                string shapeName = (string)data[i++];
                string geometryName = (string)data[i++];
                Primitive colour = (Primitive)data[i++];
                Primitive materialType = (Primitive)data[i++];
                UIElement obj = (UIElement)data[i++];

                try
                {
                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;

                        MaterialGroup material = new MaterialGroup();
                        Brush brush = null;
                        foreach (GradientBrush iBrush in LDShapes.brushes)
                        {
                            if (iBrush.name == colour)
                            {
                                brush = iBrush.getBrush();
                            }
                        }
                        if (null == brush) brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                        switch (materialType.ToString().ToLower())
                        {
                            case "e":
                                material.Children.Add(new DiffuseMaterial(brush));
                                material.Children.Add(new EmissiveMaterial(brush));
                                geometry.BackMaterial = material;
                                break;
                            case "d":
                                material.Children.Add(new DiffuseMaterial(brush));
                                geometry.BackMaterial = material;
                                break;
                            case "s":
                                material.Children.Add(new SpecularMaterial(brush, specular));
                                geometry.BackMaterial = material;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void AnimateRotation_Delegate()
            {
                int i = 0;
                string shapeName = (string)data[i++];
                string geometryName = (string)data[i++];
                Primitive xDir = (Primitive)data[i++];
                Primitive yDir = (Primitive)data[i++];
                Primitive zDir = (Primitive)data[i++];
                Primitive startAngle = (Primitive)data[i++];
                Primitive endAngle = (Primitive)data[i++];
                Primitive duration = (Primitive)data[i++];
                Primitive repeats = (Primitive)data[i++];
                UIElement obj = (UIElement)data[i++];

                try
                {
                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate2];
                        AxisAngleRotation3D axisAngleRotation3D = (AxisAngleRotation3D)rotateTransform3D.Rotation;

                        DoubleAnimation doubleAnimaton = new DoubleAnimation();
                        doubleAnimaton.Duration = new Duration(new TimeSpan(duration * 10000000));
                        doubleAnimaton.RepeatBehavior = (repeats > 0) ? new RepeatBehavior(repeats) : RepeatBehavior.Forever;
                        doubleAnimaton.From = startAngle;
                        doubleAnimaton.To = endAngle;
                        doubleAnimaton.Completed += (s, _) => _RotationCompletedEvent(geom);
                        axisAngleRotation3D.Axis = new Vector3D(xDir, yDir, zDir);
                        axisAngleRotation3D.BeginAnimation(AxisAngleRotation3D.AngleProperty, doubleAnimaton);
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void AnimateRotation2_Delegate()
            {
                int i = 0;
                string shapeName = (string)data[i++];
                string geometryName = (string)data[i++];
                Primitive xDir = (Primitive)data[i++];
                Primitive yDir = (Primitive)data[i++];
                Primitive zDir = (Primitive)data[i++];
                Primitive startAngle = (Primitive)data[i++];
                Primitive endAngle = (Primitive)data[i++];
                Primitive duration = (Primitive)data[i++];
                Primitive repeats = (Primitive)data[i++];
                UIElement obj = (UIElement)data[i++];

                try
                {
                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate3];
                        AxisAngleRotation3D axisAngleRotation3D = (AxisAngleRotation3D)rotateTransform3D.Rotation;

                        DoubleAnimation doubleAnimaton = new DoubleAnimation();
                        doubleAnimaton.Duration = new Duration(new TimeSpan(duration * 10000000));
                        doubleAnimaton.RepeatBehavior = (repeats > 0) ? new RepeatBehavior(repeats) : RepeatBehavior.Forever;
                        doubleAnimaton.From = startAngle;
                        doubleAnimaton.To = endAngle;
                        doubleAnimaton.Completed += (s, _) => _RotationCompletedEvent(geom);
                        axisAngleRotation3D.Axis = new Vector3D(xDir, yDir, zDir);
                        axisAngleRotation3D.BeginAnimation(AxisAngleRotation3D.AngleProperty, doubleAnimaton);
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }

            public void AnimateTranslation_Delegate()
            {
                int i = 0;
                string shapeName = (string)data[i++];
                string geometryName = (string)data[i++];
                Primitive x = (Primitive)data[i++];
                Primitive y = (Primitive)data[i++];
                Primitive z = (Primitive)data[i++];
                Primitive duration = (Primitive)data[i++];
                UIElement obj = (UIElement)data[i++];

                try
                {
                    if (obj.GetType() == typeof(Viewport3D))
                    {
                        Geometry geom = getGeometry(geometryName);
                        if (null == geom) return;
                        GeometryModel3D geometry = geom.geometryModel3D;
                        Transform3D transform3D = (Transform3D)geometry.Transform;
                        Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                        TranslateTransform3D translateTransform3D = (TranslateTransform3D)transform3DGroup.Children[(int)transform.Translate];

                        DoubleAnimation doubleAnimationX = new DoubleAnimation();
                        doubleAnimationX.Duration = new Duration(new TimeSpan(duration * 10000000));
                        doubleAnimationX.From = translateTransform3D.OffsetX;
                        doubleAnimationX.To = x;

                        DoubleAnimation doubleAnimationY = new DoubleAnimation();
                        doubleAnimationY.Duration = new Duration(new TimeSpan(duration * 10000000));
                        doubleAnimationY.From = translateTransform3D.OffsetY;
                        doubleAnimationY.To = y;

                        DoubleAnimation doubleAnimationZ = new DoubleAnimation();
                        doubleAnimationZ.Duration = new Duration(new TimeSpan(duration * 10000000));
                        doubleAnimationZ.From = translateTransform3D.OffsetZ;
                        doubleAnimationZ.To = z;

                        doubleAnimationX.Completed += (s, _) => _TranslationCompletedEvent(geom);

                        translateTransform3D.BeginAnimation(TranslateTransform3D.OffsetXProperty, doubleAnimationX);
                        translateTransform3D.BeginAnimation(TranslateTransform3D.OffsetYProperty, doubleAnimationY);
                        translateTransform3D.BeginAnimation(TranslateTransform3D.OffsetZProperty, doubleAnimationZ);
                    }
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        /// <summary>
        /// Get or set the specular exponent used for specular materials (default 5).
        /// </summary>
        public static Primitive SpecularExponent
        {
            get { return specular; }
            set { specular = value; }
        }

        /// <summary>
        /// Add a 3DView (GraphicsWindow shape).
        /// </summary>
        /// <param name="width">The width of the 3DView.</param>
        /// <param name="height">The height of the 3DView.</param>
        /// <param name="performance">
        /// A flag to favour speed over quality "True" or "False".
        /// "True" removes visual clipping (clip 3DView to input width and height), hit-testing (unused) and anti-aliasing (not needed).
        /// </param>
        /// <returns>The 3DView viewport3D name.</returns>
        public static Primitive AddView(Primitive width, Primitive height, Primitive performance)
        {
            GraphicsWindow.Show();
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
#if SVB
                shapeName = method.Invoke(null, new object[] { "View3D", false }).ToString();
#else
                shapeName = method.Invoke(null, new object[] { "View3D" }).ToString();
#endif

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Viewport3D viewport3D = new Viewport3D();
                        //viewport3D.Cursor = Cursors.Cross;
                        viewport3D.Name = shapeName;
                        viewport3D.Width = width;
                        viewport3D.Height = height;
                        if (performance)
                        {
                            viewport3D.IsHitTestVisible = false;
                            viewport3D.ClipToBounds = false;
                            RenderOptions.SetEdgeMode((DependencyObject)viewport3D, EdgeMode.Aliased);
                        }

                        PerspectiveCamera camera = new PerspectiveCamera();
                        camera.Position = new Point3D(0, 0, 10);
                        camera.LookDirection = new Vector3D(0, 0, -1);
                        camera.FieldOfView = 60;
                        viewport3D.Camera = camera;

                        ModelVisual3D modelVisual3D = new ModelVisual3D();
                        viewport3D.Children.Add(modelVisual3D);

                        Model3DGroup model3DGroup = new Model3DGroup();
                        modelVisual3D.Content = model3DGroup;

                        _objectsMap[shapeName] = viewport3D;
                        _mainCanvas.Children.Add(viewport3D);
                        views.Add(viewport3D);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
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
        /// Set auto control of the camera.
        /// This mode is a general purpose camera control, mainly for moving within a scene (a flyby mode).
        /// Move forwards and backwards with mouse wheel (faster with Shift down, slower with Control down).
        /// Yaw and Pitch camera moving with left mouse button.
        /// Yaw with A,D or Left,Right keys, move forwards and backwards with W,S or Up,Down keys.
        /// Roll camera moving with right mouse button.
        /// Double left click an object to center it (Centre of rotation).
        /// Double right click to reset the up direction to Y.
        /// Yaw and Pitch scene moving with Shift and left mouse button after selecting an object to rotate scene about.
        /// X, Y, Z keys change the view direction and up direction to face in these directions towards (0,0,0), with Shift then the negative direction.
        /// </summary>
        /// <param name="pitchRoll">Allow pitch and roll movement, "True" or "False".</param>
        /// <param name="shift">Allow the Shift/Control key modifiers for mouse control, "True" or "False".</param>
        /// <param name="keyDistance">The distance to view the scene from using keys, (0 prevents the X,Y,Z key shortcuts, -1 also prevents the A,D,W,S and arrow keys).</param>
        /// <param name="speed">Forwards and backwards speed multiplier (default 1).</param>
        public static void AutoControl(Primitive pitchRoll, Primitive shift, Primitive keyDistance, Primitive speed)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Window _window;

            try
            {
                _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        autoMode = 0;
                        bPitchRoll = pitchRoll;
                        bShift = shift;
                        keyDist = keyDistance;
                        speedMult = speed;
                        if (lastPos == new Point(-1, -1))
                        {
                            _window.MouseMove += new MouseEventHandler(_MouseMove);
                            _window.MouseWheel += new MouseWheelEventHandler(_MouseWheel);
                            _window.MouseDoubleClick += new MouseButtonEventHandler(_MouseDoubleClick);
                            _window.KeyDown += new KeyEventHandler(_KeyDown);

                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            timer.Enabled = true;
                            timer.Interval = 20;
                            timer.Tick += new EventHandler(timer_Tick);
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set auto control of the camera.
        /// This mode is mainly to rotate and view a 3D scene rather than move through the scene (an inspection mode).
        /// Zoom in or out with mouse wheel (faster with Shift down, slower with Control down).
        /// Pan left/right with A,D or Left,Right keys, pan up/down with W,S or Up,Down keys.
        /// Double left click an object to center it (Centre of rotation).
        /// Double right click to reset the up direction to Y.
        /// Yaw and Pitch scene moving with left mouse button after selecting an object to rotate scene about.
        /// Roll scene moving with right mouse button.
        /// X, Y, Z keys change the view direction and up direction to face in these directions towards selected center, with Shift then the negative direction.
        /// </summary>
        /// <param name="keyDistance">The distance to view the scene from using keys, (0 prevents the X,Y,Z key shortcuts).</param>
        /// <param name="speed">Forwards and backwards speed multiplier (default 1).</param>
        public static void AutoControl2(Primitive keyDistance, Primitive speed)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Window _window;

            try
            {
                _window = (Window)GraphicsWindowType.GetField("_window", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelper ret = new InvokeHelper(delegate
                {
                    try
                    {
                        autoMode = 1;
                        bPitchRoll = true;
                        bShift = true;
                        keyDist = keyDistance;
                        speedMult = speed;
                        if (lastPos == new Point(-1, -1))
                        {
                            _window.MouseMove += new MouseEventHandler(_MouseMove);
                            _window.MouseWheel += new MouseWheelEventHandler(_MouseWheel);
                            _window.MouseDoubleClick += new MouseButtonEventHandler(_MouseDoubleClick);
                            _window.KeyDown += new KeyEventHandler(_KeyDown);

                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            timer.Enabled = true;
                            timer.Interval = 20;
                            timer.Tick += new EventHandler(timer_Tick);
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                });
                FastThread.Invoke(ret);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Add a geometry object.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="points">A space or colon deliminated list of point coordinates.</param>
        /// <param name="indices">A space or colon deliminated list of indices for each triangle (counter-clockwise for outward face).</param>
        /// <param name="normals">An optional space or colon deliminated list of the outward normals for each node or "".</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddGeometry(Primitive shapeName, Primitive points, Primitive indices, Primitive normals, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                string[] s;
                                int i;

                                // Create a collection of vertex positions for the MeshGeometry3D. 
                                Point3DCollection pointCollection = new Point3DCollection();
                                s = Utilities.getString(points).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i += 3)
                                {
                                    pointCollection.Add(new Point3D(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1]), Utilities.getDouble(s[i + 2])));
                                }

                                // Create a collection of triangle indices for the MeshGeometry3D.
                                Int32Collection indexCollection = new Int32Collection();
                                s = Utilities.getString(indices).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i++)
                                {
                                    indexCollection.Add(Utilities.getInt(s[i]));
                                }

                                // Create a collection of normal vectors for the MeshGeometry3D.
                                Vector3DCollection normalCollection = new Vector3DCollection();
                                s = Utilities.getString(normals).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i += 3)
                                {
                                    normalCollection.Add(new Vector3D(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1]), Utilities.getDouble(s[i + 2])));
                                }

                                // Create a collection of texture coordinates for the MeshGeometry3D.
                                PointCollection textureCollection = new PointCollection();
                                //s = Utilities.getString(textures).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                //for (i = 0; i < s.Length; i += 2)
                                //{
                                //    textureCollection.Add(new Point(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1])));
                                //}

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, pointCollection, indexCollection, normalCollection, textureCollection, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add an image to a geometry object.
        /// A geometry 'skin' may contain several segment images in one image.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="textures">A space or colon deliminated list of the texture coordinates for each node.
        /// Each node has 2 values between 0 and 1 indicating the x,y image mapping to the node.
        /// The may be defaulted to "" if the texture has previously been set.</param>
        /// <param name="imageName">
        /// The image to load to the geometry.
        /// Value returned from ImageList.LoadImage or local or network image file.
        /// A colour or gradient brush can also be used here.
        /// </param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular - additional specular highlights.</param>
        public static void AddImage(Primitive shapeName, Primitive geometryName, Primitive textures, Primitive imageName, Primitive materialType)
        {
            UIElement obj;
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                MeshGeometry3D mesh = (MeshGeometry3D)geometry.Geometry;
                                MaterialGroup material = (MaterialGroup)geometry.Material;

                                string[] s;
                                int i;

                                // Create a collection of texture coordinates for the MeshGeometry3D.
                                PointCollection textureCollection = new PointCollection();
                                s = Utilities.getString(textures).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i += 2)
                                {
                                    textureCollection.Add(new Point(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1])));
                                }
                                if (textureCollection.Count == mesh.Positions.Count) mesh.TextureCoordinates = textureCollection;

                                Brush brush = null;
                                foreach (GradientBrush iBrush in LDShapes.brushes)
                                {
                                    if (iBrush.name == imageName)
                                    {
                                        brush = iBrush.getBrush();
                                    }
                                }
                                if (null == brush)
                                {
                                    try
                                    {
                                        brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(imageName));
                                    }
                                    catch
                                    {
                                        _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                                        if (!_savedImages.TryGetValue((string)imageName, out img))
                                        {
                                            imageName = ImageList.LoadImage(imageName);
                                            if (!_savedImages.TryGetValue((string)imageName, out img))
                                            {
                                                return;
                                            }
                                        }
                                        brush = new ImageBrush(img);
                                    }
                                }

                                switch (materialType.ToString().ToLower())
                                {
                                    case "e":
                                        material.Children.Add(new EmissiveMaterial(brush));
                                        break;
                                    case "d":
                                        material.Children.Add(new DiffuseMaterial(brush));
                                        break;
                                    case "s":
                                        material.Children.Add(new SpecularMaterial(brush, specular));
                                        break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return;
                    });
                    FastThread.Invoke(ret);
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
        /// Add an image to a back surface of geometry object.
        /// A geometry 'skin' may contain several segment images in one image.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="textures">A space or colon deliminated list of the texture coordinates for each node.
        /// Each node has 2 values between 0 and 1 indicating the x,y image mapping to the node.
        /// The may be defaulted to "" if the texture has previously been set.</param>
        /// <param name="imageName">
        /// The image to load to the geometry.
        /// Value returned from ImageList.LoadImage or local or network image file.
        /// A colour or gradient brush can also be used here.
        /// </param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular - additional specular highlights.</param>
        public static void AddBackImage(Primitive shapeName, Primitive geometryName, Primitive textures, Primitive imageName, Primitive materialType)
        {
            UIElement obj;
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                MeshGeometry3D mesh = (MeshGeometry3D)geometry.Geometry;
                                MaterialGroup material = (MaterialGroup)geometry.BackMaterial;
                                if (null == material) material = new MaterialGroup();

                                string[] s;
                                int i;

                                // Create a collection of texture coordinates for the MeshGeometry3D.
                                PointCollection textureCollection = new PointCollection();
                                s = Utilities.getString(textures).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i += 2)
                                {
                                    textureCollection.Add(new Point(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1])));
                                }
                                if (textureCollection.Count == mesh.Positions.Count) mesh.TextureCoordinates = textureCollection;

                                Brush brush = null;
                                foreach (GradientBrush iBrush in LDShapes.brushes)
                                {
                                    if (iBrush.name == imageName)
                                    {
                                        brush = iBrush.getBrush();
                                    }
                                }
                                if (null == brush)
                                {
                                    try
                                    {
                                        brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(imageName));
                                    }
                                    catch
                                    {
                                        _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                                        if (!_savedImages.TryGetValue((string)imageName, out img))
                                        {
                                            imageName = ImageList.LoadImage(imageName);
                                            if (!_savedImages.TryGetValue((string)imageName, out img))
                                            {
                                                return;
                                            }
                                        }
                                        brush = new ImageBrush(img);
                                    }
                                }

                                switch (materialType.ToString().ToLower())
                                {
                                    case "e":
                                        material.Children.Add(new EmissiveMaterial(brush));
                                        break;
                                    case "d":
                                        material.Children.Add(new DiffuseMaterial(brush));
                                        break;
                                    case "s":
                                        material.Children.Add(new SpecularMaterial(brush, specular));
                                        break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return;
                    });
                    FastThread.Invoke(ret);
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
        /// Move the camera view direction and position.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="yaw">The Left/Right rotation in degrees (Yaw).</param>
        /// <param name="pitch">The Up/Down rotation in degrees (Pitch).</param>
        /// <param name="roll">Spin view about view direction in degrees (Roll).</param>
        /// <param name="move">The Forward/Backward movement in device coordinates (along the view direction).</param>
        public static void MoveCamera(Primitive shapeName, Primitive yaw, Primitive pitch, Primitive roll, Primitive move)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue(shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (double)yaw, (double)pitch, (double)roll, (double)move, obj });
                    FastThread.BeginInvoke(delegates.MoveCamera_Delegate);
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
        /// Reset the camera position, view direction and up vector (optional).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="xPos">The x position of the camera.</param>
        /// <param name="yPos">The y position of the camera.</param>
        /// <param name="zPos">The z position of the camera.</param>
        /// <param name="xDir">The x direction of the camera.</param>
        /// <param name="yDir">The y direction of the camera.</param>
        /// <param name="zDir">The z direction of the camera.</param>
        /// <param name="xUp">The optional x up direction of the camera or "".</param>
        /// <param name="yUp">The optional y up direction of the camera or "".</param>
        /// <param name="zUp">The optional z up direction of the camera or "".</param>
        public static void ResetCamera(Primitive shapeName, Primitive xPos, Primitive yPos, Primitive zPos, Primitive xDir, Primitive yDir, Primitive zDir, Primitive xUp, Primitive yUp, Primitive zUp)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (double)xDir, (double)yDir, (double)zDir, (double)xPos, (double)yPos, (double)zPos, xUp, yUp, zUp, obj });
                    FastThread.BeginInvoke(delegates.ResetCamera_Delegate);
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
        /// Set the angle of view, near and far clipping distances.
        /// These are all of the fundamental perspective camera properties.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="nearDistance">The near clipping distance (can improve near object e.g. wall hit detection).
        /// A negative value is 0.001 (default is 0.125).</param>
        /// <param name="farDistance">The far clipping distance (can improve performance).
        /// A negative value is infinity (default).</param>
        /// <param name="angle">The view angle cone of the camera in degrees (affects perspective vanishing point).
        /// If this is negative, then an Orthographic (no perspective) camera is used with view width set to -angle). </param>
        public static void CameraProperties(Primitive shapeName, Primitive nearDistance, Primitive farDistance, Primitive angle)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ProjectionCamera cameraOld = (ProjectionCamera)viewport3D.Camera;

                                if (angle > 0)
                                {
                                    PerspectiveCamera camera = new PerspectiveCamera(cameraOld.Position, cameraOld.LookDirection, cameraOld.UpDirection, angle);
                                    camera.NearPlaneDistance = System.Math.Max(1.0e-3, nearDistance);
                                    camera.FarPlaneDistance = (farDistance < camera.NearPlaneDistance) ? double.PositiveInfinity : (double)farDistance;
                                    viewport3D.Camera = camera;
                                }
                                else
                                {
                                    OrthographicCamera camera = new OrthographicCamera(cameraOld.Position, cameraOld.LookDirection, cameraOld.UpDirection, -angle);
                                    camera.NearPlaneDistance = System.Math.Max(1.0e-3, nearDistance);
                                    camera.FarPlaneDistance = (farDistance < camera.NearPlaneDistance) ? double.PositiveInfinity : (double)farDistance;
                                    viewport3D.Camera = camera;
                                }

                                UpdateBillBoards(viewport3D, shapeName);
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
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get the camera position.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <returns>An array of the camera position coordinates.</returns>
        public static Primitive GetCameraPosition(Primitive shapeName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;

                                string position = "1=" + Utilities.ArrayParse(camera.Position.X.ToString(CultureInfo.InvariantCulture)) + ";" + "2=" + Utilities.ArrayParse(camera.Position.Y.ToString(CultureInfo.InvariantCulture)) + ";" + "3=" + Utilities.ArrayParse(camera.Position.Z.ToString(CultureInfo.InvariantCulture)) + ";";
                                return position;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Get the camera direction.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <returns>An array of the camera direction vector.</returns>
        public static Primitive GetCameraDirection(Primitive shapeName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;

                                string direction = "1=" + Utilities.ArrayParse(camera.LookDirection.X.ToString(CultureInfo.InvariantCulture)) + ";" + "2=" + Utilities.ArrayParse(camera.LookDirection.Y.ToString(CultureInfo.InvariantCulture)) + ";" + "3=" + Utilities.ArrayParse(camera.LookDirection.Z.ToString(CultureInfo.InvariantCulture)) + ";";
                                return direction;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Get the camera up direction.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <returns>An array of the camera up direction vector.</returns>
        public static Primitive GetCameraUpDirection(Primitive shapeName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;

                                string direction = "1=" + Utilities.ArrayParse(camera.UpDirection.X.ToString(CultureInfo.InvariantCulture)) + ";" + "2=" + Utilities.ArrayParse(camera.UpDirection.Y.ToString(CultureInfo.InvariantCulture)) + ";" + "3=" + Utilities.ArrayParse(camera.UpDirection.Z.ToString(CultureInfo.InvariantCulture)) + ";";
                                return direction;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a directional light source.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="colour">The light colour.</param>
        /// <param name="xDir">The x direction of the light.</param>
        /// <param name="yDir">The y direction of the light.</param>
        /// <param name="zDir">The z direction of the light.</param>
        /// <returns>The 3DView Light name.</returns>
        public static Primitive AddDirectionalLight(Primitive shapeName, Primitive colour, Primitive xDir, Primitive yDir, Primitive zDir)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                DirectionalLight directionalLight = new DirectionalLight();
                                directionalLight.Color = (Color)ColorConverter.ConvertFromString(colour);
                                directionalLight.Direction = new Vector3D(xDir, yDir, zDir);

                                string name = getLightingName();
                                Lightings.Add(new Lighting(name, directionalLight));
                                model3DGroup.Children.Add(directionalLight);
                                return name;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add an ambient light source.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="colour">The light colour.</param>
        /// <returns>The 3DView Light name.</returns>
        public static Primitive AddAmbientLight(Primitive shapeName, Primitive colour)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                AmbientLight ambientLight = new AmbientLight();
                                ambientLight.Color = (Color)ColorConverter.ConvertFromString(colour);

                                string name = getLightingName();
                                Lightings.Add(new Lighting(name, ambientLight));
                                model3DGroup.Children.Add(ambientLight);
                                return name;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a directional spot light source.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="colour">The light colour.</param>
        /// <param name="xPos">The x position of the light.</param>
        /// <param name="yPos">The y position of the light.</param>
        /// <param name="zPos">The z position of the light.</param>
        /// <param name="xDir">The x direction of the light.</param>
        /// <param name="yDir">The y direction of the light.</param>
        /// <param name="zDir">The z direction of the light.</param>
        /// <param name="angle">The cone angle the light in degrees.</param>
        /// <param name="range">The light range.</param>
        /// <returns>The 3DView Light name.</returns>
        public static Primitive AddSpotLight(Primitive shapeName, Primitive colour, Primitive xPos, Primitive yPos, Primitive zPos, Primitive xDir, Primitive yDir, Primitive zDir, Primitive angle, Primitive range)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                SpotLight spotLight = new SpotLight();
                                spotLight.Color = (Color)ColorConverter.ConvertFromString(colour);
                                spotLight.Position = new Point3D(xPos, yPos, zPos);
                                spotLight.Direction = new Vector3D(xDir, yDir, zDir);
                                spotLight.InnerConeAngle = angle;
                                spotLight.OuterConeAngle = angle + 10;
                                spotLight.Range = range;
                                //spotLight.ConstantAttenuation = 3;

                                string name = getLightingName();
                                Lightings.Add(new Lighting(name, spotLight));
                                model3DGroup.Children.Add(spotLight);
                                return name;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a non-directional point light source.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="colour">The light colour.</param>
        /// <param name="xPos">The x position of the light.</param>
        /// <param name="yPos">The y position of the light.</param>
        /// <param name="zPos">The z position of the light.</param>
        /// <param name="range">The light range.</param>
        /// <returns>The 3DView Light name.</returns>
        public static Primitive AddPointLight(Primitive shapeName, Primitive colour, Primitive xPos, Primitive yPos, Primitive zPos, Primitive range)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                PointLight pointLight = new PointLight();
                                pointLight.Color = (Color)ColorConverter.ConvertFromString(colour);
                                pointLight.Position = new Point3D(xPos, yPos, zPos);
                                pointLight.Range = range;
                                pointLight.QuadraticAttenuation = 1;

                                string name = getLightingName();
                                Lightings.Add(new Lighting(name, pointLight));
                                model3DGroup.Children.Add(pointLight);
                                return name;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Rotate a geometry object about its centre.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="x">X direction of vector to rotate about.</param>
        /// <param name="y">Y direction of vector to rotate about.</param>
        /// <param name="z">Z direction of vector to rotate about.</param>
        /// <param name="angle">An angle in degrees to rotate.</param>
        public static void RotateGeometry(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive angle)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, (double)x, (double)y, (double)z, (double)angle, obj });
                    FastThread.BeginInvoke(delegates.RotateGeometry_Delegate);
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
        /// Rotate a geometry object about its centre (a second rotation).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="x">X direction of vector to rotate about.</param>
        /// <param name="y">Y direction of vector to rotate about.</param>
        /// <param name="z">Z direction of vector to rotate about.</param>
        /// <param name="angle">An angle in degrees to rotate.</param>
        public static void RotateGeometry2(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive angle)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, (double)x, (double)y, (double)z, (double)angle, obj });
                    FastThread.BeginInvoke(delegates.RotateGeometry2_Delegate);
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
        /// Rotate a geometry object about its centre (a third rotation).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="x">X direction of vector to rotate about.</param>
        /// <param name="y">Y direction of vector to rotate about.</param>
        /// <param name="z">Z direction of vector to rotate about.</param>
        /// <param name="angle">An angle in degrees to rotate.</param>
        public static void RotateGeometry3(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive angle)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, (double)x, (double)y, (double)z, (double)angle, obj });
                    FastThread.BeginInvoke(delegates.RotateGeometry3_Delegate);
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
        /// Scale (zoom) a geometry object about its centre.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="scaleX">X scale factor.</param>
        /// <param name="scaleY">Y scale factor.</param>
        /// <param name="scaleZ">Z scale factor.</param>
        public static void ScaleGeometry(Primitive shapeName, Primitive geometryName, Primitive scaleX, Primitive scaleY, Primitive scaleZ)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, (double)scaleX, (double)scaleY, (double)scaleZ, obj });
                    FastThread.BeginInvoke(delegates.ScaleGeometry_Delegate);
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
        /// Translate (move) a geometry object.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="dx">X direction translation.</param>
        /// <param name="dy">Y direction translation.</param>
        /// <param name="dz">Z direction translation.</param>
        public static void TranslateGeometry(Primitive shapeName, Primitive geometryName, Primitive dx, Primitive dy, Primitive dz)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, (double)dx, (double)dy, (double)dz, obj });
                    FastThread.BeginInvoke(delegates.TranslateGeometry_Delegate);
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
        /// Perform an action on a light or geometry object.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry or light name.</param>
        /// <param name="action">The action to perform.
        /// The allowed actions are:
        /// "X" remove
        /// "H" hide
        /// "S" show
        /// </param>
        public static void ModifyObject(Primitive shapeName, Primitive geometryName, Primitive action)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, (string)action, obj });
                    FastThread.BeginInvoke(delegates.ModifyObject_Delegate);
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
        /// Create a complete copy of a geometry object and all of its properties.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The object to copy's name.</param>
        /// <returns>The new copied 3DView object name.</returns>
        public static Primitive CloneObject(Primitive shapeName, Primitive geometryName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                Geometry geom = getGeometry(geometryName);
                                Lighting lighting = getLighting(geometryName);
                                if (null != geom)
                                {
                                    GeometryModel3D geomClone = geom.geometryModel3D.Clone();
                                    string name = getGeometryName();
                                    Geometries.Add(new Geometry(name, geomClone));
                                    model3DGroup.Children.Add(geomClone);
                                    return name;

                                }
                                else if (null != lighting)
                                {
                                    Light lightClone = lighting.light.Clone();
                                    string name = getLightingName();
                                    Lightings.Add(new Lighting(name, lightClone));
                                    model3DGroup.Children.Add(lightClone);
                                    return name;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Perform a hit test in the 3DView.
        /// A negative value for the coordinates defaults to the screen centre (camera view).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="x">The x coordinate in the GraphicsWindow coordinates within the 3DView.</param>
        /// <param name="y">The y coordinate in the GraphicsWindow coordinates within the 3DView.</param>
        /// <returns>An array with the hit object name and its distance or "" for no hit.</returns>
        public static Primitive HitTest(Primitive shapeName, Primitive x, Primitive y)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;

                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                if (x < 0) x = viewport3D.Width / 2;
                                else x -= LDShapes.GetLeft(shapeName);
                                if (y < 0) y = viewport3D.Height / 2;
                                else y -= LDShapes.GetTop(shapeName);

                                PointHitTestParameters hitParams = new PointHitTestParameters(new Point(x, y));
                                rayResult = null;
                                VisualTreeHelper.HitTest(viewport3D, null, ResultCallback, hitParams);

                                if (null != rayResult)
                                {
                                    RayMeshGeometry3DHitTestResult rayResultMesh = rayResult as RayMeshGeometry3DHitTestResult;
                                    string result = "";
                                    foreach (Geometry i in Geometries)
                                    {
                                        if (i.geometryModel3D == rayResultMesh.ModelHit)
                                        {
                                            result += "1=" + i.name + ";";
                                            break;
                                        }
                                    }
                                    result += "2=" + Utilities.ArrayParse(rayResultMesh.DistanceToRayOrigin.ToString(CultureInfo.InvariantCulture)) + ";";
                                    return result;
                                }
                                return "";
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Freeze a geometry object to improve performance a bit - it cannot then be modified in any way.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The object to freeze.</param>
        public static void Freeze(Primitive shapeName, Primitive geometryName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, obj });
                    FastThread.BeginInvoke(delegates.Freeze_Delegate);
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
        /// Animate a geometry rotation about an axis vector.
        /// This uses the second rotation, the first is still available for another axis rotation.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object to animate.</param>
        /// <param name="xDir">X direction of vector to rotate about.</param>
        /// <param name="yDir">Y direction of vector to rotate about.</param>
        /// <param name="zDir">Z direction of vector to rotate about.</param>
        /// <param name="startAngle">The starting angle in degrees (e.g. 0).</param>
        /// <param name="endAngle">The final angle in degrees (e.g. 360).</param>
        /// <param name="duration">The animation duration (time in sec).</param>
        /// <param name="repeats">The number of times to repeat the animation (-1 is for ever).</param>
        public static void AnimateRotation(Primitive shapeName, Primitive geometryName, Primitive xDir, Primitive yDir, Primitive zDir, Primitive startAngle, Primitive endAngle, Primitive duration, Primitive repeats)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, xDir, yDir, zDir, startAngle, endAngle, duration, repeats, obj });
                    FastThread.BeginInvoke(delegates.AnimateRotation_Delegate);
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
        /// Animate a geometry rotation about an axis vector.
        /// This uses the third rotation, the first is still available for another axis rotation.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object to animate.</param>
        /// <param name="xDir">X direction of vector to rotate about.</param>
        /// <param name="yDir">Y direction of vector to rotate about.</param>
        /// <param name="zDir">Z direction of vector to rotate about.</param>
        /// <param name="startAngle">The starting angle in degrees (e.g. 0).</param>
        /// <param name="endAngle">The final angle in degrees (e.g. 360).</param>
        /// <param name="duration">The animation duration (time in sec).</param>
        /// <param name="repeats">The number of times to repeat the animation (-1 is for ever).</param>
        public static void AnimateRotation2(Primitive shapeName, Primitive geometryName, Primitive xDir, Primitive yDir, Primitive zDir, Primitive startAngle, Primitive endAngle, Primitive duration, Primitive repeats)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, xDir, yDir, zDir, startAngle, endAngle, duration, repeats, obj });
                    FastThread.BeginInvoke(delegates.AnimateRotation2_Delegate);
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
        /// Event when a rotation animation is completed.
        /// </summary>
        public static event SBCallback RotationCompleted
        {
            add
            {
                _RotationCompletedDelegate = value;
            }
            remove
            {
                _RotationCompletedDelegate = null;
            }
        }

        /// <summary>
        /// The last completed rotation animation geometry object.
        /// </summary>
        public static Primitive LastRotationCompleted
        {
            get
            {
                if (queueRotation.Count > 0) lastRotation = queueRotation.Dequeue();
                return lastRotation;
            }
        }

        /// <summary>
        /// Animate a geometry translation.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object to animate.</param>
        /// <param name="x">X position to animate to.</param>
        /// <param name="y">Y position to animate to.</param>
        /// <param name="z">Z position to animate to.</param>
        /// <param name="duration">The animation duration (sec).</param>
        public static void AnimateTranslation(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive duration)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, x, y, z, duration, obj });
                    FastThread.BeginInvoke(delegates.AnimateTranslation_Delegate);
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
        /// Event when a translation animation is completed.
        /// </summary>
        public static event SBCallback TranslationCompleted
        {
            add
            {
                _TranslationCompletedDelegate = value;
            }
            remove
            {
                _TranslationCompletedDelegate = null;
            }
        }

        /// <summary>
        /// The last completed translation animation geometry object.
        /// </summary>
        public static Primitive LastTranslationCompleted
        {
            get
            {
                if (queueTranslation.Count > 0) lastTranslation = queueTranslation.Dequeue();
                return lastTranslation;
            }
        }

        /// <summary>
        /// The number of currently queued completed rotation animations.
        /// </summary>
        public static Primitive QueuedRotationCompleted
        {
            get
            {
                return queueRotation.Count;
            }
        }

        /// <summary>
        /// The number of currently queued completed translation animations.
        /// </summary>
        public static Primitive QueuedTranslationCompleted
        {
            get
            {
                return queueTranslation.Count;
            }
        }

        /// <summary>
        /// Load geometry models from a file.
        /// Supported formats include 3ds, lwo, obj, objz, stl and off.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="fileName">The file to load.
        /// Often image files etc are also required with the same name in the same folder.</param>
        /// <returns>An array with the added geometry names.</returns>
        public static Primitive LoadModel(Primitive shapeName, Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                Model3DGroup model3DGroupLoad = ModelImporter.Load(fileName);
                                string names = "";
                                int i = 0;
                                foreach (GeometryModel3D geometry in model3DGroupLoad.Children)
                                {
                                    string name = getGeometryName();
                                    names += (++i).ToString() + "=" + Utilities.ArrayParse(name) + ";";
                                    AddTransforms(geometry);
                                    Geometries.Add(new Geometry(name, geometry));
                                    model3DGroup.Children.Add(geometry);
                                }
                                return Utilities.CreateArrayMap(names);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a sphere geometry object centred on (0,0,0).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="radius">The sphere radius.</param>
        /// <param name="divisions">The sphere divisions, default 10 (affects number of triangles and smoothness).</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddSphere(Primitive shapeName, Primitive radius, Primitive divisions, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                Point3D center = new Point3D(0, 0, 0);
                                int phiDiv = divisions < 2 ? 10 : (int)divisions;
                                int thetaDiv = 2 * phiDiv;
                                builder.AddSphere(center, radius, thetaDiv, phiDiv);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a tube geometry object.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="path">A space or colon deliminated list of 3D point coordinates.</param>
        /// <param name="diameter">The tube diameter.</param>
        /// <param name="divisions">The tube radial divisions, default 10 (affects number of triangles and smoothness).</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddTube(Primitive shapeName, Primitive path, Primitive diameter, Primitive divisions, Primitive colour, Primitive materialType)
        {
            bool closed = false;
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                Point3DCollection pointCollection = new Point3DCollection();
                                string[] s = Utilities.getString(path).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (int i = 0; i < s.Length; i += 3)
                                {
                                    pointCollection.Add(new Point3D(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1]), Utilities.getDouble(s[i + 2])));
                                }
                                int thetaDiv = divisions < 2 ? 10 : (int)divisions;
                                builder.AddTube(pointCollection, diameter, thetaDiv, closed);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a revolute geometry object.  This is a surface starting at (0,0,0) and pointing up.
        /// Its shape is defined by a set points (Y,Z) where Y is the vertical distance along the surface from 0 and Z is the radius of revolution.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="path">A space or colon deliminated list of 2D point coordinates describing the revolute shape.</param>
        /// <param name="divisions">The radial divisions, default 10 (affects number of triangles and smoothness).</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddRevolute(Primitive shapeName, Primitive path, Primitive divisions, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                List<Point> points = new List<Point>();
                                string[] s = Utilities.getString(path).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (int i = 0; i < s.Length; i += 2)
                                {
                                    points.Add(new Point(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1])));
                                }
                                int thetaDiv = divisions < 2 ? 10 : (int)divisions;
                                builder.AddRevolvedGeometry(points, new Point3D(0, 0, 0), new Vector3D(0, 1, 0), thetaDiv);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Reverse the outward normals for a geometry.
        /// For example, make the inside surface of a sphere the visible surface instead of the outside surface (skydome).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object to reverse outward normals.</param>
        public static void ReverseNormals(Primitive shapeName, Primitive geometryName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                MeshGeometry3D mesh = (MeshGeometry3D)geometry.Geometry;
                                Material material = geometry.Material;
                                int i;
                                for (i = 0; i < mesh.TriangleIndices.Count; i += 3)
                                {
                                    int j = mesh.TriangleIndices[i];
                                    mesh.TriangleIndices[i] = mesh.TriangleIndices[i + 1];
                                    mesh.TriangleIndices[i + 1] = j;
                                }
                                for (i = 0; i < mesh.Normals.Count; i++)
                                {
                                    mesh.Normals[i] *= -1;
                                }
                                geometry.Material = material;
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
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Add a cube geometry object centered on (0,0,0).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="sideLength">The side length of the cube.</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddCube(Primitive shapeName, Primitive sideLength, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                builder.AddBox(new Point3D(0, 0, 0), sideLength, sideLength, sideLength);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add an arrow geometry object pointing up starting at (0,0,0).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="length">The length of the arrow.</param>
        /// <param name="diameter">The diameter of the arrow shaft.</param>
        /// <param name="arrowLength">The length of the arrow head.</param>
        /// <param name="arrowDiameter">The diameter of the arrow head.</param>
        /// <param name="divisions">The number of divisions for the arrow (default 18).</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddArrow(Primitive shapeName, Primitive length, Primitive diameter, Primitive arrowLength, Primitive arrowDiameter, Primitive divisions, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                builder.AddArrow(new Point3D(0, 0, 0), new Point3D(0, length, 0), diameter, arrowLength / diameter, arrowDiameter / diameter, divisions);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a cone geometry object pointing up with base centred at (0,0,0).
        /// Note a cylinder is a cone with baseRadius = topRadius.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="baseRadius">The radius of the base.</param>
        /// <param name="topRadius">The radius of the top  if truncated (default 0).</param>
        /// <param name="height">The height of the cone.</param>
        /// <param name="divisions">The number of divisions for the cone (default 18).</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddCone(Primitive shapeName, Primitive baseRadius, Primitive topRadius, Primitive height, Primitive divisions, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                builder.AddCone(new Point3D(0, 0, 0), new Vector3D(0, 1, 0), baseRadius, topRadius, height, true, true, divisions);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a pyramid geometry object pointing up with base centred at (0,0,0).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="sideLength">The radius of the base.</param>
        /// <param name="height">The height of the cone.</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddPyramid(Primitive shapeName, Primitive sideLength, Primitive height, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                builder.AddPyramid(new Point3D(0, 0, 0), sideLength, height);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a pipe geometry object pointing up with base centred at (0,0,0).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="length">The length of the pipe.</param>
        /// <param name="innerDiameter">The inner diameter of the pipe.</param>
        /// <param name="outerDiameter">The outer diameter of the pipe.</param>
        /// <param name="divisions">The number of divisions for the pipe (default 18).</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddPipe(Primitive shapeName, Primitive length, Primitive innerDiameter, Primitive outerDiameter, Primitive divisions, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                builder.AddPipe(new Point3D(0, 0, 0), new Point3D(0, length, 0), innerDiameter, outerDiameter, divisions);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add an icosahedron geometry object centred at (0,0,0).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="radius">The radius of the icosahedron.</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddIcosahedron(Primitive shapeName, Primitive radius, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                builder.AddRegularIcosahedron(new Point3D(0, 0, 0), radius, false);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Add a rectangle geometry object centred at (0,0,0).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddRectangle(Primitive shapeName, Primitive width, Primitive height, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ProjectionCamera camera = (ProjectionCamera)viewport3D.Camera;

                                MeshBuilder builder = new MeshBuilder(true, true);
                                builder.AddCubeFace(new Point3D(0, 0, 0), new Vector3D(0, 0, 1), new Vector3D(0, 1, 0), 0, width, height);
                                MeshGeometry3D mesh = builder.ToMesh();

                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
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
        /// Set an object to rotate to always face the camera.
        /// This uses the 2nd and 3rd rotations.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        public static void SetBillBoard(Primitive shapeName, Primitive geometryName)
        {
            if (!BillBoards.ContainsKey(shapeName)) BillBoards[shapeName] = new List<string>();
            if (!BillBoards[shapeName].Contains(geometryName))
            {
                BillBoards[shapeName].Add(geometryName);
                MoveCamera(shapeName, 0, 0, 0, 0);
            }
        }

        /// <summary>
        /// Set the centre for rotation and scale transformations of a geometry.
        /// By default this is the centre of a bounding box for the geometry, often 0,0,0.
        /// The centre is defined in the coordinates used to create the geometry.
        /// It does not have to be within the geometry.
        /// If a coordinate value is set to "", then the default value is used.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="x">The x coordinate of the centre.</param>
        /// <param name="y">The y coordinate of the centre.</param>
        /// <param name="z">The z coordinate of the centre.</param>
        /// <param name="options">Options to control centre setting.  Multiples can be set, e.g. "R1R2R3" to set all rotations.
        /// "R1" First rotation transformation
        /// "R2" Second rotation transformation
        /// "R3" Third rotation transformation
        /// "S" Scale transformation
        /// </param>
        public static void SetCentre(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive options)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, x, y, z, (string)options, obj});
                    FastThread.BeginInvoke(delegates.SetCentre_Delegate);
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
        /// Get the bounding box extent of a geometry.
        /// This is the current position (after any transformations).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <returns>An array of dimensions or "FAILED".
        /// array[1] = sizeX (width)
        /// array[2] = sizeY (height)
        /// array[3] = sizeZ (depth)
        /// array[4] = X (Xmin)
        /// array[5] = Y (Ymin)
        /// array[6] = Z (Zmin)
        /// </returns>
        public static Primitive BoundingBox(Primitive shapeName, Primitive geometryName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        Primitive result = "";
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return "FAILED";
                                GeometryModel3D geometry = geom.geometryModel3D;

                                result[1] = geometry.Bounds.SizeX;
                                result[2] = geometry.Bounds.SizeY;
                                result[3] = geometry.Bounds.SizeZ;
                                result[4] = geometry.Bounds.X;
                                result[5] = geometry.Bounds.Y;
                                result[6] = geometry.Bounds.Z;
                                return result;
                            }
                            return "FAILED";
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "FAILED";
                        }
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "FAILED";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Reset the material for an existing geometry.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        public static void ResetMaterial(Primitive shapeName, Primitive geometryName, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, colour, materialType, obj });
                    FastThread.BeginInvoke(delegates.ResetMaterial_Delegate);
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
        /// Set the back face material for an existing geometry.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="colour">A colour or gradient brush for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular  - specular highlights.
        /// </param>
        public static void SetBackMaterial(Primitive shapeName, Primitive geometryName, Primitive colour, Primitive materialType)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    Delegates delegates = new Delegates(new object[] { (string)shapeName, (string)geometryName, colour, materialType, obj });
                    FastThread.BeginInvoke(delegates.SetBackMaterial_Delegate);
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
        /// Get the transformed (current) center position of an existing geometry.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <returns> An array of the transformed position or "FAILED".
        /// array[1] = X (Xcen)
        /// array[2] = Y (Ycen)
        /// array[3] = Z (Zcen)
        /// </returns>
        public static Primitive GetPosition(Primitive shapeName, Primitive geometryName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        Primitive result = "";
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return "FAILED";
                                GeometryModel3D geometry = geom.geometryModel3D;

                                Point3D center = geometry.Bounds.Location;
                                center.X += geometry.Bounds.SizeX / 2.0;
                                center.Y += geometry.Bounds.SizeY / 2.0;
                                center.Z += geometry.Bounds.SizeZ / 2.0;
                                result[1] = center.X;
                                result[2] = center.Y;
                                result[3] = center.Z;
                            }
                            return result;
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                            return "FAILED";
                        }
                    });
                    return FastThread.InvokeWithReturn(ret).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                    return "FAILED";
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Rotate (swap) the Y and Z direction of a geometry.
        /// This can be useful for geometries created with a Z up convention, coverting it to a Y up direction used by this extension.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        public static void SwapUpDirection(Primitive shapeName, Primitive geometryName)
        {
            UIElement obj;

            try
            {
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                MeshGeometry3D mesh = (MeshGeometry3D)geometry.Geometry;

                                Matrix3D rotateMatrix = Matrix3D.Identity;
                                Quaternion quaterion = new Quaternion(swapDirection, swapAngle);
                                rotateMatrix.Rotate(quaterion);

                                for (int i = 0; i < mesh.Positions.Count; i++)
                                {
                                    mesh.Positions[i] = rotateMatrix.Transform(mesh.Positions[i]);
                                }
                                for (int i = 0; i < mesh.Normals.Count; i++)
                                {
                                    mesh.Normals[i] = rotateMatrix.Transform(mesh.Normals[i]);
                                }

                                AddTransforms(geometry);
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
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }
}
