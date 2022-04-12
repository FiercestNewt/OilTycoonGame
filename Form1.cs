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

        public Form1()
        {
            InitializeComponent();
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
            description.Text += "testing";
        }
    }
}