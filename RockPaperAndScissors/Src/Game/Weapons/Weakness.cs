namespace RockPaperAndScissors.Src.Game.Weapons
{
    /// <summary>
    /// Define the Weakness
    /// </summary>
    class Weakness : IWeakness
    {
        #region Properties
        /// <summary>
        /// Action name
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Weapon Weak
        /// </summary>
        public IWeapon Weapon { get; set; } 
        #endregion

        #region Constructors
        /// <summary>
        /// Main construct
        /// </summary>
        public Weakness() { }
        /// <summary>
        /// Full construct
        /// </summary>
        /// <param name="action"></param>
        /// <param name="weapon"></param>
        public Weakness(string action, IWeapon weapon)
        {
            this.Action = action;
            this.Weapon = weapon;
        } 
        #endregion


    }
}
