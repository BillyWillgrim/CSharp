using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
        // There are a number of benefits to using polymorphism:

        /* 
            If we had stuck to the enum structure, we would have to define a new algorithm for drawing each type of shape in this method, and as we add more shapes, the fatter this method becomes.

            We fixed this problem by using encapsulation. We encapsulated the implementation of drawing a circle within the circle class.

            If we added a triangle tomorrow, this would not modify the canvas class, or the base Shape class. - Losely coupled :)
         */

    }
}
