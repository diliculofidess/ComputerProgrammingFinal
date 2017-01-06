using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number n, the computer will give out methods to climb up.");
            int n = int.Parse(Console.ReadLine());
            int x;
            int y;
            int z;
            int f = 0;
            for (x = 1; x <=3 ; ++x)
            {
                for (y = 1; y <= 3; ++y)
                {
                    for (z = 1; z <= 3; ++z)
                    {
                        if (x + y + z != n) continue;
                        ++f;
                        Console.WriteLine("{0}:{1}+{2}+{3}=n", f, x, y, z);
                        break;
                    } 
                }
            }

        }
    }
}