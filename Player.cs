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
        }

        public void UpgradeRig(Rig r)
        {

        }
    }
}
