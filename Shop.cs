using System;

namespace Project
{
    public class Shop
    {
        private Storage storage;
        private Cashbox cashbox;



        public Shop()
        {
            storage = new Storage();
            cashbox = new Cashbox();
        }
        public List<Product> GetProducts()
        {
            return storage.GetProducts();
        }

        public void SupplyProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                storage.Supply(product);
            }
        }

        public void BuyProduct(Product product)
        {
            if (storage.Take(product))
            {
                Transaction t = new Transaction() { Description = $"Покупка {product.Title}", Date = DateTime.Now, Summ = product.Price };
                cashbox.AddTransaction(t);
            }
        }

        public float GetCashboxBalance()
        {
            return cashbox.Balance;
        }
    }
}