using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Értékadó operátor: =
            int num_1 = 10;
            int num_2;
            num_2 = 5;
            int num_3 = Convert.ToInt32(Console.ReadLine());
            //Matematikai operátorok: + - * / %
            int osszeg = num_1 + num_2;
            int kulonbseg = num_1 - num_3;
            int szorzat = num_1 * num_3;
            int hanyados = num_1 / num_2;
            int maradékos = num_3 % num_2;
            //Relációs Operátorok: < > <= >= == !=
            int (num_1 < num_2)
            {
                //a program csak akkor fut le ha num_1 kissebb mint num_2
            }
            int (num_1 > num_2)
            {
                //a program csak akkor fut le ha num_1 nagyobb mint num_2
            }
            int (num_1 <= num_2)
            {
                //a program csak akkor fut le ha num_1 kissebb vagy egyenlő mint num_2
            }
            int (num_1 >= num_2)
            {
                //a program csak akkor fut le ha num_1 nagyobb vagy egyenlő mint num_2
            }
            int (num_1 == num_2)
            {
                //a program csak akkor fut le ha num_1 egyenlő num_2 -vel
            }
            int (num_1 != num_2)
            {
                //a program csak akkor fut le ha num_1 nem egyenlő num_2-vel
            }
            //Logikai Operátorok: ||(vagy) &&(és) !()
            if (num_1 == 10 || num_2 == 5)
            {
                //utasítás. ha az egyik nem igaz akkor is lefut, ha mindkettő hamis akkor nem!
            }
            if (num_1 == 10 && num_2 == 5)
            {
                //utasítás. ha valamelyik állítás hamis akkor nem fut le, csak akkor ha mind kettő igaz!
            }
            if (!(num_1 == 10))
            {
                //utasítás. tagadás, csak akkor fut le ha num_1 nem = 10-el
            }

            //Rövidítő Operátorok: ++ -- += -= *= /=

            // +=   használat: x+=2     jelentés: x=x+2
            // -=   használat: x-=2     jelentés: x=x-2
            // *=   használat: x*=2     jelentés: x=x*2
            // /=   használat: x/=2     jelentés: x=x/2
            // %=   használat: x%=2     jelentés: x=x%2
            // ++   használat: i++      jelentés: i=i+1
            // --   használat: i--      jelentés: i=i-1
        }
    }
}
