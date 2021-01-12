using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    public class Category
    {
        List<Category> listCategory = new List<Category>();

        public int ID { get; set; }
        public string Name { get; set; }

        public Category()
        {

        }

        public Category(string _name, int _iD)
        {
            ID = _iD;
            Name = _name;
        }

        /*
         * Set data in Category by List 
         */
        public List<Category> SetDataCategory()
        {
            Category category = new Category("Computer", 1);
            Category category1 = new Category("Memory", 2);
            Category category2 = new Category("Card", 3);
            Category category3 = new Category("Acsesory", 4);

            listCategory.Add(category);
            listCategory.Add(category1);
            listCategory.Add(category2);
            listCategory.Add(category3);

            return listCategory;
        }

        /**
         * Set data in Category by Array
         */
        public Category[] AddCategorysByArray() // set data in array
        {
            Category[] array = new Category[4];

            int countDataCategory = SetDataCategory().Count;
            int countListCategory = 0;

            for (int indexArray = 0; indexArray < array.Length; indexArray++)
            {
                for (int indexListProduct = 0; indexListProduct < countDataCategory; indexListProduct++)
                {
                    if (countListCategory == indexArray)
                    {
                        array[indexArray] = SetDataCategory()[indexArray];
                        string test1 = array[indexArray].Name;
                        countListCategory++;
                    }
                }

            }

            return array;
        }
    }
}
