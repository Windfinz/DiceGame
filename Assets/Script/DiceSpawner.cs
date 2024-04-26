using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceSpawner : MonoBehaviour
{
    public List<DiceScriptableObject> diceData = new List<DiceScriptableObject>();
    public GameObject dicePrefab;
    GameManager gameManager;
    public GameObject selectedDice;

    public Transform parentPos;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void Update()
    {
        if(gameManager.readyToSpawn == true)
        {
        }
            //RollAndSpawn();
    }

    public void SelectDice(GameObject dice)
    {
        selectedDice = dice;
    }

    public void RollAndSpawn()
    {
        GameObject dice = Instantiate(dicePrefab,transform.position, Quaternion.identity);
        dice.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        dice.transform.position = parentPos.transform.position;
        Image image = dice.GetComponent<Image>();
        DiceScriptableObject randomDice = diceData[Random.Range(0, diceData.Count)];
        
        image = randomDice.Icon;
        
        Dice diceScript = dice.GetComponent<Dice>();
        
        diceScript.point = randomDice.Point;
    }
}
