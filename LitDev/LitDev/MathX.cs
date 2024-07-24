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

using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics.Interpolation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Reflection;

namespace LitDev
{
    /// <summary>
    /// Extended maths methods, FFT and cubic spline.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDMathX
    {
        static LDMathX()
        {
            Instance.Verify();
        }

        /// <summary>
        /// Compute a FFT (Fast Fourier Transform).
        /// </summary>
        /// <param name="real">An array of real values to calculate the FFT from.</param>
        /// <returns>An array of complex data (real amplitude and imaginary phase) or "FAILED".
        /// For each complex pair the index is the real part and the value is the imaginary part.</returns>
        public static Primitive FFTForward(Primitive real)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> dataMap;
                dataMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(real);
                int length = dataMap.Count;
                Complex[] complex = new Complex[length];
                int i = 0;
                foreach (KeyValuePair<Primitive, Primitive> kvp in dataMap)
                {
                    double realData = double.Parse(kvp.Value);
                    complex[i++] = new Complex(realData, 0);
                }
                Fourier.Forward(complex, FourierOptions.Default);
                string result = "";
                for (i = 0; i < length; i++)
                {
                    result += (i + 1).ToString() + "=" + (complex[i].Real.ToString(CultureInfo.InvariantCulture) + "\\=" + complex[i].Imaginary.ToString(CultureInfo.InvariantCulture) + "\\;") + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// The inverse of a FFT (Fast Fourier Transform).
        /// </summary>
        /// <param name="complex">An array of complex data (real amplitude and imaginary phase).
        /// For each complex pair the index is the real part and the value is the imaginary part.</param>
        /// <returns>An array of inverse FFT values or "FAILED".</returns>
        public static Primitive FFTInverse(Primitive complex)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> dataMap;
                dataMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(complex);
                int length = dataMap.Count;
                Complex[] complexData = new Complex[length];
                int i = 0;
                foreach (KeyValuePair<Primitive, Primitive> kvp in dataMap)
                {
                    string[] values = ((string)kvp.Value).Split(new char[] { '=', ';' });
                    double real = double.Parse(values[0]);
                    double imaginary = double.Parse(values[1]);
                    complexData[i++] = new Complex(real, imaginary);
                }
                Fourier.Inverse(complexData, FourierOptions.Default);
                string result = "";
                for (i = 0; i < length; i++)
                {
                    result += (i + 1).ToString() + "=" + complexData[i].Real.ToString(CultureInfo.InvariantCulture) + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get the real part of an array of complex data.
        /// </summary>
        /// <param name="complex">An array of complex data (real amplitude and imaginary phase).
        /// For each complex pair the index is the real part and the value is the imaginary part.</param>
        /// <returns>An array of the real part of the data or "FAILED".</returns>
        public static Primitive FFTReal(Primitive complex)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> complexMap;
                complexMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(complex);
                int i = 1;
                string result = "";
                foreach (KeyValuePair<Primitive, Primitive> kvp in complexMap)
                {
                    string[] values = ((string)kvp.Value).Split(new char[] { '=', ';' });
                    double real = double.Parse(values[0]);
                    result += (i++).ToString() + "=" + real.ToString(CultureInfo.InvariantCulture) + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Get the imaginary part of an array of complex data.
        /// </summary>
        /// <param name="complex">An array of complex data (real amplitude and imaginary phase).
        /// For each complex pair the index is the real part and the value is the imaginary part.</param>
        /// <returns>An array of the imaginary part of the data or "FAILED".</returns>
        public static Primitive FFTImaginary(Primitive complex)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> complexMap;
                complexMap = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(complex);
                int i = 1;
                string result = "";
                foreach (KeyValuePair<Primitive, Primitive> kvp in complexMap)
                {
                    string[] values = ((string)kvp.Value).Split(new char[] { '=', ';' });
                    double imaginary = double.Parse(values[1]);
                    result += (i++).ToString() + "=" + imaginary.ToString(CultureInfo.InvariantCulture) + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Create an array of complex values from arrays of real and imaginary parts.
        /// </summary>
        /// <param name="real">An array of real data.</param>
        /// <param name="imaginary">An array of imaginary data.</param>
        /// <returns>An array of complex data (real amplitude and imaginary phase), "MISMATCH" or "FAILED".
        /// For each complex pair the index is the real part and the value is the imaginary part.</returns>
        public static Primitive FFTComplex(Primitive real, Primitive imaginary)
        {
            try
            {
                Type PrimitiveType = typeof(Primitive);
                Dictionary<Primitive, Primitive> dataReal, dataImaginary;
                dataReal = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(real);
                dataImaginary = (Dictionary<Primitive, Primitive>)PrimitiveType.GetField("_arrayMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.Instance).GetValue(imaginary);
                int length = dataReal.Count;
                if (length != dataImaginary.Count) return "MISMATCH";
                List<double> realData = new List<double>();
                foreach (KeyValuePair<Primitive, Primitive> kvp in dataReal)
                {
                    realData.Add(kvp.Value);
                }
                List<double> imaginaryData = new List<double>();
                foreach (KeyValuePair<Primitive, Primitive> kvp in dataImaginary)
                {
                    imaginaryData.Add(kvp.Value);
                }
                string result = "";
                for (int i = 0; i < length; i++)
                {
                    result += (i + 1).ToString() + "=" + (realData[i].ToString(CultureInfo.InvariantCulture) + "\\=" + imaginaryData[i].ToString(CultureInfo.InvariantCulture) + "\\;") + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        private static Dictionary<string, CubicSpline> cubicSplines = new Dictionary<string, CubicSpline>();

        /// <summary>
        /// Create a cubic spline for later interpolation.
        /// </summary>
        /// <param name="data">A set of x,y data in an array data[x]=y.</param>
        /// <param name="mode">Spline termination (both ends) or other variants
        /// 1 : first derivitive = 0
        /// 2 : second derivitive = 0
        /// 3 : Hermite cubic spline (all first derivatives = 0)
        /// 4 : Akima cubic spline (reduce outlier overshoots)</param>
        /// <returns>The cubic spline.</returns>
        public static Primitive CreateSpline(Primitive data, Primitive mode)
        {
            Type ShapesType = typeof(Shapes);
            string splineName;

            try
            {
                MethodInfo method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
#if SVB
                splineName = method.Invoke(null, new object[] { "Spline", false }).ToString();
#else
                splineName = method.Invoke(null, new object[] { "Spline" }).ToString();
#endif
                Primitive indices = SBArray.GetAllIndices(data);
                int numData = SBArray.GetItemCount(data);
                double[] x = new double[numData];
                double[] y = new double[numData];
                double[] d = new double[numData];
                for (int i = 1; i <= numData; i++)
                {
                    Primitive index = indices[i];
                    x[i - 1] = index;
                    y[i - 1] = data[index];
                    d[i - 1] = 0;
                }
                CubicSpline spline;
                switch ((int)mode)
                {
                    case 1:
                        spline = CubicSpline.InterpolateBoundaries(x, y, SplineBoundaryCondition.FirstDerivative, 0, SplineBoundaryCondition.FirstDerivative, 0);
                        cubicSplines[splineName] = spline;
                        break;
                    case 2:
                        spline = CubicSpline.InterpolateBoundaries(x, y, SplineBoundaryCondition.SecondDerivative, 0, SplineBoundaryCondition.SecondDerivative, 0);
                        cubicSplines[splineName] = spline;
                        break;
                    case 3:
                        spline = CubicSpline.InterpolateHermite(x, y, d);
                        cubicSplines[splineName] = spline;
                        break;
                    case 4:
                        spline = CubicSpline.InterpolateAkima(x, y);
                        cubicSplines[splineName] = spline;
                        break;
                    default:
                        spline = CubicSpline.InterpolateNatural(x, y);
                        cubicSplines[splineName] = spline;
                        break;
                }
                return splineName;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Calculated interpolated data from a previopusly created cubic spline.
        /// </summary>
        /// <param name="splineName">The cubic spline created with CreateSpline.</param>
        /// <param name="data">An array of x values to interpolate.</param>
        /// <returns>An array of interpolated x,y pairs, result[x] = y.</returns>
        public static Primitive InterpolateSpline(Primitive splineName, Primitive data)
        {
            try
            {
                CubicSpline spline = null;
                if (cubicSplines.TryGetValue(splineName, out spline))
                {
                    if (SBArray.IsArray(data))
                    {
                        Primitive result = "";
                        Primitive indices = SBArray.GetAllIndices(data);
                        for (int i = 1; i <= SBArray.GetItemCount(indices); i++)
                        {
                            int index = indices[i];
                            result[index] = spline.Interpolate(index);
                        }
                        return data;
                    }
                    else
                    {
                        return spline.Interpolate(data);
                    }
                }
                return "FAILED";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}
