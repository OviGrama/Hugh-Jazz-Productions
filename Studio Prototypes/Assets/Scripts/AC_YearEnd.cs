using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_YearEnd : MonoBehaviour
{
    // Connects to AC_StudentSpawner script, to get info on each of the students info taht is attached to the student objects.
    private AC_StudentSpawner studentSpawner;
    // Connects to AC_SchoolStatsManager script, to get info on current school reputaion.
    private AC_SchoolStatsManager schoolStats;
    // Connect to JH_Control_Time script, to get the time when a year end.
    private JH_Time_UI timeUI;

    // Variables that hold graduation pass grades.
    public int studentPassGrade;
    public int superPassGrade;
    // Variables that hold the number of students that graduate.
    public int[] numberOfGraduates;
    public int numberOfSuperGraduates;
    // Variables that hold what students do when they graduate.
    public int numberOfNormies;
    public int numberOfHeroes;
    public int numberOfSuperheroes;
    public int numberOfVillians;
    public int numberOfSupervillians;
    // Variables to hold the current student that is being checked, stats.
    private int currentStudentEQ;
    private int currentStudentIQ;
    private int currentStudentFL;
    private int currentStudentSL;
    private float currentStudentALI;

    // Start is called before the first frame update
    void Start()
    {
        // So the this script doesnt lose the reference to the AC_StudentSpawner script.
        studentSpawner = GameObject.Find("GameManager").GetComponent<AC_StudentSpawner>();

        // So the this script doesnt lose the reference to the AC_SchoolStatsManager script.
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();

        // So the this script doesnt lose the reference to the JH_Control_Time script.
        timeUI = GameObject.Find("SchoolStatDropDown").GetComponent<JH_Time_UI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Graduation()
    {
        for (int i = 0; i < studentSpawner.numberOfStudents; i++)
        {
            currentStudentEQ = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().EQ;
            currentStudentIQ = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().IQ;
            currentStudentFL = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().FL;
            currentStudentSL = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().SL;
            currentStudentALI = studentSpawner.go_Students[i].GetComponent<OG_StudentInfo>().fl_Allignment;

            // Has the student passed.
            if (currentStudentEQ + currentStudentIQ + currentStudentFL >= studentPassGrade)
            {
                // Increase the number of graduates.
                numberOfGraduates[timeUI.in_year - 1]++;

                // Is the graduate a super.
                if (currentStudentSL >= superPassGrade)

                {
                    // Increase the number of super graduates.
                    numberOfSuperGraduates++;

                    // Check to see what type of super powered individual the super graduate will become.
                    if (currentStudentALI >= 85)
                    {
                        numberOfSuperheroes++;
                    }

                    if (currentStudentALI >= 65 & currentStudentALI < 85)
                    {
                        numberOfHeroes++;
                    }

                    if (currentStudentALI > 35 & currentStudentALI < 65 || currentStudentSL < superPassGrade)
                    {
                        numberOfNormies++;
                    }

                    if (currentStudentALI < 15 & currentStudentALI <= 35)
                    {
                        numberOfVillians++;
                    }

                    if (currentStudentALI <= 15)
                    {
                        numberOfSupervillians++;
                    }
                }
            } 
        }
    }
}
