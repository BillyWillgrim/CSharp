﻿using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void Cut()
        {
            Console.WriteLine("Object removed and copied to cliboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object duplicated");
        }
    }
}
