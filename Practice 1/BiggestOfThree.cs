using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class BiggestOfThree
    {
        public static void Biggest()
        {
            int a, b, c;
            Console.WriteLine("Input a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input c:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number is: ");
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
        }
    }
}
