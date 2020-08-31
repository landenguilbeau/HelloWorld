using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        float heal(float playerHealth)
        {
            float result = (playerHealth + 20);
            return result;
        }
        void PrintStats(float health, int defense, string name)
        {
            Console.WriteLine(name + " health: " + health);
            Console.WriteLine(name + " defense: " + defense);
        }
        
        public void Run()
        {

            Console.WriteLine("Welcome hero what is your name?!");
            string playerName = Console.ReadLine();

            Console.WriteLine(playerName + " please select a pet name of choice");
            string pet = Console.ReadLine();

            // This variable is used to store base stats.
            float playerHealth = 100;
            int playerDefense = 50;
            int playerDamage = 0;

            // This loop is to remind player of their health
            if (playerHealth >= 100)
            {
                Console.WriteLine("Health is full");
            }
            if (playerHealth <= 40)
            {
                Console.WriteLine("Danger! You're health is low!");
            }
            if (playerHealth <= 0)
            {
                Console.WriteLine("You have died!");
            }


            // This value is used to store the pet's health and damage.
            int petHealth = 0;
            int petDamage = 0;
            int petDefense = 0;

            // The string allows players to select a role 
            Console.WriteLine("Please select a role");
            Console.WriteLine("Select one: [1]Mage, [2]Knight, [3]Assassain, or [4]Hunter");
            char input = (' ');
            Console.WriteLine();
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                input = Console.ReadKey().KeyChar;

                if (input == '1')
                {
                    playerHealth = 100;
                    playerDefense = 25;
                    playerDamage = playerDamage + 15;
                }
                if (input == '2')
                {
                    playerHealth = 100;
                    playerDefense = 75;
                    playerDamage = playerDamage + 25;
                }
                if (input == '3')
                {
                    playerHealth = 100;
                    playerDefense = 25;
                    playerDamage = playerDamage + 10;
                }
                if (input == '4')
                {
                    playerHealth = 100;
                    playerDefense = 45;
                    playerDamage = playerDamage + 20;
                }

            }

            Console.WriteLine(")");
            Console.WriteLine("Choose pet type");
            Console.WriteLine("[1] Dragon, [2] Horse, [3] Crow, [4] Wolf");
            char petType = (' ');
            Console.WriteLine();
            while (petType != '1' && petType != '2' && petType != '3' && petType != '4')
            {
                petType = Console.ReadKey().KeyChar;

                if (petType == '1')
                {
                    petHealth = petHealth + 25;
                    petDamage = petDamage + 10;
                    petDefense = petDefense + 0;
                }
                if (petType == '2')
                {
                    petHealth = petHealth + 20;
                    petDamage = petDamage + 7;
                    petDefense = petDefense + 10;
                }
                if (petType == '3')
                {
                    petHealth = petHealth + 10;
                    petDamage = petDamage + 15;
                    petDefense = petDefense + 5;
                }
                if (petType == '4')
                {
                    petHealth = petHealth + 15;
                    petDamage = petDamage + 15;
                    petDefense = petDefense + 15;
                }

            }

            // The code below allows the player to see it's stats, name, and pet's name.
            Console.WriteLine(") ");
            Console.WriteLine("[PLAYER STATS]");
            Console.WriteLine("PLayer Name: " + playerName);
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Player Damage: " + playerDamage);
            Console.WriteLine("Player Defense: " + playerDefense);

            Console.WriteLine(" ");

            Console.WriteLine("[PET STATS]");
            Console.WriteLine("Pet's Name: " + pet);
            Console.WriteLine("Pet's Health: " + petHealth);
            Console.WriteLine("Pet's Damage: " + petDamage);
            Console.WriteLine("Pet's Defense: " + petDefense);
           
            Console.WriteLine(" ");
            Console.WriteLine("[Enter] to continue");

            string continueGame = Console.ReadLine();
            if (continueGame == "1") 
            {
                Console.WriteLine(" ");
            }

            Console.Clear();

            // The users adventure begins 
            Console.WriteLine(" ");
            Console.WriteLine("You're told to go to Himpleton Village");
            Console.WriteLine(" ");
            Console.WriteLine("You have arrived in Himpleton Village and meet someone named Bidwarf");
            Console.WriteLine(" ");
            Console.WriteLine("Bidwarf: Who are you?");
            Console.WriteLine(" ");
            Console.WriteLine("You:" + playerName);
            Console.WriteLine(" ");
            Console.WriteLine("Bidwarf: Where are you from?");
            Console.WriteLine(" ");

            string home = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You:" + home);
            Console.WriteLine(" ");
            Console.WriteLine("Bidwarf: Sounds interesting, would you mind helping out a bit? ");
            Console.WriteLine("[1] Yes or [2] No");
            Console.WriteLine(" ");

            char answerBidwarf = (' ');
            while (answerBidwarf != '1' && answerBidwarf != '2')
            {
                answerBidwarf = Console.ReadKey().KeyChar;

                if (answerBidwarf == '1')
                {
                    Console.WriteLine(playerName + ": No, I wouldn't mind.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Bidwarf: Okay defeat that troll that lurks around the village at night,and bring me back a Troll's Toe. I'll throw in a reward!");
                    Console.WriteLine(" ");
                    Console.WriteLine(playerName + ": Okay, no problem.");
                }
                else if (answerBidwarf == '2')
                {

                    Console.WriteLine("Bidwarf: Too bad, I need your help.");
                    Console.WriteLine("Bidwarf: Okay defeat that troll that lurks around the village at night,and bring me back a Troll's Toe. I'll throw in a reward!");
                    Console.WriteLine(playerName + ": Okay, no problem.");
                }
            }


            Console.WriteLine("The night approaches...");
            Console.WriteLine("[Enter] to continue");

            //This string is used to advance the game and clear the console to make things look nicer
            string advance = Console.ReadLine();

            if (advance == " ")
            {
                Console.WriteLine(" ");
            }

            Console.Clear();

            // Player's first encounter with an enemy
            Console.WriteLine("You have encountered the Troll");

            int trollHealth = 50;
            int trollDamage = 5;
            string trollName = ("Basic Troll");

            while (trollHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("What will you do?");
                Console.WriteLine("[1] Attack");
                Console.WriteLine("[2] Pet Attack");

                PrintStats(playerHealth, playerDefense, playerName);
                PrintStats(petHealth, petDefense, pet);
                PrintStats(trollHealth, trollDamage, trollName);

                input = Console.ReadKey().KeyChar;

                if (input == '1')
                {
                    trollHealth -= playerDamage;
                    playerHealth -= trollDamage;
                    Console.WriteLine("You have done " + playerDamage + " to the Troll!");
                    Console.WriteLine(trollName + " has done " + trollDamage + " to you.");
                }
                else if (input == '2')
                {
                    trollHealth -= petDamage;
                    petHealth -= trollDamage;
                    Console.WriteLine("You have done " + petDamage + "to the " + trollName);
                    Console.WriteLine(trollName + " has done " + trollDamage + " to " + pet);
                }
                Console.Clear();
            }

            Console.WriteLine("Congratulations! You have defeated " + trollName);
            Console.WriteLine("[Enter] to continue.");
            Console.WriteLine("Now return the Troll's Toe to Bidwarf.");

            Console.ReadLine();
            Console.Clear();

            playerHealth = 100;







            // Create an application that gets the users name
            // along with additional input. Print the user's name and input
            // to the console along with their stats. Must use all data types.




        }
    }
}
