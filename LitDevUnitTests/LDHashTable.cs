using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LitDev;


namespace LitDevUnitTests
{
    [TestClass]
    public class LDHashTableTest
    {
        [TestMethod]
        public void Add()
        {
            LDHashTable.Clear("test");
            int count = LDHashTable.Add("test", "A", 1);
            Assert.AreEqual(1, count);

            count = LDHashTable.Add("test", "B", 1);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Remove()
        {
            LDHashTable.Clear("test");
            LDHashTable.Add("test", "A", 1);
            LDHashTable.Add("test", "B", 1);

            Assert.AreEqual(-1, (int)LDHashTable.Remove("foo", "B"));
            Assert.AreEqual(1, (int)LDHashTable.Remove("test", "A"));
        }

        [TestMethod]
        public void ContainsKey()
        {
            LDHashTable.Clear("test");
            LDHashTable.Add("test", "A", 1);

            Assert.AreEqual("False", LDHashTable.ContainsKey("foo12", "A").ToString());
            Assert.AreEqual("False", LDHashTable.ContainsKey("test", "B").ToString());
            Assert.AreEqual("True", LDHashTable.ContainsKey("test", "A").ToString());
        }

        [TestMethod]
        public void ContainsValue()
        {
            LDHashTable.Clear("test");
            LDHashTable.Add("test", "A", 1);
            LDHashTable.Add("test", "B", 2);

            Assert.AreEqual("True", LDHashTable.ContainsValue("test", 1).ToString());
            Assert.AreEqual("False", LDHashTable.ContainsValue("test", 3).ToString());
            Assert.AreEqual("False", LDHashTable.ContainsValue("fbs1", 3).ToString());
        }

        [TestMethod]
        public void Clear()
        {
            LDHashTable.Clear("test");
            LDHashTable.Add("test", "A", 1);
            LDHashTable.Add("test", "B", 2);

            Assert.AreEqual(-1, (int)LDHashTable.Clear("sjasf"));
            Assert.AreEqual(0, (int)LDHashTable.Clear("test"));
        }

        [TestMethod]
        public void GetValue()
        {
            LDHashTable.Clear("test");
            LDHashTable.Add("test", "A", 1);
            LDHashTable.Add("test", "B", 2);

            Assert.AreEqual("", LDHashTable.GetValue("test", "C").ToString());
            Assert.AreEqual("", LDHashTable.GetValue("fo334", "C").ToString());
            Assert.AreEqual(1, (int)LDHashTable.GetValue("test", "A"));
        }

        [TestMethod]
        public void ToArray()
        {
            LDHashTable.Clear("test");
            LDHashTable.Add("test", "A", 1);
            LDHashTable.Add("test", "B", 2);

            Assert.AreEqual("A=1;B=2;" , LDHashTable.ToArray("test").ToString() );
        }
    }
}