using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("potato");
            list.Add(DateTime.Today);

            var number = (int)list[1]; // throws error due to lack of type safety

            // but there is another problem. The ArrayList.Add method takes in an argument that is an argument of type Object.
            // This means that when we pass in a value type like 1 or DateTime.Today then boxing will happen
            // subsequently, when we get that value back and cast it - unboxing happens

            // it is better to use a generic list 

            var anotherList = new List<int>(); // this gives us type safety and avoids the need for boxing and unboxing

            var names = new List<string>();
            

            

           







        }
    }
}
