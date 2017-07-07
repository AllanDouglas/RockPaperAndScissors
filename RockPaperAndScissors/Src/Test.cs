using System;
using NUnit.Framework;
using RockPaperAndScissors.Src.Game.Core;


namespace RockPaperAndScissors.Src
{
    [TestFixture]
    class Test
    {
        /// <summary>
        /// General tests
        /// </summary>
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

        /// <summary>
        /// Tese the Player VS Computer Mode
        /// </summary>
        [TestCase]
        public void PvCMode()
        {
            // get the intance
            IGameMode PVC = PlayerVSComputer.Instance;
            // setup
            PVC.Setup(Game.Rules.Basic.Instance);
            //start 
            PVC.Start();

            // set player weapon
            Human p1 = PVC.PlayerOne as Human;
            p1.SelectedWeapon = Game.Weapons.Scissors.Instance;

            // Fight
            IPlayer winner = PVC.Fight();
            // get the winner for teste whith the instead logic
            IPlayer winnerTest = GameHelper.CompareWeapons(PVC.PlayerTwo, PVC.PlayerOne);

            Assert.AreEqual(winner, winnerTest);


        }

    }
}
