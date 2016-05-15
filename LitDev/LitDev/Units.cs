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
using System.Collections.Generic;
using varType = System.Int32;

namespace LitDev
{
    /// <summary>
    /// A general editable unit conversion system.
    /// All units and dimensions are case sensitive.
    /// A base unit consists of a name and conversion factors (multiplier and additive term, usually 1 and 0).
    /// A derived unit consists of a name and units definition and optional additive term, usually 0.
    /// A unit is parsed by separting . and /, then recursively resolving derived unit conversions, bracketed () terms first.
    /// Values (especially those with a decimal point '.') should be contained in ().
    /// A unit may be prefixed by a prefix or number value (e.g. m is mili 0.001, K is kilo 1000 etc).
    /// Any unit may be postfixed by a power.
    /// A typical unit may be "mile/hr" or "Kg.m/s2" etc.
    /// An additive value is only used for non-compound unit conversions (e.g. C to F).
    /// </summary>
    [SmallBasicType]
    public static class LDUnits
    {
        static UnitSystem unitSystem = new UnitSystem();

        /// <summary>
        /// Convert a value from one unit to another.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="fromUnit">The units to convert from.</param>
        /// <param name="toUnit">The units to convert to.</param>
        /// <returns>
        /// The converted value or "FAILED" (usually non-existant unit or invalid conversion).
        /// </returns>
        public static Primitive Convert(Primitive value, Primitive fromUnit, Primitive toUnit)
        {
            double result = unitSystem.Convert(value, fromUnit, toUnit);
            return double.IsNaN(result) ? (Primitive)"FAILED" : (Primitive)result;
        }

        /// <summary>
        /// Get an array of error messages if a Convert fails or conflicts are found for added units or constants.
        /// </summary>
        /// <returns>Array of error messages or "".</returns>
        public static Primitive GetErrors()
        {
            List<string> errors = unitSystem.GetErrors();
            if (errors.Count == 0) return "";
            string result = "";
            int i = 1;
            foreach (string error in errors)
            {
                result += (i++).ToString() + Utilities.ArrayParse(error) + ";";
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get an arrof dimensions for a unit.
        /// </summary>
        /// <param name="unit">The unit to get dimensinsof.</param>
        /// <returns>
        /// An array indexed by dimension and value of the dimension power or "".
        /// </returns>
        public static Primitive GetDimensions(Primitive unit)
        {
            Dictionary<string, double> dimensions = unitSystem.GetDimensions(unit);
            if (dimensions.Count == 0) return "";
            string result = "";
            foreach (KeyValuePair<string, double> kvp in dimensions)
            {
                if (kvp.Value != 0)
                {
                    result += Utilities.ArrayParse(kvp.Key) + "=" + Utilities.ArrayParse(kvp.Value.ToString()) + ";";
                }
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get a list of current base units.
        /// </summary>
        /// <returns>
        /// An array of available base units, indexed by unit name.
        /// The array value is the base unit dimension.
        /// </returns>
        public static Primitive GetBaseUnits()
        {
            Dictionary<string, string> units = unitSystem.GetBaseUnits();

            string result = "";
            foreach (KeyValuePair<string, string> kvp in units)
            {
                result += Utilities.ArrayParse(kvp.Key) + "=" + Utilities.ArrayParse(kvp.Value) + ";";
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get a list of current derived units.
        /// </summary>
        /// <returns>
        /// An array of available derived units, indexed by unit name.
        /// The array value is the base (or derived units) used for conversion.
        /// </returns>
        public static Primitive GetDerivedUnits()
        {
            Dictionary<string, string> units = unitSystem.GetDerivedUnits();

            string result = "";
            foreach (KeyValuePair<string, string> kvp in units)
            {
                result += Utilities.ArrayParse(kvp.Key) + "=" + Utilities.ArrayParse(kvp.Value) + ";";
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get a list of current constants.
        /// </summary>
        /// <returns>An array of available constants, indexed by constant name.
        /// The array value is the constant value.
        /// </returns>
        public static Primitive GetConstants()
        {
            Dictionary<string, string> constants = unitSystem.GetConstants();

            string result = "";
            foreach (KeyValuePair<string, string> kvp in constants)
            {
                result += Utilities.ArrayParse(kvp.Key) + "=" + Utilities.ArrayParse(kvp.Value) + ";";
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get a list of current prefixes.
        /// </summary>
        /// <returns>An array of available prefices, indexed by prefix name.
        /// The array value is the prefix value.
        /// </returns>
        public static Primitive GetPrefixes()
        {
            Dictionary<string, double> prefixes = unitSystem.GetPrefixes();

            string result = "";
            string unit = "";
            foreach (KeyValuePair<string, double> kvp in prefixes)
            {
                if (kvp.Key.Length == 1) unit = kvp.Key + " (";
                else
                {
                    unit += kvp.Key + ")";
                    result += Utilities.ArrayParse(unit) + "=" + (Primitive)kvp.Value + ";";
                }
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Add a base unit to the system.
        /// </summary>
        /// <param name="name">The unit name (be careful it doesn't confict with existing unit names).</param>
        /// <param name="dimension">The base unit dimension (e.g. TEMPERATURE).</param>
        /// <param name="mult">An multiplier term (default 1).</param>
        /// <param name="add">An addition term (default 0).</param>
        public static void AddBaseUnit(Primitive name, Primitive dimension, Primitive mult, Primitive add)
        {
            unitSystem.AddBaseUnit(name, dimension, mult, add);
        }

        /// <summary>
        /// Add a derived unit to the system.
        /// </summary>
        /// <param name="name">The unit name (be careful it doesn't confict with existing unit names).</param>
        /// <param name="units">The derived unit definition.</param>
        /// <param name="add">An ooptional addition term.</param>
        public static void AddDerivedUnit(Primitive name, Primitive units, Primitive add)
        {
            unitSystem.AddDerivedUnit(name, units, add);
        }

        /// <summary>
        /// Add a constant to the system.
        /// </summary>
        /// <param name="name">The constant name (be careful it doesn't confict with existing constant names).</param>
        /// <param name="value">The derived constant value.</param>
        public static void AddConstant(Primitive name, Primitive value)
        {
            unitSystem.AddConstant(name, value);
        }
    }
}
