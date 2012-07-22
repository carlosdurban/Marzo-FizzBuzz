using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marzo_FizzBuzz
{
    public class FizzBuzzChecker
    {
      
        public string Check(List<int> numbers)
        {
            StringBuilder BizzBuzzBuilder = new StringBuilder();

            foreach (int number in numbers)
            {
                if (IsFizzBuzz(number))
                    BizzBuzzBuilder.Append(number + " FizzBuzz"+ System.Environment.NewLine);
                else if (IsFizz(number))
                    BizzBuzzBuilder.Append(number + " Fizz" + System.Environment.NewLine);
                else if (IsBuzz(number))
                    BizzBuzzBuilder.Append(number + " Buzz" + System.Environment.NewLine);
                else
                    BizzBuzzBuilder.Append(number + System.Environment.NewLine);
            }
            return BizzBuzzBuilder.ToString();
        }

        protected bool IsFizzBuzz(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        protected bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        protected bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}
