using System.Collections.Generic;

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
        public IList<IWeakness> Weaknesses { get; protected set; }
        #endregion

        /// <summary>
        /// Add a new Weakness
        /// </summary>
        /// <param name="weapon"></param>
        public void AddWeakness(IWeakness weakness)
        {
            // check about just exist weakness
            foreach(IWeapon weapon in this.Weaknesses)
            {
                if(weakness.Weapon == weapon)
                {
                    return;
                }
            }

            // add a new weakness
            this.Weaknesses.Add(weakness);
        }

    }
}
