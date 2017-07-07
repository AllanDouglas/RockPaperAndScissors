namespace RockPaperAndScissors.Src.Game.Core
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