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
            Console.WriteLine("Ez a program kiszámítja egy téglalap területét és kerületét!");
			System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Kérlek add meg az 'a' oldal értékét:");
            int szam_0 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Kérlek add meg az 'b' oldal értékét:");
            int szam_1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int er_0 = szam_0 * szam_1;
            int er_1 = 2 * (szam_0 + szam_1);
            Console.Write("A téglalap kerülete:{0}\nA téglalap területe:{1}", er_0, er_1);
            System.Threading.Thread.Sleep(2000);
        }
    }
}
