using System;
using System.Windows.Forms;

namespace RockPaperAndScissors
{
    static class Program
    {
        /// <summary>
        /// Start Point
        /// </summary>   
        [STAThread]
        static void Main()
        {
         
            Application.EnableVisualStyles();

            var gameMode = Src.Game.Core.PlayerVSComputer.Instance;
            gameMode.Setup(Src.Game.Rules.Basic.Instance);

            Application.Run(new Src.Game.View.PlayerVsComputer(gameMode));
        }
    }
}
