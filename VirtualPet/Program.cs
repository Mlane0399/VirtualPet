using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        public static string Speak { get; private set; }

        static void Main(string[] args)

        {
            VirtualPet1 myVirtualPet = new VirtualPet1();




            string name = "";


            while (name == "") // Accepting value of Name property
            {
                Console.WriteLine("Name your pet!");
                string TamaName = (name);
                name = Console.ReadLine();
            }

            string Color = "";

            while (Color == "") // Accepting value of Color property
            {
                Console.WriteLine("What color is your pet?");
                string TamaColor = (Color);
                Color = Console.ReadLine();
            }

            string Age = "";

            while (Age == "") // Accepting value of Age property
            {
                Console.WriteLine("How old is your pet?");
                string TamaAge = (Age);
                Age = Console.ReadLine();
            }




            Console.WriteLine("My pet " + name + " is " + Age + " year(s) old. " + " and is the color " + Color);

            Console.WriteLine("How do you want to interact with the pet? (speak/feed/play)");

            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "speak":
                    Console.WriteLine(name + " says Hello! ");
                    break;

                case "feed":
                    Console.WriteLine(name + " is eating their food ");
                    break;

                case "play":
                    Console.WriteLine(name + " is having a roll in the yard ");
                    break;

            }








        }
    }
}

