using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Row : MonoBehaviour, IDropHandler
{
    private int maxSize = 3;
    public List<Dice> rows = new List<Dice>(3);

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        Dice dice = dropped.GetComponent<Dice>();
        dice.parentAfterDrag = transform;
    }

    public void AddDiceToList(Dice dice)
    {
            Debug.Log("CO");
            if (rows.Count < maxSize)
            {
                rows.Add(dice);
            }
            else
            {
                Debug.Log("List Full");
            }
        
    }

    private void Update()
    {
        GetTotalPointValue();
    }

    public int GetTotalPointValue()
    {
        int total = 0;
        if(rows != null)
        {
            foreach (Dice dice in rows)
            {
                total += dice.point;
                CheckDouble();
                Debug.Log(total);
            }
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

   
}
