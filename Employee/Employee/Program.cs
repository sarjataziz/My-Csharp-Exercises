using System;

public class OASBank
{
    public static void Main()
    {
        Employee[] employee = new Employee[10];
        byte count = 1;

        Console.WriteLine(Employee.organizationName);
        Console.WriteLine(Employee.typeOfEmployee);  

        for (int i = 0; i < employee.Length; i++)
        {
            employee[i] = new Employee();

            Console.Write("Enter Employee ID: ");
            employee[i].employeeID = Console.ReadLine();

            Console.Write("Enter Employee Name: ");
            employee[i].employeeName = Console.ReadLine();

            Console.Write("Enter Employee's Salary Per Hour: ");
            employee[i].employeeSalaryPerHour = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee's Number Of Working Hour: ");
            employee[i].numberOfWorkingHour = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee's net Salary: ");
            employee[i].netSalary = int.Parse(Console.ReadLine());

            Console.WriteLine();
            count++;
            Console.WriteLine("Number of Employees : " +count);
        }

        Console.WriteLine();
        Console.WriteLine("Thank You.......");
        Console.ReadKey();        
    }
}
