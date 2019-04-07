using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Set_Class : MonoBehaviour
{
    public enum ClassDate
    {
        MondayAM,
        MondayPM,
        TuesdayAM,
        TuesdayPM,
        WednesdayAM,
        WednesdayPM,
        ThursdayAM,
        ThursdayPM,
        FridayAM,
        FridayPM
    }
    public ClassDate classDate;

    public enum ClassName
    {
        None,
        Literature,
        Advanced_Literature,
        Citizenship,
        Advanced_Citizenship,
        BasicScience,
        Psychology,
        Physiology,
        Advanced_Science,
        Persuasion_Hero,
        Persuasion_Villain,
        Genetics_Hero,
        Genetics_Villain,
        Sport,
        Gym,
        Advanced_Gym,
        Meditation,
        Advanced_Meditation,
        Super101,
        Super201,
        Physical_Development,
        Mental_Development,
        Responsible_Power_Management,
        Maximising_Power_Potential
    }
    public ClassName className;

    public enum GroupNumber
    {
        One,
        Two,
        Three
    }

    public GroupNumber groupNumber;

    private GameObject go_setClass;
    private GameObject go_timetableManager;
    private GameObject go_classDropDownManager;

    private GameObject[] go_timetableManagers;

    private JH_Quick_Set_Class classManager;

    private int in_classAmount;

    [Header("Student Modifiers")]
    public int EQ_Modifier;
    public int IQ_Modifier;
    public int FL_Modifier;
    public int SL_Modifier;
    public int happiness_Modifier;
    public int alignment_Modifier;

    // Start is called before the first frame update
    void Start()
    {
        go_timetableManagers = new GameObject[3];
        go_classDropDownManager = GameObject.Find("ClassesDropDownManager");

        go_timetableManagers[0] = GameObject.Find("ClassDrops");
        go_timetableManagers[1] = GameObject.Find("ClassDrops2");
        go_timetableManagers[2] = GameObject.Find("ClassDrops3");

        classManager = GameObject.Find("SpecificClassesPanels").GetComponent<JH_Quick_Set_Class>();
        
    }

    // Update is called once per frame
    void Update()
    {
        SetupManager();
    }

    public void SetClass()
    {

        #region Assign Class
        if (classDate == ClassDate.MondayAM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().mondayAM = className;
        }
        if (classDate == ClassDate.MondayPM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().mondayPM = className;
        }
        if (classDate == ClassDate.TuesdayAM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().tuesdayAM = className;
        }
        if (classDate == ClassDate.TuesdayPM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().tuesdayPM = className;
        }
        if (classDate == ClassDate.WednesdayAM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().wednesdayAM = className;
        }
        if (classDate == ClassDate.WednesdayPM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().wednesdayPM = className;
        }
        if (classDate == ClassDate.ThursdayAM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().thursdayAM = className;
        }
        if (classDate == ClassDate.ThursdayPM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().thursdayPM = className;
        }
        if (classDate == ClassDate.FridayAM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().fridayAM = className;
        }
        if (classDate == ClassDate.FridayPM)
        {
            go_timetableManager.GetComponent<JH_Assign_Class>().fridayPM = className;
        }
        
        #endregion
    }

    public void CloseDropDown()
    {
        transform.parent.parent.gameObject.SetActive(false);
    }


    public void ResetDropDown()
    {
        for (int i = 0; i < classManager.dd_classDropdowns.Length; i++)
        {
            classManager.dd_classDropdowns[i].value = 0;
        }
        CloseDropDown();
    }

    void SetupManager()
    {
        if (go_setClass == null) go_setClass = GameObject.Find("SpecificClassesPanels");
        else
        {
            if (go_setClass.GetComponent<JH_Quick_Set_Class>().groupNumber == GroupNumber.One)
            {
                go_timetableManager = GameObject.Find("ClassDrops");
            }
            if (go_setClass.GetComponent<JH_Quick_Set_Class>().groupNumber == GroupNumber.Two)
            {
                go_timetableManager = GameObject.Find("ClassDrops2");
            }
            if (go_setClass.GetComponent<JH_Quick_Set_Class>().groupNumber == GroupNumber.Three)
            {
                go_timetableManager = GameObject.Find("ClassDrops3");
            }


            CheckClass();
        }
        
        
    }

    void CheckClass()
    {
        for (int i = 0; i < go_timetableManagers.Length; i++)
        {
            if (classDate == ClassDate.MondayAM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().mondayAM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.MondayPM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().mondayPM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.TuesdayAM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().tuesdayAM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.TuesdayPM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().tuesdayPM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.WednesdayAM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().wednesdayAM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.WednesdayPM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().wednesdayPM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.ThursdayAM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().thursdayAM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.ThursdayPM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().thursdayPM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.FridayAM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().fridayAM == className)
                {
                    in_classAmount++;
                }
            }
            if (classDate == ClassDate.FridayPM)
            {
                if (go_timetableManagers[i].GetComponent<JH_Assign_Class>().fridayPM == className)
                {
                    in_classAmount++;
                }
            }
        }

        if (in_classAmount == 0)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
            in_classAmount = 0;
        }

        if (go_setClass.GetComponent<JH_Quick_Set_Class>().firstPreviousClass == className)
        {
            if (go_setClass.GetComponent<JH_Quick_Set_Class>().firstCurrentClass != go_setClass.GetComponent<JH_Quick_Set_Class>().firstPreviousClass)
            {
                go_setClass.GetComponent<JH_Quick_Set_Class>().firstGroupEQChange = EQ_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().firstGroupIQChange = IQ_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().firstGroupFLChange = FL_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().firstGroupSLChange = SL_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().firstGroupHappinessChange = happiness_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().firstGroupAlignmentChange = alignment_Modifier;

                go_setClass.GetComponent<JH_Quick_Set_Class>().firstPreviousClass = go_setClass.GetComponent<JH_Quick_Set_Class>().firstCurrentClass;
            }
        }

        if (go_setClass.GetComponent<JH_Quick_Set_Class>().secondPreviousClass == className)
        {
            if (go_setClass.GetComponent<JH_Quick_Set_Class>().secondCurrentClass != go_setClass.GetComponent<JH_Quick_Set_Class>().secondPreviousClass)
            {
                go_setClass.GetComponent<JH_Quick_Set_Class>().secondGroupEQChange = EQ_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().secondGroupIQChange = IQ_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().secondGroupFLChange = FL_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().secondGroupSLChange = SL_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().secondGroupHappinessChange = happiness_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().secondGroupAlignmentChange = alignment_Modifier;

                go_setClass.GetComponent<JH_Quick_Set_Class>().secondPreviousClass = go_setClass.GetComponent<JH_Quick_Set_Class>().secondCurrentClass;
            }
        }

        if (go_setClass.GetComponent<JH_Quick_Set_Class>().thirdPreviousClass == className)
        {
            if (go_setClass.GetComponent<JH_Quick_Set_Class>().thirdCurrentClass != go_setClass.GetComponent<JH_Quick_Set_Class>().thirdPreviousClass)
            {
                go_setClass.GetComponent<JH_Quick_Set_Class>().thirdGroupEQChange = EQ_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().thirdGroupIQChange = IQ_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().thirdGroupFLChange = FL_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().thirdGroupSLChange = SL_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().thirdGroupHappinessChange = happiness_Modifier;
                go_setClass.GetComponent<JH_Quick_Set_Class>().thirdGroupAlignmentChange = alignment_Modifier;

                go_setClass.GetComponent<JH_Quick_Set_Class>().thirdPreviousClass = go_setClass.GetComponent<JH_Quick_Set_Class>().thirdCurrentClass;
            }
        }
    }
}
