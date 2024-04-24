using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Row : MonoBehaviour
{
    private int maxSize = 3;
    public List<Dice> rows = new List<Dice>(3);
    public List<Transform> targetPositions = new List<Transform>(3);

    private bool isInitialized = false;

    /*   public void AddDiceToList(Dice dice, Transform targetPosition)
       {
           if (rows.Count < maxSize)
           {
               rows.Add(dice);
               targetPositions.Add(targetPosition);
               ChangeDicePositions(targetPositions);
           }
           else
           {
               Debug.Log("List Full");
           }
       }
    */
    private void Update()
    {
        GetTotalPointValue();
        ChangeDicePositions(targetPositions);
    }

    public int GetTotalPointValue()
    {
        int total = 0;
        foreach (Dice dice in rows)
        {
            total += dice.point;
            CheckDouble();
            Debug.Log(total);
        }
        return total;
    }

    private void CheckDouble()
    {
        for (int i = 0; i < rows.Count; i++)
        {
            for (int j = i + 1; j < rows.Count; j++)
            {
                if (rows[i].point == rows[j].point)
                {
                    rows[i].point = ((rows[i].point + rows[i].point) * 2) - rows[i].point; 
                }
            }
        }
    }

    public void AddDice(Dice dice)
    {
        rows.Add(dice);
        if (rows.Count == 1) // Nếu chỉ có một dice trong hàng, bắt đầu thiết lập vị trí cho chúng
        {
            isInitialized = true;
            ChangeDicePositions(targetPositions);
        }
    }

    public void ChangeDicePositions(List<Transform> newPositions)
    {
        if (newPositions.Count != rows.Count)
        {
            Debug.LogError("Number of new positions must match the number of dice in the row.");
            return;
        }

        for (int i = 0; i < rows.Count; i++)
        {
            rows[i].transform.position = newPositions[i].position;
        }
    }
}
