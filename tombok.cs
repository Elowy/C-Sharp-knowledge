using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Létrehozás
            /* Tömb létrehozása... 
             * int [](utalás a tömb létrehozására) new int[10](a tömb nagysága) 
             */
            int[] tombnev = new int[10];
            int[] randomszamok = new int[10];
            #endregion
            #region Sima feltöltés
            //Programon belüli feltöltés...
            /*tombnev[0] = 1;
            tombnev[1] = 2;
            tombnev[2] = 3;
            tombnev[3] = 4;*/
            #endregion
            #region Feltöltés Értékmegadással
            /* For ciklus használata az ilyen értékmegadásokhoz, mivel így a hellyel +
             * programozási idővel is spórolunk.
             * Meghatározott ideig futó ciklus (i < tombnev) addig fut meg az i értéke az előre meghatározott
             * (new int[10]-et) el nem éri!
             */
            for (int i = 0; i < tombnev.Length; i++) 
                //az i kezdőértékének meghatározása, a program lefutásának hossza, lépésköz
            {
                Console.Clear();//Console tisztítás a cikluson belül
                Console.Write("Add meg a tömb {0}. index értékét:",i);//a változó bekérése, i kiírása...
                tombnev[i] = Convert.ToInt32(Console.ReadLine());//tömmbe való lementés
            }
            #endregion
            #region Feltöltés Random Számmal
            Random rnd = new Random();//random függvény meghívása. (gyakorlást igényel!)
            for (int i = 0; i < tombnev.Length; i++)
            {
                randomszamok[i] = rnd.Next(1, 101);//random szamok a tömbbe tétele 1-100-as skálán
            }
            #endregion
            #region Kiíratás
            Console.Clear();//Console tisztítása.
            Console.WriteLine("A feltöltött tömb értékei:");
            for (int i = 0; i < tombnev.Length; i++)
            {
                Console.Write("{0},", tombnev[i]);
            }
            Console.WriteLine("\nA randomizált tömb értékei:");
            for (int i = 0; i < randomszamok.Length; i++)
            {
                Console.Write("{0},", randomszamok[i]);
            }
            #endregion
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
