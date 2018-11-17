using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OG_RandomSprite : MonoBehaviour {

    private int in_rand;

    public Sprite[] Sprite_Pics;

	// Use this for initialization
	void Start () {

        Randomise();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Randomise();
        }
		
	}

    void Randomise()
    {
        in_rand = Random.Range(0, Sprite_Pics.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Pics[in_rand];
    }
}
