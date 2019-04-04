using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JH_Tutorial_Move : MonoBehaviour
{

    private bool bl_changePage;

    private Vector3 v3_currentPosition;
    private Vector3 v3_moveTowards;
    private float fl_movePosition;

    public float fl_moveRange;
    public float fl_moveSpeed;

    public string st_mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        v3_currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (bl_changePage) MovePage();
        if (st_mainMenu != "" && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(st_mainMenu);
        }
    }

    public void NextPage()
    {
        v3_moveTowards = new Vector3(v3_currentPosition.x + fl_moveRange, v3_currentPosition.y, v3_currentPosition.z);
        bl_changePage = true;
    }

    public void PreviousPage()
    {
        v3_moveTowards = new Vector3(v3_currentPosition.x - fl_moveRange, v3_currentPosition.y, v3_currentPosition.z);
        bl_changePage = true;
    }

    void MovePage()
    {
        transform.position = Vector3.MoveTowards(transform.position, v3_moveTowards, fl_moveSpeed);
        if (transform.position == v3_moveTowards)
        {
            v3_currentPosition = transform.position;
            bl_changePage = false;
        }
    }
}
