using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("Welcome hero what is your name?!");
            string name = Console.ReadLine();

            Console.WriteLine(name + " please select a pet name of choice");
            string pet = Console.ReadLine();

            // This variable is used to store base stats.
            float health = 100;
            float speed = 25;
            float defense = 50;

            // This value shows the players' and their pets' levels, and the maximum level capacity.
            int maxLevel = 100;
            int level = 1;
            int petLevel = 1;

            // This value is used to store the pet's health.
            float petHealth = 50;

            // The string allows players to select a role 
            Console.WriteLine("Please select a role");
            Console.WriteLine("Select one: Mage, Knight, Assassain, or Hunter");
            string role = Console.ReadLine();

            Console.WriteLine("So you are a " + role + "?");
            if (role == "Mage")
            {
                health = 100;
                speed = 75;
                defense = 25;
                petHealth = 50;
            }
            if (role == "Knight")
            {
                health = 100;
                speed = 50;
                defense = 50;
                petHealth = 50;
            }
            if (role == "Assassin")
            {
                health = 90;
                speed = 85;
                defense = 25;
                petHealth = 50;
            }
            if (role == "Hunter")
            {
                health = 100;
                speed = 45;
                defense = 45;
                petHealth = 75;

            }

            // This value is used to heal the player.
            float healthRegen = 20;
            Console.WriteLine("You look a little hurt take this");
            Console.WriteLine("You gained " + healthRegen + "Hp!!");

            Console.WriteLine("Congrats " + name + "! Good Luck!");
            bool ready = true;

            // The code below allows the player to see it's stats, name, and pet's name.
            Console.WriteLine("PLayer Name:" + name);
            Console.WriteLine("Player Health:" + health);
            Console.WriteLine("Player Speed:" + speed);
            Console.WriteLine("Player Defense:" + defense);
            Console.WriteLine("Player Level:" + level);

            Console.WriteLine("Pet's Name:" + pet);
            Console.WriteLine("Pet's Health:" + petHealth);
            Console.WriteLine("Pet's level:" + petLevel);

            Console.WriteLine("Remain safe and make the right decisions to survive and level up!");
            Console.WriteLine("Press [1] to start");
            string startGame = Console.ReadLine();

            if(startGame == "1")
            {
                Console.WriteLine(" ");
            }

            Console.Clear();


            // The users adventure begins with lure
            Console.WriteLine(" ");
            Console.WriteLine("You're told to go to Himpleton Village");
            Console.WriteLine(" ");
            Console.WriteLine("You have arrived in Himpleton Village and meet someone named Bidwarf");
            Console.WriteLine("Bidwarf: Who are you?");
            Console.WriteLine("You:" + name);
            Console.WriteLine("Bidwarf: Where are you from?");

            string home = Console.ReadLine();
            Console.WriteLine("You:" + home);

            Console.WriteLine("Bidwarf: Sounds interesting, would you mind helping out a bit? ");
            Console.WriteLine("[1] Yes or [2] No");
            string answer1 = Console.ReadLine();

            if(answer1 == "1" )
            {
                Console.WriteLine("You: No, I wouldn't mind.");
                Console.WriteLine("Bidwarf: Okay can you defeat that troll that lurks around the village at night? It bothers me, and I'll throw in a reward!");
                Console.WriteLine("[1] Yes or [2] No");
                string answer2 = Console.ReadLine();
                if (answer2 == "1")
                {
                    Console.WriteLine("Bidwarf: Okay bring me back a troll toe and I'll reward you!");

                }


            }

            if (answer1 == "2" )
            {
                Console.WriteLine("You: Yes i would, thanks not interested.");
                Console.WriteLine("Bidwarf: Pfft! Whatever.");
            }

            Console.WriteLine("The night approaches...");
            Console.WriteLine("[1] to continue");

            string answer3 = Console.ReadLine();

            if(answer3 == "1")
            {
                Console.WriteLine(" ");
            }

            Console.Clear();

            
            Console.WriteLine("You've encountered the troll!!!");
            Console.WriteLine("How should you attack?");
            Console.WriteLine("");
            Console.WriteLine("[1] Punch");
            Console.WriteLine("[2] Kick");
            string answer4 = Console.ReadLine();
            if(answer4 == "1")
            {
                Console.WriteLine("You have injured the troll!");
                Console.WriteLine("You [  " + health + "  ]");
                Console.WriteLine("Troll [  20  ] -15");

                Console.WriteLine("How should you attack?");
                Console.WriteLine("[1] Punch");
                Console.WriteLine("[2] Kick");
                string answer5 = Console.ReadLine();
                string answer6 = Console.ReadLine();
                if (answer5 == "1")
                {
                    Console.WriteLine("You have injured the troll!");
                    Console.WriteLine("You [  " + health + "  ]");
                    Console.WriteLine("You [  5  ] -15");
                    Console.WriteLine("Congradulations, you have defeated the Troll!");
                    Console.WriteLine("The Trolls's Toe was not found, please restart");
                }
                if (answer5 == "2")
                {
                    Console.WriteLine("The kick landed, he dropped an item");
                    Console.WriteLine("You [  " + health + "  ]");
                    Console.WriteLine("Troll [  5  ] -25");
                    Console.WriteLine("You have acquired Troll's Toe");

                    Console.WriteLine("[1] to continue");
                    if(answer6 == "1")
                    {
                        Console.WriteLine(" ");

                    }

                }
                
            }
            string answer7 = Console.ReadLine();
            if(answer7 == "2")
            {
                Console.WriteLine("You missed the troll! He headbutt you!");
                Console.WriteLine("You [  " + health + "  ]" + "-15");
                Console.WriteLine("Troll [  20  ]");
            }

            // Create an application that gets the users name
            // along with additional input. Print the user's name and input
            // to the console along with their stats. Must use all data types.

        }
    }
}
