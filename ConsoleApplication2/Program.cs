using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.142;
            double area;
            const int number = 2;
            double circum;

            Console.WriteLine("Enter Radius of the Circle");
            var radius = Double.Parse(Console.ReadLine());

            area = (pi * radius * radius);
            circum = (number * pi * radius);
            Console.WriteLine("area = {0}; circumference = {1}", area, circum);



        }
    }
}
