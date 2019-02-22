using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_ClassesDisplayText : MonoBehaviour
{
    public Text txt_SpecificClassMonAM = null;
    public Text txt_SpecificClassTueAM = null;
    public Text txt_SpecificClassWedAM = null;
    public Text txt_SpecificClassThuAM = null;
    public Text txt_SpecificClassFrAM = null;

    public Text txt_SpecificClassMonPM = null;
    public Text txt_SpecificClassTuePM = null;
    public Text txt_SpecificClassWedPM = null;
    public Text txt_SpecificClassThuPM = null;
    public Text txt_SpecificClassFrPM = null;


    public void ChangeTextToClassTextMonAM(string MonAMClassName)
    {
        txt_SpecificClassMonAM.text = MonAMClassName;
    }
    public void ChangeTextToClassTextTueAM(string TueAMClassName)
    {
        txt_SpecificClassTueAM.text = TueAMClassName;
    }

}
