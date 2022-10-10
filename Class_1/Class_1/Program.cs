using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + firstName + " " + lastName);
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.firstName = "Sarjat";
            person.lastName = "Aziz";

            person.Introduce();
        }
    }
}
