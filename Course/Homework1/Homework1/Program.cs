using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //顯示using System;
            Console.ForegroundColor = ConsoleColor.Blue;//顯示using的字型顏色為藍色
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System;");

            //顯示using System.Collections.Generic;
            Console.ForegroundColor = ConsoleColor.Blue;//顯示using的字型顏色為藍色
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System.Collections.Generic;");

            //顯示using System.Linq;
            Console.ForegroundColor = ConsoleColor.Blue;//顯示using的字型顏色為藍色
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System.Linq;");

            //顯示using System.Text;
            Console.ForegroundColor = ConsoleColor.Blue;//顯示using的字型顏色為藍色
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System.Text;");

            //顯示using System.Threading.Tasks;
            Console.ForegroundColor = ConsoleColor.Blue;//顯示using的字型顏色為藍色
            Console.Write("using ");
            Console.ResetColor();
            Console.WriteLine("System.Threading.Tasks;");

            //顯示namespace ConsoleApp1
            Console.ForegroundColor = ConsoleColor.Blue;//顯示namespace的字型顏色為藍色
            Console.Write("\nnamespace ");
            Console.ResetColor();
            Console.WriteLine("ConsoleApp1");

            //顯示{
            Console.WriteLine("{");

            //顯示class Program
            Console.ForegroundColor = ConsoleColor.Blue;//顯示class的字型顏色為藍色
            Console.Write("\tclass ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Program");
            Console.ResetColor();

            //顯示{
            Console.WriteLine("\t{");

            //顯示static void Main(string[] args)
            Console.ForegroundColor = ConsoleColor.Blue;//顯示static void的字型顏色為藍色
            Console.Write("\t\tstatic void ");
            Console.ResetColor();
            Console.Write("Main(");
            Console.ForegroundColor = ConsoleColor.Blue;//顯示string的字型顏色為藍色
            Console.Write("string");
            Console.ResetColor();
            Console.WriteLine("[] args)");

            //顯示{
            Console.WriteLine("\t\t{");

            //顯示Console.WriteLine("Hello, world!");
            Console.ForegroundColor = ConsoleColor.Green;//顯示Console的字型顏色為綠色
            Console.Write("\t\t\tConsole");
            Console.ResetColor();
            Console.Write(".WriteLine(");
            Console.ForegroundColor = ConsoleColor.Red;//顯示"Hello, world!"的字型顏色為紅色
            Console.Write("\"Hello, world!\"");
            Console.ResetColor();
            Console.WriteLine(");");

            //顯示Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;//顯示Console的字型顏色為綠色
            Console.Write("\t\t\tConsole");
            Console.ResetColor();
            Console.WriteLine(".ReadLine();");

            //顯示{
            Console.WriteLine("\t\t}");

            //顯示{
            Console.WriteLine("\t}");

            //顯示{
            Console.WriteLine("}");

            Console.ReadKey();
        }
    }
}
