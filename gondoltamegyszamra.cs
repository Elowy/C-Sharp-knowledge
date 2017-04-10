using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Négyzetszámkiíratásaadottértékig
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AProgramIsmertetése
            Console.Write("Gondoltam egy számra 1-től 100-ig, ki szeretnéd találni?\nFolytatás 2 másodperc múlva!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            #endregion
            #region Változók Bekérése
            Random rnd = new Random();
            int gondoltszam = rnd.Next(1, 101);
            bool kitalalta = false;
            int tipp_szam = 0;
            #endregion
            #region Főprogram
            Console.Clear();
            while (kitalalta == false)
            {
                Console.Clear();
                Console.Write("Írd be szerinted mi lehet a szám:");
                int tipp = Convert.ToInt32(Console.ReadLine());
                if (tipp < gondoltszam)
                {
                    tipp_szam++;
                    Console.WriteLine("A szám amire gondoltam nagyobb!");
                    System.Threading.Thread.Sleep(2000);
                }
                else if (tipp > gondoltszam)
                {
                    tipp_szam++;
                    Console.WriteLine("A szám amire gondoltam kissebb");
                    System.Threading.Thread.Sleep(2000);
                }
                else if (tipp == gondoltszam)
                {
                    tipp_szam++;
                    Console.WriteLine("Gratulálok kitaláltad a számot! A {0} tippre.", tipp_szam);
                    System.Threading.Thread.Sleep(2000);
                    kitalalta = true;
                }
                else
                {
                    Console.WriteLine("Mondtam, hogy csak 1 és 100 között!");
                    System.Threading.Thread.Sleep(2000);
                }
            }
            #endregion
            Console.WriteLine("A játéknak vége :(");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
