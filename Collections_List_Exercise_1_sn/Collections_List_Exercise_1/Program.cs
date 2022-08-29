/*
using System;
using System.Collections.Generic; 
*/

namespace Collections_List_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<string> cities = new System.Collections.Generic.List<string>();

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add(cities.Capacity.ToString("Dhaka"));                                                                               //1

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add("ABC");                                                                                               //2

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add("ABC");                                                                                   //3
            cities.Add("BC");                                                                                   //4
            cities.Add("AB");                                                                                  //5

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add(cities.Capacity.ToString("Dhaka"));                                                                               //6

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add("ABC");                                                                                               //7

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add("ABC"); //--------------------------------------------------------------------------------------//8

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add("BC");                                                                                   //9

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add("AB");                                                                                  //10

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Add("AB");
            cities.TrimExcess(); //-------------------------------------------------------------------------  // It use to cut excess memory

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();


            System.Console.ReadKey();
        }
    }
}
