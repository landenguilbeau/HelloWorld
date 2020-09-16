using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Item
    {
        private string name;
        private int addDamage;
        private int addDefense;
        private int addHealth;

        public Item()
        {
            addDamage = 0;
            addDefense = 0;
            addHealth = 0;
        }
        public Item(int damage,int defense, int health)
        {
            addDamage = (damage + 10);
            addDefense = (defense + 5);
            addHealth = (defense + 7);
        }


    }

}
