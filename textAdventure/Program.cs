using System;

namespace textAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the doors of Life");
            Console.WriteLine();
            Console.WriteLine("Pick a door to see where in life you're headed next");
            Console.WriteLine();
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();

            string doorChoice;


            do
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You have 3 doors in front of you");
                Console.WriteLine("red door");
                Console.WriteLine("green door");
                Console.WriteLine("purple door");
                Console.WriteLine();
                Console.WriteLine("Pick a door");

                doorChoice = Console.ReadLine();

                if (doorChoice.ToLower() == "green door")
                {
                    Console.WriteLine("You win the lottery...but you only win $100!!");
                }

                else if (doorChoice.ToLower() == "purple door")
                {
                    Console.WriteLine("You win a million dollars but you'd be purple forever!!");
                }

                else if (doorChoice.ToLower() == "red door")
                {
                    Console.WriteLine("You get attacked by fire ants but you keep surviving!!!");
                }

                else
                {
                    Console.WriteLine("That door does not exist!");
                }

            } while (doorChoice != "green door");


                   Console.WriteLine("The End!");
        }
    }
}
