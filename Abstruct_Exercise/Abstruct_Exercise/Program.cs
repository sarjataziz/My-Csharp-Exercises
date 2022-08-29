namespace Abstruct_Exercise
{
    public abstract class Parent
    {
        abstract public void MyMethods();
    }

    public class Child : Parent
    {
        override public void MyMethods()
        {
            System.Console.WriteLine("This is Child Method call.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Child();
            parent.MyMethods();

            System.Console.ReadKey();
        }
    }
}
