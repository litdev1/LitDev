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

namespace LitDevUnitTests
{
    [TestClass]
    public class LDFinance
    {
        public void SetUp()
        {
            Primitive key = File.ReadContents("finapi.txt");
            LDFinances.Key = key;
        }

        [TestMethod]
        public void Description()
        {
            SetUp();
            Primitive data = LDFinances.Description("AAPL");
            Assert.IsTrue(SBArray.IsArray(data));
            
            Assert.AreEqual("Apple Inc", data["name"].ToString());
            Assert.AreEqual("NASDAQ", data["exchangeCode"].ToString());

        }

        [TestMethod]
        public void Price()
        {
            SetUp();
            Primitive data = LDFinances.Price("AAPL");
            Console.WriteLine(data.ToString());
            Assert.IsTrue( SBArray.IsArray(data) );
            Assert.IsTrue( double.Parse(data["volume"]) > 0 );
        }

    }
}
