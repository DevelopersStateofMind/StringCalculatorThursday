using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringCalculatorBlank
{
    // https://osherove.com/tdd-kata-1
  

    public class StringCalculatorTests
    {
        private readonly StringCalculator _calculator;

        public StringCalculatorTests()
        {
            _calculator = new StringCalculator(new Mock<ILogger>().Object);
        }

        [Fact]
        public void EmptyStringReturnsZero()
        {
            int answer = _calculator.Add("");

            Assert.Equal(0, answer);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        [InlineData("999", 999)]
        public void SingleDigits(string numbers, int expected)
        {
            int answer = _calculator.Add(numbers);

            Assert.Equal(expected, answer);
        }
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,2",4)]
        public void MultipleDigits(string numbers, int expected)
        {
            int answer = _calculator.Add(numbers);

            Assert.Equal(expected, answer);
        }
    }
}
