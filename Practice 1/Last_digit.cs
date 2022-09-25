using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class Last_digit
    {
        public static void Print()
        {
            int n, lastDigit;
            Console.WriteLine("Input any number: ");
            n = int.Parse(Console.ReadLine());
            lastDigit = n %(10);
            Console.WriteLine("Last digit is: ");
            Console.WriteLine(lastDigit);
        }
    }
}
