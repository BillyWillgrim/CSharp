using System;

namespace IntroToArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3]; // same as int[] numbers = new int[3]
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var words = new string[3];
            words[0] = "Scotland";

            Console.WriteLine(words[0]);
            Console.WriteLine(words[1]);
            Console.WriteLine(words[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
        }
    }
}
