using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlanetFactoryTests
{
    [Test]
    public void CreatesPlanetWithPopulation()
    {
        GameObject gameObject = PlanetFactory.createPlanet();
        Assert.That(gameObject, Is.Not.Null);

        int population = gameObject.GetComponent<PlanetData>().getPopulation();
        Assert.That(population, Is.GreaterThan(0));
    }
    
}
