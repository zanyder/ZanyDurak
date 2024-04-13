namespace DurakClient

{
    partial class DurakGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DurakLibrary.Card card1 = new DurakLibrary.Card();
            this.lblHumanPlayer = new System.Windows.Forms.Label();
            this.lblPlayer2Attacking = new System.Windows.Forms.Label();
            this.lblHumanAttacking = new System.Windows.Forms.Label();
            this.lblTrumpCard = new System.Windows.Forms.Label();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.flpComputerHand2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.flpRiver = new System.Windows.Forms.FlowLayoutPanel();
            this.flpHumanHand1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardImageControl1 = new DurakClient.CardImageControl();
            this.flpTrumpCard = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCeaseAttack = new System.Windows.Forms.Button();
            this.lblRoundNum = new System.Windows.Forms.Label();
            this.txtRoundNum = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToMenuFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerWins = new System.Windows.Forms.Label();
            this.georgeWins = new System.Windows.Forms.Label();
            this.bobbyWins = new System.Windows.Forms.Label();
            this.philWins = new System.Windows.Forms.Label();
            this.labelPlayerInfo = new System.Windows.Forms.Label();
            this.labelGeorgeInfo = new System.Windows.Forms.Label();
            this.flpComputerHand2.SuspendLayout();
            this.flpHumanHand1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHumanPlayer
            // 
            this.lblHumanPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHumanPlayer.Location = new System.Drawing.Point(2, 0);
            this.lblHumanPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHumanPlayer.Name = "lblHumanPlayer";
            this.lblHumanPlayer.Size = new System.Drawing.Size(79, 20);
            this.lblHumanPlayer.TabIndex = 1;
            this.lblHumanPlayer.Text = " Player1 Cards";
            this.lblHumanPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Attacking
            // 
            this.lblPlayer2Attacking.AutoEllipsis = true;
            this.lblPlayer2Attacking.BackColor = System.Drawing.Color.DarkOrange;
            this.lblPlayer2Attacking.Location = new System.Drawing.Point(471, 183);
            this.lblPlayer2Attacking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2Attacking.Name = "lblPlayer2Attacking";
            this.lblPlayer2Attacking.Size = new System.Drawing.Size(102, 32);
            this.lblPlayer2Attacking.TabIndex = 4;
            this.lblPlayer2Attacking.Text = " AI Attacking ";
            this.lblPlayer2Attacking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayer2Attacking.Visible = false;
            // 
            // lblHumanAttacking
            // 
            this.lblHumanAttacking.BackColor = System.Drawing.Color.DarkOrange;
            this.lblHumanAttacking.Location = new System.Drawing.Point(471, 477);
            this.lblHumanAttacking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHumanAttacking.Name = "lblHumanAttacking";
            this.lblHumanAttacking.Size = new System.Drawing.Size(102, 32);
            this.lblHumanAttacking.TabIndex = 5;
            this.lblHumanAttacking.Text = "Human Attacking    ";
            this.lblHumanAttacking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrumpCard
            // 
            this.lblTrumpCard.AutoSize = true;
            this.lblTrumpCard.BackColor = System.Drawing.Color.Yellow;
            this.lblTrumpCard.Location = new System.Drawing.Point(220, 430);
            this.lblTrumpCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrumpCard.Name = "lblTrumpCard";
            this.lblTrumpCard.Size = new System.Drawing.Size(68, 13);
            this.lblTrumpCard.TabIndex = 6;
            this.lblTrumpCard.Text = " Trump Card ";
            // 
            // btnPickUp
            // 
            this.btnPickUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPickUp.Location = new System.Drawing.Point(832, 462);
            this.btnPickUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(104, 47);
            this.btnPickUp.TabIndex = 8;
            this.btnPickUp.Text = "&Pick Up Cards";
            this.btnPickUp.UseVisualStyleBackColor = false;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // flpComputerHand2
            // 
            this.flpComputerHand2.BackColor = System.Drawing.Color.SeaGreen;
            this.flpComputerHand2.Controls.Add(this.lblPlayer2Name);
            this.flpComputerHand2.Location = new System.Drawing.Point(261, 29);
            this.flpComputerHand2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpComputerHand2.Name = "flpComputerHand2";
            this.flpComputerHand2.Size = new System.Drawing.Size(527, 150);
            this.flpComputerHand2.TabIndex = 9;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayer2Name.Location = new System.Drawing.Point(2, 0);
            this.lblPlayer2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(79, 20);
            this.lblPlayer2Name.TabIndex = 2;
            this.lblPlayer2Name.Text = " Player2 Cards";
            this.lblPlayer2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpRiver
            // 
            this.flpRiver.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.flpRiver.Location = new System.Drawing.Point(302, 224);
            this.flpRiver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpRiver.Name = "flpRiver";
            this.flpRiver.Size = new System.Drawing.Size(487, 241);
            this.flpRiver.TabIndex = 10;
            // 
            // flpHumanHand1
            // 
            this.flpHumanHand1.BackColor = System.Drawing.Color.SeaGreen;
            this.flpHumanHand1.Controls.Add(this.lblHumanPlayer);
            this.flpHumanHand1.Controls.Add(this.cardImageControl1);
            this.flpHumanHand1.Location = new System.Drawing.Point(266, 512);
            this.flpHumanHand1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpHumanHand1.Name = "flpHumanHand1";
            this.flpHumanHand1.Size = new System.Drawing.Size(527, 150);
            this.flpHumanHand1.TabIndex = 11;
            // 
            // cardImageControl1
            // 
            card1.CardClicked = null;
            this.cardImageControl1.Card = card1;
            this.cardImageControl1.Location = new System.Drawing.Point(85, 2);
            this.cardImageControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardImageControl1.Name = "cardImageControl1";
            this.cardImageControl1.Size = new System.Drawing.Size(53, 78);
            this.cardImageControl1.TabIndex = 2;
            // 
            // flpTrumpCard
            // 
            this.flpTrumpCard.BackColor = System.Drawing.Color.OldLace;
            this.flpTrumpCard.Location = new System.Drawing.Point(216, 292);
            this.flpTrumpCard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpTrumpCard.Name = "flpTrumpCard";
            this.flpTrumpCard.Size = new System.Drawing.Size(82, 112);
            this.flpTrumpCard.TabIndex = 13;
            // 
            // btnCeaseAttack
            // 
            this.btnCeaseAttack.BackColor = System.Drawing.Color.Tomato;
            this.btnCeaseAttack.Location = new System.Drawing.Point(832, 394);
            this.btnCeaseAttack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCeaseAttack.Name = "btnCeaseAttack";
            this.btnCeaseAttack.Size = new System.Drawing.Size(104, 49);
            this.btnCeaseAttack.TabIndex = 19;
            this.btnCeaseAttack.Text = " &Cease Attack";
            this.btnCeaseAttack.UseVisualStyleBackColor = false;
            this.btnCeaseAttack.Click += new System.EventHandler(this.btnCeaseAttack_Click);
            // 
            // lblRoundNum
            // 
            this.lblRoundNum.BackColor = System.Drawing.Color.GreenYellow;
            this.lblRoundNum.Location = new System.Drawing.Point(231, 214);
            this.lblRoundNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoundNum.Name = "lblRoundNum";
            this.lblRoundNum.Size = new System.Drawing.Size(46, 22);
            this.lblRoundNum.TabIndex = 36;
            this.lblRoundNum.Text = "Round   ";
            this.lblRoundNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoundNum
            // 
            this.txtRoundNum.BackColor = System.Drawing.Color.Chartreuse;
            this.txtRoundNum.Location = new System.Drawing.Point(246, 252);
            this.txtRoundNum.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRoundNum.Name = "txtRoundNum";
            this.txtRoundNum.ReadOnly = true;
            this.txtRoundNum.Size = new System.Drawing.Size(22, 20);
            this.txtRoundNum.TabIndex = 37;
            this.txtRoundNum.TextChanged += new System.EventHandler(this.txtRoundNum_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.viewLogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startNewGameToolStripMenuItem.Text = "Start";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToMenuFormToolStripMenuItem});
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewLogToolStripMenuItem.Text = "View ";
            // 
            // goToMenuFormToolStripMenuItem
            // 
            this.goToMenuFormToolStripMenuItem.Name = "goToMenuFormToolStripMenuItem";
            this.goToMenuFormToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.goToMenuFormToolStripMenuItem.Text = "Open Log";
            // 
            // playerWins
            // 
            this.playerWins.Location = new System.Drawing.Point(0, 0);
            this.playerWins.Name = "playerWins";
            this.playerWins.Size = new System.Drawing.Size(100, 23);
            this.playerWins.TabIndex = 3;
            // 
            // georgeWins
            // 
            this.georgeWins.Location = new System.Drawing.Point(0, 0);
            this.georgeWins.Name = "georgeWins";
            this.georgeWins.Size = new System.Drawing.Size(100, 23);
            this.georgeWins.TabIndex = 2;
            // 
            // bobbyWins
            // 
            this.bobbyWins.Location = new System.Drawing.Point(0, 0);
            this.bobbyWins.Name = "bobbyWins";
            this.bobbyWins.Size = new System.Drawing.Size(100, 23);
            this.bobbyWins.TabIndex = 1;
            // 
            // philWins
            // 
            this.philWins.Location = new System.Drawing.Point(0, 0);
            this.philWins.Name = "philWins";
            this.philWins.Size = new System.Drawing.Size(100, 23);
            this.philWins.TabIndex = 0;
            // 
            // labelPlayerInfo
            // 
            this.labelPlayerInfo.AutoSize = true;
            this.labelPlayerInfo.Location = new System.Drawing.Point(271, 493);
            this.labelPlayerInfo.Name = "labelPlayerInfo";
            this.labelPlayerInfo.Size = new System.Drawing.Size(66, 13);
            this.labelPlayerInfo.TabIndex = 46;
            this.labelPlayerInfo.Text = "Player Wins:";
            // 
            // labelGeorgeInfo
            // 
            this.labelGeorgeInfo.AutoSize = true;
            this.labelGeorgeInfo.Location = new System.Drawing.Point(266, 186);
            this.labelGeorgeInfo.Name = "labelGeorgeInfo";
            this.labelGeorgeInfo.Size = new System.Drawing.Size(72, 13);
            this.labelGeorgeInfo.TabIndex = 47;
            this.labelGeorgeInfo.Text = "George Wins:";
            // 
            // DurakGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakClient.Properties.Resources.dec31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 662);
            this.Controls.Add(this.labelGeorgeInfo);
            this.Controls.Add(this.labelPlayerInfo);
            this.Controls.Add(this.philWins);
            this.Controls.Add(this.bobbyWins);
            this.Controls.Add(this.georgeWins);
            this.Controls.Add(this.playerWins);
            this.Controls.Add(this.txtRoundNum);
            this.Controls.Add(this.lblRoundNum);
            this.Controls.Add(this.btnCeaseAttack);
            this.Controls.Add(this.flpTrumpCard);
            this.Controls.Add(this.flpHumanHand1);
            this.Controls.Add(this.flpRiver);
            this.Controls.Add(this.flpComputerHand2);
            this.Controls.Add(this.btnPickUp);
            this.Controls.Add(this.lblTrumpCard);
            this.Controls.Add(this.lblHumanAttacking);
            this.Controls.Add(this.lblPlayer2Attacking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1026, 709);
            this.MinimumSize = new System.Drawing.Size(1026, 681);
            this.Name = "DurakGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak | Game";
            this.Load += new System.EventHandler(this.DurakClientForm_Load);
            this.flpComputerHand2.ResumeLayout(false);
            this.flpHumanHand1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHumanPlayer;
        private System.Windows.Forms.Label lblPlayer2Attacking;
        private System.Windows.Forms.Label lblHumanAttacking;
        private System.Windows.Forms.Label lblTrumpCard;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.FlowLayoutPanel flpComputerHand2;
        private System.Windows.Forms.FlowLayoutPanel flpRiver;
        private System.Windows.Forms.FlowLayoutPanel flpHumanHand1;
        private System.Windows.Forms.FlowLayoutPanel flpTrumpCard;
        private System.Windows.Forms.Button btnCeaseAttack;
        private System.Windows.Forms.Label lblRoundNum;
        private System.Windows.Forms.TextBox txtRoundNum;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToMenuFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label playerWins;
        private System.Windows.Forms.Label georgeWins;
        private System.Windows.Forms.Label bobbyWins;
        private System.Windows.Forms.Label philWins;
        private CardImageControl cardImageControl1;
        private System.Windows.Forms.Label labelPlayerInfo;
        private System.Windows.Forms.Label labelGeorgeInfo;
    }
}