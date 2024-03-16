using Microsoft.EntityFrameworkCore;
using Task1;
namespace Task2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MyDataBase db = new MyDataBase();
            var products = new List<Product>()
            {
                new Product(Guid.NewGuid(), "Product 1", 10.99, "Description for Product 1", 5),
                new Product(Guid.NewGuid(), "Product 2", 20.49, "Description for Product 2", 10),
                new Product(Guid.NewGuid(), "Product 3", 15.79, "Description for Product 3", 3),
                new Product(Guid.NewGuid(), "Product 4", 8.99, "Description for Product 4", 8),
                new Product(Guid.NewGuid(), "Product 5", 12.39, "Description for Product 5", 6),
                new Product(Guid.NewGuid(), "Product 6", 25.99, "Description for Product 6", 2),
                new Product(Guid.NewGuid(), "Product 7", 18.29, "Description for Product 7", 7),
                new Product(Guid.NewGuid(), "Product 8", 14.59, "Description for Product 8", 4),
                new Product(Guid.NewGuid(), "Product 9", 9.99, "Description for Product 9", 9),
                new Product(Guid.NewGuid(), "Product 10", 22.49, "Description for Product 10", 12)
            };
            foreach (var product in products)
            {
                db.Products.Add(product);
            }
            await db.SaveChangesAsync();
            await Console.Out.WriteLineAsync("Data was saved");

            var productsFromDb = await db.Products.ToListAsync();
            await Console.Out.WriteLineAsync("Data was extracted from db");
            productsFromDb = productsFromDb.OrderBy(p => p.Name).ToList();

            await Console.Out.WriteLineAsync($"Items with indexes -> 1, 5, 0, 7 ordered by {nameof(Product.Name)}:");
            await Console.Out.WriteLineAsync(productsFromDb[1].ToString());
            await Console.Out.WriteLineAsync(productsFromDb[5].ToString());
            await Console.Out.WriteLineAsync(productsFromDb[0].ToString());
            await Console.Out.WriteLineAsync(productsFromDb[7].ToString());
        }
    }
}
