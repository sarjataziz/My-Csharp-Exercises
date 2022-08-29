
namespace ClassLibrary1
{
    public class Student
    {
        //Fields Declaration
        string name, id, department;
        int semester;
        float cgpa;

        //Constructor
        public Student(string name, string id, string department,int semester, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.semester = semester;
            this.cgpa = cgpa;
            this.department = department;
            
        }
        public void Desplay()
        {
            System.Console.WriteLine($"Name: {this.name} \nID: {id} \nSemester: {this.semester} \nCGPA: {this.cgpa} \nDepartment: {this.department}");
            System.Console.ReadKey();
        }
    }
}
