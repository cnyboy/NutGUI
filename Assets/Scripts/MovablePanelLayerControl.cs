using UnityEngine;
using UnityEngine.EventSystems;

public class MovablePanelLayerControl : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.SetAsLastSibling();
    }
}
