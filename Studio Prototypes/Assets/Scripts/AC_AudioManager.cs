using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_AudioManager : MonoBehaviour
{
    // Connects to AC_SchoolStatsManager script, to get info on current school reputaion.
    private AC_SchoolStatsManager schoolStats;

    // Holds all the background music.
    public AudioClip superheroMusic;
    public AudioClip heroMusic;
    public AudioClip neutralMusic;
    public AudioClip villainMusic;
    public AudioClip supervillainMusic;

    public bool superheroMorality;
    public bool heroMorality;
    public bool neutralMorality;
    public bool villainMorality;
    public bool supervillainMorality;

    // Grabs what will play the audio.
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // So the this script doesnt lose the reference to the AC_SchoolStatsManager script.
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();

        // Starts the game on normal background music.
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeBackgroundMusic()
    {
        if (superheroMorality == true)
        {
            if (audioSource.clip == !superheroMusic)
            {
                audioSource.clip = superheroMusic;
                audioSource.Play();
                superheroMorality = false;
            }
        }

        if (heroMorality == true)
        {
            if (audioSource.clip == !heroMusic)
            {
                audioSource.clip = heroMusic;
                audioSource.Play();
                heroMorality = false;
            }
        }

        if (neutralMorality == true)
        {
            if (audioSource.clip == !neutralMusic)
            {
                audioSource.clip = neutralMusic;
                audioSource.Play();
                neutralMorality = false;
            }
        }

        if (villainMorality == true)
        {
            if (audioSource.clip == !villainMusic)
            {
                audioSource.clip = villainMusic;
                audioSource.Play();
                villainMorality = false;
            }
        }

        if (supervillainMorality == true)
        {
            if (audioSource.clip == !supervillainMusic)
            {
                audioSource.clip = supervillainMusic;
                audioSource.Play();
                supervillainMorality = false;
            }
        }
    }
}
