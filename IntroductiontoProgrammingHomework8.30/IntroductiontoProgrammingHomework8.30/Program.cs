using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoProgrammingHomework8._30
{
    class  Program
    {
        static string Using = "using";
        static string getForegroundColorUsing = getForegroundColor(Using);
        static void Main(string[] args)
        {
            
            
            Console.Write(getForegroundColorUsing);
            Console.WriteLine("using System.Collections.Generic;");
            Console.WriteLine("using System.Linq;");
            Console.WriteLine("using System.Text;");
            Console.WriteLine("using System.Threading.Tasks;");
            Console.WriteLine("");
            Console.WriteLine("namespace ConsoleApp1");
            Console.WriteLine("{");
            Console.WriteLine("class Program");
            Console.WriteLine("{");
            Console.WriteLine("static void Main(string[] args)");
            Console.WriteLine("{");
            Console.WriteLine("Console.WriteLine(\"Hello, world!\");");
            Console.WriteLine("Console.ReadLine();");
            Console.WriteLine("}");
            Console.WriteLine("}");
            Console.WriteLine("}");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ReadKey();
        }

        public static string getForegroundColor(String word) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(word);
            Console.ResetColor();

            return word;
        }


    }
}
