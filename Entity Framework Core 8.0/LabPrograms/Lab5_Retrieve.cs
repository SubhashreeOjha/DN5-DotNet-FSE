using EFCoreRetailStore.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRetailStore.LabPrograms
{
    public static class Lab5_Retrieve
    {
        public static async Task Run()
        {
            using var context = new AppDbContext();

            // Retrieve all products
            Console.WriteLine("All Products:");

            var products = await context.Products.ToListAsync();

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - ₹{p.Price}");
            }

            // Find product by ID
            Console.WriteLine("\nFind Product with ID = 1");

            var product = await context.Products.FindAsync(1);

            if (product != null)
            {
                Console.WriteLine($"Found: {product.Name}");
            }

            // First product with price greater than 50000
            Console.WriteLine("\nExpensive Product:");

            var expensive = await context.Products
                .FirstOrDefaultAsync(p => p.Price > 50000);

            if (expensive != null)
            {
                Console.WriteLine($"{expensive.Name} - ₹{expensive.Price}");
            }
        }
    }
}