using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_ClassesDropDown : MonoBehaviour
{
    List<string> MondayAM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };
    List<string> TuesdayAM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };
    List<string> WednesdayAM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };
    List<string> ThursdayAM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };
    List<string> FridayAM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };

    List<string> MondayPM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };
    List<string> TuesdayPM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };
    List<string> WednesdayPM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };
    List<string> ThursdayPM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };
    List<string> FridayPM = new List<string>() { "Select", "EQ", "IQ", "Super", "Fitness" };


    List<string> Weekend = new List<string>() { "Select", "Homework", "Freetime" };

    [Header("Morning Dropdowns")]
    public Dropdown dd_MonDropdownAM;
    public Text txt_MonClassAM;
    public GameObject pl_EQ_PanelMonAM;
    public GameObject pl_IQ_PanelMonAM;
    public GameObject pl_Super_PanelMonAM;
    public GameObject pl_Fitness_PanelMonAM;

    public Dropdown dd_TueDropdownAM;
    public Text txt_TueClassAM;
    public GameObject pl_EQ_PanelTueAM;
    public GameObject pl_IQ_PanelTueAM;
    public GameObject pl_Super_PanelTueAM;
    public GameObject pl_Fitness_PanelTueAM;

    public Dropdown dd_WedDropdownAM;
    public Text txt_WedClassAM;
    public GameObject pl_EQ_PanelWedAM;
    public GameObject pl_IQ_PanelWedAM;
    public GameObject pl_Super_PanelWedAM;
    public GameObject pl_Fitness_PanelWedAM;

    public Dropdown dd_ThuDropdownAM;
    public Text txt_ThuClassAM;
    public GameObject pl_EQ_PanelThuAM;
    public GameObject pl_IQ_PanelThuAM;
    public GameObject pl_Super_PanelThuAM;
    public GameObject pl_Fitness_PanelThuAM;

    public Dropdown dd_FrDropdownAM;
    public Text txt_FrClassAM;
    public GameObject pl_EQ_PanelFrAM;
    public GameObject pl_IQ_PanelFrAM;
    public GameObject pl_Super_PanelFrAM;
    public GameObject pl_Fitness_PanelFrAM;

    [Header("Afternoon Dropdowns")]
    public Dropdown dd_MonDropdownPM;
    public Text txt_MonClassPM;
    public GameObject pl_EQ_PanelMonPM;
    public GameObject pl_IQ_PanelMonPM;
    public GameObject pl_Super_PanelMonPM;
    public GameObject pl_Fitness_PanelMonPM;

    public Dropdown dd_TueDropdownPM;
    public Text txt_TueClassPM;
    public GameObject pl_EQ_PanelTuePM;
    public GameObject pl_IQ_PanelTuePM;
    public GameObject pl_Super_PanelTuePM;
    public GameObject pl_Fitness_PanelTuePM;

    public Dropdown dd_WedDropdownPM;
    public Text txt_WedClassPM;
    public GameObject pl_EQ_PanelWedPM;
    public GameObject pl_IQ_PanelWedPM;
    public GameObject pl_Super_PanelWedPM;
    public GameObject pl_Fitness_PanelWedPM;

    public Dropdown dd_ThuDropdownPM;
    public Text txt_ThuClassPM;
    public GameObject pl_EQ_PanelThuPM;
    public GameObject pl_IQ_PanelThuPM;
    public GameObject pl_Super_PanelThuPM;
    public GameObject pl_Fitness_PanelThuPM;

    public Dropdown dd_FrDropdownPM;
    public Text txt_FrClassPM;
    public GameObject pl_EQ_PanelFrPM;
    public GameObject pl_IQ_PanelFrPM;
    public GameObject pl_Super_PanelFrPM;
    public GameObject pl_Fitness_PanelFrPM;

    [Header("Weekend Dropdown")]
    public Dropdown dd_WeEndDropdown;
    public Text txt_Weekend;


    #region Text Indexes For each day of the week (AM & PM)
    public void Dropdown_SelectedIndexMonAM(int indexMonAM)
    {
        txt_MonClassAM.text = MondayAM[indexMonAM];
    }
    public void Dropdown_SelectedIndexTueAM(int indexTueAM)
    {
        txt_TueClassAM.text = TuesdayAM[indexTueAM];
    }
    public void Dropdown_SelectedIndexWedAM(int indexWedAM)
    {
        txt_WedClassAM.text = WednesdayAM[indexWedAM];
    }
    public void Dropdown_SelectedIndexThuAM(int indexThuAM)
    {
        txt_ThuClassAM.text = ThursdayAM[indexThuAM];
    }
    public void Dropdown_SelectedIndexFrAM(int indexFrAM)
    {
        txt_FrClassAM.text = FridayAM[indexFrAM];
    }

    public void Dropdown_SelectedIndexMonPM(int indexMonPM)
    {
        txt_MonClassPM.text = MondayPM[indexMonPM];
    }
    public void Dropdown_SelectedIndexTuePM(int indexTuePM)
    {
        txt_TueClassPM.text = TuesdayPM[indexTuePM];
    }
    public void Dropdown_SelectedIndexWedPM(int indexWedPM)
    {
        txt_WedClassPM.text = WednesdayPM[indexWedPM];
    }
    public void Dropdown_SelectedIndexThuPM(int indexThuPM)
    {
        txt_ThuClassPM.text = ThursdayPM[indexThuPM];
    }
    public void Dropdown_SelectedIndexFriPM(int indexFriPM)
    {
        txt_FrClassPM.text = FridayPM[indexFriPM];
    }

    public void Dropdown_SelectedIndexWeekend(int indexWeekend)
    {
        txt_Weekend.text = Weekend[indexWeekend];
    }

    #endregion


    public void ClassesPanels()
    {
        if(dd_MonDropdownAM.value == 1)
        {
            pl_EQ_PanelMonAM.SetActive(true);
        }
        else
        {
            pl_EQ_PanelMonAM.SetActive(false);       
        }

        if(dd_MonDropdownAM.value == 2)
        {
            pl_IQ_PanelMonAM.SetActive(true);
        }
        else
        {
            pl_IQ_PanelMonAM.SetActive(false);
        }

        if(dd_MonDropdownAM.value == 3)
        {
            pl_Super_PanelMonAM.SetActive(true);
        }
        else
        {
            pl_Super_PanelMonAM.SetActive(false);
        }

        if(dd_MonDropdownAM.value == 4)
        {
            pl_Fitness_PanelMonAM.SetActive(true);
        }
        else
        {
            pl_Fitness_PanelMonAM.SetActive(false);
        }
    }



    private void Start()
    {
        PopulateList();
    }


    void PopulateList()
    {

        dd_MonDropdownAM.AddOptions(MondayAM);
        dd_TueDropdownAM.AddOptions(TuesdayAM);
        dd_WedDropdownAM.AddOptions(WednesdayAM);
        dd_ThuDropdownAM.AddOptions(ThursdayAM);
        dd_FrDropdownAM.AddOptions(FridayAM);

        dd_MonDropdownPM.AddOptions(MondayPM);
        dd_TueDropdownPM.AddOptions(TuesdayPM);
        dd_WedDropdownPM.AddOptions(WednesdayPM);
        dd_ThuDropdownPM.AddOptions(ThursdayPM);
        dd_FrDropdownPM.AddOptions(FridayPM);

        dd_WeEndDropdown.AddOptions(Weekend);
    }
}
