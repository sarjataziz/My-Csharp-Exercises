namespace Array_Exercise
{
    class Program
    {
        public static void Main()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("-------------------------One-dimentional Array---------------------------------------");
            System.Console.WriteLine();

            //One-dimentional Array

            int[] number = new int[5];

            number[0] = 10;
            number[1] = 20;
            number[2] = 30;
            number[3] = 50;
            number[4] = 80;

            for (int i = 0; i < number.Length; i++)
            {
                System.Console.WriteLine($"Number is {number[i]}");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("-----------------------------------------------------------");
            System.Console.WriteLine();

            //Foreach loop

            foreach (int item in number)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("-------------------------Two-dimentional Array---------------------------------------");
            System.Console.WriteLine();

            //Two-dimentional Array

            int[,] number1 = new int[2, 3];

            number1[0, 0] = 10;
            number1[0, 1] = 20;
            number1[0, 2] = 30;

            number1[1, 0] = 20;
            number1[1, 1] = 40;
            number1[1, 2] = 50;

            for(int i = 0; i < number1.GetLength(0); i++)               //row
            {
                for (int j = 0; j < number1.GetLength(1); j++)          //colume
                {
                    System.Console.Write(number1[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();
            System.Console.WriteLine("-----------------------------------------------------------");
            System.Console.WriteLine();

            int[,] number2 = new int[3, 3] { { 10, 20, 30 }, { 30, 50 , 70}, { 15, 35, 75 } };

            for (int i = 0; i < number2.GetLength(0); i++)               //row
            {
                for (int j = 0; j < number2.GetLength(1); j++)          //colume
                {
                    System.Console.Write(number2[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();
            System.Console.WriteLine("-------------------------Jagged Array---------------------------------------");
            System.Console.WriteLine();

            int[][] number3 = new int[3][];

            number3[0] = new int[3] { 20, 40, 60 };
            number3[1] = new int[2] { 30, 50 };
            number3[2] = new int[4] { 15, 25, 35, 45 };

            for (int i = 0; i < number3.Length; i++)                            //array index
            {
                for (int j = 0; j < number3[i].Length; j++)
                {
                    System.Console.Write(number3[i][j] + " ");                  // array index value or another array
                    
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();
            System.Console.WriteLine("-----------------------------------------------------------");
            System.Console.WriteLine();


            System.Console.WriteLine();

            System.Console.ReadKey();
        }
    }
}