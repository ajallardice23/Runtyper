using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Easy : MonoBehaviour
{
    public void playGameEasy()
    {
        GameSettings.gameSettings.difficulty = 1;
        SceneManager.LoadScene("GAME");
    }

    
}
