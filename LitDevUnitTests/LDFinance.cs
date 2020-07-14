using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LitDev;
using Microsoft.SmallBasic.Library;
using Array = Microsoft.SmallBasic.Library.Array;

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
            Assert.IsTrue(Array.IsArray(data));
            
            Assert.AreEqual("Apple Inc", data["name"].ToString());
            Assert.AreEqual("NASDAQ", data["exchangeCode"].ToString());

        }

        [TestMethod]
        public void Price()
        {
            SetUp();
            Primitive data = LDFinances.Price("AAPL");
            Console.WriteLine(data.ToString());
            Assert.IsTrue( Array.IsArray(data) );
            Assert.IsTrue( double.Parse(data["volume"]) > 0 );
        }

    }
}
