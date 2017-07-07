using System;
using System.Windows.Forms;
using RockPaperAndScissors.Src.Game.Core;
using RockPaperAndScissors.Src.Game.Rules;

namespace RockPaperAndScissors.Src.Game.View
{
    /// <summary>
    /// Player VS Computer Game View
    /// </summary>
    partial class PlayerVsComputer : Form, IGameView
    {

        /// <summary>
        /// Game Mode for this view
        /// </summary>
        public IGameMode GameMode { get; private set; }
        
        /// <summary>
        /// Main contructor
        /// </summary>
        public PlayerVsComputer(IGameMode gameMode)
        {
            this.GameMode = gameMode;
            // initialize components
            InitializeComponent();
        }

        #region Events Handlers

        /// <summary>
        /// Load Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadHandler(object sender, EventArgs e)
        {
            
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
            InitializeComponent();

            //restart game mode
            this.GameMode.Restart();
        }

        #endregion

        
    }
}
