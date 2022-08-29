using System;
using System.Collections.Generic;

namespace Collection_List_Exercise_3
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student() { Id = "10-12", Name = "Aziz"});
            students.Add(new Student() { Id = "10-14", Name = "Rumi"});

            Student student = new Student() { Id = "11-11", Name = "Sarjat" };

            students.Add(student);

            foreach(Student student2 in students)
            {
                Console.WriteLine("Name: " + student2.Name);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
