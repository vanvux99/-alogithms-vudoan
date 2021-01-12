using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    public class Example13
    {
        /**
            Hãy viết function sortByCategoryName(listProduct, listCategory) 
            trả về danh sách product sắp xếp theo category name theo thứ tự abc. . 
            Làm theo thuật toán selection. 
        */

        /**
         * Thêm 1 thuộc tính name vào Product và gán nó bằng name của cateegory khi và chỉ khi id của category và id của product bằng nhau.
         */

        static Product product = new Product();
        static Category category = new Category();

        /**
         * Test Ex 13
         */
        public static void Test(Product[] listProduct, Category[] listCatefory)
        {
            /*foreach (var item in SortByCategoryName(listProduct, listCategory))
            {
                Console.WriteLine(item.CategoryName);
            }*/

            foreach (var item in SortByCategoryName(listProduct, listCatefory))
            {
                Console.WriteLine(item.Name);
            }
        }

        /*
         * Set data into the product
         */
        public static List<Product> SetDataForProduct(Product[] listProduct, Category[] listCategory)
        {
            List<Product> list = new List<Product>();

            for (int indexProduct = 0; indexProduct < listProduct.Length; indexProduct++)
            {
                for (int indexCategory = 0; indexCategory < listCategory.Length; indexCategory++)
                {
                    string testName = listProduct[indexProduct].CategoryId.ToString();
                    string testName1 = listCategory[indexCategory].ID.ToString();
                    if (listProduct[indexProduct].CategoryId == listCategory[indexCategory].ID) // compare 2 id, if it is equal then set categoryName into the constructor for product
                    {
                        string compare = listCategory[indexCategory].Name;

                        Product product1 = new Product(product.Name, product.Price, product.Quality, product.CategoryId, compare);
                        list.Add(product1);
                    }
                }
            }

            return list;
        }

        /*
         * Sort by Category name
         */
        public static Product[] SortByCategoryName(Product[] listProduct, Category[] listCategory)
        {
            List<Product> setData = new List<Product>();
            int min = 0;

            setData = SetDataForProduct(listProduct, listCategory);
            for (int i = 0; i < setData.Count - 1; i++)
            {
                min = i;
                for (int index = i + 1; index < setData.Count; index++)
                {
                    if (string.Compare(setData[index].Name, setData[min].Name) > 0) // không so sánh được các ggias trị tên
                    {
                        min = index;
                    }
                }
                FunctionExample.Swap(listProduct, i, min);
            }

            return listProduct;
        }
    }
}
