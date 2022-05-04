using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OilTycoonGame
{
    internal class Player
    {
        public PlayerData data = new PlayerData();
        public List<Rig> rigs = new List<Rig>(6);
        
        public int BuyRig(System.Windows.Forms.Button rigBtn) //System.Drawing.Bitmap rigImage, 
        {
            char num = rigBtn.Name[rigBtn.Name.Length - 1];
            int numberPos = int.Parse(num.ToString());
            Rig r = new Rig(rigBtn);
            return numberPos;
            //rigs[numberPos - 1] = r;
        }

        public void BuyRefier(Rig r)
        {
            // add a rig to that refiner
            // check to see if the player has the money
            // give them a refiner if they do
            data.AddMoney(10);
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
