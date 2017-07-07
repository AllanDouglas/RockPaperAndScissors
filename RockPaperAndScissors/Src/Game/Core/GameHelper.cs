using RockPaperAndScissors.Src.Game.Core;
using RockPaperAndScissors.Src.Game.Weapons;
using System;

namespace RockPaperAndScissors.Src.Game.Core
{
    /// <summary>
    /// Game Helper Class
    /// </summary>
    static class GameHelper
    {

        /// <summary>
        /// Compare the selec
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        internal static IPlayer CompareWeapons(IPlayer one, IPlayer two)
        {

            // check about null weapons
            if (one.SelectedWeapon == null | two.SelectedWeapon == null)
            {
                throw new NullReferenceException("Both players must have non-null weapons");
            }

            // check if Selected Weapons are the same
            // return null
            if ( one.SelectedWeapon.GetType().Equals(two.SelectedWeapon.GetType()))
            {
                return null;
            }

            // check if the Two's Weapon is more strong the One's Weapon 
            // return Two
            foreach(IWeakness weakness in one.SelectedWeapon.Weaknesses)
            {
                if(weakness.Weapon.GetType().Equals(two.SelectedWeapon.GetType()))
                {
                    return two;
                }
            }

            // check if the Two's Weapon is more strong the One's Weapon 
            // return One
            return one;
            
        }
    }
}
