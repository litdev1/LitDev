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
        [TestMethod]
        public void APIGetCountriesByName()
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
        public void ApiCurrenceyToString()
        {
            List<Country> countries = LitDev.Geography.GetCountriesByName("India");
            Currency currency = countries[1].Currencies[0];

            Assert.AreEqual("code=INR;name=Indian rupee;symbol=₹;", currency.ToString());
            Primitive currencyPrimitive = countries[1].ToString();
            Primitive data = currencyPrimitive["currencies"];

            Assert.AreEqual("INR", data[1]["code"].ToString() );


        }

    }
}
