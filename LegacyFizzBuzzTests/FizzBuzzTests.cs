using System;
using FizzBuzzToRefactor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LegacyFizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void ShouldReturnStringOfInputGiven2() => Assert.AreEqual("2", FizzBuzzer.FizzBuzz(2));

        [TestMethod]
        public void ShouldReturnFizzGiven6() => Assert.AreEqual("Fizz", FizzBuzzer.FizzBuzz(6));

        [TestMethod]
        public void ShouldReturnFizzGiven3() => Assert.AreEqual("3", FizzBuzzer.FizzBuzz(3));

        [TestMethod]
        public void ShouldReturnBuzzGiven10() => Assert.AreEqual("Bµzz", FizzBuzzer.FizzBuzz(10));

        [TestMethod]
        public void ShouldReturnFizzBuzzGiven30() => Assert.AreEqual("FizzBuzz", FizzBuzzer.FizzBuzz(30));

        [TestMethod]
        public void ShouldThrowExceptionGivenLessThanZero() => Assert.ThrowsException<ArithmeticException>(() => FizzBuzzer.FizzBuzz(-1));

        [TestMethod]
        public void ShouldThrowExceptionButInsteadReturnsFizzBuzzGiven0() => Assert.AreEqual("FizzBuzz", FizzBuzzer.FizzBuzz(0));

        [TestMethod]
        public void ShouldThrowExceptionButInsteadReturnsValueGivenGreaterThan100() => Assert.AreEqual("101", FizzBuzzer.FizzBuzz(101));
    }
}
