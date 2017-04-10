using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Csinálj egy olyan programot, ami bekéri a neved, majd köszön neked!
            #region getname
            Console.WriteLine("Kérlek add meg a neved, majd nyomj entert!");
            string string_egy;
            string_egy = Console.ReadLine();
            #endregion

            #region showname
            Console.Clear();
            Console.WriteLine("Üdvözöllek {0}!", string_egy);
            System.Threading.Thread.Sleep(2000);
            #endregion

        }
    }
}
