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

using Bing;
using Microsoft.SmallBasic.Library;
using System;
using System.Net;

namespace LitDev
{
    /// <summary>
    /// Bing online search methods.
    /// Includes web, image, video, news and spelling suggestions.
    /// </summary>
    [SmallBasicType]
    public static class LDSearch
    {
        private static string bingKey = "USofJjSorAeOFEQ19oS+coNxSholq0Cq4TMc3rY6Y/M";
        private static BingSearchContainer bing = new BingSearchContainer(new Uri("https://api.datamarket.azure.com/Bing/Search/")) { Credentials = new NetworkCredential(bingKey, bingKey) };

        /// <summary>
        /// Do a Bing search for Web sites.
        /// </summary>
        /// <param name="search">The search text.</param>
        /// <returns>An array (up to  50) of results, index url and value description.</returns>
        public static Primitive GetWeb(Primitive search)
        {
            try
            {
                var query = bing.Web(search, null, null, null, null, null, null, null);
                var sites = query.Execute();

                string result = "";
                foreach (var site in sites)
                {
                    result += Utilities.ArrayParse(site.Url) + "=" + Utilities.ArrayParse(site.Description) + ";";
                }

                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
 
        /// <summary>
        /// Do a Bing search for Web images.
        /// </summary>
        /// <param name="search">The search text.</param>
        /// <returns>An array (up to 50) of results, index url and value description.</returns>
        public static Primitive GetImage(Primitive search)
        {
            try
            {
                var query = bing.Image(search, null, null, null, null, null, null);
                var sites = query.Execute();

                string result = "";
                foreach (var site in sites)
                {
                    result += Utilities.ArrayParse(site.MediaUrl) + "=" + Utilities.ArrayParse(site.Title) + ";";
                }

                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Do a Bing search for Web videos.
        /// </summary>
        /// <param name="search">The search text.</param>
        /// <returns>An array (up to 50) of results, index url and value description.</returns>
        public static Primitive GetVideo(Primitive search)
        {
            try
            {
                var query = bing.Video(search, null, null, null, null, null, null, null);
                var sites = query.Execute();

                string result = "";
                foreach (var site in sites)
                {
                    result += Utilities.ArrayParse(site.MediaUrl) + "=" + Utilities.ArrayParse(site.Title) + ";";
                }

                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Do a Bing search for Web news.
        /// </summary>
        /// <param name="search">The search text.</param>
        /// <returns>An array (up to 15) of results, index url and value description.</returns>
        public static Primitive GetNews(Primitive search)
        {
            try
            {
                var query = bing.News(search, null, null, null, null, null, null, null, null);
                var sites = query.Execute();

                string result = "";
                foreach (var site in sites)
                {
                    result += Utilities.ArrayParse(site.Url) + "=" + Utilities.ArrayParse(site.Description) + ";";
                }

                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Do a Bing search for Web spelling suggestions.
        /// </summary>
        /// <param name="search">The search text.</param>
        /// <returns>An array of spelling suggestions or none if spelling is correct or no suggestions found.</returns>
        public static Primitive GetSpelling(Primitive search)
        {
            try
            {
                var query = bing.SpellingSuggestions(search, null, null, null, null, null);
                var sites = query.Execute();

                string result = "";
                int i = 1;
                foreach (var site in sites)
                {
                    result += (i++).ToString() + "=" + Utilities.ArrayParse(site.Value) + ";";
                }

                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
    }
}