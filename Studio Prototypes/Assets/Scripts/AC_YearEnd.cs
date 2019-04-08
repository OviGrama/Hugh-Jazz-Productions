using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_YearEnd : MonoBehaviour
{
    // Connects to JH_Student_Manager script, to get info on each of the students info taht is attached to the student objects.
    private JH_Student_Manager studentSpawner;
    // Connects to AC_SchoolStatsManager script, to get info on current school reputaion.
    private AC_SchoolStatsManager schoolStats;
    // Connect to JH_Control_Time script, to get the time when a year end.
    private JH_Time_UI timeUI;

    private OG_RandomEvents randomEvents;

    // Variables that hold graduation pass grades.
    public int studentPassGrade;
    public int superPassGrade;
    // Variables that hold the number of students that graduate.
    public int[] numberOfGraduates;
    public int numberOfSuperGraduates;
    public int nonGraduatestsForYear;
    // Variables that hold what students do when they graduate.
    public int numberOfNormies;
    public int numberOfHeroes;
    public int numberOfSuperheroes;
    public int numberOfVillians;
    public int numberOfSupervillians;
    // For world state.
    public int heroesInWorld;
    public int villiansInWorld;
    // Variables to hold the current student that is being checked, stats.
    private int currentStudentEQ;
    private int currentStudentIQ;
    private int currentStudentFL;
    private int currentStudentSL;
    private int currentStudentHAP;
    private int currentStudentALI;


    //
    private int currentRep;

    // Start is called before the first frame update
    void Start()
    {
        randomEvents = GameObject.Find("GameManager").GetComponent<OG_RandomEvents>();

        // So the this script doesnt lose the reference to the JH_Student_Manager script.
        studentSpawner = GameObject.Find("Game").GetComponent<JH_Student_Manager>();

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
        currentRep = schoolStats.currentRep;

        for (int i = 0; i < studentSpawner.go_studentList.Length; i++)
        {
            if (studentSpawner.go_studentList[i] != null)
            {

                currentStudentEQ = studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().EQ;
                currentStudentIQ = studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().IQ;
                currentStudentFL = studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().FL;
                currentStudentSL = studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().SL;
                currentStudentHAP = studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().happinessLevel;
                currentStudentALI = studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().alignmentLevel;

                // Has the student passed.
                if (currentStudentEQ + currentStudentIQ + currentStudentFL >= studentPassGrade)
                {
                    // Increase the number of graduates.
                    //numberOfGraduates[timeUI.in_year - 1]++;

                    // Is the graduate a super.
                    if (currentStudentSL >= superPassGrade)
                    {
                        // Increase the number of super graduates.
                        numberOfSuperGraduates++;

                        // Check to see what type of super powered individual the super graduate will become.
                        if (currentStudentALI >= 85)
                        {
                            numberOfSuperheroes++;
                            heroesInWorld += 2;
                        }

                        if (currentStudentALI >= 65 && currentStudentALI < 85)
                        {
                            numberOfHeroes++;
                            heroesInWorld++;
                        }

                        if (currentStudentALI > 35 && currentStudentALI < 65 || currentStudentSL < superPassGrade)
                        {
                            numberOfNormies++;
                        }

                        if (currentStudentALI > 15 && currentStudentALI <= 35)
                        {
                            numberOfVillians++;
                            villiansInWorld++;
                        }

                        if (currentStudentALI <= 15)
                        {
                            numberOfSupervillians++;
                            villiansInWorld += 2;
                        }
                    }
                }
                else
                { 
                    nonGraduatestsForYear++;
                }
            }
        }

        if (nonGraduatestsForYear > 0)
        {
            currentRep -= Mathf.RoundToInt(nonGraduatestsForYear / schoolStats.currentAvgHappy);
        }


        // Updates random event deck.
        if (heroesInWorld >= 10)
        {
            randomEvents.bl_herosNumberReached = true;
        }
        if (villiansInWorld >= 10)
        {
            randomEvents.bl_villainsNumberReached = true;
        }
        randomEvents.HeroVillainDecks();

        // Clears student array.
        for (int i = 0; i < studentSpawner.go_studentList.Length; i++)
        {
            if (studentSpawner.go_studentList[i] != null)
            {
                Destroy(studentSpawner.go_studentList[i]);
            }
        }

        // Sets students number based of graduation results.

        // Budget increase for the year.
        schoolStats.currentMoney += 30000 + (currentRep * 500);

        // Limits number of students to form sizes.
        if (studentSpawner.in_dormUpgrades != 0)
        {
            studentSpawner.in_spawnAmount = 9 * studentSpawner.in_dormUpgrades;
        }
        else
        {
            studentSpawner.in_spawnAmount = 9;
        }

        studentSpawner.SpawnStudents();

    }
}