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
    public bool tier3Class;
    public bool iqClass;
    public bool fitnessClass;
    public bool superClass;

    //Creates a connection to the 
    private AC_ClassTiers classTiers;

    // Can the building be brought.
    public bool iqBuildingBuyable;
    public bool fitnessBuildingBuyable;
    public bool superBuildingBuyable;

    // Has the primary class been unlocked.
    public bool iqPrimaryClassBrought;
    public bool fitnessPrimaryClassBrought;
    public bool superPrimaryClassBrought;
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

    public void BuildingBuyable()
    {
        if (iqPrimaryClassBrought == true)
        {
            iqBuildingBuyable = true;
        }

        if (fitnessPrimaryClassBrought == true)
        {
            fitnessBuildingBuyable = true;
        }

        if (superPrimaryClassBrought == true)
        {
            superBuildingBuyable = true;
        }
    }

    public void CanBuy()
    {
        for (int i = 0; i < numberOfClasses; i++)
        {
            tier1Class = go_Classes[i].GetComponent<AC_ClassTiers>().tier1Class;
            tier2Class = go_Classes[i].GetComponent<AC_ClassTiers>().tier2Class;
            tier3Class = go_Classes[i].GetComponent<AC_ClassTiers>().tier3Class;
            iqClass = go_Classes[i].GetComponent<AC_ClassTiers>().tier1Class;
            fitnessClass = go_Classes[i].GetComponent<AC_ClassTiers>().tier2Class;
            superClass = go_Classes[i].GetComponent<AC_ClassTiers>().tier3Class;

            // Teir 1 IQ Classes.
            if (tier1Class == true && iqClass == true)
            {
                if (iqPrimaryClassBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            // Tier 1 Fitness Classes.
            if (tier1Class == true && tier2Class == false && tier3Class == false && iqClass == false && fitnessClass == true && superClass == false)
            {
                if (fitnessPrimaryClassBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            // Tier 1 Super Classes.
            if (tier1Class == true && tier2Class == false && tier3Class == false && iqClass == false && fitnessClass == false && superClass == true)
            {
                if (superPrimaryClassBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }

            // Tier 2 IQ Classes.
            if (tier1Class == false && tier2Class == true && tier3Class == false && iqClass == true && fitnessClass == false && superClass == false)
            {
                if (iqBuildingBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            // Tier 2 Fitness Classes.
            if (tier1Class == false && tier2Class == true && tier3Class == false && iqClass == false && fitnessClass == true && superClass == false)
            {
                if (fitnessBuildingBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            // Tier 2 Super Classes.
            if (tier1Class == false && tier2Class == true && tier3Class == false && iqClass == false && fitnessClass == false && superClass == true)
            {
                if (superBuildingBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }

            // Tier 3 IQ Classes.
            if (tier1Class == false && tier2Class == false && tier3Class == true && iqClass == true && fitnessClass == false && superClass == false)
            {
                if (iqBuildingBrought == true && iqExpantionBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            //Tier 3 Fitness Classes.
            if (tier1Class == false && tier2Class == false && tier3Class == true && iqClass == false && fitnessClass == true && superClass == false)
            {
                if (fitnessBuildingBrought == true && fitnessExpantionBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            // Tier 3 Super Classes.
            if (tier1Class == false && tier2Class == false && tier3Class == true && iqClass == false && fitnessClass == false && superClass == true)
            {
                if (superBuildingBrought == true && superExpantionBrought == true)
                {
                    go_Classes[i].GetComponent<Button>().interactable = true;
                }
            }
            Debug.Log("Test");
        }
    }
}