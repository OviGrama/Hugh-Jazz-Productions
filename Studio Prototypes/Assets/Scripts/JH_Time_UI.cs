using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Time_UI : MonoBehaviour {

    public enum ListDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    public ListDays currentDay;

    public float fl_timeSpeed;
    private int in_currentTime = 8;
    private bool bl_progressTime = true;
    private bool bl_changeClass = true;
    private GameObject go_classManager;
    private Text tx_days;
    private Text tx_time;

	// Use this for initialization
	void Start () {
        go_classManager = GameObject.Find("Main Camera");
        tx_days = transform.GetChild(0).GetComponent<Text>();
        tx_time = transform.GetChild(1).GetComponent<Text>();
        PauseTime();
	}
	
	// Update is called once per frame
	void Update () {
        if (bl_progressTime) StartCoroutine(ProgressTime());
        ChangeDay();
        ChangeClass();
	}

    IEnumerator ProgressTime()
    {
        bl_progressTime = false;
        yield return new WaitForSeconds(fl_timeSpeed);
        in_currentTime++;
        if (in_currentTime == 21) in_currentTime = 7;
        bl_progressTime = true;
    }

    // Changes the current day
    void ChangeDay()
    {
        if (go_classManager.GetComponent<JH_Class_Manager>().currentClass == 0)
        {
            currentDay = ListDays.Monday;
            tx_days.text = currentDay.ToString();
        }
        if (go_classManager.GetComponent<JH_Class_Manager>().currentClass == 2)
        {
            currentDay = ListDays.Tuesday;
            tx_days.text = currentDay.ToString();
        }
        if (go_classManager.GetComponent<JH_Class_Manager>().currentClass == 4)
        {
            currentDay = ListDays.Wednesday;
            tx_days.text = currentDay.ToString();
        }
        if (go_classManager.GetComponent<JH_Class_Manager>().currentClass == 6)
        {
            currentDay = ListDays.Thursday;
            tx_days.text = currentDay.ToString();
        }
        if (go_classManager.GetComponent<JH_Class_Manager>().currentClass == 8)
        {
            currentDay = ListDays.Friday;
            tx_days.text = currentDay.ToString();
        }

        tx_time.text = in_currentTime.ToString() + ":00";
    }

    // Changes the active class
    void ChangeClass()
    {
        if (bl_changeClass && in_currentTime == 12)
        {
            go_classManager.GetComponent<JH_Class_Manager>().currentClass++;
            bl_changeClass = false;
        }

        if (in_currentTime == 13) bl_changeClass = true;

        if (bl_changeClass && in_currentTime == 7)
        {
            go_classManager.GetComponent<JH_Class_Manager>().currentClass++;
            bl_changeClass = false;
        }

        if (in_currentTime == 8) bl_changeClass = true;

        if (in_currentTime >= 18) go_classManager.GetComponent<JH_Class_Manager>().bl_homeTime = true;
        else go_classManager.GetComponent<JH_Class_Manager>().bl_homeTime = false;
    }

    public void PauseTime()
    {
        if (Time.timeScale == 0) Time.timeScale = 1;
        else Time.timeScale = 0;
    }

    public void NormalTime()
    {
        Time.timeScale = 1;
    }

    public void DoubleTime()
    {
        if (Time.timeScale != 2) Time.timeScale = 2;
        else Time.timeScale = 1;
    }
}
