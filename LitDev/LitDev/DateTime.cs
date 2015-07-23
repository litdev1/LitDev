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
using System;
using System.Globalization;

namespace LitDev
{
    /// <summary>
    /// Time and Date conversion.
    /// 
    /// The date format is "25/01/2012 22:18:52", the time part is optional.
    /// The date part will be dependent on your locale, e.g. in US it will be "01/25/2012 22:18:52".
    /// 
    /// An OADate is the number of days (and part days) since 30 December 1899, allowing dates to be added or subtracted.
    /// </summary>
    [SmallBasicType]
    public static class LDDateTime
    {
        /// <summary>
        /// The current date and time.
        /// </summary>
        /// <returns>
        /// The current date and time.
        /// 
        /// The format is "25/01/2012 22:18:52", the time part is optional.
        /// The date part will be dependent on your locale, e.g. in US it will be "01/25/2012 22:18:52".
        /// </returns>
        /// 
        public static Primitive Now()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// The current OADate.
        /// </summary>
        /// <returns>
        /// The number of days (and part days) since 30 December 1899 (OADate).
        /// </returns>
        public static Primitive NowOADate()
        {
            return ToOADate(DateTime.Now);
        }

        /// <summary>
        /// Calculate a date from input date and an offset in days.
        /// </summary>
        /// <param name="date">The input date.</param>
        /// <param name="offset">An offset in days.</param>
        /// <returns>
        /// A date equivalent to the input date + offset.
        /// 
        /// The format is "25/01/2012 22:18:52", the time part is optional.
        /// The date part will be dependent on your locale, e.g. in US it will be "01/25/2012 22:18:52".
        /// </returns>
        public static Primitive Add(Primitive date, Primitive offset)
        {
            try
            {
                return FromOADate(ToOADate(date) + offset);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return date;
            }
        }

        /// <summary>
        /// Calculate a number of days between two dates.
        /// </summary>
        /// <param name="date1">The input date1.</param>
        /// <param name="date2">The input date2.</param>
        /// <returns>
        /// The number of days (and part days) between the dates (date1-date2).
        /// </returns>
        public static Primitive Subtract(Primitive date1, Primitive date2)
        {
            try
            {
                return ToOADate(date1) - ToOADate(date2);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return 0;
            }
        }

        /// <summary>
        /// Convert date string to OADate.
        /// </summary>
        /// <param name="date">
        /// The date string to convert.
        /// 
        /// The format is "25/01/2012 22:18:52", the time part is optional.
        /// The date part will be dependent on your locale, e.g. in US it will be "01/25/2012 22:18:52".
        /// </param>
        /// <returns>
        /// The number of days (and part days) since 30 December 1899 (OADate).
        /// </returns>
        public static Primitive ToOADate(Primitive date)
        {
            try
            {
                return DateTime.Parse(date).ToOADate();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Convert OADate to date string.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate to convert.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The date string.
        /// 
        /// The format is "25/01/2012 22:18:52", the time part is optional.
        /// The date part will be dependent on your locale, e.g. in US it will be "01/25/2012 22:18:52".
        /// </returns>
        public static Primitive FromOADate(Primitive OAdate)
        {
            try
            {
                return DateTime.FromOADate(OAdate).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Create OADate from date and time values.
        /// </summary>
        /// <param name="year">
        /// The year.
        /// </param>
        /// <param name="month">
        /// The month.
        /// </param>
        /// <param name="day">
        /// The day.
        /// </param>
        /// <param name="hour">
        /// The hour.
        /// </param>
        /// <param name="minute">
        /// The minute.
        /// </param>
        /// <param name="second">
        /// The second.
        /// </param>
        /// <returns>
        /// The number of days (and part days) since 30 December 1899 (OADate).
        /// </returns>
        public static Primitive OADate(Primitive year, Primitive month, Primitive day, Primitive hour, Primitive minute, Primitive second)
        {
            try
            {
                return new DateTime(year, month, day, hour, minute, second).ToOADate();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get year from OADate.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The year.
        /// </returns>
        public static Primitive GetYear(Primitive OAdate)
        {
            try
            {
                return DateTime.FromOADate(OAdate).Year;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get month from OADate.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The month.
        /// </returns>
        public static Primitive GetMonth(Primitive OAdate)
        {
            try
            {
                return DateTime.FromOADate(OAdate).Month;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get day of the month from OADate.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The month.
        /// </returns>
        public static Primitive GetDay(Primitive OAdate)
        {
            try
            {
                return DateTime.FromOADate(OAdate).Day;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
            
        /// <summary>
        /// Get hour from OADate.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The hour.
        /// </returns>
        public static Primitive GetHour(Primitive OAdate)
        {
            try
            {
                return DateTime.FromOADate(OAdate).Hour;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get minute from OADate.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The minute.
        /// </returns>
        public static Primitive GetMinute(Primitive OAdate)
        {
            try
            {
                return DateTime.FromOADate(OAdate).Minute;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get second from OADate.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The second.
        /// </returns>
        public static Primitive GetSecond(Primitive OAdate)
        {
            int second = 0;
            try
            {
                second = DateTime.FromOADate(OAdate).Second;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return second;
        }

        /// <summary>
        /// Get day of the week from OADate.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The day name.
        /// </returns>
        public static Primitive GetDayName(Primitive OAdate)
        {
            try
            {
                return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.FromOADate(OAdate).DayOfWeek);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Get month name from OADate.
        /// </summary>
        /// <param name="OAdate">
        /// The OADate.
        /// 
        /// The number of days since 30 December 1899 (OADate).
        /// </param>
        /// <returns>
        /// The month name.
        /// </returns>
        public static Primitive GetMonthName(Primitive OAdate)
        {
            try
            {
                return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.FromOADate(OAdate).Month);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
    }
}
