using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    public class AddProduct
    {
        Product product1 = new Product("CPU", 750, 10, 1);
        Product product2 = new Product("RAM", 50, 2, 2);
        Product product3 = new Product("HDD", 70, 1, 2);
        Product product4 = new Product("MAIN", 400, 3, 1);
        Product product5 = new Product("KEYBROAND", 30, 8, 4);
        Product product6 = new Product("MOUSE", 25, 50, 4);
        Product product7 = new Product("VGA", 60, 35, 3);
        Product product8 = new Product("MONITOR", 120, 28, 2);
        Product product9 = new Product("CASE", 120, 28, 5);

        List<Product> listProduct = new List<Product>();
        public List<Product> AddProducts()
        {
            listProduct.Add(product1);
            listProduct.Add(product2);
            listProduct.Add(product3);
            listProduct.Add(product4);
            listProduct.Add(product5);
            listProduct.Add(product6);
            listProduct.Add(product7);
            listProduct.Add(product8);
            listProduct.Add(product9);
            return listProduct;
        }

        public Product[] AddProductsByArray()
        {
            Product[] array = new Product[9] {
                    product1, product2, product3, product4, product5, product6, product7, product8, product9
                };
            return array;
        }
    }
}
