using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JH_Student_Move : MonoBehaviour {

    private GameObject go_classManager;
    private GameObject go_timeManager;
    private NavMeshAgent nv_student;

	// Use this for initialization
	void Start () {
        go_classManager = GameObject.Find("ClassDrops");
        go_timeManager = GameObject.Find("Date/TimePanel");
        nv_student = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        MoveToClass();
	}

    void MoveToClass()
    {
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
            }
        }
        else
        {
            nv_student.destination = go_classManager.GetComponent<JH_Assign_Class>().go_homeSpot.transform.position;
        }
    }


}
