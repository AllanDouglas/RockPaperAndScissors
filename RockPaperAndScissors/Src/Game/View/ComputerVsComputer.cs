using RockPaperAndScissors.Src.Game.Core;
using RockPaperAndScissors.Src.Game.Rules;
using RockPaperAndScissors.Src.Game.Weapons;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperAndScissors.Src.Game.View
{
    /// <summary>
    /// CvsC Game View
    /// </summary>
    partial class ComputerVsComputer : Form, IGameView
    {

        /// <summary>
        /// Game Mode for this view
        /// </summary>
        public IGameMode GameMode { get; private set; }

        /// <summary>
        /// Main contructor
        /// </summary>
        public ComputerVsComputer(IRule rule)
        {
            // get game mode instance
            this.GameMode = ComputerVSComputer.Instance;
            // setupe the game mode
            this.GameMode.Setup(rule);
            // initialize components
            InitializeComponent();
        }

        #region Auxiliary methods
        /// <summary>
        /// Prepare the visual elements
        /// </summary>
        private void Setup()
        {
            
            // set the label to no visible
            this.winnerLabel.Visible = false;
            this.labelLooser.Visible = false;

            // reset images
            PlayerOneImage.Image = Properties.Resources.logo;
            PlayerTwoImage.Image = Properties.Resources.logo;

            // enable fight button
            fightButton.Enabled = true;
        }

        /// <summary>
        /// Show feedback Information
        /// </summary>
        /// <param name="location">position</param>     
        private void ShowFeedbackInformation(Label label, Point location, string text = "WINNER!")
        {
            label.Location = location; // change location
            label.Visible = true; // Moke Visible
            label.Text = text; // set text
        }

        /// <summary>
        /// Show the winner information
        /// </summary>
        /// <param name="winner"></param>
        private void WinnerHandler(IPlayer winner)
        {
            Point location;
            Point looserLocation;
            // check about the winner is null for draw
            if (winner == null)
            {
                // new point
                location = new Point()
                {
                    X = this.Width / 2
                };
                // show information
                ShowFeedbackInformation(winnerLabel, location, "DRAW!");
                return;
            }

            // action looser
            string looserAction = "Looser";

            // check about winner is player one or player two            
            // get the container image player position           
            if (winner.Equals(this.GameMode.PlayerOne))
            {
                location = PlayerOneImage.Location;
                looserLocation = PlayerTwoImage.Location;
                looserAction = GameHelper.FindWinnerAtack(winner, GameMode.PlayerTwo);
            }
            else
            {
                location = PlayerTwoImage.Location;
                looserLocation = PlayerOneImage.Location;
                looserAction = GameHelper.FindWinnerAtack(winner, GameMode.PlayerOne);
            }
            // show the label
            ShowFeedbackInformation(winnerLabel, location);
            ShowFeedbackInformation(labelLooser, looserLocation, looserAction);
        }

        /// <summary>
        /// Set the image
        /// </summary>
        /// <param name="imageContainer"></param>
        private void SetWeaponImage(PictureBox imageContainer, IWeapon weapon)
        {
            // load the image
            imageContainer.Image =
                Properties.Resources.ResourceManager.GetObject(weapon.ImageUri)
                as Image;
        }
        #endregion

        #region Events Handlers

        /// <summary>
        /// Load Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadHandler(object sender, EventArgs e)
        {
            // prepere the view
            this.Setup();
            //start the level
            try
            {
                this.GameMode.Start();
            }
            catch (Core.Exceptions.BadGameModeSetupException ex)
            {
                Console.WriteLine(ex.StackTrace);

                MessageBox.Show("Can't start. You must Setup the Game Mode First", "Game",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        /// <summary>
        /// Close Button Click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClickHandler(object sender, EventArgs e)
        {
            // clone aplication
            Application.Exit();
        }

        /// <summary>
        /// Start Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartButtonClickHandler(object sender, EventArgs e)
        {
            // restart view elements
            Setup();

            //restart game mode
            this.GameMode.Restart();
        }
        /// <summary>
        /// Fight Button Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FightButtonClickEventHandler(object sender, EventArgs e)
        {

            try
            {
            // get the winner
                IPlayer winner = this.GameMode.Fight();
                // set the Playe 1 image 
                SetWeaponImage(PlayerOneImage, this.GameMode.PlayerOne.SelectedWeapon);
                // set the Playe 2 image 
                SetWeaponImage(PlayerTwoImage, this.GameMode.PlayerTwo.SelectedWeapon);                
                // handler the winner
                WinnerHandler(winner);
                // desable fight button
                fightButton.Enabled = false;

            }
            catch (Core.Exceptions.WeaponNotSelectedExeption ex)
            {
                Console.WriteLine(ex.StackTrace);

                MessageBox.Show("Select your Weapon", "Game",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        #endregion
    }
}
