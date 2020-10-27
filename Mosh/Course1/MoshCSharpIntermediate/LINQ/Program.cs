using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    public class LINQWithLists
    {
        

        public IEnumerable<int> RetrieveFirstNEvenNumbers(IEnumerable<int> numbers, int n)
        {
            IEnumerable<int> evenNumbers;

            evenNumbers = numbers.Where(x => x % 2 == 0).Take(n);

            return evenNumbers;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var LINQClass = new LINQWithLists();

            var numbersInput = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var firstFiveEvenNumbers = LINQClass.RetrieveFirstNEvenNumbers(numbersInput, 5);

            foreach (var evenNumber in firstFiveEvenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

        }
    }
}
