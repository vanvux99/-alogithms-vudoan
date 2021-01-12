using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    public class FunctionClass
    {
        // Câu 4
        public static Product FindProduct(List<Product> listProduct, string nameProduct)
        {
            Product result = new Product();
            foreach (var item in listProduct)
            {
                if (item.Name == nameProduct)
                {
                    //Console.WriteLine("Product(name: " + item.Name + ", price: " + item.Price + ", quality: " + item.Quality + ", categoryId: " + item.CategoryId + ")");
                    result = item;
                }
            }

            return result;
        }

        // Câu 5
        public static List<Product> FindProductByCategory(List<Product> listProduct, int categoryId)
        {
            List<Product> result = new List<Product>();
            foreach (var item in listProduct)
            {
                if (item.CategoryId == categoryId)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        // Câu 6
        public static List<Product> FindProductByPrice(List<Product> listProduct, int price)
        {
            List<Product> result = new List<Product>();
            foreach (var item in listProduct)
            {
                if (item.Price <= price)
                {
                    result.Add(item);
                    //Console.WriteLine("Product(name: " + item.Name + ", price: " + item.Price + ", quality: " + item.Quality + ", categoryId: " + item.CategoryId + ")");
                }
            }

            return result;
        }

        // Câu 11
        public static Product[] SortByPrice(Product[] listProduct)
        {
            Product t = null;
            for (int p = 0; p < listProduct.Length - 1; p++)
            {
                for (int i = 0; i < listProduct.Length - 1; i++)
                {
                    if (listProduct[i].Price > listProduct[i + 1].Price)
                    {
                        Swap(listProduct, i, (i + 1));
                    }
                }
            }

            return listProduct;
        }

        // Câu 12
        public static Product[] SortByName(Product[] listProduct)
        {
            for (int i = 0; i < listProduct.Length; i++)
            {
                Product temp = listProduct[i];
                int temp2 = i - 1;

                while (temp2 >= 0 && temp.Name.Length > listProduct[temp2].Name.Length) // độ dài của tên ... 
                {
                    listProduct[temp2 + 1] = listProduct[temp2];
                    temp2--;
                }
                listProduct[temp2 + 1] = temp;
            }

            return listProduct;
        }
        // Other Class
        #region 
        static void Swap(Product[] array, int i, int j)
        {
            Product temp = null;

            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        #endregion

















        // TEST
        public static void Test(List<Product> listProduct, string nameProduct, int categoryId, int price, Product[] listProductByArray, int example)
        {
            if (example == 4)
            {
                Console.WriteLine("Product(name: " + FunctionClass.FindProduct(listProduct, nameProduct).Name + ", price: " +
                "" + FunctionClass.FindProduct(listProduct, nameProduct).Price + ", quality: " +
                "" + FunctionClass.FindProduct(listProduct, nameProduct).Quality + ", categoryId: " +
                "" + FunctionClass.FindProduct(listProduct, nameProduct).CategoryId + ")");
            }
            else if (example == 5)
            {
                foreach (var item in FunctionClass.FindProductByCategory(listProduct, categoryId))
                {
                    Console.WriteLine("Product(name: " + item.Name + ", price: " +
                                    "" + item.Price + ", quality: " +
                                    "" + item.Quality + ", categoryId: " +
                                    "" + item.CategoryId + ")");
                }

            }
            else if (example == 6)
            {
                foreach (var item in FunctionClass.FindProductByPrice(listProduct, price))
                {
                    Console.WriteLine("Product(name: " + item.Name + ", price: " +
                                    "" + item.Price + ", quality: " +
                                    "" + item.Quality + ", categoryId: " +
                                    "" + item.CategoryId + ")");
                }
            }
            else if (example == 11)
            {
                foreach (var item in SortByPrice(listProductByArray))
                {
                    Console.WriteLine("Product(name: " + item.Name + ", price: " +
                                    "" + item.Price + ", quality: " +
                                    "" + item.Quality + ", categoryId: " +
                                    "" + item.CategoryId + ")");
                }
            }
            else if (example == 12)
            {
                foreach (var item in SortByName(listProductByArray))
                {
                    Console.WriteLine("Product(name: " + item.Name + ", price: " +
                                    "" + item.Price + ", quality: " +
                                    "" + item.Quality + ", categoryId: " +
                                    "" + item.CategoryId + ")");
                }
            }
        }

    }
}
