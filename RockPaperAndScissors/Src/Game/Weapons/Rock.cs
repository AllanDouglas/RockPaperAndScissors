using System.Collections.Generic;

namespace RockPaperAndScissors.Src.Game.Weapons
{
    /// <summary>
    /// The Rock
    /// </summary>
    class Rock : Weapon
    {


        #region Singleton
        /// <summary>
        /// Singleton field
        /// </summary>
        private static Weapon _instance;

        /// <summary>
        /// Get a Instance 
        /// </summary>
        public static Weapon Instance
        {
            get
            {
                // check if _instance is null; True: create a new Weapon Instance
                if (_instance == null) _instance = new Rock();

                return _instance;
            }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Main Contructor
        /// </summary>
        private Rock()
        {
            this.Name = "Rock";
            this.ImageUri = "Rock";

            this.Weaknesses = new List<IWeakness>();

        }

        #endregion

    }
}
