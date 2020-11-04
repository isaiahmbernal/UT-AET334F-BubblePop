using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay_MoveNote : MonoBehaviour
{
    public float speed = 4f;

    void Update()
    {
        transform.position = new Vector2 (transform.position.x, transform.position.y + speed);
    }
}
