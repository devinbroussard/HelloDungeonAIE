using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeonAIE
{
    class Game
    {
        public void Run()
        {
            string start = "Welcome!";
            Console.WriteLine(start);

            //initializes variable
            int health = 0;
            int power = 0;
            string characterJob = "";
            string name = "";

            //Gets player's name
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine().ToUpper();

            //Asks player what class they'd like to choose, and gets input
            Console.WriteLine("Pick a class!");
            Console.WriteLine("1. Wizard");
            Console.WriteLine("2. Knight");
            string input = Console.ReadLine().ToLower();

            //Sets player's class to either wizard or knight, depending on input given
            if (input == "1" || input == "wizard")
            {
                health = 150;
                power = 15;
                characterJob = "Wizard";
            }
            else if (input == "2" || input == "knight")
            {
                health = 400;
                power = 80;
                characterJob = "Knight";
            }
            //..displays error message
            else
            {
                Console.WriteLine("Invalid input!");
            }

            //Displays character stat
            Console.WriteLine("Your Character Stats:\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Job: " + characterJob);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Power: " + power);

        }
    }
}
