using System;
using Unity.VisualScripting;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public AudioClip coinClip;
    public event Action AddingScore;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coins")
        {

            AudioSource.PlayClipAtPoint(coinClip,transform.position,0.4f);
            Destroy(other.gameObject);
            if (AddingScore != null)
            {
                AddingScore();
            }
        }
    }
}
