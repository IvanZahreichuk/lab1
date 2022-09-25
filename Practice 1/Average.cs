using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    static class Average
    {
        public static void Calculate()
        {
            //1. Declare
            int a, b, c, average;

            //2. Read
            Console.WriteLine("Input a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input c:");
            c = int.Parse(Console.ReadLine());

            //3. Calculate
            average = (a + b + c) / 3;

            //4. Print
            Console.WriteLine("Average: ");
            Console.WriteLine(average);
        }
    }
}
