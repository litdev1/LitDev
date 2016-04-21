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
using System.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace LitDev
{
    /// <summary>
    /// Extended maths methods.
    /// </summary>
    [SmallBasicType]
    public static class LDMathX
    {
        /// <summary>
        /// Compute a FFT (Fast Fourier Transform).
        /// </summary>
        /// <param name="real">An array of real values to calculate the FFT from.</param>
        /// <returns>An array of complex data (real amplitude and imaginary phase) or "FAILED".
        /// For each complex pair the index is the real part and the value is the imaginary part.</returns>
        public static Primitive FFTForawrd(Primitive real)
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
                Fourier.BluesteinForward(complex, FourierOptions.Default);
                string result = "";
                for (i = 0; i < length; i++)
                {
                    result += (i + 1).ToString() + "=" + (complex[i].Real + "\\=" + complex[i].Imaginary + "\\;") + ";";
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
                Fourier.BluesteinInverse(complexData, FourierOptions.Default);
                string result = "";
                for (i = 0; i < length; i++)
                {
                    result += (i + 1).ToString() + "=" + complexData[i].Real + ";";
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
                    result += (i++).ToString() + "=" + real + ";";
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
                    result += (i++).ToString() + "=" + imaginary + ";";
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
                    result += (i + 1).ToString() + "=" + (realData[i] + "\\=" + imaginaryData[i] + "\\;") + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}
