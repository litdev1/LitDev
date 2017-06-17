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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Xml;

namespace LitDev
{
    public class AdmAccessToken
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string scope { get; set; }
    }

    /// <summary>
    /// Language translation methods.
    /// This method is currently depreciated as MS has remove translation API.
    /// </summary>
    [SmallBasicType]
    public static class LDTranslate
    {
        private static string token = string.Empty;
        private static DateTime tokenEnds = DateTime.Now;

        private static void GetHeader()
        {
            if (DateTime.Now < tokenEnds) return;

            string clientID = "LitDevExtension";
            string clientSecret = "Vn1J4b9Bx/I3cfjWtUFYIxeUfEuruWlCTlCLc5llW5I=";
            String strTranslatorAccessURI = "https://datamarket.accesscontrol.windows.net/v2/OAuth2-13";
            String strRequestDetails = string.Format("grant_type=client_credentials&client_id={0}&client_secret={1}&scope=http://api.microsofttranslator.com", HttpUtility.UrlEncode(clientID), HttpUtility.UrlEncode(clientSecret));
            WebRequest webRequest = WebRequest.Create(strTranslatorAccessURI);
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Method = "POST";
            byte[] bytes = Encoding.ASCII.GetBytes(strRequestDetails);
            webRequest.ContentLength = bytes.Length;
            using (Stream outputStream = webRequest.GetRequestStream())
            {
                outputStream.Write(bytes, 0, bytes.Length);
            }
            WebResponse webResponse = webRequest.GetResponse();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(AdmAccessToken));
            //Get deserialized object from JSON stream 
            AdmAccessToken admToken = (AdmAccessToken)serializer.ReadObject(webResponse.GetResponseStream());
            token = "Bearer " + admToken.access_token;
            tokenEnds = DateTime.Now.AddSeconds(double.Parse(admToken.expires_in) - 10);
        }

        private static string TranslateMethod(string sourceText, string langFrom, string langTo)
        {
            GetHeader();
            string txtToTranslate = sourceText;
            string uri = "http://api.microsofttranslator.com/v2/Http.svc/Translate?text=" + System.Web.HttpUtility.UrlEncode(txtToTranslate) + "&from=" + langFrom + "&to=" + langTo;
            WebRequest translationWebRequest = WebRequest.Create(uri);
            translationWebRequest.Headers.Add("Authorization", token);
            WebResponse response = translationWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            Encoding encode = Encoding.GetEncoding("utf-8");
            StreamReader translatedStream = new StreamReader(stream, encode);
            XmlDocument xTranslation = new XmlDocument();
            xTranslation.LoadXml(translatedStream.ReadToEnd());
            return xTranslation.InnerText;
        }

        private static List<string> GetLanguagesForTranslate()
        {
            GetHeader();
            string uri = "http://api.microsofttranslator.com/v2/Http.svc/GetLanguagesForTranslate";
            WebRequest languagesWebRequest = WebRequest.Create(uri);
            languagesWebRequest.Headers.Add("Authorization", token);
            WebResponse response = languagesWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            DataContractSerializer dcs = new DataContractSerializer(typeof(List<string>));
            return (List<string>)dcs.ReadObject(stream);
        }

        private static List<string> GetLanguageNames(List<string> languages)
        {
            GetHeader();
            string uri = "http://api.microsofttranslator.com/v2/Http.svc/GetLanguageNames?locale=" + CultureInfo.CurrentCulture.Name;
            WebRequest languagesWebRequest = WebRequest.Create(uri);
            languagesWebRequest.Headers.Add("Authorization", token);
            languagesWebRequest.ContentType = "text/xml";
            languagesWebRequest.Method = "POST";
            using (Stream stream = languagesWebRequest.GetRequestStream())
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<string>));
                dcs.WriteObject(stream, languages);
            }
            WebResponse response = languagesWebRequest.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<string>));
                return (List<string>)dcs.ReadObject(stream);
            }
        }

        /// <summary>
        /// Get an array of language codes and their language.
        /// The array indices are the required language codes for the Translate method.
        /// </summary>
        /// <returns>The 1D array of language codes and names.</returns>
        [HideFromIntellisense]
        public static Primitive Languages()
        {
            try
            {
                List<string> languages = GetLanguagesForTranslate();
                List<string> languageNames = GetLanguageNames(languages);
                string result = "";
                for (int i = 0; i < languages.Count; i++)
                {
                    result += Utilities.ArrayParse(languages[i]) + "=" + Utilities.ArrayParse(languageNames[i]) + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Translate a text from one language to another.
        /// </summary>
        /// <param name="input">The text to translate.</param>
        /// <param name="languageFrom">The language code to translate from.</param>
        /// <param name="languageTo">The language code to translate to.</param>
        /// <returns>The translated text.</returns>
        [HideFromIntellisense]
        public static Primitive Translate(Primitive input, Primitive languageFrom, Primitive languageTo)
        {
            try
            {
                return TranslateMethod(input, languageFrom, languageTo);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }
    }
}