using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Class_Manager : MonoBehaviour {

    public GameObject englishRoom;
    public GameObject mathRoom;
    public GameObject scienceRoom;
    public GameObject sportRoom;
    public GameObject superRoom;
    public GameObject home;

    public int currentClass;
    public bool bl_homeTime;

    public GameObject[] ClassList;

	// Use this for initialization
	void Start () {
        ClassList = new GameObject[10];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
