using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OG_DropZone : MonoBehaviour, IDropHandler {

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name +  " dropped on " + gameObject.name);

        OG_Draggable draggable = eventData.pointerDrag.GetComponent<OG_Draggable>();
        {
            if(draggable != null)
            {
                draggable.originalParent = this.transform;
            }
        }
    }

}
