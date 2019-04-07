using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
