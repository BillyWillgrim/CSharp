using System;
using System.Net;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int number;
            // var number = int.Parse("abc");
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 5, 6, 7, 8, 9 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);

                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
