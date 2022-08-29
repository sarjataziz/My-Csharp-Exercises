using System;

namespace Interface_Exercise
{
    interface ISleepable
    {
        void Sleep();
    }

    interface IRunable
    {
        void Run();
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
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            //new ISleepable() // ERROR

            Human human = new Human();  
            human.Sleep();
            human.Run();

            ISleepable sleepable = new Human();
            sleepable.Sleep();

            IRunable runable = new Human();
            runable.Run();

            ISleepable sleepable1 = new Human();
            
            // Polymorfic behaviour -> 

            Human human1 = (Human) sleepable1; //Downcasting
            human1.Sleep();
            human1.Run();

            IRunable runable1 =(Human) sleepable;
            runable1.Run();
           

            ((ISleepable)runable1).Sleep();           //////////////////////////////////

            ((IRunable)sleepable).Run();              /////////////////////////////////


            Console.ReadKey();
        }
    }
}
