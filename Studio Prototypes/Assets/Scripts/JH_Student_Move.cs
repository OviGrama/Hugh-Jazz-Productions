using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JH_Student_Move : MonoBehaviour {

    private GameObject go_classManager;
    private GameObject go_timeManager;
    private GameObject go_studentManager;
    private NavMeshAgent nv_student;

    public JH_Set_Class.GroupNumber groupNumber;

	// Use this for initialization
	void Start () {
        go_classManager = GameObject.Find("ClassDrops");
        go_timeManager = GameObject.Find("Date/TimePanel");
        go_studentManager = GameObject.Find("Game");
        nv_student = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        MoveToClass();
	}

    void MoveToClass()
    {

        // Sets the destination to the correct class, go to the canteen for lunch, and either head home or to the dorms at the end of the day
        if (go_timeManager.GetComponent<JH_Time_UI>().in_time >= 7 && 
            go_timeManager.GetComponent<JH_Time_UI>().in_time <= 17)
        {
            if (go_timeManager.GetComponent<JH_Time_UI>().in_time >= 11 &&
                go_timeManager.GetComponent<JH_Time_UI>().in_time < 13)
            {
                nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_canteen.transform.position;
            }
            else
            {
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.None)
                {
                    nv_student.destination = new Vector3(go_classManager.GetComponent<JH_Assign_Class>().go_homeSpot.transform.position.x,
                                                         transform.position.y,
                                                         go_classManager.GetComponent<JH_Assign_Class>().go_homeSpot.transform.position.z);
                }

                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Literature)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_literatureClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Citizenship)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_citizenshipClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.BasicScience)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_scienceClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Super101)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_superClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Sport)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_sportsClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Citizenship)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedCitizenship.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Literature)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedLiterature.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Psychology)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_psychology.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Physiology)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_physiology.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Science)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedScience.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Persuasion_Hero)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_persuasionHero.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Persuasion_Villain)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_persuasionVillain.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Genetics_Hero)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_geneticsHero.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Genetics_Villain)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_geneticsVillain.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Gym)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_gymClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Gym)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedGym.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Meditation)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_meditationClass.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Meditation)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedMeditation.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Super201)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_super201.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Physical_Development)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_physicalDevelopment.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Mental_Development)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_mentalDevelopment.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Responsible_Power_Management)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_responsiblePowerManagement.transform.position;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Maximising_Power_Potential)
                {
                    nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_maximisingPowerPotential.transform.position;
                }
            }
        }
        else
        {
            if (go_studentManager.GetComponent<JH_Student_Manager>().in_dormUpgrades >= 1 && groupNumber == JH_Set_Class.GroupNumber.One)
            {
                nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_dorms[0].transform.position;
            }
            else if (go_studentManager.GetComponent<JH_Student_Manager>().in_dormUpgrades >= 2 && groupNumber == JH_Set_Class.GroupNumber.Two)
            {
                nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_dorms[1].transform.position;
            }
            else if (go_studentManager.GetComponent<JH_Student_Manager>().in_dormUpgrades >= 3 && groupNumber == JH_Set_Class.GroupNumber.Three)
            {
                nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_dorms[2].transform.position;
            }
            else nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_homeSpot.transform.position;
        }
    }


}
