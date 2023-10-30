using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        [TestInitialize] 
        public void SetUp()
        {
            c = new Calculation(10, 5);
        }
        //Trường hợp Test Đúng: Expected và Actual ra cùng một kết quả
        [TestMethod]
        public void Test_Cong() {
            int expected, actual;
            //Calcution c = new Calculation(a, b)
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        //Trường hợp Test Sai: Expected và Actual ra khác kết quả
        [TestMethod]
        public void Test_Tru()
        {
            int expected, actual;
            //Calcution c = new Calculation(a, b)
            expected = 6;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhan()
        {
            int expected, actual;
            //Calcution c = new Calculation(a, b)
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chia()
        {
            int expected, actual;
            //Calcution c = new Calculation(a, b)
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Trường hợp ngoại lệ chia cho DivideByZeroException
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }
    }
}
