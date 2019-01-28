using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Class_Main : MonoBehaviour
{
    public GameObject[] upgradeRemove;
    public bool roomUpgraded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradeRoom()
    {
        if (!roomUpgraded)
        {
            for (int i = 0; i < upgradeRemove.Length; i++)
            {
                upgradeRemove[i].SetActive(false);
            }

            roomUpgraded = true;
        }
    }
}
