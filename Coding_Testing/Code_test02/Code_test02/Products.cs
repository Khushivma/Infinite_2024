using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Products> products = new List<Products>
            {
            new Products { ProductId = 1, ProductName = "Laptop", Price = 1200 },
            new Products { ProductId = 2, ProductName = "Smartphone", Price = 900 },
            new Products { ProductId = 3, ProductName = "Headphones", Price = 600 },
            new Products { ProductId = 4, ProductName = "Speaker", Price = 500},

            };
            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

            Console.WriteLine("Sorted Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: ${product.Price}");
                Console.Read();
            }
        }
    }
}

