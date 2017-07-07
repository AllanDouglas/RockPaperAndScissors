using System;
using NUnit.Framework;
using RockPaperAndScissors.Src.Game.Core;
using RockPaperAndScissors.Src.Game.Mode;

namespace RockPaperAndScissors.Src
{
    [TestFixture]
    class Test
    {
        [TestCase]
        public void Main()
        {
            Game.Rules.IRule basics = Game.Rules.Basic.Instance;

            Human one = new Human();
            one.SetWeapon(Game.Weapons.Rock.Instance);
            Human two = new Human();
            two.SetWeapon(Game.Weapons.Scissors.Instance);

            Console.WriteLine(one.SelectedWeapon.Name);
            Console.WriteLine(two.SelectedWeapon.Name);

            IPlayer winner = GameHelper.CompareWeapons(one, two);

            Assert.AreEqual(one, winner);
            //Assert.AreEqual(one, winner);
        }

    }
}
