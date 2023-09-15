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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LitDev;
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
            Assert.AreEqual("Germany",countries[1].Name);
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

        [TestMethod]
        public void GetCountriesByCapital()
        {
            List<Country> countries = LitDev.Geography.GetCountriesByCapital("New Delhi");
            Assert.AreEqual("India", countries[0].Name);
        }

        [TestMethod]
        public void GetCountriesByCallingCode()
        {
            List<Country> countries = LitDev.Geography.GetCountriesByCallingCode("7");
            Assert.AreEqual("Russian Federation",countries[0].Name);
        }

        [TestMethod]
        public void GetCountriesByRegion()
        {
            List<Country> countries = LitDev.Geography.GetCountriesByRegion("Europe");
            Assert.AreEqual("Åland Islands", countries[0].Name);
        }

        [TestMethod]
        public void GetCountriesByRegionalBloc()
        {
            List<Country> countries = LitDev.Geography.GetCountriesByRegionalBloc("NAFTA ");
            Assert.AreEqual("Canada", countries[0].Name);
            Assert.AreEqual("Mexico", countries[1].Name);
            Assert.AreEqual("United States of America", countries[2].Name);
        }
    }
}
