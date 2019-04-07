using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Student_Stats : MonoBehaviour
{
    [Header("Student Stats")]
    public int EQ;
    public int IQ;
    public int FL;
    public int SL;

    public int happinessLevel;
    public int alignmentLevel;

    private int maxStartStats;
    private int minStartStats;
    private int maxStartHappiness;
    private int minStartHappiness;
    private int maxStartAlignment;
    private int minStartAlignment;

    public string superPower;

    private JH_Student_Manager studentManager;


    // Start is called before the first frame update
    void Start()
    {
        studentManager = GameObject.Find("Game").GetComponent<JH_Student_Manager>();
        maxStartStats = studentManager.maxStartStats;
        minStartStats = studentManager.minStartStats;
        maxStartHappiness = studentManager.maxStartHappiness;
        minStartHappiness = studentManager.minStartHappiness;
        maxStartAlignment = studentManager.maxStartAlignment;
        minStartAlignment = studentManager.minStartAlignment;

        EQ = Random.Range(minStartStats, maxStartStats + 1);
        IQ = Random.Range(minStartStats, maxStartStats + 1);
        FL = Random.Range(minStartStats, maxStartStats + 1);
        SL = Random.Range(minStartStats, maxStartStats + 1);
        happinessLevel = Random.Range(minStartHappiness, maxStartHappiness + 1);
        alignmentLevel = Random.Range(minStartAlignment, maxStartAlignment + 1);

        if (Random.Range(1, 3) == 1)
        {
            superPower = studentManager.physicalPowers[Random.Range(0, studentManager.physicalPowers.Length)];
        }
        else
        {
            superPower = studentManager.mentalPowers[Random.Range(0, studentManager.mentalPowers.Length)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
