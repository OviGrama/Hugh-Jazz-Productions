using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Student_Stats : MonoBehaviour
{
    [Header("Student Stats")]
    public int EQ;
    public int IQ;
    public int FL;
    public int SL;

    public int happinessLevel;
    public int alignmentLevel;
    
    private int maxStartHappiness;
    private int minStartHappiness;
    private int maxStartAlignment;
    private int minStartAlignment;

    public string superPower;

    private JH_Student_Manager studentManager;
    private JH_Time_UI timeManager;

    [HideInInspector] public int previousEQ;
    [HideInInspector] public int previousIQ;
    [HideInInspector] public int previousFL;
    [HideInInspector] public int previousSL;
    [HideInInspector] public int previousHappiness;
    [HideInInspector] public int previousAlignment;

    private GameObject go_studentStatList;
    private int in_listPosition;

    // Start is called before the first frame update
    void Start()
    {
        studentManager = GameObject.Find("Game").GetComponent<JH_Student_Manager>();
        timeManager = GameObject.Find("Date/TimePanel").GetComponent<JH_Time_UI>();
        maxStartHappiness = studentManager.maxStartHappiness;
        minStartHappiness = studentManager.minStartHappiness;
        maxStartAlignment = studentManager.maxStartAlignment;
        minStartAlignment = studentManager.minStartAlignment;

        EQ = Random.Range(1, 31);
        IQ = Random.Range(1, 51 - EQ);
        FL = 50 - (EQ - IQ);
        SL = Random.Range(1, 11);
        happinessLevel = Random.Range(minStartHappiness, maxStartHappiness + 1);
        alignmentLevel = Random.Range(minStartAlignment, maxStartAlignment + 1);

        if (Random.Range(1, 3) == 1)
        {
            superPower = studentManager.physicalPowers[Random.Range(0, studentManager.physicalPowers.Length)];
        }
        else
        {
            superPower = studentManager.mentalPowers[Random.Range(0, studentManager.mentalPowers.Length)];
        }

        previousEQ = EQ;
        previousIQ = IQ;
        previousFL = FL;
        previousSL = SL;
        previousHappiness = happinessLevel;
        previousAlignment = alignmentLevel;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeManager.dayNames == JH_Time_UI.DayNames.MON && timeManager.in_time == 9)
        {
            UpdateNewWeek();
        }

        UpdateStats();
    }

    void UpdateNewWeek()
    {
        previousEQ = EQ;
        previousIQ = IQ;
        previousFL = FL;
        previousSL = SL;
        previousHappiness = happinessLevel;
        previousAlignment = alignmentLevel;
    }

    void UpdateStats()
    {
        if (go_studentStatList == null) go_studentStatList = GameObject.Find("StudentButtonListContent");
        else
        {
            if (go_studentStatList.activeInHierarchy)
            {
                for (int i = 0; i < studentManager.GetComponent<JH_Student_Manager>().go_studentList.Length; i++)
                {
                    if (studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].gameObject == gameObject)
                    {
                        go_studentStatList.transform.GetChild(i).GetChild(0).GetComponent<Text>().text =
                        GetComponent<JH_Student_Appearance>().studentName;



                        JH_Show_Student_Stats newStudentStats;

                        newStudentStats = go_studentStatList.transform.GetChild(i).GetComponent<JH_Show_Student_Stats>();
                        newStudentStats.studentName = GetComponent<JH_Student_Appearance>().studentName;
                        newStudentStats.studentPower = superPower;
                        newStudentStats.EQ = EQ;
                        newStudentStats.IQ = IQ;
                        newStudentStats.FL = FL;
                        newStudentStats.SL = SL;
                        newStudentStats.happinessLevel = happinessLevel;
                        newStudentStats.alignmentLevel = alignmentLevel;
                        newStudentStats.previousEQ = previousEQ;
                        newStudentStats.previousIQ = previousIQ;
                        newStudentStats.previousFL = previousFL;
                        newStudentStats.previousSL = previousSL;
                        newStudentStats.previousHappiness = previousHappiness;
                        newStudentStats.previousAlignment = previousAlignment;
                        newStudentStats.studentBody = GetComponent<JH_Student_Appearance>().studentBody;
                        newStudentStats.studentHead = GetComponent<JH_Student_Appearance>().studentHead;

                        return;
                    }
                }


            }
        }
        
    }
}
