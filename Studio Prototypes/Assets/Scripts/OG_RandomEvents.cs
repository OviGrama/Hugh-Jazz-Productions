using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OG_RandomEvents : MonoBehaviour {

    private OG_Alignment alignment;
    public bool bl_goodSchool;
    public Canvas[] GoodSchoolEvents;
    public Canvas[] BadSchoolEvents;

    // Use this for initialization
    void Start () {

        alignment = GameObject.Find("Student").GetComponent<OG_Alignment>();

        if (alignment.fl_CurrentAlignment >= 50f)
        {
            bl_goodSchool = true;
        }
        else
            bl_goodSchool = false;
		
	}
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(EventTrigger());
		
	}

    void EnableGoodEvent()
    {
        int i = Random.Range(0, GoodSchoolEvents.Length);
        GoodSchoolEvents[i].gameObject.SetActive(true);
    }


    void EnableBadEvent()
    {
        int i = Random.Range(0, BadSchoolEvents.Length);
        BadSchoolEvents[i].gameObject.SetActive(true);
    }

    IEnumerator EventTrigger()
    {
        yield return new WaitForSeconds(120f);
        if (bl_goodSchool)
        {
            EnableGoodEvent();
        }
        else
        {
            EnableBadEvent();
        }
    }
}
