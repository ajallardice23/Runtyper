using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinCountUI;
    void Update()
    {
        coinCountUI.text = ("Coins: " + PlayerController.coinCount.ToString());
    }
}
