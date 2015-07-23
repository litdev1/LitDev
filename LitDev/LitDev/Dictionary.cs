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
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Linq;

namespace LitDev
{    
    /// <summary>
    /// This class provides access to an online Dictionary service.
    /// Alternative for Version 1.0 Dictionary object that fails.
    /// </summary>
    [SmallBasicType]
    public static class LDDictionary
    {
        private const string _frenchGuid = "{92DF305E-677C-43D1-9FC7-B2A3D08DCA5C}";
        private const string _englishGuid = "{FEF89077-4F4D-4803-A8BF-228083F70EAA}";
        private const string _spanishGuid = "{FDB3E101-5014-44BE-AA64-BD0E5B55B3B7}";
        private const string _queryXml = "<QueryPacket xmlns='urn:Microsoft.Search.Query' revision='1' >\r\n                                   <Query domain='{2}'>\r\n                                     <Context>\r\n                                       <QueryText type='STRING' language='en-us' >{0}</QueryText>\r\n                                       <LanguagePreference>en-us</LanguagePreference>\r\n                                     </Context>\r\n                                     <OfficeContext xmlns='urn:Microsoft.Search.Query.Office.Context' revision='1'>\r\n                                       <UserPreferences>\r\n                                         <ParentalControl>false</ParentalControl>\r\n                                       </UserPreferences>\r\n                                       <ServiceData>{1}</ServiceData>\r\n                                       <ApplicationContext>\r\n                                         <Name>Microsoft Office Word</Name>\r\n                                         <Version>(14.0.3524)</Version>\r\n                                       </ApplicationContext>\r\n                                       <QueryLanguage>en-us</QueryLanguage>\r\n                                       <KeyboardLanguage>en-us</KeyboardLanguage>\r\n                                    </OfficeContext>\r\n                                   </Query>\r\n                                 </QueryPacket>";
        
        private static string url = "http://rr.office.microsoft.com/Research/query.asmx";
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
            return LDDictionary.GetDefinition(word, "EDICT", _englishGuid);
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
        public static Primitive GetDefinitionInFrench(Primitive word)
        {
            return LDDictionary.GetDefinition(word, "FDICT", _frenchGuid);
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
        public static Primitive GetDefinitionInSpanish(Primitive word)
        {
            return LDDictionary.GetDefinition(word, "SDICT", _spanishGuid);
        }

        public static Primitive Translate(Primitive text)
        {
            string clientID = "LitDevExtension";
            string clientSecret = "Vn1J4b9Bx/I3cfjWtUFYIxeUfEuruWlCTlCLc5llW5I=";
            String strTranslatorAccessURI = "https://datamarket.accesscontrol.windows.net/v2/OAuth2-13";
            String strRequestDetails = string.Format("grant_type=client_credentials&client_id={0}&client_secret={1}&scope=http://api.microsofttranslator.com", HttpUtility.UrlEncode(clientID), HttpUtility.UrlEncode(clientSecret));
            System.Net.WebRequest webRequest = System.Net.WebRequest.Create(strTranslatorAccessURI);
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Method = "POST";
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(strRequestDetails);
            webRequest.ContentLength = bytes.Length;
            using (System.IO.Stream outputStream = webRequest.GetRequestStream())
            {
                outputStream.Write(bytes, 0, bytes.Length);
            }
            System.Net.WebResponse webResponse = webRequest.GetResponse();
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(AdmAccessToken));
            //Get deserialized object from JSON stream 
            AdmAccessToken token = (AdmAccessToken)serializer.ReadObject(webResponse.GetResponseStream());
            string headerValue = "Bearer " + token.access_token;

            string txtToTranslate = text;
            string uri = "http://api.microsofttranslator.com/v2/Http.svc/Translate?text=" + System.Web.HttpUtility.UrlEncode(txtToTranslate) + "&from=en&to=es";
            System.Net.WebRequest translationWebRequest = System.Net.WebRequest.Create(uri);
            translationWebRequest.Headers.Add("Authorization", headerValue);
            System.Net.WebResponse response = null;
            response = translationWebRequest.GetResponse();
            System.IO.Stream stream = response.GetResponseStream();
            System.Text.Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            System.IO.StreamReader translatedStream = new System.IO.StreamReader(stream, encode);
            System.Xml.XmlDocument xTranslation = new System.Xml.XmlDocument();
            xTranslation.LoadXml(translatedStream.ReadToEnd());
            return xTranslation.InnerText;
        }
    }
}
