using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Assign_Class : MonoBehaviour {

    public int classPosition;
    private GameObject go_classManager;

	// Use this for initialization
	void Start () {
        go_classManager = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
        UpdateClasses();
	}

    void UpdateClasses()
    {
        if (transform.childCount > 2) {
             if (transform.GetChild(2).GetComponent<JH_Class_Navigation>() != null) {

                go_classManager.GetComponent<JH_Class_Manager>().ClassList[classPosition - 1] =
                    transform.GetChild(2).GetComponent<JH_Class_Navigation>().assignedClass;
             }
        }
    }
}
