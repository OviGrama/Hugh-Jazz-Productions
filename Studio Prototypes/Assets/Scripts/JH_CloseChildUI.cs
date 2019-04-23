using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_CloseChildUI : MonoBehaviour
{
    public GameObject go_parentObject;
    public GameObject[] go_parentObjects;
    public bool bl_closeParent;
    
    // Closes childed objects and then the parent if bool is true
    public void CloseChild()
    {
        if (go_parentObject != null)
        {
            for (int i = 0; i < go_parentObject.transform.childCount; i++)
            {
                go_parentObject.transform.GetChild(i).gameObject.SetActive(false);
            }

            if (bl_closeParent) go_parentObject.SetActive(false);
        }
        if (go_parentObjects.Length > 0)
        {
            for (int i = 0; i < go_parentObjects.Length; i++)
            {
                for (int j = 0; j < go_parentObjects[i].transform.childCount; j++)
                {
                    go_parentObjects[i].transform.GetChild(j).gameObject.SetActive(false);
                }

                if (bl_closeParent) go_parentObjects[i].SetActive(false);
            }
        }
    }
}
