using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PurchaseBackpack : MonoBehaviour
{
    public TextMeshProUGUI notenoughcoins;
    public TextMeshProUGUI purchasedtext;
    public void purchaseBackpack()
    {
        if (PlayerController.coinCount >= 10){
            ShopSettings.backpackState.backpack = true;
            PlayerController.coinCount -= 10;
            StartCoroutine(Purchased());
        }

        else
        {
            StartCoroutine(NotEnoughCoins());
        }
    }

    private IEnumerator NotEnoughCoins()
    {
        notenoughcoins.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);  
        notenoughcoins.gameObject.SetActive(false);
    }
    
    private IEnumerator Purchased()
    {
        purchasedtext.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);  
        purchasedtext.gameObject.SetActive(false);
    }
}
