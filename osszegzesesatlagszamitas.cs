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
            #region Program Leírása
            Console.WriteLine("Ez a program számoknak az összegzését végzi el, valamint az átlagát számolja ki.\nA folytatáshoz nyomj Entert!");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region A Tömb Létrehozása
            int[] tomb_1 = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < tomb_1.Length; i++)
            {
                tomb_1[i] = rnd.Next(1, 101);
            }
            #endregion

            #region Összegzés Tétele
            int osszeg = 0;
            for (int i = 0; i < tomb_1.Length; i++)
            {
                osszeg = osszeg + tomb_1[i];
            }
            Console.WriteLine("A random számok összege:{0}", osszeg);
            #endregion

            #region Átlagszámítás Tétele
            int atlag = 0;
            for (int i = 0; i < tomb_1.Length; i++)
            {
                atlag = osszeg / tomb_1.Length;
            }
            Console.WriteLine("A random számok átlaga:{0}", atlag);
            #endregion

            Console.ReadLine();
        }
    }
}