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
            Assert.AreEqual("AAPL", data["symbol"].ToString());
            Assert.IsTrue( double.Parse( data["price"]) > 0);
            Assert.IsTrue(double.Parse(data["beta"]) > 0);
            Assert.IsTrue(double.Parse(data["volumeAverage"]) > 0);
            Assert.IsTrue(double.Parse(data["marketCap"]) > 0);
            Assert.IsTrue(double.Parse(data["lastDiv"]) > 0);
            Assert.IsFalse( string.IsNullOrWhiteSpace( data["range"].ToString() ) );
            Assert.IsTrue(double.Parse(data["changes"]) > 0);
            Assert.IsFalse( string.IsNullOrWhiteSpace(data["changesPercentage"].ToString()) );
            Assert.AreEqual("Apple Inc.", data["companyName"].ToString());
            Assert.AreEqual("Nasdaq Global Select", data["exchange"].ToString());
            Assert.AreEqual("Computer Hardware", data["industry"].ToString() );
            Assert.IsFalse( string.IsNullOrWhiteSpace( data["description"].ToString() ) );
            Assert.AreEqual("Timothy D. Cook", data["ceo"].ToString());
            Assert.AreEqual("Technology", data["sector"].ToString());
            Assert.AreEqual("https://financialmodelingprep.com/images-New-jpg/AAPL.jpg", data["image"].ToString());
        }

        [TestMethod]
        public void Quote()
        {
            SetUp();
            Primitive data = LDFinances.Quote("AAPL")[1];

            Assert.IsTrue(Array.IsArray(data));
            Console.WriteLine(data.ToString());
            Assert.AreEqual("AAPL", data["symbol"].ToString());
            Assert.AreEqual("Apple Inc.", data["name"].ToString());
            Assert.IsTrue(double.Parse(data["price"]) > 0);
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["changesPercentage"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["change"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["dayLow"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["dayHigh"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["yearHigh"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["yearLow"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["marketCap"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["priceAvg50"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["priceAvg200"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["volume"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["avgVolume"].ToString()));
            Assert.AreEqual("NASDAQ", data["exchange"].ToString());
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["open"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["previousClose"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["eps"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["pe"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["earningsAnnouncement"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["sharesOutstanding"].ToString()));
            Assert.IsFalse(string.IsNullOrWhiteSpace(data["timestamp"].ToString()));
        }

        [TestMethod]
        public void Price()
        {
            SetUp();
            Primitive data = LDFinances.Price("AAPL");
            Console.WriteLine(data.ToString());
            Assert.IsTrue( Array.IsArray(data) );
            Assert.AreEqual("AAPL", data["symbol"].ToString());
            Assert.IsTrue( double.Parse(data["price"]) > 0 );
        }

        [TestMethod]
        public void Search()
        {
            SetUp();
            Primitive data = LDFinances.Search("AA", "NASDAQ");
            Console.WriteLine(data.ToString());
            for (int i = 1; i < 11; i++)
            {
                Assert.IsTrue( Array.IsArray(data[i]) );
                Console.WriteLine(data[i].ToString());
            }
        }

        [TestMethod]
        public void Statement()
        {
            SetUp();
            Primitive AnnualIncome = LDFinances.Statement("AAPL", "Annual", "Income");
            Primitive QuarterlyIncome = LDFinances.Statement("AAPL", "Quarterly", "Income");
            Primitive AnnualBalance = LDFinances.Statement("AAPL", "Annual", "Balance");
            Primitive QuarterlyBalance = LDFinances.Statement("AAPL", "Quarterly", "Balance");
            Primitive AnnualCashFlow = LDFinances.Statement("AAPL", "Annual", "CashFlow");
            Primitive QuarterlyCashFlow = LDFinances.Statement("AAPL", "Quarterly", "CashFlow");

            Assert.IsTrue( Array.IsArray(AnnualIncome) );
            Assert.IsTrue( Array.IsArray(AnnualBalance) );
            Assert.IsTrue( Array.IsArray(AnnualCashFlow));

            Assert.IsTrue( Array.IsArray(QuarterlyIncome) );
            Assert.IsTrue( Array.IsArray(QuarterlyBalance) );
            Assert.IsTrue( Array.IsArray(QuarterlyCashFlow) );

        }
    }
}
