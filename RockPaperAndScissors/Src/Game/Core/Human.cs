using System;
using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Core
{
    /// <summary>
    /// Human controller player
    /// </summary>
    class Human : IPlayer
    {
        /// <summary>
        /// The Selected Weapon
        /// </summary>
        public IWeapon SelectedWeapon { get; set; }       

    }
}
