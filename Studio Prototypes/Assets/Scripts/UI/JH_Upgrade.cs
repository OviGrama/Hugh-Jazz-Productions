using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Upgrade : MonoBehaviour
{
    private AC_SchoolStatsManager sc_schoolStats;
    public int in_upgradeCost;
    public GameObject[] go_enable;
    public GameObject[] go_disable;
    

    // Start is called before the first frame update
    void Start()
    {
        sc_schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();
    }

    // Update is called once per frame
    void Update()
    {

        // Allows button to be clicked if player can afford the upgrade
        if (sc_schoolStats.currentMoney - in_upgradeCost >= 0)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }


    public void ButtonClick()
    {
        // Enables selected GameObjects
        if (go_enable.Length > 0)
        {
            for (int i = 0; i < go_enable.Length; i++)
            {
                go_enable[i].SetActive(true);
            }
        }

        // Disables selected GameObjects
        if (go_disable.Length > 0)
        {
            for (int i = 0; i < go_disable.Length; i++)
            {
                go_disable[i].SetActive(false);
            }
        }

        // Removes money from player
        sc_schoolStats.currentMoney -= in_upgradeCost;
    }

}
