using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzes_es_atlagszamitas_tetele
{
    class Program
    {
        static void Main(string[] args)
        {
            #region A program bemutatása
            Console.WriteLine("Ez a program egy kockadobáló szimuláció, amiben általad választottszor dobunk el egy átlagos dobókockát, majd megnézzük,hogy melyik a leggyakoribb dobott szam!");
            Console.WriteLine("A folytatás 5 másodperc múlva!");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            #endregion
            #region A dobálás szimuláció
            Console.Write("Mond meg, hogy hányszor dobjam el a kockát:");
            int dobasszam = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Most eldobom a kockát {0}x majd kiírom az értékeket!",dobasszam);
            int[] dobasok = new int[dobasszam];
            Random rnd = new Random();
            for (int i = 0; i < dobasok.Length; i++)
            {
                dobasok[i] = rnd.Next(1, 7);
                Console.Write("{0},", dobasok[i]);
            }
            #endregion
            #region Elemzés
            int egyesek_szama = 0;
            int kettesek_szama = 0;
            int harmasok_szama = 0;
            int negyesek_szama = 0;
            int otosok_szama = 0;
            int hatosok_szama = 0;
            for (int i = 0; i < dobasok.Length; i++)
            {
                if (dobasok[i] == 1)
                {
                    egyesek_szama++;
                }
                else if (dobasok[i] == 2)
                {
                    kettesek_szama++;
                }
                else if (dobasok[i] == 3)
                {
                    harmasok_szama++;
                }
                else if (dobasok[i] == 4)
                {
                    negyesek_szama++;
                }
                else if (dobasok[i] == 5)
                {
                    otosok_szama++;
                }
                else  
                {
                    hatosok_szama++;
                }

            }
            #endregion
            #region Statisztika kiírása
            Console.WriteLine("\nA statisztika:");
            Console.WriteLine("Egyesek szama: {0},\nKettesek szama: {1},\nHarmasok szama: {2},\nNegyesek szama: {3},\nÖtösök száma: {4},\nHatosok száma: {5}.", egyesek_szama, kettesek_szama, harmasok_szama, negyesek_szama, otosok_szama, hatosok_szama);
            Console.ReadLine();
            #endregion
        }
    }
}