using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfor1028_BMI_BP_BS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("這是一個檢測各年齡層血壓是否在標準值的量表。");
            Console.WriteLine("系統會透過您輸入的資料，告訴您的標準血壓，以及是否有高/低血壓的風險。");
            Console.WriteLine("建議測量血壓的時間：早上起床半小時內/晚上睡覺前一小時");

            Console.WriteLine("首先，請輸入您的年齡:");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("接下來，請輸入您的收縮壓(通常數值較大):");
            int EDV = int.Parse(Console.ReadLine());
            Console.WriteLine("最後，請輸入您的舒張壓(通常數值較小):");
            int ESV = int.Parse(Console.ReadLine());

            double StandardEDV = age * 0.3 + 104;
            double StandardESV = age * 0.2 + 70;
            Console.WriteLine("您的標準收縮壓為:" + StandardEDV);
            Console.WriteLine("您的標準舒張壓為:" + StandardESV);

            bool HIGH_BLOOD_PRESSURE = EDV >= 180;
            bool HIGH_BLOOD_PRESSURE_DANGER = EDV >= 160;
            if(HIGH_BLOOD_PRESSURE_DANGER)
            { if (HIGH_BLOOD_PRESSURE)
                {
                    Console.WriteLine("您已經罹患高血壓!請盡早至醫院治療!");
                }
                else { Console.WriteLine("您是罹患高血壓患者的危險族群，請規律飲食以及運動。"); }
            }
            else { Console.WriteLine("您的血壓目前在正常值，請繼續保持!"); }
        }
    }
}
