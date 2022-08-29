using ClassLibrary1;
class Program
{
    public static void Main()
    {
        /*
         
        System.Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||");
        System.Console.WriteLine();
        System.Console.Write("Enter your name: ");
        string name = System.Console.ReadLine();
        System.Console.Write("Enter your ID: ");
        string id = System.Console.ReadLine();
        System.Console.Write("Enter your semester: ");
        int semester = System.Int32.Parse(System.Console.ReadLine());
        System.Console.Write("Enter your cgps: ");
        float cgpa = System.Convert.ToSingle(System.Console.ReadLine());
        System.Console.Write("Enter your Department: ");
        string department = System.Console.ReadLine();

        System.Console.WriteLine();
        System.Console.WriteLine("==================================================");
        System.Console.WriteLine();

        System.Console.WriteLine("Name: " + name + "\nID: " + id + "\nSemester: " + semester + "th" +
            "\nCGPA: " + cgpa + "\nDepartment: " + department);

        System.Console.WriteLine();
        System.Console.WriteLine("==================================================");
        System.Console.WriteLine();

        System.Console.WriteLine("Name: {0} \nID: {1} \nSemester: {2} \nCGPA: {3} \nDepartment: {4}", name, id, semester, cgpa, department);

        System.Console.WriteLine();
        System.Console.WriteLine("==================================================");
        System.Console.WriteLine();

        System.Console.WriteLine($"Name: {name} \nID: {id} \nSemester: {semester} \nCGPA: {cgpa} \nDepartment: {department}");

        System.Console.WriteLine();
        System.Console.ReadKey(); 

        */

        Student student = new Student("asfdsaf","dsfsd","AFSD",7,3.9F);
        student.Desplay();
    }
}