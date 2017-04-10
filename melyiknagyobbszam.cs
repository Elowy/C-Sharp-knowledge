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
            Console.Write("Please enter the first number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            if (number > number1)
            {
                Console.WriteLine("The First number {0} is higher than the Second.", number);
                Console.Read();
            }
            else if (number == number1)
            {
                Console.WriteLine("The two number are equialent to eatch other.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("The Second number {0} is higher than the first.", number1);
                Console.Read();
            }
        }
    }
}
