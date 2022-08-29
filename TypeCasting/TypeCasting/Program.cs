using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            double numDouble = 1.23;

            // Explicit casting
            int numInt = (int)numDouble;

            // Value before conversion
            Console.WriteLine("Original double Value: " + numDouble);

            // Value before conversion
            Console.WriteLine("Converted int Value: " + numInt);

            Console.WriteLine("Original double Value: " + numDouble);

            Console.ReadLine();
        }
    }
}