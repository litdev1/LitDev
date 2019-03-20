using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LitDevUnitTests
{
    [TestClass]
    public class LDGeography
    {
        [TestMethod]
        public void StrictSearch()
        {
            LitDev.LDGeography.StrictSearch = "True";
            Assert.AreEqual(true, LitDev.Geography.FullTextSearch);

            LitDev.LDGeography.StrictSearch = "false";
            Assert.AreEqual(false, LitDev.Geography.FullTextSearch);

            LitDev.LDGeography.StrictSearch = "truth";
            Assert.AreEqual(false, LitDev.Geography.FullTextSearch);
        }

        [TestMethod]
        public void Fields()
        {
            LitDev.LDGeography.Fields = "1=name;2=nativeName;";
            Assert.AreEqual(new string[] {"name", "nativeName"}.ToPrimitiveArray() , LitDev.Geography.Fields.ToPrimitiveArray());

            LitDev.LDGeography.Fields = "";
            Assert.AreEqual(0, LitDev.Geography.Fields.Length );

            LitDev.LDGeography.Fields = "foo";
            Assert.AreEqual(0, LitDev.Geography.Fields.Length);
        }

        [TestMethod]
        public void GetAll()
        {
            if (LitDev.LDGeography.GetAllCountries().ToString().Contains("FAILED"))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetCountryByCountryCode()
        {
            Assert.AreEqual("United States Minor Outlying Islands", LitDev.LDGeography.GetCountriesByCode("1=UMI;")[1]["name"].ToString());
            Assert.AreEqual("United States of America" , LitDev.LDGeography.GetCountriesByCode("1=USA;")[1]["name"].ToString());
        }

        [TestMethod]
        public void GetCountryByCurrencey()
        {
            LitDev.LDGeography.Fields = "1=name;";
            Assert.AreEqual(@"1=name\=Bhutan\;;2=name\=India\;;3=name\=Zimbabwe\;;", LitDev.LDGeography.GetCountriesByCurrency("INR").ToString());
            LitDev.LDGeography.Fields = "";
        }
    }
}
