using UnityEngine;

public class DiceSpawner : MonoBehaviour
{
    private bool readyToSpawn = false;
    public GameObject dice;

    private void Update()
    {
        if(readyToSpawn == true)
        {
            Instantiate(dice, transform.position, Quaternion.identity);
        }
    }

}
