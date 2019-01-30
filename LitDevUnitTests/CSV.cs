using System;
using System.IO;
using Microsoft.SmallBasic.Library;
using LitDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using File = Microsoft.SmallBasic.Library.File;

namespace LitDevUnitTests
{
    [TestClass]
    public class CSV
    {
        private string path;

        
        public void SetUp()
        {
            path = Path.Combine(Parent(Parent(Directory.GetCurrentDirectory())), "Test Files", "Sacramento realestate transactions.csv"); ;
        }

        [TestMethod]
        public void Write()
        {
            SetUp();
            Primitive data = LDFile.ReadCSV(path);
            Primitive hash = LDEncryption.SHA512HashFile(path);

            string temp = File.GetTemporaryFilePath();
            LDFile.WriteCSV(temp, data );

            Primitive hash2 = LDEncryption.SHA512HashFile(temp);
            File.DeleteFile(temp);

            Assert.AreEqual(hash, hash2);
        }

        [TestMethod]
        public void Read()
        {
            SetUp();
            Primitive data = LDFile.ReadCSV(path);
            Primitive headers = data[1];

            string[] columns = new [] {"street", "city", "zip", "state", "beds", "baths", "sq__ft", "type", "sale_date","price", "latitude", "longitude" };
            Assert.AreEqual(columns.ToPrimitiveArray(), headers.ToString());
            Assert.AreEqual("3882 YELLOWSTONE LN", (data[986][1]).ToString());
        }

        string Parent(string directory)
        {
            return Directory.GetParent(directory).FullName;
        }
    }
}
