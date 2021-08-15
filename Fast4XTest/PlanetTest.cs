using NUnit.Framework;
using NSubstitute;
using Fast4XCore;

namespace Fast4XTest
{
    class PlanetTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PlanetPopulationGrowsAccordingToFormula()
        {
            Planet planet = new Planet(2000);

            planet.AdvanceTurn();

            Assert.That(planet.GetTruePopulation(), Is.EqualTo(2160));
        }

        [Test]
        public void PlanetDoesNotGrowPastMaximum()
        {
            Planet planet = new Planet(9999);

            planet.AdvanceTurn();

            Assert.That(planet.GetTruePopulation(), Is.EqualTo(10000));
        }

        [Test]
        public void PlanetNotifiesListeners()
        {
            Planet planet = new Planet(2000);
            PlanetListener listener = Substitute.For<PlanetListener>();
            planet.AddListener(listener);

            planet.AdvanceTurn();

            listener.Received().Notify(21);

        }

        [Test]
        public void PlanetHasLocation()
        {
            Planet planet = new Planet();
            Coordinates coordinates = planet.getCoordinates();
            Assert.That(coordinates.x, Is.GreaterThanOrEqualTo(0));
            Assert.That(coordinates.y, Is.GreaterThanOrEqualTo(0));
        }
    }
}
