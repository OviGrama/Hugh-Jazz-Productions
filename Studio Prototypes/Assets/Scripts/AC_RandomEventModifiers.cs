using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_RandomEeventModifiers : MonoBehaviour
{
    private JH_Student_Manager studentSpawner;
    private AC_SchoolStatsManager schoolStats;

    [Header("Student Modifiers")]
    public int eqModifier;
    public int iqModifier;
    public int flModifier;
    public int slModifier;
    public int happinessModifier;
    public int alignmentModifier;

    [Header("School Modifiers")]
    public int repModifier;
    public int moneyModifier;

    // Start is called before the first frame update
    void Start()
    {
        studentSpawner = GameObject.Find("Game").GetComponent<JH_Student_Manager>();
        schoolStats = GameObject.Find("SchoolStatDropDown").GetComponent<AC_SchoolStatsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomEventModifiers()
    {
        if (eqModifier != 0 || iqModifier != 0 || flModifier != 0 || slModifier != 0 || happinessModifier != 0 || alignmentModifier != 0)
        {
            for (int i = 0; i < studentSpawner.numberOfStudents; i++)
            {
                studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().EQ += eqModifier;
                studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().IQ += iqModifier;
                studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().FL += flModifier;
                studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().SL += slModifier;
                studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().happinessLevel += happinessModifier;
                studentSpawner.go_studentList[i].GetComponent<JH_Student_Stats>().alignmentLevel += alignmentModifier;
            }
        }

        if (repModifier != 0 || moneyModifier != 0)
        {
            schoolStats.schoolRep += repModifier;
            schoolStats.currentMoney += moneyModifier;
        }
    }
}
