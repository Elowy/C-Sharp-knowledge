using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Informaciogyüjtes
            Console.WriteLine("Kérlek adj meg egy számot az összeadáshoz!");     //Egyszerű kiírás.
            int szam_egy;                                                        //szam_egy értékhatározó.
            szam_egy = Convert.ToInt32(Console.ReadLine());                      //szam_egy Int32-be való alakítása.
            Console.WriteLine("Kérlek adj meg még egy számot az összeadáshoz!"); //Egyszerű kiírás.
            int szam_ketto;                                                      //szam_ketto értékhatározó.
            szam_ketto = Convert.ToInt32(Console.ReadLine());                    //szam_ketto Int32-be való alakítása.
            System.Threading.Thread.Sleep(1000);                                 //Program üresjárat.
            Console.Clear();                                                     //Console felület tisztítása.
            #endregion

            #region vegeredmeny
            int osszeg = szam_egy + szam_ketto;                                  //Műveletvégrehajtás.
            Console.WriteLine("Végeredmény:{0}", osszeg);                        //A végeredmény kiírása.
            Console.WriteLine("A program leáll 5 másodperc múlva.");
            Console.WriteLine("By: Luisgg");
            System.Threading.Thread.Sleep(5000);                                 //Program üresjárat a felhasználó miatt.
            #endregion
        }
    }
}
