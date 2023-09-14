//#define SVB 
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

using System;
using System.IO;
using LitDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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

            string temp = SBFile.GetTemporaryFilePath();
            LDFile.WriteCSV(temp, data );

            Primitive hash2 = LDEncryption.SHA512HashFile(temp);
            SBFile.DeleteFile(temp);

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
