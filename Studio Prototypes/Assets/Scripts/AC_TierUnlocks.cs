using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_TierUnlocks : MonoBehaviour
{
    //
    public GameObject[] go_Classes;
    public int numberOfClasses;

    public bool tier1Class;
    public bool tier2Class;
    public bool iqClass;
    public bool fitnessClass;
    public bool superClass;

    //Creates a connection to the 
    private AC_ClassTiers classTiers;

    // Can the building be brought.
    public bool iqBuildingBuyable;
    public bool fitnessBuildingBuyable;
    public bool superBuildingBuyable;
    // Is the building unlocked.
    public bool iqBuildingBrought;
    public bool fitnessBuildingBrought;
    public bool superBuildingBrought;
    // Is the class expanded.
    public bool iqExpantionBrought;
    public bool fitnessExpantionBrought;
    public bool superExpantionBrought;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CanBuy()
    {
        for (int i = 0; i < numberOfClasses; i++)
        {
            tier1Class = go_Classes[i].GetComponent<AC_ClassTiers>().tier1Class;
            tier2Class = go_Classes[i].GetComponent<AC_ClassTiers>().tier2Class;
            iqClass = go_Classes[i].GetComponent<AC_ClassTiers>().iqClass;
            fitnessClass = go_Classes[i].GetComponent<AC_ClassTiers>().fitnessClass;
            superClass = go_Classes[i].GetComponent<AC_ClassTiers>().superClass;

            // Tier 1 IQ Classes.
            if (tier1Class == true && tier2Class == false  && iqClass == true && fitnessClass == false && superClass == false)
            {
                if (iqBuildingBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            // Tier 1 Fitness Classes.
            if (tier1Class == true && tier2Class == false  && iqClass == false && fitnessClass == true && superClass == false)
            {
                if (fitnessBuildingBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            // Tier 1 Super Classes.
            if (tier1Class == true && tier2Class == false && iqClass == false && fitnessClass == false && superClass == true)
            {
                if (superBuildingBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }

            // Tier 2 IQ Classes.
            if (tier1Class == false && tier2Class == true && iqClass == true && fitnessClass == false && superClass == false)
            {
                if (iqBuildingBrought == true && iqExpantionBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            //Tier 2 Fitness Classes.
            if (tier1Class == false && tier2Class == true && iqClass == false && fitnessClass == true && superClass == false)
            {
                if (fitnessBuildingBrought == true && fitnessExpantionBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            // Tier 2 Super Classes.
            if (tier1Class == false && tier2Class == true && iqClass == false && fitnessClass == false && superClass == true)
            {
                if (superBuildingBrought == true && superExpantionBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
        }
    }
}