using System;
using RockPaperAndScissors.Src.Game.Weapons;
using RockPaperAndScissors.Src.Game.Rules;


namespace RockPaperAndScissors.Src.Game.Core
{
    class Computer : Player
    {
        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="rules"></param>
        public Computer(IRule rules)
        {
            this.rules = rules;
        }

        /// <summary>
        /// Choose the Weapon
        /// </summary>
        /// <param name="weapon"></param>
        public override void Choose(IWeapon weapon = null)
        {
            // randomly get a weapon from Rule
            int index = Utils.Random.Range(0, rules.AvailableWeapons.Length);
            // get the weapon
            SelectedWeapon = rules.AvailableWeapons[index];

        }
    }
}
