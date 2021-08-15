using NUnit.Framework;
using Fast4XCore;

namespace Fast4XTest
{
    public class CoreMain
    {
        Main game;

        [SetUp]
        public void Setup()
        {
            game = new Main();
        }

        [Test]
        public void GameHasPlanets()
        {
            Assert.That(game.planets, Is.Not.Empty);
        }

    }
}