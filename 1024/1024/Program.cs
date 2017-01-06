using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            String a = Console.ReadLine();
            Console.WriteLine("Enter another word");
            String b = Console.ReadLine();
            Console.WriteLine("Enter the last word");
            String c = Console.ReadLine();
            Console.WriteLine(c +" " + b + " " + a);
        }
    }
}
