using System;
using RockPaperAndScissors.Src.Game.Core;

namespace RockPaperAndScissors.Src.Game.View
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.PvCButton = new System.Windows.Forms.Button();
            this.CvCButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.advRulesCX = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoImage.ErrorImage = null;
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoImage.InitialImage")));
            this.logoImage.Location = new System.Drawing.Point(155, 12);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(287, 203);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // PvCButton
            // 
            this.PvCButton.Location = new System.Drawing.Point(226, 221);
            this.PvCButton.Name = "PvCButton";
            this.PvCButton.Size = new System.Drawing.Size(144, 36);
            this.PvCButton.TabIndex = 1;
            this.PvCButton.Text = "Player vs Computer";
            this.PvCButton.UseVisualStyleBackColor = true;
            this.PvCButton.Click += new System.EventHandler(this.PlayerVsComputerEventHandler);
            // 
            // CvCButton
            // 
            this.CvCButton.Location = new System.Drawing.Point(226, 263);
            this.CvCButton.Name = "CvCButton";
            this.CvCButton.Size = new System.Drawing.Size(144, 36);
            this.CvCButton.TabIndex = 2;
            this.CvCButton.Text = "Computer vs Computer";
            this.CvCButton.UseVisualStyleBackColor = true;
            this.CvCButton.Click += new System.EventHandler(this.ComputerVsComputerEventHandler);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Location = new System.Drawing.Point(545, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 35);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClickHandler);
            // 
            // advRulesCX
            // 
            this.advRulesCX.AutoSize = true;
            this.advRulesCX.Location = new System.Drawing.Point(245, 308);
            this.advRulesCX.Name = "advRulesCX";
            this.advRulesCX.Size = new System.Drawing.Size(105, 17);
            this.advRulesCX.TabIndex = 3;
            this.advRulesCX.Text = "Advanced Rules";
            this.advRulesCX.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 343);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.advRulesCX);
            this.Controls.Add(this.CvCButton);
            this.Controls.Add(this.PvCButton);
            this.Controls.Add(this.logoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Button PvCButton;
        private System.Windows.Forms.Button CvCButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox advRulesCX;

       
    }
}