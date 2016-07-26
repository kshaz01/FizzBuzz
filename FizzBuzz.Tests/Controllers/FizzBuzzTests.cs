using System;
using NUnit.Framework;
using FizzBuzz.Domain.Entities;
namespace FizzBuzz.Tests.Controllers
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private readonly Interaction _app;

        public FizzBuzzTests()
	    {
            _app = new Interaction();
	    }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
        {
            Assert.That(_app.Start(3),Does.Match("Fizz"));
            Assert.That(_app.Start(6), Does.Match("Fizz"));
            Assert.That(_app.Start(9), Does.Match("Fizz"));
        }
        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
        {
            Assert.That(_app.Start(5), Does.Match("Buzz"));
            Assert.That(_app.Start(10), Does.Match("Buzz"));
            Assert.That(_app.Start(20), Does.Match("Buzz"));
        }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5()
        {
            Assert.That(_app.Start(15), Does.Match("FizzBuzz"));
            Assert.That(_app.Start(30), Does.Match("FizzBuzz"));
            Assert.That(_app.Start(45), Does.Match("FizzBuzz"));
        }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            Assert.That(_app.Start(7), Does.Match("7"));
            Assert.That(_app.Start(17), Does.Match("17"));
            Assert.That(_app.Start(1), Does.Match("1"));
        }
    }
}
