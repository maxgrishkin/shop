using System;

namespace Project
{
    class Program
    {
        static void Main()
        {
            TestShop();
        }

        static void TestShop()
        {
            Shop shop = new Shop();
            shop.SupplyProducts(new List<Product>()
            {
                new Product(){  Title = "Tomato", Price = 100},
                new Product(){  Title = "Tomato", Price = 100},
                new Product(){  Title = "Tomato", Price = 120 },
                new Product(){  Title = "Potato", Price = 40},
                new Product(){  Title = "Potato", Price = 40},
                new Product(){  Title = "Banana", Price = 500},
            });

            foreach (Product product in shop.GetProducts())
                Console.WriteLine($"{product.Id} {product.Title} ({product.Description}) : {product.Price}");

            shop.BuyProduct(shop.GetProducts()[0]);
            shop.BuyProduct(shop.GetProducts()[0]);
            shop.BuyProduct(shop.GetProducts()[0]);

            foreach (Product product in shop.GetProducts())
                Console.WriteLine($"{product.Id} {product.Title} ({product.Description}) : {product.Price}");

            Console.WriteLine(shop.GetCashboxBalance());

            //Console.WriteLine(product);
        }
    }
}