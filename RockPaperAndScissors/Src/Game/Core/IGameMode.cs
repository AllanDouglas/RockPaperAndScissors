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
        Rules.IRule Rule { get; }

        /// <summary>
        /// Setup the GameMode 
        /// </summary>
        /// <param name="rule"></param>
        void Setup(Rules.IRule rule);

        /// <summary>
        /// Start the GameMode
        /// </summary>
        void Start();

        /// <summary>
        /// Restart the game mode
        /// </summary>
        void Restart();

        /// <summary>
        /// Compare the Players Weapons
        /// </summary>
        /// <returns>The winner Player; Null if draw</returns>
        IPlayer Fight();

    }
}
