using System;

class Sample 
    {
        static void Main()
        {
            Product product1, product2, product3;

            product1 = new Product();
            product2 = new Product();
            product3 = new Product();

            product1.productID = 1001;
            product1.productName = "Moble";
            product1.cost = 2000;
            product1.quantityInStock = 1200;

            product2.productID = 1010;
            product2.productName = "Laptop";
            product2.cost = 5000;
            product2.quantityInStock = 1100;

            product3.productID = 1020;
            product3.productName = "Speaker";
            product3.cost = 300;
            product3.quantityInStock = 1900;

            Console.WriteLine("Product 1: ");
            Console.WriteLine("Product ID: " + product1.productID);
            Console.WriteLine("Product Name: " + product1.productName);
            Console.WriteLine("Product Cost: " + product1.cost);
            Console.WriteLine("Product Quantity in Stock: " + product1.quantityInStock);

            Console.WriteLine("\nProduct 2: ");
            Console.WriteLine("Product ID: " + product2.productID);
            Console.WriteLine("Product Name: " + product2.productName);
            Console.WriteLine("Product Cost: " + product2.cost);
            Console.WriteLine("Product Quantity in Stock: " + product2.quantityInStock);

            Console.WriteLine("\nProduct 3: ");
            Console.WriteLine("Product ID: " + product3.productID);
            Console.WriteLine("Product Name: " + product3.productName);
            Console.WriteLine("Product Cost: " + product3.cost);
            Console.WriteLine("Product Quantity in Stock: " + product3.quantityInStock);
        }
    }


