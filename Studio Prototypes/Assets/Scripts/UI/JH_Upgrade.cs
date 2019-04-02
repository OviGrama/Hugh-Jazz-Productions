using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Upgrade : MonoBehaviour
{
    private AC_SchoolStatsManager sc_schoolStats;
    public bool bl_canBuy;
    public int in_upgradeCost;
    public GameObject[] go_enable;
    public GameObject[] go_disable;
    public GameObject[] go_unlock;
    

    // Start is called before the first frame update
    void Start()
    {
        if (in_upgradeCost != 0)
        {
            sc_schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        // Allows button to be clicked if player can afford the upgrade
        if (in_upgradeCost != 0 && bl_canBuy)
        {
            if (sc_schoolStats.currentMoney - in_upgradeCost >= 0)
            {
                GetComponent<Button>().interactable = true;
            }
            else
            {
                GetComponent<Button>().interactable = false;
            }
        }
        else if (!bl_canBuy)
        {
            GetComponent<Button>().interactable = false;
        }

        if (sc_schoolStats == null)
        {
            sc_schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();
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

        if (go_unlock.Length > 0)
        {
            for (int i = 0; i < go_unlock.Length; i++)
            {
                go_unlock[i].GetComponent<JH_Upgrade>().bl_canBuy = true;
            }
        }

        // Removes money from player
        if (in_upgradeCost != 0)
        {
            sc_schoolStats.currentMoney -= in_upgradeCost;
        }
    }

}
