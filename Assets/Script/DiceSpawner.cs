using System.Collections.Generic;
using UnityEngine;

public class DiceSpawner : MonoBehaviour
{
    public List<DiceScriptableObject> diceData = new List<DiceScriptableObject>();
    public GameObject dicePrefab;
    GameManager gameManager;

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

    public Dice RollAndSpawn()
    {
        GameObject dice = Instantiate(dicePrefab, transform.position, Quaternion.identity);

        SpriteRenderer spriteRenderer = dice.GetComponent<SpriteRenderer>();
        
        DiceScriptableObject randomDice = diceData[Random.Range(0, diceData.Count)];
        
        spriteRenderer.sprite = randomDice.Icon;
        
        Dice diceScript = dice.GetComponent<Dice>();
        
        diceScript.point = randomDice.Point;
        return dice.GetComponent<Dice>();
    }
}
