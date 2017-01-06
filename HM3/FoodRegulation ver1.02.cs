/*
 * 1.使用者輸入基本數值
 *  
 * 2.計算出BMI,BMR,日常活動消耗量    
 * 2-1.BMI公式=(體重(公斤)/(身高(公尺)*身高(公尺))    
 * 2-2.BMR(男)=(13.7×體重(公斤))+(5.0×身高(公分))-(6.8×年齡)+66
       BMR(女)=(9.6×體重(公斤))+(1.8×身高(公分))-(4.7×年齡)+655    
 * 2-3.日常活動消耗量for標準體重=體重(公斤)*30
       日常活動消耗量for過重=體重(公斤)*25
 * 
 * 3.進行食譜建議
 * 3-1.輸入各食物的卡路里數值，並區別早餐及午晚餐
 * 3-2.1.對BMI指數過高的人
 *       用for迴圈計算是否符合身體所需
 *       符合條件的食物:基礎代謝率<整天吸收的熱量<日常活動消耗量
 * 3-2.2.對BMI指數正常的人
 *       用random隨機抽取各類別食物中的一項    
 * 3-3.1.對BMI指數過高的人，列出所有符合的食譜
 * 3-3.2.對BMI指數正常的人，輸出一份隨機食譜
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HM2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的年齡:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入你的性別(男輸入1/女輸入2):");
            int gender = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入你的身高(公分):");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("請輸入你的體重(公斤):");
            double weight = double.Parse(Console.ReadLine());
            double BMI = weight / (height / 100 * height / 100);
            double ConsumptionDL;
            double BMR;


            //輸出BMI值並判斷是否為標準體重
            if (BMI > 24.0)
            {
                Console.WriteLine("BMI=" + BMI + '\n' + "你已經超重了!要進行飲食及運動管理!");
            }
            else if (BMI < 18.5)
            {
                Console.WriteLine("BMI=" + BMI + '\n' + "你過輕了!要進行飲食及運動管理!");
            }
            else
            {
                Console.WriteLine("BMI=" + BMI + '\n' + "你的BMI值很正常!繼續保持!");
            }

            //延遲五秒後清除畫面，詢問使用者是否進行飲食建議
            //加入using System.Threading;組件
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("你要進行健康建議嗎?(y/n)");
            char HealthSuggest = Console.ReadLine().ToCharArray()[0];
            switch (HealthSuggest)
            {
                case 'n':
                    Console.WriteLine("感謝您的使用!");
                    return;
                case 'y':    //輸出基礎代謝率以及日常活動代謝量
                    if (gender >= 2)
                    {
                        BMR = (9.6 * weight) + (1.8 * height) - (4.7 * age) + 655;
                        Console.WriteLine("BMI=" + BMI + '\n' + "BMR(基礎代謝率)=" + BMR);

                    }
                    else
                    {
                        BMR = (13.7 * weight) + (5.0 * height) - (6.8 * age) + 66;
                        Console.WriteLine("BMI=" + BMI + '\n' + "BMR(基礎代謝率)=" + BMR);

                    }
                    if (BMI > 24.0)
                    {
                        ConsumptionDL = weight * 25;
                        Console.WriteLine("日常活動消耗量=" + ConsumptionDL);
                    }
                    else
                    {
                        ConsumptionDL = weight * 30;
                        Console.WriteLine("日常活動消耗量=" + ConsumptionDL);
                    }
                    break;
            }
            if (BMI > 24.0)
            {
                Console.WriteLine("一天攝取的能量若在基礎代謝量以上，日常活動消耗量以下，可以減肥。");
                Console.WriteLine("請問要進行食譜建議嗎?(y/n)");
            }
            else
            {
                Console.WriteLine("一天攝取的能量必須在基礎代謝量以上，日常活動消耗量以下，");
                Console.WriteLine("若要增肌，可以食用高蛋白食物。");
                Console.WriteLine("請問要進行食譜隨機選擇嗎?(y/n)");
            }

            char Recipe = Console.ReadLine().ToCharArray()[0];
            switch (Recipe)
            {
                case 'n':
                    Console.WriteLine("感謝您的使用!");
                    return;
                case 'y':
                    Console.Clear();
                    Console.WriteLine("以下是您的食譜選擇：" + '\n' + '\n' + '\n');
                    break;
            }


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

            //早餐變數
            int breakfastgrainchoice;
            int breakfastmeatchoice;
            int breakfastvegechoice;
            int breakfastfruitchoice;

            //午餐變數
            int lunchgrainchoice;
            int lunchmeatchoice;
            int lunchvegechoice;
            int lunchfruitchoice;

            //晚餐變數
            int dinnergrainchoice;
            int dinnermeatchoice;
            int dinnervegechoice;
            int dinnerfruitchoice;

            //分成BMI指數過高的以及BMI指數正常的輸出不同的食譜

            if (BMI >= 24)
            {
                //輸出早餐食譜            
                for (breakfastgrainchoice = 0; breakfastgrainchoice <= calories_g_for_breakfast.Length; ++breakfastgrainchoice)
                {
                    for (breakfastmeatchoice = 0; breakfastmeatchoice <= calories_m_for_breakfast.Length; ++breakfastmeatchoice)
                    {
                        for (breakfastvegechoice = 0; breakfastvegechoice <= calories_v.Length; ++breakfastvegechoice)
                        {
                            for (breakfastfruitchoice = 0; breakfastfruitchoice <= calories_f.Length; ++breakfastfruitchoice)
                            {
                                double totalcaloriesbreakfast = calories_g_for_breakfast[breakfastgrainchoice] + calories_m_for_breakfast[breakfastmeatchoice] + calories_v[breakfastvegechoice] + calories_f[breakfastfruitchoice];
                                bool goodchoiceforbreakfast = (totalcaloriesbreakfast <= ConsumptionDL * 0.3) && (totalcaloriesbreakfast >= BMR * 0.3);

                                if (goodchoiceforbreakfast)
                                {
                                    Console.WriteLine("早餐列表:" + '\n' + g_for_breakfast[breakfastgrainchoice] + "  " + calories_g_for_breakfast[breakfastgrainchoice] + '\n'
                                        + m_for_breakfast[breakfastmeatchoice] + "  " + calories_m_for_breakfast[breakfastmeatchoice] + '\n'
                                        + v[breakfastvegechoice] + "  " + calories_v[breakfastvegechoice] + '\n'
                                        + f[breakfastfruitchoice] + "  " + calories_f[breakfastfruitchoice] + '\n');
                                    
                                }
                            }
                        }
                    }
                }

                //輸出午餐食譜
                for (lunchgrainchoice = 0; lunchgrainchoice <= calories_g_for_breakfast.Length; ++lunchgrainchoice)
                {
                    for (lunchmeatchoice = 0; lunchmeatchoice <= calories_m_for_breakfast.Length; ++lunchmeatchoice)
                    {
                        for (lunchvegechoice = 0; lunchvegechoice <= calories_v.Length; ++lunchvegechoice)
                        {
                            for (lunchfruitchoice = 0; lunchfruitchoice <= calories_f.Length; ++lunchfruitchoice)
                            {
                                double totalcalorieslunch = calories_g[lunchgrainchoice] + calories_m[lunchmeatchoice] + calories_v[lunchvegechoice] + calories_f[lunchfruitchoice];
                                bool goodchoiceforlunch = (totalcalorieslunch <= ConsumptionDL * 0.4) && (totalcalorieslunch >= BMR * 0.4);

                                if (goodchoiceforlunch)
                                {
                                    Console.WriteLine("午餐列表:" + '\n' + g[lunchgrainchoice] + "  " + calories_g[lunchgrainchoice] + '\n'
                                       + m[lunchmeatchoice] + "  " + calories_m[lunchvegechoice] + '\n'
                                        + v[lunchvegechoice] + "  " + calories_v[lunchvegechoice] + '\n'
                                        + f[lunchfruitchoice] + "  " + calories_f[lunchfruitchoice] + '\n');
                                    
                                }
                            }
                        }
                    }
                }


                //輸出晚餐食譜
                for (dinnergrainchoice = 0; dinnergrainchoice <= calories_g_for_breakfast.Length; ++dinnergrainchoice)
                {
                    for (dinnermeatchoice = 0; dinnermeatchoice <= calories_m_for_breakfast.Length; ++dinnermeatchoice)
                    {
                        for (dinnervegechoice = 0; dinnervegechoice <= calories_v.Length; ++dinnervegechoice)
                        {
                            for (dinnerfruitchoice = 0; dinnerfruitchoice <= calories_f.Length; ++dinnerfruitchoice)
                            {
                                double totalcaloriesdinner = calories_g[dinnergrainchoice] + calories_m[dinnermeatchoice] + calories_v[dinnervegechoice] + calories_f[dinnerfruitchoice];
                                bool goodchoicefordinner = (totalcaloriesdinner <= ConsumptionDL * 0.4) && (totalcaloriesdinner >= BMR * 0.4);

                                if (goodchoicefordinner)
                                {
                                    Console.WriteLine("晚餐列表:" + '\n' + g[dinnergrainchoice] + "  " + calories_g[dinnergrainchoice] + '\n'
                                        + m[dinnermeatchoice] + "  " + calories_m[dinnervegechoice] + '\n'
                                        + v[dinnervegechoice] + "  " + calories_v[dinnervegechoice] + '\n'
                                        + f[dinnerfruitchoice] + "  " + calories_f[dinnerfruitchoice] + '\n');
                                    
                                }
                            }
                        }
                    }
                }
            }
            else
            {            
                //輸出早餐列表
                for (breakfastgrainchoice = 0; breakfastgrainchoice <= calories_g_for_breakfast.Length; ++breakfastgrainchoice)
                {
                    for (breakfastmeatchoice = 0; breakfastmeatchoice <= calories_m_for_breakfast.Length; ++breakfastmeatchoice)
                    {
                        for (breakfastvegechoice = 0; breakfastvegechoice <= calories_v.Length; ++breakfastvegechoice)
                        {
                            for (breakfastfruitchoice = 0; breakfastfruitchoice <= calories_f.Length; ++breakfastfruitchoice)
                            {
                                Random lg = new Random();
                                breakfastgrainchoice = lg.Next(1, 9);
                                Random lm = new Random();
                                breakfastmeatchoice = lm.Next(1, 11);
                                Random lv = new Random();
                                breakfastvegechoice = lv.Next(1, 22);
                                Random lf = new Random();
                                breakfastfruitchoice = lf.Next(1, 19);
                                Console.WriteLine("早餐列表:" + '\n' + g_for_breakfast[breakfastgrainchoice] + " " + calories_g_for_breakfast[breakfastgrainchoice] + '\n'
                                    + m_for_breakfast[breakfastmeatchoice] + " " + calories_m_for_breakfast[breakfastvegechoice] + '\n' + v[breakfastvegechoice] + " "
                                    + calories_v[breakfastvegechoice] + '\n' + f[breakfastfruitchoice] + " "
                                    + calories_f[breakfastfruitchoice] + '\n');
                            }
                        }
                    }
                }

                //輸出午餐食譜
                for (lunchgrainchoice = 0; lunchgrainchoice <= calories_g_for_breakfast.Length; ++lunchgrainchoice)
                {
                    for (lunchmeatchoice = 0; lunchmeatchoice <= calories_m_for_breakfast.Length; ++lunchmeatchoice)
                    {
                        for (lunchvegechoice = 0; lunchvegechoice <= calories_v.Length; ++lunchvegechoice)
                        {
                            for (lunchfruitchoice = 0; lunchfruitchoice <= calories_f.Length; ++lunchfruitchoice)
                            {
                                Random lg = new Random(); 
                                lunchgrainchoice = lg.Next(1, 8); 
                                Random lm = new Random(); 
                                lunchmeatchoice = lm.Next(1, 9); 
                                Random lv = new Random(); 
                                lunchvegechoice = lv.Next(1, 22); 
                                Random lf = new Random();
                                lunchfruitchoice = lf.Next(1, 19);
                                Console.WriteLine("午餐列表:" + '\n' + g[lunchgrainchoice] + " " + calories_g[lunchgrainchoice] + '\n' 
                                    + m[lunchmeatchoice] + " " + calories_m[lunchvegechoice] + '\n' + v[lunchvegechoice] + " " 
                                    + calories_v[lunchvegechoice] + '\n' + f[lunchfruitchoice] + " " 
                                    + calories_f[lunchfruitchoice] + '\n');

                            }
                        }
                    }
                }

                //輸出晚餐食譜
                for (dinnergrainchoice = 0; dinnergrainchoice <= calories_g_for_breakfast.Length; ++dinnergrainchoice)
                {
                    for (dinnermeatchoice = 0; dinnermeatchoice <= calories_m_for_breakfast.Length; ++dinnermeatchoice)
                    {
                        for (dinnervegechoice = 0; dinnervegechoice <= calories_v.Length; ++dinnervegechoice)
                        {
                            for (dinnerfruitchoice = 0; dinnerfruitchoice <= calories_f.Length; ++dinnerfruitchoice)
                            {
                                Random lg = new Random();
                                dinnergrainchoice = lg.Next(1, 8);
                                Random lm = new Random();
                                dinnermeatchoice = lm.Next(1, 9);
                                Random lv = new Random();
                                dinnervegechoice = lv.Next(1, 22);
                                Random lf = new Random();
                                dinnerfruitchoice = lf.Next(1, 19);
                                Console.WriteLine("晚餐列表:" + '\n' + g[dinnergrainchoice] + " " + calories_g[dinnergrainchoice] + '\n'
                                    + m[dinnermeatchoice] + " " + calories_m[dinnervegechoice] + '\n' + v[dinnervegechoice] + " "
                                    + calories_v[dinnervegechoice] + '\n' + f[dinnerfruitchoice] + " "
                                    + calories_f[dinnerfruitchoice] + '\n');
                            }
                        }
                    }
                }
            }
        }
    }
}

 




