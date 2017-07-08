namespace RockPaperAndScissors.Src.Game.View
{
    partial class ComputerVsComputer
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
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelLooser = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.fightButton = new System.Windows.Forms.Button();
            this.PlayerTwoImage = new System.Windows.Forms.PictureBox();
            this.PlayerOneImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Location = new System.Drawing.Point(345, 51);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(60, 13);
            this.labelPlayerTwo.TabIndex = 25;
            this.labelPlayerTwo.Text = "Player Two";
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Location = new System.Drawing.Point(35, 51);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(59, 13);
            this.labelPlayerOne.TabIndex = 26;
            this.labelPlayerOne.Text = "Player One";
            // 
            // labelLooser
            // 
            this.labelLooser.AutoSize = true;
            this.labelLooser.BackColor = System.Drawing.Color.Crimson;
            this.labelLooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLooser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLooser.Location = new System.Drawing.Point(344, 70);
            this.labelLooser.Name = "labelLooser";
            this.labelLooser.Size = new System.Drawing.Size(68, 24);
            this.labelLooser.TabIndex = 23;
            this.labelLooser.Text = "Looser";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.winnerLabel.Location = new System.Drawing.Point(35, 70);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(86, 24);
            this.winnerLabel.TabIndex = 24;
            this.winnerLabel.Text = "WINNER";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Image = global::RockPaperAndScissors.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(505, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 35);
            this.closeButton.TabIndex = 22;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClickHandler);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(430, 262);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(113, 30);
            this.mainMenuButton.TabIndex = 18;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(311, 262);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(113, 30);
            this.restartButton.TabIndex = 19;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButtonClickHandler);
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(194, 113);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(117, 50);
            this.fightButton.TabIndex = 20;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.FightButtonClickEventHandler);
            // 
            // PlayerTwoImage
            // 
            this.PlayerTwoImage.Image = global::RockPaperAndScissors.Properties.Resources.logo;
            this.PlayerTwoImage.Location = new System.Drawing.Point(348, 70);
            this.PlayerTwoImage.Name = "PlayerTwoImage";
            this.PlayerTwoImage.Size = new System.Drawing.Size(121, 122);
            this.PlayerTwoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTwoImage.TabIndex = 16;
            this.PlayerTwoImage.TabStop = false;
            // 
            // PlayerOneImage
            // 
            this.PlayerOneImage.Image = global::RockPaperAndScissors.Properties.Resources.logo;
            this.PlayerOneImage.Location = new System.Drawing.Point(35, 70);
            this.PlayerOneImage.Name = "PlayerOneImage";
            this.PlayerOneImage.Size = new System.Drawing.Size(121, 122);
            this.PlayerOneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerOneImage.TabIndex = 17;
            this.PlayerOneImage.TabStop = false;
            // 
            // ComputerVsComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 304);
            this.Controls.Add(this.labelPlayerTwo);
            this.Controls.Add(this.labelPlayerOne);
            this.Controls.Add(this.labelLooser);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.PlayerTwoImage);
            this.Controls.Add(this.PlayerOneImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComputerVsComputer";
            this.Text = "ComputerVsComputer";
            this.Load += new System.EventHandler(this.LoadHandler);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.Label labelLooser;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.PictureBox PlayerTwoImage;
        private System.Windows.Forms.PictureBox PlayerOneImage;
    }
}