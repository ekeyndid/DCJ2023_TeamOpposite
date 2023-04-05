using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToolbarSlot : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0)
        {
            ToolbarItem toolbarItem = eventData.pointerDrag.GetComponent<ToolbarItem>();
            toolbarItem.parentAfterDrag = transform;
        }

    }
}
