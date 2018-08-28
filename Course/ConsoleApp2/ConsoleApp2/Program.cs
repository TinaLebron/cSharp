using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //字串的宣告
            string name;
            name = "王大衛";
            string 電話 = "0912-345-678";//=是指定，把等號右邊的值指定給左邊
            //字元
            char char1 = 'x';
            char char2 = '微';
            //整數正負號
            short a = 28;
            int amount = -25000;
            long count = 345678901122;
            //不含正負號整數
            ushort age = 28;
            uint price = 30000;
            ulong total = 300000000;
            //浮點數
            float average = 98.37f;
            double pi = 3.14159265358;
            //布林boolean
            bool isSucces = true;
            bool isFinish = false;


            Console.WriteLine("姓名: " + name + "," + "電話: " + 電話);
            Console.WriteLine("字元: " + char1);
            Console.WriteLine("年齡: " + age);
            Console.WriteLine("數量: " + amount);
            Console.WriteLine("平均: " + average);
            Console.WriteLine("pi: " + pi);
            Console.WriteLine("是否成功: " + isSucces);
            Console.ReadLine();
            



        }
    }
}
