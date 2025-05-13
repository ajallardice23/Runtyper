using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Header("Animation")]
    public Animator animator;
    public int step;
    
    [Header("Movement")]
    public float movementspeed = 80f;
    
    [Header("Camera")]
    public Transform playerCam;
    
    [Header("Keys")]
    private KeyCode randomkey;
    public TextMeshProUGUI letterUI;

    [Header("Coin System")] 
    public static int coinCount = 0;
    public TextMeshProUGUI coinCountUI;

    [Header("Accessories")] 
    public GameObject Tophat;
    public GameObject Halo;
    public GameObject Backpack;
    
    // Start is called before the first frame update
    void Start()
    {
        ChooseKey();
        step = 0;
        
        if (ShopSettings.tophatState.tophat == true)
        {
            Tophat.SetActive(true);
        }
        
        if (ShopSettings.backpackState.backpack == true)
        {
            Backpack.SetActive(true);
        }
        
        if (ShopSettings.haloState.halo == true)
        {
            Halo.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //If key is key selected move player and camera
        if (Input.GetKeyDown(randomkey))
        {
            animator.SetBool("isRunning", true);
            Vector3 playermove = (Vector3.forward * movementspeed * Time.deltaTime);
            transform.position += playermove;
            playerCam.position += playermove;
            ChooseKey();
        }
        
        letterUI.text = randomkey.ToString();
        coinCountUI.text = coinCount.ToString();
    }

    //Choosing a key
    void ChooseKey()
    {
        KeyCode[] keys = { KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D, KeyCode.E, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.I, KeyCode.J, KeyCode.K, KeyCode.L, KeyCode.M, KeyCode.N,
            KeyCode.O, KeyCode.P, KeyCode.Q, KeyCode.R, KeyCode.S, KeyCode.T, KeyCode.U, KeyCode.V, KeyCode.W, KeyCode.X, KeyCode.Y, KeyCode.Z};
        
        randomkey = keys[Random.Range(0, keys.Length)];
        Debug.Log(randomkey);
    }
    
    //Add coins to player
    public void AddCoins(int coinAmount)
    {
        coinCount += coinAmount;
    }
}
