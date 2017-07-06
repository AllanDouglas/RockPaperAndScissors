namespace RockPaperAndScissors.Src.Game.Weapons
{
    /// <summary>
    /// Strength Interface
    /// </summary>
    interface IWeakness
    {
        /// <summary>
        /// Description
        /// </summary>
        string Action { get; set; }

        /// <summary>
        /// Weapon Strong
        /// </summary>
        IWeapon Weapon { get; set; }


    }
}
