using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiceManager : MonoBehaviour, IDragHandler
{
    public static int diceValue; // Lưu giá trị số điểm ngẫu nhiên được chọn

    // List chứa tất cả các Prefabs của các mặt xúc sắc
    public List<GameObject> diceFaces;

    private GameObject draggedDice; // Lưu trữ viên xúc sắc đang được kéo


    // Hàm này sẽ được gọi khi bắt đầu game
    void Start()
    {
        RollDice();
    }

    private void RollDice()
    {
        // Random một số từ 0 đến 5 (đây là index của Prefab sẽ hiện thị)
        int randomIndex = Random.Range(0, 6);
        diceValue = randomIndex + 1; // Lưu giá trị số điểm ngẫu nhiên được chọn

        // Duyệt qua tất cả các Prefab trong list
        foreach (GameObject face in diceFaces)
        {
            if (face.CompareTag("Face" + diceValue))
            {
                face.SetActive(true);
            }
            else
            {
                face.SetActive(false);
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition; // di chuyển vị trí xúc sắc theo chuột
    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    RaycastHit hit;
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Dice"))
        //    {
        //        isDragging = true;
        //        draggedDice = hit.collider.gameObject;
        //    }
        //}

        //if (Input.GetMouseButtonUp(0))
        //{
        //    if (isDragging)
        //    {
        //        // Đặt viên xúc sắc vào vị trí con trỏ chuột
        //        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //        draggedDice.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
        //        isDragging = false;
        //        draggedDice = null;
        //    }
        //}

        //// Kiểm tra khi đang kéo xúc sắc
        //if (isDragging && draggedDice != null)
        //{
        //    // Di chuyển viên xúc sắc theo vị trí chuột
        //    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    draggedDice.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
        //}
    }
}
