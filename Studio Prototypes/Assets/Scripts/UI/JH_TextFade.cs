using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JH_TextFade : MonoBehaviour
{
    public GameObject go_targetObject;
    public float fl_fadeMultiplier;
    private Color c_objectFade;


    // Start is called before the first frame update
    void Start()
    {
        c_objectFade = GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        FadeObject();
    }

    void FadeObject()
    {
        float fl_distance = Vector3.Distance(transform.position, go_targetObject.transform.position);
        float fl_fade = Mathf.Clamp((fl_distance * fl_fadeMultiplier) / 100, 0, 1);
        c_objectFade.a =  1 - fl_fade;
        GetComponent<MeshRenderer>().material.color = c_objectFade;
    }
}
