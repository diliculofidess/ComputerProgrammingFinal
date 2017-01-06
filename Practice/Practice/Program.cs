using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade:");
            int score = int.Parse(Console.ReadLine());
            bool GOOD_GRADE_THRESHOLD = (score >= 80) && (score <= 100);
            bool FAIL_THRESHOLD = (score >= 60) && (score <= 100);     
            if (FAIL_THRESHOLD)
            {
                if (GOOD_GRADE_THRESHOLD)
                { Console.WriteLine("Good grade!Keep on going!"); }
                else { Console.WriteLine("Perfect, keep going!"); }
            }
            else { Console.WriteLine("You need to put more effort in it!"); } 
            }            
        }
    }

