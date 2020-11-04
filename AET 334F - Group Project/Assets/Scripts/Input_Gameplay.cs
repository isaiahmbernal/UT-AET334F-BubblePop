using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Gameplay : MonoBehaviour
{
    public Input_CheckArrow arrowUp;
    public Input_CheckArrow arrowDown;
    public Input_CheckArrow arrowLeft;
    public Input_CheckArrow arrowRight;

    public int score = 0;
    public float health = 5;

    public AudioSource pop01;
    public AudioSource pop02;

    public Image testLight;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (arrowUp.isTriggeredA == true)
            {
                testLight.color = Color.green;
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
                testLight.color = Color.red;
                health--;
                Debug.Log(health);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (arrowDown.isTriggeredA == true)
            {
                testLight.color = Color.green;
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
                testLight.color = Color.red;
                health--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (arrowLeft.isTriggeredA == true)
            {
                testLight.color = Color.green;
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
                testLight.color = Color.red;
                health--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (arrowRight.isTriggeredA == true)
            {
                testLight.color = Color.green;
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
                testLight.color = Color.red;
                health--;
            }
        }
    }
}
