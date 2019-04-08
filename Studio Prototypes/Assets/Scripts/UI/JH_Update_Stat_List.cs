using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Update_Stat_List : MonoBehaviour
{

    private GameObject go_studentManager;
    private GameObject go_statManager;

    // Start is called before the first frame update
    void Start()
    {
        go_studentManager = GameObject.Find("Game");
        go_statManager = GameObject.Find("StudentButtonListContent");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < go_studentManager.GetComponent<JH_Student_Manager>().go_studentList.Length; i++)
        {
            if (go_studentManager.GetComponent<JH_Student_Manager>().go_studentList[i] != null)
            {
                go_statManager.transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                go_statManager.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
