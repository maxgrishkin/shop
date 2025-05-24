using System;

namespace Project
{
    public class Storage
    {
        int productIdMax = 1;
        private List<Product> product_list = new List<Product>();

        public void Supply(Product product)
        {
            product.Id = productIdMax++;
            product_list.Add(product);
        }
        public bool Take(Product product)
        {
            if (!product_list.Contains(product))
                return false;
            product_list.Remove(product);
            return true;
        }

        public List<Product> GetProducts()
        {
            return product_list;
        }
    }
}
