namespace Calculator.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Subtraction(10, 10) == 0);
            Assert.That(calc.Subtraction(100, 10) == 90);
            Assert.That(calc.Subtraction(0, 10) == -10);
        }

        [Test]
        public void DivisionMustReturhCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Division(10, 10) == 1);
            Assert.That(calc.Division(100, 10) == 10);
            Assert.That(calc.Division(0, 10) == 0);
        }

        [Test]
        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Additional(10, 10) == 20);
            Assert.That(calc.Additional(100, 10) == 110);
            Assert.That(calc.Additional(0, 10) == 10);
        }

        [Test]
        public void MultiplicationlMustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Miltiplication(10, 10) == 100);
            Assert.That(calc.Miltiplication(100, 10) == 1000);
            Assert.That(calc.Miltiplication(0, 10) == 0);
        }

    }
}
