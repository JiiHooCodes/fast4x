using System;
using System.Collections.Generic;

namespace Fast4XCore
{
    public class Main
    {
        public readonly List<Planet> planets = new List<Planet>();
        public Main()
        {
            CreatePlanets();
        }

        private void CreatePlanets()
        {
            planets.Add(new Planet(2000, new Coordinates(1, 1)));
            planets.Add(new Planet(0, new Coordinates(2, 2)));
        }

        public void NextTurn()
        {
            planets.ForEach(planet => planet.AdvanceTurn());
        }
    }
}
