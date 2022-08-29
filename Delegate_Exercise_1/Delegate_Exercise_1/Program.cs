using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Exercise_1
{
    public class Sample
    {
        public void MyMethod(int x)
        {
            Console.WriteLine("MyMethod value:" +x);
        }
        public void AnotherMethod(int a)
        {
            Console.WriteLine("AnotherMethod value:" + a);
        }
        public void OtherMethod(int c)
        {
            Console.WriteLine("OtherMethod value:" + c);
        }
    }

    //Delegate Declaration

    public delegate void MyDelegate(int x);

    internal class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();



            //MyDelegate myDelegate = new MyDelegate(sample.MyMethod);  //Binding method to a Delegate

            /*
            myDelegate.Invoke(100);
            myDelegate(100);
            */
            /*
            myDelegate += sample.AnotherMethod;
            myDelegate += sample.OtherMethod;

            myDelegate(500);
            */

            MyDelegate myDelegate1 = sample.AnotherMethod;
            MyDelegate myDelegate2 = sample.OtherMethod;
            MyDelegate myDelegate3 = sample.MyMethod;

            MyDelegate myDelegate = myDelegate1 + myDelegate2 + myDelegate3;
            myDelegate(1000);


            Console.ReadKey();
        }
    }
}
