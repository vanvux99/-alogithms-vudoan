using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    class Example16
    {
        /**
         * Hãy viết function minByPrice(listProduct) 
         * trả về  product có giá lớn nhất
         */

        public static void TestExample(Product[] listProduct)
        {
            Console.WriteLine("Product(name: " + MinByPrice(listProduct).Name + ", price: " +
                                "" + MinByPrice(listProduct).Price + ", quality: " +
                                "" + MinByPrice(listProduct).Quality + ", categoryId: " +
                                "" + MinByPrice(listProduct).CategoryId + ")");
        }

        public static Product MinByPrice(Product[] listProduct)
        {
            Product product = new Product();

            foreach (var listPro in listProduct)
            {
                if (listPro.Price == MinPrice(listProduct))
                {
                    product = new Product(listPro.Name, listPro.Price, listPro.Quality, listPro.CategoryId);
                }
            }

            return product;
        }

        /**
         * Get value min price  
         */
        public static int MinPrice(Product[] listProduct)
        {
            int maxPrice = 0;
            maxPrice = listProduct[0].Price;

            for (int indexlistProduct = 1; indexlistProduct < listProduct.Length; indexlistProduct++)
            {
                int a = listProduct[indexlistProduct].Price;
                if (listProduct[indexlistProduct].Price > maxPrice)
                {
                    maxPrice = listProduct[indexlistProduct].Price;
                }
            }

            return maxPrice;
        }
    }
}
