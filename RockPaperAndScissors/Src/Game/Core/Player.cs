using RockPaperAndScissors.Src.Game.Mode;
using System;
using RockPaperAndScissors.Src.Game.Weapons;
using RockPaperAndScissors.Src.Game.Rules;

namespace RockPaperAndScissors.Src.Game.Core
{
    /// <summary>
    /// Player Base class
    /// </summary>
    abstract class  Player : IPlayer
    {
        /// <summary>
        /// Selected Weapon from the player
        /// </summary>
        public IWeapon SelectedWeapon { get; protected set; }

        /// <summary>
        /// Game Rules
        /// </summary>
        protected IRule rules;

        /// <summary>
        /// Chose a Weapon
        /// </summary>
        /// <param name="wweapon"></param>
        public abstract void Choose(IWeapon weapon = null);
    }
}
