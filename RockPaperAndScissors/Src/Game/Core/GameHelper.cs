using RockPaperAndScissors.Src.Game.Mode;
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
        /// <param name="Two"></param>
        static IPlayer CompareWeapons(IPlayer one, IPlayer Two)
        {
            // check if Selected Weapons are the same
            // return null
            if (one.SelectedWeapon == Two.SelectedWeapon)
            {
                return null;
            }

            // check if the Two's Weapon is more strong the One's Weapon 
            // return Two
            foreach(var weapon in Two.SelectedWeapon.Weaknesses)
            {
                if(weapon == one.SelectedWeapon)
                {
                    return Two;
                }
            }

            // check if the Two's Weapon is more strong the One's Weapon 
            // return One
            return one;
            
        }
    }
}
