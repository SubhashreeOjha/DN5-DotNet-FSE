using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    // Linear Search
    static Product LinearSearch(Product[] products, string name)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }
        return null;
    }

    // Binary Search
    static Product BinarySearch(Product[] products, string name)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int comparison = string.Compare(
                products[mid].ProductName,
                name,
                StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return products[mid];

            if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Keyboard","Electronics"),
            new Product(103,"Mouse","Electronics"),
            new Product(104,"Shoes","Fashion")
        };

        Product result1 = LinearSearch(products, "Keyboard");

        Console.WriteLine("Linear Search Result:");
        if (result1 != null)
            Console.WriteLine(result1.ProductName);

        Array.Sort(products,
            (a, b) => a.ProductName.CompareTo(b.ProductName));

        Product result2 = BinarySearch(products, "Keyboard");

        Console.WriteLine("\nBinary Search Result:");
        if (result2 != null)
            Console.WriteLine(result2.ProductName);
    }
}
