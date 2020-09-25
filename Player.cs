using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _baseDamage;
        private Item[] _inventory;
        private Item _currentWeapon;
        private Item _hands;
        private bool _gameOver;
        private int _sword;
        private int _potion;
        public Player()
        {
            _inventory = new Item[3];
            _health = 100;
            _baseDamage = 10;
            _hands.name = "These Hands!";

        }
        public Player(string playerName, int healthVal, int damageVal, int inventorySize)
        {
            _name = playerName;
            _health = healthVal;
            _damage = damageVal;
            _inventory = new Item[inventorySize];
            _hands.name = "These Hands!";
            _hands.statBoost = 0;
        }
        public void AddItemToInventory(Item item, int index)
        {
            _inventory[index] = item;
        }
        public void SelectItem(Player player)
        {
            char input;
            GetInput(out input, "Sword", "Potion", "Please select item for battle");
            if (input == '1')
            {
                player.EquipItem(_sword);
            }
            else if (input == '2')
            {
                player.EquipItem(_potion);
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
        public void EquipItem(int ItemIndex)
        {
            _damage = _inventory[ItemIndex].statBoost;
        }

        public string GetName()
        {
            return _name;
        }
        public bool GetIsAlive()
        {
            return _health > 0;
        }
        public void Attack(Player enemy)
        {
            enemy.TakeDamage(_damage);
        }
        public void PrintStats()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }
        private void TakeDamage(int damageVal)
        {
            if(GetIsAlive())
            {
                _health -= damageVal;
            }
            Console.WriteLine(_name + " has taken " + damageVal + " damage.");
        }
        
    }
    
}
