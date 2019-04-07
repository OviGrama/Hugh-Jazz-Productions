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

    // Variables to hold the current student that is being checked, stats.
    private int currentTotalHAP;
    private int currentTotalALI;
    // 
    private int currentAverageHAP;
    private int currentAverageALI;



    // Start is called before the first frame update.
    void Start()
    {
        // So the this script doesnt lose the reference to the JH_Student_Manager script.
        studentSpawner = GameObject.Find("Game").GetComponent<JH_Student_Manager>();

        //
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();
    }

    // Update is called once per frame.
    void Update()
    {

    }

    public void WeeklyStudentUpdate()
    {
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

        // Finds averages.
        currentAverageHAP = currentTotalHAP / studentSpawner.go_studentList.Length;
        currentAverageALI = currentTotalALI / studentSpawner.go_studentList.Length;

        // Updates the school stats dropdown.
        schoolStats.avgHappy = currentAverageHAP;
        schoolStats.avgMoral = currentAverageALI;
    }
}
