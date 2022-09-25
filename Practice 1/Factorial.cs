using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class Factorial
    {
        public static void Factor()
        {
            int n, factorial;
            factorial = 1;

            Console.WriteLine("Input n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial =");
            Console.WriteLine( factorial);
        }
    }
}
