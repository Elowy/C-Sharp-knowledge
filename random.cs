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
            //Előre megadott értékek
            //Felhasználó által megadott értékek
            //Random értékek (számítóhép által)
            Random rnd = new Random();
            //rnd=a számnak a neve, new= új változó. Random = függvény.
            int numb_1 = rnd.Next(1,100);
            //1 és 99 közötti számokat hoz létre. (Alulról zárt felülről nyitott)
            Random rnd_1 = new Random();
            double numb_2 = rnd.Next(1, 100) / 3.0;
            //tört szám létrehozása.
            double numb_3 = rnd.NextDouble();
            //0 és 1 közötti valós szám létrehozása.
        }
    }
}
