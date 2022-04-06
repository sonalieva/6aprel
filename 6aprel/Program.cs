using System;
using ClassLibrary;

namespace _6aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Cola";
            product.Price = 1.8;
            product.Type = ProductType.Drink;
            Product product1 = new Product();
            product1.Name = "Pork";
            product1.Price = 8;
            product1.Type = ProductType.Meat;
            Store smth = new Store();
            smth.AddProduct(product);
            smth.AddProduct(product1);
            foreach (var item in smth.Products)
            {
                Console.WriteLine(item.Name);
            }

            foreach (var item in smth.FilterProductByName("Meat"))
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in smth.FilterProductsByType(ProductType.Drink))
            {
                Console.WriteLine(item.Name);
            }
            
        }
    }
}
