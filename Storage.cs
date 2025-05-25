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
        private void normalizationId()
        {
            int idNormal = 1;
            foreach(Product product in product_list)
            {
                product.Id = idNormal;
                idNormal++;
            }
            idNormal = 1;
        }
        public bool Take(Product product)
        {
            if (!product_list.Contains(product))
                return false;
            product_list.Remove(product);
            normalizationId();
            return true;
        }

        public List<Product> GetProducts()
        {
            return product_list;
        }
    }
}
