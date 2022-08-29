/*
using System;
using System.Collections.Generic; 
*/

namespace Collection_List_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Collections.Generic.List<string> cities = new System.Collections.Generic.List<string>();

            cities.Add(cities.Capacity.ToString("Dhaka"));

            cities.Add("New York");
            cities.Add("ABCD");
            cities.Add("New York");
            cities.Add("ABCD");
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.WriteLine("Count: " + cities.Count);
            System.Console.WriteLine("ToString: " + cities.Count.ToString());
            System.Console.WriteLine("Capacity: " + cities.Capacity);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            
            foreach(var item in cities) //----------------------------------------------------------------------- useing foreach loop(it is best for Collection Type)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();

            cities.Reverse(); //-------------------------------------------------------------------------------- Reverse Method

            foreach (var item in cities)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();


            cities.Sort(); //-------------------------------------------------------------------------------- Sort Method

            foreach (var item in cities)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            System.Console.ReadKey();

            cities.Clear(); //-------------------------------------------------------------------------------- Clear Method

            foreach (var item in cities)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("===========================================================");
            System.Console.WriteLine();
            
        }
    }
}

