using Student_Info_1;
using Using_Association;
using University_Details;

namespace Student_Details
{
    class Program
    {
        public static void Main()
        {
            Address address = new Address("20/A", "503-505", "Dhaka");

            Student student = new Student() { Name = "L", Id = "12213-1324", University = "ALLA", Department = "BSc CSE", Cgpa = 3.9F, Address = address };

            //student.ShowInfo();

            University university = new University("bbbbbb", 5);

            university.AddStudent(student);
            university.StudentInfoDetails();

            System.Console.ReadKey();
        }

    }
}