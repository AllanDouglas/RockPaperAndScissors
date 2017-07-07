using System;
using NUnit.Framework;
using RockPaperAndScissors.Src.Game.Core;


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
            one.SelectedWeapon = (Game.Weapons.Rock.Instance);
            Human two = new Human();
            two.SelectedWeapon = (Game.Weapons.Scissors.Instance);

            Console.WriteLine(one.SelectedWeapon.Name);
            Console.WriteLine(two.SelectedWeapon.Name);

            IPlayer winner = GameHelper.CompareWeapons(one, two);

            Assert.AreEqual(one, winner);
            //Assert.AreEqual(one, winner);
        }

    }
}
