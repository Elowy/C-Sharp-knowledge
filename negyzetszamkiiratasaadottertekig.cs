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
            Console.Write("Ez a program kiírja az összes négyzetszámot egy adott értékig.\nA folytatás 5 másodperc múlva.");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            #endregion
            #region Változók Bekérése
            Console.Write("Add meg, hogy a program meddig írja ki a négyzetszámokat:");
            int hatar = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int i = 1;
            #endregion
            #region Főprogram
            while (i*i<hatar)
            {
                Console.WriteLine(i*i);
                i++;
            }
            #endregion
            Console.ReadLine();
        }
    }
}
