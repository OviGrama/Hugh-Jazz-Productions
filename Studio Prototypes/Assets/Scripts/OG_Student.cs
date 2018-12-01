using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OG_Student : MonoBehaviour {

    //public Transform Target_Dest;
    float fl_speed = 5;
    public GameObject go_UIpanel;
    public float fl_DistanceToDest;
    public GameObject[] Classes;
    public int i;


	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

        if (Classes[i].GetComponent<OG_Classes>().bl_Unlocked)
        {
            transform.position = Vector3.MoveTowards(transform.position, Classes[i].transform.position, fl_speed * Time.deltaTime);
        }



    }
}
