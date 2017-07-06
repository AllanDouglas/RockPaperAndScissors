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
        private static IWeapon _instance;

        /// <summary>
        /// Get a Instance 
        /// </summary>
        public static IWeapon Instance
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
            this.ImageUri = "Res...";

            this.Weaknesses = new Weakness[2];

            this.Weaknesses[0] = new Weakness("Covered", Paper.Instance);

        }

        #endregion

    }
}
