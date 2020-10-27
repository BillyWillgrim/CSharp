using System.Collections.Generic;

namespace MethodOverriding
{

    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();

            canvas.DrawShapes(new List<Shape> {new Circle(), new Rectangle(), new Shape(), new Triangle() });
        }
    }
}
