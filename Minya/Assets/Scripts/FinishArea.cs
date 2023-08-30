using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishArea : MonoBehaviour
{
    public GameObject FinishMenu;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && FindObjectOfType<ScoreManager>().score == 15)
        {
            FinishMenu.SetActive(true);
        }
        
    }
}
