using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum=0;
            for (i = 2; i <= 100; i += 2) 
            { sum += i; }
            Console.WriteLine("顯示的數字為1~100偶數的總和" + sum);
        }
    }
}
