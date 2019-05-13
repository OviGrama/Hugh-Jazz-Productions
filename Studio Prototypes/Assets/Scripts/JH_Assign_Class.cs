using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Assign_Class : MonoBehaviour {

    public JH_Set_Class.ClassName mondayAM;
    public JH_Set_Class.ClassName mondayPM;
    public JH_Set_Class.ClassName tuesdayAM;
    public JH_Set_Class.ClassName tuesdayPM;
    public JH_Set_Class.ClassName wednesdayAM;
    public JH_Set_Class.ClassName wednesdayPM;
    public JH_Set_Class.ClassName thursdayAM;
    public JH_Set_Class.ClassName thursdayPM;
    public JH_Set_Class.ClassName fridayAM;
    public JH_Set_Class.ClassName fridayPM;

    public JH_Set_Class.ClassName currentClass;

    public Text txt_SpecificClassMonAM;
    public Text txt_SpecificClassTueAM;
    public Text txt_SpecificClassWedAM;
    public Text txt_SpecificClassThuAM;
    public Text txt_SpecificClassFrAM;

    public Text txt_SpecificClassMonPM;
    public Text txt_SpecificClassTuePM;
    public Text txt_SpecificClassWedPM;
    public Text txt_SpecificClassThuPM;
    public Text txt_SpecificClassFrPM;

    [Header("Class Objects")]
    public GameObject go_literatureClass;
    public GameObject go_citizenshipClass;
    public GameObject go_scienceClass;
    public GameObject go_sportsClass;
    public GameObject go_superClass;
    public GameObject go_advancedLiterature;
    public GameObject go_advancedCitizenship;
    public GameObject go_psychology;
    public GameObject go_physiology;
    public GameObject go_advancedScience;
    public GameObject go_persuasionHero;
    public GameObject go_persuasionVillain;
    public GameObject go_geneticsHero;
    public GameObject go_geneticsVillain;
    public GameObject go_gymClass;
    public GameObject go_advancedGym;
    public GameObject go_meditationClass;
    public GameObject go_advancedMeditation;
    public GameObject go_super201;
    public GameObject go_physicalDevelopment;
    public GameObject go_mentalDevelopment;
    public GameObject go_responsiblePowerManagement;
    public GameObject go_maximisingPowerPotential;

    [Header("Facilities Objects")]
    public GameObject go_canteen;
    public GameObject go_hallway;
    public GameObject go_homeSpot;
    public GameObject[] go_dorms;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        AssignClass();
	}

    void AssignClass()
    {
        if (mondayAM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassMonAM.text = mondayAM.ToString();
        }

        if(tuesdayAM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassTueAM.text = tuesdayAM.ToString();
        }

        if (wednesdayAM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassWedAM.text = wednesdayAM.ToString();
        }

        if (thursdayAM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassThuAM.text = thursdayAM.ToString();
        }

        if (fridayAM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassFrAM.text = fridayAM.ToString();
        }

        if (mondayPM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassMonPM.text = mondayPM.ToString();
        }

        if (tuesdayPM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassTuePM.text = tuesdayPM.ToString();
        }

        if (wednesdayPM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassWedPM.text = wednesdayPM.ToString();
        }

        if (thursdayPM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassThuPM.text = thursdayPM.ToString();
        }

        if (fridayPM != JH_Set_Class.ClassName.None)
        {
            txt_SpecificClassFrPM.text = fridayPM.ToString();
        }
    }

    
}
