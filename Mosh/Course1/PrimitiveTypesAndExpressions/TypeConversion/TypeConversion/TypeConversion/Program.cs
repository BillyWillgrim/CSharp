using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string number = "1234";
                // int i = (int)number; does not work, even explicitly 
                // instead we must use the convert class

                // this will throw an exception due to the fact that 1234 is too large a number to be stored as a byte
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }


            try
            {
                string str = "false";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("the value of str was not recognised as a valid boolean");
            }
            

        }
    }
}
