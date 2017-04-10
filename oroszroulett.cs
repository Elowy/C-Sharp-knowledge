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
            Console.Write("Üdvözöllek az orosz roulettben!/n Kérlek várj 2 másodpercet még a program sorsol!\n\n");
            System.Threading.Thread.Sleep(2000);
            Random rnd = new Random();
            //rnd=a számnak a neve, new = új változó. Random = függvény.
            int numb_1 = rnd.Next(1, 101);
            if (numb_1 < 17)
            {
                Console.Write("A golyó eltalált. Próbáld újra!");
            }
            else
            {
                Console.Write("A golyó mást talált el!");
            }
            System.Threading.Thread.Sleep(2000);
        }
    }
}
