using System;

namespace Inheritance_Example
{
    class Parents
    {
        public int myField;

        public Parents()
        {
            Console.WriteLine("Parameterless. -> P");
        }

        public Parents(int myField)
        {
            this.myField = myField;
            Console.WriteLine("Parameterize. -> P");
        }

        ~Parents()
        {
            Console.WriteLine("Destactor. -> P");
        }
    }

    class Child : Parents
    {
        public Child()
        {
            Console.WriteLine("Parameterless. -> C");
        }

        public Child(int myField) : base(myField)
        {
            this.myField = myField;
            Console.WriteLine("Parameterize. -> C");
        }

        ~Child()
        {
            Console.WriteLine("Destactor. -> C");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Child child = new Child(100);
            //child.myField = 1;

            Console.ReadKey();
        }
    }
}
