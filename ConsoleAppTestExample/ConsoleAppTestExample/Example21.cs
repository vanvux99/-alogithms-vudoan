using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    /**
     * Hãy viết function calSalary(salary, n) , trả về lương của năm thứ n. 
     * Biết rằng cứ mỗi năm lương sẽ tăng bằng 10% năm liền trước.
     * Viết bằng 2 cách, đệ qui và không dùng đệ qui
     */
    class Example21
    {
        public static void TestExample(float salary, float year)
        {
            Console.WriteLine(CalSalaryRecursive(salary, year));
        }

        /**
         * Don't use recursive
         */
        public static float CalSalary(float salary, float year)
        {
            float result = 0.0f;

            for (int indexSalary = 0; indexSalary < year; indexSalary++)
            {
                salary += salary / 10;
                result = salary;
            }

            return result;
        }

        /**
         * Use recursive
         */
        public static float CalSalaryRecursive(float salary, float year)
        {
            if (year <= 0)
            {
                return salary;
            }
            return (CalSalaryRecursive(salary, year - 1) + CalSalaryRecursive(salary, year - 1) / 10);

        }
    }
}
