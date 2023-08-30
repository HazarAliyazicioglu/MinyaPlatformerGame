using TMPro;
using System;
using UnityEngine;

public class DeathAreaManager : MonoBehaviour
{
    public event Action sbfalling;
    
    public GameObject RestartMenu;
    public TextMeshProUGUI scoreBeforeFalling;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            sbfalling();
            RestartMenu.SetActive(true);
        }
    }
}
