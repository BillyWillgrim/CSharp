using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person(new DateTime(1995, 6, 25));

            Console.WriteLine(person.Age);

            person.SetNumber(10); // cannot set readonly field outside of class

            Console.WriteLine(person.Number);
        }
    }
}
