using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            AddProduct add = new AddProduct();
            string name = "";
            int id = 0;
            int price = 0;

            Console.WriteLine("Nhập tên muốn tìm kiếm: ");
            name = Console.ReadLine();
            FunctionClass.FindProduct(add.AddProducts(), name);

            Console.WriteLine("Nhập ID muốn tìm kiếm: ");
            id = int.Parse(Console.ReadLine());
            FunctionClass.FindProductByCategory(add.AddProducts(), id);

            Console.WriteLine("Nhập Price muốn tìm kiếm: ");
            price = int.Parse(Console.ReadLine());
            FunctionClass.FindProductByPrice(add.AddProducts(), price);

            Console.ReadKey();
        }
    }

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
    }
    
    public class FunctionClass
    {
        public static void FindProduct(List<Product> listProduct, string nameProduct)
        {
            foreach (var item in listProduct)
            {
                if (item.Name == nameProduct)
                {
                    Console.WriteLine("Product(name: " + item.Name + ", price: " + item.Price + ", quality: " + item.Quality + ", categoryId: " + item.CategoryId + ")");
                }
            }
        }


        public static void FindProductByCategory(List<Product> listProduct, int categoryId)
        {
            foreach (var item in listProduct)
            {
                if (item.CategoryId == categoryId)
                {
                    Console.WriteLine("Product(name: " + item.Name + ", price: " + item.Price + ", quality: " + item.Quality + ", categoryId: " + item.CategoryId + ")");
                }
            }
        }

        public static void FindProductByPrice(List<Product> listProduct, int price)
        {
            foreach (var item in listProduct)
            {
                if (item.Price <= price)
                {
                    Console.WriteLine("Product(name: " + item.Name + ", price: " + item.Price + ", quality: " + item.Quality + ", categoryId: " + item.CategoryId + ")");
                }
            }
        }
    }

}
