using System;
using System.Collections;
using UnityEngine;
using NUnit.Framework;

internal class GameRunner
{
    GameObject mainObject;
    UnityMain script;

    internal void start()
    {
        mainObject = new GameObject("main");
        script = mainObject.AddComponent<UnityMain>();
    }

    internal void hasAPlanetWithPopulation(double expectedPopulation)
    {
        GameObject planet = GameObject.Find("planet");
        Assert.That(planet, Is.Not.Null);

        int population = planet.GetComponent<PlanetData>().getPopulation();
        Assert.That(population, Is.EqualTo(expectedPopulation));
    }

    internal IEnumerator refresh()
    {
        return null;
    }

    internal void advanceTurn()
    {
        throw new NotImplementedException();
    }
}