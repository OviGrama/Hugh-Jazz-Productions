using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OG_UI0Rot : MonoBehaviour
{

    private Quaternion rotation;

    void Awake()
    {
        rotation = transform.rotation;
    }

    void LateUpdate()
    {
        transform.rotation = rotation;
    }
}
