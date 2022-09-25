using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class BigOdd
    {
        public static void Check()
        {
            int n;
            bool m;
            Console.WriteLine("Input number: ");
            n = int.Parse(Console.ReadLine());
            if (n > 20&& (n % (2)) == 1)
            {
                m = true;
            }
            else
            {
                m = false;
            }
            if (m == true)
            {
                Console.WriteLine("True!");
            }
            else
            {
                Console.WriteLine("False!");
            }
        }
    }
}
