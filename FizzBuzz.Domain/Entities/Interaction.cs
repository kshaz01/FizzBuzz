using FizzBuzz.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Domain.Entities
{
    public class Interaction : IInteraction
    {
        public IEnumerable<string> Start(int value)
        {
            return Enumerable.Range(1, value).Select(Output);
        }

        public string Output(int input)
        {
            if (input % 3 == 0 && input % 5 != 0)
                return "Fizz";
            if (input % 5 == 0 && input % 3 != 0)
                return "Buzz";
            if (input % 3 == 0 && input % 5 == 0)
                return "Fizz Buzz";
            else
                return input.ToString();

        }
    }
}
