/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; */

namespace Generic_Exercise
{

    public class MyGenericClass<T>                                             //Generic Class
    {
        public T myField;                                                       //Generic Field

        public void MyMethod(T x)
        {
            System.Console.WriteLine("X : " + x);
        }

        public T MyMthod2(T y)
        {
            return y;
        }
    }

    public class MyGenericClass2<T, U>                                             //Generic Class
    {
        public T myField;                                                       //Generic Field

        public void MyMethod(U x)
        {
            System.Console.WriteLine("X : " + x);
        }

        public U MyMthod2(U y)
        {
            return y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> myGenericClass = new MyGenericClass<int>();     //Define a Generic class

            myGenericClass.myField = 1;
            myGenericClass.MyMethod(10);
            int a = myGenericClass.MyMthod2(20);

            System.Console.WriteLine(a);

            System.Console.WriteLine("Value / Output is: " + myGenericClass.myField);

            MyGenericClass<string> myGenericClass1 = new MyGenericClass<string>();         //Define a Generic class

            myGenericClass1.myField = "Nothing..";

            System.Console.WriteLine("Output is: " + myGenericClass1.myField);


            MyGenericClass2<int, float> myGenericClass2 = new MyGenericClass2<int, float>();      //Define a Generic class

            myGenericClass2.myField = 10;
            System.Console.WriteLine("Here: " + myGenericClass.myField);

            myGenericClass2.MyMethod(20.50f);

            System.Console.WriteLine(myGenericClass2.MyMthod2(20.25f));

            System.Console.ReadKey();
        }
    }
}
