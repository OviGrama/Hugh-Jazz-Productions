using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OG_RandomEvents : MonoBehaviour {

    // Randomised Timer.
    public int minTime;
    public int maxTime;

    public float fl_EventTimer;

    public bool goodRep;
    public bool badRep;
    //private bool bl_CondCoroutineStart = true;
    private bool bl_CoroutineStart = true;

    public bool bl_herosNumberReached;
    public bool bl_villainsNumberReached;

    // Checks so decks arent added twice.
    public bool heroDeckAdded = false;
    public bool villainDeckAdded = false;
    public bool goodRepDeckAdded = false;
    public bool badRepDeckAdded = false;
    public bool repChanged = false;

    public int in_TotalEvents;

    private AC_YearEnd yearend_ref;

    public GameObject[] StandardDeck;
    public GameObject[] HeroDeck;
    public GameObject[] VillainDeck;
    public GameObject[] GoodRepDeck;
    public GameObject[] BadRepDeck;
    public GameObject[] RandomEvents;

    public int[] currentRepEvents;
    public int replaceEvent;

    // Holds the value of the current event being played.
    private int currentEvent;
    private GameObject currentEventChoicePanel;

    //private int standardNum;

    // Use this for initialization
    void Start () {

        yearend_ref = GameObject.Find("GameManager").GetComponent<AC_YearEnd>();
        
        // Double checks all events are set to false on game start.
        for (int i = 0; i < StandardDeck.Length; i++)
        {
            StandardDeck[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < HeroDeck.Length; i++)
        {
            HeroDeck[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < VillainDeck.Length; i++)
        {
            VillainDeck[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < GoodRepDeck.Length; i++)
        {
            GoodRepDeck[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < BadRepDeck.Length; i++)
        {
            BadRepDeck[i].gameObject.SetActive(false);
        }

        // At start of game it adds the standard events to the total event deck.
        for (int i = 0; i < StandardDeck.Length; i++)
        {
            RandomEvents[i] = StandardDeck[i];
        }

        in_TotalEvents = StandardDeck.Length;

        if (bl_CoroutineStart)
        {
            StartCoroutine(EventTrigger());
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
	void Update ()
    {

    }

    // Randomises the time for the next Random Event.
    public void RandomTime()
    {
        fl_EventTimer = Random.Range(minTime, maxTime);
    }

    void EnableEvent()
    {
        int i = Random.Range(0, in_TotalEvents);
        currentEvent = i;
        RandomEvents[i].gameObject.SetActive(true);
        RandomEvents[i].transform.GetChild(0).gameObject.SetActive(true);
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

    #region Repuatation Decks

    public void GoodRepBadRepDecks()
    {
        Debug.Log("Good Rep and Bad Rep Deck Check");

        // Calls add hero deck function if number of heroes in world is reached.
        if (goodRep == true && heroDeckAdded == false)
        {
            Debug.Log("Good Rep Deck, Adding Now");
            AddGoodRepDeck();
        }
        // Calls add villain deck function if number of villains in world is reached.
        if (badRep == true)
        {
            Debug.Log("Bad Rep Deck, Adding Now");
            AddBadRepDeck();
        }
    }

    void AddGoodRepDeck()
    {
        if (repChanged == true)
        {
            if (goodRepDeckAdded == true)
            {
                return;
            }
            else if (badRepDeckAdded == true)
            {
                for (int i = 0; i < currentRepEvents.Length; i++)
                {
                    replaceEvent = currentRepEvents[i];
                    RandomEvents[replaceEvent] = GoodRepDeck[i];
                }
                badRepDeckAdded = false;
                goodRepDeckAdded = true;
            }
        }
        else
        {
            for (int i = 0; i < GoodRepDeck.Length; i++)
            {
                RandomEvents[in_TotalEvents] = GoodRepDeck[i];
                currentRepEvents[i] = in_TotalEvents;
                in_TotalEvents++;
            }
            goodRepDeckAdded = true;
            repChanged = true;
        }
    }

    void AddBadRepDeck()
    {
        if (repChanged == true)
        {
            if (badRepDeckAdded == true)
            {
                return;
            }
            else if (goodRepDeckAdded == true)
            {
                for (int i = 0; i < currentRepEvents.Length; i++)
                {
                    replaceEvent = currentRepEvents[i];
                    RandomEvents[replaceEvent] = BadRepDeck[i];
                }
                goodRepDeckAdded = false;
                badRepDeckAdded = true;
            }
        }
        else
        {
            for (int i = 0; i < BadRepDeck.Length; i++)
            {
                RandomEvents[in_TotalEvents] = BadRepDeck[i];
                currentRepEvents[i] = in_TotalEvents;
                in_TotalEvents++;
            }
            badRepDeckAdded = true;
            repChanged = true;
        }
    }

    #endregion


    // Standard event trigger (Coroutine based on the fl_standardeventimer)
    IEnumerator EventTrigger()
    {
        bl_CoroutineStart = false;

        yield return new WaitForSeconds(fl_EventTimer);

        EnableEvent();
    }

    public void RestartTimer()
    {
        RandomTime();
        bl_CoroutineStart = true;
        StartCoroutine(EventTrigger());
        RandomEvents[currentEvent].gameObject.SetActive(false);
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

    #region Standard Events Actions

    //public void ReprimandThemBoth()
    //{
    //    StandardDeck[0].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}
    //public void IgnoreTheIncident()
    //{
    //    StandardDeck[0].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}

    //public void ReprimandTheOffender()
    //{
    //    StandardDeck[1].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}
    //public void EncourageRetaliation()
    //{
    //    StandardDeck[1].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}

    //public void PunishThem()
    //{
    //    StandardDeck[2].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}
    //public void BlackMailThem()
    //{
    //    StandardDeck[2].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}

    //public void InformTheJudges()
    //{
    //    StandardDeck[3].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}
    //public void SayNothing()
    //{
    //    StandardDeck[3].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}

    //public void GrapevineReprimand()
    //{
    //    StandardDeck[4].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}
    //public void GrapevineEncourage()
    //{
    //    StandardDeck[4].gameObject.SetActive(false);
    //    bl_CoroutineStart = true;
    //}

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
