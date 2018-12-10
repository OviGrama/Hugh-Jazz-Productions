using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Class_Navigation : MonoBehaviour {

    public enum ClassName
    {
        English,
        Math,
        Science,
        Sport,
        Super
    }

    public ClassName Class;

    public GameObject assignedClass;

    private GameObject go_classManager;

	// Use this for initialization
	void Start () {
        go_classManager = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
        AssignClass();
	}

    void AssignClass()
    {
        if (Class == ClassName.English) assignedClass = go_classManager.GetComponent<JH_Class_Manager>().englishRoom;
        if (Class == ClassName.Math) assignedClass = go_classManager.GetComponent<JH_Class_Manager>().mathRoom;
        if (Class == ClassName.Science) assignedClass = go_classManager.GetComponent<JH_Class_Manager>().scienceRoom;
        if (Class == ClassName.Sport) assignedClass = go_classManager.GetComponent<JH_Class_Manager>().sportRoom;
        if (Class == ClassName.Super) assignedClass = go_classManager.GetComponent<JH_Class_Manager>().superRoom;
    }
}
