using System;

namespace Interface_Exercise
{
    interface ISleepable
    {
        void Sleep();

        void Work();
    }

    interface IRunable
    {
        void Run();

        void Work();
    }

    class Human : ISleepable, IRunable
    {
        public void Sleep()
        {
            Console.WriteLine("THIS IS Human SLEEP");
        }

        public void Run()
        {
            Console.WriteLine("This is Human run");
        }

        //Override any one of them

        public void Work()
        {
            Console.WriteLine("This is working...");
        }

        //Explicit interface implementation

        void ISleepable.Work()
        {
            Console.WriteLine("This Human working...-> ISleepable");
        }

        void IRunable.Work()
        {
            Console.WriteLine("This Human working...-> IRunable");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //new ISleepable() // ERROR

            Human human = new Human();
            human.Sleep();
            human.Run();  
            ((IRunable)human).Work();
            ((ISleepable)human).Work();
            Console.WriteLine();
            Console.WriteLine();

            ISleepable sleepable = new Human();

            sleepable.Sleep();
            sleepable.Work();

            Console.WriteLine();
            Console.WriteLine();

            IRunable runable = new Human();

            runable.Run();
            runable.Work();



            Console.ReadKey();
        }
    }
}
