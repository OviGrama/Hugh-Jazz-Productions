using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_AudioManager : MonoBehaviour
{
    // Connects to AC_SchoolStatsManager script, to get info on current school reputaion.
    private AC_SchoolStatsManager schoolStats;

    // Holds all the background music.
    public AudioClip goodMusic;
    public AudioClip normalMusic;
    public AudioClip badMusic;
    public bool heroMorality;
    public bool nomralMorality;
    public bool villianMorality;

    // Grabs what will play the audio.
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // So the this script doesnt lose the reference to the AC_SchoolStatsManager script.
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();

        // Starts the game on normal background music.
        audioSource = GetComponent<AudioSource>();

        // Sets the background to normal music.
        audioSource.clip = normalMusic;

        // Plays the background music.
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeBackgroundMusic()
    {
        //if (schoolStats.currentAverageMorality == "Hero")
        //{
        //    audioSource.clip = goodMusic;
        //    audioSource.Play();
        //}

        //if (schoolStats.currentAverageMorality == "Normal")
        //{
        //    audioSource.clip = goodMusic;
        //    audioSource.Play();
        //}

        //if (schoolStats.currentAverageMorality == "Villian")
        //{
        //    audioSource.clip = goodMusic;
        //    audioSource.Play();
        //}

        if (heroMorality == true)
        {
            audioSource.clip = goodMusic;
            audioSource.Play();
            heroMorality = false;
        }

        if (nomralMorality == true)
        {
            audioSource.clip = normalMusic;
            audioSource.Play();
            nomralMorality = false;
        }

        if (villianMorality == true)
        {
            audioSource.clip = badMusic;
            audioSource.Play();
            villianMorality = false;
        }
    }


}
