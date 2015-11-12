using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilSquare;

namespace UnitTestUtilSquare
{
    [TestClass]
    public class UnitTestUtilSq
    {
        [TestMethod]
        public void TestCorrectArguments()
        {
            double expected = 1298;

            double a = 44, b = 59;
            double actual = UtilMath.getSquareTriangle(a, b);

            Assert.AreEqual(expected, actual, 0.001, "result is not as expected");
        }

        [TestMethod]
        public void TestCorrectArguments1()
        {
            double expected = 1233.75;

            double a = 105, b = 23.5;
            double actual = UtilMath.getSquareTriangle(a, b);

            Assert.AreEqual(expected, actual, 0.001, "result is not as expected");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIncorrectArgumentsIsLessThanZero()
        {
            double a = -10, b = 19;
            double actual = UtilMath.getSquareTriangle(a, b);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIncorrectArgumentsIsEqualToZero()
        {
            double a = 0, b = 19;
            double square = UtilMath.getSquareTriangle(a, b);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void TestIncorrectArgumentsLessThanZero1()
        {
            double a = 10, b = -1;

            try
            {
                double actual = UtilMath.getSquareTriangle(a, b);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, UtilMath.ArgumentLessThanZeroMessage);
            }
        }

        [TestMethod]
        public void TestIncorrectArgumentsIsEqualToZero1()
        {
            double a = 0, b = 15;
            try
            {
                double actual = UtilMath.getSquareTriangle(a, b);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, UtilMath.ArgumentIsEqualToZeroMessage);
            }
        }
    }
}
