using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    public class Point
    {
        private int x;
        private int y;
        private string color;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Color { get { return color; } }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowChords()
        {
            Console.WriteLine("X= " + x + ", Y= " + y);
        }

        public double Distance()
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return result;
        }

        public void ReplacePoint(int a, int b)
        {
            Console.WriteLine($"New x is: {x + a}");
            Console.WriteLine($"New y is: {y + b}");
        }
    }
}
