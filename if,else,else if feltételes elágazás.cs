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
            Console.Write("Adj meg egy számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            //Egyirányú feltételes elágazás:
            
             if (szam == 3)
             {
                Console.WriteLine("A program megfelelt a feltételeknek!");
             }
            
            //Kétirányú feltételes elágazás:
             if (szam == 3)
             {
                 Console.WriteLine("A program megfelelt a feltételeknek.");
             }
             else
             {
                 Console.WriteLine("A program nem felelt meg a feltételeknek!")
             }
            
            //Többirányú feltételes elágazás:
            if (szam == 3)
            {
                Console.WriteLine("A program megfelelt a feltételeknek.");
            }
            else if(szam == 4)
            {
                Console.WriteLine("A program nem felelt meg a feltételeknek!")
            }
            Console.ReadLine();
        }
    }
}
