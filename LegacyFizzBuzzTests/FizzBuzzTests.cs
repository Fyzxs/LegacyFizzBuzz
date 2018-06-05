using FizzBuzzToRefactor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LegacyFizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void ShouldReturnStringOfInput() => Assert.AreEqual("2", FizzBuzzer.FizzBuzz(2));

        [TestMethod]
        public void ShouldReturnFizz() => Assert.AreEqual("Fizz", FizzBuzzer.FizzBuzz(6));

        [TestMethod]
        public void ShouldReturnBuzz() => Assert.AreEqual("Bµzz", FizzBuzzer.FizzBuzz(10));

        [TestMethod]
        public void ShouldReturnFizzBuzz() => Assert.AreEqual("FizzBµzz", FizzBuzzer.FizzBuzz(30));
    }
}
