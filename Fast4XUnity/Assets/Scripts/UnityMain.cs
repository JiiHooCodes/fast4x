using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

        CreateUI();
        
    }

    void CreateUI()
    {
        if(GameObject.Find("EventSystem") == null)
        {
            GameObject eventSystem = new GameObject("EventSystem", typeof(UnityEngine.EventSystems.EventSystem), typeof(UnityEngine.EventSystems.StandaloneInputModule));

            GameObject UI = Instantiate(Resources.Load<GameObject>("UI/UI_Canvas"));
            Button nextTurnButton = UI.transform.GetChild(0).gameObject.GetComponent<Button>();
            nextTurnButton.onClick.AddListener(NextTurnClicked);

        }
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
