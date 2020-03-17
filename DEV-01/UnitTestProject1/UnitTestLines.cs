using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestLines
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckValue_NullException()
        {
            DEV_1.Lines line = new DEV_1.Lines(null);
        }

        [TestMethod]
        public void Counting_NormalLine()
        {
            DEV_1.Lines line = new DEV_1.Lines("abadcddd");
            int actual = line.CountingNonRepeatingLetters();
            int expected = 6;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Counting_EmptyLine()
        {
            DEV_1.Lines line = new DEV_1.Lines(String.Empty);
            int actual = line.CountingNonRepeatingLetters();
            int expected = 0;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Counting_LongLine_FewRepit()
        {
            DEV_1.Lines line = new DEV_1.Lines("nkjgbnrfvbriubvldkfjbvlurdblbvldfuvhdufvlbdfbvuldf" +
                "uvbldifubvlduifvbdlfbvdflkjvbfyblrdbvflkvmdfvmourfnvdfiuvhdfuhvdnfmfuvhfbvnkmoseifruhg" +
                "lserjfnvmfuvhdfvffvuervhlfkdsfuduyghbgjeiiivisdvolfvfffjijijllllfudddddvbdksfhhrhlvru" +
                "uuuwfennnnnnnvfirbvvvvvrudslkfvnjfdslfjvblweiunfvlrdsivruldvnurrvnlrdiuvnldsifurgnfjvk" +
                "fffffvnldfvnjfkkkkkdlfvnerrlviiiiirnfvliiiiiiibnnnnnnruvldirjnvruuuuuvnldruubvnkldrklvr" +
                "vndlvurfnldfubfvnrivnuldsdurvbruidlfmmmmdlrjvunsrnulufvlrdivrbvldsfnvjruhbvnsdljvfusdll" +
                "llvnruvdlsfvnuslbllvlrsirurv");
            int actual = line.CountingNonRepeatingLetters();
            int expected = 153;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Counting_AllRepit()
        {
            DEV_1.Lines line = new DEV_1.Lines("aaa");
            int actual = line.CountingNonRepeatingLetters();
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Counting_LittersToLower()
        {
            DEV_1.Lines line = new DEV_1.Lines("AbaBcDDd");
            int actual = line.CountingNonRepeatingLetters();
            int expected = 6;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Counting_OneLitter()
        {
            DEV_1.Lines line = new DEV_1.Lines("a");
            int actual = line.CountingNonRepeatingLetters();
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Counting_Space()
        {
            DEV_1.Lines line = new DEV_1.Lines("  ");
            int actual = line.CountingNonRepeatingLetters();
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }
    }
}
