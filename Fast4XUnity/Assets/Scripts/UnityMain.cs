using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fast4XCore;
using System;

public class UnityMain : MonoBehaviour
{
    Main game;
    GameObject planetGameObject;
    // Start is called before the first frame update
    void Start()
    {
        game = new Main();
        if (game.planet != null)
        {
            planetGameObject = PlanetFactory.CreatePlanet(game.planet);
        }
        GameObject nextTurnButtonGO = new GameObject("NextTurnButton");
        UnityEngine.UI.Button nextTurnButton = nextTurnButtonGO.AddComponent<UnityEngine.UI.Button>();
        nextTurnButton.onClick.AddListener(NextTurnClicked);

    }

    public void Clear()
    {
        Destroy(planetGameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NextTurnClicked()
    {
        game.nextTurn();
    }
}
