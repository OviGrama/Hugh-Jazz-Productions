using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JH_OpenButton : MonoBehaviour
{

    [HideInInspector] public bool bl_interactable;
    public float fl_animationSpeed;
    private bool bl_open;
    private Animator anim_button;
    private Button button_Button;

    // Start is called before the first frame update
    void Start()
    {
        anim_button = GetComponent<Animator>();
        anim_button.SetFloat("speed", fl_animationSpeed);
        button_Button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bl_open)
        {
            anim_button.SetBool("openTab", true);
            bl_interactable = true;
            button_Button.transition = Selectable.Transition.None;
        }
        else
        {
            anim_button.SetBool("openTab", false);
            bl_interactable = false;
            button_Button.transition = Selectable.Transition.ColorTint;
        }
    }

    public void ClickButton()
    {
        if (bl_open) bl_open = false;
        else bl_open = true;
    }
}
