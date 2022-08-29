using System;

namespace Conversion
{
    class Program
    {

        static void Main(string[] args)
        {

            string n = "100";

            // converting string to int type
            int a = int.Parse(n);
            Console.WriteLine("Original string value: " + n);
            Console.WriteLine("Converted int value: " + a);
            Console.ReadLine();
        }
    }
}