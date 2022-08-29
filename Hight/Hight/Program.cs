using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float h = 5.7F;
            float inch = 2.54F;

            Console.WriteLine("Heighr is " + (h * inch));
            Console.ReadKey();

        }
    }
}
