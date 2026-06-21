using System;
using System.Collections.Generic;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, int quantity, double price)
    {
        ProductId = id;
        ProductName = name;
        Quantity = quantity;
        Price = price;
    }
}

class Inventory
{
    private Dictionary<int, Product> products = new Dictionary<int, Product>();

    public void AddProduct(Product product)
    {
        products[product.ProductId] = product;
    }

    public void UpdateProduct(int id, int quantity, double price)
    {
        if (products.ContainsKey(id))
        {
            products[id].Quantity = quantity;
            products[id].Price = price;
        }
    }

    public void DeleteProduct(int id)
    {
        products.Remove(id);
    }

    public void DisplayProducts()
    {
        foreach (var p in products.Values)
        {
            Console.WriteLine($"{p.ProductId} {p.ProductName} Qty:{p.Quantity} Price:{p.Price}");
        }
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(new Product(1, "Laptop", 10, 50000));
        inventory.AddProduct(new Product(2, "Mouse", 50, 500));

        inventory.UpdateProduct(2, 60, 550);

        inventory.DisplayProducts();

        inventory.DeleteProduct(1);

        Console.WriteLine("\nAfter Deletion:");
        inventory.DisplayProducts();
    }
}
