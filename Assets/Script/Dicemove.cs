using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class Dicemove : MonoBehaviour
{
    public List<DiceMoveToPos> targetPos = new List<DiceMoveToPos>(3);

    public void CheckPos()
    {
        for (int i = 0; i < targetPos.Count; i++)
        {
            if (targetPos[i].isFull == false ) 
            {
                transform.DOMove(targetPos[i].moveToPos.position, 2f);
            }
        }
    }

}
