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
            Console.WriteLine("Ez a program kiszámítja egy négyzet területét és kerületét!");
            Console.Clear();
            Console.Write("Kérlek add meg a számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("A négyzet kerülete:{0}\nA négyzet területe:{1}", szam * 4, szam * szam);
            System.Threading.Thread.Sleep(2000);
        }
    }
}
