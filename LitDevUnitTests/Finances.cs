using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using LitDev.Finances;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace LitDevUnitTests
{
    [TestClass]
    public class Finances
    {
        [TestMethod]
        public void GetProfile()
        {
            var data = Engine.GetCompanyProfile("AAPL");
            Assert.AreEqual("AAPL", data.symbol);
            Assert.AreEqual("Technology",data.profile.sector);
        }

        [TestMethod]
        public void GetQuote()
        {
            var data = Engine.GetCompanyQuote("AAPL");
            Assert.AreEqual("AAPL", data[0].symbol);
            Assert.AreEqual("Apple Inc.", data[0].name);
            Assert.AreEqual("NASDAQ", data[0].exchange);
        }

        [TestMethod]
        public void GetSearch()
        {
            var data = Engine.GetSearch("AA", "NASDAQ");
            Assert.IsNotNull(data[0]);
            Assert.IsNotNull(data[9]);
        }

        [TestMethod]
        public void GetFinancialStatements()
        {
            var annual = Engine.GetIncomeStatement("AAPL");
            Assert.AreEqual("AAPL", annual.symbol);
            Assert.IsNotNull(annual.financials);
            Assert.IsTrue( annual.financials[0].date.CompareTo( new DateTime(2019, 09, 8)) >= 0 );

            var quarterly = Engine.GetIncomeStatement("AAPL", Engine.ReportingPeriod.Quarterly);
            Assert.AreEqual("AAPL", quarterly.symbol);
            Assert.IsNotNull(quarterly.financials);
            Assert.IsTrue(quarterly.financials[0].date.CompareTo(new DateTime(2020, 03, 28)) >= 0);
        }

        [TestMethod]
        public void GetBalanceStatements()
        {
            var annual = Engine.GetBalanceStatement("AAPL");
            Assert.AreEqual("AAPL", annual.symbol);
            Assert.IsNotNull(annual.financials);
        }

        [TestMethod]
        public void GetCashFlowStatement()
        {
            var annual = Engine.GetCashFlowStatement("AAPL");
            Assert.AreEqual("AAPL", annual.symbol);
            Assert.IsNotNull(annual.financials);
        }

        [TestMethod]
        public void GetStockPrice()
        {
            var price = Engine.GetRealTimePrice("AAPL");
            Assert.AreEqual("AAPL", price.symbol);
            Assert.IsTrue(price.price > 0);
        }
    }
}
