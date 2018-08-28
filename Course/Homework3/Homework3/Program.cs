using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arrayBentoName = new string[11];
            int[] arrayBentoPrice = new int[10];
            int price = 0;

            //菜單
            arrayBentoName[0] = "1. 黃金炸雞腿便當";
            arrayBentoName[1] = "2. 黃金炸豬排便當";
            arrayBentoName[2] = "3. 香煎秋刀魚便當";
            arrayBentoName[3] = "4. 滷香雞腿便當";
            arrayBentoName[4] = "5. 滷香排骨便當";
            arrayBentoName[5] = "6. 香甜蜜汁雞腿便當";
            arrayBentoName[6] = "7. 蔥爆羊肉便當";
            arrayBentoName[7] = "8. 北海鱈魚便當";
            arrayBentoName[8] = "9. 清淡養身素食便當";
            arrayBentoName[9] = "10. 多汁豐厚牛排便當";
            arrayBentoName[10] = "Q. 不小心按錯店家須離開";

            //價錢
            arrayBentoPrice[0] = 85;
            arrayBentoPrice[1] = 80;
            arrayBentoPrice[2] = 75;
            arrayBentoPrice[3] = 85;
            arrayBentoPrice[4] = 80;
            arrayBentoPrice[5] = 85;
            arrayBentoPrice[6] = 80;
            arrayBentoPrice[7] = 85;
            arrayBentoPrice[8] = 85;
            arrayBentoPrice[9] = 100;
            
            //設計無窮迴圈的詢問, 但要可以結束程式

            while (true) {

                Console.WriteLine("歡迎光臨~小林便當店選單系統~\n");
                Console.WriteLine("本店菜單有:");

                for (int i = 0; i < arrayBentoName.Length; i++) {
                    Console.WriteLine("\n" + arrayBentoName[i] + " ");
                }

                Console.WriteLine("\n點餐的方式，請輸入菜單編號:\n");

                string strSearchForLunch = Console.ReadLine();

                if (strSearchForLunch != "Q") {

                    ClickMenu(strSearchForLunch, arrayBentoName, arrayBentoPrice, price);
                    
                    Console.WriteLine("\n親愛的客戶請稍等，馬上為您送上熱騰騰的佳餚 ^__^ \n");
                    Console.WriteLine("*********************************************************************\n");
                    Console.WriteLine("親愛的客戶如果需要在點餐，請您按下 \"enter\"");
                    Console.WriteLine("\n親愛的客戶如果要離開點餐區，請按下 \"Q\"");
                    Console.WriteLine("\n*********************************************************************\n");

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

        }
        //客戶選擇菜單的條件是
        public static void ClickMenu(string strSearchForLunch, string[] arrayBentoName,int[] arrayBentoPrice,int price)
        {
            switch (strSearchForLunch)
            {
                case "1":
                    strSearchForLunch = arrayBentoName[0];
                    price = arrayBentoPrice[0];
                    break;
                case "2":
                    strSearchForLunch = arrayBentoName[1];
                    price = arrayBentoPrice[1];
                    break;
                case "3":
                    strSearchForLunch = arrayBentoName[2];
                    price = arrayBentoPrice[2];
                    break;
                case "4":
                    strSearchForLunch = arrayBentoName[3];
                    price = arrayBentoPrice[3];
                    break;
                case "5":
                    strSearchForLunch = arrayBentoName[4];
                    price = arrayBentoPrice[4];
                    break;
                case "6":
                    strSearchForLunch = arrayBentoName[5];
                    price = arrayBentoPrice[5];
                    break;
                case "7":
                    strSearchForLunch = arrayBentoName[6];
                    price = arrayBentoPrice[6];
                    break;
                case "8":
                    strSearchForLunch = arrayBentoName[7];
                    price = arrayBentoPrice[7];
                    break;
                case "9":
                    strSearchForLunch = arrayBentoName[8];
                    price = arrayBentoPrice[8];
                    break;
                case "10":
                    strSearchForLunch = arrayBentoName[9];
                    price = arrayBentoPrice[9];
                    break;
                case "Q":
                    break;
                default:
                    strSearchForLunch = "無此菜單，請悉知本店菜單，請在重新點餐";
                    price = 0;
                    break;
            }
            Console.WriteLine("\n您所選擇的便當為: " + strSearchForLunch + "，此價格為: " + price);
        }
    }
}
