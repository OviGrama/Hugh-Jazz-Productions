using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OG_RandomEvents : MonoBehaviour {

    //[HideInInspector]
    // public float fl_ConditionalEventTimer;

    // private JH_Time_UI timeUI;

    public float fl_StandardEventTimer;


    public bool bl_goodRep;
    private bool bl_CondCoroutineStart = true;
    private bool bl_StaCoroutineStart = true;

    public bool bl_herosNumberReached;
    public bool bl_villainsNumberReached;

    //
    public bool heroDeckAdded = false;
    public bool villainDeckAdded = false;

    public int in_TotalEvents;

    private AC_YearEnd yearend_ref;

    public GameObject[] StandardDeck;
    public GameObject[] HeroDeck;
    public GameObject[] VillainDeck;
    public GameObject[] GoodRepDeck;
    public GameObject[] BadRepDeck;
    public GameObject[] RandomEvents;



    //private int standardNum;

    // Use this for initialization
    void Start () {

        yearend_ref = GameObject.Find("GameManager").GetComponent<AC_YearEnd>();

        for (int i = 0; i < StandardDeck.Length; i++)
        {
            StandardDeck[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < StandardDeck.Length; i++)
        {
            RandomEvents[i] = StandardDeck[i];
        }

        in_TotalEvents = StandardDeck.Length;

        if (bl_StaCoroutineStart)
        {
            StartCoroutine(StandardEventTrigger());
        }


        //for (int i = 0; i < GoodSchoolEvents.Length; i++)
        //{
        //    GoodSchoolEvents[i].gameObject.SetActive(false);
        //}

        //for (int i = 0; i < BadSchoolEvents.Length; i++)
        //{
        //    BadSchoolEvents[i].gameObject.SetActive(false);
        //}

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

    }

    // 
    private int currentEvent;
    void EnableStandardEvent()
    {
        int i = Random.Range(0, StandardDeck.Length);
        currentEvent = i;
        StandardDeck[i].gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    // Calls to add either or both of the hero and villain decks if the number of heroes or villians has reached the required number.
    public void HeroVillainDecks()
    {
        Debug.Log("Hero and Villain Deck Check");

        // Calls add hero deck function if number of heroes in world is reached.
        if (bl_herosNumberReached == true && heroDeckAdded == false)
        {
            Debug.Log("Hero Deck, Adding Now");
            AddHeroDeck();
        }
        // Calls add villain deck function if number of villains in world is reached.
        if (bl_villainsNumberReached == true && villainDeckAdded == false)
        {
            Debug.Log("Villain Deck, Adding Now");
            AddVillainDeck();
        }
    }
    
    void AddHeroDeck()
    {
        for (int i = 0; i < HeroDeck.Length; i++)
        {
            RandomEvents[in_TotalEvents] = HeroDeck[i];
            in_TotalEvents++;
        }
        heroDeckAdded = true;
    }

    void AddVillainDeck()
    {
        for (int i = 0; i < HeroDeck.Length; i++)
        {
            RandomEvents[in_TotalEvents] = VillainDeck[i];
            in_TotalEvents++;
        }
        villainDeckAdded = true;
    }

    // Reputation Decks.
    //void GoodBadReputationDecks()
    //{
    //    if (bl_goodRep == true)
    //    {
    //        AddGoodRepDeck();
    //    }
    //    else
    //    {
    //        AddBadRepDeck();
    //    }
    //}

    //void AddGoodRepDeck()
    //{
    //    for (int i = 0; i < HeroDeck.Length; i++)
    //    {
    //        RandomEvents[in_TotalEvents + 1] = GoodRepDeck[i];
    //        in_TotalEvents++;
    //    }
    //}

    //void AddBadRepDeck()
    //{
    //    for (int i = 0; i < HeroDeck.Length; i++)
    //    {
    //        RandomEvents[in_TotalEvents + 1] = BadRepDeck[i];
    //        in_TotalEvents++;
    //    }
    //}







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

    public void RestartTimer()
    {
        bl_StaCoroutineStart = true;
        StartCoroutine(StandardEventTrigger());
        StandardDeck[currentEvent].gameObject.SetActive(false);
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
