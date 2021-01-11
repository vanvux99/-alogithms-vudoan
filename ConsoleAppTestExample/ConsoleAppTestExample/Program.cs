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

            /*Console.WriteLine("Nhập tên muốn tìm kiếm: ");
            name = Console.ReadLine();
            FunctionClass.Test(add.AddProducts(), name, id, price, add.AddProductsByArray(), 4);*/

            /*Console.WriteLine("Liệt kê ID giống nha ");
            id = int.Parse(Console.ReadLine());
            FunctionClass.Test(add.AddProducts(), name, id, price, add.AddProductsByArray(), 5);*/

            /*Console.WriteLine("Price nhỏ hơn Price nhập vào: ");
            price = int.Parse(Console.ReadLine());
            FunctionClass.Test(add.AddProducts(), name, id, price, add.AddProductsByArray(), 6);*/

            /*Console.WriteLine("Sắp xếp Price tăng dần");
            FunctionClass.Test(add.AddProducts(), name, id, price, add.AddProductsByArray(), 11);*/

            /*Console.WriteLine("Độ dài của tên từ cao đén thấp");
            FunctionClass.Test(add.AddProducts(), name, id, price, add.AddProductsByArray(), 12);*/

            Console.ReadKey();
        }
    }
}
