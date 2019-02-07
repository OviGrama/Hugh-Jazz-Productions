using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OG_RandomEvents : MonoBehaviour {

    public float fl_ConditionalEventTimer;
    public float fl_StandardEventTimer;

    private OG_StudentInfo alignment;

    public bool bl_goodSchool;
    private bool bl_CondCoroutineStart = true;
    private bool bl_StaCoroutineStart = true;

    public Canvas[] GoodSchoolEvents;
    public Canvas[] BadSchoolEvents;
    public Canvas[] StandardEvents;

    // Use this for initialization
    void Start () {

        alignment = GameObject.Find("Student").GetComponent<OG_StudentInfo>();

        for (int i = 0; i < GoodSchoolEvents.Length; i++)
        {
            GoodSchoolEvents[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < BadSchoolEvents.Length; i++)
        {
            BadSchoolEvents[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < StandardEvents.Length; i++)
        {
            StandardEvents[i].gameObject.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {


        if (alignment.fl_Allignment >= 50f)
        {
            bl_goodSchool = true;
        }
        else
            bl_goodSchool = false;

        if (bl_CondCoroutineStart)
        {
            StartCoroutine(ConditionalEventTrigger());
        }

        if (bl_StaCoroutineStart)
        {
            StartCoroutine(StandardEventTrigger());
        }
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

    void EnableStandardEvent()
    {
        int i = Random.Range(0, StandardEvents.Length);
        StandardEvents[i].gameObject.SetActive(true);
    }

    IEnumerator ConditionalEventTrigger()
    {
        bl_CondCoroutineStart = false;

        yield return new WaitForSeconds(fl_ConditionalEventTimer);

        if (bl_goodSchool)
        {
            EnableGoodEvent();
        }
        else
        {
            EnableBadEvent();
        }
    }

    IEnumerator StandardEventTrigger()
    {
        bl_StaCoroutineStart = false;

        yield return new WaitForSeconds(fl_StandardEventTimer);

        EnableStandardEvent();
    }

    #region Standard Events Actions

    public void ReprimandThemBoth()
    {
        StandardEvents[0].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void IgnoreTheIncident()
    {
        StandardEvents[0].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    public void ReprimandTheOffender()
    {
        StandardEvents[1].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void EncourageRetaliation()
    {
        StandardEvents[1].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    public void PunishThem()
    {
        StandardEvents[2].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void BlackMailThem()
    {
        StandardEvents[2].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    public void InformTheJudges()
    {
        StandardEvents[3].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void SayNothing()
    {
        StandardEvents[3].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    public void GrapevineReprimand()
    {
        StandardEvents[4].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void GrapevineEncourage()
    {
        StandardEvents[4].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    #endregion

    #region Good Events Actions

    public void AcceptThePrise()
    {
        GoodSchoolEvents[0].gameObject.SetActive(false);
        bl_CondCoroutineStart = true;
    }
    public void PraiseTheStudents()
    {
        GoodSchoolEvents[0].gameObject.SetActive(false);
        bl_CondCoroutineStart = true;
    }


    #endregion

    #region Bad Events Actions

    public void LetHimGo()
    {
        BadSchoolEvents[0].gameObject.SetActive(false);
        bl_CondCoroutineStart = true;
    }
    public void DenyTheRequest()
    {
        BadSchoolEvents[0].gameObject.SetActive(false);
        bl_CondCoroutineStart = true;
    }

    #endregion
}
