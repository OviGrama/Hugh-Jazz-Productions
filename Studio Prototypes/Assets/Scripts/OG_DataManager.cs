using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_DataManager : MonoBehaviour
{
    public static OG_DataManager DM_instance;

    AC_GameOver gameover_ref;
    AC_YearEnd yearend_ref;

    public int in_YearsPlayed;
    public int in_WeeksPlayed;
    public int in_HeroGraduates;
    public int in_VillainGraduates;
    public int in_FailedGraduates;
    public int in_TotalGraduates;

    public string st_EndTitle;

    private void Start()
    {
        gameover_ref = GameObject.Find("GameManager").GetComponent<AC_GameOver>();
        yearend_ref = GameObject.Find("GameManager").GetComponent<AC_YearEnd>();
    }

    // Start is called before the first frame update
    void Awake()
    {   // If the instance was not set yet,
        if (DM_instance == null)
        { // set this as the instance
            DM_instance = this;
        }
        // If the instance was already set, and is not this one
        else if (DM_instance != null)
        {// destroy this gameobject.
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }


    // Update is called once per frame
    void Update()
    {

    }

    public void DataManagerUpdater()
    {
        in_YearsPlayed = yearend_ref.currentYear;
        in_WeeksPlayed = yearend_ref.currentWeek;
        in_HeroGraduates = yearend_ref.numberOfHeroes + yearend_ref.numberOfSuperheroes;
        in_VillainGraduates = yearend_ref.numberOfVillians + yearend_ref.numberOfSupervillians;
        in_TotalGraduates = 0;
        in_FailedGraduates = 0;

        for (int i = 0; i < yearend_ref.numberOfGraduates.Length; i++)
        {
            in_TotalGraduates += yearend_ref.numberOfGraduates[i];
        }
        for (int i = 0; i < yearend_ref.numberOfNonGraduates.Length; i++)
        {
            in_FailedGraduates += yearend_ref.numberOfNonGraduates[i];
        }

        st_EndTitle = gameover_ref.endText;


    }
}
