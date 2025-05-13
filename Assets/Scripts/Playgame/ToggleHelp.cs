using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHelp : MonoBehaviour
{
    public GameObject help;

    public void Openhelp()
    {
        help.SetActive(true);
    }

    public void Closehelp()
    {
        help.SetActive(false);
    }
}
