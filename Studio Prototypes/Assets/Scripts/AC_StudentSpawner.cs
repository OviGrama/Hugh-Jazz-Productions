using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_StudentSpawner : MonoBehaviour
{

    // Hold each of the spawn
    public GameObject prefab_Student;
    public GameObject spawnLocation;
    public GameObject[] go_Students;
    public int numberOfStudents;

    // Start is called before the first frame update
    void Start()
    {
        SpawnStudents();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnStudents()
    {

        for (int i = 0; i < numberOfStudents; i++)
        {
            go_Students[i] = Instantiate(prefab_Student, spawnLocation.transform.position, Quaternion.identity);
        }

    }
}
