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

            //initializes variables
            int health = 0;
            int power = 0;
            string characterJob = "";
            string name = "";
            bool validInputRecieved = false;
            string input;
            int numberOfAttempts = 3;
            int attemptsRemaining = 3;


            //Gets player's name
            Console.WriteLine("What is your name?");
            Console.Write("> ");
            name = Console.ReadLine();
            Console.Clear();


            while (validInputRecieved == false)
            {
                //Asks player what class they'd like to choose, and gets input
                Console.WriteLine("Pick a class!");
                Console.WriteLine("1. Wizard");
                Console.WriteLine("2. Knight");
                Console.Write("> ");
                input = Console.ReadLine().ToLower();

                //Sets player's class to either wizard or knight, depending on input given
                if (input == "1" || input == "wizard")
                {
                    health = 150;
                    power = 15;
                    characterJob = "Wizard";
                    validInputRecieved = true;
                }
                else if (input == "2" || input == "knight")
                {
                    health = 400;
                    power = 80;
                    characterJob = "Knight";
                    validInputRecieved = true;
                }
                //..displays error message
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                }

                Console.Clear();
            }


            //Displays character stat
            Console.Clear();
            Console.WriteLine("Your Character Stats:\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Job: " + characterJob);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Power: " + power);
            Console.ReadKey();
            Console.Clear();

            //First stage
            Console.WriteLine("You awaken in a forest.");
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
            Console.Write("> ");
            input = Console.ReadLine().ToLower();


            //Gives the player two different outcomes, depending on the input given
            if (input == "1" || input == "right")
            {

                Console.Clear();
                Console.WriteLine("You walk down the path to your right, until you reach a point where the path is suddently cut off by a rushing river.");
                Console.WriteLine("You see a fallen tree laid across the river. You might be able to cross it if you tried.");
                Console.WriteLine("Will you turn back, or cross the tree?\n");
                Console.WriteLine("1. Cross the Tree");
                Console.WriteLine("2. Turn around");
                Console.Write("> ");
                input = Console.ReadLine().ToLower();

                if (input == "1" || input == "cross" || input == "cross the tree")
                {
                    Console.Clear();
                    Console.WriteLine("You attempt to cross the tree.");
                    Console.WriteLine("Unfortunately, you only make it half way before the tree breaks, leaving you to drown in the rushing water.");
                    Console.WriteLine("You die a sad death.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Game over!");
                    Console.ReadKey();
                }
                else if (input == "2" || input == "turn" || input == "turn around")
                {
                    Console.WriteLine();
                    Console.WriteLine("You head back towards where you came");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("You walk down the path to your left, until you see a strange man standing in the road.");
                    Console.WriteLine("He waves at you, and then gestures for you to come closer");
                    Console.WriteLine("Hello stranger!', the strange man says to you.");
                    Console.WriteLine("I have a riddle for you! If you can solve it, I'll help you out!', he says.");
                    Console.WriteLine("You have three chances! If you fail, you will die!', he says.");

                    for (int i = 0; i < numberOfAttempts; i++)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("You decide to listen to the strange man's riddle. " +
                            "\n'Okay', you say to him.");
                        Console.WriteLine("'What has to be broken before you can use it?', says the strange man.");
                        Console.WriteLine("Attempts remaining: " + attemptsRemaining);
                        Console.Write("> ");
                        input = Console.ReadLine().ToLower();

                        if (input == "egg")
                        {
                            Console.WriteLine("'Wow, good job!', the strange man says.");
                            Console.WriteLine("'There is a town along this road! You should reach if before night if you hurry!', he says. He then runs off into the forest.");
                            break;
                        }
                        else
                        {
                            attemptsRemaining--;
                            Console.WriteLine("You were wrong!");
                            Console.WriteLine("Attempts remaining:" + attemptsRemaining);
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                }
            }


            else if (input == "2" || input == "left")
            {
                Console.Clear();
                Console.WriteLine("You walk down the path to your left, until you see a strange man standing in the road.");
                Console.WriteLine("He waves at you, and then gestures for you to come closer");
                Console.WriteLine("Hello stranger!', the strange man says to you.");
                Console.WriteLine("I have a riddle for you! If you can solve it, I'll help you out!', he says.");
                Console.WriteLine("You have three chances! If you fail, you will die!', he says.");

                for (int i = 0; i < numberOfAttempts; i++)
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("You decide to listen to the strange man's riddle. " +
                        "\n'Okay', you say to him.");
                    Console.WriteLine("'What has to be broken before you can use it?', says the strange man.");
                    Console.WriteLine("Attempts remaining: " + attemptsRemaining);
                    Console.Write("> ");
                    input = Console.ReadLine().ToLower();

                    if (input == "egg")
                    {
                        Console.WriteLine("'Wow, good job!', the strange man says.");
                        Console.WriteLine("'There is a town along this road! You should reach if before night if you hurry!', he says. He then runs off into the forest.");
                        break;
                    }
                    else
                    {
                        attemptsRemaining--;
                        Console.WriteLine("'Haha, that was wrong!', the strange man says.");
                        Console.WriteLine("Attempts remaining: " + attemptsRemaining);

                        if (attemptsRemaining == 0)
                        {
                            Console.WriteLine("The strange man's eyes begin to glow a deep red, and he starts laughing like a maniac.");
                            Console.WriteLine("You start to feel strange, as you see your soul being sucked from your body.");
                            Console.WriteLine("You died a pathetic death.");
                            Console.ReadKey();
                            Console.WriteLine("Game over!");
                            Console.ReadKey();
                            Console.Clear();
                            Run();
                        }
                    }
                }
                Console.WriteLine("You head off in the direction of the town.");


            }
            else
            {
                Console.WriteLine("Invalid input!");
                Console.ReadKey();
            }
        }

        public void startGame()
        {

        }
    }
}
