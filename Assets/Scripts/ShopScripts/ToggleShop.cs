using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleShop : MonoBehaviour
{
    public GameObject shop;

    public void Openshop()
    {
        shop.SetActive(true);
    }

    public void Closeshop()
    {
        shop.SetActive(false);
    }
}
