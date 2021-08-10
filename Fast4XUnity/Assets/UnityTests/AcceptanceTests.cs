using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

// Please note: In [UnityTest]-tests we have to put 'yield return' in front of game.refresh() to wait for Unity to set everything up, before we can query most things. And I haven't been able to find any syntactic sugar to make it nicer.

public class AcceptanceTests
{
    GameRunner game;
    [UnitySetUp]
    public IEnumerator Setup()
    {
        game = new GameRunner();
        game.Start();
        yield return game.Refresh();
    }
    [TearDown]
    public void TearDown()
    {
        game.End();
    }

    [Test]
    public void WhenGameHasStartedThereIsAPlanetWithPopulation()
    {
        game.HasAPlanetWithPopulation(20);
    }

    [UnityTest]
    public IEnumerator OnTurn2PlanetsPopulationHasGrown()
    {
        game.HasAPlanetWithPopulation(20);
        game.AdvanceTurn();
        yield return game.Refresh();

        game.HasAPlanetWithPopulation((int)(Mathf.Floor(20 + 1.6f))); // UI shows the population rounded down. 1.6 comes from the formula in Core.Planet
    }

}
