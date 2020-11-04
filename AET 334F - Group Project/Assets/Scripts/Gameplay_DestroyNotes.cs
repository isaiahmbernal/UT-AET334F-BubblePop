using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay_DestroyNotes : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");
        if (other.gameObject.tag == "Note")
            Destroy(other.gameObject);
    }
}