using NUnit.Framework;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Calculator_Add1And1_Returns2()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(2,calc.Add(1, 1));
        }

        [Test]
        public void Calculator_Multiply5And6_returns30()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(30,calc.Multiply(5, 6));
        }

        [Test]
        public void Calculator_Subtract15And3_Return12()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(12 ,calc.Subtract(15, 3));
        }

        [Test]
        public void Calculator_Power3And3_Return27()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(27 ,calc.Power(3, 3));
        }
    }
}