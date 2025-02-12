using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LitDev
{
    /// <summary>
    /// This class is a singleton
    /// and should be used to generate WebAPI objects
    /// </summary>
    public class WebAPIFactory
    {
        private static WebAPIFactory instance = null; 
        private static readonly object padlock = new object();

        private Dictionary<string, WebAPI> map;

        public WebAPIFactory()
        {
            map = new Dictionary<string, WebAPI>();
        }

        public static WebAPIFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new WebAPIFactory();
                    }

                    return instance;
                }
            }
        }

        public WebAPI GetWebApi(string baseUrl)
        {
            if (map.ContainsKey(baseUrl))
            {
                return map[baseUrl];
            }
            WebAPI api = new WebAPI(baseUrl);
            map.Add(baseUrl, api);
            return api;
        }
    }

    /// <summary>
    /// A wrapper for some Web Request stuff for Geography, Finances, 
    /// and other future API's.
    /// 
    /// We can also be kind to the API's we use through this
    /// by allowing restrictions on how frequently our users
    /// request information either based on setting time
    /// limits on the information. 
    /// </summary>
    public class WebAPI
    {
        private string baseUrl;
        public string lastUrl;

        public WebAPI(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        /// <summary>
        /// Sends a get request to the specified path
        /// </summary>
        /// <param name="path">The path is appended to the baseUrl</param>
        /// <returns>The response from the server</returns>
        public string Get(string path)
        {
            string URL = baseUrl + path;

            //TODO: This is the point where we could check the cache
            //and see if we can return the results from there instead of creating a new request 
            //If not, we can always go ahead and actually fetch the data
            //In an ideal world we will also be able to prevent the deserialization of the 
            //data in question but that is less important since the user is using 
            //their own resources to deserialize vs public resources to refetch the data. 

            ServicePointManager.Expect100Continue = true;
            LDNetwork.SetSSL();
            WebRequest WR = WebRequest.Create(URL);
            WR.ContentType = "application/x-www-form-urlencoded";
            WR.Method = "GET";

            WebResponse response = WR.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader translatedStream = new StreamReader(stream, Encoding.UTF8);
            string data = translatedStream.ReadToEnd();
            lastUrl = URL;

            if (string.IsNullOrWhiteSpace(data))
            {
                throw new Exception($"No output returned from {URL}.");
            }
            return data;
        }

        /// <summary>
        /// Sends a get request to the specified path
        /// and deserialize the returned JSON
        /// </summary>
        /// <typeparam name="T">The type to deserialize to</typeparam>
        /// <param name="path">The path is appended to the baseUrl</param>
        /// <returns>The JSON object requested</returns>
        public T DeserializeJSON<T>(string path)
        {
            return JsonConvert.DeserializeObject<T>(Get(path));
        }
    }

    public class Cache
    {

    }
}
