using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_02
{
    class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }

        public Products(int productId, string productName, float productPrice)
        {
            ProductID = productId;
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }

    class Productss
    {
        static void Main()
        {
            List<Products> productList = new List<Products>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter the {i + 1} Product Name: ");
                string name = Console.ReadLine();
                Console.Write($"Enter the {i + 1} Product Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write($"Enter the {i + 1} Product Price: ");
                float price = Convert.ToSingle(Console.ReadLine());

                productList.Add(new Products(id, name, price));
            }

            productList = productList.OrderBy(p => p.ProductPrice).ToList();

            foreach (var pd in productList)
            {
                Console.WriteLine($"ID: {pd.ProductID}, Name: {pd.ProductName}, Price: {pd.ProductPrice}");
            }

            Console.Read();
        }
    }
}
