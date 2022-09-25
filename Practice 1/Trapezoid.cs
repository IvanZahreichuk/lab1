using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    static class Trapezoid
    {
        public static void Calculate()
        {
            float a, b, h, area;
            Console.WriteLine("Input a:");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Input b:");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Input h:");
            h = float.Parse(Console.ReadLine());

            area = ((a + b) / 2) * h;

            Console.WriteLine("Area =");
            Console.WriteLine(area);
        }
    }
}
