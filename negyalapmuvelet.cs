using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a program végrehajtja a 4 alapműveletet!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Add meg az első számot:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Add meg a második számot:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A szamok összeadva:{0}\nKivonva:{1}\nOsztva{2}\nSzorozva:{3}\n", a + b, a - b, a / b, a * b);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Coded by: Levente");
            System.Threading.Thread.Sleep(2000);
        //https://www.youtube.com/watch?v=6hMK31S4cbA&index=65&list=PLGyaaiLprtIDrLyaJccXNgAv2iV4I5jw-
        }
    }
}
