using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class N_digit
    {
        public static void Find()
        {
            int number, n, nDigit;
            Console.WriteLine("Input a number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Input n: ");
            n = int.Parse(Console.ReadLine());
            nDigit = (int)(number / Math.Pow(10,(n - 1))) % (10);
             Console.WriteLine("Result: ");
            if(nDigit == 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine(nDigit);
            }
            
            
        }
    }
}
