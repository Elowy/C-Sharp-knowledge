using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
            int number = Convert.ToByte(Console.ReadLine());

            if (number <= 10)
            {
                Console.Clear();
                Console.WriteLine("You have entered a vaild number.");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have entered an invaild number.");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
