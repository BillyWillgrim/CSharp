using System.Runtime.InteropServices.ComTypes;

namespace FizzBuzz
{


    class Program
    {
        static void Main(string[] args)
        {
            // count up from 1 to 100

            // each time you hit a multiple of 3 print "fizz"

            // each time you hit a multiple of 5 print "buzz"

            // each time you hit a multiple of 3 and 5 print "fizzbuzz"


            var badFizzBuzz = new BadFizzBuzz();

            //badFizzBuzz.FizzBuzz();

            var betterFizzBuzz = new BetterFizzBuzz();

            betterFizzBuzz.FizzBuzz(3, 4);
            

        }
    }
}
