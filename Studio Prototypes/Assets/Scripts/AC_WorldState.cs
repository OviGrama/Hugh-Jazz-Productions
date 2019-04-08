using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_WorldState : MonoBehaviour
{

    public GameObject go_DescriptionText;
    //public GameObject go_DescriptionImage;

    public Text currentText;
    //public Image currentImage;

    public bool heroWorld;
    public bool neutralWorld;
    public bool villainWorld;
    public bool equalWorld;

    // Start is called before the first frame update
    void Start()
    {
        currentText = go_DescriptionText.GetComponent<Text>();
        //currentImage = go_DescriptionImage.GetComponent<Image>();

        currentText.text = "Neutral";
        neutralWorld = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeWorldState()
    {
        if (heroWorld == false && villainWorld == false)
        {
            currentText.text = "Neutral";
            neutralWorld = true;
        }

        if (heroWorld == true)
        {
            currentText.text = "Hero";
            heroWorld = false;
            neutralWorld = false;
        }

        if (villainWorld == true)
        {
            currentText.text = "Villain";
            villainWorld = false;
            neutralWorld = false;
        }

        if (heroWorld == true && equalWorld == true)
        {
            currentText.text = "Equal";
            equalWorld = true;
            neutralWorld = false;
        }
    }
}
