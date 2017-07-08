using RockPaperAndScissors.Src.Game.Core;
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

        /// <summary>
        /// Get the Suffered attack
        /// </summary>
        /// <param name="winner"></param>
        /// <param name="loser"></param>
        /// <returns>Weaknesse action. If null winner invalid</returns>
        string AttackSuffered(IPlayer winner, IPlayer loser);

        /// <summary>
        /// Compare the selected weapons
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns>The winner player or null if draw</returns>
        IPlayer CompareWeapons(IPlayer one, IPlayer two);

    }
}