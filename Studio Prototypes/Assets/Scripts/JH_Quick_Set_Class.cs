using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Quick_Set_Class : MonoBehaviour
{
    private Dropdown dd_classes;
    private GameObject[] go_timetableManagers;
    public Dropdown[] dd_classDropdowns;
    public JH_Set_Class.GroupNumber groupNumber;
    public JH_Set_Class.ClassName firstCurrentClass;
    [HideInInspector] public JH_Set_Class.ClassName firstPreviousClass;
    public JH_Set_Class.ClassName secondCurrentClass;
    [HideInInspector] public JH_Set_Class.ClassName secondPreviousClass;
    public JH_Set_Class.ClassName thirdCurrentClass;
    [HideInInspector] public JH_Set_Class.ClassName thirdPreviousClass;

    private GameObject go_studentManager;

    public int firstGroupEQChange;
    public int firstGroupIQChange;
    public int firstGroupFLChange;
    public int firstGroupSLChange;
    public int firstGroupHappinessChange;
    public int firstGroupAlignmentChange;

    public int secondGroupEQChange;
    public int secondGroupIQChange;
    public int secondGroupFLChange;
    public int secondGroupSLChange;
    public int secondGroupHappinessChange;
    public int secondGroupAlignmentChange;

    public int thirdGroupEQChange;
    public int thirdGroupIQChange;
    public int thirdGroupFLChange;
    public int thirdGroupSLChange;
    public int thirdGroupHappinessChange;
    public int thirdGroupAlignmentChange;

    // Start is called before the first frame update
    void Start()
    {
        go_studentManager = GameObject.Find("Game");
        dd_classDropdowns = new Dropdown[30];
        go_timetableManagers = new GameObject[3];
        dd_classes = GameObject.Find("ClassesDropdown").GetComponent<Dropdown>();

        go_timetableManagers[0] = GameObject.Find("ClassDrops");
        go_timetableManagers[1] = GameObject.Find("ClassDrops2");
        go_timetableManagers[2] = GameObject.Find("ClassDrops3");

        for (int i = 0; i < 10; i++)
        {
            dd_classDropdowns[i] = go_timetableManagers[0].transform.GetChild(i).GetChild(0).GetComponent<Dropdown>();
        }
        for (int i = 0; i < 10; i++)
        {
            dd_classDropdowns[i + 10] = go_timetableManagers[1].transform.GetChild(i).GetChild(0).GetComponent<Dropdown>();
        }
        for (int i = 0; i < 10; i++)
        {
            dd_classDropdowns[i + 20] = go_timetableManagers[2].transform.GetChild(i).GetChild(0).GetComponent<Dropdown>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dd_classes.value == 0) groupNumber = JH_Set_Class.GroupNumber.One;
        if (dd_classes.value == 1) groupNumber = JH_Set_Class.GroupNumber.Two;
        if (dd_classes.value == 2) groupNumber = JH_Set_Class.GroupNumber.Three;

        UpdateClasses();
    }

    void UpdateClasses()
    {
        firstCurrentClass = GameObject.Find("ClassDrops").GetComponent<JH_Assign_Class>().currentClass;
        if (firstPreviousClass == JH_Set_Class.ClassName.None)
        {
            firstPreviousClass = firstCurrentClass;
        }
        secondCurrentClass = GameObject.Find("ClassDrops2").GetComponent<JH_Assign_Class>().currentClass;
        if (secondPreviousClass == JH_Set_Class.ClassName.None)
        {
            secondPreviousClass = secondCurrentClass;
        }
        thirdCurrentClass = GameObject.Find("ClassDrops3").GetComponent<JH_Assign_Class>().currentClass;
        if (thirdPreviousClass == JH_Set_Class.ClassName.None)
        {
            thirdPreviousClass = thirdCurrentClass;
        }

        if (firstGroupEQChange != 0 || firstGroupIQChange != 0 || firstGroupFLChange != 0 || firstGroupSLChange != 0
            || firstGroupHappinessChange != 0 || firstGroupAlignmentChange != 0)
        {
            for (int i = 0; i < go_studentManager.GetComponent<JH_Student_Manager>().go_studentList.Length; i++)
            {
                if (go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i] != null)
                {
                    if (go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Move>().groupNumber == JH_Set_Class.GroupNumber.One)
                    {
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().EQ += firstGroupEQChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().IQ += firstGroupIQChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().FL += firstGroupFLChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().SL += firstGroupSLChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().happinessLevel += firstGroupHappinessChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().alignmentLevel += firstGroupAlignmentChange;
                    }
                }
            }

            firstGroupEQChange = 0;
            firstGroupIQChange = 0;
            firstGroupFLChange = 0;
            firstGroupSLChange = 0;
            firstGroupHappinessChange = 0;
            firstGroupAlignmentChange = 0;
        }

        if (secondGroupEQChange != 0 || secondGroupIQChange != 0 || secondGroupFLChange != 0 || secondGroupSLChange != 0
            || secondGroupHappinessChange != 0 || secondGroupAlignmentChange != 0)
        {
            for (int i = 0; i < go_studentManager.GetComponent<JH_Student_Manager>().go_studentList.Length; i++)
            {
                if (go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i] != null)
                {
                    if (go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Move>().groupNumber == JH_Set_Class.GroupNumber.Two)
                    {
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().EQ += secondGroupEQChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().IQ += secondGroupIQChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().FL += secondGroupFLChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().SL += secondGroupSLChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().happinessLevel += secondGroupHappinessChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().alignmentLevel += secondGroupAlignmentChange;
                    }
                }
            }

            secondGroupEQChange = 0;
            secondGroupIQChange = 0;
            secondGroupFLChange = 0;
            secondGroupSLChange = 0;
            secondGroupHappinessChange = 0;
            secondGroupAlignmentChange = 0;
        }

        if (thirdGroupEQChange != 0 || thirdGroupIQChange != 0 || thirdGroupFLChange != 0 || thirdGroupSLChange != 0
            || thirdGroupHappinessChange != 0 || thirdGroupAlignmentChange != 0)
        {
            for (int i = 0; i < go_studentManager.GetComponent<JH_Student_Manager>().go_studentList.Length; i++)
            {
                if (go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i] != null)
                {
                    if (go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Move>().groupNumber == JH_Set_Class.GroupNumber.Three)
                    {
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().EQ += thirdGroupEQChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().IQ += thirdGroupIQChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().FL += thirdGroupFLChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().SL += thirdGroupSLChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().happinessLevel += thirdGroupHappinessChange;
                        go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i].GetComponent<JH_Student_Stats>().alignmentLevel += thirdGroupAlignmentChange;
                    }
                }
            }

            thirdGroupEQChange = 0;
            thirdGroupIQChange = 0;
            thirdGroupFLChange = 0;
            thirdGroupSLChange = 0;
            thirdGroupHappinessChange = 0;
            thirdGroupAlignmentChange = 0;
        }
    }
}
