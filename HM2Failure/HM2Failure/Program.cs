using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2Failure
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用者重新輸入剛計算出的基礎代謝率以及日常活動代謝量
            Console.WriteLine("請輸入剛剛計算出來的基礎代謝量:");
            double ConsumptionDLnew = double.Parse(Console.ReadLine());
            Console.WriteLine("請輸入剛剛計算出來的日常活動消耗量:");
            double BMRnew = double.Parse(Console.ReadLine());

            //g為五穀根莖類(grains),m為蛋豆魚肉類(meat&egg),v為蔬菜類(vegetables),f為水果類(fruit),d為奶類(dairy)
            string[] g_for_breakfast = new string[9] { "白稀飯一碗(150g)", "白飯一碗(150g)", "五穀飯一碗(150g)", "白麵線一碗(50g)", "饅頭一顆", "番薯一顆(100g)", "全麥土司一片", "白吐司一片", "小餐包兩個" };
            double[] calories_g_for_breakfast = new double[9] { 100, 200, 225, 125, 280, 85, 75, 75, 140 };
            string[] g = new string[8] { "白飯一碗(150g)", "五穀飯一碗(150g)", "白麵線一碗(50g)", "拉麵一碗(150g)", "烏龍麵一碗(150g)", "意麵一碗(150g)", "紫米飯一碗(100g)", "馬鈴薯一顆(100g)" };
            double[] calories_g = new double[8] { 200, 225, 125, 436.2, 200, 400, 353, 76 };
            string[] m_for_breakfast = new string[11] { "無糖豆漿一杯", "低糖豆漿一杯", "統一豆漿一杯", "糙米漿一杯", "白煮蛋一顆", "茶葉蛋一顆", "煎蛋一顆", "炒蛋一顆", "蒸蛋一顆", "荷包蛋一顆", "三湯匙肉鬆" };
            double[] calories_m_for_breakfast = new double[11] { 147, 200, 249, 321, 70, 90, 85, 95, 80, 85, 112.5 };
            string[] m = new string[9] { "清煮雞胸肉一份(100g)", "鮭魚一份(100g)", "滷雞排一份(200g)", "炸雞排一份(200g)", "排骨一份", "炸豬排一份", "蒸魚一份", "香腸半根", "培根一片(100g)" };
            double[] calories_m = new double[9] { 115, 208.2, 380, 450, 251, 280, 160, 254, 309 };
            string[] v = new string[22] { "高麗菜一份(100g)", "空心菜一份(100g)", "青江菜一份(100g)", "冬瓜一份(100g)", "花椰菜一份(100g)", "竹筍一份(100g)", "豆芽菜一份(100g)", "芥藍一份(100g)", "絲瓜一份(100g)",
                "小黃瓜一份(100g)", "青椒一份(100g)", "菠菜一份(100g)", "小白菜一份(100g)", "苦瓜一份(100g)", "洋蔥一份(100g)", "甜玉米一根", "白玉米一根", "大陸妹一份(100g)", "A菜一份(100g)", "莧菜一份(100g)", "胡瓜一份(100g)", "蘆筍一份(100g)" };
            double[] calories_v = new double[22] { 23, 19, 16, 13, 25, 27.5, 22.9, 22.5, 17, 13, 20.1, 23.2, 13, 34.4, 39.7, 280, 200, 14, 30, 30, 15.5, 20.3 };
            string[] f = new string[] { "蘋果一顆", "香瓜一顆", "釋迦一顆", "香蕉一根", "橘子一顆", "柳丁一顆", "楊桃一顆", "奇異果一顆", "哈密瓜半顆", "西瓜一片", "蓮霧一顆", "荔枝十顆", "小草莓十顆", "葡萄十顆", "龍眼十五顆", "木瓜半顆", "西洋梨一顆", "鳳梨一片", "小番茄十顆" };
            double[] calories_f = new double[19] { 55, 89, 120, 120, 60, 60, 75, 30, 120, 40, 30, 70, 40, 50, 75, 90, 60, 60, 30 };
            
            Random bg = new Random();
            int breakfastgrainchoice = bg.Next(1, 9);
            Random bm = new Random();
            int breakfastmeatchoice = bm.Next(1, 11);
            Random bv = new Random();
            int breakfastvegechoice = bv.Next(1, 22);
            Random bf = new Random();
            int breakfastfruitchoice = bf.Next(1, 19);

            double totalcaloriesbreakfast = calories_g_for_breakfast[breakfastgrainchoice] + calories_m_for_breakfast[breakfastmeatchoice] + calories_v[breakfastvegechoice] + calories_f[breakfastfruitchoice];
            bool goodchoiceforbreakfast = (totalcaloriesbreakfast <= ConsumptionDLnew * 0.3) && (totalcaloriesbreakfast >= BMRnew * 0.3);

            if (goodchoiceforbreakfast)
            {
                Console.WriteLine("早餐列表:" + '\n' + g_for_breakfast[breakfastgrainchoice] + "  " + calories_g_for_breakfast[breakfastgrainchoice] + '\n'
                    + m_for_breakfast[breakfastmeatchoice] + "  " + calories_m_for_breakfast[breakfastvegechoice] + '\n'
                    + v[breakfastvegechoice] + "  " + calories_v[breakfastvegechoice] + '\n'
                    + f[breakfastfruitchoice] + "  " + calories_f[breakfastfruitchoice] + '\n');

            }
            
            //輸出午餐食譜
            for (; ; )
            {
                Random lg = new Random();
                int lunchgrainchoice = lg.Next(1, 8);
                Random lm = new Random();
                int lunchmeatchoice = lm.Next(1, 9);
                Random lv = new Random();
                int lunchvegechoice = lv.Next(1, 22);
                Random lf = new Random();
                int lunchfruitchoice = lf.Next(1, 19);

                double totalcalorieslunch = calories_g[lunchgrainchoice] + calories_m[lunchmeatchoice] + calories_v[lunchvegechoice] + calories_f[lunchfruitchoice];
                bool goodchoiceforlunch = (totalcalorieslunch <= ConsumptionDLnew * 0.4) && (totalcalorieslunch >= BMRnew * 0.4);

                if (goodchoiceforlunch)
                {
                    Console.WriteLine("午餐列表:" + '\n' + g[lunchgrainchoice] + "  " + calories_g[lunchgrainchoice] + '\n'
                        + m[lunchmeatchoice] + "  " + calories_m[lunchvegechoice] + '\n'
                        + v[lunchvegechoice] + "  " + calories_v[lunchvegechoice] + '\n'
                        + f[lunchfruitchoice] + "  " + calories_f[lunchfruitchoice] + '\n');
                    break;
                }
            }
            
            //輸出晚餐食譜
            for (; ; )
            {
                Random dg = new Random();
                int dinnergrainchoice = dg.Next(1, 8);
                Random dm = new Random();
                int dinnermeatchoice = dm.Next(1, 9);
                Random dv = new Random();
                int dinnervegechoice = dv.Next(1, 22);
                Random df = new Random();
                int dinnerfruitchoice = df.Next(1, 19);
                
                double totalcaloriesdinner = calories_g[dinnergrainchoice] + calories_m[dinnermeatchoice] + calories_v[dinnervegechoice] + calories_f[dinnerfruitchoice];
                bool goodchoicefordinner = (totalcaloriesdinner <= ConsumptionDLnew * 0.4) && (totalcaloriesdinner >= BMRnew * 0.4);
                
                if (goodchoicefordinner)
                {
                    Console.WriteLine("晚餐列表:" + '\n' + g[dinnergrainchoice] + "  " + calories_g[dinnergrainchoice] + '\n'
                        + m[dinnermeatchoice] + "  " + calories_m[dinnervegechoice] + '\n'
                        + v[dinnervegechoice] + "  " + calories_v[dinnervegechoice] + '\n'
                        + f[dinnerfruitchoice] + "  " + calories_f[dinnerfruitchoice] + '\n');
                    break;
                }
        }
    }
}
