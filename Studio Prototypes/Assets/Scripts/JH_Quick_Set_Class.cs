using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_Quick_Set_Class : MonoBehaviour
{
    private Dropdown dd_classes;
    public JH_Set_Class.GroupNumber groupNumber;

    // Start is called before the first frame update
    void Start()
    {
        dd_classes = GameObject.Find("ClassesDropdown").GetComponent<Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dd_classes.value == 0) groupNumber = JH_Set_Class.GroupNumber.One;
        if (dd_classes.value == 1) groupNumber = JH_Set_Class.GroupNumber.Two;
        if (dd_classes.value == 2) groupNumber = JH_Set_Class.GroupNumber.Three;
    }
}
