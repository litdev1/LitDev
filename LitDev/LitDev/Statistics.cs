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

using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Globalization;
using SBArray = Microsoft.SmallBasic.Library.Array;

namespace LitDev
{
    /// <summary>
    /// Performs statistics on a 1D array of data.
    /// </summary>
    [SmallBasicType]
    public static class LDStatistics
    {
        private static List<double> data = new List<double>();
        private static List<double> points = new List<double>();
        private static bool bPositive;
        private static int count, countVal;
        private static double sum, sum2, geom, harm, min, max;
        private static double minPoint, maxPoint;
        private static double[] xVal;
        private static double[] yVal;

        private static void setData(string array)
        {
            string[] stringSeparators = new string[] { ";" };
            string[] lines = array.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            data.Clear();
            sum = 0.0;
            sum2 = 0.0;
            geom = 1.0;
            harm = 0.0;
            min = 1.0e20;
            max = -1.0e20;
            bPositive = true;
            foreach (string line in lines)
            {
                string[] records = line.Split('=');
                try
                {
                    double point = Utilities.getDouble(records[1]);
                    sum += point;
                    sum2 += point * point;
                    min = System.Math.Min(min, point);
                    max = System.Math.Max(max, point);
                    bPositive = bPositive && point > 0;
                    if (bPositive)
                    {
                        geom *= point;
                        harm += 1.0 / point;
                    }
                    data.Add(point);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
            count = data.Count;
            data.Sort();
        }

        private static void setPoints(string array)
        {
            string[] stringSeparators = new string[] { ";" };
            string[] lines = array.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            points.Clear();
            minPoint = 1.0e20;
            maxPoint = -1.0e20;
            foreach (string line in lines)
            {
                string[] records = line.Split('=');
                try
                {
                    double point = Utilities.getDouble(records[1]);
                    minPoint = System.Math.Min(minPoint, point);
                    maxPoint = System.Math.Max(maxPoint, point);
                    points.Add(point);
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
            points.Sort();
        }

        private static void formData(string array)
        {
            string[] stringSeparators = new string[] { ";" };
            string[] lines = ((string)array).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            countVal = lines.Length;
            xVal = new double[countVal];
            yVal = new double[countVal];
            double _x, _y;
            int i = 0;
            foreach (string line in lines)
            {
                string[] records = line.Split('=');
                try
                {
                    _x = Utilities.getDouble(records[0]);
                    _y = Utilities.getDouble(records[1]);
                    xVal[i] = _x;
                    yVal[i] = _y;
                    i++;
                }
                catch (Exception ex)
                {
                    Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                }
            }
        }

        private static double interpolateY(double x)
        {
            if (x < xVal[0])
            {
                return yVal[0];
            }
            else if (x > xVal[countVal - 1])
            {
                return yVal[countVal - 1];
            }
            else
            {
                for (int i = 0; i < countVal - 1; i++)
                {
                    if (x >= xVal[i] && x <= xVal[i + 1])
                    {
                        if (xVal[i] == xVal[i + 1]) return (yVal[i] + yVal[i + 1]) / 2.0;
                        return yVal[i] + (yVal[i + 1] - yVal[i]) * (x - xVal[i]) / (xVal[i + 1] - xVal[i]);
                    }
                }
            }
            return 0;
        }

        private static double interpolateX(double y)
        {
            if (y < yVal[0])
            {
                return xVal[0];
            }
            else if (y > yVal[countVal - 1])
            {
                return xVal[countVal - 1];
            }
            else
            {
                for (int i = 0; i < countVal - 1; i++)
                {
                    if (y >= yVal[i] && y <= yVal[i + 1])
                    {
                        if (yVal[i] == yVal[i + 1]) return (xVal[i] + xVal[i + 1]) / 2.0;
                        return xVal[i] + (xVal[i + 1] - xVal[i]) * (y - yVal[i]) / (yVal[i + 1] - yVal[i]);
                    }
                }
            }
            return 0;
        }

        private static double factorial(int n)
        {
            double fact = 1;
            for (double i = 2; i <= n; i++) fact *= i;
            return fact;
        }

        private static double binomial(int n, int k)
        {
            double m = System.Math.Max(k, n - k);
            double fact = 1;
            for (double i = m + 1; i <= n; i++) fact *= i;
            for (double i = 2; i <= n - m; i++) fact /= i;
            return fact;
        }

        /// <summary>
        /// Set a 1D array of numbers to perform some statistics on.
        /// 
        /// This command must be called before any statistics are calculated.
        /// </summary>
        /// <param name="array">
        /// The array to perform statistics on.
        /// </param>
        /// <returns>
        /// An array of the data sorted.
        /// </returns>
        public static Primitive SetArray(Primitive array)
        {
            setData(array);
            string _data = "";
            int i = 0;
            foreach (double point in data)
            {
                i++;
                _data += i.ToString() + "=" + point.ToString(CultureInfo.InvariantCulture) + ";";
            }
            return Utilities.CreateArrayMap(_data);
        }

        /// <summary>
        /// The sum of data points.
        /// </summary>
        public static Primitive Sum { get { return sum; } }

        /// <summary>
        /// The sum of the squares of the data points.
        /// </summary>
        public static Primitive Sum2 { get { return sum2; } }

        /// <summary>
        /// The number of data points.
        /// </summary>
        public static Primitive Count { get { return count; } }

        /// <summary>
        /// The arithmetic mean of the data points.
        /// </summary>
        public static Primitive Mean { get { return count > 0 ? sum / (double)count : 0; } }

        /// <summary>
        /// The harmonic mean of the data points (all points > 0).
        /// </summary>
        public static Primitive HarmonicMean { get { return (bPositive && count > 0) ? (double)count / harm : 0; } }

        /// <summary>
        /// The geometric mean of the data points (all points > 0).
        /// </summary>
        public static Primitive GeometricMean { get { return (bPositive && count > 0) ? System.Math.Pow(geom, 1.0/(double)count) : 0; } }

        /// <summary>
        /// The standard deviation of the data points.
        /// </summary>
        public static Primitive SDev { get { return count > 1 ? System.Math.Sqrt((sum2 / (double)count - Mean * Mean) * ((double)count / (double)(count - 1))) : 0; } }

        /// <summary>
        /// The population deviation of the data points.
        /// </summary>
        public static Primitive PDev { get { return count > 0 ? System.Math.Sqrt(sum2 / (double)count - Mean * Mean) : 0; } }

        /// <summary>
        /// The median of the data points.
        /// </summary>
        public static Primitive Median { get { return count > 0 ? data[((count + 1) / 2)] : 0; } }

        /// <summary>
        /// The minimum value of the data points.
        /// </summary>
        public static Primitive Min { get { return count > 0 ? min : 0; } }

        /// <summary>
        /// The maximum value of the data points.
        /// </summary>
        public static Primitive Max { get { return count > 0 ? max : 0; } }

        /// <summary>
        /// The mode of the data points.
        /// </summary>
        public static Primitive Mode 
        { 
            get
            {
                int iCount = 0, maxCount = 0;
                double last = data[0], mode = 0.0;
                foreach (double point in data)
                {
                    if (point == last)
                    {
                        iCount++;
                    }
                    else
                    {
                        iCount = 1;
                        last = point;
                    }
                    if (iCount > maxCount)
                    {
                        mode = point;
                        maxCount = iCount;
                    }

                }
                return mode;
            } 
        }

        /// <summary>
        /// Create an array with a Normal distribution.
        /// </summary>
        /// <param name="distMean">The mean of the distribution.</param>
        /// <param name="distSTD">The standard deviation of the distribution.</param>
        /// <param name="size">The number of points.</param>
        /// <returns>A 1D array of the Normal distribution (Array[x] = y).</returns>
        public static Primitive DistNormal(Primitive distMean, Primitive distSTD, Primitive size)
        {
            double rangeMin = distMean - 5 * distSTD;
            double rangeMax = distMean + 5 * distSTD; 
            string result = "";
            double x, y;
            double scale = 1.0 / System.Math.Sqrt(2.0 * System.Math.PI) / distSTD;
            for (int i = 0; i < size; i++)
            {
                x = rangeMin + (rangeMax - rangeMin) * i / (double)(size - 1);
                y = scale * System.Math.Exp(-0.5 * (x - distMean) * (x - distMean) / distSTD / distSTD);
                result += ((Decimal)x).ToString(CultureInfo.InvariantCulture) + "=" + ((Decimal)y).ToString(CultureInfo.InvariantCulture) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Create an array with a Binomial distribution.
        /// 
        /// This is like the probablity of getting k heads from 20 (n) coin tosses, with a probablity for each toss getting a heads of 0.5 (p).
        /// </summary>
        /// <param name="n">The number of tries.</param>
        /// <param name="p">The probablity of success for each try.</param>
        /// <returns>A 1D array of the Binomial distribution, probablity of k successes (Array[k] = y).</returns>
        public static Primitive DistBinomial(Primitive n, Primitive p)
        {
            string result = "";
            double x, y;
            for (int k = 0; k <= n; k++)
            {
                x = k;
                //y = factorial(n) / factorial(k) / factorial(n - k) * System.Math.Pow(p, k) * System.Math.Pow(1 - p, n - k);
                y = binomial(n, k) * System.Math.Pow(p, k) * System.Math.Pow(1 - p, n - k);
                result += ((Decimal)x).ToString(CultureInfo.InvariantCulture) + "=" + ((Decimal)y).ToString(CultureInfo.InvariantCulture) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Create an array with a Uniform distribution.
        /// </summary>
        /// <param name="rangeMin">The minimum value.</param>
        /// <param name="rangeMax">The maximum value.</param>
        /// <param name="size">The number of points.</param>
        /// <returns>A 1D array of the Uniform distribution (Array[x] = y).</returns>
        public static Primitive DistUniform(Primitive rangeMin, Primitive rangeMax, Primitive size)
        {
            string result = "";
            double x, y;
            double scale = 1.0 / (rangeMax - rangeMin);
            for (int i = 0; i < size; i++)
            {
                x = rangeMin + (rangeMax - rangeMin) * i / (double)(size - 1);
                y = scale;
                result += ((Decimal)x).ToString(CultureInfo.InvariantCulture) + "=" + ((Decimal)y).ToString(CultureInfo.InvariantCulture) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Create an array with a Triangular distribution.
        /// </summary>
        /// <param name="rangeMin">The minimum value.</param>
        /// <param name="rangeMax">The maximum value.</param>
        /// <param name="size">The number of points.</param>
        /// <returns>A 1D array of the Triangular distribution (Array[x] = y).</returns>
        public static Primitive DistTriangular(Primitive rangeMin, Primitive rangeMax, Primitive size)
        {
            string result = "";
            double x, y;
            double scale = 4.0 / (rangeMax - rangeMin) / (rangeMax - rangeMin);
            for (int i = 0; i < size; i++)
            {
                x = rangeMin + (rangeMax - rangeMin) * i / (double)(size - 1);
                if (x < (rangeMin + rangeMax) / 2.0)
                {
                    y = scale * (x - rangeMin);
                }
                else
                {
                    y = scale * (rangeMax - x);
                }
                result += ((Decimal)x).ToString(CultureInfo.InvariantCulture) + "=" + ((Decimal)y).ToString(CultureInfo.InvariantCulture) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Calculate the integral of a 1D data array.
        /// </summary>
        /// <param name="array">The array to integrate (array[x]=y).</param>
        /// <returns>A 1D array of the Integral of the input array.</returns>
        public static Primitive Integrate(Primitive array)
        {
            formData(array);

            double last = 0.0, next, dx;
            string result = xVal[0].ToString(CultureInfo.InvariantCulture) + "=0;";

            for (int i = 1; i < countVal; i++)
            {
                dx = xVal[i] - xVal[i - 1];
                next = last + dx * (yVal[i] + yVal[i - 1]) / 2.0;
                result += xVal[i].ToString(CultureInfo.InvariantCulture) + "=" + next.ToString(CultureInfo.InvariantCulture) + ";";
                last = next;
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Calculate the derivative of a 1D data array.
        /// </summary>
        /// <param name="array">The array to differentiate (array[x]=y).</param>
        /// <returns>A 1D array of the Derivative of the input array.</returns>
        public static Primitive Differentiate(Primitive array)
        {
            formData(array);

            double dx, dy;
            string result = "";

            for (int i = 1; i < countVal; i++)
            {
                dx = xVal[i] - xVal[i - 1];
                dy = yVal[i] - yVal[i - 1];
                if (dx != 0) result += ((xVal[i - 1] + xVal[i]) / 2.0).ToString(CultureInfo.InvariantCulture) + "=" + (dy / dx).ToString(CultureInfo.InvariantCulture) + ";";
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Interpolate a 1D data array to find the value of y(x).
        /// 
        /// The values of x should be monotonically increasing.
        /// </summary>
        /// <param name="array">The array to interpolate (array[x]=y).</param>
        /// <param name="x">The value of x (may be an array of x values).</param>
        /// <returns>The interpolated value y or an array of y values.</returns>
        public static Primitive InterpolateY(Primitive array, Primitive x)
        {
            formData(array);

            if (SBArray.GetItemCount(x) == 0)
            {
                return interpolateY(x);
            }
            else
            {
                setPoints(x);
                string result = "";
                for (int i = 0; i < points.Count; i++)
                {
                    result += (i + 1).ToString() + "=" + interpolateY(points[i]).ToString(CultureInfo.InvariantCulture) + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
        }

        /// <summary>
        /// Interpolate a 1D data array to find the value of x(y).
        /// 
        /// The values of y should be monotonically increasing with x.
        /// </summary>
        /// <param name="array">The array to interpolate (array[x]=y).</param>
        /// <param name="y">The value of y (may be an array of y values).</param>
        /// <returns>The interpolated value x or an array of x values.</returns>
        public static Primitive InterpolateX(Primitive array, Primitive y)
        {
            formData(array);

            if (SBArray.GetItemCount(y) == 0)
            {
                return interpolateX(y);
            }
            else
            {
                setPoints(y);
                string result = "";
                for (int i = 0; i < points.Count; i++)
                {
                    result += (i + 1).ToString() + "=" + interpolateX(points[i]).ToString(CultureInfo.InvariantCulture) + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
        }

        /// <summary>
        /// Calculate a frequency distribution from array of data.
        /// </summary>
        /// <param name="array">The array to create the frequency distribution from.</param>
        /// <param name="bins">The number of bins spanning the data.</param>
        /// <param name="normalised">Is the frequency normalised to integrate to 1 ("True" or "False").</param>
        /// <returns>Frequency distribution as an array (array[bin]=frequency).</returns>
        public static Primitive Frequency(Primitive array, Primitive bins, Primitive normalised)
        {
            setPoints(array);

            Dictionary<Primitive, Primitive> dictionary = new Dictionary<Primitive, Primitive>();
            int i;
            for (i = 0; i < bins; i++)
            {
                dictionary.Add(minPoint + (maxPoint-minPoint) * (i + 0.5) / (double)bins, 0);
            }
            double increment = normalised ? (double)bins / (double)points.Count / (maxPoint - minPoint) : 1;
            foreach (double value in points)
            {
                i = (int)((value - minPoint) * bins / (maxPoint - minPoint));
                i = System.Math.Min(bins - 1, System.Math.Max(0, i));
                dictionary[minPoint + (maxPoint - minPoint) * (i + 0.5) / (double)bins] += increment;
            }

            return Primitive.ConvertFromMap(dictionary);
        }
    }
}
