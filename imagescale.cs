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
            Console.Beep();
            Console.Write("Please add the height of the image:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please add the width of the image:");
            int width = Convert.ToInt32(Console.ReadLine());
            if (height == width)
            {
                Console.WriteLine("This Image is a portrait.");
                Console.ReadLine();
            }
            else if (height > width)
            {
                Console.WriteLine("This image is a portrait.");
                Console.ReadLine();
            }
            else if (height < width)
            {
                Console.WriteLine("This is a landscape!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I dunno wut...");
            }
            Console.BackgroundColor == ConsoleColor.Green;
        }
    }
}
