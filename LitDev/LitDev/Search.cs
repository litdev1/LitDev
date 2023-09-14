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
#endif

using Bing;
using System;
using System.Net;
using LitDev.Engines;

namespace LitDev
{
    /// <summary>
    /// Bing online search methods.
    /// Includes web, image, video, news and spelling suggestions.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDSearch
    {
        private static string bingKey = "USofJjSorAeOFEQ19oS+coNxSholq0Cq4TMc3rY6Y/M";
        private static BingSearchContainer bing = new BingSearchContainer(new Uri("https://api.datamarket.azure.com/Bing/Search/")) { Credentials = new NetworkCredential(bingKey, bingKey) };
        private static Cognitive cognitive = new Cognitive();
        private static bool bNewAPI = true;

        /// <summary>
        /// The maximum number of web search results, default 50.
        /// </summary>
        public static Primitive Count
        {
            get { return cognitive.count; }
            set { cognitive.count = value; }
        }

        /// <summary>
        /// The language culture to use, default is current culture.
        /// es-AR,en-AU,de-AT,nl-BE,fr-BE,pt-BR,en-CA,fr-CA,es-CL,da-DK,fi-FI,fr-FR,de-DE,zh-HK,en-IN,en-ID,en-IE,it-IT,ja-JP,ko-KR,en-MY,es-MX,nl-NL,en-NZ,no-NO,zh-CN,pl-PL,pt-PT,en-PH,ru-RU,ar-SA,en-ZA,es-ES,sv-SE,fr-CH,de-CH,zh-TW,tr-TR,en-GB,en-US,es-US
        /// </summary>
        public static Primitive Language
        {
            get { return cognitive.mkt; }
            set { cognitive.mkt = value; }
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
                    JsonWeb jsonWeb = cognitive.SearchRequest(search);
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
                    var query = bing.Web(search, null, null, cognitive.mkt, null, null, null, null);
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
        /// <returns>An array of results, index url and value description.</returns>
        public static Primitive GetImage(Primitive search)
        {
            try
            {
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = cognitive.SearchRequest(search);
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
                    var query = bing.Image(search, null, cognitive.mkt, null, null, null, null);
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
        /// <returns>An array of results, index url and value description.</returns>
        public static Primitive GetVideo(Primitive search)
        {
            try
            {
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = cognitive.SearchRequest(search);
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
                    var query = bing.Video(search, null, cognitive.mkt, null, null, null, null, null);
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
        /// <returns>An array of results, index url and value description.</returns>
        public static Primitive GetNews(Primitive search)
        {
            try
            {
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = cognitive.SearchRequest(search);
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
                    var query = bing.News(search, null, cognitive.mkt, null, null, null, null, null, null);
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
        /// Do a Bing search for Web spelling or alternative search suggestions.
        /// </summary>
        /// <param name="search">The search text.</param>
        /// <returns>An array of spelling or alternative suggestions or "" if no suggestions found.</returns>
        public static Primitive GetSpelling(Primitive search)
        {
            try
            {
                if (bNewAPI)
                {
                    JsonWeb jsonWeb = cognitive.SearchRequest(search);
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
                    var query = bing.SpellingSuggestions(search, null, cognitive.mkt, null, null, null);
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

        /// <summary>
        /// Do a text spell check (proof).  This is for longer text with more detailed information like in Word.
        /// </summary>
        /// <param name="text">The text to proof.</param>
        /// <param name="mode">A mode "Proof" (default for longer text) or "Spell" (for short or single word checks).</param>
        /// <returns>An array of spelling and other suggestions or "" if no suggestions found.</returns>
        public static Primitive GetProof(Primitive text, Primitive mode)
        {
            try
            {
                eSpellMode spellMode = ((string)mode).ToLower() == "spell" ? eSpellMode.spell : eSpellMode.proof;
                JsonWeb jsonWeb = cognitive.SpellRequest(text, spellMode);
                Primitive result = "";
                int i = 1;

                if (null != jsonWeb.flaggedTokens)
                {
                    foreach (var token in jsonWeb.flaggedTokens)
                    {
                        Primitive check = "";
                        check["token"] = token.token;
                        check["type"] = token.type;
                        check["offset"] = token.offset + 1;
                        if (null != token.suggestions)
                        {
                            Primitive suggestions = "";
                            int j = 1;
                            foreach (var suggestion in token.suggestions)
                            {
                                suggestions[j++] = suggestion.suggestion;
                            }
                            check["suggestions"] = suggestions;
                        }
                        result[i++] = check;
                    }
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