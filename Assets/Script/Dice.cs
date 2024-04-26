using UnityEngine;
using UnityEngine.EventSystems;

public class Dice : MonoBehaviour, IDragHandler
{
    public int point;
    //private bool dragging = false;
    //private float distance;
    public DiceSpawner spawner;
    private void Start()
    {
        spawner = FindObjectOfType<DiceSpawner>();      
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition; // di chuyển vị trí xúc sắc theo chuột
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
