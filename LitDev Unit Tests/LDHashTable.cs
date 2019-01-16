using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LitDev;


namespace LitDevTests
{
    [TestClass]
    public class LDHashTableTest
    {
        
        [TestMethod]
        public void Add()
        {
            LDHashtable.Clear("test");
            int count = LDHashtable.Add("test", "A", 1);
            Assert.AreEqual(1, count);

            count = LDHashtable.Add("test", "B", 1);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Remove()
        {
            LDHashtable.Clear("test");
            LDHashtable.Add("test", "A", 1);
            LDHashtable.Add("test", "B", 1);

            Assert.AreEqual(-1, (int)LDHashtable.Remove("foo","B"));
            Assert.AreEqual(1, (int)LDHashtable.Remove("test","A"));
        }

        [TestMethod]
        public void ContainsKey()
        {
            LDHashtable.Clear("test");
            LDHashtable.Add("test", "A", 1);

            Assert.AreEqual("False", LDHashtable.ContainsKey("foo12","A").ToString());
            Assert.AreEqual("False", LDHashtable.ContainsKey("test", "B").ToString());
            Assert.AreEqual("True", LDHashtable.ContainsKey("test", "A").ToString());
        }

        [TestMethod]
        public void ContainsValue()
        {
            LDHashtable.Clear("test");
            LDHashtable.Add("test", "A", 1);
            LDHashtable.Add("test", "B", 2);

            Assert.AreEqual("True", LDHashtable.ContainsValue("test", 1).ToString());
            Assert.AreEqual("False", LDHashtable.ContainsValue("test", 3).ToString());
            Assert.AreEqual("False", LDHashtable.ContainsValue("fbs1",3).ToString());
        }

        [TestMethod]
        public void Clear()
        {
            LDHashtable.Clear("test");
            LDHashtable.Add("test", "A", 1);
            LDHashtable.Add("test", "B", 2);

            Assert.AreEqual(-1, (int)LDHashtable.Clear("sjasf"));
            Assert.AreEqual(0, (int)LDHashtable.Clear("test"));
        }

        [TestMethod]
        public void GetValue()
        {
            LDHashtable.Clear("test");
            LDHashtable.Add("test", "A", 1);
            LDHashtable.Add("test", "B", 2);

            Assert.AreEqual("", LDHashtable.GetValue("test", "C").ToString() );
            Assert.AreEqual("", LDHashtable.GetValue("fo334", "C").ToString());
            Assert.AreEqual(1, (int)LDHashtable.GetValue("test","A"));
        }
    }
}
