using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OilTycoonGame
{
    internal class Player
    {
        public PlayerData data = new PlayerData();
        public List<Rig> rigs = new List<Rig>();
        private int RigPrice = 10;
        private int RefinerPrice = 30;

        public Rig? BuyRig(System.Windows.Forms.Button rigBtn, System.Windows.Forms.PictureBox instance) //System.Drawing.Bitmap rigImage, 
        {
            if (this.data.money >= this.RigPrice)
            {
                this.data.RemoveMoney(RigPrice);
                char num = rigBtn.Name[rigBtn.Name.Length - 1];
                int numberPos = int.Parse(num.ToString()) - 1;
                Rig r = new Rig(numberPos, instance);
                rigs.Add(r);
                return r;
            }
            return null;

        }

        public Rig? GetRig(int id)
        {
            if (this.rigs.Count >= 1)
            {
                for (int x = 0; x < this.rigs.Count; x++)
                {
                    if (this.rigs.ElementAt(x).id == id)
                    {
                        return this.rigs[x];
                    }
                }
            }
            return null;
        }

        public void BuyRefiner(Rig r)
        {
            // add a rig to that refiner
            // check to see if the player has the money
            // give them a refiner if they do
            if (r.refiner == null && this.data.money >= this.RefinerPrice)
            {
                r.AddRefiner();
                this.data.RemoveMoney(RefinerPrice);
            }
        }

        public void UpgradeRig(Rig r)
        {
            // upgrade the level of a rig, if they happen to have enough
            if (this.data.money >= RigPrice * 2 * (r.currentLevel) && r.currentLevel < 5)
            {
                this.data.RemoveMoney(RigPrice * 2 * (r.currentLevel));
                r.Upgrade();
            }
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
