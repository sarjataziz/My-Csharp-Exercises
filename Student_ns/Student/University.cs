using Student_Info_1;
using Student_Details;
using Using_Association;

namespace University_Details
{
    class University
    {
        private string _name;
        private Student[] student;

        public University(string name, int size)
        {
            _name = name;
            student = new Student[size];
        }

        public void AddStudent(Student student)
        {
            for (int i = 0; i < this.student.Length; i++)
            {
                if (this.student[i] == null)
                {
                    this.student[i] = student;
                    System.Console.WriteLine("Student added.");
                    break;
                }
            }
        }

        public void StudentInfoDetails()
        {
            for (int i = 0; i < this.student.Length; i++)
            {
                if (this.student[i] == null)
                {
                    continue;
                }
                else
                {
                    this.student[i].ShowInfo();
                }
            }
        }
    }
}