using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Rules
{
    /// <summary>
    /// Game Style Insterface
    /// </summary>
    interface IRule
    {

        /// <summary>
        /// The Available weapons to this Game Style
        /// </summary>
        IWeapon[] AvailableWeapons { get; }

    }
}