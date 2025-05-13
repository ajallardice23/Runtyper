using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Impossible : MonoBehaviour
{
    public void playGameImpossible()
    {
        GameSettings.gameSettings.difficulty = 4;
        SceneManager.LoadScene("GAME");
    }
}
