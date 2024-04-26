using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "DiceScriptableObject", menuName = "ScriptableObjects/Dice")]
public class DiceScriptableObject : ScriptableObject
{
    [SerializeField]
    Image icon;
    public Image Icon { get => icon; private set => icon = value; }

    [SerializeField]
    string diceName;
    public string DiceName { get => diceName; private set => diceName = value; }

    [SerializeField]
    int point;
    public int Point { get => point; private set => point = value; }

}
