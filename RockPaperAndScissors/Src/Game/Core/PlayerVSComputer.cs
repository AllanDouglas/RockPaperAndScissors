using System;
using RockPaperAndScissors.Src.Game.Rules;
using RockPaperAndScissors.Src.Game.Core.Exceptions;

namespace RockPaperAndScissors.Src.Game.Core
{
    /// <summary>
    /// Manager mode
    /// Player VS Computer
    /// </summary>
    class PlayerVSComputer : IGameMode
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
        public IRule GameRule { get; private set; }
        #endregion

        #region Sinlegeton
        /// <summary>
        /// Instance reference for singleton
        /// </summary>
        private static PlayerVSComputer _instance;

        /// <summary>
        /// Get the PlayerVSComputer Instance
        /// </summary>
        public static PlayerVSComputer Instance
        {
            get
            {
                // check abou null _instance
                if (_instance == null) _instance = new PlayerVSComputer();

                return _instance;
            }
        }

        /// <summary>
        /// Private constructor for
        /// Singleton
        /// </summary>
        private PlayerVSComputer()
        {
            this.PlayerOne = new Human(); // new human player
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
            this.GameRule = rule;
        }

        /// <summary>
        /// Start the Game Mode
        /// </summary>
        public void Start()
        {
            // check about null rule
            if (this.GameRule == null)
            {
                throw new BadGameModeSetupException("The GameRule can't be null. Setup first");
            }
            // cast the player2 object
            Computer p2 = PlayerTwo as Computer;
            // choose a new weapon for him
            p2.Choose(this.GameRule.AvailableWeapons);

        }

        /// <summary>
        /// Restart the game mode
        /// </summary>
        public void Restart()
        {
            (this.PlayerOne as Human).SelectedWeapon = null;
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
                winner = GameHelper.CompareWeapons(PlayerOne, PlayerTwo);
            }
            catch (WeaponNotSelectedExeption e)
            {
                Console.WriteLine(e.StackTrace);
                throw new WeaponNotSelectedExeption("Check about the Players Selected Weapon can't be null");
            }

            return winner;
        }
        #endregion
    }
}
