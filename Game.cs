using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Player
    {
        public string name;
        public int health;
        public int defense;
        public int attack;
    }
    struct Item
    {
        public string name;
        public int addAttack;
        public int addDefense;
        public int addHealth;
    }
    class Game
    {
        Player player1;
        Player player2;
        Item sheild;
        Item sword;
        Item potion;
        bool _gameOver = false;
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
            while (player1.health > 0 && player2.health > 0)
            {

            }
        }
        void GetInput(out char input, string option1, string option2, string option3)
        {
            input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine("[1] " + option1);
                Console.WriteLine("[2] " + option2);
                Console.Write("}");
                input = Console.ReadKey().KeyChar;
            }
        }
        void Start()
        {
            InitializeCharacters();
            InitializeItems();
        }
       
        void InitializeCharacters()
        {
            player1.name = "[P1]";
            player1.health = 100;
            player1.defense = 0;
            player1.attack = 5;

            player2.name = "[P2]";
            player2.health = 100;
            player2.defense = 0;
            player2.attack = 5;
        }
        void InitializeItems()
        {
            sword.name = "Sword";
            sword.addAttack = 10;

            sheild.name = "Sheild";
            sheild.addDefense = 5;
            sheild.addAttack = 2;

            potion.name = "Potion";
            potion.addHealth = 10;
        }
        void Update()
        {

        }
        void End ()
        {

        }
        void PrintStats(Player player)
        {
            Console.WriteLine(player1.name);
            Console.WriteLine("Health: " + player1.health);
            Console.WriteLine("Attack: " + player1.attack);
            Console.WriteLine("Defense: " + player1.defense);
            Console.WriteLine(" ");
            Console.WriteLine(player2.name);
            Console.WriteLine("Health: " + player2.health);
            Console.WriteLine("Attack: " + player2.attack);
            Console.WriteLine("Defense" + player2.defense);
            
        }
        
    }
    
    
}
