using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace UpcastingAndDowncasting
{

    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            // upcasting
            Shape shape = text; // no conversion required
            /*
             We can implicitly convert an object reference (text) to a base class reference (shape).

            Both the text and shape objects are both references to the same object in memory, but they have different views.

            text. will retrieve more properties and methods than shape.

             */

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); // will print 100 on the console as both text and shape reference the same object in memory, they just have different views

            //What's the point of converting an object reference to its base class reference? POLYMORPHISM

            // in .net framework Stream is the parent of every kind of stream, i.e. filestream or memory stream

            var reader = new StreamReader(new MemoryStream()); // any object we pass here, will be automatically upcast to it's parent class - Stream

            var list = new ArrayList();

            list.Add(1);
            list.Add("monkey");
            list.Add(shape);
            list.Add(new Text());
            list.Add(new Shape());
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // in real world applications we should not really use the ArrayList class because it is not type safe list - we can store a different kind of object in every element.

            // It is better to use generic lists!

            var anotherList = new List<Shape>(); // here we can only store Shape objects, or any instance of a class deriving from Shape

            // Downcasting

            Shape anotherShape = new Text(); // at compile time the type of anotherShape is Shape, but at runtime it's type will be Text

            //problem: if we type anotherShape. we get a limited view - we can't  access the members defined in the Text class

            // this is when we should downcast the anotherShape object:

            Text anotherText = (Text)anotherShape;

            // anotherText has access to every member of both classes now

            // What is a real world example? -- see WpfApp1 project.


        }
    }
}
