using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        Product[] products = new Product[0];
        public Product[] Products { get { return products; } }
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public Product[] FilterProductsByType(ProductType type)
        {
            Product[] filteredProducts = new Product[0];
            for (int i = 0; i < products.Length; i++)
            {
                if (type == products[i].Type)
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length + 1);
                    filteredProducts[filteredProducts.Length - 1] = products[i];
                }
            }
            return filteredProducts;
        }
        public Product[] FilterProductByName(string name)
        {
            Product[] filteredProducts = new Product[0];
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length + 1);
                    filteredProducts[filteredProducts.Length - 1] = products[i];
                }
            }
            return filteredProducts;
        }
    }
}
