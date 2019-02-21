namespace Holdem
{
    partial class Form1
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
            this.nextButton = new System.Windows.Forms.Button();
            this.ComputerLabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.ComputerBalanceLabel = new System.Windows.Forms.Label();
            this.computerBalance = new System.Windows.Forms.Label();
            this.playerBalance = new System.Windows.Forms.Label();
            this.playerBalanceLabel = new System.Windows.Forms.Label();
            this.callButton = new System.Windows.Forms.Button();
            this.foldButton = new System.Windows.Forms.Button();
            this.raiseButton = new System.Windows.Forms.Button();
            this.computerBet = new System.Windows.Forms.Label();
            this.computerBetLabel = new System.Windows.Forms.Label();
            this.playerBet = new System.Windows.Forms.Label();
            this.playerBetLabel = new System.Windows.Forms.Label();
            this.playerHole2 = new System.Windows.Forms.PictureBox();
            this.playerHole1 = new System.Windows.Forms.PictureBox();
            this.shared5 = new System.Windows.Forms.PictureBox();
            this.shared4 = new System.Windows.Forms.PictureBox();
            this.shared3 = new System.Windows.Forms.PictureBox();
            this.shared2 = new System.Windows.Forms.PictureBox();
            this.shared1 = new System.Windows.Forms.PictureBox();
            this.computerHole2 = new System.Windows.Forms.PictureBox();
            this.computerHole1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerHole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerHole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerHole1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(802, 294);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(84, 34);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next Hand";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComputerLabel
            // 
            this.ComputerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerLabel.Location = new System.Drawing.Point(30, 21);
            this.ComputerLabel.Name = "ComputerLabel";
            this.ComputerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComputerLabel.Size = new System.Drawing.Size(116, 39);
            this.ComputerLabel.TabIndex = 10;
            this.ComputerLabel.Text = "Computer";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(30, 297);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlayerLabel.Size = new System.Drawing.Size(116, 39);
            this.PlayerLabel.TabIndex = 11;
            this.PlayerLabel.Text = "Player";
            // 
            // ComputerBalanceLabel
            // 
            this.ComputerBalanceLabel.AutoSize = true;
            this.ComputerBalanceLabel.Location = new System.Drawing.Point(40, 67);
            this.ComputerBalanceLabel.Name = "ComputerBalanceLabel";
            this.ComputerBalanceLabel.Size = new System.Drawing.Size(59, 17);
            this.ComputerBalanceLabel.TabIndex = 12;
            this.ComputerBalanceLabel.Text = "Balance";
            // 
            // computerBalance
            // 
            this.computerBalance.AutoSize = true;
            this.computerBalance.Location = new System.Drawing.Point(117, 67);
            this.computerBalance.Name = "computerBalance";
            this.computerBalance.Size = new System.Drawing.Size(0, 17);
            this.computerBalance.TabIndex = 13;
            // 
            // playerBalance
            // 
            this.playerBalance.AutoSize = true;
            this.playerBalance.Location = new System.Drawing.Point(117, 354);
            this.playerBalance.Name = "playerBalance";
            this.playerBalance.Size = new System.Drawing.Size(0, 17);
            this.playerBalance.TabIndex = 15;
            // 
            // playerBalanceLabel
            // 
            this.playerBalanceLabel.AutoSize = true;
            this.playerBalanceLabel.Location = new System.Drawing.Point(40, 354);
            this.playerBalanceLabel.Name = "playerBalanceLabel";
            this.playerBalanceLabel.Size = new System.Drawing.Size(59, 17);
            this.playerBalanceLabel.TabIndex = 14;
            this.playerBalanceLabel.Text = "Balance";
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(802, 239);
            this.callButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(84, 34);
            this.callButton.TabIndex = 16;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // foldButton
            // 
            this.foldButton.Location = new System.Drawing.Point(802, 186);
            this.foldButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(84, 34);
            this.foldButton.TabIndex = 17;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = true;
            this.foldButton.Click += new System.EventHandler(this.foldButton_Click);
            // 
            // raiseButton
            // 
            this.raiseButton.Location = new System.Drawing.Point(802, 135);
            this.raiseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raiseButton.Name = "raiseButton";
            this.raiseButton.Size = new System.Drawing.Size(84, 34);
            this.raiseButton.TabIndex = 18;
            this.raiseButton.Text = "Raise";
            this.raiseButton.UseVisualStyleBackColor = true;
            this.raiseButton.Click += new System.EventHandler(this.raiseButton_Click);
            // 
            // computerBet
            // 
            this.computerBet.AutoSize = true;
            this.computerBet.Location = new System.Drawing.Point(833, 67);
            this.computerBet.Name = "computerBet";
            this.computerBet.Size = new System.Drawing.Size(0, 17);
            this.computerBet.TabIndex = 20;
            // 
            // computerBetLabel
            // 
            this.computerBetLabel.AutoSize = true;
            this.computerBetLabel.Location = new System.Drawing.Point(756, 67);
            this.computerBetLabel.Name = "computerBetLabel";
            this.computerBetLabel.Size = new System.Drawing.Size(29, 17);
            this.computerBetLabel.TabIndex = 19;
            this.computerBetLabel.Text = "Bet";
            // 
            // playerBet
            // 
            this.playerBet.AutoSize = true;
            this.playerBet.Location = new System.Drawing.Point(833, 354);
            this.playerBet.Name = "playerBet";
            this.playerBet.Size = new System.Drawing.Size(0, 17);
            this.playerBet.TabIndex = 22;
            // 
            // playerBetLabel
            // 
            this.playerBetLabel.AutoSize = true;
            this.playerBetLabel.Location = new System.Drawing.Point(756, 354);
            this.playerBetLabel.Name = "playerBetLabel";
            this.playerBetLabel.Size = new System.Drawing.Size(29, 17);
            this.playerBetLabel.TabIndex = 21;
            this.playerBetLabel.Text = "Bet";
            // 
            // playerHole2
            // 
            this.playerHole2.Location = new System.Drawing.Point(456, 341);
            this.playerHole2.Name = "playerHole2";
            this.playerHole2.Size = new System.Drawing.Size(95, 150);
            this.playerHole2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerHole2.TabIndex = 23;
            this.playerHole2.TabStop = false;
            // 
            // playerHole1
            // 
            this.playerHole1.Location = new System.Drawing.Point(344, 341);
            this.playerHole1.Name = "playerHole1";
            this.playerHole1.Size = new System.Drawing.Size(95, 150);
            this.playerHole1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerHole1.TabIndex = 23;
            this.playerHole1.TabStop = false;
            // 
            // shared5
            // 
            this.shared5.Location = new System.Drawing.Point(604, 178);
            this.shared5.Name = "shared5";
            this.shared5.Size = new System.Drawing.Size(95, 150);
            this.shared5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shared5.TabIndex = 23;
            this.shared5.TabStop = false;
            // 
            // shared4
            // 
            this.shared4.Location = new System.Drawing.Point(503, 178);
            this.shared4.Name = "shared4";
            this.shared4.Size = new System.Drawing.Size(95, 150);
            this.shared4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shared4.TabIndex = 23;
            this.shared4.TabStop = false;
            // 
            // shared3
            // 
            this.shared3.Location = new System.Drawing.Point(402, 178);
            this.shared3.Name = "shared3";
            this.shared3.Size = new System.Drawing.Size(95, 150);
            this.shared3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shared3.TabIndex = 23;
            this.shared3.TabStop = false;
            // 
            // shared2
            // 
            this.shared2.Location = new System.Drawing.Point(301, 178);
            this.shared2.Name = "shared2";
            this.shared2.Size = new System.Drawing.Size(95, 150);
            this.shared2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shared2.TabIndex = 23;
            this.shared2.TabStop = false;
            // 
            // shared1
            // 
            this.shared1.Location = new System.Drawing.Point(200, 178);
            this.shared1.Name = "shared1";
            this.shared1.Size = new System.Drawing.Size(95, 150);
            this.shared1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shared1.TabIndex = 23;
            this.shared1.TabStop = false;
            // 
            // computerHole2
            // 
            this.computerHole2.Location = new System.Drawing.Point(456, 18);
            this.computerHole2.Name = "computerHole2";
            this.computerHole2.Size = new System.Drawing.Size(95, 150);
            this.computerHole2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerHole2.TabIndex = 23;
            this.computerHole2.TabStop = false;
            // 
            // computerHole1
            // 
            this.computerHole1.Location = new System.Drawing.Point(344, 18);
            this.computerHole1.Name = "computerHole1";
            this.computerHole1.Size = new System.Drawing.Size(95, 150);
            this.computerHole1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerHole1.TabIndex = 23;
            this.computerHole1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 517);
            this.Controls.Add(this.playerHole2);
            this.Controls.Add(this.playerHole1);
            this.Controls.Add(this.shared5);
            this.Controls.Add(this.shared4);
            this.Controls.Add(this.shared3);
            this.Controls.Add(this.shared2);
            this.Controls.Add(this.shared1);
            this.Controls.Add(this.computerHole2);
            this.Controls.Add(this.computerHole1);
            this.Controls.Add(this.playerBet);
            this.Controls.Add(this.playerBetLabel);
            this.Controls.Add(this.computerBet);
            this.Controls.Add(this.computerBetLabel);
            this.Controls.Add(this.raiseButton);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.playerBalance);
            this.Controls.Add(this.playerBalanceLabel);
            this.Controls.Add(this.computerBalance);
            this.Controls.Add(this.ComputerBalanceLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.ComputerLabel);
            this.Controls.Add(this.nextButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Texas Hold\'em";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerHole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shared1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerHole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerHole1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label ComputerLabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label ComputerBalanceLabel;
        private System.Windows.Forms.Label computerBalance;
        private System.Windows.Forms.Label playerBalance;
        private System.Windows.Forms.Label playerBalanceLabel;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button foldButton;
        private System.Windows.Forms.Button raiseButton;
        private System.Windows.Forms.Label computerBet;
        private System.Windows.Forms.Label computerBetLabel;
        private System.Windows.Forms.Label playerBet;
        private System.Windows.Forms.Label playerBetLabel;
        private System.Windows.Forms.PictureBox computerHole1;
        private System.Windows.Forms.PictureBox computerHole2;
        private System.Windows.Forms.PictureBox shared1;
        private System.Windows.Forms.PictureBox shared2;
        private System.Windows.Forms.PictureBox shared3;
        private System.Windows.Forms.PictureBox shared4;
        private System.Windows.Forms.PictureBox shared5;
        private System.Windows.Forms.PictureBox playerHole1;
        private System.Windows.Forms.PictureBox playerHole2;
    }
}

