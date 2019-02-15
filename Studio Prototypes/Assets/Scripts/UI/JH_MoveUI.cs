using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_MoveUI : MonoBehaviour
{
    private Vector3 v3_startPos;
    private Vector3 v3_endPos;
    private bool bl_open;
    [HideInInspector] public GameObject go_lastClicked;
    [HideInInspector] public GameObject go_clicked;
    public float fl_speed;
    private float fl_fullSpeed;

    // Start is called before the first frame update
    void Start()
    {
        v3_startPos = transform.parent.GetChild(0).transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        v3_startPos = transform.parent.GetChild(0).transform.position;
        v3_endPos = transform.parent.GetChild(1).transform.position;
        OpenUI();
        fl_fullSpeed = fl_speed * transform.GetComponentInParent<Canvas>().scaleFactor;
    }

    void OpenUI()
    {

        // Toggles the UI movement animation
        if (bl_open && transform.position != v3_endPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, v3_endPos, fl_fullSpeed);
        }
        else if (!bl_open && transform.position != v3_startPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, v3_startPos, fl_fullSpeed);
        }

        // Turns off all UI panels when the UI is closed
        if (transform.position == v3_startPos)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).GetComponent<JH_ClickButton>() != null)
                {
                    transform.GetChild(i).GetComponent<JH_ClickButton>().go_panel.SetActive(false);
                }
            }
        }
    }

    public void OnMouseClick()
    {
        // Opens the UI if it's closed
        if (!bl_open)
        {
            bl_open = true;
            go_clicked.GetComponent<JH_ClickButton>().go_panel.SetActive(true);
            go_lastClicked = go_clicked;
            go_clicked = null;
        }
        else
        {
            // Changes the UI panel but keeps the UI open
            if (go_clicked != go_lastClicked)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    if (transform.GetChild(i).GetComponent<JH_ClickButton>() != null)
                    {
                        if (transform.GetChild(i).gameObject != go_clicked)
                        {
                            transform.GetChild(i).GetComponent<JH_ClickButton>().go_panel.SetActive(false);
                        }
                    }
                }
                go_clicked.GetComponent<JH_ClickButton>().go_panel.SetActive(true);
                go_lastClicked = go_clicked;
                go_clicked = null;
            }
            // Closes the UI
            else
            {
                bl_open = false;
                go_clicked = null;
                go_lastClicked = null;
            }
        }

    }

    public void CloseUI()
    {
        bl_open = false;
    }
}
