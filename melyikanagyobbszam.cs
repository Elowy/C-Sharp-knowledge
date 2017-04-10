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
            Console.WriteLine("Adj meg két számot és eldöntöm, hogy melyik kissebb!");
            Console.WriteLine("Add meg az első számot:");
            double numb_1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add meg a második számot:");
            double numb_2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (numb_1 > numb_2)
            {
                Console.WriteLine("A {0} kissebb mint {1}.", numb_2, numb_1);
            }
            else
            {
                Console.WriteLine("A {0} nagyobb mint {1}.", numb_2, numb_1);
            }
            System.Threading.Thread.Sleep(2000);
        }
    }
}
