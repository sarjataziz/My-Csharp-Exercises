using System;

namespace OOP_2
{
    class Animal
    {
        private string name;
        public int age;
        public string voice;

        public string Name { get => name; set => name = value; }

        public void printDeails()
        {
            Console.WriteLine("Name: " + Name + " " + "Age: " + age + "Voice: " + voice);
        }

        public Animal(string name, int age, string voice)
        {
            this.Name = name;
            this.age = age;
            this.voice = voice;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("HK", 134, "jk");
            dog.printDeails();

            Animal cat = new Animal("djs", 13, "sdf");
            cat.printDeails();
            Console.ReadKey();
        }
    }
}
