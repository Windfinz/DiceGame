using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dice : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public int point;
    public Transform parentAfterDrag;
    public Image diceImage;

    public DiceSpawner spawner;
    private void Start()
    {
        diceImage = GetComponent<Image>();
        spawner = FindObjectOfType<DiceSpawner>();      
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        diceImage.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition; // di chuyển vị trí xúc sắc theo chuột
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        diceImage.raycastTarget = true;
    }



    //private void OnMouseDown()
    //{
    //    spawner.SelectDice(this.gameObject);
    //}

    //void OnMouseDown()
    //{
    //    distance = Vector3.Distance(transform.position, Camera.main.transform.position);
    //    dragging = true;
    //}

    //void OnMouseUp()
    //{
    //    dragging = false;
    //}

    //void Update()
    //{
    //    if (dragging)
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        Vector3 rayPoint = ray.GetPoint(distance);
    //        transform.position = rayPoint;
    //    }
    //}



}
