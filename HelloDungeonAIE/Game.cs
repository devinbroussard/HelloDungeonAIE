using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeonAIE
{
    class Game
    {
        //initializes variables
        int health = 0;
        int power = 0;
        string characterJob = "";
        string name = "";
        int input;

        public void Run()
        {
            StartGame();
        }

        //Function calls the welcome menu, and then leads to the rest of the game
        public void StartGame()
        {
            //displays a welcome message to the player
            string start = "Welcome!";
            Console.WriteLine(start);

            //Gets player's name
            Console.WriteLine("What is your name?\n");
            Console.Write("> ");
            name = Console.ReadLine();
            Console.Clear();

            //Asks player what class they'd like to choose, and gets input
            input = GetInput("Pick a class!", "Wizard", "Knight");

            if (input == 1)
            {
                health = 2002
                    ;
                power = 15;
                characterJob = "Wizard";
            }
            else if (input == 2)
            {
                health = 400;
                power = 80;
                characterJob = "Knight";
            }

            //calls two functions which progress the game further
            DisplayStats();
            FirstStage();

        }

        //function for Displaying character stats; can be used multiple times
        void DisplayStats()
        {
            //Displays character stat
            Console.Clear();
            Console.WriteLine("Your Character Stats:\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Job: " + characterJob);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Power: " + power);
            Console.ReadKey();
            Console.Clear();
        }

        //function that contains the first stage, and that will call the next stage
        void FirstStage()
        {
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
            input = GetInput("Will you walk down the path to your left, or right ? ", "Right", "Left");

            //Gives the player two different outcomes, depending on the input given
            if (input == 1)
            {
                GoRightPath();
            }


            else if (input == 2)
            {
                GoLeftPath();
            }
            else
            {
                Console.WriteLine("Invalid input!");
                Console.ReadKey();
            }
        }

        //calls the scenario for if the player chooses the right path
        public void GoRightPath()
        {
            Console.Clear();
            Console.WriteLine("You walk down the path to your right, until you reach a point where the path is suddently cut off by a rushing river.");
            Console.WriteLine("You see a fallen tree laid across the river. You might be able to cross it if you tried.");

            input = GetInput("Will you turn back, or cross the tree?", "Cross the Tree", "Turn around");

            //Gives the player a game over if they choose the risky option
            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine("You attempt to cross the tree.");
                Console.WriteLine("Unfortunately, you only make it half way before the tree breaks, leaving you to drown in the rushing water.");
                Console.WriteLine("You die a sad death.");
                Console.ReadKey();
                GameOver();
            }

            //Lets the player turn around instead of taking the risky option
            else if (input == 2)
            {
                Console.WriteLine();
                Console.WriteLine("You head back towards where you came");
                Console.ReadKey();
                GoLeftPath();
            }
        }

        //Calls the scenario for if the player chooses the left path
        public void GoLeftPath()
        {
            Console.Clear();
            Console.WriteLine("You walk down the path to your left, until you see a strange man standing in the road.");
            Console.WriteLine("He waves at you, and then gestures for you to come closer");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Hello stranger!', the strange man says to you.");
            Console.WriteLine("I have a riddle for you! If you can solve it, I'll help you out!', he says.");
            Console.WriteLine("You have three chances! If you fail, you will die!', he says.");
            Console.ReadKey();
            Console.Clear();

            //Asks the player on input on a decision that will influence the game
            input = GetInput("Will you take the strange man's riddle?", "Yes", "No");

            //The strange man kills the player if they do not take the riddle
            if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("The strange man's eyes begin to glow a deep red, and he starts laughing like a maniac.");
                Console.WriteLine("You start to feel strange, as you see your soul being sucked from your body.");
                Console.WriteLine("You die a pathetic death!");
                Console.ReadKey();
                GameOver();
            }

            if (input == 1)
            {
                StrangeManRiddle();
            }
        }

        //Generic function that asks for user input; can be used multiple times 
        public int GetInput(string description, string option1, string option2)
        {
            int inputRecieved = 0;

            while (!(inputRecieved == 1 || inputRecieved == 2))
            {
                //Displays character options and asks for input
                Console.WriteLine(description + "\n");
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");
                string getInput = Console.ReadLine().ToLower();

                //Gives player two different outcomes depending on their input
                if (getInput == "1" || getInput == option1.ToLower())
                {
                    inputRecieved = 1;
                }
                else if (getInput == "2" || getInput == option2.ToLower())
                {
                    inputRecieved = 2;
                }
                //..displays error message
                else
                {
                    Console.WriteLine("\nInvalid input!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            return inputRecieved;
        }

        //Win screen that can be called anywhere, and that will ask the player if they'd like to play again
        public void WinScreen()
        {
            Console.Clear();
            Console.WriteLine("You won!\n");
            Console.ReadKey();
            input = GetInput("Would you like to play again?", "Yes", "No");

            if (input == 1)
            {
                ResetVariables();
                Console.Clear();
                StartGame();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Okay, goodbye!");
                Console.ReadKey();
            }

        }

        //A generic game over function that can be used multiple times 
        public void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over!\n");
            Console.ReadKey();

            input = GetInput("Will you give up, or try again?", "Try again", "Give up");

            //Restarts the game if player wants to
            if (input == 1)
            {
                ResetVariables();
                Console.Clear();
                StartGame();
            }
            //Ends game if player wants to
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Goodbye, coward!");
                Console.ReadKey();
            }
        }

        //Resets variables; used for if the player restarts game
        public void ResetVariables()
        {
            health = 0;
            power = 0;
            characterJob = "";
            name = "";
            input = 0;
        }

        public void StrangeManRiddle()
        {
            int numberOfAttempts = 3;
            int attemptsRemaining = 3;

            //Gives the player three attempts at solving the riddle
            for (int i = 0; i < numberOfAttempts; i++)
            {
                string riddleInput;
                Console.Clear();
                Console.WriteLine("You decide to listen to the strange man's riddle.");
                Console.WriteLine("'What has to be broken before you can use it?', says the strange man.\n");
                Console.WriteLine("Attempts remaining: " + attemptsRemaining);
                Console.Write("> ");
                riddleInput = Console.ReadLine().ToLower();

                //Progresses the story if the player gets the riddle correct
                if (riddleInput == "egg")
                {
                    Console.Clear();
                    Console.WriteLine("'Wow, good job!', the strange man says.");
                    Console.WriteLine("'There is a town along this road! You should reach if before night if you hurry!'");
                    Console.WriteLine("He then runs off into the forest.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("You head in the direction the strange man told you to go.");
                    Console.WriteLine("You followed the path and made it to your home village!");
                    Console.ReadKey();

                    //Would call the next level here, but for time's sake will end the game
                    WinScreen();
                    break;
                }
                else
                {
                    attemptsRemaining--;
                    health -= 50;
                    Console.WriteLine();
                    Console.WriteLine("'Haha, that was wrong!', the strange man says.");
                    Console.WriteLine("You see ghostly bits leaving your body and heading toward the man.\n");
                    Console.ReadKey();
                    Console.WriteLine("You lost 50 health!");
                    Console.WriteLine("Current health: " + health);
                    Console.ReadKey();

                    //if the player runs out of attempts, the game will be over, and then restart
                    if (attemptsRemaining == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("The strange man's eyes begin to glow a deep red, and he starts laughing like a maniac.");
                        Console.WriteLine("You start to feel strange, as you see your soul being sucked from your body.");
                        Console.WriteLine("You die a pathetic death!");
                        Console.ReadKey();
                        GameOver();
                    }
                }
            }
        }
        /// <summary>
        /// Prints all even numbers in the range [num1..num2]
        /// </summary>
        /// <param name="num1">The starting number</param>
        /// <param name="num2">The ending number</param>
        void PrintAllEven(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
