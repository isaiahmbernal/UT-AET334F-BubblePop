// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Input_GameplayMulti : MonoBehaviour
// {
//     // Trigger checks for each of the arrows on the screen
//     public Input_CheckArrow arrowUp1;
//     public Input_CheckArrow arrowDown1;
//     public Input_CheckArrow arrowLeft1;
//     public Input_CheckArrow arrowRight1;

//     public Input_CheckArrow arrowUp2;
//     public Input_CheckArrow arrowDown2;
//     public Input_CheckArrow arrowLeft2;
//     public Input_CheckArrow arrowRight2;

//     // Creating the score and health values
//     public int score1 = 0;
//     public float health1 = 5;

//     public int score2 = 0;
//     public float health2 = 5;

//     // Creating the sound effects when you hit a note
//     public AudioSource pop01;
//     public AudioSource pop02;

//     // This is just for testing, checks to see if you hit the note correctly
//     // public Image testLight;

//     // Player Input checking
//     void Update()
//     {
        
//     }
//     void Player1Input()
//     {
//         if (Input.GetKeyDown(KeyCode.W))
//         {
//             if (arrowUp1.isTriggeredA == true)
//             {
//                 // testLight.color = Color.green;
//                 Destroy(arrowUp1.bubble);
//                 score1++;
//                 int pickSound = Random.Range(0,2);
//                 if (pickSound == 0)
//                     pop01.Play();
//                 else if (pickSound == 1)
//                     pop02.Play();
//             }
//             else
//             {
//                 // testLight.color = Color.red;
//                 health1--;
//                 // Debug.Log(health1);
//             }
//         }
//         else if (Input.GetKeyDown(KeyCode.S))
//         {
//             if (arrowDown1.isTriggeredA == true)
//             {
//                 // testLight.color = Color.green;
//                 Destroy(arrowDown1.bubble);
//                 score1++;
//                 int pickSound = Random.Range(0,2);
//                 if (pickSound == 0)
//                     pop01.Play();
//                 else if (pickSound == 1)
//                     pop02.Play();
//             }
//             else
//             {
//                 // testLight.color = Color.red;
//                 health1--;
//             }
//         }
//         else if (Input.GetKeyDown(KeyCode.A))
//         {
//             if (arrowLeft1.isTriggeredA == true)
//             {
//                 // testLight.color = Color.green;
//                 Destroy(arrowLeft1.bubble);
//                 score1++;
//                 int pickSound = Random.Range(0,2);
//                 if (pickSound == 0)
//                     pop01.Play();
//                 else if (pickSound == 1)
//                     pop02.Play();
//             }
//             else
//             {
//                 // testLight.color = Color.red;
//                 health1--;
//             }
//         }
//         else if (Input.GetKeyDown(KeyCode.D))
//         {
//             if (arrowRight1.isTriggeredA == true)
//             {
//                 // testLight.color = Color.green;
//                 Destroy(arrowRight1.bubble);
//                 score1++;
//                 int pickSound = Random.Range(0,2);
//                 if (pickSound == 0)
//                     pop01.Play();
//                 else if (pickSound == 1)
//                     pop02.Play();
//             }
//             else
//             {
//                 // testLight.color = Color.red;
//                 health1--;
//             }
//         }
//     }

//     void Player2Input()
//     {
//         if (Input.GetKeyDown(KeyCode.UpArrow))
//         {
//             if (arrowUp2.isTriggeredA == true)
//             {
//                 // testLight.color = Color.green;
//                 Destroy(arrowUp2.bubble);
//                 score2++;
//                 int pickSound = Random.Range(0,2);
//                 if (pickSound == 0)
//                     pop01.Play();
//                 else if (pickSound == 1)
//                     pop02.Play();
//             }
//             else
//             {
//                 // testLight.color = Color.red;
//                 health2--;
//                 // Debug.Log(health2);
//             }
//         }
//         else if (Input.GetKeyDown(KeyCode.DownArrow))
//         {
//             if (arrowDown2.isTriggeredA == true)
//             {
//                 // testLight.color = Color.green;
//                 Destroy(arrowDown2.bubble);
//                 score2++;
//                 int pickSound = Random.Range(0,2);
//                 if (pickSound == 0)
//                     pop01.Play();
//                 else if (pickSound == 1)
//                     pop02.Play();
//             }
//             else
//             {
//                 // testLight.color = Color.red;
//                 health2--;
//             }
//         }
//         else if (Input.GetKeyDown(KeyCode.LeftArrow))
//         {
//             if (arrowLeft2.isTriggeredA == true)
//             {
//                 // testLight.color = Color.green;
//                 Destroy(arrowLeft2.bubble);
//                 score2++;
//                 int pickSound = Random.Range(0,2);
//                 if (pickSound == 0)
//                     pop01.Play();
//                 else if (pickSound == 1)
//                     pop02.Play();
//             }
//             else
//             {
//                 // testLight.color = Color.red;
//                 health2--;
//             }
//         }
//         else if (Input.GetKeyDown(KeyCode.RightArrow))
//         {
//             if (arrowRight2.isTriggeredA == true)
//             {
//                 // testLight.color = Color.green;
//                 Destroy(arrowRight2.bubble);
//                 score2++;
//                 int pickSound = Random.Range(0,2);
//                 if (pickSound == 0)
//                     pop01.Play();
//                 else if (pickSound == 1)
//                     pop02.Play();
//             }
//             else
//             {
//                 // testLight.color = Color.red;
//                 health2--;
//             }
//         }
//     }
// }