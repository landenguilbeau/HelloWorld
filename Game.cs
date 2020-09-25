using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Item
    {
        public int statBoost;
        public string name;
    }
    class Game
    {
        Player _player1;
        Player _player2;
        bool _gameOver = false;
        private Item _longSword;
        private Item _dagger;
        private Item _bow;
        private Item _crossBow;
        private Item _cherryBomb;
        private Item _mace;

        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        public void InitializeItems()
        {
            _longSword.name = "Long Sword";
            _longSword.statBoost = 15;
            _dagger.name = "Dagger";
            _dagger.statBoost = 10;
            _bow.name = "Bow";
            _bow.statBoost = 12;
            _crossBow.name = "Cross Bow";
            _crossBow.statBoost = 34;
            _cherryBomb.name = "Cherry Bomb";
            _cherryBomb.statBoost = 24;
            _mace.name = "Mace";
            _mace.statBoost = 25;
        }

        
        public void SelectLoadout(Player player)
        {
            Console.Clear();
            Console.WriteLine("Loadout 1: ");
            Console.WriteLine(_longSword.name);
            Console.WriteLine(_dagger.name);
            Console.WriteLine(_bow.name);

            Console.WriteLine("\n Loadout 2: ");
            Console.WriteLine(_crossBow.name);
        }

        public void StartBattle()
        {
            Console.Clear();
            Console.WriteLine("Now GO!");

            while (_player1.GetIsAlive() && _player2.GetIsAlive())
            {
                //print player stats to console
                Console.WriteLine("Player1");
                _player1.PrintStats();
                Console.WriteLine("Player2");
                _player2.PrintStats();
                //Player 1 turn start
                //Get player input
                char input;
                GetInput(out input, "Attack", "Change Weapon", "Your turn Player 1");

                if (input == '1')
                {
                    _player1.Attack(_player2);
                }
                else
                {
                    SwitchWeapons(_player1);
                }

                GetInput(out input, "Attack", "Change Weapon", "Your turn Player 2");

                if (input == '1')
                {
                    _player2.Attack(_player1);
                }
                else
                {
                    SwitchWeapons(_player2);
                }
                Console.Clear();
            }
            if (_player1.GetIsAlive())
            {
                Console.WriteLine("Player 1 wins!!1!1!!11!11?");
            }
            else
            {
                Console.WriteLine("Player 2 wins??????????");
            }
            ClearScreen();
            _gameOver = true;
        }
        public void SelectItem(Player player)
        {
            char input;
            GetInput(out input, "Loadout 1", "Loadout 2", "Please select item for battle");
            if(input == '1')
            {

            }
            else if(input == '2')
            {

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

                _gameOver = false;
            }

        }

        public void SwitchWeapons(Player player)
        {
            Item[] inventory = player.GetInventory();

            char input = ' ';
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + "\n Damage: " + inventory[i].statBoost);
            }
            Console.Write("> ");
            input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    {
                        player.EquipItem(0);
                        Console.WriteLine("You equipped " + inventory[0].name);
                        Console.WriteLine("Base damage increased by " + inventory[0].name);
                        break;
                    }
                case '2':
                    {
                        player.EquipItem(1);
                        Console.WriteLine("You equipped " + inventory[1].name);
                        Console.WriteLine("Base damage increased by " + inventory[1].name);
                        break;
                    }
                case '3':
                    {
                        player.EquipItem(2);
                        Console.WriteLine("You equipped " + inventory[2].name);
                        Console.WriteLine("Base damage increased by " + inventory[2].name);
                        break;
                    }
                default:
                    {
                        player.UnequipItems();
                        Console.WriteLine("You accidently dropped your weapon!");
                        break;
                    }
            }
        }

        void InitializeCharacters()
        {

        }
        public Player CreateCharacter()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Player player = new Player(name, 100, 5);
            SelectLoadout(player);
            return player;
        }
         
        void Start()
        {
            CreateCharacter();
            InitializeCharacters();
            InitializeItems();
        }
        void Update()
        {
            _player1 = CreateCharacter();
            _player2 = CreateCharacter();
            StartBattle();
        }
        void End()
        {

        }
    }
}

    
    

