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
using System.Net.Http;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Collections.Specialized;

namespace LitDev
{
    [DataContract]
    public class JsonWeb
    {
        [DataMember]
        public JsonWebPages webPages;

        [DataMember]
        public JsonImages images;

        [DataMember]
        public JsonNews news;

        [DataMember]
        public JsonVideos videos;

        [DataMember]
        public JsonRelatedSearches relatedSearches;

        [DataMember]
        public JsonSpellSuggestions spellSuggestions;
    }

    [DataContract]
    public class JsonWebPages
    {
        [DataMember]
        public List<JsonValue> value;
    }

    [DataContract]
    public class JsonImages
    {
        [DataMember]
        public List<JsonValue> value;
    }

    [DataContract]
    public class JsonNews
    {
        [DataMember]
        public List<JsonValue> value;
    }

    [DataContract]
    public class JsonVideos
    {
        [DataMember]
        public List<JsonValue> value;
    }

    [DataContract]
    public class JsonRelatedSearches
    {
        [DataMember]
        public List<JsonValue> value;
    }

    [DataContract]
    public class JsonSpellSuggestions
    {
        [DataMember]
        public List<JsonValue> value;
    }

    [DataContract]
    public class JsonValue
    {
        [DataMember]
        public string name;

        [DataMember]
        public string text;

        [DataMember]
        public string description;

        [DataMember]
        public string url;

        [DataMember]
        public string contentUrl;
    }

    /// <summary>
    /// Bing online search methods.
    /// Includes web, image, video, news and spelling suggestions.
    /// </summary>
    [SmallBasicType]
    public static class LDSearch
    {
        private static string bingKey = "USofJjSorAeOFEQ19oS+coNxSholq0Cq4TMc3rY6Y/M";
        private static BingSearchContainer bing = new BingSearchContainer(new Uri("https://api.datamarket.azure.com/Bing/Search/")) { Credentials = new NetworkCredential(bingKey, bingKey) };

        private static HttpClient client = new HttpClient();
        private static NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty); private static DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(JsonWeb));
        private static int count = 50;
        private static string mkt = CultureInfo.CurrentCulture.Name;
        private static bool bNewAPI = true;

        private static JsonWeb MakeRequest(string search)
        {
            // Request headers
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "7689c5090e5d425e979e7edb9d8feb64");

            // Web Request parameters
            queryString["q"] = search;
            queryString["count"] = count.ToString();
            queryString["offset"] = "0";
            queryString["mkt"] = mkt;
            queryString["safesearch"] = "Moderate";
            string uri = "https://api.cognitive.microsoft.com/bing/v5.0/search?" + queryString;

            HttpResponseMessage response = client.GetAsync(uri).Result;
            Stream stream = response.Content.ReadAsStreamAsync().Result;
            return (JsonWeb)jsonSerializer.ReadObject(stream);
        }

        /// <summary>
        /// The maximum number of results, default 50.
        /// </summary>
        public static Primitive Count
        {
            get { return count; }
            set { count = value; }
        }


        /// <summary>
        /// The language culture to use, default is current culture.
        /// es-AR,en-AU,de-AT,nl-BE,fr-BE,pt-BR,en-CA,fr-CA,es-CL,da-DK,fi-FI,fr-FR,de-DE,zh-HK,en-IN,en-ID,en-IE,it-IT,ja-JP,ko-KR,en-MY,es-MX,nl-NL,en-NZ,no-NO,zh-CN,pl-PL,pt-PT,en-PH,ru-RU,ar-SA,en-ZA,es-ES,sv-SE,fr-CH,de-CH,zh-TW,tr-TR,en-GB,en-US,es-US
        /// </summary>
        public static Primitive Language
        {
            get { return mkt; }
            set { mkt = value; }
        }

        /// <summary>
        /// Do a Bing search for Web sites.
        /// </summary>
        /// <param name="search">The search text.</param>
        /// <returns>An array (up to  50) of results, index url and value description.</returns>
        public static Primitive GetWeb(Primitive search)
        {
            try
            {
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = MakeRequest(search);
                    if (null == jsonWeb.webPages) return "";

                    string result = "";
                    foreach (var site in jsonWeb.webPages.value)
                    {
                        result += Utilities.ArrayParse(site.url) + "=" + Utilities.ArrayParse(site.name) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
                else
                {
                    var query = bing.Web(search, null, null, mkt, null, null, null, null);
                    var sites = query.Execute();

                    string result = "";
                    foreach (var site in sites)
                    {
                        result += Utilities.ArrayParse(site.Url) + "=" + Utilities.ArrayParse(site.Description) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
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
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = MakeRequest(search);
                    if (null == jsonWeb.images) return "";

                    string result = "";
                    foreach (var site in jsonWeb.images.value)
                    {
                        result += Utilities.ArrayParse(site.contentUrl) + "=" + Utilities.ArrayParse(site.name) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
                else
                {
                    var query = bing.Image(search, null, mkt, null, null, null, null);
                    var sites = query.Execute();

                    string result = "";
                    foreach (var site in sites)
                    {
                        result += Utilities.ArrayParse(site.MediaUrl) + "=" + Utilities.ArrayParse(site.Title) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
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
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = MakeRequest(search);
                    if (null == jsonWeb.videos) return "";

                    string result = "";
                    foreach (var site in jsonWeb.videos.value)
                    {
                        result += Utilities.ArrayParse(site.contentUrl) + "=" + Utilities.ArrayParse(site.name) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
                else
                {
                    var query = bing.Video(search, null, mkt, null, null, null, null, null);
                    var sites = query.Execute();

                    string result = "";
                    foreach (var site in sites)
                    {
                        result += Utilities.ArrayParse(site.MediaUrl) + "=" + Utilities.ArrayParse(site.Title) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
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
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = MakeRequest(search);
                    if (null == jsonWeb.news) return "";

                    string result = "";
                    foreach (var site in jsonWeb.news.value)
                    {
                        result += Utilities.ArrayParse(site.url) + "=" + Utilities.ArrayParse(site.name) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
                else
                {
                    var query = bing.News(search, null, mkt, null, null, null, null, null, null);
                    var sites = query.Execute();

                    string result = "";
                    foreach (var site in sites)
                    {
                        result += Utilities.ArrayParse(site.Url) + "=" + Utilities.ArrayParse(site.Description) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Do a Bing search for Web spelling or alternative suggestions.
        /// </summary>
        /// <param name="search">The search text.</param>
        /// <returns>An array of spelling or alternative suggestions or none if no suggestions found.</returns>
        public static Primitive GetSpelling(Primitive search)
        {
            try
            {
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = MakeRequest(search);
                    string result = "";
                    int i = 1;

                    if (null != jsonWeb.spellSuggestions)
                    {
                        foreach (var site in jsonWeb.spellSuggestions.value)
                        {
                            result += (i++).ToString() + "=" + Utilities.ArrayParse(site.text) + ";";
                        }
                    }
                    if (null != jsonWeb.relatedSearches)
                    {
                        foreach (var site in jsonWeb.relatedSearches.value)
                        {
                            result += (i++).ToString() + "=" + Utilities.ArrayParse(site.text) + ";";
                        }
                    }
                    return Utilities.CreateArrayMap(result);
                }
                else
                {
                    var query = bing.SpellingSuggestions(search, null, mkt, null, null, null);
                    var sites = query.Execute();

                    string result = "";
                    int i = 1;
                    foreach (var site in sites)
                    {
                        result += (i++).ToString() + "=" + Utilities.ArrayParse(site.Value) + ";";
                    }
                    return Utilities.CreateArrayMap(result);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }
    }
}