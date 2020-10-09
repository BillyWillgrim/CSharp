using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // defensive programming
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            Move(newLocation.X, newLocation.Y);
            // use this to avoid code duplication

            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }
    }
}
