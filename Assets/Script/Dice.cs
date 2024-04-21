using UnityEngine;
using UnityEngine.EventSystems;

public class Dice : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition; // di chuyển vị trí xúc sắc theo chuột
    }
}
