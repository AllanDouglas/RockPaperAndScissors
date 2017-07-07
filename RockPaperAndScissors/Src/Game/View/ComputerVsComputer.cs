using RockPaperAndScissors.Src.Game.Core;
using System;
using System.Windows.Forms;

namespace RockPaperAndScissors.Src.Game.View
{
    partial class ComputerVsComputer : Form, IGameView
    {

        /// <summary>
        /// Game Mode for this view
        /// </summary>
        public IGameMode GameMode { get; private set; }

        /// <summary>
        /// Main contructor
        /// </summary>
        public ComputerVsComputer(IGameMode gameMode)
        {
            this.GameMode = gameMode;
            // initialize components
            InitializeComponent();
        }

        #region Events Handlers

        /// <summary>
        /// Close Button Click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClickHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Start Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartButtonClickHandler(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
