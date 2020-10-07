using Classes.Math;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            var will = new Person();
            will.FirstName = "Will";
            will.LastName = "Gash";
            will.Introduce();

            Calculator calculator = new Calculator();

            var addResult = calculator.Add(5, 7);
            Console.WriteLine(addResult);
        }
    }
}
