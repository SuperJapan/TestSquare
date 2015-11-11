using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilSquare;

namespace UnitTestUtilSquare
{
    [TestClass]
    public class UnitTestUtilSq
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 1298;
            
            double a = 44; double b = 59;
            double square = UtilMath.getSquareTriangle(a, b);
            Console.WriteLine("square:" + square);

            double actual = square;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
