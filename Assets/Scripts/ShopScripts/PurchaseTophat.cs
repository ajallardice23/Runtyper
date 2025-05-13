using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PurchaseTophat : MonoBehaviour
{
    public TextMeshProUGUI notenoughcoins;
    public TextMeshProUGUI purchasedtext;
    
    public void purchaseTophat()
    {
        if (PlayerController.coinCount >= 1){
            ShopSettings.tophatState.tophat = true;
            PlayerController.coinCount -= 1;
            StartCoroutine(Purchased());
            Debug.Log("Tophat active");
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
