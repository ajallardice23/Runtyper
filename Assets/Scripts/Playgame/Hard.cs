using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hard : MonoBehaviour
{
    public void playGameHard()
    {
        GameSettings.gameSettings.difficulty = 3;
        SceneManager.LoadScene("GAME");
    }
}
