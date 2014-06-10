using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GameOfLifeRulesKata;


namespace GameOfLifeRulesTest
{
    [TestFixture]
    public class GameOfLifeRulesTests
    {
        [Test]
        public void ADeadCellWithNoNeighbors_ShouldResultInADeadCell()
        {
            int numberOfNeighbors = 0;
            Assert.That( GameOfLifeRules.ApplyRules( numberOfNeighbors, State.Dead ), Is.EqualTo( State.Dead ));

        }

        [Test]
        public void AnAliveCellWithNoNeighbors_ShouldResultInADeadCell()
        {
            int numberOfNeighbors = 0;
            Assert.That(GameOfLifeRules.ApplyRules(numberOfNeighbors, State.Alive), Is.EqualTo(State.Dead));

        }

        [Test]
        public void AnAliveCellWithTwoOrThreeNeighbors_ShouldResultInALiveCell()
        {
            int numberOfNeighbors = 2;

            Assert.That(GameOfLifeRules.ApplyRules(numberOfNeighbors, State.Alive), Is.EqualTo(State.Alive));

            numberOfNeighbors = 3;

            Assert.That(GameOfLifeRules.ApplyRules(numberOfNeighbors, State.Alive), Is.EqualTo(State.Alive));


        }





    }
}
