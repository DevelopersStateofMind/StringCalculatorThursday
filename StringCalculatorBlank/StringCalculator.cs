using System;
using System.Linq;

namespace StringCalculatorBlank
{
    public class StringCalculator
    {
        private readonly ILogger _logger;

        public StringCalculator(ILogger logger)
        {
            _logger = logger;
        }

        public int Add(string numbers)
        {
            var answer =  numbers == "" ? 0 :
             numbers.Split(',')
                       .Select(int.Parse) // Map
                       .Sum();

            _logger.Write(answer.ToString());

            return answer;
        }
    }
}