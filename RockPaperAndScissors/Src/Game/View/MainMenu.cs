using RockPaperAndScissors.Src.Game.Core;
using System;
using System.Windows.Forms;

namespace RockPaperAndScissors.Src.Game.View
{
    /// <summary>
    /// Main menu
    /// </summary>
    partial class MainMenu : Form, IGameView
    {
        /// <summary>
        /// Game mode
        /// </summary>
        public IGameMode GameMode { get; }

        /// <summary>
        /// Main contructor
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClickHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
