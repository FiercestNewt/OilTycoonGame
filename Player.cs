using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OilTycoonGame
{
    internal class Player
    {
        public PlayerData data;
        public List<Rig> rigs = new List<Rig>();
        
        public void BuyRig(System.Drawing.Bitmap rigImage, System.Windows.Forms.Button rigBtn)
        {
            Rig r = new Rig(rigImage, rigBtn);
            rigs.Add(r);
        }

        public void BuyRefier(Rig r)
        {
            // add a rig to that refiner
            // check to see if the player has the money
            // give them a refiner if they do
        }

        public void UpgradeRig(Rig r)
        {
            // upgrade the level of a rig, if they happen to have enough
        }

        public int GetNextMoneyCollection()
        {
            int totalEarned = 0;
            for(var x = 0; x < this.rigs.Count; x++)
            {
                Rig currentRig = this.rigs[x];

                int moneyAmount = currentRig.GetMoney();
                totalEarned += moneyAmount;
            }

            // add the money to the data so that it is tracked
            this.data.AddMoney(totalEarned);

            return totalEarned;
        }
    }
}
