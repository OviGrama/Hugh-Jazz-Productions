using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Staff_Spawn : MonoBehaviour
{
    public JH_Set_Class.ClassName classTaught;
    private JH_Assign_Class assignClass;
    public GameObject go_staffPrefab;

    // Start is called before the first frame update
    void Start()
    {
        assignClass = GameObject.Find("ClassDrops").GetComponent<JH_Assign_Class>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HireStaff()
    {
        GameObject go_newStaff = Instantiate(go_staffPrefab, assignClass.go_homeSpot.transform.position, transform.rotation);
        go_newStaff.GetComponent<JH_Staff_Move>().classTaught = classTaught;
        go_newStaff.GetComponent<JH_Staff_Move>().SetAppearance();
    }
}
