using Xunit;

namespace ProjectForTestingHiddenTests.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void CalculatorAddShouldEqualToResult()
        {
            var calculator = new Calculator();

            var result = calculator.Add(15, 10);
            var expected = 25;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculatorDivideShouldEqualToResult()
        {
            var calculator = new Calculator();

            var result = calculator.Divide(12, 4);
            var expected = 3;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculatorMultiplyShouldEqualToResult()
        {
            var calculator = new Calculator();

            var result = calculator.Multiply(5, 20);
            var expected = 100;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculatorSubtractShouldEqualToResult()
        {
            var calculator = new Calculator();

            var result = calculator.Subtract(10, 5);
            var expected = 5;

            Assert.Equal(expected, result);
        }
    }
}