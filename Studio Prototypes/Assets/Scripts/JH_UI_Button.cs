using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_UI_Button : MonoBehaviour {

    public GameObject uiPanel;
    public bool openPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (openPanel) uiPanel.SetActive(true);  
        else uiPanel.SetActive(false);  
	}

    public void ToggleUI()
    {
        if (openPanel) openPanel = false;
        else
        {
            
            for (int i = 0; i < uiPanel.transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i).GetComponent<JH_UI_Button>() != null)
                {
                    if (transform.parent.GetChild(i) != gameObject)
                    {
                        transform.parent.GetChild(i).gameObject.GetComponent<JH_UI_Button>().openPanel = false;
                    }
                }
            }
            openPanel = true;
        }
    }
}
