using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LitDev;
using NUnit.Framework;
using LitDev.Finances;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace LitDevUnitTests
{
    /// <summary>
    /// This class tests the Finance Engine.
    /// </summary>
    [TestClass]
    public class Finances
    {

        [SetUp]
        public void SetUp()
        {
            Primitive key = File.ReadContents("finapi.txt");
            LDFinances.Key = key;
        }

        [TestMethod]
        public void GetProfile()
        {
            SetUp();
            Assert.IsFalse(string.IsNullOrWhiteSpace(Engine.key));
            var data = Engine.GetCompanyProfile("AAPL");
            Assert.AreEqual("AAPL", data.symbol);
            Assert.AreEqual("Technology",data.profile.sector);
        }

        [TestMethod]
        public void GetQuote()
        {
            SetUp();
            var data = Engine.GetCompanyQuote("AAPL");
            Assert.AreEqual("AAPL", data[0].symbol);
            Assert.AreEqual("Apple Inc.", data[0].name);
            Assert.AreEqual("NASDAQ", data[0].exchange);
        }

        [TestMethod]
        public void GetSearch()
        {
            SetUp();
            var data = Engine.GetSearch("AA", "NASDAQ");
            Assert.IsNotNull(data[0]);
            Assert.IsNotNull(data[9]);
        }

        [TestMethod]
        public void GetFinancialStatements()
        {
            SetUp();
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
            SetUp();
            var annual = Engine.GetBalanceStatement("AAPL");
            Console.WriteLine(Engine.LastURL);
            Assert.AreEqual("AAPL", annual.symbol);
            Assert.IsNotNull(annual.financials);
        }

        [TestMethod]
        public void GetCashFlowStatement()
        {
            SetUp();
            var annual = Engine.GetCashFlowStatement("AAPL");
            Assert.AreEqual("AAPL", annual.symbol);
            Assert.IsNotNull(annual.financials);
        }

        [TestMethod]
        public void GetStockPrice()
        {
            SetUp();
            var price = Engine.GetRealTimePrice("AAPL");
            Assert.AreEqual("AAPL", price.symbol);
            Assert.IsTrue(price.price > 0);
        }
    }
}
