using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords;

namespace NumberWordsTest
{
    [TestClass]
    public class NumberToWordsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strWord = ConvertNumberToWords.NumberToWord(13456);
            Assert.AreEqual(strWord, "thirteen thousand, four hundred fifty-six");
        }

        [TestMethod]
        public void TestMethod2()
        {            
            string strWord = ConvertNumberToWords.NumberToWord(-5);
            Assert.AreEqual(strWord, "negative five");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string strWord = ConvertNumberToWords.NumberToWord(9923);
            Assert.AreEqual(strWord, "nine thousand, nine hundred twenty-three");
        }

        [TestMethod]
        public void TestMethod4()
        {
            string strWord = ConvertNumberToWords.NumberToWord(523);
            Assert.AreEqual(strWord, "five hundred twenty-three");
        }

        [TestMethod]
        public void TestMethod5()
        {
            string strWord = ConvertNumberToWords.NumberToWord(8989);
            Assert.AreEqual(strWord, "eight thousand, nine hundred eighty-nine");
        }
    }
}
