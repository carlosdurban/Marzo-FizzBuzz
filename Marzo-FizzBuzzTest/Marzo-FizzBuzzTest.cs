using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using Marzo_FizzBuzz;


namespace Marzo_FizzBuzzTest
{
    [TestFixture]
    public class Marzo_FizzBuzzTest
    {
        [Test]
        public void CheckFizzBuzzNumbers()
        {
            FizzBuzzChecker FizzBuzz = new FizzBuzzChecker();

            List<int> Numbers = Enumerable.Range(1, 100).ToList();

            Console.Write(FizzBuzz.Check(Numbers));
        }
    }
}
