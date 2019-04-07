using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_WeekEnd : MonoBehaviour
{
    // Connect to JH_Control_Time script, to get the time when a year end.
    private JH_Time_UI timeUI;

    // Connects to AC_StudentSpawner script, to get info on each of the students info taht is attached to the student objects.
    private AC_StudentSpawner studentSpawner;

    // Variables to hold the current student that is being checked, stats.
    private int currentStudentEQ;
    private int currentStudentIQ;
    private int currentStudentFL;
    private int currentStudentSL;
    private float currentStudentALI;

    // Start is called before the first frame update
    void Start()
    {
        // So the this script doesnt lose the reference to the JH_Control_Time script.
        timeUI = GameObject.Find("Date/TimePanel").GetComponent<JH_Time_UI>();

        // So the this script doesnt lose the reference to the AC_StudentSpawner script.
        studentSpawner = GameObject.Find("GameManager").GetComponent<AC_StudentSpawner>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WeeklyStudentUpdate()
    {
        for (int i = 0; i < studentSpawner.numberOfStudents; i++)
        {
            currentStudentEQ = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().EQ;
            currentStudentIQ = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().IQ;
            currentStudentFL = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().FL;
            currentStudentSL = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().SL;
            currentStudentALI = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().fl_Allignment;

        }
    }
}
