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
            //Üdvözlés
            Console.WriteLine("Ez a program meghatározza egy x és egy y értékről, hogy hol találhatóak, a kordináta rendszerben!\n A folytatás 5 másodperc Múlva!");
            System.Threading.Thread.Sleep(5000);
            //értékgyűjtés
            Console.Write("Add meg az x értéket:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Add meg az y értéket:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            //A változók kiértékelése.
            //Az Origó.
            if (x == 0 && y == 0)
            {
                Console.WriteLine("A pont az origón található");
            }
            //1. Síknegyed. x +, y +
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("A pont az 1. síknegyeden található található");
            }
            //2. Síknegyed. x -, y +
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("A pont a 2. síknegyeden található található");
            }
            //3. Síknegyed. x -, y -
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("A pont a 3. síknegyeden található található");
            }
            //4. Síknegyed. x +, y -
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("A pont a 4. síknegyeden található origón található");
            }
            //x tengely
            else if (y == 0)
            {
                Console.WriteLine("A pont az X tengelyen található");
            }
            //y tengely
            else if (x == 0)
            {
                Console.WriteLine("A pont az Y tengelyen található");
            }
            else
            {
                Console.WriteLine("A pont nem meghatározható!");
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
