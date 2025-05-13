using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class OpponentController : MonoBehaviour
{
    //Difficulty 1 easy 2 medium 3 hard 4 impossible
    public int difficulty;
    public float movementspeed = 80f;
    private KeyCode randomkey; 
    private int randomNum;

    public float cooldownSet;
    private float moveCooldown;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        //Setting difficulty by time per number picked for opponent AI
        int difficulty = GameSettings.gameSettings.difficulty;
        if (difficulty == 1)
        {
            
            cooldownSet = 1f;
        }
        
        else if (difficulty == 2)
        {
            cooldownSet = .5f;
        }
        
        else if (difficulty == 3)
        {
            cooldownSet = .4f;
        }
        
        else if (difficulty == 4)
        {
            cooldownSet = .2f;
        }
        RandomNumber();
        moveCooldown = cooldownSet;
    }

    // Update is called once per frame
    void Update()
    {
        moveCooldown -= Time.deltaTime;
        //Loop for cooldown
        if (moveCooldown <= 0)
        {
            RandomNumber();
            
            //If random number is one move opponent
            if (randomNum == 1)
            {
                MoveOpponent();
            }

            //ResettingTimer
            moveCooldown = cooldownSet;
        }
        
    }
    
    void RandomNumber()
    {
        //Selecting the random number
        randomNum = Random.Range(1, 3);
    }
    
    void MoveOpponent()
    {
        Vector3 opponentmove = (Vector3.forward * movementspeed * Time.deltaTime);
        transform.position += opponentmove;
        moveCooldown = cooldownSet;
    }
}
