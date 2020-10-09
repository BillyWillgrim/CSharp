using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.SetBirthdate(new DateTime(1995, 6, 25));
            Console.WriteLine(person.GetBirthdate());

        }
    }
}
