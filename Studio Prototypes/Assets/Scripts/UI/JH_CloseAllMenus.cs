using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_CloseAllMenus : MonoBehaviour
{
    public GameObject go_mainPanel;
    public bool bl_closeThisPanel;
    public GameObject[] go_otherPanels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseClick()
    {
        for (int i = 0; i < go_otherPanels.Length; i++)
        {
            go_otherPanels[i].SetActive(false);
        }
        if (bl_closeThisPanel) go_mainPanel.SetActive(false);
    }
}
