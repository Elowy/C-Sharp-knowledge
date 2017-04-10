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
            #region A program ismertetése
            Console.WriteLine("Ez a program egy általad megadott szám prím tényezős alakját állítja elő!\nFolytatás 5 másodperc múlva!");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            #endregion
            #region Változók bekérése
            Console.Write("Add meg vizsgálni kívánt számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            #endregion
            #region Felbontás elvégzése, kiíratás
            int i = 2;
            while (i <= szam)
            {
                if (szam % i == 0)
                {
                    szam = szam / i;
                    Console.Write("{0}*", i);
                }
                else
                {
                    i++;
                }
            }
            #endregion
            System.Threading.Thread.Sleep(5000);
        }
    }
}
