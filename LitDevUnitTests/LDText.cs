using LitDev;
using Microsoft.SmallBasic.Library;
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
