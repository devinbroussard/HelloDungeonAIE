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
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

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
            Console.ReadKey();
            Console.Clear();

            //First stage
            Console.WriteLine("You awaken in a forest.");
            Console.ReadKey();
            Console.WriteLine("Upon looking around, you notice that the sun is setting.");

            //displays different text to the player, depending on their class
            if (characterJob == "Wizard")
            {
                Console.WriteLine("You look down, and see you still have your magic gear.");
            }
            else if (characterJob == "Knight")
            {
                Console.WriteLine("You look down, and see that you still have your sword and armor on.");
            }

            //Asks for player input
            Console.WriteLine("You begin walking towards a dirt path that you see in the distance.");
            Console.WriteLine("You reach the path, and are now faced with a decision.");
            Console.WriteLine("Will you walk down the path to your left, or right?\n");
            Console.WriteLine("1. Right");
            Console.WriteLine("2. Left");
            input = Console.ReadLine().ToLower();

            //Gives the player two different outcomes, depending on the input given
            if (input == "1" || input == "right")
            {
                Console.WriteLine("You walk down the path to your right, until you reach a point where the path is suddently cut off by a rushing river.");
                Console.WriteLine("You see a fallen tree laid across the river. You might be able to cross it if you tried.");
                Console.WriteLine("Will you turn back, or cross the tree?\n");
                Console.WriteLine("1. Cross the Tree");
                Console.WriteLine("2. Turn around");
                input = Console.ReadLine().ToLower();

                if (input == "1" || input == "cross" || input == "cross the tree") ;
                {
                    Console.WriteLine("You attempt to cross the tree.");
                    Console.WriteLine("You only make it half way until it snaps, leaving you to drown in the rushing river.");
                    Console.WriteLine("Game over!");
                }
                else if (input == "2" || input == "cross" || input == "cross the tree")
                {

                }

            }

            else if (input == "2" || input == "left")
            {
                Console.WriteLine("You down the path to your left, until you see a strange man standing in the road.");
                Console.WriteLine("He waves at you, and then gestures for you to come closer");
            }

        }
    }
}
