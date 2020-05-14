using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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

        [TestMethod]
        public void GetSearch()
        {
            var data = LitDev.Finances.GetSearch("AA", "NASDAQ");
            Assert.IsNotNull(data[0]);
            Assert.IsNotNull(data[9]);
        }

        [TestMethod]
        public void GetFinancialStatements()
        {
            var annual = LitDev.Finances.GetIncomeStatement("AAPL");
            Assert.AreEqual("AAPL", annual.symbol);
            Assert.IsNotNull(annual.financials);
            Assert.IsTrue( annual.financials[0].date.CompareTo( new DateTime(2019, 09, 8)) >= 0 );

            var quarterly = LitDev.Finances.GetIncomeStatement("AAPL", LitDev.Finances.ReportingPeriod.Quarterly);
            Assert.AreEqual("AAPL", quarterly.symbol);
            Assert.IsNotNull(quarterly.financials);
            Assert.IsTrue(quarterly.financials[0].date.CompareTo(new DateTime(2020, 03, 28)) >= 0);
        }

        [TestMethod]
        public void GetBalanceStatements()
        {
            var annual = LitDev.Finances.GetBalanceStatement("AAPL");
            Assert.AreEqual("AAPL", annual.symbol);
            Assert.IsNotNull(annual.financials);
        }

        [TestMethod]
        public void GetCashFlowStatement()
        {
            var annual = LitDev.Finances.GetCashFlowStatement("AAPL");
            Assert.AreEqual("AAPL", annual.symbol);
            Assert.IsNotNull(annual.financials);
        }

        [TestMethod]
        public void GetStockPrice()
        {
            var price = LitDev.Finances.GetRealTimePrice("AAPL");
            Assert.AreEqual("AAPL", price.symbol);
            Assert.IsTrue(price.price > 0);
        }
    }
}
