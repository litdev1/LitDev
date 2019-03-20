using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.SmallBasic.Library;
using Newtonsoft.Json;

namespace LitDev
{
    /// <summary>
    /// This is an abstraction layer around the API.
    /// If we change the API's source or change API
    /// providers LD Geography should not have to change.
    /// </summary>
    [HideFromIntellisense]
    public static class Geography
    {
        private const string baseURL = "https://restcountries.eu/rest/v2";
        public static string query;

        public static List<Country> GetAllCountries()
        {
            query = $"{baseURL}/all";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query)); ;
        }

        public static List<Country> GetCountriesByName(string name)
        {
            query = $"{baseURL}/name/{name}";

            if (FullTextSearch || Fields?.Length > 0)
            {
                query += "?";

                if (FullTextSearch)
                {
                   query += "fullText=true";
                }

                if (Fields?.Length > 0)
                {
                    if (FullTextSearch)
                    {
                        query += "&";
                    }

                    query += $"fields={ ArrayToURL(Fields)}";
                }
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query)); 
        }

        public static List<Country> GetCountriesByCode(string[] codes)
        {
            query = $"{baseURL}/alpha/";

            if (codes.Length == 1)
            {
                query += codes[0];
            }
            else
            {
                query += $"?codes={ArrayToURL(codes)}";
            }

            if (Fields?.Length > 0)
            {
                if (codes.Length == 1)
                {
                    query += "?";
                }

                query += $"fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByCurrency(string currency)
        {
            query = $"{baseURL}/currency/{currency}";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByCapital(string capital)
        {
            query = $"{baseURL}/capital/{capital}";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByCallingCode(string callingCode)
        {
            query = $"{baseURL}/callingcode/{callingCode}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByRegion(string region)
        {
            query = $"{baseURL}/region/{region}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByRegionalBloc(string bloc)
        {
            query = $"{baseURL}/regionalbloc/{bloc}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        private static string JSON(string URL)
        {
            return Response(Request(URL));
        }

        private static WebRequest Request(string URL)
        {
            WebRequest WR = WebRequest.Create(URL);
            WR.ContentType = "application/x-www-form-urlencoded";
            WR.Method = "GET";
            return WR;
        }

        private static string Response(WebRequest WR)
        {
            WebResponse response = WR.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader translatedStream = new StreamReader(stream, Encoding.UTF8);
            return translatedStream.ReadToEnd();
        }

        private static string ArrayToURL(string[] fields)
        {
            string temp = string.Empty;
            for (int i = 0; i < fields.Count(); i++)
            {
                temp += fields[i];

                if (i < fields.Length)
                {
                    temp += ";";
                }
            }

            return temp;
        }

        public static string[] Fields;
        public static bool FullTextSearch;
    }

    public struct Country
    {
        public string Name;
        public string[] TopLevelDomain;
        public string Alpha2Code;
        public string Alpha3Code;
        public int[] CallingCodes;
        public string[] AltSpellings;
        public string Region;
        public decimal[] Latlng;
        public string Demonym;
        public decimal Area;
        public string GINI;
        public string[] Timezones;
        public string[] Borders;
        public string NativeName;
        public int NumericCode;

        public string CIOC;

        public Currency[] Currencies;
        public Language[] Languages;

        public string flag;
        public RegionalBloc[] RegionalBlocs;

        //TODO Replace Primitive methods with stringbuilder
        public override string ToString()
        {
            Primitive results = new Primitive();
            Primitive temp;

            temp = "";
            for (int i = 0; i < Currencies.Length; i++)
            {
                temp[i + 1] = Currencies[i].ToString();
            }

            results["currencies"] = temp;

            return  results ;
        }
    }

    public struct Currency
    {
        public string Code;
        public string Name;
        public string Symbol;

        public override string ToString()
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(Code))
            {
                result += $"code={Code};";
            }

            if (!string.IsNullOrEmpty(Name))
            {
                result += $"name={Name};";
            }

            if (!string.IsNullOrEmpty(Symbol))
            {
                result += $"symbol={Symbol};";
            }

            return result;
        }
    }

    public struct Language
    {
        public string ISO639_1;
        public string ISO639_2;
        public string Name;
        public string NativeName;

        public override string ToString()
        {
            string result = string.Empty;



            return result;
        }
    }

    public class Translation
    {
        public string DE;
        public string ES;
        public string FR;
        public string JA;
        public string IT;
        public string BR;
        public string PT;
    }

    public class RegionalBloc
    {
        public string Acronym;
        public string Name;
        public string[] OtherAcronyms;
        public string[] OtherNames;
    }



    /// <summary>
    /// Gets geographic information about countries and
    /// regional blocks.
    /// API provided by https://restcountries.eu
    /// Coded by Abhishek Sathiabalan
    /// </summary>
    [SmallBasicType]
    [HideFromIntellisense]
    public static class LDGeography
    {
        
    }
}
