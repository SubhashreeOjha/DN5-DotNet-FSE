using EFCoreRetailStore.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRetailStore.LabPrograms
{
    public static class Lab7_Linq
    {
        public static async Task Run()
        {
            using var context = new AppDbContext();

            // Filter products
            var filtered = await context.Products
                .Where(p => p.Price > 1000)
                .OrderByDescending(p => p.Price)
                .ToListAsync();

            Console.WriteLine("Filtered Products:");

            foreach (var p in filtered)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
            }

            // Project into DTO (anonymous object)
            var productDTOs = await context.Products
                .Select(p => new
                {
                    p.Name,
                    p.Price
                })
                .ToListAsync();

            Console.WriteLine("\nProduct DTOs:");

            foreach (var p in productDTOs)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
            }
        }
    }
}