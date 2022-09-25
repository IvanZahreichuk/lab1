using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class PureDivisor
    {
        public static void Divide()
        {
            int n, result;
            Console.WriteLine("Input n:");
            n = int.Parse(Console.ReadLine());
            if (n % (9) == 0 && n % (11)==0 && n % (13)==0)
            {
                Console.WriteLine("False!");
            }
            else
            {
                Console.WriteLine("True!");
            }
        }
    }
}
