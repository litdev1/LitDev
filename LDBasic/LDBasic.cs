using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.SmallBasic.Library;
using Newtonsoft.Json.Linq;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;

namespace LDBasic
{
    /// <summary>
    /// A Small selection of LitDev extension methods specific to help fix some depreciated Small Basic features.
    /// 
    /// Example:
    /// 
    /// LDBasic.FixFlickr()
    /// imgURL = Flickr.GetRandomPicture("Car")
    /// image = LDBasic.LoadImage(imgURL)
    /// GraphicsWindow.DrawResizedImage(image,0,0, GraphicsWindow.Width, GraphicsWindow.Height)
    /// </summary>
    [SmallBasicType]
    public static class LDBasic
    {
        /// <summary>
        /// Fix the Flickr object with an updated API key.
        /// </summary>
        public static Primitive FixFlickr()
        {
            Type FlickrType = typeof(Flickr);
            FieldInfo fieldInfo = FlickrType.GetField("_urlTemplate", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
            string _urlTemplate = (string)fieldInfo.GetValue(null);
            _urlTemplate = _urlTemplate.Replace("http://", "https://");
            _urlTemplate = _urlTemplate.Replace("api.flickr.com", "www.flickr.com");
            _urlTemplate = _urlTemplate.Replace("1f9fb9818296700580bf3340279346b6", "0710832f037b546b7ba28571850f36bd");
            fieldInfo.SetValue(null, _urlTemplate);

            fieldInfo = FlickrType.GetField("_picUrlTemplate", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
            string _picUrlTemplate = (string)fieldInfo.GetValue(null);
            _picUrlTemplate = _picUrlTemplate.Replace("http://", "https://");
            _picUrlTemplate = _picUrlTemplate.Replace("static.flickr.com", "staticflickr.com");
            fieldInfo.SetValue(null, _picUrlTemplate);

            Primitive result = new Primitive();
            result["_urlTemplate"] = _urlTemplate;
            result["_picUrlTemplate"] = _picUrlTemplate;
            return result;
        }

        /// <summary>
        /// Set SSL security for network operations downoading files.
        /// LoadImage and DownloadFile both use this method internally for special cases.
        /// Use this call before using various network operations that do not require LoadImage or DownloadFile
        /// </summary>
        public static void SetSSL()
        {
            WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultCredentials;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        /// <summary>
        /// Replacement for default method of the same name.  Handles image downloads from Flickr.
        /// Loads an image from a file or the Internet into memory (Imagelist).
        /// </summary>
        /// <param name="fileNameOrURL">The file name to load the image from.  This could be a local file or a URL to the Internet location.</param>
        /// <returns>Returns the name of the image that was loaded.</returns>
        public static Primitive LoadImage(Primitive fileNameOrURL)
        {
            SetSSL();
            string tmpFile = SBFile.GetTemporaryFilePath();
            DownloadFile(tmpFile, fileNameOrURL);
            Primitive image = SBImageList.LoadImage(tmpFile);
            SBFile.DeleteFile(tmpFile);
            return image;
        }

        /// <summary>
        /// Similar To Network.DownloadFile, except the download file is input and handles larger files better.
        /// </summary>
        /// <param name="localFile">The local file name to save the downloaded file.</param>
        /// <param name="remoteFile">The remote network file.</param>
        /// <returns>The size of the file in bytes or -1 for failue.</returns>
        public static Primitive DownloadFile(Primitive localFile, Primitive remoteFile)
        {
            try
            {
                FileInfo fileInf = new FileInfo(localFile);
                Uri uri = new Uri(remoteFile);
                SetSSL();
                WebRequest webRequest = WebRequest.Create(uri);

                int bufferSize = 2048;
                byte[] buffer = new byte[bufferSize];

                FileStream fs = fileInf.OpenWrite();
                WebResponse webResponse = webRequest.GetResponse();
                Stream stream = webResponse.GetResponseStream();

                int readCount = stream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    fs.Write(buffer, 0, readCount);
                    readCount = stream.Read(buffer, 0, bufferSize);
                }

                stream.Close();
                fs.Close();
                webResponse.Close();
                return (decimal)fileInf.Length;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        private static string wordnikURL = "http://api.wordnik.com/v4/word.json/{0}/definitions?limit=20&includeRelated=false&sourceDictionaries=all&useCanonical=true&includeTags=false&api_key=j001kafeiltiu6qv9y9ra7lyxbqk02py7vzwh9d19tdqiu44z";

        private static string GetDefinition(string word, string lang)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StreamReader streamReader = null;
            WebResponse webResponse = null;
            try
            {
                string url = string.Format(wordnikURL, word.ToLower());

                SetSSL();
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
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            return stringBuilder.ToString();
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
        }
    }
}
