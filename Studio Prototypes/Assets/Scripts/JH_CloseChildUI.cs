using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_CloseChildUI : MonoBehaviour
{
    public GameObject go_parentObject;
    public bool bl_closeParent;
    
    // Closes childed objects and then the parent if bool is true
    public void CloseChild()
    {
        for (int i = 0; i < go_parentObject.transform.childCount; i++)
        {
            go_parentObject.transform.GetChild(i).gameObject.SetActive(false);
        }

        if (bl_closeParent) go_parentObject.SetActive(false);
    }
}
