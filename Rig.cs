using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OilTycoonGame
{
    internal class Rig
    {
        public int moneyPerSecond = 5;
        public int currentLevel = 1;
        private Refiner? refiner = null;
        private int totalMoneyEarned = 0;
        private System.Drawing.Bitmap? image = null;
        private System.Windows.Forms.Button? button = null;

        public Rig(System.Drawing.Bitmap rigImage, System.Windows.Forms.Button rigBtn)
        {
            this.image = rigImage;
            this.button = rigBtn;
        }

        // sell a rig and get some money for it based on its level
        public static int Sell() 
        {
            return 5; // return an amount based on a rigs level
        }
        public void Upgrade() 
        {
            // upgrade a refiner here
            // the max level is 5
            if(this.currentLevel < 5)
            {
                this.currentLevel++;
                this.moneyPerSecond = this.currentLevel ^ 2 + 5;
                this.ChangeImage();
            }

        }
        public void AddRefiner()
        {
            if (this.refiner == null)
            {
             this.refiner = new Refiner();
            }
        }
        public void ChangeImage()
        {
            // images are named lke so:
            // Level1, Level2, Level3, Level4, Level5
            // images will need to be made larger later
            if (this.currentLevel == 2) // start on level two because it auto starts on 1
            {
                this.image = global::OilTycoonGame.Properties.Resources.Level2;
            }
            else if (this.currentLevel == 3)
            {
                this.image = global::OilTycoonGame.Properties.Resources.Level3;
            }
            else if (this.currentLevel == 4)
            {
                this.image = global::OilTycoonGame.Properties.Resources.Level4;
            }
            else if (this.currentLevel == 5)
            {
                this.image = global::OilTycoonGame.Properties.Resources.Level5;
            }
            // just to shut up the intellesese. I know I slaughtered that. and that. lol...
            if(this.button != null)
            {
                this.button.Image = this.image;
            }
            
        }
        public int GetMoney()
        {
            if (this.refiner != null)
            {
                // there is a refiner attatched
                int money = this.moneyPerSecond * refiner.multiplier;
                this.totalMoneyEarned += money;
                return money;
            }
            this.totalMoneyEarned += this.moneyPerSecond;
            return this.moneyPerSecond;
        }
    }
}
