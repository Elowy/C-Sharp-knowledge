using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ez a program a legnagyobb közös osztót határozza meg.\nFolytatás 5 másodperc múlva!");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.Write("Add meg az első számot:");
            int numb_1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Add meg a második számot:");
            int numb_2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int kissebb;
            if (numb_1 < numb_2)
            {
                kissebb = numb_1;
            }
            else
            {
                kissebb = numb_2;
            }
            int lnko=0;
            for (int i = 1; i <= kissebb; i++)
            {
                if (numb_1 % i == 0 && numb_2 % i == 0)
                {
                    lnko = i;
                    Console.WriteLine("A két szám közös osztója: {0}.", lnko);
                    System.Threading.Thread.Sleep(500);
                }
                else
                { }
            }
            Console.WriteLine("A két szám {0},{1} legnagyobb közös osztója: {2}.", numb_1, numb_2, lnko);
            System.Threading.Thread.Sleep(5000);
        }   
    }
}