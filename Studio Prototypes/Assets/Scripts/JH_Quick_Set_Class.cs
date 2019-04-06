using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Quick_Set_Class : MonoBehaviour
{
    private Dropdown dd_classes;
    private GameObject[] go_timetableManagers;
    public Dropdown[] dd_classDropdowns;
    public JH_Set_Class.GroupNumber groupNumber;

    // Start is called before the first frame update
    void Start()
    {
        dd_classDropdowns = new Dropdown[30];
        go_timetableManagers = new GameObject[3];
        dd_classes = GameObject.Find("ClassesDropdown").GetComponent<Dropdown>();

        go_timetableManagers[0] = GameObject.Find("ClassDrops");
        go_timetableManagers[1] = GameObject.Find("ClassDrops2");
        go_timetableManagers[2] = GameObject.Find("ClassDrops3");

        for (int i = 0; i < 10; i++)
        {
            dd_classDropdowns[i] = go_timetableManagers[0].transform.GetChild(i).GetChild(0).GetComponent<Dropdown>();
        }
        for (int i = 0; i < 10; i++)
        {
            dd_classDropdowns[i + 10] = go_timetableManagers[1].transform.GetChild(i).GetChild(0).GetComponent<Dropdown>();
        }
        for (int i = 0; i < 10; i++)
        {
            dd_classDropdowns[i + 20] = go_timetableManagers[2].transform.GetChild(i).GetChild(0).GetComponent<Dropdown>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dd_classes.value == 0) groupNumber = JH_Set_Class.GroupNumber.One;
        if (dd_classes.value == 1) groupNumber = JH_Set_Class.GroupNumber.Two;
        if (dd_classes.value == 2) groupNumber = JH_Set_Class.GroupNumber.Three;
    }
}
