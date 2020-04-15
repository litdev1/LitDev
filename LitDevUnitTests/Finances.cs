using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LitDevUnitTests
{
    [TestClass]
    public class Finances
    {
        [TestMethod]
        public void GetProfile()
        {
            var data = LitDev.Finances.GetCompanyProfile("AAPL");
            Assert.AreEqual("AAPL", data.symbol);
            Assert.AreEqual("Technology",data.profile.sector);
        }

        [TestMethod]
        public void GetQuote()
        {
            var data = LitDev.Finances.GetCompanyQuote("AAPL");
            Assert.AreEqual("AAPL", data[0].symbol);
            Assert.AreEqual("Apple Inc.", data[0].name);
            Assert.AreEqual("NASDAQ", data[0].exchange);
        }
    }
}
