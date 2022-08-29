using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float PI = 3.1416F;
            float radius = 100F;
            float area = PI * radius * radius;
            Console.WriteLine("Area of the circle is " +area+ "m. ");
            Console.ReadKey();
        }
    }
}
