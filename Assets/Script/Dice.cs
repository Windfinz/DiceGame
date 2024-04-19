using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public DiceScriptableObject diceData;
    public Image Icon;

    private void Start()
    {
        Icon = diceData.Icon;
    }

}
