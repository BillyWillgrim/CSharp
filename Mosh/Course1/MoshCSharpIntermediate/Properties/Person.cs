using System;
using System.Runtime.InteropServices.ComTypes;

namespace Properties
{
    public class Person
    {

        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        private int _number;

        public void SetNumber(int number)
        {
            this._number = number;
        }

        public int GetNumber()
        {
            return _number;
        }

        public int Number { get; private set; } = 20;




        public Person(DateTime birthDate)
        {
            Birthdate = birthDate;
        }


        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
