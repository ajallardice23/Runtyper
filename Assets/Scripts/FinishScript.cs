using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class FinishScript : MonoBehaviour
{
    
    public int finishCount;
    public TextMeshProUGUI endPosition;
    public static int winCount;
    public static int winStreak;
    public Button Retry;
    public Button Menu;
    public TextMeshProUGUI letterUI;
    public TextMeshProUGUI moveUI;
    public TextMeshProUGUI winStreakUI;
    public TextMeshProUGUI winCountUI;
    
    public Image imageui;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        finishCount = 1;
        endPosition.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);
        Menu.gameObject.SetActive(false);
        winStreakUI.gameObject.SetActive(true);
        winCountUI.gameObject.SetActive(true);
        
        winStreakUI.text = ("Win Streak:" + winStreak.ToString());
        winCountUI.text = ("Win Count:" + winCount.ToString());

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Opponent")
        {
            //Add one to pos for each opponent passed finish
            finishCount += 1;
            Destroy(other); 
        }

        if (other.gameObject.tag == "Player")
        {
            //Deactivate all of the UI
            letterUI.gameObject.SetActive(false);
            moveUI.gameObject.SetActive(false);
            imageui.gameObject.SetActive(false);
            //Displaying end position to player
            endPosition.gameObject.SetActive(true);
            endPosition.text = ("You placed #" + finishCount.ToString());
            Debug.Log("You placed #" + finishCount);
            //Buttons to retry or go to menu
            Retry.gameObject.SetActive(true);
            Menu.gameObject.SetActive(true);

            if (finishCount == 1)
            {
                PlayerController.coinCount += 1;
                winCount += 1;
                winStreak += 1;
            }

            else
            {
                winStreak = 0;
            }
            
            winStreakUI.text = ("Win Streak:" + winStreak.ToString());
            winCountUI.text = ("Win Count:" + winCount.ToString());
            
            Debug.Log(winCount);
            Debug.Log(winStreak);
            Debug.Log(PlayerController.coinCount);
        }
    }
}
