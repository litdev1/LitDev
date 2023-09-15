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

using LitDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LitDevUnitTests
{
    [TestClass]
    public class LDTextTest
    {
        [TestMethod]
        public void Split()
        {
            string phrase = "The quick brown fox jumps over the lazy dog, twice a month";
            Primitive array = "1=The;2=quick;3=brown;4=fox;5=jumps;6=over;7=the;8=lazy;9=dog,;" +
                              "10=twice;11=a;12=month;";

            Primitive array2 = "1=The;2=quick;3=brown;4=fox;5=jumps;6=over;7=the;8=lazy;9=dog;" +
                               "10=twice;11=a;12=month;";

            Assert.AreEqual( array, LDText.Split(phrase," ") );
            Assert.AreEqual( array2, LDText.Split(phrase, "1= ;2=,;"));
        }

        [TestMethod]
        public void FindAll()
        {
            string phrase = "One morning I shot an elephant in my pajamas. How he got in my pajamas, I don't know.";
            Primitive array = "1=38;2=64;";

            Assert.AreEqual(array, LDText.FindAll(phrase, "pajamas"));
        }
    }
}
