using RockPaperAndScissors.Src.Game.Core;
using RockPaperAndScissors.Src.Game.Rules;

namespace RockPaperAndScissors.Src.Game.View
{
    /// <summary>
    /// Game view
    /// </summary>
    interface IGameView 
    {
        /// <summary>
        /// The game mode
        /// </summary>
        IGameMode GameMode { get; }

    }
}
