using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Control_Time : MonoBehaviour {

    public enum TimeType
    {
        Pause,
        Normal,
        Double
    }

    public TimeType timeType;
    private Text tx_button;

	// Use this for initialization
	void Start () {
        tx_button = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        ShowSelection();
	}

    void ShowSelection()
    {
        if (timeType == TimeType.Pause && Time.timeScale == 0) tx_button.fontStyle = FontStyle.Bold;
        else if (timeType == TimeType.Normal && Time.timeScale == 1) tx_button.fontStyle = FontStyle.Bold;
        else if (timeType == TimeType.Double && Time.timeScale == 2) tx_button.fontStyle = FontStyle.Bold;
        else tx_button.fontStyle = FontStyle.Normal;
    }
}
