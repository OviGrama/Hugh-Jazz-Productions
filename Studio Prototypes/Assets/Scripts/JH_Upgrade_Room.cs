using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Upgrade_Room : MonoBehaviour
{
    // Upgrade menus
    public GameObject upgradePanel;
    public GameObject upgradeBuildingPanel;

    [HideInInspector] public GameObject selectedRoom;
    private bool upgradingRoom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (upgradingRoom) ClickToUpgrade();
    }

    public void UpgradeRoom()
    {
        if (upgradePanel.activeInHierarchy)
        {
            upgradePanel.SetActive(false);
            upgradingRoom = false;
            selectedRoom = null;
        }
        else
        {
            upgradePanel.SetActive(true);
            upgradingRoom = true;
        }
    }

    public void CloseUpgradePanels()
    {
        upgradePanel.SetActive(false);
    }

    public void UpgradeBuildingMenu()
    {
        if (upgradeBuildingPanel.activeInHierarchy)
        {
            upgradeBuildingPanel.SetActive(false);
        }
        else
        {
            for (int i = 0; i < upgradeBuildingPanel.transform.parent.childCount; i++)
            {
                if (upgradeBuildingPanel.transform.parent.GetChild(i) != upgradeBuildingPanel)
                {
                    upgradeBuildingPanel.transform.parent.GetChild(i).gameObject.SetActive(false);
                }
            }
            upgradeBuildingPanel.SetActive(true);
        }
    }

    void ClickToUpgrade()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            selectedRoom = hit.collider.gameObject;

            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.gameObject.GetComponent<JH_Class_Main>() != null)
                {
                    hit.collider.gameObject.GetComponent<JH_Class_Main>().UpgradeRoom();
                    UpgradeRoom();
                }
            }
        }
    }

    public void CloseAllUpgrades()
    {
        upgradePanel.SetActive(false);
        upgradeBuildingPanel.SetActive(false);
    }
}
