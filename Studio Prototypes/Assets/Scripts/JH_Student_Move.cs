using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JH_Student_Move : MonoBehaviour {

    private GameObject[] go_classManagers;
    private GameObject go_timeManager;
    private GameObject go_studentManager;
    private NavMeshAgent nv_student;
    private int in_classNumber;

    public JH_Set_Class.GroupNumber groupNumber;
    private int in_dormUnlock;

    [HideInInspector] public bool bl_usingBathroom;

	// Use this for initialization
	void Start () {
        go_classManagers = new GameObject[3];
        go_timeManager = GameObject.Find("Date/TimePanel");
        go_studentManager = GameObject.Find("Game");
        nv_student = GetComponent<NavMeshAgent>();
        go_classManagers[0] = GameObject.Find("ClassDrops");
        go_classManagers[1] = GameObject.Find("ClassDrops2");
        go_classManagers[2] = GameObject.Find("ClassDrops3");
	}
	
	// Update is called once per frame
	void Update () {
        

        if (groupNumber == JH_Set_Class.GroupNumber.One)
        {
            in_classNumber = 0;
            in_dormUnlock = 1;
        }
        if (groupNumber == JH_Set_Class.GroupNumber.Two)
        {
            in_classNumber = 1;
            in_dormUnlock = 2;
        }
        if (groupNumber == JH_Set_Class.GroupNumber.Three)
        {
            in_classNumber = 2;
            in_dormUnlock = 3;
        }
        MoveToClass();
    }

    void MoveToClass()
    {

        // Sets the destination to the correct class, go to the canteen for lunch, and either head home or to the dorms at the end of the day
        if (go_timeManager.GetComponent<JH_Time_UI>().in_time >= 7 && 
            go_timeManager.GetComponent<JH_Time_UI>().in_time <= 17)
        {
            // Go to the correct bathroom if bladder level is low
            if (GetComponent<JH_Student_Stats>().bladderLevel <= 10)
            {
                if (GetComponent<JH_Student_Appearance>().studentGender == JH_Student_Manager.StudentGender.Female)
                {
                    nv_student.destination = go_studentManager.GetComponent<JH_Student_Manager>().go_fBathroom.transform.position;
                }
                else
                {
                    nv_student.destination = go_studentManager.GetComponent<JH_Student_Manager>().go_mBathroom.transform.position;
                }
                
                // Use the bathroom when close enough
                if (Vector3.Distance(transform.position, new Vector3(nv_student.destination.x, transform.position.y,
                                                      nv_student.destination.z)) <= 0.5f)
                {
                    StartCoroutine(UseBathroom());
                }
            }
            else
            {
                // Go to the canteen at lunch time
                if (go_timeManager.GetComponent<JH_Time_UI>().in_time >= 11 &&
                    go_timeManager.GetComponent<JH_Time_UI>().in_time < 13)
                {
                    nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_canteen.transform.position;
                }
                // Go to the assigned class
                else
                {
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.None)
                    {
                        nv_student.destination = new Vector3(go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_homeSpot.transform.position.x,
                                                             transform.position.y,
                                                             go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_homeSpot.transform.position.z);
                    }

                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Literature)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_literatureClass.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Citizenship)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_citizenshipClass.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.BasicScience)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_scienceClass.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Super101)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_superClass.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Sport)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_sportsClass.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Citizenship)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_advancedCitizenship.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Literature)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_advancedLiterature.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Psychology)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_psychology.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Physiology)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_physiology.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Science)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_advancedScience.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Persuasion_Hero)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_persuasionHero.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Persuasion_Villain)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_persuasionVillain.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Genetics_Hero)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_geneticsHero.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Genetics_Villain)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_geneticsVillain.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Gym)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_gymClass.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Gym)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_advancedGym.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Meditation)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_meditationClass.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Meditation)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_advancedMeditation.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Super201)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_super201.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Physical_Development)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_physicalDevelopment.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Mental_Development)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_mentalDevelopment.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Responsible_Power_Management)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_responsiblePowerManagement.transform.position;
                    }
                    if (go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Maximising_Power_Potential)
                    {
                        nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_maximisingPowerPotential.transform.position;
                    }
                }
            }
        }

        // Head home (or to the dorms if unlocked) at the end of the day or if there are no classes
        else
        {
            if (go_studentManager.GetComponent<JH_Student_Manager>().in_dormUpgrades >= in_dormUnlock)
            {
                nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_dorms[in_classNumber].transform.position;
            }
            else nv_student.destination = go_classManagers[in_classNumber].GetComponent<JH_Assign_Class>().go_homeSpot.transform.position;

            if (GetComponent<JH_Student_Stats>().bladderLevel <= 10) GetComponent<JH_Student_Stats>().bladderLevel += 10;
        }
    }

    // Refresh the bladder level when using the bathroom
    IEnumerator UseBathroom()
    {
        bl_usingBathroom = true;
        yield return new WaitForSeconds(5);
        GetComponent<JH_Student_Stats>().bladderLevel = 100;
        bl_usingBathroom = false;
    }

}
