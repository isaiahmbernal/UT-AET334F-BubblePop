using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Gameplay : MonoBehaviour
{
    string myName;

    // Trigger checks for each of the arrows on the screen
    public Input_CheckArrow arrowUp;
    public Input_CheckArrow arrowDown;
    public Input_CheckArrow arrowLeft;
    public Input_CheckArrow arrowRight;

    // Creating the score and health values
    public int score = 0;
    public int health = 5;

    // Creating the sound effects when you hit a note
    public AudioSource pop01;
    public AudioSource pop02;

    // This is just for testing, checks to see if you hit the note correctly
    // public Image testLight;

    private StatsManager stats;

    void Start()
    {
        myName = this.gameObject.name;
    }
    
    // Player input checking
    void Update()
    {
        // If this is the Player 1 input
        if (myName == "Player 1")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                testLight.color = Color.green;
                Destroy(arrowUp.bubble);
                score++;
                stats.changeTotalScore(1);
                stats.changePopTotal(1);
                int pickSound = Random.Range(0,2);
                if (pickSound == 0)
                    pop01.Play();
                else if (pickSound == 1)
                    pop02.Play();
                if (arrowUp.isTriggeredA == true)
                {
                    // testLight.color = Color.green;
                    Destroy(arrowUp.bubble);
                    score++;
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                else
                {
                    // testLight.color = Color.red;
                    health--;
                    // Debug.Log(health);
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                testLight.color = Color.red;
                health--;
                stats.changeTotalHPLost(1);
                Debug.Log(health);
                if (arrowDown.isTriggeredA == true)
                {
                    // testLight.color = Color.green;
                    Destroy(arrowDown.bubble);
                    score++;
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                else
                {
                    // testLight.color = Color.red;
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                testLight.color = Color.green;
                Destroy(arrowDown.bubble);
                score++;
                stats.changeTotalScore(1);
                stats.changePopTotal(1);
                int pickSound = Random.Range(0,2);
                if (pickSound == 0)
                    pop01.Play();
                else if (pickSound == 1)
                    pop02.Play();
                if (arrowLeft.isTriggeredA == true)
                {
                    // testLight.color = Color.green;
                    Destroy(arrowLeft.bubble);
                    score++;
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                else
                {
                    // testLight.color = Color.red;
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                testLight.color = Color.red;
                health--;
                stats.changeTotalHPLost(1);
                if (arrowRight.isTriggeredA == true)
                {
                    // testLight.color = Color.green;
                    Destroy(arrowRight.bubble);
                    score++;
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                else
                {
                    // testLight.color = Color.red;
                    health--;
                }
            }
        }

        // Case if this is the Player 2 input
        if ( myName == "Player 2" )
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                testLight.color = Color.green;
                Destroy(arrowLeft.bubble);
                score++;
                stats.changeTotalScore(1);
                stats.changePopTotal(1);
                int pickSound = Random.Range(0,2);
                if (pickSound == 0)
                    pop01.Play();
                else if (pickSound == 1)
                    pop02.Play();
                if (arrowUp.isTriggeredA == true)
                {
                    // testLight.color = Color.green;
                    Destroy(arrowUp.bubble);
                    score++;
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                else
                {
                    // testLight.color = Color.red;
                    health--;
                    // Debug.Log(health);
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                testLight.color = Color.red;
                health--;
                stats.changeTotalHPLost(1);
                if (arrowDown.isTriggeredA == true)
                {
                    // testLight.color = Color.green;
                    Destroy(arrowDown.bubble);
                    score++;
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                else
                {
                    // testLight.color = Color.red;
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                testLight.color = Color.green;
                Destroy(arrowRight.bubble);
                score++;
                stats.changeTotalScore(1);
                stats.changePopTotal(1);
                int pickSound = Random.Range(0,2);
                if (pickSound == 0)
                    pop01.Play();
                else if (pickSound == 1)
                    pop02.Play();
                if (arrowLeft.isTriggeredA == true)
                {
                    // testLight.color = Color.green;
                    Destroy(arrowLeft.bubble);
                    score++;
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                else
                {
                    // testLight.color = Color.red;
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                testLight.color = Color.red;
                health--;
                stats.changeTotalHPLost(1);
            }
        }
    }

    public void ConnectToManager( StatsManager manager )
    {
        stats = manager;
    }
}
                if (arrowRight.isTriggeredA == true)
                {
                    // testLight.color = Color.green;
                    Destroy(arrowRight.bubble);
                    score++;
                    int pickSound = Random.Range(0,2);
                    if (pickSound == 0)
                        pop01.Play();
                    else if (pickSound == 1)
                        pop02.Play();
                }
                else
                {
                    // testLight.color = Color.red;
                    health--;
                }
            }
        }
    }
}
