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
            Application.Run(new Src.Game.View.MainMenu());
        }
    }
}
