using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OG_EnableUIonMouseEnter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public float fl_fadetime;
    public Canvas canvas;
    public bool bl_displayStats;

    // Use this for initialization
    void Start()
    {
        //canvas = GameObject.Find("Info").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayStats();
        OnMouseClick();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!bl_displayStats)
        { 
            bl_displayStats = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(bl_displayStats)
        {
            bl_displayStats = false;
        }
    }

    public void OnMouseClick()
    {
        if (bl_displayStats && Input.GetButtonDown("Fire1"))
        {
            bl_displayStats = false;
        }
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
        else
        {
            canvas.enabled = false;
        }
    }
}
