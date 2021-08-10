using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fast4XCore;

public class PlanetFactory
{
    public static GameObject CreatePlanet(Planet planet)
    {
        GameObject planetUI = new GameObject("planet");
        PlanetData planetData = planetUI.AddComponent<PlanetData>();
        planet.AddListener(planetData);
        planetData.SetInitialPopulation(planet.GetPopulation());
        return planetUI;
    }
}
