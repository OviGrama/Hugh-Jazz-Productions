﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Time_UI : MonoBehaviour
{
    // Connects to AC_YearEnd script so graduation function can be called by this script.
    private AC_YearEnd yearEnd;
    private AC_WeekEnd weekEnd;
    private AC_SchoolStatsManager schoolStats;

    public Text tx_year;
    public Text tx_week;
    public Text tx_day;
    public Text tx_time;

    public bool bl_timeControls;

    public int in_year = 1;
    public int in_week = 1;
    [HideInInspector] public int in_time;

    public float fl_secondsPerHour;

    public enum DayNames
    {
        MON,
        TUE,
        WED,
        THUR,
        FRI
    }
    public DayNames dayNames;
    private bool bl_changeTime = true;

    private GameObject[] go_classManagers;

    private ColorBlock cb_newColors;
    private ColorBlock cb_oldColors;
    public Color c_activeColor;
    public GameObject go_playButton;
    public GameObject go_pauseButton;
    public GameObject go_doubleSpeedButton;
    public GameObject go_skipButton;

    private bool bl_dayDebug = true;

    // Start is called before the first frame update
    void Start()
    {
        // So the this script doesnt lose the reference to the AC_YearEnd script.
        yearEnd = GameObject.Find("GameManager").GetComponent<AC_YearEnd>();
        weekEnd = GameObject.Find("GameManager").GetComponent<AC_WeekEnd>();
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();

        go_classManagers = new GameObject[3];
        in_time = 6;
        cb_oldColors = go_playButton.GetComponent<Button>().colors;
        cb_newColors = cb_oldColors;
        cb_newColors.normalColor = c_activeColor;
        go_classManagers[0] = GameObject.Find("ClassDrops");
        go_classManagers[1] = GameObject.Find("ClassDrops2");
        go_classManagers[2] = GameObject.Find("ClassDrops3");
        in_year = 1;
        in_week = 1;
        tx_time.text = in_time.ToString() + ":00";
    }

    // Update is called once per frame
    void Update()
    {
        tx_year.text = "Year: " + in_year.ToString();
        tx_week.text = "Week: " + in_week.ToString();
        tx_day.text = dayNames.ToString();
        tx_time.text = in_time.ToString() + ":00";
        if (bl_changeTime) StartCoroutine(TimeUpdate());
        ChangeClass();
        UpdateTimeButtons();

        // Debug to move time quickly
        if (Input.GetKeyDown(KeyCode.T)) Time.timeScale = 100;
        if (Input.GetKeyUp(KeyCode.T)) Time.timeScale = 1;

        if (Input.GetKeyDown(KeyCode.Y)) UpdateDay();
    }

    void UpdateDay()
    {
        if (dayNames != DayNames.FRI)
        {
            dayNames += 1;
        }
        else
        {
            in_week += 1;
            dayNames = DayNames.MON;
            weekEnd.WeeklyStudentUpdate();
        }

        if (in_week == 40)
        {
            in_year += 1;
            in_week = 1;
            yearEnd.Graduation();
        }
    }

    public bool firstUpdate;

    IEnumerator TimeUpdate()
    {
        if (firstUpdate == false)
        {
            yearEnd.FirstYear();
            schoolStats.FirstUpdate();
            firstUpdate = true;

            // pause game
            // pause needs to disable all other UI
            // open timetable
            // have close button turned off until all classes are filled.
        }

        bl_changeTime = false;
        yield return new WaitForSeconds(fl_secondsPerHour);
        if (in_time < 23)
        {
            in_time++;
        }
        else
        {
            in_time = 0;
            UpdateDay();
        }
        bl_changeTime = true;
    }

    void ChangeClass()
    {
        for (int i = 0; i < go_classManagers.Length; i++)
        {


            if (dayNames == DayNames.MON)
            {
                if (in_time < 11)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().mondayAM;
                }
                if (in_time > 12)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().mondayPM;
                }
            }
            if (dayNames == DayNames.TUE)
            {
                if (in_time < 11)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().tuesdayAM;
                }
                if (in_time > 12)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().tuesdayPM;
                }
            }
            if (dayNames == DayNames.WED)
            {
                if (in_time < 11)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().wednesdayAM;
                }
                if (in_time > 12)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().wednesdayPM;
                }
            }
            if (dayNames == DayNames.THUR)
            {
                if (in_time < 11)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().thursdayAM;
                }
                if (in_time > 12)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().thursdayPM;
                }
            }
            if (dayNames == DayNames.FRI)
            {
                if (in_time < 11)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().fridayAM;
                }
                if (in_time > 12)
                {
                    go_classManagers[i].GetComponent<JH_Assign_Class>().currentClass =
                    go_classManagers[i].GetComponent<JH_Assign_Class>().fridayPM;
                }
            }
        }
    }

    public void PauseButton()
    {
        if (bl_timeControls)
        {
            if (Time.timeScale == 0) Time.timeScale = 1;
            else Time.timeScale = 0;
        }
    }

    public void PlayButton()
    {
        if (bl_timeControls)
        {
            Time.timeScale = 1;
        }
    }

    public void DoubleSpeedButton()
    {
        if (bl_timeControls)
        {
            Time.timeScale = 2;
        }
    }

    public void SkipForward()
    {
        if (bl_timeControls)
        {
            UpdateDay();
            in_time = 7;
        }
    }

    void UpdateTimeButtons()
    {
        if (Time.timeScale == 0)
        {
            go_pauseButton.GetComponent<Button>().colors = cb_newColors;
            go_playButton.GetComponent<Button>().colors = cb_oldColors;
            go_doubleSpeedButton.GetComponent<Button>().colors = cb_oldColors;
        }
        if (Time.timeScale == 1)
        {
            go_playButton.GetComponent<Button>().colors = cb_newColors;
            go_pauseButton.GetComponent<Button>().colors = cb_oldColors;
            go_doubleSpeedButton.GetComponent<Button>().colors = cb_oldColors;
        }
        if (Time.timeScale == 2)
        {
            go_doubleSpeedButton.GetComponent<Button>().colors = cb_newColors;
            go_pauseButton.GetComponent<Button>().colors = cb_oldColors;
            go_playButton.GetComponent<Button>().colors = cb_oldColors;
        }

        if (in_time >= 19)
        {
            go_skipButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            go_skipButton.GetComponent<Button>().interactable = false;
        }
    }
}
