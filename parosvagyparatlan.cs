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
            Console.WriteLine("Adj meg egy számot és megmondom, hogy páros-e vagy páratlan!");
            double numb = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            if (numb % 2 == 0)
            {
                Console.WriteLine("A {0} egy páros szám!",numb);
            }
            else 
            {
                Console.WriteLine("A {0} egy páratlan szám!", numb);
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
