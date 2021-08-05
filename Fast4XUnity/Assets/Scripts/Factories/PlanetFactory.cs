using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetFactory
{
    public static GameObject createPlanet()
    {
        GameObject planet = new GameObject("planet");
        PlanetData pd = planet.AddComponent<PlanetData>();
        pd.setInitialPopulation(20);
        return planet;
    }
}
