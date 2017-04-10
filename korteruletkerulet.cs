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
            Console.WriteLine("Ez a program kiszámítja egy kör területét és kerületét!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Add meg a kör sugarát:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A kör Területe:{0}\nAKör Kerülete:{1}", Math.PI *2* r,Math.PI*r*r );
            System.Threading.Thread.Sleep(2000);
        }
    }
}
