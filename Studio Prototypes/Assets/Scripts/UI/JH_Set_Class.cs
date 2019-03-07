using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private GameObject go_timetableManager;
    private GameObject go_classDropDownManager;

    // Start is called before the first frame update
    void Start()
    {
        go_timetableManager = GameObject.Find("ClassDrops");
        go_classDropDownManager = GameObject.Find("ClassesDropDownManager");
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void ResetDropDown()
    {
        go_classDropDownManager.GetComponent<OG_ClassesDropDown>().ResetDropDown();
    }
}
