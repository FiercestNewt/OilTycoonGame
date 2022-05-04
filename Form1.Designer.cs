using System.Threading;

namespace OilTycoonGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Player player = new Player();
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellRig = new System.Windows.Forms.Button();
            this.buyRefiner = new System.Windows.Forms.Button();
            this.upgradeRig = new System.Windows.Forms.Button();
            this.Level_Shower = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.MPS_Shower = new System.Windows.Forms.Label();
            this.moneyPerSecondLbl = new System.Windows.Forms.Label();
            this.BuyARig_1 = new System.Windows.Forms.Button();
            this.BuyARig_2 = new System.Windows.Forms.Button();
            this.BuyARig_3 = new System.Windows.Forms.Button();
            this.BuyARig_4 = new System.Windows.Forms.Button();
            this.ButARig_5 = new System.Windows.Forms.Button();
            this.BuyARig_6 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.RigNumber1 = new System.Windows.Forms.PictureBox();
            this.RigNumber2 = new System.Windows.Forms.PictureBox();
            this.RigNumber3 = new System.Windows.Forms.PictureBox();
            this.RigNumber4 = new System.Windows.Forms.PictureBox();
            this.RigNumber5 = new System.Windows.Forms.PictureBox();
            this.RigNumber6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::OilTycoonGame.Properties.Resources.Bkg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ImageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImageLabel.Location = new System.Drawing.Point(4, 7);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(104, 17);
            this.ImageLabel.TabIndex = 1;
            this.ImageLabel.Text = "Your Tycoon Stats";
            this.ImageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "MONEY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "RIGS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = " REFINERS:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statsPanel
            // 
            this.statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsPanel.Controls.Add(this.label3);
            this.statsPanel.Controls.Add(this.ImageLabel);
            this.statsPanel.Controls.Add(this.label2);
            this.statsPanel.Controls.Add(this.label1);
            this.statsPanel.Location = new System.Drawing.Point(529, 23);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(115, 144);
            this.statsPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "RIG \r\nSTATS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sellRig);
            this.panel1.Controls.Add(this.buyRefiner);
            this.panel1.Controls.Add(this.upgradeRig);
            this.panel1.Controls.Add(this.Level_Shower);
            this.panel1.Controls.Add(this.LevelLabel);
            this.panel1.Controls.Add(this.MPS_Shower);
            this.panel1.Controls.Add(this.moneyPerSecondLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(4, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 61);
            this.panel1.TabIndex = 7;
            // 
            // sellRig
            // 
            this.sellRig.Location = new System.Drawing.Point(427, 21);
            this.sellRig.Name = "sellRig";
            this.sellRig.Size = new System.Drawing.Size(76, 23);
            this.sellRig.TabIndex = 13;
            this.sellRig.Text = "Sell";
            this.sellRig.UseVisualStyleBackColor = true;
            this.sellRig.Click += new System.EventHandler(this.sellRig_Click);
            // 
            // buyRefiner
            // 
            this.buyRefiner.Location = new System.Drawing.Point(346, 21);
            this.buyRefiner.Name = "buyRefiner";
            this.buyRefiner.Size = new System.Drawing.Size(75, 23);
            this.buyRefiner.TabIndex = 12;
            this.buyRefiner.Text = "Buy Refiner";
            this.buyRefiner.UseVisualStyleBackColor = true;
            this.buyRefiner.Click += new System.EventHandler(this.buyRefiner_Click);
            // 
            // upgradeRig
            // 
            this.upgradeRig.Location = new System.Drawing.Point(265, 21);
            this.upgradeRig.Name = "upgradeRig";
            this.upgradeRig.Size = new System.Drawing.Size(75, 23);
            this.upgradeRig.TabIndex = 11;
            this.upgradeRig.Text = "Upgrade ";
            this.upgradeRig.UseVisualStyleBackColor = true;
            this.upgradeRig.Click += new System.EventHandler(this.upgradeRig_Click);
            // 
            // Level_Shower
            // 
            this.Level_Shower.AutoSize = true;
            this.Level_Shower.Location = new System.Drawing.Point(218, 32);
            this.Level_Shower.Name = "Level_Shower";
            this.Level_Shower.Size = new System.Drawing.Size(13, 15);
            this.Level_Shower.TabIndex = 10;
            this.Level_Shower.Text = "0";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(206, 9);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(37, 15);
            this.LevelLabel.TabIndex = 9;
            this.LevelLabel.Text = "Level:";
            // 
            // MPS_Shower
            // 
            this.MPS_Shower.AutoSize = true;
            this.MPS_Shower.Location = new System.Drawing.Point(111, 34);
            this.MPS_Shower.Name = "MPS_Shower";
            this.MPS_Shower.Size = new System.Drawing.Size(19, 15);
            this.MPS_Shower.TabIndex = 8;
            this.MPS_Shower.Text = "$0";
            // 
            // moneyPerSecondLbl
            // 
            this.moneyPerSecondLbl.AutoSize = true;
            this.moneyPerSecondLbl.Location = new System.Drawing.Point(82, 9);
            this.moneyPerSecondLbl.Name = "moneyPerSecondLbl";
            this.moneyPerSecondLbl.Size = new System.Drawing.Size(109, 15);
            this.moneyPerSecondLbl.TabIndex = 7;
            this.moneyPerSecondLbl.Text = "Money Per Second:";
            // 
            // BuyARig_1
            // 
            this.BuyARig_1.Location = new System.Drawing.Point(42, 133);
            this.BuyARig_1.Name = "BuyARig_1";
            this.BuyARig_1.Size = new System.Drawing.Size(81, 38);
            this.BuyARig_1.TabIndex = 8;
            this.BuyARig_1.Text = "BUY A NEW RIG";
            this.BuyARig_1.UseVisualStyleBackColor = true;
            this.BuyARig_1.Click += new System.EventHandler(this.BuyARig_1_Click);
            // 
            // BuyARig_2
            // 
            this.BuyARig_2.Location = new System.Drawing.Point(54, 283);
            this.BuyARig_2.Name = "BuyARig_2";
            this.BuyARig_2.Size = new System.Drawing.Size(81, 38);
            this.BuyARig_2.TabIndex = 9;
            this.BuyARig_2.Text = "BUY A NEW RIG";
            this.BuyARig_2.UseVisualStyleBackColor = true;
            this.BuyARig_2.Click += new System.EventHandler(this.BuyARig_2_Click);
            // 
            // BuyARig_3
            // 
            this.BuyARig_3.Location = new System.Drawing.Point(179, 413);
            this.BuyARig_3.Name = "BuyARig_3";
            this.BuyARig_3.Size = new System.Drawing.Size(81, 38);
            this.BuyARig_3.TabIndex = 10;
            this.BuyARig_3.Text = "BUY A NEW RIG";
            this.BuyARig_3.UseVisualStyleBackColor = true;
            this.BuyARig_3.Click += new System.EventHandler(this.BuyARig_3_Click);
            // 
            // BuyARig_4
            // 
            this.BuyARig_4.Location = new System.Drawing.Point(297, 224);
            this.BuyARig_4.Name = "BuyARig_4";
            this.BuyARig_4.Size = new System.Drawing.Size(81, 38);
            this.BuyARig_4.TabIndex = 11;
            this.BuyARig_4.Text = "BUY A NEW RIG";
            this.BuyARig_4.UseVisualStyleBackColor = true;
            this.BuyARig_4.Click += new System.EventHandler(this.BuyARig_4_Click);
            // 
            // ButARig_5
            // 
            this.ButARig_5.Location = new System.Drawing.Point(314, 59);
            this.ButARig_5.Name = "ButARig_5";
            this.ButARig_5.Size = new System.Drawing.Size(81, 38);
            this.ButARig_5.TabIndex = 12;
            this.ButARig_5.Text = "BUY A NEW RIG";
            this.ButARig_5.UseVisualStyleBackColor = true;
            this.ButARig_5.Click += new System.EventHandler(this.ButARig_5_Click);
            // 
            // BuyARig_6
            // 
            this.BuyARig_6.Location = new System.Drawing.Point(363, 377);
            this.BuyARig_6.Name = "BuyARig_6";
            this.BuyARig_6.Size = new System.Drawing.Size(81, 38);
            this.BuyARig_6.TabIndex = 13;
            this.BuyARig_6.Text = "BUY A NEW RIG";
            this.BuyARig_6.UseVisualStyleBackColor = true;
            this.BuyARig_6.Click += new System.EventHandler(this.BuyARig_6_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(518, 195);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(142, 180);
            this.description.TabIndex = 14;
            this.description.Text = resources.GetString("description.Text");
            // 
            // RigNumber1
            // 
            this.RigNumber1.BackColor = System.Drawing.Color.Transparent;
            this.RigNumber1.BackgroundImage = global::OilTycoonGame.Properties.Resources.Level1;
            this.RigNumber1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RigNumber1.Location = new System.Drawing.Point(50, 120);
            this.RigNumber1.Name = "RigNumber1";
            this.RigNumber1.Size = new System.Drawing.Size(66, 66);
            this.RigNumber1.TabIndex = 15;
            this.RigNumber1.TabStop = false;
            this.RigNumber1.Visible = false;
            this.RigNumber1.Click += new System.EventHandler(this.RigNumber1_Click);
            // 
            // RigNumber2
            // 
            this.RigNumber2.BackColor = System.Drawing.Color.Transparent;
            this.RigNumber2.BackgroundImage = global::OilTycoonGame.Properties.Resources.Level1;
            this.RigNumber2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RigNumber2.Location = new System.Drawing.Point(61, 270);
            this.RigNumber2.Name = "RigNumber2";
            this.RigNumber2.Size = new System.Drawing.Size(66, 66);
            this.RigNumber2.TabIndex = 16;
            this.RigNumber2.TabStop = false;
            this.RigNumber2.Visible = false;
            this.RigNumber2.Click += new System.EventHandler(this.RigNumber2_Click);
            // 
            // RigNumber3
            // 
            this.RigNumber3.BackColor = System.Drawing.Color.Transparent;
            this.RigNumber3.BackgroundImage = global::OilTycoonGame.Properties.Resources.Level1;
            this.RigNumber3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RigNumber3.Location = new System.Drawing.Point(187, 402);
            this.RigNumber3.Name = "RigNumber3";
            this.RigNumber3.Size = new System.Drawing.Size(66, 66);
            this.RigNumber3.TabIndex = 17;
            this.RigNumber3.TabStop = false;
            this.RigNumber3.Visible = false;
            this.RigNumber3.Click += new System.EventHandler(this.RigNumber3_Click);
            // 
            // RigNumber4
            // 
            this.RigNumber4.BackColor = System.Drawing.Color.Transparent;
            this.RigNumber4.BackgroundImage = global::OilTycoonGame.Properties.Resources.Level1;
            this.RigNumber4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RigNumber4.Location = new System.Drawing.Point(305, 209);
            this.RigNumber4.Name = "RigNumber4";
            this.RigNumber4.Size = new System.Drawing.Size(66, 66);
            this.RigNumber4.TabIndex = 18;
            this.RigNumber4.TabStop = false;
            this.RigNumber4.Visible = false;
            this.RigNumber4.Click += new System.EventHandler(this.RigNumber4_Click);
            // 
            // RigNumber5
            // 
            this.RigNumber5.BackColor = System.Drawing.Color.Transparent;
            this.RigNumber5.BackgroundImage = global::OilTycoonGame.Properties.Resources.Level1;
            this.RigNumber5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RigNumber5.Location = new System.Drawing.Point(322, 44);
            this.RigNumber5.Name = "RigNumber5";
            this.RigNumber5.Size = new System.Drawing.Size(66, 66);
            this.RigNumber5.TabIndex = 19;
            this.RigNumber5.TabStop = false;
            this.RigNumber5.Visible = false;
            this.RigNumber5.Click += new System.EventHandler(this.RigNumber5_Click);
            // 
            // RigNumber6
            // 
            this.RigNumber6.BackColor = System.Drawing.Color.Transparent;
            this.RigNumber6.BackgroundImage = global::OilTycoonGame.Properties.Resources.Level1;
            this.RigNumber6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RigNumber6.Location = new System.Drawing.Point(370, 364);
            this.RigNumber6.Name = "RigNumber6";
            this.RigNumber6.Size = new System.Drawing.Size(66, 66);
            this.RigNumber6.TabIndex = 20;
            this.RigNumber6.TabStop = false;
            this.RigNumber6.Visible = false;
            this.RigNumber6.Click += new System.EventHandler(this.RigNumber6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(661, 591);
            this.Controls.Add(this.RigNumber6);
            this.Controls.Add(this.RigNumber5);
            this.Controls.Add(this.RigNumber4);
            this.Controls.Add(this.RigNumber3);
            this.Controls.Add(this.RigNumber2);
            this.Controls.Add(this.RigNumber1);
            this.Controls.Add(this.BuyARig_1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.BuyARig_6);
            this.Controls.Add(this.ButARig_5);
            this.Controls.Add(this.BuyARig_4);
            this.Controls.Add(this.BuyARig_3);
            this.Controls.Add(this.BuyARig_2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statsPanel);
            this.MaximumSize = new System.Drawing.Size(677, 630);
            this.MinimumSize = new System.Drawing.Size(677, 630);
            this.Name = "Form1";
            this.Text = "Oil Tycoon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigNumber6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label ImageLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel statsPanel;
        private Label label4;
        private Panel panel1;
        private Label moneyPerSecondLbl;
        private Label MPS_Shower;
        private Label Level_Shower;
        private Label LevelLabel;
        private Button buyRefiner;
        private Button upgradeRig;
        private Button BuyARig_1;
        private Button BuyARig_2;
        private Button BuyARig_3;
        private Button BuyARig_4;
        private Button ButARig_5;
        private Button BuyARig_6;
        private Label description;
        private Button sellRig;
        private PictureBox RigNumber1;
        private PictureBox RigNumber2;
        private PictureBox RigNumber3;
        private PictureBox RigNumber4;
        private PictureBox RigNumber5;
        private PictureBox RigNumber6;
    }
}