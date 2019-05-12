using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OG_DataHandler : MonoBehaviour
{

    public Text txt_EndTitle;
    public Text txt_Time;
    public Text txt_HeroesG;
    public Text txt_VillainsG;
    public Text txt_FailedG;
    public Text txt_TotalG;

    OG_DataManager datamanager_ref;

    // Start is called before the first frame update
    void Start()
    {
        datamanager_ref = GameObject.Find("DataManager").GetComponent<OG_DataManager>();

        txt_Time.text = "Total Time as Principle: " + datamanager_ref.in_YearsPlayed.ToString() + " Years and " + datamanager_ref.in_WeeksPlayed.ToString() + " Weeks";
        txt_HeroesG.text = "Total Number of Hero Graduates: " + datamanager_ref.in_HeroGraduates.ToString();
        txt_VillainsG.text = "Total Number of Villain Graduates: " + datamanager_ref.in_VillainGraduates.ToString();
        txt_FailedG.text = "Total Number of Non-Graduates: " + datamanager_ref.in_FailedGraduates.ToString();
        txt_TotalG.text = "Total Number of Graduates: " + datamanager_ref.in_TotalGraduates.ToString();
        txt_EndTitle.text = datamanager_ref.st_EndTitle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }
}
