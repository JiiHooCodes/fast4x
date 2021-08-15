using System;
using System.Collections.Generic;

namespace Fast4XCore
{
    public class Main
    {
        public readonly List<Planet> planets = new List<Planet>();
        public Main()
        {
            planets.Add(new Planet(2000));
            planets.Add(new Planet(0));
        }

        public void nextTurn()
        {
            planets.ForEach(planet => planet.AdvanceTurn());
        }
    }
}
