using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class Gameplay_Health : MonoBehaviour
{
    // Gameplay variable so we can check the player's health
    [SerializeField] private Input_Gameplay currentHealth;

    // The image for the healthbar we're going to update
    private Image healthBar;

    // Variable so we can store the max health we started with
    private float maxHealth;

    void Start()
    {
        // The maximum health the player started with
        maxHealth = currentHealth.health;

        // Assigning our healthbar variable to the game object's image
        healthBar = GetComponent<Image>();
    }
    void Update()
    {
        // Every frame the fill amount of the health bar is set to the player's current % of remaining health
        healthBar.fillAmount = currentHealth.health/maxHealth;
    }
}
