using System.Threading;


namespace OilTycoonGame
{
    public partial class Form1 : Form
    {
        //public System.Windows.Forms.PictureBox generate(System.Windows.Forms.Button button)
        //{
        //    System.Windows.Forms.PictureBox ImageBox = new System.Windows.Forms.PictureBox();
        //    ImageBox.Location = button.Location;
        //    ImageBox.Size = button.Size;
        //    return ImageBox;
        //}

        /// <summary>
        /// here is the main code for running the game
        /// </summary>
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Rig? currentRig;
        private System.Windows.Forms.PictureBox? currentBox;

        private void UpdateMoney()
        {
            this.label1.Text = "MONEY: " + this.player.data.money.ToString();
        }
        private void UpdateRigData()
        {
            MPS_Shower.Text = "$" + currentRig.moneyPerSecond.ToString();
            Level_Shower.Text = currentRig.currentLevel.ToString();
        }
        private void UpdateRigData(Rig? r)
        {
            if (r != null)
            {
                MPS_Shower.Text = "$" + r.moneyPerSecond.ToString();
                Level_Shower.Text = r.currentLevel.ToString();
                currentRig = r;
            }
        }
        private void changeColors(System.Windows.Forms.PictureBox pictureBox)
        {
            if (pictureBox.Visible)
            {
                if (currentBox != null)
                {
                    currentBox.BorderStyle = BorderStyle.None;
                    currentBox.BackColor = Color.Transparent;
                }
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                pictureBox.BackColor = Color.DodgerBlue;
                currentBox = pictureBox;
            }

        }
        private void handleRigClick(System.Windows.Forms.Button btn, System.Windows.Forms.PictureBox newBox)
        {
            Rig? boughtRig = this.player.BuyRig(btn, newBox);
            if (boughtRig != null)
            {
                // they have bought a new box
                // make the outline show so that the player can see the current selected
                newBox.Visible = true;
                btn.Visible = false;
                changeColors(newBox);
                UpdateRigData(boughtRig);

                UpdateMoney();
            }
        }
        private void Startupgame(Object myObject, EventArgs myEventArgs)
        {

            // this is where we startup and do things for the game
            // we then need to give the player all of their money that they have 
            // earned in the last second. adds all of the money to their balance
            int moneyEarned = this.player.GetNextMoneyCollection();

            // update the ui to refelect new money balance
            // this.description.Text = //moneyEarned.ToString();//"MONEY: " + " Test";// + (moneyEarned);

            // label1 is the MONEY:
            // label2 is the RIGS:
            // label3 is the REFINERS:
            UpdateMoney();
            this.label2.Text = "RIGS: " + this.player.rigs.Count.ToString();
            this.label3.Text = "REFINERS: " + this.player.refiners.Count.ToString();
        }

        private void Run()
        {
            timer.Tick += new EventHandler(Startupgame);
            timer.Interval = 1000; // miliseconds
            timer.Start();

        }
        /// //////////////////////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
            Run();
        }

        private void upgradeRig_Click(object sender, EventArgs e) // this is for upgrading the selected rig
        {
            if (currentRig != null)
            {
                this.player.UpgradeRig(currentRig);
                UpdateMoney();
                UpdateRigData();
            }
        }

        private void buyRefiner_Click(object sender, EventArgs e) // buy a refiner for the selected rig rig
        {
            if (currentRig != null)
            {
                this.player.BuyRefiner(currentRig);
                UpdateMoney();
                MPS_Shower.Text = "$" + currentRig.moneyPerSecond.ToString();
            }
        }

        private void BuyARig_1_Click(object sender, EventArgs e) // buy a rig at pos 1
        {
            handleRigClick(this.BuyARig_1, this.RigNumber1);
        }

        private void BuyARig_2_Click(object sender, EventArgs e) // buy a rig at pos 2
        {
            handleRigClick(this.BuyARig_2, this.RigNumber2);
        }

        private void BuyARig_3_Click(object sender, EventArgs e) // buy a rig at pos 3
        {
            handleRigClick(this.BuyARig_3, this.RigNumber3);
        }

        private void BuyARig_4_Click(object sender, EventArgs e) // buy a rig at pos 4
        {
            handleRigClick(this.BuyARig_4, this.RigNumber4);
        }

        private void BuyARig_6_Click(object sender, EventArgs e) // buy a rig at pos 6
        {
            handleRigClick(this.BuyARig_6, this.RigNumber6);
        }

        private void BuyARig_5_Click(object sender, EventArgs e) // buy a rig at pos 5
        {
            handleRigClick(this.BuyARig_5, this.RigNumber5);
        }

        private void sellRig_Click(object sender, EventArgs e) // sell a rig
        {
            // not needed for now
        }

        private void RigNumber1_Click(object sender, EventArgs e)
        {
            Rig? rig = this.player.GetRig(0);
            if (rig != null)
            {
                changeColors(rig!.instance);
                UpdateRigData(rig);
            }
        }

        private void RigNumber2_Click(object sender, EventArgs e)
        {
            Rig? rig = this.player.GetRig(1);
            if (rig != null)
            {
                changeColors(rig.instance);
                UpdateRigData(rig);
            }
        }

        private void RigNumber3_Click(object sender, EventArgs e)
        {
            Rig? rig = this.player.GetRig(2);
            if (rig != null)
            {
                changeColors(rig.instance);
                UpdateRigData(rig);
            }
        }

        private void RigNumber4_Click(object sender, EventArgs e)
        {
            Rig? rig = this.player.GetRig(3);
            if (rig != null)
            {
                changeColors(rig.instance);
                UpdateRigData(rig);
            }
        }

        private void RigNumber5_Click(object sender, EventArgs e)
        {
            Rig? rig = this.player.GetRig(4);
            if (rig != null)
            {
                changeColors(rig.instance);
                UpdateRigData(rig);
            }
        }

        private void RigNumber6_Click(object sender, EventArgs e)
        {
            Rig? rig = this.player.GetRig(5);
            if (rig != null)
            {
                changeColors(rig.instance);
                UpdateRigData(rig);
            }
        }
    }
}