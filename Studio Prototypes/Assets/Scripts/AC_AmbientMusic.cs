using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_AmbientMusic : MonoBehaviour
{
    // Holds the ambient music.
    public AudioClip roomAudio;

    public bool inRoom = false;

    // Grabs what will play the audio.
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Starts the game on normal background music.
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = roomAudio;

    }

    // Update is called once per frame
    void Update()
    {
  
    }

    private void OnTriggerEnter(Collider other)
    {
        inRoom = true;
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        inRoom = false;
            audioSource.Stop();
    }
}
