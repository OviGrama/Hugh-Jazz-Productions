using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_WeekEnd : MonoBehaviour
{
    // Connects to AC_StudentSpawner script, to get info on each of the students info taht is attached to the student objects.
    private JH_Student_Manager studentSpawner;
    //
    private AC_SchoolStatsManager schoolStats;

    // Variables to hold the current student that is being checked, stats.
    private int currentAverageHAP;
    private int currentAverageALI;


    // Start is called before the first frame update
    void Start()
    {
        // So the this script doesnt lose the reference to the AC_StudentSpawner script.
        studentSpawner = GameObject.Find("Game").GetComponent<JH_Student_Manager>();

        //
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WeeklyStudentUpdate()
    {
        for (int i = 0; i < studentSpawner.go_studentList.Length; i++)
        {
            if (studentSpawner.go_studentList[i] != null)
            {
                currentAverageALI = studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().happinessLevel;
                currentAverageHAP = studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().alignmentLevel;
            }
        }
    }
}
