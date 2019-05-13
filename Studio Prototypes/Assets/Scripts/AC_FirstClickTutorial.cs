using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_FirstClickTutorial : MonoBehaviour
{
    private JH_Time_UI timeUI;

    public GameObject timetableButton;

    public GameObject upgradesButton;
    public GameObject upgradeTutPanel;
    public GameObject upgradeTutClose;
    public GameObject infoButton;
    public GameObject infoTutPanel;
    public GameObject infoTutClose;
    public GameObject worldstateButton;
    public GameObject worldstateTutPanel;
    public GameObject worldstateTutButton;

    public bool upgradeTutorialDone;
    public bool infoTutorialDone;
    public bool worldstateTutorialDone;

    // Start is called before the first frame update
    void Start()
    {
        timeUI = GameObject.Find("Date/TimePanel").GetComponent<JH_Time_UI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradeFirstClick()
    {
        if (upgradeTutorialDone == false)
        {
            timeUI.PauseButton();
            upgradeTutorialDone = true;
            upgradeTutPanel.SetActive(true);
            //timetableButton.GetComponent<Button>().interactable = false;
            //upgradesButton.GetComponent<Button>().interactable = false;
            //infoButton.GetComponent<Button>().interactable = false;
            //worldstateButton.GetComponent<Button>().interactable = false;
        }
    }

    public void InfoFirstClick()
    {
        if (infoTutorialDone == false)
        {
            timeUI.PauseButton();
            infoTutorialDone = true;
            infoTutPanel.SetActive(true);
            //timetableButton.GetComponent<Button>().interactable = false;
            //upgradesButton.GetComponent<Button>().interactable = false;
            //infoButton.GetComponent<Button>().interactable = false;
            //worldstateButton.GetComponent<Button>().interactable = false;
        }
    }

    public void WorldStateFirstClick()
    {
        if (worldstateTutorialDone == false)
        {
            timeUI.PauseButton();
            worldstateTutorialDone = true;
            worldstateTutPanel.SetActive(true);
            //timetableButton.GetComponent<Button>().interactable = false;
            //upgradesButton.GetComponent<Button>().interactable = false;
            //infoButton.GetComponent<Button>().interactable = false;
            //worldstateButton.GetComponent<Button>().interactable = false;
        }
    }

    public void CloseTutorial()
    {
        if (upgradeTutorialDone == true)
        {
            timeUI.PlayButton();
            upgradeTutPanel.SetActive(false);
            //timetableButton.GetComponent<Button>().interactable = true;
            //upgradesButton.GetComponent<Button>().interactable = true;
            //infoButton.GetComponent<Button>().interactable = true;
            //worldstateButton.GetComponent<Button>().interactable = true;
        }

        if (infoTutorialDone == true)
        {
            timeUI.PlayButton();
            infoTutPanel.SetActive(false);
            //timetableButton.GetComponent<Button>().interactable = true;
            //upgradesButton.GetComponent<Button>().interactable = true;
            //infoButton.GetComponent<Button>().interactable = true;
            //worldstateButton.GetComponent<Button>().interactable = true;
        }

        if (worldstateTutorialDone == true)
        {
            timeUI.PlayButton();
            worldstateTutPanel.SetActive(false);
            //timetableButton.GetComponent<Button>().interactable = true;
            //upgradesButton.GetComponent<Button>().interactable = true;
            //infoButton.GetComponent<Button>().interactable = true;
            //worldstateButton.GetComponent<Button>().interactable = true;
        }
    }
}
