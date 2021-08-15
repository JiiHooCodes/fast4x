using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fast4XCore;

public class PlanetFactory
{
    public static GameObject CreatePlanet(Planet planet)
    {
        GameObject planetUI = new GameObject("planet");
        planetUI.tag = "planet";
        PlanetData planetData = planetUI.AddComponent<PlanetData>();
        planet.AddListener(planetData);
        planetData.SetInitialPopulation(planet.GetPopulation());
        Coordinates coordinates = planet.getCoordinates();
        planetData.transform.position = new Vector2(coordinates.x, coordinates.y);
        return planetUI;
    }
}
