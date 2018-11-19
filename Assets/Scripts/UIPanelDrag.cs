using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIPanelDrag : MonoBehaviour, IBeginDragHandler,IDragHandler
{
    private RectTransform rectTransform;
    private Vector3 mousePosition;
    private Vector3 offset;

    private void Start()
    {
        rectTransform = gameObject.GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToWorldPointInRectangle(rectTransform, eventData.position,
                                                            eventData.enterEventCamera, out mousePosition);
        offset = rectTransform.position- mousePosition;
    }
    public void OnDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToWorldPointInRectangle(rectTransform, eventData.position,
                                                            eventData.enterEventCamera, out mousePosition);
        rectTransform.position = offset + mousePosition;
        
    }
}
