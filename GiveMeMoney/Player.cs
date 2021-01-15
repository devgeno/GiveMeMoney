using System;
using System.Collections.Generic;
using System.Text;

namespace GiveMeMoney
{
    class Player
    {
        private int money;
        private string name;

        public Player(string _name, int _money)
        {
            money = _money;
            name = _name;
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddMoney(int _money)
        {
            money += _money;
        }

        public int SubtractMoney(int _money)
        {
            if (_money >= money)
            {
                money = 0;
            }
            else
            {
                money -= _money;
            }
            return money;
        }
    }
}
