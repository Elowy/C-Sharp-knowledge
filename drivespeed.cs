using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Excersises
{
    class Program
    {
        public static int SpeedLimit;
        public static int CarSpeed;
        static void Main(string[] args)
        {
            var person = new Program();
            Console.Write("Please enter the speed limit:");
            SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Please enter the speed of the car:");
            CarSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (CarSpeed > SpeedLimit)
            {
                person.OverLimit();
            }
            else if (CarSpeed < SpeedLimit)
            {
                SpeedLimit -= CarSpeed;
                Console.WriteLine("The car is under the speed limit by:{0}", SpeedLimit);
                Console.ReadLine();
            }
            else if (CarSpeed == SpeedLimit)
            {
                Console.WriteLine("The car speed equialent to the speed limit.");
                Console.ReadLine();
            }
        }

        public void OverLimit()
        {
            Console.Clear();
            CarSpeed -= SpeedLimit;
            CarSpeed /= 5;
            int blackPoints = CarSpeed;
            if (CarSpeed >= 12)
            {
                Console.WriteLine("Your Driving License has been suspensed.");
                Console.WriteLine("Because you have driven by: " + CarSpeed*5 + " over the speed limit ({0}).", SpeedLimit);
                Console.WriteLine("You have {0} black points in this situation. Over 12 black points your License has been suspensed.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have driven over the speed Limit by: " + CarSpeed*5 + ".\n");
                Console.WriteLine("If you drive over the speed limit by 12 black points your Driving License will be suspended.");
                Console.WriteLine("You have {0} black points in this situation.", blackPoints);
                Console.WriteLine("Every black points you have you have to pay a penality of 4$.");
                Console.WriteLine("You have a penalty: {0} $.", blackPoints*4);
                Console.ReadLine();
            }
        }
    }
}
