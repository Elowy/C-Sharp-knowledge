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
            Console.WriteLine("A program megnézi három megadott számról, hogy azok számtani sorozatot alkotnak-e.\nA folytatás 5 másodperc múlva.");
            System.Threading.Thread.Sleep(5000);
            //Számok bekérése
            Console.Clear();
            Console.Write("Add meg az első számot:");
            double num_1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Add meg a második számot:");
            double num_2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Add meg a harmadik számot:");
            double num_3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            //Kiértékelés...
            double diff1 = num_1 - num_2;
            double diff2 = num_2 - num_3;
            if (diff1 == diff2)
            {
                Console.WriteLine("A megadott számok: {0},{1},{2} számtani sorozatot alkotnak!", num_1, num_2, num_3);
            }
            else
            {
                Console.WriteLine("A megadott számok: {0},{1},{2} nem alkotnak számtani sorozatot!", num_1, num_2, num_3);
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
