using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay_Health : MonoBehaviour
{
    public Input_Gameplay currentHealth;
    private Image healthBar;
    private float maxHealth;

    void Start()
    {
        maxHealth = currentHealth.health;
        healthBar = GetComponent<Image>();
    }
    void Update()
    {
        healthBar.fillAmount = currentHealth.health/maxHealth;
    }
}
