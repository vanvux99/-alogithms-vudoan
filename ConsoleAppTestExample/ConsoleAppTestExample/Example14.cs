using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    public class Example14
    {
        /**
         * Hãy viết function mapProductByCategory(listProduct, listCategory) 
         * trả về danh sách product có chứa tên category tương ứng theo categoryId
         */

        public static void TestExample14(Product[] listProduct, Category[] listCategory, int categoryId)
        {
            foreach (var listPro in MapProductByCategory(listProduct, listCategory, categoryId))
            {
                Console.WriteLine("Product(name: {0}, price: {1}, quality: {2}, categoryId: {3}, categoryName: {4}) ", listPro.Name, listPro.Price,
                    listPro.Quality, listPro.CategoryId, listPro.CategoryName);
            }
        }

        public static List<Product> MapProductByCategory(Product[] listProduct, Category[] listCategory, int categoryId)
        {
            List<Product> list = new List<Product>();

            for (int indexPro = 0; indexPro < listProduct.Length; indexPro++)
            {
                for (int indexCate = 0; indexCate < listCategory.Length; indexCate++)
                {
                    if (listProduct[indexPro].CategoryId == listCategory[indexCate].ID && listProduct[indexPro].CategoryId == categoryId)
                    {
                        string name = listCategory[indexCate].Name;

                        Product product1 = new Product(listProduct[indexPro].Name, listProduct[indexPro].Price,
                            listProduct[indexPro].Quality, listProduct[indexPro].CategoryId, name);
                        list.Add(product1);
                    }
                }
            }

            return list;
        }
    }
}
