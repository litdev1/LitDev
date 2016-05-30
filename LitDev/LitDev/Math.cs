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

using Microsoft.JScript;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;

namespace LitDev
{
    public static class Evaluator
    {
        private static MethodInfo _evaluator = null;
        private static readonly string _jscriptSource = "class Evaluator { public static function Eval(expr : String) : String { return eval(expr); } }";
       
        public static string EvalToString(string statement)
        {
            return _evaluator.Invoke(null, new object[] { statement }).ToString();
        }
               
        static Evaluator()
        {
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.TreatWarningsAsErrors = false;
            compilerParams.GenerateExecutable = false;
            compilerParams.GenerateInMemory = true;

            JScriptCodeProvider provider = new JScriptCodeProvider();
            CompilerResults compile = provider.CompileAssemblyFromSource(compilerParams, _jscriptSource);
            foreach (Module module in compile.CompiledAssembly.GetModules())
            {
                foreach (Type type in module.GetTypes())
                {
                    foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.Public | BindingFlags.Static))
                    {
                        if (methodInfo.Name == "Eval")
                        {
                            _evaluator = methodInfo;
                            return;
                        }
                    }
                }
            }
        }
    }
    
    /// <summary>
    /// Trig functions with degrees.
    /// Other assorted maths functions and calculations.
    /// </summary>
    [SmallBasicType]
    public static class LDMath
    {
        private static double deg2rad = System.Math.PI / 180.0;
        
        /// <summary>
        /// Sin of an angle in degrees.
        /// </summary>
        /// <param name="angle">
        /// The angle in degrees.
        /// </param>
        /// <returns>
        /// The Sin of the angle.
        /// </returns>
        public static Primitive Sin(Primitive angle)
        {
            return System.Math.Sin(angle * deg2rad);
        }

        /// <summary>
        /// Cos of an angle in degrees.
        /// </summary>
        /// <param name="angle">
        /// The angle in degrees.
        /// </param>
        /// <returns>
        /// The Cos of the angle.
        /// </returns>
        public static Primitive Cos(Primitive angle)
        {
            return System.Math.Cos(angle * deg2rad);
        }

        /// <summary>
        /// Tan of an angle in degrees.
        /// </summary>
        /// <param name="angle">
        /// The angle in degrees.
        /// </param>
        /// <returns>
        /// The Tan of the angle.
        /// </returns>
        public static Primitive Tan(Primitive angle)
        {
            return System.Math.Tan(angle * deg2rad);
        }

        /// <summary>
        /// ArcSin in degrees.
        /// </summary>
        /// <param name="sin">
        /// The Sin of the angle.
        /// </param>
        /// <returns>
        /// The angle in degrees.
        /// </returns>
        public static Primitive ArcSin(Primitive sin)
        {
            return System.Math.Asin(System.Math.Min(1.0, System.Math.Max(-1.0, sin))) / deg2rad;
        }

        /// <summary>
        /// ArcCos in degrees.
        /// </summary>
        /// <param name="cos">
        /// The Cos of the angle.
        /// </param>
        /// <returns>
        /// The angle in degrees.
        /// </returns>
        public static Primitive ArcCos(Primitive cos)
        {
            return System.Math.Acos(System.Math.Min(1.0, System.Math.Max(-1.0, cos))) / deg2rad;
        }

        /// <summary>
        /// ArcTan in degrees.
        /// </summary>
        /// <param name="tan">
        /// The Tan of the angle.
        /// </param>
        /// <returns>
        /// The angle in degrees.
        /// </returns>
        public static Primitive ArcTan(Primitive tan)
        {
            return System.Math.Atan(tan) / deg2rad;
        }

        /// <summary>
        /// Calculate the distance and angle between two points.
        /// </summary>
        /// <param name="x1">
        /// The X coordinate of point 1.
        /// </param>
        /// <param name="y1">
        /// The Y coordinate of point 1.
        /// </param>
        /// <param name="x2">
        /// The X coordinate of point 2.
        /// </param>
        /// <param name="y2">
        /// The Y coordinate of point 2.
        /// </param>
        /// <returns>
        /// A 2 element array with the distance and the angle in degrees from point 1 to point 2.
        /// </returns>
        public static Primitive Convert2Radial(Primitive x1, Primitive y1, Primitive x2, Primitive y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dDist = System.Math.Sqrt(dx * dx + dy * dy);
            double dAngle;
            if (dx == 0.0)
            {
                dAngle = 90;
            }
            else
            {
                dAngle = ArcTan(dy / dx);
            }
            if (dx < 0.0) dAngle += 180.0;
            if (dAngle < 360.0) dAngle += 360.0;
            if (dAngle > 360.0) dAngle -= 360.0;

            return Utilities.CreateArrayMap("1=" + dDist.ToString(CultureInfo.InvariantCulture) + ";2=" + dAngle.ToString(CultureInfo.InvariantCulture) + ";");
        }

        /// <summary>
        /// Calculate the coordinates of a point 2, from point 1 and the distance and angle to point 2.
        /// </summary>
        /// <param name="x1">
        /// The X coordinate of point 1.
        /// </param>
        /// <param name="y1">
        /// The Y coordinate of point 1.
        /// </param>
        /// <param name="dist">
        /// The distance to point 2.
        /// </param>
        /// <param name="angle">
        /// The angle to point 2 in degrees.
        /// </param>
        /// <returns>
        /// A 2 element array with the coordinates of point 2.
        /// </returns>
        public static Primitive Convert2Cartesian(Primitive x1, Primitive y1, Primitive dist, Primitive angle)
        {
            return Utilities.CreateArrayMap("1=" + (x1 + dist * Cos(angle)) + ";2=" + (y1 + dist * Sin(angle)) + ";");
        }

        /// <summary>
        /// Rotate point 2 clockwise about point 1.
        /// </summary>
        /// <param name="x1">
        /// The X coordinate of point 1.
        /// </param>
        /// <param name="y1">
        /// The Y coordinate of point 1.
        /// </param>
        /// <param name="x2">
        /// The X coordinate of point 2.
        /// </param>
        /// <param name="y2">
        /// The Y coordinate of point 2.
        /// </param>
        /// <param name="angle">
        /// The angle to rotate point 2 around point 1 in degrees.
        /// </param>
        /// <returns>
        /// A 2 element array with the coordinates of the rotated point 2.
        /// </returns>
        public static Primitive Rotate(Primitive x1, Primitive y1, Primitive x2, Primitive y2, Primitive angle)
        {
            Primitive radial = Convert2Radial(x1, y1, x2, y2);
            return Convert2Cartesian(x1, y1, radial[1], radial[2] + angle);
        }

        /// <summary>
        /// Exponential of a number e^x.
        /// </summary>
        /// <param name="value">The value to raise e to the power of.</param>
        /// <returns>e^x</returns>
        public static Primitive Exp(Primitive value)
        {
            return System.Math.Exp(value);
        }

        /// <summary>
        /// Natural logarithm base.
        /// </summary>
        public static Primitive E { get { return System.Math.E; } }

        /// <summary>
        /// Get the integral part of a number.
        /// </summary>
        /// <param name="value">The number to truncate.</param>
        /// <returns>The integral part of the number (removing decimal fraction).</returns>
        public static Primitive Truncate(Primitive value)
        {
            return System.Math.Truncate((decimal)value);
        }

        /// <summary>
        /// Convert a decimal integer to another base.
        /// </summary>
        /// <param name="number">The decimal integer to convert (non negative).</param>
        /// <param name="Base">The base to convert to (2 binary) (8 octal) (16 hex).</param>
        /// <returns>The number in the requested base.</returns>
        public static Primitive Decimal2Base(Primitive number, Primitive Base)
        {
            try
            {
                return System.Convert.ToString(number, Base);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Convert a base number to a decimal integer.
        /// </summary>
        /// <param name="number">The base number to convert (non negative).</param>
        /// <param name="Base">The base to convert from (2 binary) (8 octal) (16 hex).</param>
        /// <returns>The number as a decimal integer.</returns>
        public static Primitive Base2Decimal(Primitive number, Primitive Base)
        {
            try
            {
                return System.Convert.ToInt32(number, Base);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Set the seed for random numbers.  The seed should be an integer number and be set before Math.GetRandomNumber is called.
        /// The random number sequence will be initialised by the seed and can be used for testing when a repeatable sequence of random numbers is required.
        /// </summary>
        public static Primitive RandomNumberSeed
        {
            set
            {
                Type MathType = typeof(Microsoft.SmallBasic.Library.Math);
                MathType.GetField("_random", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).SetValue(null, new Random((int)value));
            }
        }

        /// <summary>
        /// Hyperbolic sine.
        /// </summary>
        /// <param name="angle">Angle in radians.</param>
        /// <returns>Hyperbolic sine.</returns>
        public static Primitive Sinh(Primitive angle)
        {
            return System.Math.Sinh(angle);
        }

        /// <summary>
        /// Hyperbolic cosine.
        /// </summary>
        /// <param name="angle">Angle in radians.</param>
        /// <returns>Hyperbolic cosine.</returns>
        public static Primitive Cosh(Primitive angle)
        {
            return System.Math.Cosh(angle);
        }

        /// <summary>
        /// Hyperbolic tangent.
        /// </summary>
        /// <param name="angle">Angle in radians.</param>
        /// <returns>Hyperbolic tangent.</returns>
        public static Primitive Tanh(Primitive angle)
        {
            return System.Math.Tanh(angle);
        }

        /// <summary>
        /// Evaluate a string expression to a number or boolean (if possible).
        /// The JScript command 'eval' is used and may therefore allow more complex JScript manipulations (also see LDInline).
        /// The TextWindow should be visible prior to using this method if later use of the TextWindow is required.
        /// </summary>
        /// <param name="expression">The expression to evaluate, e.g. "(9/6) + 3" or "2.1 > 1.5".</param>
        /// <returns>The evaluated result.</returns>
        public static Primitive Evaluate(Primitive expression)
        {
            try
            {
                return Evaluator.EvalToString(expression);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Evaluate a string expression to a number (if possible).
        /// An alternative to Evaluate that behaves nicely with the TextWindow.
        /// </summary>
        /// <param name="expression">The expression to evaluate, e.g. "1e6 + 6/4".</param>
        /// <returns>The evaluated result.</returns>
        public static Primitive Evaluate2(Primitive expression)
        {
            try
            {
                ParameterExpression pe = Expression.Parameter(typeof(string), "IntegerAsReal");
                ExpressionParser parser = new ExpressionParser(new ParameterExpression[] { pe }, expression, null);
                LambdaExpression expr = Expression.Lambda(parser.Parse(typeof(double)), null);
                var del = (Func<double>)expr.Compile();
                return del();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Evaluate a string expression to a boolean "True" or "False" (if possible).
        /// An alternative to Evaluate that behaves nicely with the TextWindow.
        /// </summary>
        /// <param name="expression">The expression to evaluate to a boolean, e.g. "21.3 > 16".</param>
        /// <returns>The evaluated result ("True" or "False").</returns>
        public static Primitive Evaluate3(Primitive expression)
        {
            try
            {
                ParameterExpression pe = Expression.Parameter(typeof(string), "IntegerAsReal");
                ExpressionParser parser = new ExpressionParser(new ParameterExpression[] { pe }, expression, null);
                LambdaExpression expr = Expression.Lambda(parser.Parse(typeof(bool)), null);
                var del = (Func<bool>)expr.Compile();
                return del();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Round a number to a fixed number of significant figures.
        /// </summary>
        /// <param name="number">The number to change.</param>
        /// <param name="digits">The number of significant figures.</param>
        /// <returns>The modified number.</returns>
        public static Primitive FixSigFig(Primitive number, Primitive digits)
        {
            if (number == 0 || number+0 != number) return number;

            double scale = System.Math.Pow(10, System.Math.Floor(System.Math.Log10(System.Math.Abs((double)number))) + 1);
            return scale * System.Math.Round((double)number / scale, digits);
        }

        /// <summary>
        /// Round a number to a fixed number of decimal places.  Additional training decimal 0s are added if required.
        /// </summary>
        /// <param name="number">The number to change.</param>
        /// <param name="digits">The number of decimal places.</param>
        /// <returns>The modified number.</returns>
        public static Primitive FixDecimal(Primitive number, Primitive digits)
        {
            if (number + 0 != number) return number;

            double scale = System.Math.Pow(10, digits);
            return (Primitive)(1.0/scale) * (Primitive)System.Math.Round((double)number * scale);
        }

        /// <summary>
        /// The minimum number that Small Basic can handle.
        /// </summary>
        public static Primitive MinNumber
        {
            get { return Decimal.MinValue; }
        }

        /// <summary>
        /// The maximum number that Small Basic can handle.
        /// </summary>
        public static Primitive MaxNumber
        {
            get { return Decimal.MaxValue; }
        }
    }
}
