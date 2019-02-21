using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_ClickButton : MonoBehaviour
{
    private Vector3 v3_startPos;
    private Vector3 v3_endPos;
    private float fl_startPos;
    private GameObject go_mainUI;
    private Button bt_button;
    [HideInInspector] public bool bl_open;
    public GameObject go_panel;
    public float verticalOffset;
    public float moveSpeed;
    private float fl_speed;

    // Start is called before the first frame update
    void Start()
    {
        fl_startPos = transform.position.y;
        go_mainUI = transform.parent.gameObject;
        bt_button = transform.GetComponentInChildren<Button>();

        // Sets the starting position for the UI
        go_mainUI.transform.parent.GetChild(0).transform.position = new Vector3(go_mainUI.transform.parent.GetChild(0).transform.position.x,
                                                                                transform.position.y,
                                                                                go_mainUI.transform.parent.GetChild(0).transform.position.z);

        // Finds the panel if none is set in the inspector
        if (go_panel == null) go_panel = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // Sets the speed to be the same on all screen sizes
        fl_speed = moveSpeed * go_mainUI.GetComponentInParent<Canvas>().scaleFactor;

        // Sets the start and end positions for the UI movement
        v3_startPos = new Vector3(transform.position.x,
                                  go_mainUI.transform.parent.GetChild(0).transform.position.y,
                                  transform.position.z);
        v3_endPos = new Vector3(transform.position.x,
                                go_mainUI.transform.parent.GetChild(1).transform.position.y + verticalOffset,
                                transform.position.z);

        // Turns off color tints for open buttons
        if (bl_open)
        {
            bt_button.transition = Selectable.Transition.None;
        }
        else
        {
            bt_button.transition = Selectable.Transition.ColorTint;
        }

        OpenUI();
    }


    void OpenUI()
    {
        if (bl_open)
        {
            // Sets the end position relative to the UI position
            Vector3 v3_moveToEnd = new Vector3(transform.position.x, v3_endPos.y + verticalOffset, transform.position.z);

            // Moves the UI to the end position
            if (transform.position.y != v3_endPos.y)
            {
                transform.position = Vector3.MoveTowards(transform.position, v3_moveToEnd, fl_speed);
            }

            // Sets the opening UI above all others
            //transform.SetSiblingIndex(0);

            // Turns on the panel
            go_panel.SetActive(true);
        }
        else
        {
            // Sets the start position relative to the UI position
            Vector3 v3_moveToStart = new Vector3(transform.position.x, v3_startPos.y, transform.position.z);

            // Moves the UI to the start position
            if (transform.position.y != v3_startPos.y)
            {
                transform.position = Vector3.MoveTowards(transform.position, v3_moveToStart, fl_speed);
            }

            // Turns the panel off once it's off of the screen
            if (transform.position.y <= fl_startPos) go_panel.SetActive(false);
        }

    }

    public void ButtonClick()
    {
        // Closes the panel on click if it's opened
        if (bl_open)
        {
            bl_open = false;
            transform.SetAsFirstSibling();
        }

        // Closes all other panels and opens this one on click
        else
        {
            bl_open = true;
            for (int i = 0; i < go_mainUI.transform.childCount; i++)
            {
                if (go_mainUI.transform.GetChild(i).GetComponent<JH_ClickButton>() != null)
                {
                    if (go_mainUI.transform.GetChild(i).gameObject != gameObject)
                    {
                        if (go_mainUI.transform.GetChild(i).GetComponent<JH_ClickButton>().bl_open)
                        {
                            go_mainUI.transform.GetChild(i).GetComponent<JH_ClickButton>().bl_open = false;
                            go_mainUI.transform.GetChild(i).transform.SetAsFirstSibling();
                            transform.SetSiblingIndex(1);
                            return;
                        }
                        else transform.SetAsFirstSibling();
                    }
                }
            }
        }
    }

    public void ClosePanel()
    {
        bl_open = false;
    }
}
