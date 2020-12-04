using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Gameplay_MoveNote : MonoBehaviour
{
    // The speed at which notes move across the screen
    private float speed = 15f;

    void Update()
    {
        // Moving the notes every frame
        transform.position = new Vector2 (transform.position.x, transform.position.y + speed);
    }
}
