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
    [SerializeField] private Input_CheckArrow arrowUp;
    [SerializeField] private Input_CheckArrow arrowDown;
    [SerializeField] private Input_CheckArrow arrowLeft;
    [SerializeField] private Input_CheckArrow arrowRight;

    // Variables to track the score and health
    public int score = 0;
    public float health = 1;
    private float healthGain = .25f;
    [SerializeField] private float maxHealth = 6;

    // Variables to keep track of the current streaks
    public static int currentStreak = 0;
    public static int currentStreakP1 = 0;
    public static int currentStreakP2 = 0;


    // These are the sound effects for when you hit a note properly
    [SerializeField] private AudioSource pop01;
    [SerializeField] private AudioSource pop02;

    [SerializeField] private Config_Info configInfo;

    // variable used to reference stats manager script
    private StatsManager stats;

    void Start()
    {
        // Assigning the player name
        myName = this.gameObject.name;
    }

    void OnEnable()
    {
        health = maxHealth;
        score = 0;
    }
    
    // Checking player input
    void Update()
    {
        PlayerInput();

        // Checking if the longest recorded player streaks should be updated
        if (currentStreak > StatsManager.SP_longestStreak)
        {
            StatsManager.SP_longestStreak = currentStreak;                
        }
        if (currentStreakP1 > StatsManager.MP_longestStreakP1)
        {
            StatsManager.MP_longestStreakP1 = currentStreakP1;                
        }
        if (currentStreakP2 > StatsManager.MP_longestStreakP2)
        {
            StatsManager.MP_longestStreakP2 = currentStreakP2;
        }                                                                
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
                    if ( configInfo.isMulti == false )
                    {
                        stats.changeTotalScore(1);
                        stats.changePopTotal(1);
                        currentStreak++;
                    }
                    if ( configInfo.isMulti == true )
                    {
                        stats.changeTotalScoreMP1(1);
                        stats.changePopTotalMP1(1);
                        currentStreakP1++;
                    }
                    

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
                    if ( configInfo.isMulti == false )
                    {
                        stats.changeTotalHPLost(1.0f);
                        currentStreak = 0;
                    }
                    if ( configInfo.isMulti == true )
                    {
                        stats.changeTotalHPLostMP1(1.0f);
                        currentStreakP1 = 0;
                    }
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
                    if ( configInfo.isMulti == false )
                    {
                        stats.changeTotalScore(1);
                        stats.changePopTotal(1);
                        currentStreak++;
                    }
                    if ( configInfo.isMulti == true )
                    {
                        stats.changeTotalScoreMP1(1);
                        stats.changePopTotalMP1(1);
                        currentStreakP1++;
                    }

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
                    if ( configInfo.isMulti == false )
                    {
                        stats.changeTotalHPLost(1.0f);
                        currentStreak = 0;
                    }
                    if ( configInfo.isMulti == true )
                    {
                        stats.changeTotalHPLostMP1(1.0f);
                        currentStreakP1 = 0;
                    }
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
                    if ( configInfo.isMulti == false )
                    {
                        stats.changeTotalScore(1);
                        stats.changePopTotal(1);
                        currentStreak++;
                    }
                    if ( configInfo.isMulti == true )
                    {
                        stats.changeTotalScoreMP1(1);
                        stats.changePopTotalMP1(1);
                        currentStreakP1++;
                    }

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
                    if ( configInfo.isMulti == false )
                    {
                        stats.changeTotalHPLost(1.0f);
                        currentStreak = 0;
                    }
                    if ( configInfo.isMulti == true )
                    {
                        stats.changeTotalHPLostMP1(1.0f);
                        currentStreakP1 = 0;
                    }
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
                    if ( configInfo.isMulti == false )
                    {
                        stats.changeTotalScore(1);
                        stats.changePopTotal(1);
                        currentStreak++;
                    }
                    if ( configInfo.isMulti == true )
                    {
                        stats.changeTotalScoreMP1(1);
                        stats.changePopTotalMP1(1);
                        currentStreakP1++;
                    }

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
                    if ( configInfo.isMulti == false )
                    {
                        stats.changeTotalHPLost(1.0f);
                        currentStreak = 0;
                    }
                    if ( configInfo.isMulti == true )
                    {
                        stats.changeTotalHPLostMP1(1.0f);
                        currentStreakP1 = 0;
                    }
                    
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
                    stats.changeTotalScoreMP2(1);
                    stats.changePopTotalMP2(1);
                    currentStreakP2++;


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
                    stats.changeTotalHPLostMP2(1.0f);
                    currentStreakP2 = 0;
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
                    stats.changeTotalScoreMP2(1);
                    stats.changePopTotalMP2(1);
                    currentStreakP2++;

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
                    stats.changeTotalHPLostMP2(1.0f);
                    currentStreakP2 = 0;
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
                    stats.changeTotalScoreMP2(1);
                    stats.changePopTotalMP2(1);
                    currentStreakP2++;

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
                    stats.changeTotalHPLostMP2(1.0f);
                    currentStreakP2 = 0;
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
                    stats.changeTotalScoreMP2(1);
                    stats.changePopTotalMP2(1);
                    currentStreakP2++;

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
                    stats.changeTotalHPLostMP2(1.0f);
                    currentStreakP2 = 0;
                }
            }
        }
    }

    public void ConnectToManager( StatsManager manager )
    {
        stats = manager;
    }
}
