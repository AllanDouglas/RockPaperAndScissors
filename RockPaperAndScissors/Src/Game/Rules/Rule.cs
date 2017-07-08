using System;
using RockPaperAndScissors.Src.Game.Weapons;
using RockPaperAndScissors.Src.Game.Core.Exceptions;
using RockPaperAndScissors.Src.Game.Core;

namespace RockPaperAndScissors.Src.Game.Rules
{
    /// <summary>
    /// Rule Base class
    /// </summary>
    abstract class Rule : IRule
    {
        /// <summary>
        /// Available Weapons for this rules mode
        /// </summary>
        public abstract IWeapon[] AvailableWeapons { get; protected set; }

        /// <summary>
        /// Get the Suffered attack
        /// </summary>
        /// <param name="winner"></param>
        /// <param name="loser"></param>
        /// <returns>Weaknesse action. If null winner invalid</returns>
        public virtual string AttackSuffered(IPlayer winner, IPlayer loser)
        {
            // check if the Two's Weapon is more strong the One's Weapon 
            // return Two
            foreach (IWeakness weakness in loser.SelectedWeapon.Weaknesses)
            {
                if (weakness.Weapon.GetType().Equals(winner.SelectedWeapon.GetType()))
                {
                    return weakness.Action;
                }
            }

            return null;
        }

        /// <summary>
        /// Compare the selected weapons
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        public virtual IPlayer CompareWeapons(IPlayer one, IPlayer two)
        {

            // check about null weapons
            if (one.SelectedWeapon == null | two.SelectedWeapon == null)
            {
                throw new WeaponNotSelectedExeption("Both players must have non-null weapons");
            }

            // check if Selected Weapons are the same
            // return null
            if (one.SelectedWeapon.GetType().Equals(two.SelectedWeapon.GetType()))
            {
                return null;
            }

            // check if the Two's Weapon is more strong the One's Weapon 
            // return Two
            foreach (IWeakness weakness in one.SelectedWeapon.Weaknesses)
            {
                if (weakness.Weapon.GetType().Equals(two.SelectedWeapon.GetType()))
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
