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
        private NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);
        private DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(JsonWeb));

        public int count = 50;
        public string mkt = CultureInfo.CurrentCulture.Name;

        public Cognitive()
        {
            clientSearch.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "7689c5090e5d425e979e7edb9d8feb64");
            clientSpell.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "dc2179923b7a4e3380fe73f5f2866cf3");
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
            string uri = "https://api.cognitive.microsoft.com/bing/v5.0/search?" + queryString;

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
            var uri = "https://api.cognitive.microsoft.com/bing/v5.0/spellcheck/?" + queryString;

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
