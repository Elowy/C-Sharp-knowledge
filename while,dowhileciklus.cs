using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A While ciklus elemei:");
            int i = 0;
            while (i < 10) // elöltesztelős ciklus (addig fut, amíg az i < 10)
            {
                Console.WriteLine("Hello World! {0}", i);
                i++; // lépésköz!
            }
            Console.ReadLine();
            int i_1 = 0;
            Console.WriteLine("A Do-While ciklus elemei:");
            do // hátultesztelős ciklus (addig fut, amíg az i < 10) de a végén kell megadni!
            {
                Console.WriteLine("Hello World! {0}", i_1);
                i_1++; // lépésköz
            }
            while (i_1 < 10);
            Console.ReadLine();
        }
    }
}
