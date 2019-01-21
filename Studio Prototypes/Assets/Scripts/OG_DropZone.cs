using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OG_DropZone : MonoBehaviour, IDropHandler {

    public GameObject ClassChangePanel;
    public Animator anim_text;

    private void Start()
    {
        ClassChangePanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (anim_text.GetBool("isActive")) ClassChangePanel.SetActive(true);
        else ClassChangePanel.SetActive(false);
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name +  " dropped on " + gameObject.name);

        OG_Draggable draggable = eventData.pointerDrag.GetComponent<OG_Draggable>();
        {
            if(draggable != null)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    if (transform.GetChild(i).GetComponent<OG_Draggable>() != null)
                    {
                        transform.GetChild(i).transform.parent = GameObject.Find("Calendar Classes Panel").transform;
                        anim_text.SetBool("isActive", true);

                    }
                }
                draggable.originalParent = this.transform;
            }
        }
    }

}
