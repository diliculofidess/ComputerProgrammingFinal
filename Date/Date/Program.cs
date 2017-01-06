using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (i < 100)
            {
                ++i;
                sum += i;
            }
            Console.WriteLine("1 + 2 + 3 + . . . + 100 = " + sum);


        }
    }
}
