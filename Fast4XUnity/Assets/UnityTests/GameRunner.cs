using System;
using System.Collections;
using UnityEngine;
using NUnit.Framework;

internal class GameRunner
{
    GameObject mainObject;
    UnityMain unityMain;

    internal void Start()
    {
        mainObject = new GameObject("main");
        unityMain = mainObject.AddComponent<UnityMain>();
    }
    internal void End()
    {
        unityMain.Clear();
    }


    internal void HasAPlanetWithPopulation(int expectedPopulation)
    {
        GameObject[] planets = GameObject.FindGameObjectsWithTag("planet");
        Assert.That(planets, Is.Not.Empty);

        foreach (GameObject planet in planets)
        {
            int population = planet.GetComponent<PlanetData>().GetPopulation();
            if (expectedPopulation == population)
            {
                return;
            }
        }
        Assert.Fail("Expected planet with population " + expectedPopulation + ",\nbut didn't find one.");
    }

    internal IEnumerator Refresh()
    {
        return null;
    }

    internal void AdvanceTurn()
    {
        GameObject NextTurnButtonGO = GameObject.Find("EndTurn_Button");
        UnityEngine.UI.Button button = NextTurnButtonGO.GetComponent<UnityEngine.UI.Button>();
        button.onClick.Invoke();
    }

    internal void CheckNoOverlapOfPlanets()
    {
        GameObject[] planets = GameObject.FindGameObjectsWithTag("planet");
        Assert.That(planets, Is.Not.Empty);

        foreach (GameObject planet in planets)
        {
            foreach (GameObject anotherPlanet in planets)
            {
                if(!planet.Equals(anotherPlanet))
                {
                    Assert.That(planet.transform.position, Is.Not.EqualTo(anotherPlanet.transform.position).Using(UnityEngine.TestTools.Utils.Vector3EqualityComparer.Instance));
                }
            }
        }
    }
}