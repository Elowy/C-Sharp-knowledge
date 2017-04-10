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
            Console.Write("Ez a program egy általad megadott számtani sorozatot irat ki,\n ha megadod az elemeinek az értékét!\n");
            Console.Write("A folytatás 5 másodperc múlva...\n");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            //változók bekérése.
            Console.Write("Add meg a sorozat első tagját:");
            int numb_1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Add meg a differencia értéket:");
            int diff = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Add meg a sorozat hosszát értéket:");
            int hossz = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //számtani sorozat kiiratása.
            Console.WriteLine("A számtani sorozat a következő:");
            for (int i = 1; i <= hossz; i++)
            {
                Console.Write("{0},", numb_1);
                numb_1 = numb_1 + diff;
            }
            //mértani sorozat kiiratása.
            Console.WriteLine("\nA mértani sorozat a következő:");
            for (int i = 1; i <= hossz; i++)
            {
                Console.Write("{0},", numb_1);
                numb_1 = numb_1 * diff;
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
