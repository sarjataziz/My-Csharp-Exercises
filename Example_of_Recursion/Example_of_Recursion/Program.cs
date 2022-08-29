class Factorial_Example
{
    public double factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * factorial(number - 1);
        }
    }
}
class Program
{
    static void Main()
    {
        System.Console.Write("Enter number: ");
        int n = int.Parse(System.Console.ReadLine());

        Factorial_Example factorial_example = new Factorial_Example();

        double fact = factorial_example.factorial(n);

        System.Console.WriteLine(n +" Factorial is "+fact);

        System.Console.ReadKey();

        /* if n = 5
         * Factorial 5 = 5 * factorial(4)   -> 5*24
           Factorial 4 = 4 * factorial(3)   -> 4*6
           Factorial 3 = 3 * factorial(2)   -> 3*2
           Factorial 2 = 2 * factorial(1)   -> 2*1
         * Factorial 1 = 1 * factorial(0)   -> 1*1
         * Factorial 0 = 1 (if number == 0, it will return 1. And this 1 goes to F(1).)
         */
    }
}