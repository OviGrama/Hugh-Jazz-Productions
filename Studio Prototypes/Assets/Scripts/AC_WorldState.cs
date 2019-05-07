using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_WorldState : MonoBehaviour
{

    public GameObject go_DescriptionText;
    public GameObject go_DescriptionImage;

    public Text currentText;
    public Image currentImage;

    // Holds Images for world state chanegs.
    public Image heroImage;
    public Image neutralImage;
    public Image villainImage;
    public Image equalImage;
    public Image heroLeadingImage;
    public Image villainLeadingImage;

    public bool heroWorld;
    public bool neutralWorld;
    public bool villainWorld;
    public bool equalWorld;
    public bool heroLeadingWorld;
    public bool villainLeadingWorld;

    // Start is called before the first frame update
    void Start()
    {
        currentText = go_DescriptionText.GetComponent<Text>();
        currentImage = go_DescriptionImage.GetComponent<Image>();

        currentText.text = "Neutral";
        currentImage = neutralImage;
        neutralWorld = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeWorldState()
    {
        if (neutralWorld == true)
        {
            currentText.text = "Neutral";
            currentImage = neutralImage;
        }

        if (heroWorld == true)
        {
            currentText.text = "Heros";
            currentImage = heroImage;
        }

        if (villainWorld == true)
        {
            currentText.text = "Villains";
            currentImage = villainImage;
        }

        if (equalWorld == true)
        {
            currentText.text = "Equal";
            currentImage = equalImage;
        }

        if (heroLeadingWorld == true)
        {
            currentText.text = "Heroes Leading";
            currentImage = heroLeadingImage;
        }

        if (villainLeadingWorld == true)
        {
            currentText.text = "Villains Leading";
            currentImage = villainImage;
        }
    }
}
