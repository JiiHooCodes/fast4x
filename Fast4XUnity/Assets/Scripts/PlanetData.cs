using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fast4XCore;

public class PlanetData : MonoBehaviour, PlanetListener
{
    private int population;

    void Start()
    {

    }

    void Update()
    {

    }

    public int GetPopulation()
    {
        return population;
    }
    public void SetInitialPopulation(int pop)
    {
        if (population == 0)
            population = pop;
    }

    public void Notify(int population)
    {
        this.population = population;
    }
}
