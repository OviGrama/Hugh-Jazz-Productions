using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OG_Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public Transform originalParent = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!GameObject.Find("Calendar Panel").GetComponent<JH_Check_Timetable>().bl_isSaved)
        {

            Debug.Log("OnBeginDrag");

            originalParent = transform.parent;
            transform.SetParent(transform.parent.parent);

            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        if (!GameObject.Find("Calendar Panel").GetComponent<JH_Check_Timetable>().bl_isSaved)
        {
            transform.position = eventData.position;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (!GameObject.Find("Calendar Panel").GetComponent<JH_Check_Timetable>().bl_isSaved)
        {
            Debug.Log("OnEndDrag");

            transform.SetParent(originalParent);

            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
    }


}
