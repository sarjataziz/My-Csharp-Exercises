using System;

class Program
{
	static void Main(string[] args)
	{
		int a = 10, b = 20, c =30;
		Console.WriteLine("{0},{0}", a, b);
		Console.WriteLine("{0}+{1}", a, b);
		Console.WriteLine("{0}+{1}+{0}+{2}", a, b, c);

		int x = 10, y = 10;
		Console.WriteLine(x == y);


		Console.ReadKey();
	}

}

