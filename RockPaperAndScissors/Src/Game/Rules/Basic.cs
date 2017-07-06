﻿using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Rules
{
    /// <summary>
    /// Define the Basic Rules
    /// to the Game
    /// </summary>
    class Basic : IRule
    {
        /// <summary>
        /// The Available weapons to this Game Style
        /// </summary>
        public IWeapon[] AvailableWeapons { get; private set; }

        #region Singleton
        /// <summary>
        /// Singleton field
        /// </summary>
        private static IRule _instance;

        /// <summary>
        /// Get a Instance 
        /// </summary>
        public static IRule Instance
        {
            get
            {
                // check if _instance is null; True: create a new Instance
                if (_instance == null) _instance = new Basic();

                return _instance;
            }
        }
        #endregion

        #region Constructos
        /// <summary>
        /// Main constructor
        /// </summary>
        private Basic()
        {
            // add the Weapons
            this.AvailableWeapons = new IWeapon[3];

            this.AvailableWeapons[0] = Rock.Instance;
            this.AvailableWeapons[0] = Scissors.Instance;
            this.AvailableWeapons[0] = Paper.Instance;

        } 
        #endregion

    }
}