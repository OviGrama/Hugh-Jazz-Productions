using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_Camera_Move : MonoBehaviour {

    public float fl_cameraSpeed;
    public float fl_xPosMax;
    public float fl_yPosMin;
    public float fl_yPosMax;
    public float fl_zPosMax;
    public bool bl_canMoveCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (bl_canMoveCamera) MoveCamera();
	}

    void MoveCamera()
    {
        Vector3 moveCamera = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), Input.GetAxis("Mouse ScrollWheel"));
        transform.Translate(moveCamera);

        if (transform.localPosition.x > fl_xPosMax) transform.localPosition = new Vector3(fl_xPosMax, transform.localPosition.y, transform.localPosition.z);
        if (transform.localPosition.x < -fl_xPosMax) transform.localPosition = new Vector3(-fl_xPosMax, transform.localPosition.y, transform.localPosition.z);
        if (transform.localPosition.z > fl_zPosMax) transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, fl_zPosMax);
        if (transform.localPosition.z < -fl_zPosMax) transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, -fl_zPosMax);
        if (transform.localPosition.y > fl_yPosMax) transform.localPosition = new Vector3(transform.localPosition.x, fl_yPosMax, transform.localPosition.z);
        if (transform.localPosition.y < fl_yPosMin) transform.localPosition = new Vector3(transform.localPosition.x, fl_yPosMin, transform.localPosition.z);
    }
}
