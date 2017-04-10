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
            Console.WriteLine("Ez a program egy random számokkal feltöltött tömbben keresi meg a minimum és maximum értéket!\nA folytatás 3 másodperc múlva.");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            #endregion

            #region Tömbök feltöltése Random számokkal
            int[] tomb_1 = new int[25];
            Random rnd = new Random();
            for (int i = 0; i < tomb_1.Length; i++)
            {
                tomb_1[i] = rnd.Next(1, 101);
            }
            #endregion

            #region A Tömbök kiíratása
            Console.WriteLine("A tömb elemei:");
            for (int i = 0; i < tomb_1.Length; i++)
            {
                Console.Write("{0},",tomb_1[i]);
            }
            #endregion

            #region A minimum érték megkeresése
            int min = tomb_1[0];
            for (int i = 0; i < tomb_1.Length; i++)
            {
                if (tomb_1[i] < min)
                {
                    min = tomb_1[i];
                }
                else
                { }
            }
            Console.WriteLine("\nA minimum érték:{0}",min);
            #endregion

            #region A maximum érték keresése
            int max = tomb_1[0];
            for (int i = 0; i < tomb_1.Length; i++)
            {
                if (tomb_1[i] > max)
                {
                    max = tomb_1[i];
                }
                else
                { }
            }
            Console.WriteLine("A maximum érték:{0}",max);
            #endregion
            Console.ReadLine();
        }
    }
}