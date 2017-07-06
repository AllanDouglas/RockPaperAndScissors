namespace RockPaperAndScissors.Src.Game.Weapons
{
    /// <summary>
    /// The Scissors
    /// </summary>
    class Scissors : Weapon
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
                if (_instance == null) _instance = new Scissors();

                return _instance;
            }
        }
        #endregion
        
        #region Constructor

        /// <summary>
        /// Main Contructor
        /// </summary>
        private Scissors()
        {
            this.Name = "Scissors";
            this.ImageUri = "Res...";


            this.Weaknesses = new Weakness[2];

            this.Weaknesses[0] = new Weakness("Crushed", Rock.Instance);



        }

        #endregion

    }
}
