using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OG_StudentCharacter : MonoBehaviour {

    public Transform[] Classes;
    private int in_DestPoint = 0;
    private NavMeshAgent StudentAgent;

	// Use this for initialization
	void Start () {

        StudentAgent = GetComponent<NavMeshAgent>();

        StudentAgent.autoBraking = false;

        GotoNextClass();
		
	}


    void GotoNextClass()
    {
        if (Classes.Length == 0)
            return;

        StudentAgent.destination = Classes[in_DestPoint].position;

        in_DestPoint = (in_DestPoint + 1) % Classes.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (!StudentAgent.pathPending && StudentAgent.remainingDistance < 0.5f)
            GotoNextClass();


    }
}
