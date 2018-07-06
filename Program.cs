using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumx
{
    class Program
    {
        static int sumX(int x, int n)
        {
            int z = 0;
            if (x > 0)
            {
                for (int a = x; a <= n; a += x)
                {
                    z = z + a;
                }
            }
            else if (x < 0)
            {
                for (int a = x; a >= n; a += x)
                {
                    z = z + a;
                }
            }
            else
            {
                return 0;
            }
            return z;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("sumX(3, 10): " + (sumX(3, 10) == 18));
            Console.WriteLine("sumX(1, 10): " + (sumX(1, 10) == 55));
            Console.WriteLine("sumX(0, 10): " + (sumX(0, 10) == 0));
            Console.WriteLine("sumX(-1, 10): " + (sumX(-1, 10) == 0));
            Console.WriteLine("sumX(-1, -10): " + (sumX(-1, -10) == -55));
            Console.WriteLine("sumX(5, 10): " + (sumX(5, 10) == 15));
            Console.WriteLine("sumX(7, 20): " + (sumX(7, 20) == 21));
        }
    }
}
