using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

// Please note: In [UnityTest]-tests we can use 'yield return' in front of game.refresh() to wait for Unity to set everything up, before we can query most things. And I haven't been able to find any syntactic sugar to make it nicer.

public class AcceptanceTests
{
    GameRunner game;
    [UnitySetUp]
    public IEnumerator Setup()
    {
        game = new GameRunner();
        game.start();
        yield return game.refresh();
    }
    [Test]
    public void WhenGameHasStartedThereIsAPlanetWithPopulation()
    {
        game.hasAPlanetWithPopulation();
    }

}
