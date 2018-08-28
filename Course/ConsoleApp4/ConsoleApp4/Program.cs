using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 8;

            //一個條件
            if (x > y)
            {
                //看的到 x , y
                int a = 1;
                int b = 2;
                Console.WriteLine("X:" + x +"大於" + "Y:" + y);
            }
            //看不到 a, b
            
            //兩個條件
            if (x > y)
            {
                Console.WriteLine("X大於Y");
            }
            else
            {
                Console.WriteLine("X小於等於Y");
            }

            //多重條件1
            if (x == y)
            {
                Console.WriteLine("X等於Y");
            } else if (x > y)
            {
                Console.WriteLine("X大於Y");
            } else if (x < y)
            {
                Console.WriteLine("X小於Y");
            } else
            {
                Console.WriteLine("沒符合條件");
            }

            //多重條件2
            if (x > y)
            {
                Console.WriteLine("X大於Y");
            } else
            {
                if (x == y)
                {
                    Console.WriteLine("X等於Y");
                } else
                {
                    Console.WriteLine("X小於Y");
                }
            }

            //簡寫法
            int w = 6;
            int s;
            /*
            if (w < 0)
            {
                s = -1;
            }
            else
            {
                s = w * 2;
            }
            */
            s = (w < 0) ? -1 : w * 2;

            Console.WriteLine("s : " + s);

            //關係運算式
            double m = 85.32;
            double n = 45.64;
            bool compare = false;

            //compare = (m < n) && (m >= 50.0);
            //compare = (m > 60.0) && (m != n);
            //compare = (m <= 80.0) || (m >= n);
            //compare = (n > m) || (n < 20.0);
            //compare = ((m > 50.0) && (n < 100.0)) && (m == n);
            //compare = ((m < 10.0) || (n >= 60.0)) || (m <= n);
            compare = !(m > n);

            Console.WriteLine("compare:" + compare);

            for (int i = 0; i < 1000; i += 1) {
                Console.WriteLine("請輸入你要訂的便當");
                Console.WriteLine("1.排骨 2.雞腿 3.燒肉 4.咖哩 12.丼飯 q.結束");
                string sw = Console.ReadLine();

                if (sw != "q")
                {
                    Console.WriteLine("您訂的便當是:");

                    switch (sw)
                    {
                        case "1":
                            Console.WriteLine("排骨飯");
                            break;
                        case "2":
                            Console.WriteLine("雞腿飯");
                            break;
                        case "3":
                            Console.WriteLine("燒肉飯");
                            break;
                        case "4":
                            Console.WriteLine("咖哩飯");
                            break;
                        case "12":
                            Console.WriteLine("丼飯");
                            break;
                        case "q":
                            break;
                        default:
                            Console.WriteLine("抱歉沒有");
                            break;
                    }

                } else {

                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
