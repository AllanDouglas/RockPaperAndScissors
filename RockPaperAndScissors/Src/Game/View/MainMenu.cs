using RockPaperAndScissors.Src.Game.Core;
using RockPaperAndScissors.Src.Game.Rules;
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
        
        
        #region Constructors
        /// <summary>
        /// Main contructor
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        } 
        #endregion


        #region Auxiliary methods

        /// <summary>
        /// Get the rules instance
        /// </summary>
        /// <returns></returns>
        private IRule GetRule()
        {
            // get the Basic rule instance
            IRule rule = Basic.Instance;
            //check about advanced rules checkeds
            if (advRulesCX.Checked)
            {
                // advanced rules
                rule = Advanced.Instance;
            }
            return rule;
        }

        /// <summary>
        /// Open a new Game View Form
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private void NavigateTo<T>(T view) where T : Form
        {
            // set dispose event
            view.Disposed += (object sender, EventArgs e) =>
            {
                if(this != null)
                    this.Visible = true;
            };

            view.Show();

            this.Visible = false;

        }


        #endregion

        #region Events
        /// <summary>
        /// Close click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClickHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handler Click button event PvC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerVsComputerEventHandler(object sender, EventArgs e)
        {
            // get rule
            IRule rule = GetRule();
            // navigate
            NavigateTo(new PlayerVsComputer(rule));
        }

        /// <summary>
        /// Handler Click button event CvC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComputerVsComputerEventHandler(object sender, EventArgs e)
        {
            // get rule
            IRule rule = GetRule();
            // navigate
            NavigateTo(new ComputerVsComputer(rule));
        } 
        #endregion

    }
}
