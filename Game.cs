﻿using System;
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

            Console.WriteLine("Please choose a role");
            Console.WriteLine("Choose Between Mage, Knight, Assassain, or Hunter");
            string role = Console.ReadLine();

            Console.WriteLine("So you are a " + role + "?");
            if (role == "Mage") ;
            if (role == "Knight") ;
            if (role == "Assassain") ;
            if (role == "Hunter") ;

            // This variable is used to store health.
            float health = 100;

            // This value is used to heal the player.
            float healthRegen = 20;
            Console.WriteLine("You look a little hurt take this");
            Console.WriteLine("You gained " + healthRegen + "Hp!!");

            // This value is used to store the pet's health.
            float petHealth = 50;

            // This value shows the players' and their pets' levels, and the maximum level capacity.
            int maxLevel = 100;
            int level = 1;
            int petLevel = 1;

            Console.WriteLine("Congrats " + name + "! Good Luck!");
            bool ready = true;

            // The code below allows the player to see it's stats, name, and pet's name.
            Console.WriteLine("PLayer Name:" + name);
            Console.WriteLine("Player Health:" + health);
            Console.WriteLine("Player Level:" + level);
            Console.WriteLine("Pet's Name:" + pet);
            Console.WriteLine("Pet's level:" + petLevel);
            Console.WriteLine("Press any key to continue");


            // Create an application that gets the users name
            // along with additional input. Print the user's name and input
            // to the console along with their stats. Must use all data types.
        }
    }
}
