using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetData : MonoBehaviour
{
    private int population;

    void Start()
    {

    }

    void Update()
    {

    }

    public int getPopulation()
    {
        return population;
    }
    public void setInitialPopulation(int pop)
    {
        if (population == 0)
            population = pop;
    }
}
