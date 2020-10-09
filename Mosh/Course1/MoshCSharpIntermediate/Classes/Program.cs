using System;

namespace Classes
{

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Will = new Person();
            Will.Name = "Will";
            Will.Introduce("Jo");

            // this doesn't really make sense, why would we call the Parse() method on a prexisitng person object to create a new person?
            // var Henry = Will.Parse("Henry");
            //instead, we will make the Parse method static so that is is called from the Class instead:
            var Henry = Person.Parse("Henry");
            Henry.Introduce("Tom");            

        }
    }
}
