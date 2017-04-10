using System;

namespace PersonIndentifier
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public byte Age;
        public string Gender;
        public int Weight;
        public int Height;
        public string Nationality;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName + " my age is " + Age + " , I'm a " + Gender + " my weight is " + Weight + " and my height is " + Height + " \nThe country I live in: " + Nationality);
            System.Threading.Thread.Sleep(2000);
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program will ask for your name, and other things, please answer the questions.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            var person1 = new Person();
            Console.Write("What is your first name: ");
            person1.FirstName = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.Write("What is your second name: ");
            person1.LastName = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.Write("What is your age: ");
            person1.Age = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            Console.Write("What is your gender: ");
            person1.Gender = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.Write("What is your weight: ");
            person1.Weight = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("What is your height: ");
            person1.Height = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("What country are you live in: ");
            person1.Nationality = Convert.ToString(Console.ReadLine());
            Console.Clear();
            person1.Introduce();
        }
    }
}