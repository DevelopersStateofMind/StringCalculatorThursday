using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringCalculatorBlank
{
    public class StringCalculatorLogsAnswer
    {
        private readonly StringCalculator _calculator;
        private readonly Mock<ILogger> _mockedLogger;
        public StringCalculatorLogsAnswer()
        {
            _mockedLogger = new Mock<ILogger>();
            _calculator = new StringCalculator(_mockedLogger.Object);
        }

        [Theory]
        [InlineData("1", "1")]
        [InlineData("1,2,3,4,5,6,7,8,9", "45")]
        public void AnswerIsLogged(string numbers, string expected)
        {
            // Given (in the constructor)
            // When
            _calculator.Add(numbers);
            // Then??
            _mockedLogger.Verify(m => m.Write(expected));

        }
    }
}
