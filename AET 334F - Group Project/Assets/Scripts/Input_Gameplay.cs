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
    public float health = 5;

    // Creating the sound effects when you hit a note
    public AudioSource pop01;
    public AudioSource pop02;

    void Start()
    {
        myName = this.gameObject.name;
    }
    
    // Checking player input
    void Update()
    {
        // Player 1 Input
        if (myName == "Player 1")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (arrowUp.isTriggeredA == true)
                {
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
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (arrowDown.isTriggeredA == true)
                {
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
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (arrowLeft.isTriggeredA == true)
                {
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
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (arrowRight.isTriggeredA == true)
                {
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
                    health--;
                }
            }
        }

        // Player 2 Input
        if ( myName == "Player 2" )
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (arrowUp.isTriggeredA == true)
                {
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
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (arrowDown.isTriggeredA == true)
                {
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
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                if (arrowLeft.isTriggeredA == true)
                {
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
                    health--;
                }
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                if (arrowRight.isTriggeredA == true)
                {
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
                    health--;
                }
            }
        }
    }
}
