using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的身高(公分)");
            double cm = double.Parse(Console.ReadLine())/100.0;
            Console.WriteLine("請輸入你的體重(公斤)");
            double kg = double.Parse(Console.ReadLine());
            double BodyWeightIndex = kg / Math.Pow(cm, 2.0);
            Console.WriteLine("BMI={0}", BodyWeightIndex);
            if(BodyWeightIndex > 27.0)
            { Console.WriteLine("超重!該運動了!"); }           
            { Console.WriteLine("繼續保持!"); }
        }
    }
}
