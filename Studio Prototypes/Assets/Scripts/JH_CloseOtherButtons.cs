using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_CloseOtherButtons : MonoBehaviour
{
    public GameObject[] go_otherButtons;

    // Closes all gameObjects in the above array
    public void CloseButtons()
    {
        for (int i = 0; i < go_otherButtons.Length; i++)
        {
            go_otherButtons[i].gameObject.SetActive(false);
        }
    }
}
