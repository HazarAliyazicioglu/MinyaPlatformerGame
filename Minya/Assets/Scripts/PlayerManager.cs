using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Slider slider;
    public GameObject restartMenu;
    public event Action LastScore;
        
    public float health;
    public bool amIDead = false;

    private void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void GetDamage(float damage)
    {
        if ((health - damage) > 0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
            Destroy(GameObject.FindWithTag("Player"));
        }

        slider.value = health;
        AmIDead();
    }

    void AmIDead()
    {
        if (health <= 0)
        {
            amIDead = true;
            if (amIDead == true)
            {
                restartMenu.SetActive(true);
                if (LastScore != null)
                {
                    LastScore();
                }
            }
        }
    }
}
