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
            Console.Write("Ez a program kiíratja a fibonacci sorozatot, a megadott elemig!\nFolytatás 5 másodperc múlva!");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.Write("Add meg hány elemet mutassak a sorozatból:");
            int darab = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int a = 0;
            int b = 1;
            Console.Write("A fibonacci sorozat első {0} eleme a következő:",darab);
            for (int i = 0; i < darab; i++)
            {
                Console.Write("{0},", a);
                int csere = a;
                a = b;
                b = csere + b;
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
