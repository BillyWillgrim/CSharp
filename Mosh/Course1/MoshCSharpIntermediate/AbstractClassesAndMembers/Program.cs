﻿using System;

namespace AbstractClassesAndMembers
{

    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();

            rectangle.Draw();
        }
    }
}
