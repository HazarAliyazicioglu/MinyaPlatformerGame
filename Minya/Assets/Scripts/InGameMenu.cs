using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{
    public GameObject StopMenu;
    
    public void StopButton()
    {
        Time.timeScale = 0;
        StopMenu.SetActive(true);
    }
}