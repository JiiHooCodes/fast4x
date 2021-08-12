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
        GameObject planet = GameObject.Find("planet");
        Assert.That(planet, Is.Not.Null);

        int population = planet.GetComponent<PlanetData>().GetPopulation();
        Assert.That(population, Is.EqualTo(expectedPopulation));
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
}