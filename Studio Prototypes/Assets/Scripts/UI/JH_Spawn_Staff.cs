using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Spawn_Staff : MonoBehaviour
{
    public GameObject go_staff;
    private GameObject go_classManager;

    // Start is called before the first frame update
    void Start()
    {
        go_classManager = GameObject.Find("ClassDrops");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnStaff()
    {
        Instantiate(go_staff, go_classManager.GetComponent<JH_Assign_Class>().go_homeSpot.transform.position, transform.rotation);
    }
}
