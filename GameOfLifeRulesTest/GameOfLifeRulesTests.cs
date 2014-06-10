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
        public void ADeadCellWithNoNeighbors_ShouldResultInNoNeighbors()
        {
            int numberOfNeighbors = 0;
            Assert.That( GameOfLifeRules.ApplyRules( numberOfNeighbors, State.Dead ), Is.EqualTo( State.Dead ));

        }

    }
}
