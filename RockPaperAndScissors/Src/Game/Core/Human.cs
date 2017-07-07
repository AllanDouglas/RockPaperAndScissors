using System;
using RockPaperAndScissors.Src.Game.Mode;
using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Core
{
    /// <summary>
    /// Human controller player
    /// </summary>
    class Human : Player
    {
        /// <summary>
        /// Set the weapon to player
        /// </summary>
        /// <param name="weapon"></param>
        public void SetWeapon(IWeapon weapon)
        {
            this.SelectedWeapon = weapon;
        }

    }
}
