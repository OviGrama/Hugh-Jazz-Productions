using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OG_Alignment : MonoBehaviour {

    public float fl_CurrentAlignment { get; set; }
    public float fl_MaxAlignment { get; set; }

    public Slider sl_AlignmentBar;

	// Use this for initialization
	void Start () {
        fl_MaxAlignment = 100f;
        fl_CurrentAlignment =Random.Range(0, fl_MaxAlignment);

        sl_AlignmentBar.value = SetAlignment();
		
	}
	

    float SetAlignment()
    {
        return fl_CurrentAlignment / fl_MaxAlignment;
    }
}
