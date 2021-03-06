﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Student_Manager : MonoBehaviour
{
    // Aidan's reference to current number of students.
    public int numberOfStudents;

    [Header("Appearance Sprites")]
    public Sprite[] bodyList;
    public Sprite[] maleHeadList;
    public Sprite[] femaleHeadList;

    [Header("Student Names")]
    public string[] maleFirstNames;
    public string[] femaleFirstNames;
    public string[] surnameList;

    public int in_dormUpgrades = 0;

    public int in_spawnAmount;
    private int in_amountSpawned;

    private GameObject go_classManager;

    public GameObject go_studentPrefab;
    public GameObject[] go_studentList;

    [Header("Starting Values")]
    public int maxStartHappiness;
    public int minStartHappiness;
    public int maxStartAlignment;
    public int minStartAlignment;

    [Header("Power Types")]
    public string[] physicalPowers;
    public string[] mentalPowers;

    [Header("Bathrooms")]
    public GameObject go_mBathroom;
    public GameObject go_fBathroom;

    public enum StudentGender
    {
        Male,
        Female
    }

    // Start is called before the first frame update
    void Start()
    {
        go_classManager = GameObject.Find("ClassDrops");
        go_studentList = new GameObject[27];
        SpawnStudents();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnStudents()
    {
        for (int i = 0; i < in_spawnAmount; i++)
        {
            GameObject newStudent = Instantiate(go_studentPrefab, go_classManager.GetComponent<JH_Assign_Class>().go_homeSpot.transform.position, transform.rotation);
            go_studentList[i] = newStudent;
            if (in_amountSpawned <= 9) newStudent.GetComponent<JH_Student_Move>().groupNumber = JH_Set_Class.GroupNumber.One;
            if (in_amountSpawned > 9 && in_amountSpawned <= 18) newStudent.GetComponent<JH_Student_Move>().groupNumber = JH_Set_Class.GroupNumber.Two;
            if (in_amountSpawned > 18 && in_amountSpawned <= 27) newStudent.GetComponent<JH_Student_Move>().groupNumber = JH_Set_Class.GroupNumber.Three;

            in_amountSpawned++;
        }
        numberOfStudents = in_spawnAmount;
        in_spawnAmount = 0;
        in_amountSpawned = 0;
    }
}
