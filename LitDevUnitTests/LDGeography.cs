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
            //When a method fails it should return FAILED. 
            //A lack of FAILED indicates that everything should be good.
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
            Assert.AreEqual("FAILED", LitDev.LDGeography.GetCountriesByCode("1=;").ToString());
        }

        [TestMethod]
        public void GetCountryByCurrencey()
        {
            LitDev.LDGeography.Fields = "1=name;";
            Assert.AreEqual(@"1=name\=Bhutan\;;2=name\=India\;;3=name\=Zimbabwe\;;", LitDev.LDGeography.GetCountriesByCurrency("INR").ToString());
            Assert.AreEqual("FAILED", LitDev.LDGeography.GetCountriesByCurrency("").ToString());
            LitDev.LDGeography.Fields = "";
        }

        [TestMethod]
        public void GetCountriesByName()
        {
            LitDev.LDGeography.Fields = "1=name;";
            LitDev.LDGeography.StrictSearch = "True";
            Assert.AreEqual("India", LitDev.LDGeography.GetCountriesByName("India")[1]["name"].ToString());
            Assert.AreEqual("FAILED", LitDev.LDGeography.GetCountriesByName("Ind").ToString());

            LitDev.LDGeography.Fields = "";
            LitDev.LDGeography.StrictSearch = "False";
        }

        [TestMethod]
        public void GetCountriesByCapital()
        {
            Primitive data = LitDev.LDGeography.GetCountriesByCapital("New Delhi");
            Assert.AreEqual("India", data[1]["name"].ToString());
            Assert.AreEqual("FAILED", LitDev.LDGeography.GetCountriesByCapital("").ToString());
        }

        [TestMethod]
        public void GetCountriesByCallingCode()
        {
            Primitive data = LitDev.LDGeography.GetCountriesByCallingCode("7");
            Assert.AreEqual("Russian Federation", data[1]["name"].ToString());
            Assert.AreEqual("FAILED", LitDev.LDGeography.GetCountriesByCallingCode("---").ToString() );
        }

        [TestMethod]
        public void GetCountriesByRegion()
        {
            Primitive data = LitDev.LDGeography.GetCountriesByRegion("Europe");
            Assert.AreEqual("Åland Islands", data[1]["name"].ToString());
            Assert.AreEqual("FAILED", LitDev.LDGeography.GetCountriesByRegion("---").ToString());
        }

        [TestMethod]
        public void GetCountriesByRegionalBloc()
        {
            Primitive data = LitDev.LDGeography.GetCountriesByRegionalBloc("EU");
            Assert.AreEqual("Austria", data[2]["name"].ToString());
            Assert.AreEqual("FAILED", LitDev.LDGeography.GetCountriesByRegionalBloc("---").ToString());
        }
    }
}
