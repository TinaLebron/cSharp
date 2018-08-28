using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //for 迴圈
            for (int i = 1; i <= 10; i += 1) {
                Console.WriteLine("i的值:" + i);
            }
            Console.WriteLine("--------------------------");

            for (int i = 10; i >= 1; i -= 2){
                Console.WriteLine("i的值:" + i);
            }
            Console.WriteLine("--------------------------");

            for (int i = 1; i <= 10; i += 1){
                if (i % 2 == 0) {
                    continue;//跳過這次的迴圈
                    //break;//中斷迴圈
                }
                Console.WriteLine("i的值:" + i);
            }
            Console.WriteLine("--------------------------");

            for (int i = 1; i <= 9; i += 1) {
                for (int j = 1; j <= 9; j += 1) {
                    Console.WriteLine(i + "x" + j + "=" + i*j);
                }
            }

            Console.WriteLine("--------------------------");

            for (int i = 1; i <= 10;i += 1) {
                for (int j = 1;j <= i;j += 1) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------");

            int d = 1;

            while (d <= 10) {
                Console.WriteLine("d的值為" + d);
                if (d == 5) {
                    break;
                }
                d += 1;
            }

            Console.WriteLine("--------------------------");

            int e = 1;

            do {
                Console.WriteLine("e的值為" + e);
                e += 2;
            } while (e <= 27);

            Console.ReadKey();
            
        }
    }
}
