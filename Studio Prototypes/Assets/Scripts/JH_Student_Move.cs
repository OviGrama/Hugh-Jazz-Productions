using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JH_Student_Move : MonoBehaviour {

    private GameObject go_classManager;
    private NavMeshAgent nv_student;

	// Use this for initialization
	void Start () {
        go_classManager = GameObject.Find("Main Camera");
        nv_student = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        MoveToClass();
	}

    void MoveToClass()
    {
        if (go_classManager.GetComponent<JH_Class_Manager>().ClassList[
            go_classManager.GetComponent<JH_Class_Manager>().currentClass]
            != null)
        {
            nv_student.destination = new Vector3(go_classManager.GetComponent<JH_Class_Manager>().ClassList[
            go_classManager.GetComponent<JH_Class_Manager>().currentClass].transform.position.x, 
            transform.position.y, go_classManager.GetComponent<JH_Class_Manager>().ClassList[
            go_classManager.GetComponent<JH_Class_Manager>().currentClass].transform.position.z);
            Debug.Log("Should Move");
        }
    }
}
