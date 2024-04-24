using System;
using System.Globalization;
using C_sharp_constructors_this_overloading_encapsulation;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            Point m = new Point();

            Console.WriteLine(m);
        }
    }
}
