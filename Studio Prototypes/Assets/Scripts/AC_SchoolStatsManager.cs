using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_SchoolStatsManager : MonoBehaviour
{

    // Varaibles for the dropdown itself.
    public Dropdown dd_SchoolStats;
    // Use these for adding options to the Dropdown List
    public Dropdown.OptionData dd_SchoolStats_Money, dd_SchoolStats_Reputation, dd_SchoolStats_AverageHappiness, dd_SchoolStats_AverageMorality;
    // The list of messages for the Dropdown
    public List<Dropdown.OptionData> dd_SchoolStats_Messages = new List<Dropdown.OptionData>();
    public int dd_SchoolStats_Index;
    public string dd_CurrentMessage;
    public Text dd_SSText;

    // Variables for the dropdown content.
    public int currentMoney;
    public string currentSchoolReputation;
    public string currentAverageHappiness;
    public string currentAverageMorality;


    //Updates the school money stat.
    public void StatsUpdate()
    {

        // CLears the dropdown.
        dd_SchoolStats.ClearOptions();

        //Create a new option for the Dropdown menu which reads "MONEY: " and add to messages List
        //dd_SchoolStats_Money = new Dropdown.OptionData();
        dd_SchoolStats_Money.text = "MONEY: " + currentMoney;
        dd_SchoolStats_Messages.Remove(dd_SchoolStats_Money);
        dd_SchoolStats_Messages.Add(dd_SchoolStats_Money);

        //Create a new option for the Dropdown menu which reads "SCH REP: " and add to messages List
        //dd_SchoolStats_Reputation = new Dropdown.OptionData();
        dd_SchoolStats_Reputation.text = "SCH REP: " + currentSchoolReputation;
        dd_SchoolStats_Messages.Remove(dd_SchoolStats_Reputation);
        dd_SchoolStats_Messages.Add(dd_SchoolStats_Reputation);

        //Create a new option for the Dropdown menu which reads "AVR HAP: " and add to messages List
        //dd_SchoolStats_AvarageHappiness = new Dropdown.OptionData();
        dd_SchoolStats_AverageHappiness.text = "AVG HAP: " + currentAverageHappiness;
        dd_SchoolStats_Messages.Remove(dd_SchoolStats_AverageHappiness);
        dd_SchoolStats_Messages.Add(dd_SchoolStats_AverageHappiness);

        //Create a new option for the Dropdown menu which reads "AVR MOR: " and add to messages List
        //ddd_SchoolStats_AvarageMorality = new Dropdown.OptionData();
        dd_SchoolStats_AverageMorality.text = "AVG MOR: " + currentAverageMorality;
        dd_SchoolStats_Messages.Remove(dd_SchoolStats_AverageMorality);
        dd_SchoolStats_Messages.Add(dd_SchoolStats_AverageMorality);

        //Take each entry in the message List
        foreach (Dropdown.OptionData message in dd_SchoolStats_Messages)
        {
            //Add each entry to the Dropdown
            dd_SchoolStats.options.Add(message);
            //Make the index equal to the total number of entries
            dd_SchoolStats_Index = dd_SchoolStats_Messages.Count - 1;
        }

        dd_CurrentMessage = dd_SchoolStats.options[0].text;
        dd_SSText.text = dd_CurrentMessage;
    }
}
