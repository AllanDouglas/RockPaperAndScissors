using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Mode
{
    /// <summary>
    /// Game Style Insterface
    /// </summary>
    interface IGameStyle
    {

        /// <summary>
        /// The Available weapons to this Game Style
        /// </summary>
        IWeapon[] AvailableWeapons { get; }

    }
}