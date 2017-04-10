
using System;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, this program will convert your number into a byte or int.");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Type the number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (x < 255)
            {
                byte y = Convert.ToByte(x);
                Console.WriteLine("The Number is successfully converted into a byte. {0}", y);
            }
            else if (x< 32767)
            {
                Int16 c = Convert.ToInt16(x);
                Console.WriteLine("The number is successfully converted into a short. {0}", c);
            }
            else if (x< 2100000000)
            {
                Int32 e = Convert.ToInt32(x);
                Console.WriteLine("Thne number is successfully converted into an int32. {0}", e);
            }
            else
            {
                Int64 r = Convert.ToInt64(x);
                Console.WriteLine("The number is converted into Int64, because other variables can't handle it. {0}", r);
            }
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
