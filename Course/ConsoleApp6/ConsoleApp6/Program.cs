using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //一維陣列
            int[] arrayOne = new int[6];
            arrayOne[0] = 2;
            arrayOne[1] = 4;
            arrayOne[2] = 5;
            arrayOne[3] = 10;
            arrayOne[4] = 12;
            arrayOne[5] = 21;

            Console.WriteLine("取得第三個元素: " + arrayOne[2]);

            for (int i = 0; i < 6; i += 1) {
                Console.WriteLine(arrayOne[i]);
            }

            Console.WriteLine("---------------------");

            int[] arrayTwo = new int[] { 5,6,7,8,9 };
            //Console.WriteLine(arrayTwo[5]);//error,超出索引值

            int[] arrayThree = { 10, 11, 12, 13, 14, 15 };
            char[] arrayChar = new char[] { 'a','b','c','d','e' };
            string[] arrayString = new string[] { "國文", "英文", "數學", "物理", "化學" };

            foreach (string strSub in arrayString) {
                Console.WriteLine(strSub);
            }

            Console.WriteLine("---------------------");

            string strSearchSubject = "";
            bool ifSearchSuccess = false;
            Console.WriteLine("請輸入搜尋科目: ");
            strSearchSubject = Console.ReadLine();
            Console.WriteLine("您輸入了: " + strSearchSubject);

            for (int k = 0; k < arrayString.Length;k += 1) {
                if (arrayString[k] == strSearchSubject)
                {
                    Console.WriteLine("科目搜尋到了,index: " + k);
                    ifSearchSuccess = true;
                    break;
                }
                else {
                    ifSearchSuccess = false;
                }
            }
            if (ifSearchSuccess == false) {
                Console.WriteLine("無此科目");
            }

            Console.WriteLine("---------------------");

            //二維陣列
            int[,] array2Dim = new int[4, 2] {
                {1,2 },
                {3,4 },
                {5,6 },
                {7,8 },
            };
            Console.WriteLine(array2Dim[0,0]);
            Console.WriteLine(array2Dim[2,1]);
            Console.WriteLine(array2Dim[3,0]);

            Console.WriteLine("---------------------");

            for (int i = 0; i < 4;i += 1) {
                for (int j = 0; j < 2; j += 1) {
                    Console.WriteLine(array2Dim[i,j]);
                }
            }

            Console.WriteLine("---------------------");

            //三維陣列
            int[,,] array3Dim = new int[2, 2, 3] {
                {
                    {1,2,3 },
                    {4,5,6 }
                },
                {
                    {7,8,9 },
                    { 10,11,12}
                },
            };
            Console.WriteLine(array3Dim[0, 1, 1]);
            Console.WriteLine(array3Dim[1, 0, 2]);
            

            Console.ReadKey();
        }
    }
}
