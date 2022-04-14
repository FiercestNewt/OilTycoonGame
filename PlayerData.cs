using System;
using System.Collections.Generic;
using System.Text;

namespace OilTycoonGame
{
    class PlayerData
    {
        public int money = 0;
        public int totalMoneyPerSecond = 0;
        public int lifetimeMoney = 0;

        public void AddMoney(int amount)
        {
            this.money += amount;
            this.lifetimeMoney += amount;
        }

        public void RemoveMoney(int amount)
        {
            this.money -= amount;
        }
    }
}
