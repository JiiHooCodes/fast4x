using System;
using System.Collections.Generic;

namespace Fast4XCore
{
    public class Planet
    {
        private int population;
        private static int POPULATION_MAX = 10000;
        private List<PlanetListener> planetListeners = new List<PlanetListener>();

        public Planet(int startingPopulation)
        {
            population = startingPopulation;
        }

        public Planet()
        {
            population = 2000;
        }


        public  int GetTruePopulation() { return population; }
        public int GetPopulation() { return population/100; }

        public void AddListener(PlanetListener listener)
        {
            planetListeners.Add(listener);
        }

        public void AdvanceTurn()
        {
            // growth formula: pop%MissingFromMax (* growthModifier) * pop  / 10, but at least 5, unless capped
            int growth = Math.Max((int)((1 - (population / (double)POPULATION_MAX)) * population / 10), 5);
            population += growth;
            if (population > POPULATION_MAX)
            {
                population = POPULATION_MAX;
            }
            
            NotifyChanges();
        }

        private void NotifyChanges()
        {
            planetListeners.ForEach(listener => listener.Notify(population / 100));
        }
    }
}

