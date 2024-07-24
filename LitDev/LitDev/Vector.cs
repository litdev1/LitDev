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
using System.Windows.Media.Media3D;

namespace LitDev
{
    /// <summary>
    /// 3D vector algebra methods, useful for LD3DView manipulations.
    /// All vectors or points are a 3 element array indexed by 1,2,3.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDVector
    {
        static LDVector()
        {
            Instance.Verify();
        }

        /// <summary>
        /// Rotate one vector about a direction defined by a second vector.
        /// </summary>
        /// <param name="vector">The vector to rotate.</param>
        /// <param name="about">The vector axis direction to rotate about.</param>
        /// <param name="angle">The angle (in degrees) to rotate the vector by.</param>
        /// <returns>The rotated vector or "" on failure.</returns>
        public static Primitive Rotate(Primitive vector, Primitive about, Primitive angle)
        {
            try
            {
                Vector3D _vector = new Vector3D(vector[1], vector[2], vector[3]);
                Vector3D _about = new Vector3D(about[1], about[2], about[3]);

                Matrix3D rotateMatrix = Matrix3D.Identity;
                Quaternion quaterion = new Quaternion(_about, angle);
                rotateMatrix.Rotate(quaterion);
                _vector = rotateMatrix.Transform(_vector);

                Primitive result = "";
                result[1] = _vector.X;
                result[2] = _vector.Y;
                result[3] = _vector.Z;
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Rotate a point about a specified center point and direction.
        /// </summary>
        /// <param name="point">The point to rotate.</param>
        /// <param name="center">The point to rotate about.</param>
        /// <param name="about">The vector axis direction to rotate about.</param>
        /// <param name="angle">The angle (in degrees) to rotate the point by.</param>
        /// <returns>The rotated point or "" on failure.</returns>
        public static Primitive RotatePoint(Primitive point, Primitive center, Primitive about, Primitive angle)
        {
            try
            {
                Vector3D _center = new Vector3D(center[1], center[2], center[3]);
                Vector3D _vector = new Vector3D(point[1], point[2] , point[3]) - _center;
                Vector3D _about = new Vector3D(about[1], about[2], about[3]);

                Matrix3D rotateMatrix = Matrix3D.Identity;
                Quaternion quaterion = new Quaternion(_about, angle);
                rotateMatrix.Rotate(quaterion);
                _vector = rotateMatrix.Transform(_vector) + _center;

                Primitive result = "";
                result[1] = _vector.X;
                result[2] = _vector.Y;
                result[3] = _vector.Z;
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the dot product of 2 vectors.
        /// </summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The dot product or "" on failure.</returns>
        public static Primitive DotProduct(Primitive vector1, Primitive vector2)
        {
            try
            {
                Vector3D _vector1 = new Vector3D(vector1[1], vector1[2], vector1[3]);
                Vector3D _vector2 = new Vector3D(vector2[1], vector2[2], vector2[3]);
                return Vector3D.DotProduct(_vector1, _vector2);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the vector cross product of 2 vectors.
        /// </summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The vector cross product or "" on failure.</returns>
        public static Primitive CrossProduct(Primitive vector1, Primitive vector2)
        {
            try
            {
                Vector3D _vector1 = new Vector3D(vector1[1], vector1[2], vector1[3]);
                Vector3D _vector2 = new Vector3D(vector2[1], vector2[2], vector2[3]);
                Vector3D _vector = Vector3D.CrossProduct(_vector1, _vector2);

                Primitive result = "";
                result[1] = _vector.X;
                result[2] = _vector.Y;
                result[3] = _vector.Z;
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the angle between 2 vectors.
        /// </summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The angle (in degrees) between the vectors or "" on failure.</returns>
        public static Primitive AngleBetween(Primitive vector1, Primitive vector2)
        {
            try
            {
                Vector3D _vector1 = new Vector3D(vector1[1], vector1[2], vector1[3]);
                Vector3D _vector2 = new Vector3D(vector2[1], vector2[2], vector2[3]);
                return Vector3D.AngleBetween(_vector1, _vector2);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Normalise a vector to unit length.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>A rescaled vector of unit length or "" on failure.</returns>
        public static Primitive Normalise(Primitive vector)
        {
            try
            {
                Vector3D _vector = new Vector3D(vector[1], vector[2], vector[3]);
                _vector.Normalize();

                Primitive result = "";
                result[1] = _vector.X;
                result[2] = _vector.Y;
                result[3] = _vector.Z;
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the length of a vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>The vector length or "" on failure.</returns>
        public static Primitive Length(Primitive vector)
        {
            try
            {
                Vector3D _vector = new Vector3D(vector[1], vector[2], vector[3]);
                return _vector.Length;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Multiply a vector by a scalar.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="scalar">A scalar number to resize the vector.</param>
        /// <returns>The rescaled vector or "" on failure.</returns>
        public static Primitive Multiply(Primitive vector, Primitive scalar)
        {
            try
            {
                Primitive result = "";
                result[1] = vector[1] * scalar;
                result[2] = vector[2] * scalar;
                result[3] = vector[3] * scalar;
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Add 2 vectors.
        /// </summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The resulting vector or "" on failure.</returns>
        public static Primitive Add(Primitive vector1, Primitive vector2)
        {
            try
            {
                Primitive result = "";
                result[1] = vector1[1] + vector2[1];
                result[2] = vector1[2] + vector2[2];
                result[3] = vector1[3] + vector2[3];
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Subtract one vector from another.
        /// </summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector (to subtract from the first).</param>
        /// <returns>The resulting vector or "" on failure.</returns>
        public static Primitive Subtract(Primitive vector1, Primitive vector2)
        {
            try
            {
                Primitive result = "";
                result[1] = vector1[1] - vector2[1];
                result[2] = vector1[2] - vector2[2];
                result[3] = vector1[3] - vector2[3];
                return result;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
    }
}
