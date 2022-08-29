class Program
{
    static void Main()
    {
        //Read input value from keyword
        System.Console.Write("Enter the value: ");
        string s = System.Console.ReadLine();

        //TryParse
        bool b = int.TryParse(s, out int n);

        if (b == true)
        {
            System.Console.WriteLine("Consversion is successful.");
            System.Console.WriteLine(n);
        }
        else
        {
            System.Console.WriteLine("Conversion isn't successful.");
        }

        System.Console.ReadKey();
    }
}