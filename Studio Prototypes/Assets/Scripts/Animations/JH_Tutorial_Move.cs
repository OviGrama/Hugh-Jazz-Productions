using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JH_Tutorial_Move : MonoBehaviour
{

    private bool bl_changePage;

    private Vector3 v3_currentPosition;
    private Vector3 v3_moveTowards;
    private float fl_movePosition;

    public float fl_moveRange;
    public float fl_moveSpeed;
    public int in_panelAmount;
    private int in_currentPanel;

    public string st_mainMenu;

    public GameObject previousButton;
    public GameObject nextButton;

    // Start is called before the first frame update
    void Start()
    {
        v3_currentPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (bl_changePage) MovePage();
        if (st_mainMenu != "" && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(st_mainMenu);
        }

        if (in_currentPanel == 0) previousButton.GetComponent<Button>().interactable = false;
        else previousButton.GetComponent<Button>().interactable = true;

        if (in_currentPanel == in_panelAmount - 1) nextButton.GetComponent<Button>().interactable = false;
        else nextButton.GetComponent<Button>().interactable = true;
    }

    public void NextPage()
    {
        if (!bl_changePage)
        {
            v3_moveTowards = new Vector3(v3_currentPosition.x - fl_moveRange, v3_currentPosition.y, v3_currentPosition.z);
            bl_changePage = true;
            in_currentPanel++;
        }
    }

    public void PreviousPage()
    {
        if (!bl_changePage)
        {
            v3_moveTowards = new Vector3(v3_currentPosition.x + fl_moveRange, v3_currentPosition.y, v3_currentPosition.z);
            bl_changePage = true;
            in_currentPanel--;
        }
    }

    void MovePage()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, v3_moveTowards, fl_moveSpeed);
        if (transform.localPosition == v3_moveTowards)
        {
            v3_currentPosition = transform.localPosition;
            bl_changePage = false;
        }
    }
}
