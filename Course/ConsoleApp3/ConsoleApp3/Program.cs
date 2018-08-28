using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "John";
            string last = "Lee";
            string full;
            full = first + " " +  last;
            Console.WriteLine("");
            Console.WriteLine("名字是 " + full);
            Console.WriteLine("----------------------");

            //算術運算子
            int x = 9;
            int y = 2;
            int z;

            //z = x + y;
            //z = x - y;
            //z = x * y;
            //z = x / y;
            //z = x % y;
            //z = -y;
            //z = x + y * 2;
            z = (x - y) / y;

            Console.WriteLine("z的值為 " +　z);
            Console.WriteLine("----------------------");

            //算術指定運算子
            int d = 100;
            int f = 50;
            //d = d + 100;
            d += 80;
            d -= f;
            d *= 2;
            d /= 5;
            d %= 7;

            Console.WriteLine("d的值: " + d);
            Console.WriteLine("----------------------");

            //遞增遞減運算子
            int r = 8;
            int s = 6;
            //r = r+1;
            r++;
            //s = s-1;
            s--;
            Console.WriteLine("r的值為 " + r + "\n" + "s的值為 " + s);
            Console.WriteLine("----------------------");

            
            Console.ReadKey();
        }
    }
}
