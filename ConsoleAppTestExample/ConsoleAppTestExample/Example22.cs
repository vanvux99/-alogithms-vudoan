using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestExample
{
    class Example22
    {
        /**
         * Hãy viết function calMonth(money, rate) , trả về số tháng tiền cần gửi tiết kệm để tiền gốc + 
         * lãi tăng gấp đôi so với tiền gốc. Money là số tiền gốc, rate là % lãi suất mỗi tháng. ví dụ calMount(1000, 5). 
         * Viết bằng 2 cách, đệ qui và không dùng đệ qui 
         */

        public static void TestExample(float money, float rate)
        {
            Console.WriteLine( "Month: {0}", CalMonth(money, rate));
        }

        /**
         * Don't use recursive
         */
        public static int CalMonth(float money, float rate)
        {
            int month = 0;
            float doubleMoney = money * 2;

            while (money < doubleMoney)
            {
                money += (money * rate / 100);
                month++;
            }

            return month;
        }

        /**
         * Use recursive
         */
        public static int CalMonthRecursive(float money, float rate)
        {
            int month = 0;
            float doubleMoney = money * 2;

            if (money > doubleMoney)
            {
                return month;
            }
            money = (CalMonthRecursive(money, rate) + (CalMonthRecursive(money, rate) * 5 / 100));
            month++;
            return month;

        }
    }
}
