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
            Engine.key = key;
            LDFinances.Key = key;
        }

        [TestMethod]
        public void GetProfile()
        {
            SetUp();
            Assert.IsFalse(string.IsNullOrWhiteSpace(Engine.key));
            var data = Engine.GetDescription("AAPL");
            Console.WriteLine(Engine.LastURL);

        }

        [TestMethod]
        public void GetStockPrice()
        {
            SetUp();
            var price = Engine.GetRealTimePrice("AAPL");
            Assert.IsNotNull( price.date.ToString() );
            Assert.IsTrue( price.close > 0 );
            Assert.IsTrue(price.high > 0);
            Assert.IsTrue(price.low > 0);
            Assert.IsTrue(price.open > 0);
            Assert.IsTrue(price.volume >= 0);
        }

        [TestMethod]
        public void GetHistoricalStockPrices()
        {
            SetUp();
            var price = Engine.GetHistoricalPrice("AAPL", "2019-01-02", "2020-01-31", "daily");
            var firstDay = price[0];
            var lastDay = price[price.Length - 1];

            Console.WriteLine(lastDay.ToString());

            Assert.IsNotNull(firstDay.date.ToString());
            Assert.IsTrue(firstDay.close > 0);
            Assert.IsTrue(firstDay.high > 0);
            Assert.IsTrue(firstDay.low > 0);
            Assert.IsTrue(firstDay.open > 0);
            Assert.IsTrue(firstDay.volume >= 0);

            Assert.IsNotNull(lastDay.date.ToString());
            Assert.IsTrue(lastDay.close > 0);
            Assert.IsTrue(lastDay.high > 0);
            Assert.IsTrue(lastDay.low > 0);
            Assert.IsTrue(lastDay.open > 0);
            Assert.IsTrue(lastDay.volume >= 0);

        }
    }
}
