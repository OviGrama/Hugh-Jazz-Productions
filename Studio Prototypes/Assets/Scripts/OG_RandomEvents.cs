using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OG_RandomEvents : MonoBehaviour {

    [HideInInspector]
    public float fl_ConditionalEventTimer;

    public float fl_StandardEventTimer;


    public bool bl_goodRep;
    private bool bl_CondCoroutineStart = true;
    private bool bl_StaCoroutineStart = true;

    public bool bl_herosNumberReached;
    public bool bl_villainsNumberReached;

    public int in_TotalEvents;

    private AC_YearEnd yearend_ref;

    public GameObject[] HeroDeck;
    public GameObject[] VillainDeck;
    public GameObject[] GoodRepDeck;
    public GameObject[] BadRepDeck;
    public GameObject[] StandardDeck;
    public GameObject[] RandomEvents;

    // Use this for initialization
    void Start () {

        yearend_ref = GameObject.Find("GameManager").GetComponent<AC_YearEnd>();

        //for (int i = 0; i < GoodSchoolEvents.Length; i++)
        //{
        //    GoodSchoolEvents[i].gameObject.SetActive(false);
        //}

        //for (int i = 0; i < BadSchoolEvents.Length; i++)
        //{
        //    BadSchoolEvents[i].gameObject.SetActive(false);
        //}

        for (int i = 0; i < StandardDeck.Length; i++)
        {
            StandardDeck[i].gameObject.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {

        //in_TotalEvents = RandomEvents.Length;

        //for (int i = 0; i < StandardDeck.Length; i++)
        //{
        //    RandomEvents[i] = StandardDeck[i];
        //}

        //if (alignment.fl_Allignment >= 50f)
        //{
        //    bl_goodSchool = true;
        //}
        //else
        //    bl_goodSchool = false;

        //if (bl_CondCoroutineStart)
        //{
        //    StartCoroutine(ConditionalEventTrigger());
        //}

        if (bl_herosNumberReached)
        {
            AddHeroDeck();
        }

        if (bl_StaCoroutineStart)
        {
            StartCoroutine(StandardEventTrigger());
        }
    }

    //void EnableGoodRepEvent()
    //{
    //    int i = Random.Range(0, GoodSchoolEvents.Length);
    //    GoodSchoolEvents[i].gameObject.SetActive(true);
    //}


    //void EnableBadRepEvent()
    //{
    //    int i = Random.Range(0, BadSchoolEvents.Length);
    //    BadSchoolEvents[i].gameObject.SetActive(true);
    //}

    void EnableStandardEvent()
    {
        int i = Random.Range(0, StandardDeck.Length);
        StandardDeck[i].gameObject.SetActive(true);
    }

    public void HeroVillainDeck()
    {
        if(yearend_ref.numberOfHeroes > 10)
        {
            bl_herosNumberReached = true;
        }

        if(yearend_ref.numberOfVillians > 10)
        {
            bl_villainsNumberReached = true;
        }
    }
    
    void AddHeroDeck()
    {
        in_TotalEvents = in_TotalEvents + HeroDeck.Length;

        for (int i = 0; i < HeroDeck.Length; i++)
        {
            RandomEvents[i+RandomEvents.Length -1] = HeroDeck[i];
        }
    }


    // Conditionale event based on school reputation trigger (Coroutine based on the fl_conditionaleventimer)
    //IEnumerator ConditionalEventTrigger()
    //{
    //    bl_CondCoroutineStart = false;

    //    yield return new WaitForSeconds(fl_ConditionalEventTimer);

    //    if (bl_goodRep)
    //    {
    //        EnableGoodRepEvent();
    //    }
    //    else
    //    {
    //        EnableBadRepEvent();
    //    }
    //}


    // Standard event trigger (Coroutine based on the fl_standardeventimer)
    IEnumerator StandardEventTrigger()
    {
        bl_StaCoroutineStart = false;

        yield return new WaitForSeconds(fl_StandardEventTimer);

        EnableStandardEvent();
    }

    #region Standard Events Actions

    public void ReprimandThemBoth()
    {
        StandardDeck[0].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void IgnoreTheIncident()
    {
        StandardDeck[0].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    public void ReprimandTheOffender()
    {
        StandardDeck[1].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void EncourageRetaliation()
    {
        StandardDeck[1].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    public void PunishThem()
    {
        StandardDeck[2].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void BlackMailThem()
    {
        StandardDeck[2].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    public void InformTheJudges()
    {
        StandardDeck[3].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void SayNothing()
    {
        StandardDeck[3].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    public void GrapevineReprimand()
    {
        StandardDeck[4].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }
    public void GrapevineEncourage()
    {
        StandardDeck[4].gameObject.SetActive(false);
        bl_StaCoroutineStart = true;
    }

    #endregion

    #region Good Events Actions

    //public void AcceptThePrise()
    //{
    //    GoodSchoolEvents[0].gameObject.SetActive(false);
    //    bl_CondCoroutineStart = true;
    //}
    //public void PraiseTheStudents()
    //{
    //    GoodSchoolEvents[0].gameObject.SetActive(false);
    //    bl_CondCoroutineStart = true;
    //}


    #endregion

    #region Bad Events Actions

    //public void LetHimGo()
    //{
    //    BadSchoolEvents[0].gameObject.SetActive(false);
    //    bl_CondCoroutineStart = true;
    //}
    //public void DenyTheRequest()
    //{
    //    BadSchoolEvents[0].gameObject.SetActive(false);
    //    bl_CondCoroutineStart = true;
    //}

    #endregion
}
