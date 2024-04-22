using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    private int maxSize = 3;
    public List<Dice> rows = new List<Dice>(3);

    public void AddDiceToList(Dice dice)
    {
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
                    rows[i].point = (rows[i].point + rows[i].point) * 2; // need fix
                    //rows[j].point *= 2;
                }
            }
        }
    }

}
