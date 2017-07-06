namespace RockPaperAndScissors.Src.Game.Mode
{
    /// <summary>
    /// Player Interface
    /// </summary>
    interface IPlayer
    {
        /// <summary>
        /// The Selected Weapon
        /// </summary>
        Weapons.IWeapon SelectedWeapon { get; }
        

    }
}