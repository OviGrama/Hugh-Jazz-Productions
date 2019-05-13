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

        currentText.text = "The Lansteed School for the Superpowered officially opened its doors on the 1st of September. The Department of Super Occurrences is supposedly keeping a close eye on its performance, and we are eager to see the mark its graduates will make on the world. ";
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
            currentText.text = "The Lansteed School for the Superpowered officially opened its doors on the 1st of September. The Department of Super Occurrences is supposedly keeping a close eye on its performance, and we are eager to see the mark its graduates will make on the world. ";
            currentImage = neutralImage;
        }

        if (heroWorld == true)
        {
            currentText.text = "Several years after the opening of the Lansteed School, it seems that the heroes who graduated have begun to make their presence known, taking on crimes both petty and organised. Statistics from INTERPOL and national crime agencies show that world crime has decreased, a remarkable outcome that we hope will continue";
            currentImage = heroImage;
        }

        if (villainWorld == true)
        {
            currentText.text = "Several years after the opening of the Lansteed School, villains seem to have grown bolder, possibly bolstered by the school’s new graduates. Statistics from INTERPOL and national crime agencies show a rise in both petty and organised crime internationally. What is going on?";
            currentImage = villainImage;
        }

        if (equalWorld == true)
        {
            currentText.text = "Many of the Lansteed School’s students have now graduated, and these heroes and villains have been seen in spectacular battles of good and evil. Eye-witness reports, along with statistics from the Department of Super Occurrences and other watchdogs show that the fight between heroes and villains does not appear to be in either’s favour. We will keep you updated with the current standing as time goes by.";
            currentImage = equalImage;
        }

        if (heroLeadingWorld == true)
        {
            currentText.text = "Many of the Lansteed School’s students have now graduated, and these heroes and villains have been seen in spectacular battles of good and evil. Some good news for you all – eye-witness reports, along with statistics from the Department of Super Occurrences and other watchdogs show that HEROES have taken the lead against the fight between superpowered heroes and villains. Will heroes continue to maintain victory, or will the villains push back even harder? We will keep you updated with the current standing as time goes by";
            currentImage = heroLeadingImage;
        }

        if (villainLeadingWorld == true)
        {
            currentText.text = "Many of the Lansteed School’s students have now graduated, and these heroes and villains have been seen in spectacular battles of good and evil. Troubling news – eye-witness reports, along with statistics from the Department of Super Occurrences and other watchdogs show that VILLAINS have taken the lead against the fight between superpowered heroes and villains. Will the villains continue in their conquest, or will the heroes fight back even harder? We will keep you updated with the current standing as time goes by.";
            currentImage = villainImage;
        }
    }
}
