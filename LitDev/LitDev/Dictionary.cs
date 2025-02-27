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

using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Net;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using Microsoft.JScript;


namespace LitDev
{
    /// <summary>
    /// This class provides access to an online Dictionary service.
    /// Alternative for Version 1.0 Dictionary object that fails.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDDictionary
    {
        static LDDictionary()
        {
            Instance.Verify();
        }

        private const string _frenchGuid = "{92DF305E-677C-43D1-9FC7-B2A3D08DCA5C}";
        private const string _englishGuid = "{FEF89077-4F4D-4803-A8BF-228083F70EAA}";
        private const string _spanishGuid = "{FDB3E101-5014-44BE-AA64-BD0E5B55B3B7}";
        private const string _queryXml = "<QueryPacket xmlns='urn:Microsoft.Search.Query' revision='1' >\r\n                                   <Query domain='{2}'>\r\n                                     <Context>\r\n                                       <QueryText type='STRING' language='en-us' >{0}</QueryText>\r\n                                       <LanguagePreference>en-us</LanguagePreference>\r\n                                     </Context>\r\n                                     <OfficeContext xmlns='urn:Microsoft.Search.Query.Office.Context' revision='1'>\r\n                                       <UserPreferences>\r\n                                         <ParentalControl>false</ParentalControl>\r\n                                       </UserPreferences>\r\n                                       <ServiceData>{1}</ServiceData>\r\n                                       <ApplicationContext>\r\n                                         <Name>Microsoft Office Word</Name>\r\n                                         <Version>(14.0.3524)</Version>\r\n                                       </ApplicationContext>\r\n                                       <QueryLanguage>en-us</QueryLanguage>\r\n                                       <KeyboardLanguage>en-us</KeyboardLanguage>\r\n                                    </OfficeContext>\r\n                                   </Query>\r\n                                 </QueryPacket>";
        
        private static string url = "https://rr.office.microsoft.com/Research/query.asmx";
        private static string GetDefinition(string word, string serviceCode, string langGuid)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                OfficeResearch officeResearch = new OfficeResearch();
                officeResearch.Url = url;
                string q = string.Format(_queryXml, word, serviceCode, langGuid);
                string s = officeResearch.Query(q);
                XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(s));
                xmlTextReader.WhitespaceHandling = WhitespaceHandling.Significant;
                if (xmlTextReader.ReadToDescendant("Content"))
                {
                    XmlReader xmlReader = xmlTextReader.ReadSubtree();
                    while (xmlReader.Read())
                    {
                        string name;
                        if ((name = xmlReader.Name) != null)
                        {
                            if (name == "Heading" || name == "Line" || name == "P")
                            {
                                stringBuilder.AppendLine();
                                continue;
                            }
                            if (name == "Char" || name == "Text")
                            {
                                if (xmlReader.NodeType == XmlNodeType.Element)
                                {
                                    stringBuilder.Append(" ");
                                    continue;
                                }
                                continue;
                            }
                        }
                        if (xmlReader.NodeType == XmlNodeType.Text)
                        {
                            stringBuilder.Append(xmlReader.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return stringBuilder.ToString();
        }

        private static string api = "https://api.dictionaryapi.dev/api/v2/entries/"; // en/hello
        private static string wordnikURL = "http://api.wordnik.com/v4/word.json/{0}/definitions?limit=20&includeRelated=false&sourceDictionaries=all&useCanonical=true&includeTags=false&api_key=j001kafeiltiu6qv9y9ra7lyxbqk02py7vzwh9d19tdqiu44z";

        private static string GetDefinition(string word, string lang)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StreamReader streamReader = null;
            WebResponse webResponse = null;
            try
            {
                string url = string.Format(wordnikURL, word.ToLower());
                //string url = api + lang + "/" + word;

                LDNetwork.SetSSL();
                WebRequest webRequest = WebRequest.Create(url);
                webResponse = webRequest.GetResponse();
                streamReader = new StreamReader(webResponse.GetResponseStream());
                string result = streamReader.ReadToEnd();
                streamReader.Close();

                JToken jToken = JToken.Parse(result);

                foreach (JToken entry in jToken)
                {
                    if (null != entry["text"])
                    {
                        stringBuilder.Append(entry["text"]);
                        stringBuilder.AppendLine();
                    }
                }

                //result = result.Substring(1, result.Length - 2);
                //JObject jsonObject = JObject.Parse(result);

                //var definitions = jsonObject.SelectTokens("$..definition", false).ToList();
                //foreach (JToken definition in definitions)
                //{
                //    stringBuilder.Append(definition);
                //    stringBuilder.AppendLine();
                //}
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return stringBuilder.ToString();
        }


        [HideFromIntellisense]
        public static Primitive Url
        {
            get { return url; }
            set { url = value; }
        }

        /// <summary>
        /// Gets the definition of a word, in English.
        /// </summary>
        /// <param name="word">
        /// The word to define.
        /// </param>
        /// <returns>
        /// The definition(s) of the specified word.
        /// </returns>
        public static Primitive GetDefinition(Primitive word)
        {
            return GetDefinition(word, "en");
            //return LDDictionary.GetDefinition(word, "EDICT", _englishGuid);
        }

        /// <summary>
        /// Gets the definition of a word, in French.
        /// </summary>
        /// <param name="word">
        /// The word to define.
        /// </param>
        /// <returns>
        /// The definition(s) of the specified word.
        /// </returns>
        [HideFromIntellisense]
        public static Primitive GetDefinitionInFrench(Primitive word)
        {
            return GetDefinition(word, "fr");
            //return LDDictionary.GetDefinition(word, "FDICT", _frenchGuid);
        }

        /// <summary>
        /// Gets the definition of a word, in Spanish.
        /// </summary>
        /// <param name="word">
        /// The word to define.
        /// </param>
        /// <returns>
        /// The definition(s) of the specified word.
        /// </returns>
        [HideFromIntellisense]
        public static Primitive GetDefinitionInSpanish(Primitive word)
        {
            return GetDefinition(word, "es");
            //return LDDictionary.GetDefinition(word, "SDICT", _spanishGuid);
        }
    }
}
