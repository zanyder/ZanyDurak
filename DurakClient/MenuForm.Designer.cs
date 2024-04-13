namespace DurakClient
{
    partial class MenuForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGameRules = new System.Windows.Forms.Button();
            this.lblDeckSize = new System.Windows.Forms.Label();
            this.rbnDSize36 = new System.Windows.Forms.RadioButton();
            this.rbnDSize52 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGameLog = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(222, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 22);
            this.txtName.TabIndex = 37;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(50, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 31);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Enter Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(117, 468);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 50);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Aquamarine;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(117, 264);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(201, 57);
            this.btnStart.TabIndex = 45;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGameRules
            // 
            this.btnGameRules.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGameRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameRules.Location = new System.Drawing.Point(117, 336);
            this.btnGameRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGameRules.Name = "btnGameRules";
            this.btnGameRules.Size = new System.Drawing.Size(201, 53);
            this.btnGameRules.TabIndex = 46;
            this.btnGameRules.Text = "Game Rules";
            this.btnGameRules.UseVisualStyleBackColor = false;
            this.btnGameRules.Click += new System.EventHandler(this.btnGameRules_Click);
            // 
            // lblDeckSize
            // 
            this.lblDeckSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckSize.Location = new System.Drawing.Point(62, 125);
            this.lblDeckSize.Name = "lblDeckSize";
            this.lblDeckSize.Size = new System.Drawing.Size(143, 31);
            this.lblDeckSize.TabIndex = 53;
            this.lblDeckSize.Text = "Deck Size";
            this.lblDeckSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbnDSize36
            // 
            this.rbnDSize36.AutoSize = true;
            this.rbnDSize36.Checked = true;
            this.rbnDSize36.Location = new System.Drawing.Point(20, 5);
            this.rbnDSize36.Name = "rbnDSize36";
            this.rbnDSize36.Size = new System.Drawing.Size(42, 20);
            this.rbnDSize36.TabIndex = 55;
            this.rbnDSize36.TabStop = true;
            this.rbnDSize36.Text = "36";
            this.rbnDSize36.UseVisualStyleBackColor = true;
            // 
            // rbnDSize52
            // 
            this.rbnDSize52.AutoSize = true;
            this.rbnDSize52.Location = new System.Drawing.Point(96, 3);
            this.rbnDSize52.Name = "rbnDSize52";
            this.rbnDSize52.Size = new System.Drawing.Size(42, 20);
            this.rbnDSize52.TabIndex = 56;
            this.rbnDSize52.Text = "52";
            this.rbnDSize52.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbnDSize36);
            this.panel3.Controls.Add(this.rbnDSize52);
            this.panel3.Location = new System.Drawing.Point(222, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 28);
            this.panel3.TabIndex = 59;
            // 
            // btnGameLog
            // 
            this.btnGameLog.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGameLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameLog.Location = new System.Drawing.Point(117, 402);
            this.btnGameLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGameLog.Name = "btnGameLog";
            this.btnGameLog.Size = new System.Drawing.Size(201, 53);
            this.btnGameLog.TabIndex = 60;
            this.btnGameLog.Text = "Game Log";
            this.btnGameLog.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(455, 565);
            this.Controls.Add(this.btnGameLog);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblDeckSize);
            this.Controls.Add(this.btnGameRules);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(473, 612);
            this.MinimumSize = new System.Drawing.Size(473, 612);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak | Main Menu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGameRules;
        private System.Windows.Forms.Label lblDeckSize;
        private System.Windows.Forms.RadioButton rbnDSize36;
        private System.Windows.Forms.RadioButton rbnDSize52;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGameLog;
    }
}