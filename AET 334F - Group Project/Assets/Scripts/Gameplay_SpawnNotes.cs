using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author : Isaiah Bernal
public class Gameplay_SpawnNotes : MonoBehaviour
{
    // These are used to tell the spawning bubbles where to spawn so they properly spawn underneath the arrows
    [SerializeField] private Transform arrowUpPos;
    [SerializeField] private Transform arrowDownPos;
    [SerializeField] private Transform arrowLeftPos;
    [SerializeField] private Transform arrowRightPos;
    [SerializeField] private GameObject gameplayCanvas;

    // Gameplay variable so we can check player health
    [SerializeField] private Input_Gameplay currentHealth;

    // These are the variables for the prefabs in case we have notes that look different from eachother
    public GameObject noteUp;
    public GameObject noteDown;
    public GameObject noteLeft;
    public GameObject noteRight;

    // This is the game object we'll assign to whatever note we spawn
    private GameObject chosenNote;

    // Used to keep the coroutine running
    bool isSpawning = true;
    private bool stop;

    // The values for the minimum and maximum time between note spawns
    private float minSpawnTime = .66f;
    private float maxSpawnTime = .67f;

    void OnEnable()
    {
        StartCoroutine("SpawnNotes");
    }

    void Update()
    {
        if (currentHealth.health <= 0)
            StopCoroutine("SpawnNotes");
    }

    IEnumerator SpawnNotes()
    {
        while (isSpawning)
        {
            // Debug.Log ("Coroutining");

            // Rolling for which note (up, down, left, right) we want to spawn
            int whichNote = Random.Range (0, 4);

            // Rolling for the time between the next note spawn
            float waitTime = Random.Range (minSpawnTime, maxSpawnTime);

            switch (whichNote)
            {
                case (0):
                    chosenNote = noteUp;
                    chosenNote.transform.position = new Vector2 (arrowUpPos.transform.position.x, arrowUpPos.transform.position.y - 1000);
                    break;
                case (1):
                    chosenNote = noteDown;
                    chosenNote.transform.position = new Vector2 (arrowDownPos.transform.position.x, arrowDownPos.transform.position.y - 1000);
                    break;
                case (2):
                    chosenNote = noteLeft;
                    chosenNote.transform.position = new Vector2 (arrowLeftPos.transform.position.x, arrowLeftPos.transform.position.y - 1000);
                    break;
                case (3):
                    chosenNote = noteRight;
                    chosenNote.transform.position = new Vector2 (arrowRightPos.transform.position.x, arrowRightPos.transform.position.y - 1000);
                    break;
            }
            GameObject spawnedNote = Instantiate (chosenNote, chosenNote.transform.position, chosenNote.transform.rotation);
            spawnedNote.transform.SetParent(gameplayCanvas.transform);
            spawnedNote.AddComponent<Gameplay_MoveNote>();
            yield return new WaitForSeconds (waitTime);
        }
    }
}