using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Core
{
    /// <summary>
    /// GameMode Interface
    /// </summary>
    interface IGameMode
    {
        /// <summary>
        /// The Player One
        /// </summary>
        IPlayer PlayerOne { get; }
        
        /// <summary>
        /// The Player Two
        /// </summary>
        IPlayer PlayerTwo { get; }

        /// <summary>
        /// Define the Game Rule
        /// </summary>
        Rules.IRule[] GameRule { get; }

        /// <summary>
        /// Setup the GameMode 
        /// </summary>
        void Setup();

        /// <summary>
        /// Start the GameMode
        /// </summary>
        void Start();


    }
}
