using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Medium : MonoBehaviour
{
    public void playGameMedium()
    {
        GameSettings.gameSettings.difficulty = 2;
        SceneManager.LoadScene("GAME");
    }
}
