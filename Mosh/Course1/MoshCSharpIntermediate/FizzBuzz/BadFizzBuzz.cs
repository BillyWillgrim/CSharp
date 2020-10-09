using System;

namespace FizzBuzz
{
    public class BadFizzBuzz
    {
        public void FizzBuzz()
        {
            var fizzbuzzNumber = 0;

            for (int i = 1; i <= 100; i++)
            {
                fizzbuzzNumber = i;
                if (fizzbuzzNumber % 5 == 0 && fizzbuzzNumber % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (fizzbuzzNumber % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (fizzbuzzNumber % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(fizzbuzzNumber);
                }
            }
        }
    }
}
