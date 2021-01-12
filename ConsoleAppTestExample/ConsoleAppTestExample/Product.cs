using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    public class Product
    {
        List<Product> listProduct = new List<Product>();

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quality { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public Product()
        {

        }

        public Product(string name, int price, int quality, int cateroryID)
        {
            Name = name;
            Price = price;
            Quality = quality;
            CategoryId = cateroryID;
        }

        public Product(string name, int price, int quality, int cateroryID, string categoryName)
        {
            Name = name;
            Price = price;
            Quality = quality;
            CategoryId = cateroryID;
            CategoryName = categoryName;
        }

        /**
         * Set data in Product
         */
        public List<Product> SetDataProduct()
        {
            List<Product> list = new List<Product>();

            Product product1 = new Product("CPU", 750, 10, 1);
            Product product2 = new Product("RAM", 50, 2, 2);
            Product product3 = new Product("HDD", 70, 1, 2);
            Product product4 = new Product("MAIN", 400, 3, 1);
            Product product5 = new Product("KEYBROAND", 30, 8, 4);
            Product product6 = new Product("MOUSE", 25, 50, 4);
            Product product7 = new Product("VGA", 60, 35, 3);
            Product product8 = new Product("MONITOR", 120, 28, 2);
            Product product9 = new Product("CASE", 120, 28, 5);

            list.Add(product1);
            list.Add(product2);
            list.Add(product3);
            list.Add(product4);
            list.Add(product5);
            list.Add(product6);
            list.Add(product7);
            list.Add(product8);
            list.Add(product9);

            return list;
        }

        public Product[] AddProductsByArray() // set data in array
        {
            Product[] array = new Product[9];

            int countDataProduct = SetDataProduct().Count;
            int countListProduct = 0;

            for (int indexArray = 0; indexArray < array.Length; indexArray++)
            {
                for (int indexListProduct = 0; indexListProduct < countDataProduct; indexListProduct++)
                {
                    if (countListProduct == indexArray)
                    {
                        array[indexArray] = SetDataProduct()[indexArray];
                        string test1 = array[indexArray].Name;
                        countListProduct++;
                    }
                }

            }

            return array;
        }
    }
}
