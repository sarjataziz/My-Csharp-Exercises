using System;

class Sample
{
    static void Main()
    {
        Product product1, product2, product3;

        product1 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);

        product2 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);

        product3 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);

        product1.SetProductID(1030);
        product1.SetProductName("Moble");
        product1.SetCost(2000);
        product1.SetQuantityInStack(1200);

        product2.SetProductID(1010);
        product2.SetProductName("Laptop");
        product2.SetCost(5000);
        product2.SetQuantityInStack(1100);

        product3.SetProductID(1020);
        product3.SetProductName("Speaker");
        product2.SetCost(300);
        product3.SetQuantityInStack(1300);

        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();

        Console.WriteLine("\nProduct 1: ");
        Console.WriteLine("Product ID: " + product1.GetProductID());
        Console.WriteLine("Product Name: " + product1.GetProductName());
        Console.WriteLine("Product Cost: " + product1.GetCost());
        Console.WriteLine("Product Quantity in Stock: " + product1.GetQuantityInStack());
        Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
        Console.WriteLine("Tax: " + product1.GetTax());

        Console.WriteLine("\n\nProduct 2: ");
        Console.WriteLine("Product ID: " + product2.GetProductID());
        Console.WriteLine("Product Name: " + product2.GetProductName());
        Console.WriteLine("Product Cost: " + product2.GetCost());
        Console.WriteLine("Product Quantity in Stock: " + product2.GetQuantityInStack());
        Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
        Console.WriteLine("Tax : " + product2.GetTax());

        Console.WriteLine("\n\nProduct 3: ");
        Console.WriteLine("Product ID: " + product3.GetProductID());
        Console.WriteLine("Product Name: " + product3.GetProductName());
        Console.WriteLine("Product Cost: " + product3.GetCost());
        Console.WriteLine("Product Quantity in Stock: " + product3.GetQuantityInStack());
        Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
        Console.WriteLine("Tax : " + product3.GetTax());

        int totalOuantity = Product.GetTotalOuantity(product1, product2, product3);

        Console.WriteLine("\nTotal Quantity : " + totalOuantity);
        Console.WriteLine("Total Number of Products: " + Product.GetTotalNumberOfProducts());
        Console.WriteLine("Category of the Products: " + Product.CategoryName);

        Console.ReadKey();
    }
}



