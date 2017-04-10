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
            Console.Write("A program egy random számot generál az általad megadott intervallumban!\nA Folytatás 2 másodperc múlva!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Add meg az első számot:");
            int numb_1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Az első megadott szám:{0}\n\nAdd meg a második számot:", numb_1);
            int numb_2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int numb_4;
            Random numb_3 = new Random();
            if (numb_1 < numb_2)
            {
                numb_4 = numb_3.Next(numb_1, numb_2+1);
            }
            else
            {
                numb_4 = numb_3.Next(numb_2, numb_1+1);
            }
            Console.Write("A megadott intervallumban: {0},{1}.\nA legenerált szám:{2}", numb_1, numb_2, numb_4);
            System.Threading.Thread.Sleep(5000);
        }
    }
}
