using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_EnableUIonMouseClick : MonoBehaviour
{
    public Canvas canvas;
    public bool bl_displayStats = false;

    // Use this for initialization
    void Start()
    {
        //canvas = GameObject.Find("Stats").GetComponent<Canvas>();

        canvas = GetComponentInChildren<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMouseClick();
        DisplayStats();       
    }


    public void OnMouseClick()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (bl_displayStats) bl_displayStats = false;
            else bl_displayStats = true;
        }
        

    }

    //public void OnMouseCloseButtonClick()
    //{
    //    if (bl_displayStats && Input.GetButtonDown("Fire1"))
    //    {
    //        bl_displayStats = false;
    //    }
    //}

    private void OnMouseDown()
    {
        if (bl_displayStats) bl_displayStats = false;

        else bl_displayStats = true;
    }

    //private void OnMouseUp()
    //{
    //    bl_displayStats = false;
    //}

    void DisplayStats()
    {
        if (bl_displayStats)
        {
            canvas.enabled = true;
        }
        if(!bl_displayStats)
        {
            canvas.enabled = false;
        }
    }
}
