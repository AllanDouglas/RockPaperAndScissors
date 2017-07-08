using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Rules
{
    /// <summary>
    /// Define the Basic Rules
    /// to the Game
    /// </summary>
    class Basic : Rule
    {
        /// <summary>
        /// The Available weapons to this Game Style
        /// </summary>
        public override IWeapon[] AvailableWeapons { get; protected set; }

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
            this.AvailableWeapons[1] = Scissors.Instance;
            this.AvailableWeapons[2] = Paper.Instance;

            Rock.Instance.AddWeakness(new Weakness("Covered", Paper.Instance));
            Scissors.Instance.AddWeakness(new Weakness("Crushed", Rock.Instance));
            Paper.Instance.AddWeakness(new Weakness("Cut", Scissors.Instance));


        } 
        #endregion

    }
}
