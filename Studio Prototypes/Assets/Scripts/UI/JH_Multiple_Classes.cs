using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Multiple_Classes : MonoBehaviour
{
    private Dropdown dd_classes;
    private GameObject[] go_timetableManagers;

    // Start is called before the first frame update
    void Start()
    {
        dd_classes = GetComponent<Dropdown>();
        go_timetableManagers = new GameObject[3];
        go_timetableManagers[0] = GameObject.Find("ClassDrops");
        go_timetableManagers[1] = GameObject.Find("ClassDrops2");
        go_timetableManagers[2] = GameObject.Find("ClassDrops3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeGroups()
    {
        go_timetableManagers[dd_classes.value].transform.SetAsLastSibling();
    }
}
