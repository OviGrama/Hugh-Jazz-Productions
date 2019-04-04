using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JH_Staff_Move : MonoBehaviour
{

    public JH_Set_Class.ClassName classTaught;
    private NavMeshAgent nv_staff;
    private GameObject go_classManager;
    private GameObject go_timeManager;

    // Start is called before the first frame update
    void Start()
    {
        nv_staff = GetComponent<NavMeshAgent>();
        go_classManager = GameObject.Find("ClassDrops");
        go_timeManager = GameObject.Find("Date/TimePanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateClass()
    {
        if (go_timeManager.GetComponent<JH_Time_UI>().in_time >= 6 && go_timeManager.GetComponent<JH_Time_UI>().in_time <= 18)
        {
            if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == classTaught)
            {
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Literature)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_literatureClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Citizenship)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_citizenshipClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.BasicScience)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_scienceClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Super101)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_superClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Sport)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_sportsClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Citizenship)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedCitizenship.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Literature)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedLiterature.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Psychology)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_psychology.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Physiology)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_physiology.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Science)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedScience.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Persuasion_Hero)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_persuasionHero.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Persuasion_Villain)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_persuasionVillain.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Genetics_Hero)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_geneticsHero.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Genetics_Villain)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_geneticsVillain.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Gym)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_gymClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Gym)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedGym.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Meditation)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_meditationClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Meditation)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedMeditation.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Super201)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_super201.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Physical_Development)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_physicalDevelopment.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Mental_Development)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_mentalDevelopment.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Responsible_Power_Management)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_responsiblePowerManagement.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Maximising_Power_Potential)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_maximisingPowerPotential.transform.position;
                }
            }
            else
            {
                nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_canteen.transform.position;
            }
        }
        else
        {
            nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_homeSpot.transform.position;
        }
    }
}
