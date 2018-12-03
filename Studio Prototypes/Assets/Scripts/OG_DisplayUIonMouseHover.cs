using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_DisplayUIonMouseHover : MonoBehaviour {
    public float fl_fadetime;
    public Canvas canvas;
    public bool bl_displayStats;

	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("Stats").GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
        DisplayStats();


    }

    private void OnMouseDown()
    {
        if(bl_displayStats) bl_displayStats = false;

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
        else
        {
            canvas.enabled = false;
        }
    }
}
