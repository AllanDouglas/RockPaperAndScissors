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
        public virtual IWeapon SelectedWeapon { get; protected set; }
 
       
    }
}
