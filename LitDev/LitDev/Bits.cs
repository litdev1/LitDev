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
using varType = System.Int32;

namespace LitDev
{
    /// <summary>
    /// Bitwise logic to store binary flags in a single number as bits.
    /// A 32 bit number is used internally.
    /// This is like a 32 dimension array of 1s and 0s stored in single number.
    /// The bits (0 to 31) are indexed from 0.
    /// </summary>
    [SmallBasicType]
    public static class LDBits
    {
        private static varType one = (varType)1;

        /// <summary>
        /// Set a bit in a number.
        /// </summary>
        /// <param name="var">The number to set the bit.</param>
        /// <param name="bit">A zero indexed bit to set (0 to 31).</param>
        /// <returns>The modified number with bit set.</returns>
        public static Primitive SetBit(Primitive var, Primitive bit)
        {
            try
            {
                return (varType)var | (one << bit);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Unset a bit in a number.
        /// </summary>
        /// <param name="var">The number to unset the bit.</param>
        /// <param name="bit">A zero indexed bit to unset (0 to 31).</param>
        /// <returns>The modified number with bit unset.</returns>
        public static Primitive UnsetBit(Primitive var, Primitive bit)
        {
            try
            {
                return (varType)var & ~(one << bit);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get the bit value in a number.
        /// </summary>
        /// <param name="var">The number to test.</param>
        /// <param name="bit">A zero indexed bit to test (0 to 31).</param>
        /// <returns>0 (unset) or 1 (set).</returns>
        public static Primitive GetBit(Primitive var, Primitive bit)
        {
            try
            {
                return ((varType)var & (one << bit)) == 0 ? 0 : 1;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Logically Not a number.
        /// </summary>
        /// <param name="var">The number to Not.</param>
        /// <returns>The Not number (all bits reversed).</returns>
        public static Primitive Not(Primitive var)
        {
            try
            {
                return ~(varType)var;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Logically And 2 numbers.
        /// </summary>
        /// <param name="var1">The first number.</param>
        /// <param name="var2">The second number.</param>
        /// <returns>The And number (where both input bits are set).</returns>
        public static Primitive AndBits(Primitive var1, Primitive var2)
        {
            try
            {
                return (varType)var1 & (varType)var2;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Logically Or 2 numbers.
        /// </summary>
        /// <param name="var1">The first number.</param>
        /// <param name="var2">The second number.</param>
        /// <returns>The Or number (where either input bits are set).</returns>
        public static Primitive OrBits(Primitive var1, Primitive var2)
        {
            try
            {
                return (varType)var1 | (varType)var2;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Logically XOr 2 numbers.
        /// </summary>
        /// <param name="var1">The first number.</param>
        /// <param name="var2">The second number.</param>
        /// <returns>The XOr number (where exclusively either input bits are set).</returns>
        public static Primitive XOrBits(Primitive var1, Primitive var2)
        {
            try
            {
                return (varType)var1 ^ (varType)var2;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
    }
}
