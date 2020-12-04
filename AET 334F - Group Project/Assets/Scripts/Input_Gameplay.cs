using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class Input_Gameplay : MonoBehaviour
{
    // This is to check who the player is, Player 1 or Player 2
    string myName;

    // Trigger checks for each of the arrows on the screen
    public Input_CheckArrow arrowUp;
    public Input_CheckArrow arrowDown;
    public Input_CheckArrow arrowLeft;
    public Input_CheckArrow arrowRight;

    // Variables to track the score and health
    public int score = 0;
    public float health = 5;
    private float healthGain = .25f;
    private float maxHealth;

    // These are the sound effects for when you hit a note properly
    [SerializeField] private AudioSource pop01;
    [SerializeField] private AudioSource pop02;

    void Start()
    {
        // Assigning the player name
        myName = this.gameObject.name;

        // Setting the max health to the health the player started with
        maxHealth = health;
    }
    
    // Checking player input
    void Update()
    {
        PlayerInput();
    }

    void PlayerInput()
    {
        // Player 1 Input
        if (myName == "Player 1")
        {
            // If Player 1 presses the Up Arrow key
            if (Input.GetKeyDown(KeyCode.UpArrow) && health > 0)
            {
                // If there is a note within their Up Arrow trigger on screen
                if (arrowUp.isTriggeredA == true)
                {
                    // Destroy the bubble and increase the player's score
                    Destroy(arrowUp.bubble);
                    score++;

                    // If the player isn't already at full health, the player gains health
                    if (health < maxHealth)
                        health += healthGain;

                    // Rolling for which sound to play and playing it
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                // If the player hit the key when there was no note in the trigger, they lose health
                else
                {
                    health--;
                }

            }
            // If Player 1 presses the Down Arrow key
            if (Input.GetKeyDown(KeyCode.DownArrow) && health > 0)
            {
                // If there is a note within their Down Arrow trigger on screen
                if (arrowDown.isTriggeredA == true)
                {
                    // Destroy the bubble and increase the player's score
                    Destroy(arrowDown.bubble);
                    score++;

                    // If the player isn't already at full health, the player gains health
                    if (health < maxHealth)
                        health += healthGain;

                    // Rolling for which sound to play and playing it
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                // If the player hit the key when there was no note in the trigger, they lose health
                else
                {
                    health--;
                }
            }
            // If Player 1 presses the Left Arrow key
            if (Input.GetKeyDown(KeyCode.LeftArrow) && health > 0)
            {
                // If there is a note within their Left Arrow trigger on screen
                if (arrowLeft.isTriggeredA == true)
                {
                    // Destroy the bubble and increase the player's score
                    Destroy(arrowLeft.bubble);
                    score++;

                    // If the player isn't already at full health, the player gains health
                    if (health < maxHealth)
                        health += healthGain;

                    // Rolling for which sound to play and playing it
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                // If the player hit the key when there was no note in the trigger, they lose health
                else
                {
                    health--;
                }
            }
            // If Player 1 presses the Right Arrow key
            if (Input.GetKeyDown(KeyCode.RightArrow) && health > 0)
            {
                // If there is a note within their Right Arrow trigger on screen
                if (arrowRight.isTriggeredA == true)
                {
                    // Destroy the bubble and increase the player's score
                    Destroy(arrowRight.bubble);
                    score++;

                    // If the player isn't already at full health, the player gains health
                    if (health < maxHealth)
                        health += healthGain;

                    // Rolling for which sound to play and playing it
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                // If the player hit the key when there was no note in the trigger, they lose health
                else
                {
                    health--;
                }
            }
        }

        // Player 2 Input
        if (myName == "Player 2")
        {
            // If Player 2 presses the W key
            if (Input.GetKeyDown(KeyCode.W) && health > 0)
            {
                // If there is a note within their Up Arrow trigger on screen
                if (arrowUp.isTriggeredA == true)
                {
                    // Destroy the bubble and increase the player's score
                    Destroy(arrowUp.bubble);
                    score++;

                    // If the player isn't already at full health, the player gains health
                    if (health < maxHealth)
                        health += healthGain;

                    // Rolling for which sound to play and playing it
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                // If the player hit the key when there was no note in the trigger, they lose health
                else
                {
                    health--;
                }
            }
            // If Player 2 presses the S key
            if (Input.GetKeyDown(KeyCode.S) && health > 0)
            {
                // If there is a note within their Down Arrow trigger on screen
                if (arrowDown.isTriggeredA == true)
                {
                    // Destroy the bubble and increase the player's score
                    Destroy(arrowDown.bubble);
                    score++;

                    // If the player isn't already at full health, the player gains health
                    if (health < maxHealth)
                        health += healthGain;

                    // Rolling for which sound to play and playing it
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                // If the player hit the key when there was no note in the trigger, they lose health
                else
                {
                    health--;
                }
            }
            // If Player 2 presses the A key
            if (Input.GetKeyDown(KeyCode.A) && health > 0)
            {
                // If there is a note within their Left Arrow trigger on screen
                if (arrowLeft.isTriggeredA == true)
                {
                    // Destroy the bubble and increase the player's score
                    Destroy(arrowLeft.bubble);
                    score++;

                    // If the player isn't already at full health, the player gains health
                    if (health < maxHealth)
                        health += healthGain;

                    // Rolling for which sound to play and playing it
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                // If the player hit the key when there was no note in the trigger, they lose health
                else
                {
                    health--;
                }
            }
            // If Player 2 presses the A key
            if (Input.GetKeyDown(KeyCode.D) && health > 0)
            {
                // If there is a note within their Right Arrow trigger on screen
                if (arrowRight.isTriggeredA == true)
                {
                    // Destroy the bubble and increase the player's score
                    Destroy(arrowRight.bubble);
                    score++;

                    // If the player isn't already at full health, the player gains health
                    if (health < maxHealth)
                        health += healthGain;
                    
                    // Rolling for which sound to play and playing it
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                // If the player hit the key when there was no note in the trigger, they lose health
                else
                {
                    health--;
                }
            }
        }
    }
}
