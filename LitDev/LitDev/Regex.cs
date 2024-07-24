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

using System.Text.RegularExpressions;

namespace LitDev
{
    /// <summary>
    /// Regex (regular expression) text manipulation utilities.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDRegex
    {
        static LDRegex()
        {
            Instance.Verify();
        }

        /// <summary>
        /// Perform a regex match.
        /// </summary>
        /// <param name="input">The input string to perform the match on (unaltered).</param>
        /// <param name="pattern">The regex pattern string.</param>
        /// <param name="caseSensitive">If the regex match is case sensitive ("True" or "False").</param>
        /// <returns>An array of match values, indexed by the location index in the input (position).</returns>
        public static Primitive Match(Primitive input, Primitive pattern, Primitive caseSensitive)
        {
            string result = "";
            if (caseSensitive)
            {
                foreach (Match match in Regex.Matches((string)input, (string)pattern))
                {
                    result += (match.Index + 1) + "=" + Utilities.ArrayParse(match.Value) + ";";
                }
            }
            else
            {
                foreach (Match match in Regex.Matches((string)input, (string)pattern, RegexOptions.IgnoreCase))
                {
                    result += (match.Index + 1) + "=" + Utilities.ArrayParse(match.Value) + ";";
                }
            }
            return Utilities.CreateArrayMap(result);
        }

        /// <summary>
        /// Perform a regex find and replace.
        /// </summary>
        /// <param name="input">The input string to perform the replacement on (unaltered).</param>
        /// <param name="pattern">The regex pattern string.</param>
        /// <param name="replacement">The regex replacement string.</param>
        /// <param name="caseSensitive">If the regex replace is case sensitive ("True" or "False").</param>
        /// <returns>A modified version of the input string after the regex replace.</returns>
        public static Primitive Replace(Primitive input, Primitive pattern, Primitive replacement, Primitive caseSensitive)
        {
            if (caseSensitive)
            {
                return Regex.Replace((string)input, (string)pattern, (string)replacement);
            }
            else
            {
                return Regex.Replace((string)input, (string)pattern, (string)replacement, RegexOptions.IgnoreCase);
            }
        }
    }
}

