class Program
{
    static void Main()
    {
        //Create an object of Car class
        Car car = new Car();

        //Call get accessor of indexer
        System.Console.WriteLine(car[0]);

        System.Console.WriteLine(car["first"]);

        //Call set accessor of index
        car[0] = "Nissan";
        System.Console.WriteLine(car[0]);

        System.Console.ReadKey();
    }
}