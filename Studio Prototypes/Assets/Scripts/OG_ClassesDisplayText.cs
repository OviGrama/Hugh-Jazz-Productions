using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_ClassesDisplayText : MonoBehaviour
{


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


    public void ChangeTextToClassTextMonAM(string MonAMClassName)
    {
        txt_SpecificClassMonAM.text = MonAMClassName;
    }
    public void ChangeTextToClassTextTueAM(string TueAMClassName)
    {
        txt_SpecificClassTueAM.text = TueAMClassName;
    }
    
}
