using System;
using RockPaperAndScissors.Src.Game.Rules;
using RockPaperAndScissors.Src.Game.Core.Exceptions;

namespace RockPaperAndScissors.Src.Game.Core
{
    /// <summary>
    /// Manager mode
    /// Player VS Computer
    /// </summary>
    class ComputerVSComputer : IGameMode
    {
        #region Properties
        /// <summary>
        /// Player one Human
        /// </summary> 
        public IPlayer PlayerOne { get; private set; }

        /// <summary>
        /// Player Two Computer
        /// </summary>
        public IPlayer PlayerTwo { get; private set; }

        /// <summary>
        /// Game Rule
        /// </summary>
        public IRule Rule { get; private set; }
        #endregion

        #region Sinlegeton
        /// <summary>
        /// Instance reference for singleton
        /// </summary>
        private static ComputerVSComputer _instance;

        /// <summary>
        /// Get the PlayerVSComputer Instance
        /// </summary>
        public static ComputerVSComputer Instance
        {
            get
            {
                // check abou null _instance
                if (_instance == null) _instance = new ComputerVSComputer();

                return _instance;
            }
        }

        /// <summary>
        /// Private constructor for
        /// Singleton
        /// </summary>
        private ComputerVSComputer()
        {
            this.PlayerOne = new Computer(); // new human player
            this.PlayerTwo = new Computer(); // new computer player
        }
        #endregion

        #region IGameMode Methods
        /// <summary>        
        /// Prepare the Game Mode        
        /// </summary>
        /// <param name="rule"></param>
        public void Setup(IRule rule)
        {
            this.Rule = rule;
        }

        /// <summary>
        /// Start the Game Mode
        /// </summary>
        public void Start()
        {
            // check about null rule
            if (this.Rule == null)
            {
                throw new BadGameModeSetupException("The GameRule can't be null. Setup first");
            }
            // cast the player1 object
            Computer p1 = PlayerOne as Computer;
            // choose a new weapon for him
            p1.Choose(this.Rule.AvailableWeapons);
            // cast the player2 object
            Computer p2 = PlayerTwo as Computer;
            // choose a new weapon for him
            p2.Choose(this.Rule.AvailableWeapons);

        }

        /// <summary>
        /// Restart the game mode
        /// </summary>
        public void Restart()
        {
            Start();
        }

        /// <summary>
        /// Compare the Players Weapons
        /// </summary>
        /// <returns>The winner Player; Null if draw</returns>
        public IPlayer Fight()
        {

            IPlayer winner = null;
            try
            {
                // try get the winnder
                winner = this.Rule.CompareWeapons(PlayerOne, PlayerTwo);
            }
            catch (WeaponNotSelectedExeption e)
            {
                Console.WriteLine(e.StackTrace);
                throw new WeaponNotSelectedExeption("Check about the Players Selected Weapon can't be null. Did you start the level?");
            }

            return winner;
        }
        #endregion
    }
}
