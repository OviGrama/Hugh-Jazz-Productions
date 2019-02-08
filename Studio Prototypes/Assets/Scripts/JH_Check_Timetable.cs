using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Check_Timetable : MonoBehaviour
{

    public bool bl_canSave;
    public bool bl_isSaved;
    private GameObject go_saveButton;
    private GameObject go_savedPanel;
    

    // Start is called before the first frame update
    void Start()
    {
        go_saveButton = GameObject.Find("Save_Button");
        go_savedPanel = GameObject.Find("ClassChangePanel");
        go_savedPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!bl_isSaved) CheckSave();
        if (bl_canSave && !bl_isSaved) go_saveButton.GetComponent<Button>().interactable = true;
        else go_saveButton.GetComponent<Button>().interactable = false;
    }


    // Checks if the timetable is fully filled and can be saved
    void CheckSave()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).GetComponent<OG_DropZone>() != null)
            {
                if (transform.GetChild(i).childCount != 3)
                {
                    GameObject.Find("Time UI").GetComponent<JH_Time_UI>().bl_canChangeTime = false;
                    bl_canSave = false;
                    return;
                }
            }
        }
        bl_canSave = true;
    }


    // Saves the timetable
    public void SaveTimetable()
    {
        if (!bl_isSaved)
        {
            bl_isSaved = true;
            GameObject.Find("Time UI").GetComponent<JH_Time_UI>().bl_canChangeTime = true;
            go_savedPanel.SetActive(true);
            StartCoroutine(SavePanel());
        }
    }

    // Closes the alert that says the timetable was saved
    IEnumerator SavePanel()
    {
        yield return new WaitForSecondsRealtime(2);
        go_savedPanel.SetActive(false);
    }
}
