using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_WeekEnd : MonoBehaviour
{
    // Connects to JH_Student_Manager script, to get info on each of the students info taht is attached to the student objects.
    private JH_Student_Manager studentSpawner;
    //
    private AC_SchoolStatsManager schoolStats;
    private AC_GameOver gameOver;
    private AC_YearEnd yearEnd;
    private JH_Time_UI timeUI;

    public GameObject repPanel;
    public Color repColour;
    public float repOpacity;

    // Variables to hold the current student that is being checked, stats.
    public int currentTotalHAP;
    public int currentTotalALI;
    // 
    public int currentAverageHAP;
    public int currentAverageALI;

    //
    public int currentRep;
    public int lowRepTally;

    // Start is called before the first frame update.
    void Awake()
    {
        // So the this script doesnt lose the reference to the JH_Student_Manager script.
        studentSpawner = GameObject.Find("Game").GetComponent<JH_Student_Manager>();
        //
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();
        //
        gameOver = GameObject.Find("GameManager").GetComponent<AC_GameOver>();

        yearEnd = GameObject.Find("GameManager").GetComponent<AC_YearEnd>();
        // So the this script doesnt lose the reference to the JH_Control_Time script.
        timeUI = GameObject.Find("Date/TimePanel").GetComponent<JH_Time_UI>();
    }

    private void Start()
    {
        
    }
    // Update is called once per frame.
    void Update()
    {

    }

    public void WeeklyStudentUpdate()
    {
        Debug.Log("Week Update");
        yearEnd.currentWeek = timeUI.in_week;
        //
        Debug.Log("Reducing Rep");
        schoolStats.schoolRep--;
        currentRep = schoolStats.schoolRep;
        Debug.Log(currentRep);

        if (currentRep < 35 && lowRepTally != 20)
        {
            lowRepTally++;
        }

        if (currentRep >= 35 && lowRepTally != 0)
        {
            lowRepTally--;
        }

        // Fired Ending
        if (lowRepTally == 20)
        {
            gameOver.EarlyRetirementEnd();
        }

        if (currentRep < 25)
        {
           repOpacity = 0.5f;
        }
        else if (currentRep >= 20 && currentRep < 35)
        {
            repOpacity = 0.4f;
        }
        else if (currentRep >= 35 && currentRep < 50)
        {
            repOpacity = 0.3f;
        }
        else if (currentRep >= 50 && currentRep < 65)
        {
            repOpacity = 0.2f;
        }
        else
        {
            repOpacity = 0.1f;
        }

        repColour.a = repOpacity;
        repPanel.GetComponent<Image>().color = repColour;

        currentTotalHAP = 0;
        currentTotalALI = 0;

        for (int i = 0; i < studentSpawner.go_studentList.Length; i++)
        {
            
            // Gets total of all student stats.
            if (studentSpawner.go_studentList[i] != null)
            {
                currentTotalHAP += studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().happinessLevel;
                currentTotalALI += studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().alignmentLevel;
            }
        }

        Debug.Log("Average Check");

        // Finds averages.
        currentAverageHAP = currentTotalHAP / studentSpawner.numberOfStudents;
        currentAverageALI = currentTotalALI / studentSpawner.numberOfStudents;

        // Updates the school stats dropdown.
        schoolStats.avgHappy = currentAverageHAP;
        schoolStats.avgMoral = currentAverageALI;
    }
}
