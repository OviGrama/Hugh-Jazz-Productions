using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Class_Main : MonoBehaviour
{
    public GameObject[] upgradeRemove;
    public bool roomUpgraded;
    private GameObject roomHighlighted;
    private GameObject upgradeRoomUI;

    // Start is called before the first frame update
    void Start()
    {
        upgradeRoomUI = GameObject.Find("Main Camera");
        roomHighlighted = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!roomUpgraded && upgradeRoomUI.GetComponent<JH_Upgrade_Room>().selectedRoom == gameObject)
        {
            roomHighlighted.SetActive(true);
        }
        else roomHighlighted.SetActive(false);
    }

    public void UpgradeRoom()
    {
        if (!roomUpgraded)
        {
            for (int i = 0; i < upgradeRemove.Length; i++)
            {
                upgradeRemove[i].SetActive(false);
            }

            transform.GetChild(1).gameObject.SetActive(false);
            roomUpgraded = true;
        }
    }
}
