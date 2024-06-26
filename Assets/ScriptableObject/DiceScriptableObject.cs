using UnityEngine;

[CreateAssetMenu(fileName = "DiceScriptableObject", menuName = "ScriptableObjects/Dice")]
public class DiceScriptableObject : ScriptableObject
{
    [SerializeField]
    Sprite icon;
    public Sprite Icon { get => icon; private set => icon = value; }

    [SerializeField]
    string diceName;
    public string DiceName { get => diceName; private set => diceName = value; }

    [SerializeField]
    int point;
    public int Point { get => point; private set => point = value; }

}
