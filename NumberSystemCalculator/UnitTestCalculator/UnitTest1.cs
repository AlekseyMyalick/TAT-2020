using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("10", "A")]
        [DataRow("11", "B")]
        [DataRow("12", "C")]
        [DataRow("13", "D")]
        [DataRow("14", "E")]
        [DataRow("15", "F")]
        [DataRow("16", "G")]
        [DataRow("17", "H")]
        [DataRow("18", "I")]
        [DataRow("19", "J")]
        [DataRow("20", "")]
        public void ResiderGreaterNine_TestCase(string number ,string expected)
        {
            Assert.AreEqual(expected, 
                DEV_1_2.NumberSystem.ResiderGreaterNine(number));
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(10, 2, "1010")]
        [DataRow(230, 2, "11100110")]
        [DataRow(10, 3, "101")]
        [DataRow(10, 4, "22")]
        [DataRow(10, 5, "20")]
        [DataRow(10, 6, "14")]
        [DataRow(10, 7, "13")]
        [DataRow(10, 8, "12")]
        [DataRow(10, 9, "11")]
        [DataRow(10, 10, "10")]
        [DataRow(10, 11, "A")]
        [DataRow(110, 12, "92")]
        [DataRow(110, 13, "86")]
        [DataRow(110, 14, "7C")]
        [DataRow(110, 15, "75")]
        [DataRow(174, 16, "AE")]
        [DataRow(519, 17, "1D9")]
        [DataRow(230, 18, "CE")]
        [DataRow(53600, 19, "7F91")]
        [DataRow(110, 20, "5A")]
        public void TransferToNewSystem_Test(int number, int system, string expected)
        {
            DEV_1_2.NumberSystem numberSystem =
                new DEV_1_2.NumberSystem(number, system);
            Assert.AreEqual(expected, numberSystem.TransferToNewSystem());
        }

        [TestMethod]
        public void CorrectSequence_Test()
        {
            List<string> first = new List<string>() { "A","B","C","D" };
            string actual = DEV_1_2.NumberSystem.CorrectSequence(first);
            Assert.AreEqual(actual, "DCBA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckSystemLessThenTwo()
        {
            DEV_1_2.NumberSystem numberSystem =
                new DEV_1_2.NumberSystem(10,1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckSystemMoreThenTwenty()
        {
            DEV_1_2.NumberSystem numberSystem =
                new DEV_1_2.NumberSystem(10, 22);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckNumber_NumberLessThenZero()
        {
            DEV_1_2.NumberSystem numberSystem =
                new DEV_1_2.NumberSystem(-10, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckNumber_SysyemLessThenZero()
        {
            DEV_1_2.NumberSystem numberSystem =
                new DEV_1_2.NumberSystem(10, -2);
        }

    }
}
