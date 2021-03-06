﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AC_GameOver : MonoBehaviour
{
    // Stats to be displayed.
    // Time played, years and weeks.
    // Number of hero graduates.
    // Number of villain graduates.
    // Number of failed graduates.

    OG_DataManager datamanager_ref;

    public string endText;



    // Start is called before the first frame update
    void Start()
    {
        datamanager_ref = GameObject.Find("DataManager").GetComponent<OG_DataManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Year25RetirementEnd()
    {
        Debug.Log("Happy Retirement");
        endText = "Happy Retirement";
        datamanager_ref.DataManagerUpdater();
        SceneManager.LoadScene("GameOverScene");
        // Ends the game after the 25 years have passed without another end game being met.
        // Opens another scene and gives a rundown of the players game stats.

    }

    public void HeroPeaceEnd()
    {
        Debug.Log("Peaceful World");
        endText = "Peaceful World";
        datamanager_ref.DataManagerUpdater();
        SceneManager.LoadScene("GameOverScene");
        // Ends the game if the difference between the number of heroes and villains in the world is above 100 in the heroes side.
        // Opens another scene and gives a rundown of the players game stats.

    }

    public void VillainDestructionEnd()
    {
        Debug.Log("Destroyed World");
        endText = "Destroyed World";
        datamanager_ref.DataManagerUpdater();
        SceneManager.LoadScene("GameOverScene");
        // Ends the game if the difference between the number of heroes and villains in the world is above 100 in the villains side.
        // Opens another scene and gives a rundown of the players game stats.
    }

    public void EarlyRetirementEnd()
    {
        Debug.Log("Fired");
        endText = "Fired";
        datamanager_ref.DataManagerUpdater();
        SceneManager.LoadScene("GameOverScene");
        // Ends the game if the players reputation stays low for to long.
        // Opens another scene and gives a rundown of the players game stats.
    }
}
