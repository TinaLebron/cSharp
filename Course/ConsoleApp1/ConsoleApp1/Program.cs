using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World !!");
            Console.ResetColor();
            Console.WriteLine("這是第一個主控台應用程式");
            Console.WriteLine("使用 C# 語言來開發");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1.主控台\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2.視窗應用程式\n");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("3.Wed網頁程式\n");
            Console.ResetColor();
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\"雙引號\"");
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("\r\n換行");
            Console.WriteLine("\t縮排");

            //單行註解
            /*
             多行註解，
             寫筆記，
             寫心得，
             提示自己，
             重點
             */
            Console.ReadKey();//等待接收鍵盤的命令


        }
    }
}
