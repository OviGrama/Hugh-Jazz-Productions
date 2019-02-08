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

        if (transform.position.x > fl_xPosMax) transform.position = new Vector3(fl_xPosMax, transform.position.y, transform.position.z);
        if (transform.position.x < -fl_xPosMax) transform.position = new Vector3(-fl_xPosMax, transform.position.y, transform.position.z);
        if (transform.position.z > fl_zPosMax) transform.position = new Vector3(transform.position.x, transform.position.y, fl_zPosMax);
        if (transform.position.z < -fl_zPosMax) transform.position = new Vector3(transform.position.x, transform.position.y, -fl_zPosMax);
        if (transform.position.y > fl_yPosMax) transform.position = new Vector3(transform.position.x, fl_yPosMax, transform.position.z);
        if (transform.position.y < fl_yPosMin) transform.position = new Vector3(transform.position.x, fl_yPosMin, transform.position.z);
    }
}
