using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fast4XCore;

public class UnityMain : MonoBehaviour
{
    Fast4XCore.Main game;

    // Start is called before the first frame update
    void Start()
    {
        game = new Main();
        if (game.planet != null)
        {
            PlanetFactory.createPlanet();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
