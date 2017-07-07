
using System.Collections.Generic;

namespace RockPaperAndScissors.Src.Game.Weapons
{
    /// <summary>
    /// Weapon Interface
    /// </summary>
    interface IWeapon
    {
        /// <summary>
        /// Weapon name
        /// </summary>
        string Name { get; } 

        /// <summary>
        /// Image file path
        /// </summary>
        string ImageUri { get; }

        /// <summary>
        /// Weapons that are weaker than this
        /// </summary>
        IList<IWeakness> Weaknesses { get; }


    }
}
