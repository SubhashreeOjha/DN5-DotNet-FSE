using EFCoreRetailStore.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRetailStore.LabPrograms
{
    public static class Lab6_UpdateDelete
    {
        public static async Task Run()
        {
            using var context = new AppDbContext();

            // Update Laptop price
            var product = await context.Products
                .FirstOrDefaultAsync(p => p.Name == "Laptop");

            if (product != null)
            {
                product.Price = 70000;
                await context.SaveChangesAsync();

                Console.WriteLine("Laptop price updated successfully!");
            }

            // Delete Rice Bag
            var toDelete = await context.Products
                .FirstOrDefaultAsync(p => p.Name == "Rice Bag");

            if (toDelete != null)
            {
                context.Products.Remove(toDelete);
                await context.SaveChangesAsync();

                Console.WriteLine("Rice Bag deleted successfully!");
            }
        }
    }
}