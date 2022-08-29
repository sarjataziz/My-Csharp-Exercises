class Student
{
    //Method
    public void displayMarks(int marks1, int marks2, int marks3)
    {
        double avgMarks = getAvgMarks(marks1, marks2, marks3); //Calling local function

        System.Console.WriteLine("Mark 1: " + marks1);
        System.Console.WriteLine("Mark 2: " + marks2);
        System.Console.WriteLine("Mark 3: " + marks3);
        System.Console.WriteLine("Average: " + avgMarks);

        //local functionf
        static double getAvgMarks(int m1, int m2, int m3)
        {

            //create loacal variable of local function
            double avg;
            avg = (double)((m1 + m2 + m3) / 3);
            return avg;
        }

    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.displayMarks(95, 64, 100);

        System.Console.ReadKey();
    }
}

