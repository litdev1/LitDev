using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;

namespace LitDev.Engines
{
    enum eSpellMode { proof, spell };

    class Cognitive
    {
        private HttpClient clientSearch = new HttpClient();
        private HttpClient clientSpell = new HttpClient();
        private HttpClient clientTranslate = new HttpClient();
        private NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);
        private DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(JsonWeb));

        public int count = 50;
        public string mkt = CultureInfo.CurrentCulture.Name;

        public Cognitive()
        {
            clientSearch.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "52b0b43437c7406b90f5b3db0097306c");
            clientSpell.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "ef01ee4bc41e4cf1af361d4246b6ce9e");
            clientTranslate.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "49f22a1374ff46a09bd869aee2d913bb");
        }

        public JsonWeb SearchRequest(string search)
        {
            // Web Request parameters
            queryString.Clear();
            queryString["q"] = search;
            queryString["count"] = count.ToString();
            queryString["offset"] = "0";
            queryString["mkt"] = mkt;
            queryString["safesearch"] = "Moderate";
            string uri = "https://api.cognitive.microsoft.com/bing/v7.0/search?" + queryString;

            HttpResponseMessage response = clientSearch.GetAsync(uri).Result;
            Stream stream = response.Content.ReadAsStreamAsync().Result;
            return (JsonWeb)jsonSerializer.ReadObject(stream);
        }

        public JsonWeb SpellRequest(string checkText, eSpellMode spellMode)
        {
            queryString.Clear();
            queryString["mode"] = spellMode.ToString();
            queryString["mkt"] = mkt;
            //queryString["preContextText"] = "";
            //queryString["postContextText"] = "";
            var uri = "https://api.cognitive.microsoft.com/bing/v7.0/spellcheck/?" + queryString;

            string temp = Regex.Replace(checkText, @"[^A-Za-z0-9 _\-]", " ");
            if (temp.Length == checkText.Length) checkText = temp;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict["text"] = checkText;
            FormUrlEncodedContent content = new FormUrlEncodedContent(dict);

            //string json = new JavaScriptSerializer().Serialize(new
            //{
            //    text = "bill clintom",
            //});

            //StringContent content1 = new StringContent("text="+json, Encoding.UTF8, "application/json");
            //content1.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //byte[] byteData = Encoding.UTF8.GetBytes(json);
            //ByteArrayContent content2 = new ByteArrayContent(byteData);
            //content2.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //content.Headers.ContentLength = byteData.Length;
            //clientSpell.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = clientSpell.PostAsync(uri, content).Result;
            Stream stream = response.Content.ReadAsStreamAsync().Result;
            return (JsonWeb)jsonSerializer.ReadObject(stream);
        }

        public string TranslateRequestAsync(string from, string to, string text)
        {
            object[] body = new object[] { new { Text = text } };
            string requestBody = JsonConvert.SerializeObject(body);

            // Web Request parameters
            queryString.Clear();
            queryString["api-version"] = "3.0";
            queryString["from"] = from;
            queryString["to"] = to;
            string uri = "https://api.cognitive.microsofttranslator.com/translate?" + queryString;

            try
            {
                HttpResponseMessage response = clientTranslate.PostAsync(uri, new StringContent(requestBody, Encoding.UTF8, "application/json")).Result;
                string result = response.Content.ReadAsStringAsync().Result;
                TranslationResult[] deserializedOutput = JsonConvert.DeserializeObject<TranslationResult[]>(result);
                return deserializedOutput[0].Translations[0].Text;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        public Dictionary<string,string> AvailableLanguagesRequestAsync()
        {
            // Web Request parameters
            queryString.Clear();
            queryString["api-version"] = "3.0";
            queryString["scope"] = "translation";
            string uri = "https://api.cognitive.microsofttranslator.com/languages?" + queryString;
            Dictionary<string, string> languageList = new Dictionary<string, string>();

            try
            {
                HttpResponseMessage response = clientTranslate.GetAsync(uri).Result;
                string result = response.Content.ReadAsStringAsync().Result;
                AvailableLanguagesResult deserializedOutput = JsonConvert.DeserializeObject<AvailableLanguagesResult>(result);
                foreach (KeyValuePair<string, AvailableLanguage> language in deserializedOutput.Translation)
                {
                    languageList.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(language.Value.Name.ToLower()), language.Key);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return languageList;
        }
    }

    public class AvailableLanguagesResult
    {
        public Dictionary<string, AvailableLanguage> Translation { get; set; }
    }

    public class AvailableLanguage
    {
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string Dir { get; set; }
    }

    public class TranslationResult
    {
        public DetectedLanguage DetectedLanguage { get; set; }
        public TextResult SourceText { get; set; }
        public Translation[] Translations { get; set; }
    }

    public class DetectedLanguage
    {
        public string Language { get; set; }
        public float Score { get; set; }
    }

    public class TextResult
    {
        public string Text { get; set; }
        public string Script { get; set; }
    }

    public class Translation
    {
        public string Text { get; set; }
        public TextResult Transliteration { get; set; }
        public string To { get; set; }
        public Alignment Alignment { get; set; }
        public SentenceLength SentLen { get; set; }
    }

    public class Alignment
    {
        public string Proj { get; set; }
    }

    public class SentenceLength
    {
        public int[] SrcSentLen { get; set; }
        public int[] TransSentLen { get; set; }
    }

    #region Json

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

        [DataMember]
        public List<JsonFlaggedToken> flaggedTokens;

        [DataMember]
        public List<JsonError> errors;
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
    public class JsonFlaggedToken
    {
        [DataMember]
        public int offset;

        [DataMember]
        public string token;

        [DataMember]
        public string type;

        [DataMember]
        public List<JsonSuggestions> suggestions;
    }

    [DataContract]
    public class JsonError
    {
        [DataMember]
        public string code;

        [DataMember]
        public string message;

        [DataMember]
        public string parameter;

        [DataMember]
        public string value;
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

    [DataContract]
    public class JsonSuggestions
    {
        [DataMember]
        public string suggestion;
    }

    #endregion
}
