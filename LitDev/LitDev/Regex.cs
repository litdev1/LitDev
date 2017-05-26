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

using System.Text;
using Microsoft.SmallBasic.Library;
using System.Text.RegularExpressions;

namespace LitDev
{
    /// <summary>
    /// Regex (regular expression) text manipulation utilities.
    /// </summary>
    [SmallBasicType]
    public static class LDRegex
    {
        /// <summary>
        /// Perform a regex match.
        /// </summary>
        /// <param name="input">The input string to perform the match on (unaltered).</param>
        /// <param name="pattern">The regex pattern string.</param>
        /// <param name="caseSensitive">If the regex match is case sensitive ("True" or "False").</param>
        /// <returns>An array of match values, indexed by the location index in the input (position).</returns>
        public static Primitive Match(Primitive input, Primitive pattern, Primitive caseSensitive)
        {
            StringBuilder result = new StringBuilder();
            if (caseSensitive)
            {
                foreach (Match match in Regex.Matches((string)input, (string)pattern))
                {
                    result.AppendFormat("{0}={1};", (match.Index + 1), Utilities.ArrayParse(match.Value));
                }
            }
            else
            {
                foreach (Match match in Regex.Matches((string)input, (string)pattern, RegexOptions.IgnoreCase))
                {
                    result.AppendFormat("{0}={1};", (match.Index + 1), Utilities.ArrayParse(match.Value));
                }
            }
            return Utilities.CreateArrayMap(result.ToString());
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

