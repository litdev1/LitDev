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

using LitDev.Engines;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using varType = System.Int32;

namespace LitDev
{
    /// <summary>
    /// A general editable unit conversion system.
    /// All units and dimensions are case sensitive.
    /// A base unit consists of a single dimension and name, and are all independent.
    /// A derived unit consists of a description, name and units definition consisting of base or other derived units, and optional additive term, usually 0.
    /// A unit is parsed by separting . / + - and *, then recursively resolving derived unit conversions, bracketed () terms first.
    /// Values (especially those with a decimal point '.' or minus '-') should be contained in ().
    /// A unit may be prefixed by a prefix or number value (e.g. m is mili 0.001, K is kilo 1000 etc).
    /// Any unit may be postfixed by a power.
    /// A typical unit may be "mile/hr", "m/s2" or "MJ/day" etc and can be any combination of base and derived units.
    /// Any pair of unis that are dimensionally the same can be converted.
    /// An additive value is only used for non-compound unit conversions (e.g. C to F).
    /// To avoid obscure prefix unit conflicts use a full prefix name (e.g. min could be 60 seconds or 0.001 inches, the latter should be milliin).  
    /// Currency conversions are updated daily.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
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
        /// The converted value or "FAILED" (usually non-existant unit or inconsistant dimensions).
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

            return Utilities.CreateArrayMap(errors.ToPrimitiveArray());
        }

        /// <summary>
        /// Get an array of dimensions for a unit.
        /// </summary>
        /// <param name="unit">The unit to get dimensins of.</param>
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
                    result += Utilities.ArrayParse(kvp.Key) + "=" + Utilities.ArrayParse(kvp.Value.ToString(CultureInfo.InvariantCulture)) + ";";
                }
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get a list of current base units.
        /// </summary>
        /// <returns>
        /// An array of available base units, indexed by unit dimension.
        /// The array values are the base unit names.
        /// </returns>
        public static Primitive GetBaseUnits()
        {
            Dictionary<string, string> units = unitSystem.GetBaseUnits();

            string result = "";
            foreach (KeyValuePair<string, string> kvp in units)
            {
                result += Utilities.ArrayParse(kvp.Key) + "=" + Utilities.ArrayParse(kvp.Value.ToString(CultureInfo.InvariantCulture)) + ";";
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get a list of current derived units.
        /// </summary>
        /// <returns>
        /// An array of available derived units, indexed by unit name with (description).
        /// The array values are the base (or derived units) used for conversion.
        /// </returns>
        public static Primitive GetDerivedUnits()
        {
            Dictionary<string, string> units = unitSystem.GetDerivedUnits();

            string result = "";
            foreach (KeyValuePair<string, string> kvp in units)
            {
                result += Utilities.ArrayParse(kvp.Key) + "=" + Utilities.ArrayParse(kvp.Value.ToString(CultureInfo.InvariantCulture)) + ";";
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Get a list of current constants.
        /// </summary>
        /// <returns>An array of available constants, indexed by constant name with (description).
        /// The array values are the constant values.
        /// </returns>
        public static Primitive GetConstants()
        {
            Dictionary<string, string> constants = unitSystem.GetConstants();

            string result = "";
            foreach (KeyValuePair<string, string> kvp in constants)
            {
                result += Utilities.ArrayParse(kvp.Key) + "=" + Utilities.ArrayParse(kvp.Value.ToString(CultureInfo.InvariantCulture)) + ";";
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
                    result += Utilities.ArrayParse(unit) + "=" + (Primitive)kvp.Value.ToString(CultureInfo.InvariantCulture) + ";";
                }
            }

            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Add a base unit to the system.
        /// </summary>
        /// <param name="dimension">The base unit dimension (e.g. TEMPERATURE).</param>
        /// <param name="name">The unit name (be careful it doesn't confict with existing unit names).</param>
        public static void AddBaseUnit(Primitive dimension, Primitive name)
        {
            unitSystem.AddBaseUnit(dimension, name);
        }

        /// <summary>
        /// Add a derived unit to the system.
        /// </summary>
        /// <param name="description">An optional long name or description of the derived unit.</param>
        /// <param name="name">The unit name (be careful it doesn't confict with existing unit names).</param>
        /// <param name="units">The derived unit definition.</param>
        /// <param name="add">An optional addition term.</param>
        public static void AddDerivedUnit(Primitive description, Primitive name, Primitive units, Primitive add)
        {
            unitSystem.AddDerivedUnit(description, name, units, add);
        }

        /// <summary>
        /// Add a dimensionless constant to the system.
        /// </summary>
        /// <param name="description">An optional long name or description of the constant.</param>
        /// <param name="name">The constant name (be careful it doesn't confict with existing constant names).</param>
        /// <param name="value">The derived constant value.</param>
        public static void AddConstant(Primitive description, Primitive name, Primitive value)
        {
            unitSystem.AddConstant(description, name, value);
        }

        /// <summary>
        /// Export the current unit system to a file (units.txt in the current program folder).
        /// </summary>
        public static void Export()
        {
            string fileName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\units.txt";
            unitSystem.Serialise(fileName, true);
        }

        /// <summary>
        /// Import a unit system from a file (units.txt in the current program folder).
        /// </summary>
        public static void Import()
        {
            string fileName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\units.txt";
            unitSystem.Serialise(fileName, false);
        }
    }
}
