using RockPaperAndScissors.Src.Game.Weapons;

namespace RockPaperAndScissors.Src.Game.Core
{
    class Computer : Player
    {
      
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
