using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Rules
{
    /// <summary>
    /// Define the Basic Rules
    /// to the Game
    /// </summary>
    class Advanced : Rule
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
                if (_instance == null) _instance = new Advanced();

                return _instance;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Main constructor
        /// </summary>
        private Advanced()
        {
            // add the Weapons
            this.AvailableWeapons = new IWeapon[5];

            this.AvailableWeapons[0] = Rock.Instance;
            this.AvailableWeapons[1] = Scissors.Instance;
            this.AvailableWeapons[2] = Paper.Instance;
            this.AvailableWeapons[3] = Lizard.Instance;
            this.AvailableWeapons[4] = Spok.Instance;

            Rock.Instance.AddWeakness(new Weakness("Covered", Paper.Instance));
            Rock.Instance.AddWeakness(new Weakness("Vaporized", Spok.Instance));

            Scissors.Instance.AddWeakness(new Weakness("Crushed", Rock.Instance));
            Scissors.Instance.AddWeakness(new Weakness("Crushed", Spok.Instance));

            Paper.Instance.AddWeakness(new Weakness("Cut", Scissors.Instance));
            Paper.Instance.AddWeakness(new Weakness("Eaten", Lizard.Instance));

            Spok.Instance.AddWeakness(new Weakness("Poizoned", Lizard.Instance));
            Spok.Instance.AddWeakness(new Weakness("Refuted", Paper.Instance));

            Lizard.Instance.AddWeakness(new Weakness("Decapted", Scissors.Instance));
            Lizard.Instance.AddWeakness(new Weakness("Crushed", Rock.Instance));
            

        } 
        #endregion

    }
}
