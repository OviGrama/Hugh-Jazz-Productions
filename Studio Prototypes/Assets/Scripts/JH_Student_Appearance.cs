using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Student_Appearance : MonoBehaviour
{

    private GameObject go_studentManager;
    private bool bl_setupFinished;
    public string studentName;

    // Start is called before the first frame update
    void Start()
    {
        go_studentManager = GameObject.Find("Game");
    }

    // Update is called once per frame
    void Update()
    {
        if (!bl_setupFinished) StudentSetup();
    }

    void StudentSetup()
    {
        // Randomises gender and assigns body sprite
        int gender = Random.Range(1, 3);

        int body = Random.Range(0, go_studentManager.GetComponent<JH_Student_Manager>().bodyList.Length);
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = go_studentManager.GetComponent<JH_Student_Manager>().bodyList[body];

        // Assigns random female head and first name
        if (gender == 1)
        {
            int head = Random.Range(0, go_studentManager.GetComponent<JH_Student_Manager>().femaleHeadList.Length);
            transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = go_studentManager.GetComponent<JH_Student_Manager>().femaleHeadList[head];

            int firstName = Random.Range(0, go_studentManager.GetComponent<JH_Student_Manager>().femaleFirstNames.Length);
            int surname = Random.Range(0, go_studentManager.GetComponent<JH_Student_Manager>().surnameList.Length);

            studentName = go_studentManager.GetComponent<JH_Student_Manager>().femaleFirstNames[firstName] + " " +
                          go_studentManager.GetComponent<JH_Student_Manager>().surnameList[surname];
        }
        // Assigns random male head and first name
        else
        {
            int head = Random.Range(0, go_studentManager.GetComponent<JH_Student_Manager>().maleHeadList.Length);
            transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = go_studentManager.GetComponent<JH_Student_Manager>().maleHeadList[head];

            int firstName = Random.Range(0, go_studentManager.GetComponent<JH_Student_Manager>().maleFirstNames.Length);
            int surname = Random.Range(0, go_studentManager.GetComponent<JH_Student_Manager>().surnameList.Length);

            studentName = go_studentManager.GetComponent<JH_Student_Manager>().maleFirstNames[firstName] + " " +
                          go_studentManager.GetComponent<JH_Student_Manager>().surnameList[surname];
        }

        bl_setupFinished = true;
        
    }
}
