using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 }; // is the same as int[] numbers = new int[] {3,7,8,2,14,6}

            // Length
            Console.WriteLine("Length of array: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);

            Console.WriteLine("Index of 9 is " + index);

            // Clear()

            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            Console.WriteLine("Effect of Copy()");
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // sort()
            Console.WriteLine("Effect of Sort()");
            Array.Sort(numbers);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Console.WriteLine("Effect of Reverse()");
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
