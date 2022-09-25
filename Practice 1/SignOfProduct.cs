using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class SignOfProduct
    {
        public static void Product()
        {
            int a, b, c;
            int countMinus = 0;
            Console.WriteLine("Input a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input c:");
            c = int.Parse(Console.ReadLine());
            if (Math.Sign(a) == -1)
            {
                countMinus += 1;
            }
            if (Math.Sign(b) == -1)
            {
                countMinus += 1;
            }
            if (Math.Sign(c) == -1)
            {
                countMinus += 1;
            }
            if (countMinus == 0 || countMinus == 2)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
