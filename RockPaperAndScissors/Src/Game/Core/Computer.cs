using System;
using RockPaperAndScissors.Src.Game.Core;
using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Core
{
    class Computer : IPlayer
    {
        /// <summary>
        /// Selectted Weapon
        /// </summary>
        public IWeapon SelectedWeapon { get; private set;}

        /// <summary>
        /// Choose the Weapon
        /// </summary>
        /// <param name="weapon"></param>
        public void Choose(IWeapon[] options)
        {
            // randomly get a weapon from Rule
            int index = Utils.Random.Range(0, options.Length);
            // get the weapon
            SelectedWeapon = options[index];

        }
    }
}
