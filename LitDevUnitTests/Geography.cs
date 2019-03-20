using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LitDev;
using Microsoft.SmallBasic.Library;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace LitDevUnitTests
{
    [TestClass]
    public class Geography
    {
        /// <summary>
        /// Ensures that the API query
        /// generator generates a correct query
        /// with the right information given
        /// the search criteria.
        /// </summary>
        [TestMethod]
        public void GetCountriesByName()
        {
            List<Country> countries = LitDev.Geography.GetCountriesByName("India");

            Assert.AreEqual(2, countries.Count);
            Assert.AreEqual("India" , countries[1].Name);

            LitDev.Geography.FullTextSearch = true;
            LitDev.Geography.Fields = new[] {"nativeName", };
            countries = LitDev.Geography.GetCountriesByName("India");

            Assert.AreEqual(1, countries.Count);
            Assert.IsNull(countries[0].Name);

            LitDev.Geography.FullTextSearch = false;
            LitDev.Geography.Fields = new string[0];
        }

        [TestMethod]
        public void GetCountriesByCurrency()
        {
            LitDev.Geography.Fields = new[] { "name", };
            List<Country> countries = LitDev.Geography.GetCountriesByCurrency("INR");

            if (countries.Count <= 0)
            {
                Assert.Fail();
            }

            Assert.AreEqual(@"1=name\=Bhutan\;;2=name\=India\;;3=name\=Zimbabwe\;;", countries.ToPrimitiveArrayNative().ToString());

            LitDev.Geography.Fields = new string[0];
        }

        /// <summary>
        /// Ensures that the Currency struct
        /// generates correct Primitive array code.
        /// </summary>
        [TestMethod]
        public void CurrenceyToString()
        {
            List<Country> countries = LitDev.Geography.GetCountriesByName("India");
            Currency currency = countries[1].Currencies[0];

            Assert.AreEqual("code=INR;name=Indian rupee;symbol=₹;", currency.ToString());
            
            //This ensures that the data is understandable by the Primitive data class
            Primitive currencyPrimitive = countries[1].ToString();
            Primitive data = currencyPrimitive["currencies"];

            Assert.AreEqual("INR", data[1]["code"].ToString() );
        }

        [TestMethod]
        public void CountriesToString()
        {
            List<Country> countries = LitDev.Geography.GetCountriesByName("col");
            Primitive data = countries.ToPrimitiveArrayNative();

            Assert.AreEqual("Pacific Alliance", data[1]["regionalBlocs"][1]["name"].ToString());
            Assert.AreEqual("Union of South American Nations", data[1]["regionalBlocs"][2]["name"].ToString());
            Assert.AreEqual("União de Nações Sul-Americanas", data[1]["regionalBlocs"][2]["otherNames"][2].ToString());
        }

        [TestMethod]
        public void GetCountriesByCountryCode()
        {
            LitDev.Geography.Fields = new string[0];
            List<Country> countries = LitDev.Geography.GetCountriesByCode(new string[] {"USA", "DE"});

        }

        [TestMethod]
        public void GetAll()
        {
            List<Country> countries = LitDev.Geography.GetAllCountries();
            if (!(countries.Count > 0))
            {
                Assert.Fail();
            }
        }
    }
}
