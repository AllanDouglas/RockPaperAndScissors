using RockPaperAndScissors.Src.Game.Core.Exceptions;
using RockPaperAndScissors.Src.Game.Weapons;


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
                throw new WeaponNotSelectedExeption("Both players must have non-null weapons");
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

        /// <summary>
        /// Get the Suffered blow
        /// </summary>
        /// <param name="winner"></param>
        /// <param name="loser"></param>
        /// <returns></returns>
        public static string FindWinnerAtack(IPlayer winner, IPlayer loser)
        {   
            // check if the Two's Weapon is more strong the One's Weapon 
            // return Two
            foreach (IWeakness weakness in loser.SelectedWeapon.Weaknesses)
            {
                if (weakness.Weapon.GetType().Equals(winner.SelectedWeapon.GetType()))
                {         
                    return  weakness.Action;
                }
            }

            return null;
        }
    }
}
