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
    // Connects to the AC_GameOver script.
    private AC_GameOver gameOver;
    //
    private AC_WorldState worldState;
    //
    private OG_RandomEvents randomEvents;

    // Variables that hold graduation pass grades.
    public int studentPassGrade;
    public int superPassGrade;
    // Variables that hold the number of students that graduate.
    public int[] numberOfGraduates;
    public int[] numberOfNonGraduates;
    public int numberOfSuperGraduates;
    public int graduatesForYear;
    public int nongraduatesForYear;
    // Variables that hold what students do when they graduate.
    public int numberOfNormies;
    public int numberOfHeroes;
    public int numberOfSuperheroes;
    public int numberOfVillians;
    public int numberOfSupervillians;
    // For world state.
    public int heroesInWorld;
    public int villiansInWorld;
    public int superDifference;
    // Variables to hold the current student that is being checked, stats.
    private int currentStudentEQ;
    private int currentStudentIQ;
    private int currentStudentFL;
    private int currentStudentSL;
    private int currentStudentHAP;
    private int currentStudentALI;

    public float passValue;
    public int passPercentage;
    public int currentYear;
    public int currentWeek;
    public int yearSize;

    //
    private int currentRep;

    // Start is called before the first frame update
    void Awake()
    {
        //
        worldState = GameObject.Find("GameManager").GetComponent<AC_WorldState>();

        //
        randomEvents = GameObject.Find("GameManager").GetComponent<OG_RandomEvents>();

        // So the this script doesnt lose the reference to the JH_Student_Manager script.
        studentSpawner = GameObject.Find("Game").GetComponent<JH_Student_Manager>();

        // So the this script doesnt lose the reference to the AC_SchoolStatsManager script.
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();

        // So the this script doesnt lose the reference to the JH_Control_Time script.
        timeUI = GameObject.Find("Date/TimePanel").GetComponent<JH_Time_UI>();

        //
        gameOver = GameObject.Find("GameManager").GetComponent<AC_GameOver>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FirstYear()
    {
        currentYear = timeUI.in_year;
        yearSize = studentSpawner.numberOfStudents;
        currentRep = schoolStats.schoolRep;
    }

    public void Graduation()
    {
        currentYear = timeUI.in_year;
        yearSize = studentSpawner.numberOfStudents;
        currentRep = schoolStats.schoolRep;

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
                    numberOfGraduates[currentYear - 2]++;

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
                    numberOfNonGraduates[currentYear - 2]++;
                }
            }
        }

        graduatesForYear = numberOfGraduates[currentYear - 2];
        nongraduatesForYear = numberOfNonGraduates[currentYear - 2];

        PassPercentage();

        if (nongraduatesForYear > 0)
        {
            currentRep -= passPercentage / 10;
        }

        // Number of Hero and Villian in the world.

        // Resets world state booleans.
        worldState.neutralWorld = false;
        worldState.heroWorld = false;
        worldState.villainWorld = false;
        worldState.equalWorld = false;
        worldState.heroLeadingWorld = false;
        worldState.villainWorld = false;

        // Updates random event deck and world state.
        if (heroesInWorld >= 10)
        {
            randomEvents.bl_herosNumberReached = true;
            worldState.heroWorld = true;
        }

        if (villiansInWorld >= 10)
        {
            randomEvents.bl_villainsNumberReached = true;
            worldState.villainWorld = true;
        }

        if (worldState.heroWorld == false && worldState.villainWorld == false)
        {
            worldState.neutralWorld = true;
        }

        if (worldState.heroWorld == true && worldState.villainWorld == true)
        {
            worldState.equalWorld = true;
        }

        // Calculates the difference between heroes and villains in order to find who is in the lead. 
        superDifference = heroesInWorld - villiansInWorld;

        if (superDifference < 0)
        {
            superDifference = superDifference * -1;

            if (superDifference > 10)
            {
                if (worldState.equalWorld == true)
                {
                    worldState.equalWorld = false;
                    worldState.villainLeadingWorld = true;
                    worldState.heroWorld = false;
                    worldState.villainWorld = false;
                }
            }

            // Villain End
            if (superDifference > 150)
            {
                gameOver.VillainDestructionEnd();
            }
        }
        else
        {
            if (superDifference > 10)
            {
                if (worldState.equalWorld == true)
                {
                    worldState.equalWorld = false;
                    worldState.heroLeadingWorld = true;
                    worldState.heroWorld = false;
                    worldState.villainWorld = false;
                }
            }

            // Hero End
            if (superDifference > 150)
            {
                gameOver.HeroPeaceEnd();
            }
        }

        randomEvents.HeroVillainDecks();
        worldState.ChangeWorldState();


        // Clears student array.
        for (int i = 0; i < studentSpawner.go_studentList.Length; i++)
        {
            if (studentSpawner.go_studentList[i] != null)
            {
                Destroy(studentSpawner.go_studentList[i]);
            }
        }


        // Ends the game if 25 years have passed.
        if (currentYear == 26)
        {
            Debug.Log("25 Years Retirment");
            gameOver.Year25RetirementEnd();
        }

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

        schoolStats.schoolRep = currentRep;

    }

    void PassPercentage()
    {
        // Sets students number based of graduation results.
        Debug.Log("Pass Percentage");
        //passValue = graduatesForYear / studentSpawner.numberOfStudents;

        passValue = (graduatesForYear / yearSize) * 100;
        Debug.Log(passValue);
    }
}
