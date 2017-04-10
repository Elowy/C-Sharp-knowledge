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
            Console.WriteLine("Ez a program meghatározza, hogy a megadott szám prím-e!");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Console.Write("Add meg a számot:");
            int oszto = 0;
            int numb_1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= numb_1; i++)
            {
                if (numb_1 % i == 0)
                {
                    //Console.Write("A(z) {0} oszója a(z) {1}-nak(nek).\n", i, numb_1);
                    oszto++;
                    //Console.Write("A szám eddigi osztói:{0}.\n", oszto);
                    //System.Threading.Thread.Sleep(1500);
                }
                else
                {
                    //Console.Write("A(z) {0} NEM osztója a(z) {1}-nak(nek).\n", i, numb_1);
                    //System.Threading.Thread.Sleep(500);
                }
            }
            if (oszto == 2)
            {
                Console.WriteLine("A {0} szám prím!", numb_1);
            }
            else
            {
                Console.WriteLine("A {0} szám nem prím!", numb_1);
            }
            System.Threading.Thread.Sleep(4000);
        }   
    }
}
