public class Product
{
    //Fields
    private int productID;
    private string productName;
    private double tax;
    private double cost;
    private int quantityInStock;
    public static int totalNumberOfProducts;
    public const string CategoryName = "Electronics";
    private readonly string dateOfPurchase;

    //Constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToLongDateString(); // Readonly also can initilize in Constructor
    }

    //Set Method and Get Method

    public void SetProductID(int productID)
    {
        this.productID = productID;
    }
    public int GetProductID()
    {
        return productID;
    }

    public void SetProductName(string productName)
    {
       this.productName = productName;
    }

    public string GetProductName()
    {
        return (string)productName;
    }

    public void SetTax(double tax)
    {
       this.tax = tax;
    }

    public double GetTax()
    {
        return tax;
    }

    public void SetCost(double cost)
    {
        this.cost = cost;
    }

    public double GetCost()
    {
        return (double)cost;
    }
    public void SetQuantityInStack(int qualityInStock)
    {
        this.quantityInStock = qualityInStock;
    }

    public int GetQuantityInStack()
    {
        return quantityInStock;
    }

    public string GetDateOfPurchase()
    {
        return dateOfPurchase;                  
    }

    public static void SetTotalNumberOfProducts(int value)
    {
        totalNumberOfProducts = value;
    }

    public static int GetTotalNumberOfProducts()
    {
        return totalNumberOfProducts;
    }

    public static int GetTotalOuantity(Product product1, Product product2, Product product3)
    {
        int total = product1.GetQuantityInStack() + product2.GetQuantityInStack() + product3.GetQuantityInStack();
        return total;    
    }

    //Method
    public void CalculateTax()
    {
        double t;

        if(this.cost <= 2000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12 / 100;
        }
        tax = t;
    }

}

