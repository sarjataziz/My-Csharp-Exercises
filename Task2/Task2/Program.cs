using System;

namespace Task2
{
    class Student
    {
        // declaring variable
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public string Name { get => name; set => name = value; }

        //Using Proparties
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }

        public void setDepartment(string department)
        {
            this.department = department;
        }
        public string getDepartment()
        {
            return this.department;
        }

        public void setCgpa(float cgpa)
        {
            this.cgpa = cgpa;
        }
        public float getCgpa()
        {
            return this.cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Info:\n");
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("ID: " + getId());
            Console.WriteLine("Department: " + getDepartment());
            Console.WriteLine("CGPA: " + getCgpa());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.setName("Sarjat Aziz Rumi");
            student.setId("19-4****-1");
            student.setDepartment("CSE");
            student.setCgpa(3.64F);

            student.ShowInfo();

            Console.ReadKey();
        }
    }
}
