using System.Diagnostics;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

            /*foreach (var product in products)
            {
                Console.WriteLine(product);
            }*/

            Console.WriteLine("items with indexes 1, 5, 0, 7:");
            Console.WriteLine(products[1]);
            Console.WriteLine(products[5]);
            Console.WriteLine(products[0]);
            Console.WriteLine(products[7]);

            products = products.OrderBy(pr => pr.Id).ToList();
            Console.WriteLine("items with indexes 1, 5 ordered by field {0}:", nameof(Product.Id));
            Console.WriteLine(products[1]);
            Console.WriteLine(products[5]);

            products = products.OrderBy(pr => pr.Name).ToList();
            Console.WriteLine("items with indexes 0, 7 ordered by field {0}:", nameof(Product.Name));
            Console.WriteLine(products[0]);
            Console.WriteLine(products[7]);
        }
    }
}
