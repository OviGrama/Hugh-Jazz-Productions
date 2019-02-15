using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_ClickButton : MonoBehaviour
{
    private GameObject go_mainUI;
    private Button bt_button;
    public GameObject go_panel;

    // Start is called before the first frame update
    void Start()
    {
        go_mainUI = transform.parent.gameObject;
        bt_button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        // Turns off color tints for open buttons
        if (go_mainUI.GetComponent<JH_MoveUI>().go_lastClicked == gameObject)
        {
            bt_button.transition = Selectable.Transition.None;
        }
        else
        {
            bt_button.transition = Selectable.Transition.ColorTint;
        }
    }


    public void ButtonClick()
    {
        go_mainUI.GetComponent<JH_MoveUI>().go_clicked = gameObject;
    }
}
