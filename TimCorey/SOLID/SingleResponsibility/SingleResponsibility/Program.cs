using System;

namespace SingleResponsibility
{
    class Program
    {
        // this console application asks for a users first and last name. It validates both names and generates a username for that user. The problem is that it violates SRP.
        // SRP States that a class should only have one responsibility - "A class should only have one reason to change"
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this console app demonstrating the importance of The Single Responsibility Principle (SRP)!");

            // Ask for user info
            var user = new Person();


            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            user.LastName = Console.ReadLine();

            // Check if first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                Console.ReadLine();
                return;
            }

            // create a username for the person
            Console.WriteLine($"Your username is { user.FirstName.Substring(0,1) }{ user.LastName }");

            Console.ReadLine();
            

        }
    }
}
