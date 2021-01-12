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

            Product product = new Product();
            Category category = new Category();
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


            #region Example 13

            //Example13.SortByCategoryName(product.AddProductsByArray(), category.AddCategorysByArray());
            Example13.Test(product.AddProductsByArray(), category.AddCategorysByArray());

            #endregion


            /*            #region  Example 14
                        Console.WriteLine("Nhập ID: ");
                        id = int.Parse(Console.ReadLine());
                        Example14.TestExample14(product.AddProductsByArray(), category.AddCategorysByArray(), id);
                        #endregion*/


            /*            #region Example 15 
                        Console.WriteLine("Price nhỏ nhất: ");
                        Example15.TestExample(product.AddProductsByArray());
                        #endregion*/

            #region Example 16 

            /*Console.WriteLine("Price lớn nhất: ");
            Example16.TestExample(product.AddProductsByArray());*/

            #endregion

            #region Example 21

            /*Console.Write("Salary: ");
            float salary = float.Parse(Console.ReadLine());
            Console.Write("Year: ");
            float year = float.Parse(Console.ReadLine());*/

            //Example21.TestExample(100, 3);

            #endregion

            #region Example 22

            /*Console.Write("Money: ");
            float money = float.Parse(Console.ReadLine());
            Console.Write("Rate: ");
            float rate = float.Parse(Console.ReadLine());*/
            //Example22.CalMonthRecursive(1000, 5);

            #endregion

            Console.ReadKey();
        }
    }
}
