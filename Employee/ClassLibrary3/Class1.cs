public class Employee
{
    public string employeeID;
    public string employeeName;
    public int employeeSalaryPerHour;
    public int numberOfWorkingHour;
    public int netSalary;
    public static string organizationName = "OAS Inc.";
    public const string typeOfEmployee = "Contract Base";
    public readonly string departmentName;

    public Employee()
    {
        departmentName = "Finance Depertment";
    }

}