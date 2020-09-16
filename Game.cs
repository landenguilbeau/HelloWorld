using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct ForItems
    {
        public int statBoost;
    }
    class Game
    {
        Player player1;
        Player player2;
        bool _gameOver = false;
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }
        public void SelectItem(Player player)
        {
            char input;
            GetInput(out input, "Sword", "Potion", "Please select item for battle");
            if(input == '1')
            {
                player.EquipItem(sword);
            }
            else if(input == '2')
            {
                player.EquipItem(potion);
            } 
        }
        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.Write("> ");

            input = ' ';
            //loop until valid input is received
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        


        public Player CreateCharacter()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Player player = new Player(name, 100, 5);
            SelectItem(player);
            return player;
        }
        void Start()
        {

        }
        void Update()
        {

        }
        void End()
        {

        }
    }
}

    
    

