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
using System.Xml;

namespace LitDev
{
    class Detail
    {
        public string city = "";
        public string dayOfWeek = "";
        public string condition = "";
        public string tempF = "";
        public string tempC = "";
        public string humidity = "";
        public string windDirection = "";
        public string windSpeed = "";
        public string high = "";
        public string low = "";
    }

    /// <summary>
    /// Get local weather conditions.
    /// </summary>
    [SmallBasicType]
    [HideFromIntellisense]
    public static class LDWeather
    {
        private static List<Detail> Details = new List<Detail>();

        private static void SetForecast(string location)
        {
            Details.Clear();

            try
            {
                XmlDocument xmlConditions = new XmlDocument();
                xmlConditions.Load("http://www.google.com/ig/api?weather=" + location);

                if (null == xmlConditions.SelectSingleNode("xml_api_reply/weather/problem_cause"))
                {
                    foreach (XmlNode node in xmlConditions.SelectNodes("/xml_api_reply/weather/forecast_conditions"))
                    {
                        Detail condition = new Detail();

                        condition.city = xmlConditions.SelectSingleNode("/xml_api_reply/weather/forecast_information/city").Attributes["data"].InnerText;
                        condition.tempC = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/temp_c").Attributes["data"].InnerText;
                        condition.tempF = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/temp_f").Attributes["data"].InnerText;
                        string humidity = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/humidity").Attributes["data"].InnerText.Substring(10);
                        condition.humidity = humidity.Substring(0, humidity.Length - 1);
                        string wind = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/wind_condition").Attributes["data"].InnerText.Substring(6);
                        int i = wind.IndexOf("at");
                        int j = wind.IndexOf("mph");
                        condition.windDirection = wind.Substring(0, i - 1);
                        condition.windSpeed = wind.Substring(i + 3, j - i - 4);

                        condition.condition = node.SelectSingleNode("condition").Attributes["data"].InnerText;
                        condition.high = node.SelectSingleNode("high").Attributes["data"].InnerText;
                        condition.low = node.SelectSingleNode("low").Attributes["data"].InnerText;
                        condition.dayOfWeek = node.SelectSingleNode("day_of_week").Attributes["data"].InnerText;

                        Details.Add(condition);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get weather conditions for a location.
        /// This must be called before current condition details can be obtained.
        /// </summary>
        /// <param name="location">A location, could be a town/city or zip/postcode.</param>
        /// <returns>An array containing a 4 day forecast or "FAILED".</returns>
        public static Primitive Forecast(Primitive location)
        {
            SetForecast(location);

            Primitive forecast = "";
            int i = 1;
            foreach (Detail detail in Details)
            {
                forecast[i++] = detail.dayOfWeek + " " + detail.condition + " (" + detail.low + "F to " + detail.high + "F)";
            }
            return Details.Count == 0 ? "FAILED" : (string)forecast;
        }

        /// <summary>
        /// Current location.
        /// </summary>
        public static Primitive Location { get { return Details.Count == 0 ? "" : Details[0].city; } }

        /// <summary>
        /// Current conditions.
        /// </summary>
        public static Primitive Conditions { get { return Details.Count == 0 ? "" : Details[0].condition; } }

        /// <summary>
        /// Current temperature (Celcius).
        /// </summary>
        public static Primitive TempC { get { return Details.Count == 0 ? "" : Details[0].tempC; } }

        /// <summary>
        /// Current temperature (Farenheight).
        /// </summary>
        public static Primitive TempF { get { return Details.Count == 0 ? "" : Details[0].tempF; } }

        /// <summary>
        /// Current humidity (%)
        /// </summary>
        public static Primitive Humidity { get { return Details.Count == 0 ? "" : Details[0].humidity; } }

        /// <summary>
        /// Current wind direction.
        /// </summary>
        public static Primitive WindDirection { get { return Details.Count == 0 ? "" : Details[0].windDirection; } }

        /// <summary>
        /// Current wind speed (mph).
        /// </summary>
        public static Primitive WindSpeed { get { return Details.Count == 0 ? "" : Details[0].windSpeed; } }
    }
}
