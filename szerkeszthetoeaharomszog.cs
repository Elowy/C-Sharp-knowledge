using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program megmondja, hogy szerkeszthető-e a háromszög az oldalak megadásával!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Add meg az 'a' oldal hosszát:");
            double num_1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add meg a 'b' oldal hosszát:");
            double num_2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add meg a 'c' oldal hosszát:");
            double num_3 = Convert.ToDouble(Console.ReadLine());
            if (num_1 + num_2 > num_3 && num_1 + num_3 > num_2 && num_2 + num_3 > num_1)
            {
                Console.WriteLine("A háromszög szerkeszthető!");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető!");
            }
        }
    }
}
