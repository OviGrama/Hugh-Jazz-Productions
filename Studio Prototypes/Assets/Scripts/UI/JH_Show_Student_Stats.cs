using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Show_Student_Stats : MonoBehaviour
{
    [HideInInspector] public string studentName;
    [HideInInspector] public string studentPower;

    [HideInInspector] public int EQ;
    [HideInInspector] public int IQ;
    [HideInInspector] public int FL;
    [HideInInspector] public int SL;

    [HideInInspector] public int happinessLevel;
    [HideInInspector] public int alignmentLevel;

    [HideInInspector] public int previousEQ;
    [HideInInspector] public int previousIQ;
    [HideInInspector] public int previousFL;
    [HideInInspector] public int previousSL;
    [HideInInspector] public int previousHappiness;
    [HideInInspector] public int previousAlignment;

    public bool bl_active;

    private Text tx_name;
    private Text tx_stats;

    // Start is called before the first frame update
    void Start()
    {
        tx_name = transform.GetChild(0).GetComponent<Text>();
        tx_stats = GameObject.Find("Student1InfoPanel").transform.GetChild(6).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tx_name.text = studentName;
    }

    public void UpdateStats()
    {
        
        tx_stats.text = studentName + "/r/n"
                        + "/r/n"
                        + "Power: " + studentPower + "/r/n"
                        + "EQ: " + EQ + " (" + (previousEQ - EQ) + ")" + "/r/n"
                        + "IQ: " + IQ + " (" + (previousIQ - IQ) + ")" + "/r/n"
                        + "FL: " + FL + " (" + (previousFL - FL) + ")" + "/r/n"
                        + "SL: " + SL + " (" + (previousSL - SL) + ")" + "/r/n"
                        + "/r/n"
                        + "Happiness: " + happinessLevel + " (" + (previousHappiness - happinessLevel) + ")" + "/r/n"
                        + "Alignment: " + alignmentLevel + " (" + (previousAlignment - alignmentLevel) + ")" + "/r/n";
        
    }
}
