namespace RockPaperAndScissors.Src.Game.View
{
    partial class PlayerVsComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerVsComputer));
            this.PlayerOneImage = new System.Windows.Forms.PictureBox();
            this.PlayerTwoImage = new System.Windows.Forms.PictureBox();
            this.fightButton = new System.Windows.Forms.Button();
            this.weaponsCBX = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.labelLooser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerOneImage
            // 
            this.PlayerOneImage.Image = ((System.Drawing.Image)(resources.GetObject("PlayerOneImage.Image")));
            this.PlayerOneImage.Location = new System.Drawing.Point(72, 87);
            this.PlayerOneImage.Name = "PlayerOneImage";
            this.PlayerOneImage.Size = new System.Drawing.Size(121, 122);
            this.PlayerOneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerOneImage.TabIndex = 0;
            this.PlayerOneImage.TabStop = false;
            // 
            // PlayerTwoImage
            // 
            this.PlayerTwoImage.Image = ((System.Drawing.Image)(resources.GetObject("PlayerTwoImage.Image")));
            this.PlayerTwoImage.Location = new System.Drawing.Point(385, 87);
            this.PlayerTwoImage.Name = "PlayerTwoImage";
            this.PlayerTwoImage.Size = new System.Drawing.Size(121, 122);
            this.PlayerTwoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTwoImage.TabIndex = 0;
            this.PlayerTwoImage.TabStop = false;
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(231, 130);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(117, 50);
            this.fightButton.TabIndex = 1;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.FightButtonClickEventHandler);
            // 
            // weaponsCBX
            // 
            this.weaponsCBX.FormattingEnabled = true;
            this.weaponsCBX.Location = new System.Drawing.Point(72, 216);
            this.weaponsCBX.Name = "weaponsCBX";
            this.weaponsCBX.Size = new System.Drawing.Size(121, 21);
            this.weaponsCBX.Sorted = true;
            this.weaponsCBX.TabIndex = 2;
            this.weaponsCBX.SelectedIndexChanged += new System.EventHandler(this.SelecteWeaponHandler);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Location = new System.Drawing.Point(545, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 35);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClickHandler);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(351, 301);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(113, 30);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButtonClickHandler);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(470, 301);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(113, 30);
            this.mainMenuButton.TabIndex = 1;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButtonClickHandler);
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.winnerLabel.Location = new System.Drawing.Point(72, 87);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(86, 24);
            this.winnerLabel.TabIndex = 14;
            this.winnerLabel.Text = "WINNER";
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Location = new System.Drawing.Point(72, 68);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(59, 13);
            this.labelPlayerOne.TabIndex = 15;
            this.labelPlayerOne.Text = "Player One";
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Location = new System.Drawing.Point(382, 68);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(60, 13);
            this.labelPlayerTwo.TabIndex = 15;
            this.labelPlayerTwo.Text = "Player Two";
            // 
            // labelLooser
            // 
            this.labelLooser.AutoSize = true;
            this.labelLooser.BackColor = System.Drawing.Color.Crimson;
            this.labelLooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLooser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLooser.Location = new System.Drawing.Point(381, 87);
            this.labelLooser.Name = "labelLooser";
            this.labelLooser.Size = new System.Drawing.Size(68, 24);
            this.labelLooser.TabIndex = 14;
            this.labelLooser.Text = "Looser";
            // 
            // PlayerVsComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(595, 343);
            this.Controls.Add(this.labelPlayerTwo);
            this.Controls.Add(this.labelPlayerOne);
            this.Controls.Add(this.labelLooser);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.weaponsCBX);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.PlayerTwoImage);
            this.Controls.Add(this.PlayerOneImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerVsComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.LoadHandler);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerOneImage;
        private System.Windows.Forms.PictureBox PlayerTwoImage;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.ComboBox weaponsCBX;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.Label labelLooser;
    }
}