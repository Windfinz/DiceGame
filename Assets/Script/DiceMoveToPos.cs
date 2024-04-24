using UnityEngine;

public class DiceMoveToPos : MonoBehaviour
{
    public Transform moveToPos;
    public bool isFull;

    private void Start()
    {
        moveToPos = this.transform;
    }

}
