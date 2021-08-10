using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;
using Fast4XCore;

public class PlanetFactoryTests
{
    [Test]
    public void CreatesPlanetWithPopulation()
    {
        Planet planet = new Planet();
        GameObject gameObject = PlanetFactory.CreatePlanet(planet);
        Assert.That(gameObject, Is.Not.Null);

        int population = gameObject.GetComponent<PlanetData>().GetPopulation();
        Assert.That(population, Is.GreaterThan(0));
    }
    
}
