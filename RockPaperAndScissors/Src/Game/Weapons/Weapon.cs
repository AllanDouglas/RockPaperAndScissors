using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperAndScissors.Src.Game.Weapons
{
    /// <summary>
    /// Weapon Base Classe
    /// </summary>
    abstract class Weapon : IWeapon
    {
      

        #region IWeapon
        /// <summary>
        /// Weapon Name
        /// </summary>
        public virtual string Name { get; protected set; }
        /// <summary>
        /// Image Path
        /// </summary>
        public virtual string ImageUri { get; protected set; }
        /// <summary>
        /// Weapons that are weaker than this
        /// </summary>
        public virtual IWeakness[] Weaknesses { get; protected set; }
       
       
        #endregion
    }
}
