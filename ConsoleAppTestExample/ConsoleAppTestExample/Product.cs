using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    public class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int Quality { get; set; }

        public int CategoryId { get; set; }

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
    }
}
