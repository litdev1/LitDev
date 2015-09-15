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
using System.Globalization;

namespace LitDev
{
    /// <summary>
    /// Logic operations.
    /// </summary>
    [SmallBasicType]
    public static class LDLogic
    {
        private static StringComparison stringComparison = StringComparison.Ordinal;

        /// <summary>
        /// Set if string comparisons are case sensitive ("true", default) or not ("False").
        /// </summary>
        public static Primitive CaseSensitive
        {
            get { return stringComparison == StringComparison.Ordinal; }
            set { stringComparison = value ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase; }
        }

        /// <summary>
        /// The Not operator.
        /// Not("True") = "False"
        /// Not("False") = "True"
        /// </summary>
        /// <param name="value">The value to operate on ("True" or "False").</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive Not(Primitive value)
        {
            return !value;
        }

        /// <summary>
        /// The Or operator.
        /// Or("True","True") = "True"
        /// Or("False","False") = "False"
        /// Or("True","False") = "True"
        /// Or("False","True") = "True"
        /// </summary>
        /// <param name="value1">The first value ("True" or "False").</param>
        /// <param name="value2">The second value ("True" or "False").</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive Or(Primitive value1, Primitive value2)
        {
            return value1 || value2;
        }

        /// <summary>
        /// The And operator.
        /// And("True","True") = "True"
        /// And("False","False") = "False"
        /// And("True","False") = "False"
        /// And("False","True") = "False"
        /// </summary>
        /// <param name="value1">The first value ("True" or "False").</param>
        /// <param name="value2">The second value ("True" or "False").</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive And(Primitive value1, Primitive value2)
        {
            return value1 && value2;
        }

        /// <summary>
        /// The XOr (exclusive or) operator.
        /// XOr("True","True") = "False"
        /// XOr("False","False") = "False"
        /// XOr("True","False") = "True"
        /// XOr("False","True") = "True"
        /// </summary>
        /// <param name="value1">The first value ("True" or "False").</param>
        /// <param name="value2">The second value ("True" or "False").</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive XOr(Primitive value1, Primitive value2)
        {
            return (bool)value1 ^ value2;
        }

        /// <summary>
        /// The less than operator.
        /// Checks if value1 is less than value2.
        /// It also works for strings, where a lexical comparison is made.
        /// </summary>
        /// <param name="value1">The first value.</param>
        /// <param name="value2">The second value.</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive LT(Primitive value1, Primitive value2)
        {
            decimal num1, num2;
            if (decimal.TryParse((string)value1, NumberStyles.Float, CultureInfo.InvariantCulture, out num1) && decimal.TryParse((string)value2, NumberStyles.Float, CultureInfo.InvariantCulture, out num2))
            {
                return value1 < value2;
            }
            else
            {
                return string.Compare(value1, value2, stringComparison) < 0;
            }
        }

        /// <summary>
        /// The less than or equal operator.
        /// Checks if value1 is less than or equal to value2.
        /// It also works for strings, where a lexical comparison is made.
        /// </summary>
        /// <param name="value1">The first value.</param>
        /// <param name="value2">The second value.</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive LE(Primitive value1, Primitive value2)
        {
            decimal num1, num2;
            if (decimal.TryParse((string)value1, NumberStyles.Float, CultureInfo.InvariantCulture, out num1) && decimal.TryParse((string)value2, NumberStyles.Float, CultureInfo.InvariantCulture, out num2))
            {
                return value1 <= value2;
            }
            else
            {
                return string.Compare(value1, value2, stringComparison) <= 0;
            }
        }

        /// <summary>
        /// The greater than operator.
        /// Checks if value1 is greater than value2.
        /// It also works for strings, where a lexical comparison is made.
        /// </summary>
        /// <param name="value1">The first value.</param>
        /// <param name="value2">The second value.</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive GT(Primitive value1, Primitive value2)
        {
            decimal num1, num2;
            if (decimal.TryParse((string)value1, NumberStyles.Float, CultureInfo.InvariantCulture, out num1) && decimal.TryParse((string)value2, NumberStyles.Float, CultureInfo.InvariantCulture, out num2))
            {
                return value1 > value2;
            }
            else
            {
                return string.Compare(value1, value2, stringComparison) > 0;
            }
        }

        /// <summary>
        /// The greater than or equal operator.
        /// Checks if value1 is greater than or equal to value2.
        /// It also works for strings, where a lexical comparison is made.
        /// </summary>
        /// <param name="value1">The first value.</param>
        /// <param name="value2">The second value.</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive GE(Primitive value1, Primitive value2)
        {
            decimal num1, num2;
            if (decimal.TryParse((string)value1, NumberStyles.Float, CultureInfo.InvariantCulture, out num1) && decimal.TryParse((string)value2, NumberStyles.Float, CultureInfo.InvariantCulture, out num2))
            {
                return value1 >= value2;
            }
            else
            {
                return string.Compare(value1, value2, stringComparison) >= 0;
            }
        }

        /// <summary>
        /// The equality operator.
        /// Checks if value1 is equal to value2.
        /// It also works for strings, where a lexical comparison is made.
        /// </summary>
        /// <param name="value1">The first value.</param>
        /// <param name="value2">The second value.</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive EQ(Primitive value1, Primitive value2)
        {
            decimal num1, num2;
            if (decimal.TryParse((string)value1, NumberStyles.Float, CultureInfo.InvariantCulture, out num1) && decimal.TryParse((string)value2, NumberStyles.Float, CultureInfo.InvariantCulture, out num2))
            {
                return value1 == value2;
            }
            else
            {
                return string.Compare(value1, value2, stringComparison) == 0;
            }
        }

        /// <summary>
        /// The inequality operator.
        /// Checks if value1 is not equal to value2.
        /// It also works for strings, where a lexical comparison is made.
        /// </summary>
        /// <param name="value1">The first value.</param>
        /// <param name="value2">The second value.</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive NE(Primitive value1, Primitive value2)
        {
            decimal num1, num2;
            if (decimal.TryParse((string)value1, NumberStyles.Float, CultureInfo.InvariantCulture, out num1) && decimal.TryParse((string)value2, NumberStyles.Float, CultureInfo.InvariantCulture, out num2))
            {
                return value1 != value2;
            }
            else
            {
                return string.Compare(value1, value2, stringComparison) != 0;
            }
        }
    }
}
