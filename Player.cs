using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OilTycoonGame
{
    internal class Player
    {
        public int totalMoneyPerSecond = 0;
        public int totalMoney = 0;
        public int lifetimeMoney = 0;
        public List<Rig> rigs = new List<Rig>();    
    }
}
