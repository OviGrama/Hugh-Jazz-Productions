using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_StudentInfo : MonoBehaviour
{
    [Header("Student Look")]
    public Sprite[] StudentsFaces;
    private int in_Random;
    public Image StudentFace;

    [Header("Student Name")]
    public string[] StudentsNamesList;
    public string StudentDisplayName;
    public Text[] StudentNtext;

    [Header("Student Power Type")]
    public string[] PowerTypesList;
    public string PowerType;
    public Text PowerTypetext;

    [Header("Student Specific Power")]
    public string[] PhysicalSpecificPowersList;
    public string[] MentalSpecificPowersList;
    public string SpecificPower;
    public Text SpecificPowertext;

    [Header("Student Stats")]
    public int EQ;
    public int IQ;
    public int FL;
    public int SL;
    public Text EQTxt;
    public Text IQTxt;
    public Text FLTxt;
    public Text SLTxt;

    [Header("Student Happiness")]
    public float fl_Happiness;

    public float fl_CurrentHappines { get; set; }
    public float fl_MaxHappiness { get; set; }

    public Slider sl_HappinessBar;

    [Header("Student Alignment")]
    public float fl_Allignment;

    public float fl_CurrentAllignment { get; set; }
    public float fl_MaxAllignment { get; set; }

    public Slider sl_AllignmentBar;

    // Start is called before the first frame update
    void Start()
    {
        //StudentLook();
        StudentName();
        StudentPowerType();
        StudentSpecificPower();
        StudentHappiness();
        StudentAlignment();
        StudentStats();
    }

    // Update is called once per frame
    void Update()
    {
        sl_HappinessBar.value = SetHappiness();
        sl_AllignmentBar.value = SetAllignment();

    }

    //void StudentLook()
    //{

    //    in_Random = Random.Range(0, StudentsFaces.Length);
    //    StudentFace.sprite = StudentsFaces[in_Random];
    //}

    void StudentName()
    {
        StudentDisplayName = StudentsNamesList[Random.Range(0, StudentsNamesList.Length)];
        for (int i = 0; i < StudentNtext.Length; i++)
        {
            StudentNtext[i].text = StudentDisplayName.ToString();
        }
    }

    void StudentPowerType()
    {
        PowerType = PowerTypesList[Random.Range(0, PowerTypesList.Length)];
        PowerTypetext.text = PowerType.ToString();
    }

    void StudentSpecificPower()
    {
        if(PowerType == "Physical")
        {
            SpecificPower = PhysicalSpecificPowersList[Random.Range(0, PhysicalSpecificPowersList.Length)];
            SpecificPowertext.text = SpecificPower.ToString();
        }

        if (PowerType == "Mental")
        {
            SpecificPower = MentalSpecificPowersList[Random.Range(0, MentalSpecificPowersList.Length)];
            SpecificPowertext.text = SpecificPower.ToString();
        }
    }

    void StudentStats()
    {
        EQ = Random.Range(0, 30);
        IQ = Random.Range(0, 50 - EQ);
        FL = 50 - EQ - IQ;
        SL = Random.Range(0, 10);
        EQTxt.text = "EQ: " + EQ.ToString();
        IQTxt.text = "IQ: " + IQ.ToString();
        FLTxt.text = "Fitness Level: " +  FL.ToString();
        SLTxt.text = "Super Power Level: " + SL.ToString();
    }

    void StudentHappiness()
    {
        fl_MaxHappiness = 40f;
        fl_CurrentHappines = Random.Range(20, 35);
        fl_Happiness = fl_CurrentHappines;
    }
    float SetHappiness()
    {
        return fl_Happiness / fl_MaxHappiness;
    }

    void StudentAlignment()
    {
        fl_MaxAllignment = 100f;
        fl_CurrentAllignment = Random.Range(36, 64);
        fl_Allignment = fl_CurrentAllignment;
    }
    float SetAllignment()
    {
        return fl_Allignment / fl_MaxAllignment;
    }

}
