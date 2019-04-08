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

    [HideInInspector] public Sprite studentBody;
    [HideInInspector] public Sprite studentHead;

    private Image studentImage;
    private Image studentImageHead;

    // Start is called before the first frame update
    void Start()
    {
        tx_name = transform.GetChild(0).GetComponent<Text>();
        tx_stats = GameObject.Find("Student1InfoPanel").transform.GetChild(6).GetComponent<Text>();

        studentImage = GameObject.Find("Student1InfoPanel").transform.GetChild(2).GetComponent<Image>();
        studentImageHead = studentImage.gameObject.transform.GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        tx_name.text = studentName;
    }

    public void UpdateStats()
    {
        
        tx_stats.text = studentName + "\r\n"
                        + "\r\n"
                        + "Power: " + studentPower + "\r\n"
                        + "EQ: " + EQ + " (" + SetValue(EQ, previousEQ) + (EQ - previousEQ) + ")" + "\r\n"
                        + "IQ: " + IQ + " (" + SetValue(IQ, previousIQ) + (IQ - previousIQ) + ")" + "\r\n"
                        + "FL: " + FL + " (" + SetValue(FL, previousFL) + (FL - previousFL) + ")" + "\r\n"
                        + "SL: " + SL + " (" + SetValue(SL, previousSL) + (SL - previousSL) + ")" + "\r\n"
                        + "\r\n"
                        + "Happiness: " + happinessLevel + " (" + SetValue(happinessLevel, previousHappiness) + (happinessLevel - previousHappiness) + ")" + "\r\n"
                        + "Alignment: " + alignmentLevel + " (" + SetValue(alignmentLevel, previousAlignment) + (alignmentLevel - previousAlignment) + ")" + "\r\n";

        studentImage.sprite = studentBody;
        studentImageHead.sprite = studentHead;
    }

    string SetValue(int value1, int value2)
    {
        if (value1 - value2 > 0)
        {
            return "+";
        }
        else
        {
            return "";
        }
    }
}
