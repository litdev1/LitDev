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
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LitDev;
using Newtonsoft.Json;

namespace LitDev
{
    /// <summary>
    /// This is an abstraction layer around the API.
    /// If we change the API's source or change API
    /// providers LD Geography should not have to change.
    /// </summary>
    public static class Geography
    {
        private const string baseURL = "https://restcountries.eu/rest/v2";
        public static string query;
        public static string json;

        
        //This is the api abstraction
        private static WebAPI api = WebAPIFactory.Instance.GetWebApi(baseURL);

        public static List<Country> GetAllCountries()
        {
            query = $"/all";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query)); ;
        }

        public static List<Country> GetCountriesByName(string name)
        {
            query = $"/name/{name}";

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
            try
            {
                query = $"/alpha";
                query += $"?codes={ArrayToURL(codes)}";


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
            catch (Exception ex)
            {
                throw new Exception(query + "\n" + ex.ToString());
            }
        }

        public static List<Country> GetCountriesByCurrency(string currency)
        {
            query = $"/currency/{currency}";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByCapital(string capital)
        {
            query = $"/capital/{capital}";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByCallingCode(string callingCode)
        {
            query = $"/callingcode/{callingCode}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByRegion(string region)
        {
            query = $"/region/{region}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByRegionalBloc(string bloc)
        {
            query = $"/regionalbloc/{bloc}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        private static string JSON(string URL)
        {
            return api.Get(URL);
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
        public string[] CallingCodes;
        public string[] AltSpellings;
        public string Region;
        public decimal[] Latlng;
        public string Demonym;
        public decimal? Area;
        public string GINI;
        public string[] Timezones;
        public string[] Borders;
        public string NativeName;
        public int? NumericCode;

        public string CIOC;
        public string Flag;

        public Currency[] Currencies;
        public Language[] Languages;
        public RegionalBloc[] RegionalBlocs;

        //TODO Replace Primitive methods with stringbuilder
        public override string ToString()
        {
            Primitive results = new Primitive();
            if (!string.IsNullOrWhiteSpace(Name))
            {
                results["name"] = Name;
            }

            if (TopLevelDomain?.Length > 0)
            {
                results["TLD"] = TopLevelDomain.ToPrimitiveArrayNative();
            }

            if (!string.IsNullOrWhiteSpace(Alpha2Code)) { 
                results["alpha2Code"] = Alpha2Code;
            }

            if (!string.IsNullOrWhiteSpace(Alpha3Code))
            {
                results["alpha3Code"] = Alpha3Code;
            }

            if (CallingCodes?.Length > 0)
            {
                results["callingCodes"] = CallingCodes.ToList().ToPrimitiveArrayNative();
            }

            if (AltSpellings?.Length > 0)
            {
                results["altSpellings"] = AltSpellings.ToPrimitiveArrayNative();
            }

            if (!string.IsNullOrEmpty(Region))
            {
                results["region"] = Region;
            }

            if (!string.IsNullOrWhiteSpace(Demonym))
            {
                results["demonym"] = Demonym;
            }

            if (Latlng?.Length >= 1)
            {
                results["latitude"] = Latlng[0];
                results["longitude"] = Latlng[1];
            }

            if (Area != null)
            {
                results["area"] = (decimal) Area;
            }

            if (NumericCode != null)
            {
                results["numericCode"] = (int)NumericCode;
            }

            if (!string.IsNullOrWhiteSpace(GINI))
            {
                results["GINI"] = GINI;
            }

            if (Timezones?.Length > 0)
            {
                results["timezones"] = Timezones.ToPrimitiveArrayNative();
            }

            if (Borders?.Length > 0)
            {
                results["borders"] = Borders.ToPrimitiveArrayNative();
            }

            if (!string.IsNullOrWhiteSpace(CIOC))
            {
                results["CIOC"] = CIOC;
            }

            if (!string.IsNullOrWhiteSpace(Flag))
            {
                results["flag"] = Flag;
            }

            if (Currencies?.Length > 0)
            {
                results["currencies"] = Currencies.ToPrimitiveArrayNative();
            }

            if (Languages?.Length > 0)
            {
                results["languages"] = Languages.ToPrimitiveArrayNative();
            }

            if (RegionalBlocs?.Length > 0)
            {
                results["regionalBlocs"] = RegionalBlocs.ToPrimitiveArrayNative();
            }

            return results;
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

            if (!string.IsNullOrWhiteSpace(ISO639_1))
            {
                result += $"ISO639_1={ISO639_1};";
            }

            if (!string.IsNullOrWhiteSpace(ISO639_2))
            {
                result += $"ISO639_2={ISO639_2};";
            }

            if (!string.IsNullOrWhiteSpace(Name))
            {
                result += $"name={Name};";
            }

            if (!string.IsNullOrWhiteSpace(NativeName))
            {
                result += $"nativeName={NativeName};";
            }

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

        public override string ToString()
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(DE))
            {
                result += $"de={DE};";
            }

            if (!string.IsNullOrWhiteSpace(ES))
            {
                result += $"es={ES};";
            }

            if (!string.IsNullOrWhiteSpace(FR))
            {
                result += $"fr={FR};";
            }

            if (!string.IsNullOrWhiteSpace(JA))
            {
                result += $"ja={JA};";
            }

            if (!string.IsNullOrWhiteSpace(IT))
            {
                result += $"it={IT};";
            }

            if (!string.IsNullOrWhiteSpace(BR))
            {
                result += $"br={BR};";
            }

            if (!string.IsNullOrWhiteSpace(PT))
            {
                result += $"pt={PT};";
            }

            return result;
        }
    }

    public class RegionalBloc
    {
        public string Acronym;
        public string Name;
        public string[] OtherAcronyms;
        public string[] OtherNames;

        public override string ToString()
        {
            Primitive result = string.Empty;
            result["otherAcronyms"] = OtherAcronyms.ToPrimitiveArrayNative();
            result["otherNames"] = OtherNames.ToPrimitiveArrayNative();
            result["name"] = Name;
            result["acronym"] = Acronym;

            return result;
        }
    }

    /// <summary>
    /// Gets geographic information about countries and
    /// regional blocks.
    /// API provided by https://restcountries.eu
    /// Data provided by https://github.com/mledoze/countries
    /// Coded by Abhishek Sathiabalan
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDGeography
    {
        /// <summary>
        /// Whenever possible make the search require an exact match
        /// between the query and the results.
        /// </summary>
        public static Primitive StrictSearch
        {
            get { return Geography.FullTextSearch.ToString(); }

            set
            {
                bool result;
                if (bool.TryParse(value, out result))
                {
                    Geography.FullTextSearch = result;
                }
            }
        } 

        /// <summary>
        /// An array of fields that the results will
        /// contain. Fields not specified will not be
        /// returned.
        /// </summary>
        public static Primitive Fields
        {
            get { return Geography.Fields.ToPrimitiveArray(); }
            set { Geography.Fields = LimitFields(value); }
        }

        private static string[] LimitFields(Primitive fields)
        {
            string[] data = new string[fields.GetItemCount()];
            for (int i = 1; i <= fields.GetItemCount(); i++)
            {
                data[i - 1] = fields[i];
            }

            return data;
        }

        /// <summary>
        /// Returns all countries on earth and
        /// other territories in a Primitive array.
        /// </summary>
        public static Primitive GetAllCountries()
        {
            try
            {
                return Geography.GetAllCountries().ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Returns a Primitive array of countries by name.
        /// </summary>
        /// <param name="name">Name of the country to search for</param>
        /// <returns></returns>
        public static Primitive GetCountriesByName(Primitive name)
        {
            try
            {
                return Geography.GetCountriesByName(name).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Returns a Primitive array of countries by ISO country code.
        /// </summary>
        public static Primitive GetCountriesByCode(Primitive code)
        {
            try
            {
                return Geography.GetCountriesByCode(LimitFields(code)).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Returns a Primitive array of countries by currency used.
        /// </summary>
        public static Primitive GetCountriesByCurrency(Primitive currency)
        {
            try
            {
                return Geography.GetCountriesByCurrency(currency).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Returns a Primitive array of countries by country capital.
        /// </summary>
        public static Primitive GetCountriesByCapital(Primitive capital)
        {
            try
            {
                return Geography.GetCountriesByCapital(capital).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Returns a Primitive array of countries by telephone calling code.
        /// </summary>
        public static Primitive GetCountriesByCallingCode(Primitive callingCode)
        {
            try
            {
                return Geography.GetCountriesByCallingCode(callingCode).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Returns a Primitive array of countries by geographical region.
        /// </summary>
        public static Primitive GetCountriesByRegion(Primitive region)
        {
            try
            {
                return Geography.GetCountriesByRegion(region).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        /// <summary>
        /// Returns a Primitive array of countries by regional bloc.
        /// </summary>
        public static Primitive GetCountriesByRegionalBloc(Primitive regionalBloc)
        {
            try
            {
                return Geography.GetCountriesByRegionalBloc(regionalBloc).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }
    }
}
