using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17.Scripts
{
    public class Store
    {
        private byte _exitorBuy;
        public static int MultiplerMoneyWorth = 100;

        public void Store_Main()
        {
            var person1 = new Slotter();
            Console.WriteLine("Üdvözöllek a boltban!\n");
            Console.WriteLine("Megtudod vásárolni a {0}$ értékű szorzót.\n A jelenlegi szorzód:{1} \n\n Nyomj '1'-est, hogy megvásárold.\nNyomj '2'-est, hogy kilépj.", MultiplerMoneyWorth, Slotter.Multiplier);
            _exitorBuy = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            if (_exitorBuy == 1 && Slotter.Money > MultiplerMoneyWorth)
            {
                Slotter.Multiplier++;
                Slotter.Money -= MultiplerMoneyWorth;
                MultiplerMoneyWorth += 200;
                person1.Play();
            }
            else
            {
                person1.Play();
            }


        }
    }

    public class Slotter
    {
        public static byte Multiplier;
        public static int Money;
        public string Name;
        public int FirstNumber;
        public int SecondNumber;
        public int ThirdNumber;
        public int FourthNumber;
        public byte SmallWin = 2;
        public byte MediumWin = 4;
        public byte HighWin = 8;
        public byte BigWin = 15;
        public string VersionNumber = "0.0.3";
        public string VersionText = "Win Nerf + RoundsPassed";
        public static int RoundsPassed;

        public void Game_Start()
        {
            Console.Clear();
            Console.WriteLine("Nyomj Entert a játékhoz.");
            Console.WriteLine("Nyerő pörgetések esetén pénzt kapsz." + Name + ".\n\n1 pörgetés 1$\n\nA kezdő pénzed: " + Money + "$.");
            Console.ReadKey();
            Console.Clear();
            var person1  = new Slotter();
            Slotter.Money += 20;
            Slotter.Multiplier += 1;
            person1.Play();
        }
        public void Play()
        {
            var person1 = new Slotter();
            var person2 = new Store();
            Console.Clear();
            Console.WriteLine("Pénz: {0}$\n", Slotter.Money);
            Console.WriteLine("Nyomj entert a pörgetéshez. {0}$/pörgetés", Multiplier);
            System.Threading.Thread.Sleep(1000);
            RoundsPassed++;
            //Console.ReadKey();
            Console.Clear();
            if (Slotter.Money <= 0)
            {
                person1.GameOver();
            }
            else if (Store.MultiplerMoneyWorth < Slotter.Money)
            {
                person2.Store_Main();
            }
            else if (Slotter.Multiplier > 10)
            {
                person1.Win_Screen();
            }
            else
            {
                person1.Convert();
            }
        }

        public void Convert()
        {
            
            Random rnd = new Random();
            FirstNumber = rnd.Next(1, 5);
            SecondNumber = rnd.Next(1, 5);
            ThirdNumber = rnd.Next(1, 5);
            FourthNumber = rnd.Next(1, 5);
            var person1 = new Slotter();
            Slotter.Money -= Slotter.Multiplier;
            Console.WriteLine("Pénz: {0}$", Slotter.Money);
            Console.WriteLine("\nA nyerő számok:\n\n... {0} ... {1} ... {2} ... {3} ...\n", FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
            Console.WriteLine("\nVerzió {0} ({1})", VersionNumber, VersionText);
            Console.WriteLine("\nEddig eltelt körök: {0}.", RoundsPassed);
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            if (FirstNumber == SecondNumber && FirstNumber == ThirdNumber && FirstNumber == FourthNumber)
            { //Ha 1-1-1-1, 2-2-2-2, 3-3-3-3, 4-4-4-4
                Slotter.Money += (HighWin*Multiplier);
                Console.WriteLine("{0}$ Nyeremény.\n\n Ezek voltak a nyerő számok: {1},{2},{3},{4}", HighWin* Slotter.Multiplier, FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
                Console.WriteLine("\nPénz: {0}$", Slotter.Money);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                person1.Play();
            }
            else if (FirstNumber == SecondNumber && FirstNumber == ThirdNumber)
            {//Ha 1-1-1-x, 2-2-2-x, 3-3-3-x, 4-4-4-x
                Slotter.Money += (MediumWin* Multiplier);
                Console.WriteLine("{0}$ Nyeremény.\n\n Ezek voltak a nyerő számok: {1},{2},{3},{4}", MediumWin* Slotter.Multiplier, FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
                Console.WriteLine("\nPénz: {0}$", Slotter.Money);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                person1.Play();
            }
            else if (SecondNumber == ThirdNumber && SecondNumber == FourthNumber)
            {//Ha x-1-1-1, x-2-2-2, x-3-3-3, x-4-4-4
                Slotter.Money += (MediumWin* Multiplier);
                Console.WriteLine("{0}$ Nyeremény.\n\n Ezek voltak a nyerő számok: {1},{2},{3},{4}", MediumWin* Slotter.Multiplier, FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
                Console.WriteLine("\nPénz: {0}$", Slotter.Money);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                person1.Play();
            }
            else if (FirstNumber == SecondNumber)
            {//Ha 1-1-x-x, 2-2-x-x, 3-3-x-x, 4-4-x-x
                Slotter.Money += (SmallWin*Multiplier);
                Console.WriteLine("{0}$ Nyeremény.\n\n Ezek voltak a nyerő számok: {1},{2},{3},{4}", SmallWin * Slotter.Multiplier, FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
                Console.WriteLine("\nnPénz: {0}$", Slotter.Money);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                person1.Play();
            }
            else if (SecondNumber == ThirdNumber)
            {//Ha x-1-1-x, x-2-2-x, x-3-3-x, x-4-4-x
                Slotter.Money += (SmallWin * Multiplier);
                Console.WriteLine("{0}$ Nyeremény.\n\n Ezek voltak a nyerő számok: {1},{2},{3},{4}", SmallWin * Slotter.Multiplier, FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
                Console.WriteLine("\nPénz: {0}$", Slotter.Money);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                person1.Play();
            }
            else if (ThirdNumber == FourthNumber)
            {//Ha x-1-1-x, x-2-2-x, x-3-3-x, x-4-4-x
                Slotter.Money += (SmallWin * Multiplier);
                Console.WriteLine("{0}$ Nyeremény.\n\n Ezek voltak a nyerő számok: {1},{2},{3},{4}", SmallWin * Slotter.Multiplier, FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
                Console.WriteLine("\nPénz: {0}$", Slotter.Money);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                person1.Play();
            }
            else if (FirstNumber == 1 && SecondNumber == 2 && ThirdNumber == 3 && FourthNumber == 4)
            {//Ha 1-2-3-4
                Slotter.Money += (BigWin* Slotter.Multiplier);
                Console.WriteLine("{0}$ Nyeremény.\n\n Ezek voltak a nyerő számok: {1},{2},{3},{4}", BigWin * Slotter.Multiplier, FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
                Console.WriteLine("\nPénz: {0}$", Slotter.Money);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                person1.Play();
            }
            else if (FirstNumber == 4 && SecondNumber == 3 && ThirdNumber == 2 && FourthNumber == 1)
            {//Ha 4-3-2-1
                Slotter.Money += (BigWin*Slotter.Multiplier);
                Console.WriteLine("{0}$ Nyeremény.\n\n Ezek voltak a nyerő számok: {1},{2},{3},{4}", BigWin * Slotter.Multiplier, FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
                Console.WriteLine("\nPénz: {0}$", Slotter.Money);
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                person1.Play();
            }
            else
            {
                person1.Play();
            }
        }

        public void Win_Screen()
        {
            Console.WriteLine("Gratulálunk {0}, elérted a 10-es szorzót. Megnyerted a játékot!", Name);
            Console.WriteLine("Pew-Pew!! Win-Win! Pew-Pew!!");
            System.Threading.Thread.Sleep(2500);
            Console.Clear();
            ResetToStart();
        }

        public void GameOver()
        {
            Console.WriteLine("Minden Pénzed elfogyott, nem sikerült legyőzni a programot!");
            Console.ReadKey();
            Console.Clear();
            ResetToStart();
        }

        public void ResetToStart()
        {
            Console.WriteLine("Újra kezded a játékot kis türelmet...");
            Slotter.Money = 0;
            Slotter.Multiplier = 0;
            Store.MultiplerMoneyWorth = 100;
            Game_Start();
            Console.Clear();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdv a Slotter-ben. ");
            Console.Write("Üsd be a neved: ");
            var person1 = new Slotter();
            person1.Name = Convert.ToString(Console.ReadLine());
            person1.Game_Start();
            Console.Clear();
        }
    }
}
