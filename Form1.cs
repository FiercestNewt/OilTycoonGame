using System.Threading;


namespace OilTycoonGame
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.PictureBox generate(System.Windows.Forms.Button button)
        {
            System.Windows.Forms.PictureBox ImageBox = new System.Windows.Forms.PictureBox();
            ImageBox.Location = button.Location;
            ImageBox.Size = button.Size;
            return ImageBox;
        }

        /// <summary>
        /// here is the main code for running the game
        /// </summary>
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool shouldContinue = true;
        private int timesRun;
        private void Startupgame(Object myObject, EventArgs myEventArgs)
        {
            //timer.Stop();

            // this is where we startup and do things for the game
            // we then need to give the player all of their money that they have 
            // earned in the last second. adds all of the money to their balance
            int moneyEarned = this.player.GetNextMoneyCollection();

            // update the ui to refelect new money balance
            this.description.Text = moneyEarned.ToString();//"MONEY: " + " Test";// + (moneyEarned);
            
            if (timesRun > 10)
            {
                shouldContinue = false;
            }
            else
            {
                timer.Enabled = true;
            }

        }

        private void Run()
        {
            timer.Tick += new EventHandler(Startupgame);
            timer.Interval = 1000; // miliseconds
            timer.Start();

            timesRun++;
            //while (shouldContinue)
            //{
            //    //Application.DoEvents();
            //}

    }
        /// //////////////////////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
            Run();
        }

        private void upgradeRig_Click(object sender, EventArgs e) // this is for upgrading the selected rig
        {

        }

        private void buyRefiner_Click(object sender, EventArgs e) // buy a refiner for the selected rig rig
        {

        }

        private void BuyARig_1_Click(object sender, EventArgs e) // buy a rig at pos 1
        {
            //System.Windows.Forms.PictureBox image = generate(this.BuyARig_1);
            //this.BuyARig_1.Visible = false;
            //image.Image = global::OilTycoonGame.Properties.Resources.Level2;
        }

        private void BuyARig_2_Click(object sender, EventArgs e) // buy a rig at pos 2
        {

        }

        private void BuyARig_3_Click(object sender, EventArgs e) // buy a rig at pos 3
        {

        }

        private void BuyARig_4_Click(object sender, EventArgs e) // buy a rig at pos 4
        {

        }

        private void BuyARig_6_Click(object sender, EventArgs e) // buy a rig at pos 6
        {

        }

        private void ButARig_5_Click(object sender, EventArgs e) // buy a rig at pos 5
        {

        }

        private void sellRig_Click(object sender, EventArgs e) // sell a rig
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.description.Text += "testing";
        }
    }
}